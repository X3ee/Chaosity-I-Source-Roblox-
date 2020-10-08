// Decompiled with JetBrains decompiler
// Type: Chaosity.Program
// Assembly: Chaosity, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8FD1C12D-B5CF-4C0B-B451-47DE735C992C
// Assembly location: C:\Users\povar\Desktop\Chaosity (Exploit)\ChaosityExploit.exe

using System;
using System.Windows.Forms;

namespace Chaosity
{
  internal static class Program
  {
    [STAThread]
    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run((Form) new Loading());
    }
  }
}
