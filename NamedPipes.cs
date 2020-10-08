// Decompiled with JetBrains decompiler
// Type: Chaosity.NamedPipes
// Assembly: Chaosity, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8FD1C12D-B5CF-4C0B-B451-47DE735C992C
// Assembly location: C:\Users\povar\Desktop\Chaosity (Exploit)\ChaosityExploit.exe

using ModuleAPI;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Chaosity
{
  internal class NamedPipes
  {
    public static string luapipename = Encoding.Unicode.GetString(Convert.FromBase64String("RQB4AHAAbABvAGkAdABBAFAASQA="));
    private static Module api = new Module();
    public static bool wrd = false;
    public static bool easy = false;
    public static bool nem = false;
    public static bool chaosityprem2 = false;
    public static bool neminject = false;

    public static void setPipeName(string pipeName)
    {
      NamedPipes.luapipename = Encoding.Unicode.GetString(Convert.FromBase64String(Convert.ToBase64String(Encoding.UTF8.GetBytes(pipeName))));
    }

    [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool WaitNamedPipe(string name, int timeout);

    public static bool NamedPipeExist(string pipeName)
    {
      try
      {
        int timeout = 0;
        if (!NamedPipes.WaitNamedPipe(Path.GetFullPath(string.Format("\\\\\\\\.\\\\pipe\\\\{0}", (object) pipeName)), timeout))
        {
          switch (Marshal.GetLastWin32Error())
          {
            case 0:
              return false;
            case 2:
              return false;
          }
        }
        return true;
      }
      catch (Exception ex)
      {
        return false;
      }
    }

    public static void EasyExploits(string script)
    {
      NamedPipes.api.ExecuteScript(script);
    }

    public static void NemesisInject()
    {
      Thread.Sleep(100);
    }

    public static void EasyExploitsInject()
    {
      NamedPipes.api.LaunchExploit();
      Thread.Sleep(100);
    }

    public static void WeAreDevsInject()
    {
      NamedPipes.api.LaunchExploit();
      Thread.Sleep(100);
    }

    public static void LuaPipe(string script)
    {
      if (NamedPipes.easy)
      {
        NamedPipes.api.ExecuteScript(script);
      }
      else
      {
        int num = (int) MessageBox.Show("Please select a API & Inject first.", "API Selection // Injection");
      }
    }

    internal static void LuaPipe(object script)
    {
      throw new NotImplementedException();
    }
  }
}
