using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreLab.LibHarmony
{
    /// <summary>
    /// author: http://config.net.cn
    /// project site:https://github.com/configlab/ResearchNotes-Demo
    /// description:as a business process class
    /// create date: 2021-10-6
    /// </summary>
    public class TestBusiness
    {
        public string GetTopic(string type)
        {
            return $"{type}:配置啦专注于环境安装与配置";
        }
        public string GetName()
        {
            return $"配置啦";
        }
        public void DoWork(string msg)
        {
            Console.WriteLine($"TestBusiness.DoWork:\r\nname={GetName()}\r\ntopic:{GetTopic("default")}\r\nmsg={msg}");
        }
    }
}
