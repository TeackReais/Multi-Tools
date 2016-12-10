using System;
using System.Threading;
using System.Windows.Forms;
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


namespace MultiTools
{
    public sealed class MultiTools_Main
    {
        public static void Main(string[] args)
        {
            OtherAboutMultiTools.Features Feature = new OtherAboutMultiTools.Features();
            OtherAboutMultiTools.ShowOfMultiTools.XmlSettingsShow.GetXml(true);
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
                        Console.WriteLine("系统时间为:" + Time(true, true));
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
            public class XmlSettingsShow
            {
                public static void GetXml(bool Use)
                {
                    if (Use == true)
                    {
                        try
                        {
                            StartSetColor(true, Features.UseSettings.GetXmlString("Settings.xml", "Settings", "UseColor"));
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("欢迎第一次使用本程序.");
                            Console.WriteLine("欢迎使用设置.");
                            Console.ReadKey();
                            Features.UseSettings.CreateXmlFile();
                            Console.ReadKey();
                            Application.Restart();
                        }
                        finally
                        {
                            Password(Features.UseSettings.GetXmlTrueOrFalse("Settings.xml", "Settings", "UsePassword"), "Kaixu");
                        }
                        return;
                    }
                    else
                    {
                        return;
                    }
                }
                public static void StartSetColor(bool Use, string TheGetColorValue)
                {
                    if (Use == true)
                    {
                        switch (TheGetColorValue)
                        {
                            case "Black":
                                {
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    break;
                                }
                            case "Blue":
                                {
                                    Console.BackgroundColor = ConsoleColor.Blue;
                                    break;
                                }
                            case "Cyan":
                                {
                                    Console.BackgroundColor = ConsoleColor.Cyan;
                                    break;
                                }
                            case "DarkBlue":
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                                    break;
                                }
                            case "DarkCyan":
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                                    break;
                                }
                            case "DarkGray":
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkGray;
                                    break;
                                }
                            case "DarkGreen":
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                                    break;
                                }
                            case "DarkMagenta":
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                                    break;
                                }
                            case "DarkRed":
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkRed;
                                    break;
                                }
                            case "DarkYellow":
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    break;
                                }
                            case "Gray":
                                {
                                    Console.BackgroundColor = ConsoleColor.Gray;
                                    break;
                                }
                            case "Green":
                                {
                                    Console.BackgroundColor = ConsoleColor.Green;
                                    break;
                                }
                            case "Magenta":
                                {
                                    Console.BackgroundColor = ConsoleColor.Magenta;
                                    break;
                                }
                            case "Red":
                                {
                                    Console.BackgroundColor = ConsoleColor.Red;
                                    break;
                                }
                            case "White":
                                {
                                    Console.BackgroundColor = ConsoleColor.White;
                                    break;
                                }
                            case "Yellow":
                                {
                                    Console.BackgroundColor = ConsoleColor.Yellow;
                                    break;
                                }
                        }
                        Console.Clear();
                        return;
                    }
                    else
                    {
                        return;
                    }
                }
                public static string UsePassword(bool Use)
                {
                    while (true)
                    {
                        if (Use == true)
                        {
                            Console.WriteLine("欢迎使用系统密码设置.请输入序号.");
                            Console.WriteLine("1.使用");
                            Console.WriteLine("2.不使用");
                            Console.Write("输入:");
                            string Type = Console.ReadLine();
                            if (Type == "1")
                            {
                                Console.WriteLine("设置已保存.");
                                Console.ReadKey();
                                return "true";
                            }
                            else if (Type == "2")
                            {
                                Console.WriteLine("设置已保存.");
                                Console.ReadKey();
                                return "false";
                            }
                            else
                            {
                                Console.WriteLine("请输入1或2.");
                                Console.ReadKey();
                                continue;
                            }
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
                public static string PasswordString(bool Use)
                {
                    if (Use == true)
                    {

                        Console.WriteLine("欢迎使用系统密码数据设置.");
                        Console.WriteLine("请设置访问密码");
                        Console.Write("输入:");
                        string Type = Console.ReadLine();
                        Console.WriteLine("设置已保存.");
                        Console.ReadKey();
                        return Type;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            public static void Password(bool Use, string True_PassWord)
            {
                if (Use == true)
                {
                    string Type_Password;
                    Console.WriteLine("请输入密码");
                    while (true)
                    {
                        Console.Write("输入:");
                        Type_Password = Console.ReadLine();
                        if (Type_Password == True_PassWord)
                        {
                            Console.Clear();
                            Console.WriteLine("密码正确");
                            Console.Write("按任意键进入菜单。");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("密码错误");
                            Console.WriteLine("请重新输入密码");
                            continue;
                        }
                    }
                    return;
                }
                else if (Use == false)
                {
                    return;
                }
            }
            public static string Time(bool Use, bool UseTwelveMode)
            {
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
                if (TimeOfMinute < 10)
                {
                    TimeOfMinute_String = "0" + TimeOfMinute_String;
                }
                if (TimeOfSecond < 10)
                {
                    TimeOfSecond_String = "0" + TimeOfSecond_String;
                }
                if (UseTwelveMode == false)
                {
                    if (TimeOfHour < 10)
                    {
                        TimeOfHour_String = "0" + TimeOfHour_String;
                    }
                    string GetTime = TimeOfYear_String + "/" + TimeOfMonth_String + "/" + TimeOfDay_String + " " + TimeOfHour_String + ":" + TimeOfMinute_String + ":" + TimeOfSecond_String;
                    return GetTime;
                }
                else
                {
                    if (TimeOfHour < 10)
                    {
                        TimeOfHour_String = "0" + TimeOfHour_String;
                    }
                    if (TimeOfHour <= 12)
                    {
                        string GetTime = "A.M. " + TimeOfYear_String + "/" + TimeOfMonth_String + "/" + TimeOfDay_String + " " + TimeOfHour_String + ":" + TimeOfMinute_String + ":" + TimeOfSecond_String;
                        return GetTime;
                    }
                    else
                    {
                        TimeOfHour = TimeOfHour - 12;
                        TimeOfHour_String = TimeOfHour.ToString();
                        string GetTime = TimeOfYear_String + "/" + TimeOfMonth_String + "/" + TimeOfDay_String + " " + "P.M. " + TimeOfHour_String + ":" + TimeOfMinute_String + ":" + TimeOfSecond_String;
                        return GetTime;
                    }
                }
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
            public class UseSettings
            {
                public static void CreateXmlFile()
                {
                    XmlDocument XmlDocumentSet = new XmlDocument();
                    string Color_String = SetTheBackColor(true);
                    Console.Clear();
                    string UsePassword_String = ShowOfMultiTools.XmlSettingsShow.UsePassword(true);
                    Console.Clear();
                    //Xml声明
                    XmlNode Declaration = XmlDocumentSet.CreateXmlDeclaration("1.0", "UTF-8", "");
                    XmlDocumentSet.AppendChild(Declaration);
                    //一级元素
                    XmlElement ElementSettings = XmlDocumentSet.CreateElement("Settings");
                    XmlDocumentSet.AppendChild(ElementSettings);
                    //二级元素
                    XmlElement UseColor = XmlDocumentSet.CreateElement("UseColor");
                    XmlElement UsePassword = XmlDocumentSet.CreateElement("UsePassword");
                    XmlElement PasswordString = XmlDocumentSet.CreateElement("PasswordString");
                    UsePassword.InnerText = UsePassword_String;
                    UseColor.InnerText = Color_String;
                    ElementSettings.AppendChild(UsePassword);
                    ElementSettings.AppendChild(UseColor);
                    ElementSettings.AppendChild(PasswordString);
                    //                    XmlAttribute WhichColor = XmlDocumentSet.CreateAttribute("WhichColor");
                    //                    WhichColor.InnerText = "black";
                    //                    UseColor.Attributes.Append(WhichColor);
                    try
                    {
                        XmlDocumentSet.Save("Settings.xml");
                    }
                    catch (Exception)
                    {
                    }
                }
                public static string SetTheBackColor(bool Use)
                {
                    if (Use == true)
                    {
                        while (true)
                        {
                            ConsoleColor Now = Console.BackgroundColor;
                            Console.Clear();
                            Console.WriteLine("欢迎使用系统颜色设置.");
                            Console.WriteLine("请设置控制台背景颜色。请输入序号。");
                            Console.WriteLine("1.黑色");
                            Console.WriteLine("2.蓝色");
                            Console.WriteLine("3.青绿色");
                            Console.WriteLine("4.深蓝色");
                            Console.WriteLine("5.深紫色");
                            Console.WriteLine("6.深灰色");
                            Console.WriteLine("7.深绿色");
                            Console.WriteLine("8.深紫红色");
                            Console.WriteLine("9.深红色");
                            Console.WriteLine("10.深黄色");
                            Console.WriteLine("11.灰色");
                            Console.WriteLine("12.绿色");
                            Console.WriteLine("13.紫红色");
                            Console.WriteLine("14.红色");
                            Console.WriteLine("15.白色");
                            Console.WriteLine("16.黄色");
                            Console.Write("输入:");
                            string Type = Console.ReadLine();
                            Console.Clear();
                            {
                                switch (Type)
                                {
                                    #region
                                    case "1":
                                        {
                                            Console.BackgroundColor = ConsoleColor.Black;
                                            Console.Clear();
                                            Console.WriteLine("输入指定序号.");
                                            Console.WriteLine("1.确定");
                                            Console.WriteLine("2.取消");
                                            Console.Write("输入:");
                                            string TypeCase = Console.ReadLine();
                                            if (TypeCase == "1")
                                            {
                                                Console.WriteLine("设置已保存");
                                                Console.ReadKey();
                                                return "Black";
                                            }
                                            else if (TypeCase == "2")
                                            {
                                                Console.BackgroundColor = Now;
                                                continue;
                                            }
                                            else
                                            {
                                                Console.WriteLine("请重新选择");
                                                Console.ReadKey();
                                                Console.BackgroundColor = Now;
                                                continue;
                                            }
                                        }
                                    case "2":
                                        {
                                            Console.BackgroundColor = ConsoleColor.Blue;
                                            Console.Clear();
                                            Console.WriteLine("输入指定序号.");
                                            Console.WriteLine("1.确定");
                                            Console.WriteLine("2.取消");
                                            Console.Write("输入:");
                                            string TypeCase = Console.ReadLine();
                                            if (TypeCase == "1")
                                            {
                                                Console.WriteLine("设置已保存");
                                                Console.ReadKey();
                                                return "Blue";
                                            }
                                            else if (TypeCase == "2")
                                            {
                                                Console.BackgroundColor = Now;
                                                continue;
                                            }
                                            else
                                            {
                                                Console.WriteLine("请重新选择");
                                                Console.ReadKey();
                                                Console.BackgroundColor = Now;
                                                continue;
                                            }
                                        }
                                    case "3":
                                        {
                                            Console.BackgroundColor = ConsoleColor.Cyan;
                                            Console.Clear();
                                            Console.WriteLine("输入指定序号.");
                                            Console.WriteLine("1.确定");
                                            Console.WriteLine("2.取消");
                                            Console.Write("输入:");
                                            string TypeCase = Console.ReadLine();
                                            if (TypeCase == "1")
                                            {
                                                Console.WriteLine("设置已保存");
                                                Console.ReadKey();
                                                return "Cyan";
                                            }
                                            else if (TypeCase == "2")
                                            {
                                                Console.BackgroundColor = Now;
                                                continue;
                                            }
                                            else
                                            {
                                                Console.WriteLine("请重新选择");
                                                Console.ReadKey();
                                                Console.BackgroundColor = Now;
                                                continue;
                                            }
                                        }
                                    case "4":
                                        {
                                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                                            Console.Clear();
                                            Console.WriteLine("输入指定序号.");
                                            Console.WriteLine("1.确定");
                                            Console.WriteLine("2.取消");
                                            Console.Write("输入:");
                                            string TypeCase = Console.ReadLine();
                                            if (TypeCase == "1")
                                            {
                                                Console.WriteLine("设置已保存");
                                                Console.ReadKey();
                                                return "DarkBlue";
                                            }
                                            else if (TypeCase == "2")
                                            {
                                                Console.BackgroundColor = Now;
                                                continue;
                                            }
                                            else
                                            {
                                                Console.WriteLine("请重新选择");
                                                Console.ReadKey();
                                                Console.BackgroundColor = Now;
                                                continue;
                                            }
                                        }
                                    case "5":
                                        {
                                            Console.BackgroundColor = ConsoleColor.DarkCyan;
                                            Console.Clear();
                                            Console.WriteLine("输入指定序号.");
                                            Console.WriteLine("1.确定");
                                            Console.WriteLine("2.取消");
                                            Console.Write("输入:");
                                            string TypeCase = Console.ReadLine();
                                            if (TypeCase == "1")
                                            {
                                                Console.WriteLine("设置已保存");
                                                Console.ReadKey();
                                                return "DarkCyan";
                                            }
                                            else if (TypeCase == "2")
                                            {
                                                Console.BackgroundColor = Now;
                                                continue;
                                            }
                                            else
                                            {
                                                Console.WriteLine("请重新选择");
                                                Console.ReadKey();
                                                Console.BackgroundColor = Now;
                                                continue;
                                            }
                                        }
                                    case "6":
                                        {
                                            Console.BackgroundColor = ConsoleColor.DarkGray;
                                            Console.Clear();
                                            Console.WriteLine("输入指定序号.");
                                            Console.WriteLine("1.确定");
                                            Console.WriteLine("2.取消");
                                            Console.Write("输入:");
                                            string TypeCase = Console.ReadLine();
                                            if (TypeCase == "1")
                                            {
                                                Console.WriteLine("设置已保存");
                                                Console.ReadKey();
                                                return "DarkGray";
                                            }
                                            else if (TypeCase == "2")
                                            {
                                                Console.BackgroundColor = Now;
                                                continue;
                                            }
                                            else
                                            {
                                                Console.WriteLine("请重新选择");
                                                Console.ReadKey();
                                                Console.BackgroundColor = Now;
                                                continue;
                                            }
                                        }
                                    case "7":
                                        {
                                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                                            Console.Clear();
                                            Console.WriteLine("输入指定序号.");
                                            Console.WriteLine("1.确定");
                                            Console.WriteLine("2.取消");
                                            Console.Write("输入:");
                                            string TypeCase = Console.ReadLine();
                                            if (TypeCase == "1")
                                            {
                                                Console.WriteLine("设置已保存");
                                                Console.ReadKey();
                                                return "DarkGreen";
                                            }
                                            else if (TypeCase == "2")
                                            {
                                                Console.BackgroundColor = Now;
                                                continue;
                                            }
                                            else
                                            {
                                                Console.WriteLine("请重新选择");
                                                Console.ReadKey();
                                                Console.BackgroundColor = Now;
                                                continue;
                                            }
                                        }
                                    case "8":
                                        {
                                            Console.BackgroundColor = ConsoleColor.DarkMagenta;
                                            Console.Clear();
                                            Console.WriteLine("输入指定序号.");
                                            Console.WriteLine("1.确定");
                                            Console.WriteLine("2.取消");
                                            Console.Write("输入:");
                                            string TypeCase = Console.ReadLine();
                                            if (TypeCase == "1")
                                            {
                                                Console.WriteLine("设置已保存");
                                                Console.ReadKey();
                                                return "DarkMagenta";
                                            }
                                            else if (TypeCase == "2")
                                            {
                                                Console.BackgroundColor = Now;
                                                continue;
                                            }
                                            else
                                            {
                                                Console.WriteLine("请重新选择");
                                                Console.ReadKey();
                                                Console.BackgroundColor = Now;
                                                continue;
                                            }
                                        }
                                    case "9":
                                        {
                                            Console.BackgroundColor = ConsoleColor.DarkRed;
                                            Console.Clear();
                                            Console.WriteLine("输入指定序号.");
                                            Console.WriteLine("1.确定");
                                            Console.WriteLine("2.取消");
                                            Console.Write("输入:");
                                            string TypeCase = Console.ReadLine();
                                            if (TypeCase == "1")
                                            {
                                                Console.WriteLine("设置已保存");
                                                Console.ReadKey();
                                                return "DarkRed";
                                            }
                                            else if (TypeCase == "2")
                                            {
                                                Console.BackgroundColor = Now;
                                                continue;
                                            }
                                            else
                                            {
                                                Console.WriteLine("请重新选择");
                                                Console.ReadKey();
                                                Console.BackgroundColor = Now;
                                                continue;
                                            }
                                        }
                                    case "10":
                                        {
                                            Console.BackgroundColor = ConsoleColor.DarkYellow;
                                            Console.Clear();
                                            Console.WriteLine("输入指定序号.");
                                            Console.WriteLine("1.确定");
                                            Console.WriteLine("2.取消");
                                            Console.Write("输入:");
                                            string TypeCase = Console.ReadLine();
                                            if (TypeCase == "1")
                                            {
                                                Console.WriteLine("设置已保存");
                                                Console.ReadKey();
                                                return "DarkYellow";
                                            }
                                            else if (TypeCase == "2")
                                            {
                                                Console.BackgroundColor = Now;
                                                continue;
                                            }
                                            else
                                            {
                                                Console.WriteLine("请重新选择");
                                                Console.ReadKey();
                                                Console.BackgroundColor = Now;
                                                continue;
                                            }
                                        }
                                    case "11":
                                        {
                                            Console.BackgroundColor = ConsoleColor.Gray;
                                            Console.Clear();
                                            Console.WriteLine("输入指定序号.");
                                            Console.WriteLine("1.确定");
                                            Console.WriteLine("2.取消");
                                            Console.Write("输入:");
                                            string TypeCase = Console.ReadLine();
                                            if (TypeCase == "1")
                                            {
                                                Console.WriteLine("设置已保存");
                                                Console.ReadKey();
                                                return "Gray";
                                            }
                                            else if (TypeCase == "2")
                                            {
                                                Console.BackgroundColor = Now;
                                                continue;
                                            }
                                            else
                                            {
                                                Console.WriteLine("请重新选择");
                                                Console.ReadKey();
                                                Console.BackgroundColor = Now;
                                                continue;
                                            }
                                        }
                                    case "12":
                                        {
                                            Console.BackgroundColor = ConsoleColor.Green;
                                            Console.Clear();
                                            Console.WriteLine("输入指定序号.");
                                            Console.WriteLine("1.确定");
                                            Console.WriteLine("2.取消");
                                            Console.Write("输入:");
                                            string TypeCase = Console.ReadLine();
                                            if (TypeCase == "1")
                                            {
                                                Console.WriteLine("设置已保存");
                                                Console.ReadKey();
                                                return "Green";
                                            }
                                            else if (TypeCase == "2")
                                            {
                                                Console.BackgroundColor = Now;
                                                continue;
                                            }
                                            else
                                            {
                                                Console.WriteLine("请重新选择");
                                                Console.ReadKey();
                                                Console.BackgroundColor = Now;
                                                continue;
                                            }
                                        }
                                    case "13":
                                        {
                                            Console.BackgroundColor = ConsoleColor.Magenta;
                                            Console.Clear();
                                            Console.WriteLine("输入指定序号.");
                                            Console.WriteLine("1.确定");
                                            Console.WriteLine("2.取消");
                                            Console.Write("输入:");
                                            string TypeCase = Console.ReadLine();
                                            if (TypeCase == "1")
                                            {
                                                Console.WriteLine("设置已保存");
                                                Console.ReadKey();
                                                return "Magenta";
                                            }
                                            else if (TypeCase == "2")
                                            {
                                                Console.BackgroundColor = Now;
                                                continue;
                                            }
                                            else
                                            {
                                                Console.WriteLine("请重新选择");
                                                Console.ReadKey();
                                                Console.BackgroundColor = Now;
                                                continue;
                                            }
                                        }
                                    case "14":
                                        {
                                            Console.BackgroundColor = ConsoleColor.Red;
                                            Console.Clear();
                                            Console.WriteLine("输入指定序号.");
                                            Console.WriteLine("1.确定");
                                            Console.WriteLine("2.取消");
                                            Console.Write("输入:");
                                            string TypeCase = Console.ReadLine();
                                            if (TypeCase == "1")
                                            {
                                                Console.WriteLine("设置已保存");
                                                Console.ReadKey();
                                                return "Red";
                                            }
                                            else if (TypeCase == "2")
                                            {
                                                Console.BackgroundColor = Now;
                                                continue;
                                            }
                                            else
                                            {
                                                Console.WriteLine("请重新选择");
                                                Console.ReadKey();
                                                Console.BackgroundColor = Now;
                                                continue;
                                            }
                                        }
                                    case "15":
                                        {
                                            Console.BackgroundColor = ConsoleColor.White;
                                            Console.Clear();
                                            Console.WriteLine("输入指定序号.");
                                            Console.WriteLine("1.确定");
                                            Console.WriteLine("2.取消");
                                            Console.Write("输入:");
                                            string TypeCase = Console.ReadLine();
                                            if (TypeCase == "1")
                                            {
                                                Console.WriteLine("设置已保存");
                                                Console.ReadKey();
                                                return "White";
                                            }
                                            else if (TypeCase == "2")
                                            {
                                                Console.BackgroundColor = Now;
                                                continue;
                                            }
                                            else
                                            {
                                                Console.WriteLine("请重新选择");
                                                Console.ReadKey();
                                                Console.BackgroundColor = Now;
                                                continue;
                                            }
                                        }
                                    case "16":
                                        {
                                            Console.BackgroundColor = ConsoleColor.Yellow;
                                            Console.Clear();
                                            Console.WriteLine("输入指定序号.");
                                            Console.WriteLine("1.确定");
                                            Console.WriteLine("2.取消");
                                            Console.Write("输入:");
                                            string TypeCase = Console.ReadLine();
                                            if (TypeCase == "1")
                                            {
                                                Console.WriteLine("设置已保存");
                                                Console.ReadKey();
                                                return "Yellow";
                                            }
                                            else if (TypeCase == "2")
                                            {
                                                Console.BackgroundColor = Now;
                                                continue;
                                            }
                                            else
                                            {
                                                Console.WriteLine("请重新选择");
                                                Console.ReadKey();
                                                Console.BackgroundColor = Now;
                                                continue;
                                            }
                                        }
                                        #endregion
                                }
                            }
                        }
                    }
                    else
                    {
                        return null;
                    }
                }
                public static bool GetXmlTrueOrFalse(string Path, string Element, string Node)
                {
                    XDocument LoadXml = XDocument.Load(Path);
                    string Value = LoadXml.Element(Element).Element(Node).Value;
                    if (Value == "true")
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                public static string GetXmlString(string Path, string Element, string Node)
                {
                    XDocument LoadXml = XDocument.Load(Path);
                    string Value = LoadXml.Element(Element).Element(Node).Value;
                    return Value;
                }

            }
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