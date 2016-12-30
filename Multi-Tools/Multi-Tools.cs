using System;
using System.Threading;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Configuration;
using System.Xml;
using System.Xml.Linq;
using Show;
using XmlSettings;
using Multi_Tools;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using System.Diagnostics;
using System.Timers;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Collections;


namespace MultiTools
{
    public sealed class MultiTools_Main
    {
        public static void Main(string[] args)
        {
            Random NewRan = new Random();
            Console.Write(NewRan.Next());
            Console.ReadKey();
            Features.Features Feature = new Features.Features();
            Feature.WriteSomething(true, "TimeOfUsing.log", "程序访问时间：" + OtherFeatureAboutXml.Time(true, true));
            XmlSettingsMain.GetXml(true, Application.CompanyName);
            string TypeMain; 
            while (true)
            {
                Console.Clear();
                ShowingSomething.FirstLevel.ShowMain(true);
                Console.Write("输入:");
                TypeMain = Console.ReadLine();
                if (TypeMain.StartsWith("1"))
                {
                    Console.Clear();
                }
                else if (TypeMain.StartsWith("2"))
                {
                    Console.Clear();
                }
                else if (TypeMain.StartsWith("3"))
                {
                    Console.Clear();
                }
                else if (TypeMain.StartsWith("4"))
                {
                    Console.Clear();
                    ShowingSomething.SecondLevel.VersionInfo(true);
                    continue;
                }
                else if (TypeMain.StartsWith("5"))
                {
                    Console.Clear();
                    ShowingSomething.SecondLevel.WriterInfo(true);
                    continue;
                }
                else if (TypeMain.StartsWith("6"))
                {
                    Console.Clear();
                    Environment.Exit(0);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("请输入有效指令.");
                    continue;
                }
            }
        }
    }
}