using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTTPClientThread
{
    public partial class Main : Form
    {

        private int RunningThreadCount;
        private int RunTimes;
        private int TimeStart;

        public Main()
        {
            InitializeComponent();
        }

        private void btnRunProcess_Click(object sender, EventArgs e)
        {
            TimeStart = System.Environment.TickCount;
            InitProcess();
            if (chkRunThreaded.Checked)
                RunProcessThreaded();
            else RunProcess();
        }

        // set up some default values
        public void InitProcess()
        {
            btnExit.Enabled = false;
            btnRunProcess.Enabled = false;
            chkRunThreaded.Enabled = false;
            RunTimes = int.Parse(edtTimesToRun.Text);
            FillListView();

            RunningThreadCount = 0;
        }

        // fill the ListView with the count items
        public void FillListView()
        {
            lvMain.Items.Clear();
            for (int i = 0; i < RunTimes; i++)
            {
                ListViewItem itm = new ListViewItem();
                itm.Text = (i+1).ToString();
                itm.SubItems.Add("Pending");
                itm.SubItems.Add("-");
                itm.SubItems.Add("-");
                lvMain.Items.Add(itm);
            }
        }

        public async void RunProcess()
        {
            for (int i = 0; i < RunTimes; i++)
            {
                updateStatusLabel("Processing: " + (i + 1).ToString() + "/" + RunTimes.ToString());
                lvMain.Items[i].Selected = true;
                lvMain.Items[i].EnsureVisible();
                lvMain.Items[i].SubItems[1].Text = "Processing...";
                SimpleObj result = await Shared.SendWebRequest(new SimpleObj() { ItemID = i.ToString(), WebURL = edtTestServer.Text});
                lvMain.Items[i].SubItems[1].Text = result.ResultCode;
                if (result.ResultCode == "ERR")
                    lvMain.Items[i].SubItems[2].Text = result.Message;
            }
            CleanUp();
        }

        private void CleanUp()
        {
            btnExit.Enabled = true;
            btnRunProcess.Enabled = true;
            chkRunThreaded.Enabled = true;
            lblThreadCount.Visible = false;
            updateStatusLabel("Status: complete  (Time taken: " + UpdateTime().ToString() + ")");
        }


        public int UpdateTime()
        {
            var TimeEnd = System.Environment.TickCount;
            var TimeTaken = ((TimeEnd - TimeStart) / 1000);
            return (TimeTaken);
        }

        private void updateStatusLabel(string Status)
        {
            lblStatus.Text = Status;
            Application.DoEvents();
        }

        public void RunProcessThreaded()
        {
            updateStatusLabel("Status: threaded mode - watch thread count and list status");
            lblThreadCount.Visible = true;

            for (int i = 0; i < RunTimes; i++)
            {
                updateStatusLabel("Processing: " + (i + 1).ToString() + "/" + RunTimes.ToString());
                lvMain.Items[i].Selected = true;
                lvMain.Items[i].SubItems[1].Text = "Processing...";
                SimpleObj rec = new SimpleObj() { ItemID = i.ToString(), WebURL = edtTestServer.Text };
                CreateWorkThread(rec);
                RunningThreadCount++;
                UpdateThreadCount();
            }
        }


        public void CreateWorkThread(SimpleObj rec)
        {
            ThreadWorker item = new ThreadWorker(rec);
            //subscribe to be notified when result is ready
            item.Completed += WorkThread_Completed;
            item.DoWork();
        }

        //handler method to run when work has completed
        private void WorkThread_Completed(object sender, WorkItemCompletedEventArgs e)
        {
                lvMain.Items[int.Parse(e.Result.ItemID)].SubItems[1].Text = e.Result.ResultCode;
                if (e.Result.ResultCode == "ERR")
                    lvMain.Items[int.Parse(e.Result.ItemID)].SubItems[2].Text = e.Result.Message;

                RunningThreadCount--;
                UpdateThreadCount();

                if (RunningThreadCount == 0)
                {
                    CleanUp();
                }

        }

        private void UpdateThreadCount()
        {
            lblThreadCount.Text = "Running threads: " + RunningThreadCount.ToString();
        }


    }
}
