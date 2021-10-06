using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreLab.LibHarmony.HookDemo
{
	/// <summary>
	/// author: http://config.net.cn
	/// project site:https://github.com/configlab/ResearchNotes-Demo
	/// description:inject method before or after target method
	/// create date: 2021-10-6
	/// </summary>
	public class InjectWithoutParams
    {
		public static void AddInjectMethod()
		{
			var harmony = new Harmony("CoreLab.LibHarmony.TestHook.DoPatching");
			//
			var mOriginal = AccessTools.Method(typeof(TestBusiness), "DoWork");
			var mPrefix = SymbolExtensions.GetMethodInfo(() => InjectPrefix());
			var mPostfix = SymbolExtensions.GetMethodInfo(() => InjectPostfix());
			// in general, add null checks here (new HarmonyMethod() does it for you too
			harmony.Patch(mOriginal, new HarmonyMethod(mPrefix), new HarmonyMethod(mPostfix));
			//harmony.Patch(mOriginal,null, new HarmonyMethod(mPostfix));
		}
		private static void InjectPrefix()
		{
			Console.WriteLine("TestHook.InjectPrefix(IL中插入在目标方法前的方法)");
		}
		private static void InjectPostfix()
		{
			Console.WriteLine("TestHook.InjectPostfix(IL中插入在目标方法后的方法)");
		}
	}
}
