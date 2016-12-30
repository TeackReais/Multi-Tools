using System;
using System.Windows.Forms;
using System.Threading;
using System.Net.Mail;
using System.Configuration;
using System.Xml;
using System.Xml.Linq;
using XmlSettings;
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

namespace Show
{
    public class ShowingSomething
    {
        public class FirstLevel
        {
            public static void ShowMain(bool Use)
            {
                if (Use == true)
                {
                    Console.WriteLine("系统时间为:" + OtherFeatureAboutXml.Time(true, AllReturn.StartUseTwelveMethod(true)));
                    Console.WriteLine("当前目录为:" + Application.StartupPath);
                    Console.WriteLine("软件版本为:" + Application.ProductVersion);
                    Console.WriteLine("软件制造商为:" + Application.CompanyName);
                    Console.WriteLine("请输入指定字符使用指定功能");
                    Console.WriteLine("1.系统功能");
                    Console.WriteLine("2.数学运算");
                    Console.WriteLine("3.系统设置");
                    Console.WriteLine("4.版本信息");
                    Console.WriteLine("5.作者说明");
                    Console.WriteLine("6.退出程序");
                    return;
                }
                else if (Use == false)
                {
                    return;
                }
            }
        }
        public class SecondLevel
        {
            public static void SystemControl(bool Use)
            {
                while (true)
                {
                    Console.WriteLine("请输入指定字符使用指定功能");
                    Console.WriteLine("1.在指定秒数后关机");
                    Console.WriteLine("2.在指定秒数后重启");
                    Console.WriteLine("3.在指定时间执行CMD命令");
                    Console.WriteLine("4.打开CMD窗口");
                }
            }
            public static void WriterInfo(bool Use)
            {
                if (Use == true)
                {
                    Console.WriteLine("联系方式:QQ1036673441");
                    Console.WriteLine("源代码位置:https://github.com/TeackReais");
                    Console.WriteLine("联系E-Mail:Teack_Reais@outlook.com");
                    Console.WriteLine("按任意键返回主菜单");
                    Console.ReadKey();
                    return;
                }
                else
                {
                    return;
                }
            }
            public static void VersionInfo(bool Use)
            {
                if (Use == true)
                {
                    Console.WriteLine("当前版本为:" + Application.ProductVersion);
                    Console.WriteLine("按任意键返回主菜单");
                    Console.ReadKey();
                    return;
                }
                else
                {
                    return;
                }
            }
        }
        public class ThirdLevel
        {

        }
    }
    public class Math_FeaturesShowing
    { 
        public static void ShowIntersection(bool Use)
        {
            if (Use == true)
            {
                Features.Features Feature = new Features.Features();
                Features.MathFeatures MathFeature = new Features.MathFeatures();
                Console.WriteLine("Y=AX^2+BX+C");
                Console.WriteLine("请输入A,B,C,系统将会无视非数字和小数。");
                Console.WriteLine("数据不超过1.79769313486232E+307,不小于-1.79769313486232E+307");
                Console.Write("A=");
                string A_String = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Y={0}X^2+BX+C", A_String);
                Console.WriteLine("请输入A,B,C,系统将会无视非数字和小数。");
                Console.WriteLine("数据不超过1.79769313486232E+307,不小于-1.79769313486232E+307");
                Console.Write("B=");
                string B_String = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Y={0}X^2+{1}X+C", A_String, B_String);
                Console.WriteLine("请输入A,B,C,系统将会无视非数字和小数。");
                Console.WriteLine("数据不超过1.79769313486232E+307,不小于-1.79769313486232E+307");
                Console.Write("C=");
                string C_String = Console.ReadLine();
                Console.Clear();
                double A = Feature.DelAnyWord(true, false, A_String);
                double B = Feature.DelAnyWord(true, false, B_String);
                double C = Feature.DelAnyWord(true, false, C_String);
                Features.MathFeatures.Quadratic_Function Quadratic_Function = new Features.MathFeatures.Quadratic_Function();
                double[] JiaoDian = Quadratic_Function.Get_Intersection(A, B, C);
                Console.WriteLine("Y={A}X^2+{B}X+{C}");
                Console.WriteLine("与X轴交点为({0},{1})", JiaoDian[0], JiaoDian[1]);
                Console.WriteLine("与Y轴交点1为({0},{1})", JiaoDian[2], JiaoDian[3]);
                Console.WriteLine("与Y轴交点2为({0},{1})", JiaoDian[4], JiaoDian[5]);
                Console.ReadKey();
                return;
            }
            else
            {
                return;
            }
        }
    }
    public class FeaturesShowing
    {
        public static void ShowingTimeAndSaveUseTime(bool Use)
        {

        }
    }
}
