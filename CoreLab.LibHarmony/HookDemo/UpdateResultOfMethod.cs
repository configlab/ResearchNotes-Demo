using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

namespace CoreLab.LibHarmony.HookDemo
{
	/// <summary>
	/// author: http://config.net.cn
	/// project site:https://github.com/configlab/ResearchNotes-Demo
	/// description:update the return result of method before exit function
	/// create date: 2021-10-6
	/// </summary>
	[HarmonyPatch(typeof(TestBusiness), nameof(TestBusiness.GetName))]
	public class UpdateResultOfMethod
	{
        public static void Postfix(ref string __result)
        {
            __result = "配置啦(config.net.cn)--IL中方法的返回值被修改";
        }
	}
}
