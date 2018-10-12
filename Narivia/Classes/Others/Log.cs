using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Diagnostics;
using System.IO;

public class Log
{
    #region Properties
    public static bool Enabled
    {
        get { return enabled; }
        set { enabled = value; }
    } static bool enabled = true;
    public static string FileLocation
    {
        get { return fileLocation; }
        set { fileLocation = value; }
    } static string fileLocation = Environment.CurrentDirectory;
    public static string FileName 
    {
        get { return fileName; }
        set { fileName = value; }
    } static string fileName = "Log";
    public static string DefaultTimestampFormat { get { return "<HH:mm:ss>"; } }
    public static string TimestampFormat
    {
        get { return timestampFormat; }
        set { timestampFormat = value; }
    } static string timestampFormat = DefaultTimestampFormat;
    #endregion

    private static bool firstUse = true;

    public static void Write(string text)
    {
        if (firstUse)
        {
            File.WriteAllText(FileLocation + "\\" + FileName + ".LOG", "");
            firstUse = false;
        }

        using (StreamWriter sw = File.AppendText(FileLocation + "\\" + FileName + ".LOG"))
            sw.Write(DateTime.Now.ToString(TimestampFormat) + " " + text);

        Debug.Write(text);
    }

    public static void WriteLine(string text)
    {
        Write(text + Environment.NewLine);
    }
}
