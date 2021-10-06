using ConfigLab.CallContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DonetFrm.Test.Demo
{
    /// <summary>
    /// author: http://config.net.cn
    /// project site:https://github.com/configlab/ResearchNotes-Demo
    /// description:use CallContext in  .net framework with cross platform solution
    /// create date: 2021-10-6
    /// </summary>
    public class CallContextTest_CrossPlatform
    {
        public void Test()
        {
            CallContext.SetData("entry_method", "test");
            Console.WriteLine($"debug-main-1:threadId={Thread.CurrentThread.ManagedThreadId},entry_method={CallContext.GetData("entry_method")}");
            Task _task = new Task(() => {
                CallContext.SetData("set_from_task", "true");
                Console.WriteLine($"debug-task:threadId={Thread.CurrentThread.ManagedThreadId},entry_method={CallContext.GetData("entry_method")}");
            });
            _task.Start();
            new Thread(new ThreadStart(() => {
                CallContext.SetData("set_from_subthread", "true");
                Console.WriteLine($"debug-subthread:threadId={Thread.CurrentThread.ManagedThreadId},entry_method={CallContext.GetData("entry_method")}");
            })).Start();
            Thread.Sleep(5000);
            Console.WriteLine($"debug-main-2:threadId={Thread.CurrentThread.ManagedThreadId},entry_method={CallContext.GetData("entry_method")},set_from_task={CallContext.GetData("set_from_task")},set_from_subthread={CallContext.GetData("set_from_subthread")}");
        }
    }
}
