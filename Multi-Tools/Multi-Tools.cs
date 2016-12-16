using System;
using System.Threading;
using System.Windows.Forms;
using System.Net.Mail;
using System.Configuration;
using System.Xml;
using System.Xml.Linq;
using Show;
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
                ShowSomething.FirstLevel.ShowMain(true);
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
                    ShowSomething.SecondLevel.VersionInfo(true);
                    continue;
                }
                else if (TypeMain.StartsWith("5"))
                {
                    Console.Clear();
                    ShowSomething.SecondLevel.WriterInfo(true);
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
}