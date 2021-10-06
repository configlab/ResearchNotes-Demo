using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DonetFrm.Test.Demo
{
    /// <summary>
    /// author: http://config.net.cn
    /// project site:https://github.com/configlab/ResearchNotes-Demo
    /// description:use CallContext in  .net framework with System.Runtime.Remoting.Messaging.CallContext
    /// create date: 2021-10-6
    /// </summary>
    public class CallContextTest_Framework
    {
        public void Test()
        {
            CallContext.LogicalSetData("entry_method", "test");
            Console.WriteLine($"debug-main-1:threadId={Thread.CurrentThread.ManagedThreadId},entry_method={CallContext.LogicalGetData("entry_method")}");
            Task _task = new Task(() => {
                CallContext.LogicalSetData("set_from_task", "true");
                Console.WriteLine($"debug-task:threadId={Thread.CurrentThread.ManagedThreadId},entry_method={CallContext.LogicalGetData("entry_method")}");
            });
            _task.Start();
            new Thread(new ThreadStart(() => {
                CallContext.LogicalSetData("set_from_subthread", "true");
                Console.WriteLine($"debug-subthread:threadId={Thread.CurrentThread.ManagedThreadId},entry_method={CallContext.LogicalGetData("entry_method")}");
            })).Start();
            Thread.Sleep(5000);
            Console.WriteLine($"debug-main-2:threadId={Thread.CurrentThread.ManagedThreadId},entry_method={CallContext.LogicalGetData("entry_method")},set_from_task={CallContext.GetData("set_from_task")},set_from_subthread={CallContext.GetData("set_from_subthread")}");
        }
    }
}
