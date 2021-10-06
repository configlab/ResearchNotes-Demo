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
	/// description:update arguments inner method
	/// create date: 2021-10-6
	/// </summary>
	[HarmonyPatch(typeof(TestBusiness), nameof(TestBusiness.GetTopic))]
	public class UpdateArgumentsOfMethod
    {
		/// <summary>
		/// Reading and changing arguments
		/// </summary>
		/// <param name="type"></param>
		public static void Prefix(ref string type)
		{
			type = "Prefix.type（IL中参数被修改)";
		}
	}
}
