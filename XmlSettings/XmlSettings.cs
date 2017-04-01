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

namespace XmlSettings
{
    public class XmlSettingsMain
    {
        public static void CreateXmlFile(bool Use, string Compare)
        {
            if (Use == true)
            {
                XmlDocument XmlDocumentSet = new XmlDocument();
                string Color_String = AllEnter.SetTheBackColor(true);
                Console.Clear();
                string UsePassword_String = AllEnter.UsePassword(true);
                Console.Clear();
                string Password_String = AllEnter.PasswordString(true);
                Console.Clear();
                string Title_String = AllEnter.TitleString(true);
                Console.Clear();
                string TwelveSetTime = AllEnter.UseTwelveMethod(true);
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
                XmlElement TitleString = XmlDocumentSet.CreateElement("TitleString");
                XmlElement TwelveMethod = XmlDocumentSet.CreateElement("TwelveMethod");
                TitleString.InnerText = Title_String;
                PasswordString.InnerText = Password_String;
                UsePassword.InnerText = UsePassword_String;
                UseColor.InnerText = Color_String;
                TwelveMethod.InnerText = TwelveSetTime;
                ElementSettings.AppendChild(TitleString);
                ElementSettings.AppendChild(UsePassword);
                ElementSettings.AppendChild(UseColor);
                ElementSettings.AppendChild(PasswordString);
                ElementSettings.AppendChild(TwelveMethod);
                //                    XmlAttribute WhichColor = XmlDocumentSet.CreateAttribute("WhichColor");
                //                    WhichColor.InnerText = "black";
                //                    UseColor.Attributes.Append(WhichColor);
                try
                {
                    XmlDocumentSet.Save("Settings.xml");
                }
                catch (Exception e)
                {
                    Console.WriteLine("错误:" + e);
                    Console.WriteLine("请访问" + Compare);
                    Console.WriteLine("按任意键退出程序");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                return;
            }
            else
            {
                return;
            }
        }
        public static void GetXml(bool Use, string Compare)
        {
            if (Use == true)
            {
                try
                {
                    AllReturn.StartSetColor(true, AllGlobalFeatures.GetXmlString("Settings.xml", "Settings", "UseColor"));
                    AllReturn.StartSetTitle(true);
                }
                catch (Exception)
                {
                    File.Delete("Settings.xml");
                    Console.WriteLine("欢迎第一次使用本程序或您的设置文件错误.");
                    Console.WriteLine("欢迎使用设置.");
                    Console.WriteLine("按任意键进入设置");
                    Console.ReadKey();
                    CreateXmlFile(true, Compare);
                    Console.WriteLine("设置完毕");
                    Console.WriteLine("按任意键重启文件");
                    Console.ReadKey();
                    Application.Restart();
                    Environment.Exit(0);
                }
                finally
                {
                    AllReturn.StartUsePassword(true); 
                }
                return;
            }
            else
            {
                return;
            }
        }

    }
    public class AllGlobalFeatures
    {
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
    public class AllReturn
    {
        public static void StartUsePassword(bool Use)
        {
            if (Use == true)
            {
                OtherFeatureAboutXml.Password(AllGlobalFeatures.GetXmlTrueOrFalse("Settings.xml", "Settings", "UsePassword"), AllGlobalFeatures.GetXmlString("Settings.xml", "Settings", "PasswordString"));
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
        public static void StartSetTitle(bool Use)
        {
            if (Use == true)
            {
                Console.Title = AllGlobalFeatures.GetXmlString("Settings.xml", "Settings", "TitleString");
                return;
            }
            else
            {
                return;
            }
        }
        public static bool StartUseTwelveMethod(bool Use)
        {
            if (Use == true)
            {
                bool GetXml = AllGlobalFeatures.GetXmlTrueOrFalse("Settings.xml", "Settings", "TwelveMethod");
                return GetXml;
            }
            else
            {
                return false;
            }
        }
    }
    public class AllEnter
    {
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
                        }
                    }
                }
            }
            else
            {
                return null;
            }
        }
        public static string UsePassword(bool Use)
        {
            while (true)
            {
                Console.Clear();
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
        public static string TitleString(bool Use)
        {
            if (Use == true)
            {
                string Type;
                Console.WriteLine("欢迎使用系统文件标题数据设置.");
                Console.WriteLine("请设置文件标题");
                Console.Write("输入:");
                Type = Console.ReadLine();
                Console.Title = Type;
                Console.WriteLine("设置已保存.");
                Console.ReadKey();
                return Type;
            }
            else
            {
                return null;
            }
        }
        public static string UseTwelveMethod(bool Use)
        {
            if (Use == true)
            {
                while(true)
                {
                    Console.Clear();
                    Console.WriteLine("欢迎使用系统12小时计时设置.请输入序号.");
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
            }
            else
            {
                return null;
            }
        }
    }
    public class OtherFeatureAboutXml
    {
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
    }
}
