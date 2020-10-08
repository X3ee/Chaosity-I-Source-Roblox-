// Decompiled with JetBrains decompiler
// Type: Chaosity.Functions
// Assembly: Chaosity, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8FD1C12D-B5CF-4C0B-B451-47DE735C992C
// Assembly location: C:\Users\povar\Desktop\Chaosity (Exploit)\ChaosityExploit.exe

using System.IO;
using System.Windows.Forms;

namespace Chaosity
{
  internal class Functions
  {
    public static string exploitdllname = "Chaosity.dll";
    public static OpenFileDialog openfiledialog;

    public static void Inject()
    {
      if (!NamedPipes.NamedPipeExist(NamedPipes.luapipename))
        return;
      int num = (int) MessageBox.Show("Chaosity is already injected!", "Chaosity Injected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }

    public static void PopulateListBox(ListBox lsb, string Folder, string FileType)
    {
      foreach (FileInfo file in new DirectoryInfo(Folder).GetFiles(FileType))
        lsb.Items.Add((object) file.Name);
    }

    static Functions()
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Filter = "Lua Script Txt (*.txt)|*.txt|All files|.lua|(*.*)|*.*";
      openFileDialog.FilterIndex = 1;
      openFileDialog.RestoreDirectory = true;
      openFileDialog.Title = "Chaostiy Lua Open Script";
      Functions.openfiledialog = openFileDialog;
    }
  }
}
