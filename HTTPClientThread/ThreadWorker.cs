using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.ComponentModel;


namespace HTTPClientThread
{

    class ThreadWorker
    {
            private AsyncOperation op; // async operation representing the work item
            private SimpleObj ARec; // variable to store the request and response details
            public event EventHandler<WorkItemCompletedEventArgs> Completed; //event handler to be run when work has completed with a result


            // constructor for the thread. Takes param ID index of the Listview to keep track of.
            public ThreadWorker(SimpleObj Rec)
            {
                ARec = Rec;                
            }

            public void DoWork()
            {
                //get new async op object calling forms sync context
                this.op = AsyncOperationManager.CreateOperation(null);
                //queue work so a thread from the thread pool can pick it up and execute it
                ThreadPool.QueueUserWorkItem((o) => this.PerformWork(ARec));
            }

            private async void PerformWork(SimpleObj rec)
            {
                // call the main work method and wait for it to return
                SimpleObj resultObj = await Shared.SendWebRequest(rec);
                ARec.ResultCode = resultObj.ResultCode;
                ARec.XMLData = resultObj.XMLData;
                //once completed, call the "post completed" method, passing in the result received
                PostCompleted();
            }

            private void PostCompleted() 
            {
                // call OnCompleted, passing in the SimpleObj result to it, the lambda passed into this method is invoked in the context of the form UI
                op.PostOperationCompleted((o) => this.OnCompleted(new WorkItemCompletedEventArgs(ARec)), ARec);
            }


            protected virtual void OnCompleted(WorkItemCompletedEventArgs Args)
            {
                //raise the Completed event in the context of the form 
                EventHandler<WorkItemCompletedEventArgs> temp = Completed;
                if (temp != null)
                {
                    temp.Invoke(this, Args);
                }
            }


    }




    //event argument that contains the result of each threads work to be passed back to the main UI thread
    public class WorkItemCompletedEventArgs : EventArgs
    {
        // SimpleObj is declared in the "Shared" file and used to pass simple data around
        public SimpleObj Result { get; set; }

        // Constructor takes parameters that will be used to store informaiton we need to update the main UI on completion
        public WorkItemCompletedEventArgs(SimpleObj result)
        {
            this.Result = result;
        }
    }

}
