using CoreLab.LibHarmony.HookDemo;
using HarmonyLib;
using System;
using System.Reflection;

namespace CoreLab.LibHarmony
{
    /// author: http://config.net.cn
    /// project site:https://github.com/configlab/ResearchNotes-Demo
    /// description:as a business process class
    /// create date: 2021-10-6
    class Program
    {
        static void Main(string[] args)
        {
            InitHook();
            TestBusiness tb = new TestBusiness();
            tb.DoWork("dowork.entry");
        }
        private static void InitHook()
        {
            Harmony.DEBUG = true;
            InjectWithoutParams.AddInjectMethod();
            var harmony = new Harmony("cn.net.config.configlab");
            var assembly = Assembly.GetExecutingAssembly();
            harmony.PatchAll(assembly);//批量对那些基于特性标注了要修改替换的方法进行修改
        }
    }
}
