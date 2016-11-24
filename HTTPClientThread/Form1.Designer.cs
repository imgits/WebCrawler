namespace HTTPClientThread
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.edtTimesToRun = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lvMain = new System.Windows.Forms.ListView();
            this.WebsiteURL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ResultText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chkRunThreaded = new System.Windows.Forms.CheckBox();
            this.btnRunProcess = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.edtTestServer = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblThreadCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "HTTP Thread Client";
            // 
            // edtTimesToRun
            // 
            this.edtTimesToRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtTimesToRun.Location = new System.Drawing.Point(16, 80);
            this.edtTimesToRun.Name = "edtTimesToRun";
            this.edtTimesToRun.Size = new System.Drawing.Size(100, 26);
            this.edtTimesToRun.TabIndex = 1;
            this.edtTimesToRun.Text = "100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of times to run";
            // 
            // lvMain
            // 
            this.lvMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvMain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.WebsiteURL,
            this.Status,
            this.ResultText});
            this.lvMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lvMain.FullRowSelect = true;
            this.lvMain.GridLines = true;
            this.lvMain.HideSelection = false;
            this.lvMain.Location = new System.Drawing.Point(17, 122);
            this.lvMain.MultiSelect = false;
            this.lvMain.Name = "lvMain";
            this.lvMain.ShowGroups = false;
            this.lvMain.Size = new System.Drawing.Size(974, 360);
            this.lvMain.TabIndex = 5;
            this.lvMain.UseCompatibleStateImageBehavior = false;
            this.lvMain.View = System.Windows.Forms.View.Details;
            // 
            // WebsiteURL
            // 
            this.WebsiteURL.Text = "Web URL Tested";
            this.WebsiteURL.Width = 253;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.Width = 145;
            // 
            // ResultText
            // 
            this.ResultText.Text = "Result text";
            this.ResultText.Width = 438;
            // 
            // chkRunThreaded
            // 
            this.chkRunThreaded.AutoSize = true;
            this.chkRunThreaded.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.chkRunThreaded.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkRunThreaded.Location = new System.Drawing.Point(20, 511);
            this.chkRunThreaded.Name = "chkRunThreaded";
            this.chkRunThreaded.Size = new System.Drawing.Size(138, 24);
            this.chkRunThreaded.TabIndex = 11;
            this.chkRunThreaded.Text = "Run threaded";
            this.chkRunThreaded.UseVisualStyleBackColor = true;
            // 
            // btnRunProcess
            // 
            this.btnRunProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRunProcess.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRunProcess.Location = new System.Drawing.Point(828, 20);
            this.btnRunProcess.Name = "btnRunProcess";
            this.btnRunProcess.Size = new System.Drawing.Size(163, 53);
            this.btnRunProcess.TabIndex = 10;
            this.btnRunProcess.Text = "Run process";
            this.btnRunProcess.UseVisualStyleBackColor = true;
            this.btnRunProcess.Click += new System.EventHandler(this.btnRunProcess_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExit.Location = new System.Drawing.Point(828, 499);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(163, 60);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(204, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Test server address";
            // 
            // edtTestServer
            // 
            this.edtTestServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtTestServer.Location = new System.Drawing.Point(207, 80);
            this.edtTestServer.Name = "edtTestServer";
            this.edtTestServer.Size = new System.Drawing.Size(318, 26);
            this.edtTestServer.TabIndex = 13;
            this.edtTestServer.Text = "http://localhost:4174/Home/GetXML";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblStatus.Location = new System.Drawing.Point(188, 512);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(127, 20);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.Text = "Status...  [Idle]";
            // 
            // lblThreadCount
            // 
            this.lblThreadCount.AutoSize = true;
            this.lblThreadCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblThreadCount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblThreadCount.Location = new System.Drawing.Point(188, 539);
            this.lblThreadCount.Name = "lblThreadCount";
            this.lblThreadCount.Size = new System.Drawing.Size(158, 20);
            this.lblThreadCount.TabIndex = 16;
            this.lblThreadCount.Text = "Thread count label";
            this.lblThreadCount.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 571);
            this.Controls.Add(this.lblThreadCount);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.edtTestServer);
            this.Controls.Add(this.chkRunThreaded);
            this.Controls.Add(this.btnRunProcess);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lvMain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edtTimesToRun);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edtTimesToRun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvMain;
        private System.Windows.Forms.ColumnHeader WebsiteURL;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.ColumnHeader ResultText;
        private System.Windows.Forms.CheckBox chkRunThreaded;
        private System.Windows.Forms.Button btnRunProcess;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edtTestServer;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblThreadCount;
    }
}

