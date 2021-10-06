using CoreLab.LibHarmony.HookDemo;
using HarmonyLib;
using System;
using System.Reflection;

namespace CoreLab.LibHarmony
{
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
            harmony.PatchAll(assembly);
        }
    }
}
