using System;
using System.Threading;
using System.Windows.Forms;
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


namespace MultiTools
{
    public sealed class MultiTools_Main
    {
        public static void Main(string[] args)
        {
            OtherAboutMultiTools.Features Feature = new OtherAboutMultiTools.Features();
            Feature.WriteSomething(true, "TimeOfUsing.log", "程序访问时间：" + OtherFeatureAboutXml.Time(true, true));
            XmlSettingsMain.GetXml(true, Application.CompanyName);
            string TypeMain;
            while (true)
            {
                Console.Clear();
                OtherAboutMultiTools.ShowOfMultiTools.FirstLevel.ShowMain(true);
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
                    OtherAboutMultiTools.ShowOfMultiTools.SecondLevel.VersionInfo(true);
                    continue;
                }
                else if (TypeMain.StartsWith("5"))
                {
                    Console.Clear();
                    OtherAboutMultiTools.ShowOfMultiTools.SecondLevel.WriterInfo(true);
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
    sealed class OtherAboutMultiTools
    {
        public class ShowOfMultiTools
        {
            public class FirstLevel
            {
                public static void ShowMain(bool Use)
                {
                    if (Use == true)
                    {
                        GetValueFromSystem GetValue = new GetValueFromSystem();
                        Console.WriteLine("系统时间为:" + OtherFeatureAboutXml.Time(true, AllReturn.StartUseTwelveMethod(true)));
                        Console.WriteLine("当前目录为:" + GetValue.PathOfDocument);
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
            public static void ShowIntersection(bool Use)
            {
                if (Use == true)
                {
                    Features Feature = new Features();
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
                    Features.Math.Quadratic_Function Quadratic_Function = new Features.Math.Quadratic_Function();
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
        public class Features
        {
            public class Math
            {
                /// <summary>
                /// 包括根据任意五个数字求另一个数字,和求交点问题
                /// </summary>
                public class Quadratic_Function
                {
                    /// <summary>
                    /// 数组0，1为Y轴交点，数组2，3为X轴交点1，数组4，5为X轴交点2
                    /// </summary>
                    public double[] Get_Intersection(double A, double B, double C)
                    {
                        double[] ReturnNum = new double[6];
                        ReturnNum[0] = C;
                        ReturnNum[1] = 0;
                        double TempNum1 = B * B - (4 * A * C);
                        double TempNum2 = System.Math.Sqrt(TempNum1);
                        double TheB = -1 * B;
                        double XZhouJiaoDian1 = (TheB + TempNum2) / 2 / A;
                        double XZhouJiaoDian2 = (TheB - TempNum2) / 2 / A;
                        ReturnNum[2] = XZhouJiaoDian1;
                        ReturnNum[3] = 0;
                        ReturnNum[4] = XZhouJiaoDian2;
                        ReturnNum[5] = 0;
                        return ReturnNum;
                    }
                }
                /// <summary>
                /// 幂的运算
                /// </summary>
                /// <param name="Use">是否使用</param>
                /// <param name="Base">底数</param>
                /// <param name="Index">次数</param>
                /// <returns></returns>
                public int Power(bool Use, int Base, int Index)
                {
                    int? Int_Null = null;
                    if (Use == true)
                    {
                        int GetPower = 1;
                        if (Base != 0 && Index >= 0)
                        {
                            while (true)
                            {
                                if (Index > 0)
                                {
                                    GetPower = Base * GetPower;
                                    Index--;
                                    continue;
                                }
                                else if (Index == 0)
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("编译错误!!");
                                    return (int)Int_Null;
                                }
                            }
                            return GetPower;
                        }
                        else if (Base != 0 && Index < 0)
                        {
                            while (true)
                            {
                                if (Index > 0)
                                {
                                    GetPower = Base * GetPower;
                                    Index--;
                                    continue;
                                }
                                else if (Index == 0)
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("编译错误!!");
                                    return (int)Int_Null;
                                }
                            }
                            return 1 / GetPower;
                        }
                        else if (Index == 0)
                        {
                            if (Base == 0)
                            {
                                Console.WriteLine("0的0次方无法运算。");
                                return (int)Int_Null;
                            }
                            else
                            {
                                return 1;
                            }
                        }
                        else
                        {
                            Console.WriteLine("编译错误!!");
                            return (int)Int_Null;
                        }
                    }
                    else
                    {
                        return (int)Int_Null;
                    }
                }
                public bool JudgmentXiaoShu(double Num)
                {
                    foreach (char EveryWord in Num.ToString())
                    {
                        if (EveryWord != '.')
                        {
                            continue;
                        }
                        else
                        {
                            return true;
                        }
                    }
                    return false;
                }
            }
            class TheStoryOfThreeKingdoms
            {

            }
            public double DelAnyWord(bool Use, bool UseNotes, string str)
            {
                int? Int_Null = null;
                if (Use == true)
                {
                    int FalseNum = 0;
                    string StrNumOfStr = "";
                    foreach (char ACharOfString in str)
                    {
                        if (ACharOfString == '1' || ACharOfString == '2' || ACharOfString == '3' || ACharOfString == '4' || ACharOfString == '5' || ACharOfString == '6' || ACharOfString == '7' || ACharOfString == '8' || ACharOfString == '9' || ACharOfString == '0' || ACharOfString == '.')
                        {
                            StrNumOfStr = StrNumOfStr + ACharOfString;
                            continue;
                        }
                        else
                        {
                            FalseNum++;
                            continue;
                        }
                    }
                    if (FalseNum != 0 && UseNotes == false)
                    {
                        Console.WriteLine("错误共{0}处.", FalseNum);
                        double IntNumOfStr = Convert.ToDouble(StrNumOfStr);
                        return IntNumOfStr;
                    }
                    else
                    {
                        double IntNumOfStr = Convert.ToDouble(StrNumOfStr);
                        return IntNumOfStr;
                    }
                }
                else if (Use == false)
                {
                    return (int)Int_Null;
                }
                else
                {
                    Console.WriteLine("编译错误!!");
                    return (int)Int_Null;
                }
            }
            public void CountDown(bool Use, bool UseNotes, int Max, int Least)
            {
                if (Use == true)
                {
                    if (UseNotes == true)
                    {
                        int ConstTime = Max;
                        while (true)
                        {
                            if (Least <= Max)
                            {
                                Console.WriteLine("当前循环数为{0},减去前为{1}。", ConstTime - Max, Max);
                                Max--;
                                Console.WriteLine("当前循环数为{0},减去后为{1}。", ConstTime - Max + 1, Max);
                                Console.WriteLine("进入下一个循环。");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("循环结束,按任意键退出程序。");
                                Console.ReadKey();
                                break;
                            }
                        }
                        return;
                    }
                    else if (UseNotes == false)
                    {
                        while (true)
                        {
                            if (Least <= Max)
                            {
                                Console.WriteLine("{0}", Max);
                                Max--;
                                continue;
                            }
                            else
                            {
                                break;
                            }
                        }
                        return;
                    }
                    else
                    {
                        Console.WriteLine("编译错误!!");
                        return;
                    }
                }
                else if (Use == false)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("编译错误!!");
                    return;
                }
            }
            public void ShowString(string Show_String, int ShowTime)
            {
                char[] Show_Chars = Show_String.ToCharArray();
                int Num = Show_String.Length;
                foreach (char EveryWord in Show_String)
                {
                    Console.Write(EveryWord);
                    Thread.Sleep(ShowTime);
                }
                return;
            }
            public void WriteSomething(bool Use, string Path, string Value)
            {
                if (Use == true)
                {
                    StreamWriter Writer = new StreamWriter(Path, true);
                    Writer.WriteLine(Value);
                    Writer.Close();
                }
                else
                {
                    return;
                }
            }
            public void SenseOfTechnology(bool Use, string FileName)
            {
                Console.WriteLine("科技感功能将在10秒后开始。");
                Console.WriteLine("系统将在开始后在目录下创建文件。");
                Console.WriteLine("请手动关闭");
                int NowNum = 10;
                int Now = 1;
                while (true)
                {
                    if (Now < 11)
                    {
                        Console.WriteLine(NowNum);
                        Thread.Sleep(1000);
                        Now++;
                        NowNum--;
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                Random Ran = new Random();
                Features Feature = new Features();
                int i;
                while (true)
                {
                    switch (Ran.Next(2))
                    {
                        case 0:
                            {
                                i = 0;
                                Console.Write(i);
                                Feature.WriteSomething(true, FileName, "0");
                                break;
                            }
                        case 1:
                            {
                                i = 1;
                                Console.Write(i);
                                Feature.WriteSomething(true, FileName, "1");
                                break;
                            }
                    }
                }
            }
        }
    }
    class GetValueFromSystem
        {
            private string _PathOfDocument = Application.StartupPath;
            public string PathOfDocument
            {
                get
                {
                    return _PathOfDocument;
                }
            }
        }
    
}