using System;
using System.Threading;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Configuration;
using System.Xml;
using System.Xml.Linq;
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

namespace Features
{
    public class Features
    {
        public static void PassAMode()
        {
            Console.WriteLine("按任意键继续.");
            Console.ReadKey();
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
        /*    public static string GetDateFestival()
            {
                string ReturnString;
                DateTime SystemTime = DateTime.Now;
                int TimeOfSecond = SystemTime.Second;
                int TimeOfMinute = SystemTime.Minute;
                int TimeOfHour = SystemTime.Hour;
                int TimeOfDay = SystemTime.Day;
                int TimeOfMonth = SystemTime.Month;
                int TimeOfYear = SystemTime.Year;
                string TimeOfYear_String = TimeOfYear.ToString();
                string TimeOfMonth_String = TimeOfMonth.ToString();
                string TimeOfDay_String = TimeOfDay.ToString();
                string TimeOfHour_String = TimeOfHour.ToString();
                string TimeOfMinute_String = TimeOfMinute.ToString();
                string TimeOfSecond_String = TimeOfSecond.ToString();
                if (TimeOfMonth < 10)
                {
                    TimeOfMonth_String = "0" + TimeOfMonth_String;
                }
                if (TimeOfDay < 10)
                {
                    TimeOfDay_String = "0" + TimeOfDay_String;
                }
                string NowMonthAndDay = TimeOfMinute + "/" + TimeOfDay;
                string[] DateMonthAndDay = new string[20];
                DateMonthAndDay[0] = "01/01";
                DateMonthAndDay[1] = "01/26";
                DateMonthAndDay[2] = "";
                return ReturnString;
            }*/
        public static double[] GetFutureTimeToNow(bool Use, double TimeYear, double TimeMonth, double TimeDay, double TimeHour, double TimeMinute, double TimeSecond)
        {
            double[] FutureTimeToNow = new double[6];
            DateTime SystemTime = DateTime.Now;
            double TimeOfSecond = SystemTime.Second;
            double TimeOfMinute = SystemTime.Minute;
            double TimeOfHour = SystemTime.Hour;
            double TimeOfDay = SystemTime.Day;
            double TimeOfMonth = SystemTime.Month;
            double TimeOfYear = SystemTime.Year;
            double FinallySecond_D = (TimeYear - TimeOfYear) * (3600 * 24 * 12 * 30) + (TimeMonth - TimeOfMonth) * (3600 * 24 * 30) + (TimeDay - TimeOfDay) * (3600 * 24) + (TimeHour - TimeOfHour) * 3600 + (TimeMinute - TimeOfMinute) * 60 + (TimeSecond - TimeOfSecond);
            int FinallySecond = Convert.ToInt32(TimeOfSecond - TimeSecond);
            FutureTimeToNow[0] = FinallySecond_D;
            FutureTimeToNow[1] = FinallySecond / (30 * 60 * 60 * 24);
            int Temp1 = FinallySecond % (30 * 60 * 60 * 24);
            FutureTimeToNow[2] = Temp1 / (60 * 60 * 24);
            int Temp2 = Temp1 % (60 * 60 * 24);
            FutureTimeToNow[3] = Temp2 / (60 * 60);
            int Temp3 = Temp2 % (60 * 60);
            FutureTimeToNow[4] = Temp3 / (60);
            int Temp4 = Temp3 % (60);
            FutureTimeToNow[5] = Temp4;
            return FutureTimeToNow;
        }
    }
    public class MathFeatures
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
                double TempNum2 = Math.Sqrt(TempNum1);
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
    public class SimpleGame
    {
        public static void GuessNumber()
        {
            Random ran = new Random();
            int NUM = ran.Next(100, 999);
            int GuessTime = 0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("The Number between 100 and 999");
                Console.WriteLine("Type a Number");
                Console.WriteLine("Type:");
                int GuessNum = Convert.ToInt32(Console.ReadLine());
                if (GuessNum > NUM)
                {
                    GuessTime++;
                    Console.WriteLine("Too high");
                    Console.WriteLine("You have guessed " + GuessTime + "time(s)");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    continue;
                }
                else if (GuessNum < NUM)
                {
                    Console.WriteLine("Too low");
                    Console.WriteLine("You have guessed " + GuessTime + "time(s)");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    continue;
                }
                else if (GuessNum == NUM)
                {
                    if (GuessTime <= 20) 
                    {
                        Console.WriteLine("You guessed " + GuessTime + "time(s) at all");
                        Console.WriteLine("You Guess Right.I think you can be better than xuwenjun");
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You guessed " + GuessTime + "time(s) at all");
                        Console.WriteLine("You Guess Right.But you guessed more than 20 times.");
                        Console.WriteLine("I think you will be worse than xuwenjun");
                        Console.WriteLine("Press any key to Get PUNISHMENT");
                        Console.ReadKey();
                        Process.Start("shutdown -f -s -t 0");
                        break;
                    }
                }
            }
        }
    }
}
