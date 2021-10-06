using DonetFrm.Test.Demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonetFrm.Test
{
    /// author: http://config.net.cn
    /// project site:https://github.com/configlab/ResearchNotes-Demo
    /// description:use CallContext in .net framework with cross platform solution or System.Runtime.Remoting.Messaging.CallContext
    /// create date: 2021-10-6
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(".net framework: System.Runtime.Remoting.Messaging.CallContext");
            CallContextTest_Framework cctf = new CallContextTest_Framework();
            cctf.Test();
            Console.WriteLine("\r\n\r\n.net core:ConfigLab.CallContext.CallContext");
            CallContextTest_CrossPlatform cctc = new CallContextTest_CrossPlatform();
            cctc.Test();
            Console.ReadLine();
        }
    }
}
