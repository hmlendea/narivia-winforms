using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Reflection;

static class CustomCursor
{
    [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
    private static extern IntPtr LoadCursorFromFile(string path);

    public static Cursor Load(string file)
    {
        try
        {
            IntPtr hCursor = LoadCursorFromFile("Data\\Cursors\\" + file);

            if (hCursor == IntPtr.Zero)
                throw new Win32Exception();

            var cursor = new Cursor(hCursor);
            var fi = typeof(Cursor).GetField("ownHandle",
                BindingFlags.NonPublic | BindingFlags.Instance);

            fi.SetValue(cursor, true);

            return cursor;
        }
        catch
        {
            Log.WriteLine("ERROR: Error loading cursor \"" + file + "\"!");
            return Cursors.Arrow;
        }
    }
}
