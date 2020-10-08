// Decompiled with JetBrains decompiler
// Type: Chaosity.FGameHubMain
// Assembly: Chaosity, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8FD1C12D-B5CF-4C0B-B451-47DE735C992C
// Assembly location: C:\Users\povar\Desktop\Chaosity (Exploit)\ChaosityExploit.exe

using DiscordRpcDemo;
using Microsoft.Win32;
using ModuleAPI;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Chaosity
{
  public class FGameHubMain : Form
  {
    private DiscordRpc.RichPresence presence;
    private DiscordRpc.EventHandlers handlers;
    private WebClient webClient;
    private Module module;
    private WebClient webLoader;
    private Module api;
    public const int WM_NCLBUTTONDOWN = 161;
    public const int HT_CAPTION = 2;
    private OpenFileDialog open;
    private IContainer components;
    private Panel border3;
    private Panel border1;
    private Panel border2;
    private TabControl chaosityTabs;
    private TabPage execPage;
    private TabPage scriptHub;
    private Panel panel1;
    private Panel panel2;
    private Panel panel3;
    private Panel panel4;
    private Button button2;
    private WebBrowser webBrowser1;
    private Button button3;
    private Button button4;
    private Button button1;
    private Button button6;
    private FlowLayoutPanel flowLayoutPanel1;
    private PictureBox pictureBox4;
    private PictureBox pictureBox5;
    private PictureBox pictureBox6;
    private PictureBox pictureBox7;
    private PictureBox pictureBox8;
    private PictureBox pictureBox9;
    private PictureBox pictureBox10;
    private PictureBox pictureBox11;
    private PictureBox pictureBox12;
    private PictureBox pictureBox13;
    private PictureBox pictureBox14;
    private Button button8;
    private Panel panel6;
    private Label label5;
    private PictureBox pictureBox3;
    private Panel panel5;
    private Label label4;
    private Panel panel7;
    private Label label6;
    private Panel panel8;
    private Label label7;
    private Panel panel9;
    private Label label8;
    private Panel panel10;
    private Label label9;
    private Panel panel11;
    private Label label10;
    private Panel panel12;
    private Label label11;
    private Panel panel13;
    private Label label12;
    private Panel panel14;
    private Label label13;
    private Panel panel15;
    private Label label14;
    private Panel panel16;
    private Label label15;
    private ContextMenuStrip contextMenuStrip1;
    private Panel panel18;
    private Label label19;
    private PictureBox pictureBox15;
    private Panel panel19;
    private Label label20;
    private PictureBox pictureBox16;
    private Panel panel20;
    private Label label21;
    private PictureBox pictureBox17;
    private Panel panel21;
    private Label label22;
    private PictureBox pictureBox18;
    private Panel panel22;
    private Label label23;
    private PictureBox pictureBox19;
    private Panel panel17;
    private Label label18;
    private PictureBox pictureBox2;
    private Panel panel23;
    private Label label24;
    private PictureBox pictureBox20;
    private Panel panel24;
    private Label label25;
    private PictureBox pictureBox21;
    private Panel panel25;
    private Label label26;
    private PictureBox pictureBox22;
    private Panel panel26;
    private Label label27;
    private PictureBox pictureBox23;
    private Panel panel27;
    private Label label28;
    private PictureBox pictureBox24;
    private Panel panel29;
    private Label label30;
    private PictureBox pictureBox26;
    private Panel panel30;
    private Label label31;
    private PictureBox pictureBox27;
    private Panel panel31;
    private Label label32;
    private PictureBox pictureBox28;
    private Panel panel32;
    private Label label33;
    private PictureBox pictureBox29;
    private Panel panel33;
    private Label label34;
    private PictureBox pictureBox30;
    private Panel panel34;
    private Label label35;
    private PictureBox pictureBox31;
    private Panel panel35;
    private Label label36;
    private PictureBox pictureBox32;
    private Panel panel37;
    private Label label38;
    private PictureBox pictureBox34;
    private Panel panel38;
    private Label label39;
    private PictureBox pictureBox35;
    private Panel panel39;
    private Label label40;
    private PictureBox pictureBox36;
    private Panel panel40;
    private Label label41;
    private PictureBox pictureBox37;
    private Panel panel41;
    private Label label42;
    private PictureBox pictureBox38;
    private Panel panel42;
    private Label label43;
    private PictureBox pictureBox39;
    private Panel panel43;
    private Label label44;
    private PictureBox pictureBox40;
    private Panel panel44;
    private Label label45;
    private PictureBox pictureBox41;
    private Panel panel45;
    private Label label46;
    private PictureBox pictureBox42;
    private Panel panel46;
    private Label label47;
    private PictureBox pictureBox43;
    private Panel panel47;
    private Label label48;
    private PictureBox pictureBox44;
    private Panel panel48;
    private Label label49;
    private PictureBox pictureBox45;
    private Panel panel49;
    private Label label50;
    private PictureBox pictureBox46;
    private Panel panel50;
    private Label label51;
    private PictureBox pictureBox47;
    private Panel panel51;
    private Label label52;
    private PictureBox pictureBox48;
    private Panel panel52;
    private Label label53;
    private PictureBox pictureBox49;
    private Panel panel53;
    private Label label54;
    private PictureBox pictureBox50;
    private Panel panel54;
    private Label label55;
    private PictureBox pictureBox51;
    private Panel panel55;
    private Label label56;
    private PictureBox pictureBox52;
    private Panel panel56;
    private Label label57;
    private PictureBox pictureBox53;
    private Panel panel57;
    private Label label58;
    private PictureBox pictureBox54;
    private Panel panel59;
    private Label label60;
    private PictureBox pictureBox56;
    private Panel panel60;
    private Label label61;
    private PictureBox pictureBox57;
    private Panel panel62;
    private Label label63;
    private PictureBox pictureBox59;
    private Panel panel63;
    private Label label64;
    private PictureBox pictureBox60;
    private Panel panel64;
    private Label label65;
    private PictureBox pictureBox61;
    private Panel panel65;
    private Label label17;
    private PictureBox pictureBox62;
    private Panel panel66;
    private Label label66;
    private PictureBox pictureBox63;
    private Panel panel28;
    private Label label29;
    private PictureBox pictureBox25;
    private Panel panel58;
    private Label label59;
    private PictureBox pictureBox55;
    private Panel panel67;
    private Label label67;
    private PictureBox pictureBox64;
    private Panel panel68;
    private Label label68;
    private PictureBox pictureBox65;
    private Panel panel69;
    private Label label69;
    private PictureBox pictureBox66;
    private Panel panel70;
    private Label label70;
    private PictureBox pictureBox67;
    private Panel panel71;
    private Label label71;
    private PictureBox pictureBox68;
    private Panel panel72;
    private Label label72;
    private PictureBox pictureBox69;
    private Panel panel73;
    private Label label73;
    private PictureBox pictureBox70;
    private Panel panel74;
    private Label label74;
    private PictureBox pictureBox71;
    private Panel panel75;
    private Label label75;
    private PictureBox pictureBox72;
    private Panel panel76;
    private Label label76;
    private PictureBox pictureBox73;
    private Panel panel77;
    private Label label77;
    private PictureBox pictureBox74;
    private Panel panel78;
    private Label label78;
    private PictureBox pictureBox75;
    private Panel panel79;
    private Label label79;
    private PictureBox pictureBox76;
    private Panel panel80;
    private Label label80;
    private PictureBox pictureBox77;
    private Panel panel81;
    private Label label81;
    private PictureBox pictureBox78;
    private Panel panel82;
    private Label label82;
    private PictureBox pictureBox79;
    private Panel panel83;
    private Label label83;
    private PictureBox pictureBox80;
    private Panel panel84;
    private Label label84;
    private PictureBox pictureBox81;
    private Panel panel85;
    private Label label85;
    private PictureBox pictureBox82;
    private Panel panel86;
    private Label label86;
    private PictureBox pictureBox83;
    private Panel panel87;
    private Label label87;
    private PictureBox pictureBox84;
    private Panel panel88;
    private Label label88;
    private PictureBox pictureBox85;
    private Panel panel89;
    private Label label89;
    private PictureBox pictureBox86;
    private Panel panel90;
    private Label label90;
    private PictureBox pictureBox87;
    private Panel panel91;
    private Label label91;
    private PictureBox pictureBox88;
    private Panel panel93;
    private Label label93;
    private PictureBox pictureBox90;
    private Panel panel94;
    private Label label94;
    private PictureBox pictureBox91;
    private Panel panel95;
    private Label label95;
    private PictureBox pictureBox92;
    private Panel panel97;
    private Label label97;
    private PictureBox pictureBox94;
    private Panel panel98;
    private Label label98;
    private PictureBox pictureBox95;
    private Panel panel99;
    private Label label99;
    private PictureBox pictureBox96;
    private Panel panel96;
    private Label label96;
    private PictureBox pictureBox93;
    private Panel panel100;
    private Label label100;
    private PictureBox pictureBox97;
    private Panel panel102;
    private Label label16;
    private PictureBox pictureBox99;
    private Panel panel103;
    private Label label102;
    private PictureBox pictureBox100;
    private Panel panel101;
    private Label label101;
    private PictureBox pictureBox98;
    private ListBox listBox1;
    private System.Windows.Forms.Timer timer1;
    private Panel panel104;
    private Label label103;
    private PictureBox pictureBox101;
    private Panel panel105;
    private Label label104;
    private PictureBox pictureBox102;
    private Panel panel106;
    private Label label105;
    private PictureBox pictureBox103;
    private Panel panel107;
    private Label label106;
    private PictureBox pictureBox104;
    private Panel panel108;
    private Label label107;
    private PictureBox pictureBox105;
    private Panel panel109;
    private Label label108;
    private PictureBox pictureBox106;
    private Panel panel111;
    private Label label110;
    private PictureBox pictureBox108;
    private Panel panel112;
    private Label label111;
    private PictureBox pictureBox109;
    private Panel panel113;
    private Label label112;
    private PictureBox pictureBox110;
    private Panel panel92;
    private Label label92;
    private PictureBox pictureBox89;
    private Panel panel114;
    private Label label113;
    private PictureBox pictureBox111;
    private Panel panel115;
    private Label label114;
    private PictureBox pictureBox112;
    private Panel panel116;
    private Label label115;
    private PictureBox pictureBox113;
    private Panel panel117;
    private Label label116;
    private PictureBox pictureBox114;
    private Panel panel118;
    private Label label117;
    private PictureBox pictureBox115;
    private Panel panel120;
    private Label label119;
    private PictureBox pictureBox117;
    private Panel panel121;
    private Label label120;
    private PictureBox pictureBox118;
    private Panel panel122;
    private Label label121;
    private PictureBox pictureBox119;
    private Panel panel123;
    private Label label122;
    private PictureBox pictureBox120;
    private Panel panel124;
    private Label label123;
    private PictureBox pictureBox121;
    private Panel panel125;
    private Label label124;
    private PictureBox pictureBox122;
    private Panel panel126;
    private Label label125;
    private PictureBox pictureBox123;
    private Panel panel127;
    private Label label126;
    private PictureBox pictureBox124;
    private Panel panel128;
    private Label label127;
    private PictureBox pictureBox125;
    private Panel panel129;
    private Label label128;
    private PictureBox pictureBox126;
    private Panel panel130;
    private Label label129;
    private PictureBox pictureBox127;
    private Panel panel131;
    private Label label130;
    private PictureBox pictureBox128;
    private Panel panel119;
    private Label label118;
    private PictureBox pictureBox116;
    private Panel panel132;
    private Label label131;
    private PictureBox pictureBox129;
    private Panel panel133;
    private PictureBox pictureBox130;
    private Label label132;
    private Panel panel134;
    private Label label133;
    private PictureBox pictureBox131;
    private Panel panel136;
    private Label label135;
    private PictureBox pictureBox133;
    private Panel panel137;
    private Label label136;
    private PictureBox pictureBox134;
    private Panel panel138;
    private Label label137;
    private PictureBox pictureBox135;
    private Panel panel135;
    private Label label134;
    private PictureBox pictureBox132;
    private Panel panel139;
    private Label label138;
    private PictureBox pictureBox136;
    private Panel panel140;
    private Label label139;
    private PictureBox pictureBox137;
    private Panel panel141;
    private Label label140;
    private PictureBox pictureBox138;
    private Panel panel142;
    private Label label141;
    private PictureBox pictureBox139;
    private Panel panel143;
    private Label label142;
    private PictureBox pictureBox140;
    private Panel panel144;
    private Label label143;
    private PictureBox pictureBox141;
    private Panel panel145;
    private Label label144;
    private PictureBox pictureBox142;
    private Panel panel146;
    private Label label145;
    private PictureBox pictureBox143;
    private Panel panel110;
    private Label label109;
    private PictureBox pictureBox107;
    private Panel panel147;
    private Label label146;
    private PictureBox pictureBox144;
    private Panel panel148;
    private Label label147;
    private PictureBox pictureBox145;
    private Panel panel149;
    private Label label148;
    private PictureBox pictureBox146;
    private Panel panel150;
    private Label label149;
    private PictureBox pictureBox147;
    private Panel panel151;
    private Label label150;
    private PictureBox pictureBox148;
    private Panel panel152;
    private Label label151;
    private PictureBox pictureBox149;
    private Panel panel153;
    private Label label152;
    private PictureBox pictureBox150;
    private Panel panel154;
    private Label label153;
    private PictureBox pictureBox151;
    private Panel panel155;
    private Label label154;
    private PictureBox pictureBox152;
    private Panel panel156;
    private Label label155;
    private PictureBox pictureBox153;
    private Panel panel157;
    private Label label156;
    private PictureBox pictureBox154;
    private Panel panel61;
    private Label label62;
    private PictureBox pictureBox58;
    private Panel panel158;
    private Label label157;
    private PictureBox pictureBox155;
    private Panel panel159;
    private Label label158;
    private PictureBox pictureBox156;
    private Panel panel160;
    private Label label159;
    private PictureBox pictureBox157;
    private Panel panel161;
    private Label label160;
    private PictureBox pictureBox158;
    private Panel panel162;
    private Label label161;
    private PictureBox pictureBox159;
    private Panel panel163;
    private Label label162;
    private PictureBox pictureBox160;
    private Panel panel164;
    private Label label163;
    private PictureBox pictureBox161;
    private Panel panel165;
    private Label label164;
    private PictureBox pictureBox162;
    private Panel panel166;
    private Label label165;
    private PictureBox pictureBox163;
    private Button button12;
    private Button button10;
    private Button button18;
    private CheckBox cb2;
    private PictureBox pictureBox1;
    private Panel topBar;
    private Button button5;
    private Button button7;
    private Button button9;
    private Button button11;
    private Button InjectionButtonPannel;
    private Label label2;
    private CheckBox MultipleROBLOX;

    private void exec(string script)
    {
    }

    private bool universalBypassInstalled()
    {
      return Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "/Google/Chrome/User Data/Default/Extensions/aihomhdbhpnpmcnnbckjjcebjoikpihj");
    }

    [DllImport("user32.dll")]
    public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

    [DllImport("user32.dll")]
    public static extern bool ReleaseCapture();

    [DllImport("Gdi32.dll")]
    private static extern IntPtr CreateRoundRectRgn(
      int nLeftRect,
      int nTopRect,
      int nRightRect,
      int nBottomRect,
      int nWidthEllipse,
      int nHeightEllipse);

    private void dragUi(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      FGameHubMain.ReleaseCapture();
      FGameHubMain.SendMessage(this.Handle, 161, 2, 0);
    }

    public FGameHubMain()
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Filter = "Lua Script (*.txt)|*.txt|Lua Script (*.lua)|*.lua";
      openFileDialog.FilterIndex = 1;
      openFileDialog.Title = "Open Script";
      this.open = openFileDialog;
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

    private void FGameHubMain_Load(object sender, EventArgs e)
    {
      this.module.SetIdentity("chaos");
      if (this.universalBypassInstalled())
      {
        int num = (int) MessageBox.Show("You must uninstall Universal Bypass before you can use Chaosity", "Universal Bypass Failed");
        Environment.Exit(0);
      }
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
      this.scriptBoxLoad();
    }

    private void Label2_Click(object sender, EventArgs e)
    {
      this.WindowState = FormWindowState.Minimized;
    }

    private void Label1_Click(object sender, EventArgs e)
    {
      this.Hide();
      new Chaosity().Show();
    }

    private void Button2_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webBrowser1.Document.InvokeScript("GetText", (object[]) new string[0]).ToString());
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      this.webBrowser1.Document.InvokeScript("SetText", new object[1]
      {
        (object) ""
      });
    }

    private void Button4_Click(object sender, EventArgs e)
    {
      if (this.open.ShowDialog() != DialogResult.OK)
        return;
      this.webBrowser1.Document.InvokeScript("SetText", (object[]) new string[1]
      {
        System.IO.File.ReadAllText(this.open.FileName)
      });
    }

    private void Button3_Click(object sender, EventArgs e)
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

    private void Button5_Click(object sender, EventArgs e)
    {
      this.api.LaunchExploit();
    }

    private void Button6_Click(object sender, EventArgs e)
    {
      this.chaosityTabs.SelectTab("scriptHub");
    }

    private void Button7_Click(object sender, EventArgs e)
    {
      this.chaosityTabs.SelectTab("execPage");
    }

    private void Button8_Click(object sender, EventArgs e)
    {
      this.chaosityTabs.SelectTab("scriptHub");
    }

    private void PictureBox2_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/yNwzgwTN"));
    }

    private void button9_Click(object sender, EventArgs e)
    {
      this.chaosityTabs.SelectTab("scriptHub");
    }

    private void pictureBox3_Click(object sender, EventArgs e)
    {
      this.chaosityTabs.SelectTab("PFTab");
    }

    private void button8_Click_1(object sender, EventArgs e)
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

    private void pictureBox4_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/qMcbuEuJ"));
    }

    private void pictureBox5_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/kmWxeu8P"));
    }

    private void pictureBox6_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/xyvE5K4q"));
    }

    private void pictureBox8_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/154RJ1mv"));
    }

    private void pictureBox7_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/dGmwtKFZ"));
    }

    private void pictureBox9_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/tDS58RkZ"));
    }

    private void pictureBox10_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/3qs77TTk"));
      int num = (int) MessageBox.Show("Script Executed, just deploy and shoot!");
    }

    private void pictureBox11_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/61vdJN2e"));
      int num = (int) MessageBox.Show("GUI is really broken right now, so use Aimbot and Hitbox only");
    }

    private void pictureBox12_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/f1whedKk"));
    }

    private void pictureBox13_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/hz4nAqXT"));
    }

    private void pictureBox14_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/8Kmpe1xr"));
    }

    private void label5_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/3956818381/NEW-SWORDS-Ninja-Legends");
    }

    private void button9_Click_1(object sender, EventArgs e)
    {
      foreach (Process process in Process.GetProcessesByName("RobloxPlayerBeta"))
        process.Kill();
    }

    private void label4_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/402122991/Redwood-Prison");
    }

    private void label6_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/155615604/Prison-Life-Cars-fixed");
    }

    private void label7_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/3486025575/X2-Magnet-Simulator");
    }

    private void label8_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/13822889/Lumber-Tycoon-2");
    }

    private void label9_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/171391948/Hot-Wheels-Vehicle-Simulator");
    }

    private void label10_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/3652625463/X2-Coins-Lifting-Simulator");
    }

    private void label11_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/3527629287/BIG-Paintball");
    }

    private void label12_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/2377868063/Strucid-BETA");
    }

    private void label13_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/914010731/1M-FAVS-Ro-Ghoul-ALPHA");
    }

    private void label14_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/1537690962/Bee-Swarm-Simulator");
    }

    private void label15_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/3376584594/Flight-Simulator");
    }

    private void label16_Click(object sender, EventArgs e)
    {
    }

    private void Monaco_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
    {
    }

    private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
    {
    }

    private void pictureBox2_Click_1(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/62GBpaJN"));
    }

    private void label18_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/4036494886/SANTA-BOSS-2X-Gun-Simulator");
    }

    private void label19_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/2818280787/UPDATE-1-Pet-Simulator-2");
    }

    private void pictureBox15_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/QhtJiZLi"));
      int num = (int) MessageBox.Show("Once you enable autofarm, do NOT disable it, it will break the autofarm.");
    }

    private void pictureBox16_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/BEZU0bMs"));
    }

    private void label20_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/4476549181/Pet-Ranch-Simulator-2");
    }

    private void pictureBox17_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/1xJQ8T5b"));
    }

    private void label21_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/1735775055/Iron-Man-Simulator");
    }

    private void pictureBox18_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/kFwWbXUt"));
    }

    private void label22_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/855499080/SKYWARS");
    }

    private void label23_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/1262182609/BOOGA-BOOGA-v-C1-41");
    }

    private void pictureBox19_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/yigKxDrK"));
    }

    private void pictureBox20_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.youtube.com/channel/UChMPXNYurxjYI_cpsPLYPkA");
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/sAc9Zt0j"));
    }

    private void label24_Click(object sender, EventArgs e)
    {
      Process.Start("https://web.roblox.com/games/1373038156/3-X-EVENT-Woodchopping-Simulator");
    }

    private void pictureBox21_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/cnLABpj3"));
    }

    private void label25_Click(object sender, EventArgs e)
    {
      Process.Start("https://web.roblox.com/games/3925890721/Robot-Inc-Evil-Factory");
    }

    private void pictureBox22_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/0BEnnwC4"));
      int num = (int) MessageBox.Show("Ps. You have to re execute everytime there is a new giant.");
    }

    private void label26_Click(object sender, EventArgs e)
    {
      Process.Start("https://web.roblox.com/games/4003872968/Giant-Survival-Remastered");
    }

    private void pictureBox23_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/AcHFc885"));
      int num = (int) MessageBox.Show("Click on F8 to close the GUI!");
    }

    private void label27_Click(object sender, EventArgs e)
    {
      Process.Start("https://web.roblox.com/games/301549746/NEW-CASE-Counter-Blox");
    }

    private void pictureBox24_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/Yd2vKxPv"));
    }

    private void label28_Click(object sender, EventArgs e)
    {
      Process.Start("https://web.roblox.com/games/286090429/Arsenal");
    }

    private void pictureBox25_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/Ccj7htSL"));
    }

    private void label29_Click(object sender, EventArgs e)
    {
      Process.Start("https://web.roblox.com/games/292439477/GERMAN-SPACE-GUNS-Phantom-Forces");
    }

    private void pictureBox26_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/YYVLbzVg"));
    }

    private void label30_Click(object sender, EventArgs e)
    {
      Process.Start("https://web.roblox.com/games/734159876/SharkBite");
    }

    private void pictureBox27_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/Hxwnxqbh"));
    }

    private void label31_Click(object sender, EventArgs e)
    {
      Process.Start("https://web.roblox.com/games/1600503/Apocalypse-Rising");
    }

    private void pictureBox28_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/q817HYb9"));
    }

    private void label32_Click(object sender, EventArgs e)
    {
      Process.Start("https://web.roblox.com/games/192800/Gift-Calendar-Work-at-a-Pizza-Place");
    }

    private void pictureBox29_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/xJMxE4UQ"));
    }

    private void label33_Click(object sender, EventArgs e)
    {
      Process.Start("https://web.roblox.com/games/4483360365/NEW-Gift-Simulator-Beta");
    }

    private void pictureBox30_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/Z33h2izB"));
    }

    private void label34_Click(object sender, EventArgs e)
    {
      Process.Start("https://web.roblox.com/games/4058282580/X3-SOULS-Boxing-Simulator");
    }

    private void pictureBox31_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/wjSZBDSF"));
    }

    private void label35_Click(object sender, EventArgs e)
    {
      Process.Start("https://web.roblox.com/games/4042427666/KAGUNE-Anime-Fighting-Simulator");
    }

    private void pictureBox32_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/U8cHYnJ5"));
    }

    private void label36_Click(object sender, EventArgs e)
    {
      Process.Start("https://web.roblox.com/games/3697782514/Magician-Simulator");
    }

    private void pictureBox33_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/Tpwg3w1x"));
    }

    private void label37_Click(object sender, EventArgs e)
    {
      Process.Start("https://web.roblox.com/games/3970007519/One-Piece-Ultimate");
    }

    private void pictureBox34_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/rfJTK1rc"));
    }

    private void label38_Click(object sender, EventArgs e)
    {
      Process.Start("https://web.roblox.com/games/3970007519/One-Piece-Ultimate");
    }

    private void pictureBox35_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/yJ3Vcb1s"));
    }

    private void label39_Click(object sender, EventArgs e)
    {
      Process.Start("https://web.roblox.com/games/4465900102/TRADE-Present-Simulator");
    }

    private void pictureBox36_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/ju2teccL"));
    }

    private void label40_Click(object sender, EventArgs e)
    {
      Process.Start("https://web.roblox.com/games/3759927663/NEW-MISSION-Zombie-Strike-BETA");
    }

    private void pictureBox37_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/mxVSVCLE"));
    }

    private void label41_Click(object sender, EventArgs e)
    {
      Process.Start("https://web.roblox.com/games/2202352383/Super-Power-Training-Simulator");
    }

    private void pictureBox38_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/tz60v82X"));
    }

    private void label42_Click(object sender, EventArgs e)
    {
      Process.Start("https://web.roblox.com/games/3048816241/LOL-Surprise-Tycoon-CHRISTMAS");
    }

    private void pictureBox39_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/URDBqiUw"));
      int num = (int) MessageBox.Show("After Executing, Deploy And You Will Get A Lot Of Kills.");
    }

    private void label43_Click(object sender, EventArgs e)
    {
      Process.Start("https://web.roblox.com/games/901793731/D-DAY-GREASE-GUN");
    }

    private void pictureBox40_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/ZNCeSaCd"));
    }

    private void label44_Click(object sender, EventArgs e)
    {
      Process.Start("https://web.roblox.com/games/3065716641/NEW-Slicing-Simulator");
    }

    private void pictureBox41_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("http://pastebin.com/raw/dd2Ssu21"));
    }

    private void label45_Click(object sender, EventArgs e)
    {
      Process.Start("https://web.roblox.com/games/4168452999/FLYING-Magic-Sim");
    }

    private void label45_Click_1(object sender, EventArgs e)
    {
      Process.Start("https://web.roblox.com/games/4168452999/FLYING-Magic-Sim");
    }

    private void pictureBox42_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/4jHBeTtf"));
    }

    private void label46_Click(object sender, EventArgs e)
    {
      Process.Start("https://web.roblox.com/games/3823781113/XMAS-Saber-Simulator");
    }

    private void pictureBox43_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/Y30aARwS"));
    }

    private void label47_Click(object sender, EventArgs e)
    {
      Process.Start("https://web.roblox.com/games/3959436136/Fighting-Simulator");
    }

    private void pictureBox44_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/nQxFmsMN"));
    }

    private void label48_Click(object sender, EventArgs e)
    {
      Process.Start("https://web.roblox.com/games/606849621/Jailbreak-CARGO-ROBBERY");
    }

    private void pictureBox45_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/Ju72fgSV"));
    }

    private void label49_Click(object sender, EventArgs e)
    {
      Process.Start("https://web.roblox.com/games/1224212277/Mad-City");
    }

    private void pictureBox46_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/A1Xia0pi"));
    }

    private void label50_Click(object sender, EventArgs e)
    {
      Process.Start("https://web.roblox.com/games/142823291/Murder-Mystery-2");
    }

    private void pictureBox47_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/LEqzpDW0"));
    }

    private void label51_Click(object sender, EventArgs e)
    {
      Process.Start("https://web.roblox.com/games/137885680/Zombie-Rush");
    }

    private void pictureBox48_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/PwzTNbsR"));
      int num = (int) MessageBox.Show("After executing, cook and it should auto cook for you!");
    }

    private void label52_Click(object sender, EventArgs e)
    {
      Process.Start("https://web.roblox.com/games/3398014311/Restaurant-Tycoon-2");
    }

    private void label53_Click(object sender, EventArgs e)
    {
      Process.Start("https://web.roblox.com/games/4131423478/ROBOTS-Tree-Planting-Simulator");
    }

    private void pictureBox49_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/4J4x162k"));
      int num = (int) MessageBox.Show("AutoSell doesn't work!");
    }

    private void pictureBox3_Click_1(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/0V0gQ5qe"));
    }

    private void pictureBox50_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/WC89Ej1k"));
    }

    private void label54_Click(object sender, EventArgs e)
    {
      Process.Start("https://web.roblox.com/games/4458733955/UPDATE-1-Blade-Simulator");
    }

    private void pictureBox51_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/TYvHFnSh"));
    }

    private void label55_Click(object sender, EventArgs e)
    {
      Process.Start("https://web.roblox.com/games/4254575069/BOSSES-Champion-Simulator");
    }

    private void label56_Click(object sender, EventArgs e)
    {
      Process.Start("https://web.roblox.com/games/289565045/Mad-Paintball-2-v0-07");
    }

    private void pictureBox52_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.youtube.com/channel/UChMPXNYurxjYI_cpsPLYPkA");
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/As5D6NAN"));
    }

    private void pictureBox53_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/FtFCzQTw"));
      int num = (int) MessageBox.Show("After Executing, Click on Toggle and it should give you a lot of money, diamonds, etc...");
    }

    private void label57_Click(object sender, EventArgs e)
    {
      Process.Start("https://web.roblox.com/games/2580982329/MERCH-Texting-Simulator");
    }

    private void pictureBox54_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/mFnVACZ1"));
    }

    private void label58_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/893973440/Flee-the-Facility-Beta");
    }

    private void pictureBox55_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/q6WHcj2D"));
    }

    private void label59_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/536102540/Dragon-Ball-Z-Final-Stand");
    }

    private void pictureBox57_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://ghostbin.co/paste/oce55/raw"));
    }

    private void label61_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/2636441885/HOLIDAY-Speed-City");
    }

    private void label60_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/2414851778/Tier-30-Dungeon-Quest");
    }

    private void pictureBox56_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/F5vSFHZt"));
      int num = (int) MessageBox.Show("AutoFarm is still work under progress!");
    }

    private void pictureBox58_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("http://creativehell.c1.biz/public-scripts/blox-piece.lua"));
      int num = (int) MessageBox.Show("Bandit Farm WILL CRASH YOUR GAME, so use chest farm only!");
    }

    private void label62_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/2753915549/Update-8-Blox-Piece");
    }

    private void pictureBox59_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/bQRxQiBy"));
    }

    private void label63_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/2533391464/UPDATE-Snowman-Simulator");
    }

    private void label64_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/4246487209/Boss-Fighting-Simulator");
    }

    private void pictureBox60_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://hastebin.com/raw/ekidiqohew"));
    }

    private void label65_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/4003645442/Sprinting-Simulator-2K");
    }

    private void pictureBox61_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/VNQy7fg3"));
    }

    private void label17_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/2960777560/X2-WKND-Treasure-Quest");
    }

    private void pictureBox62_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/zPF5ijUU"));
    }

    private void label66_Click(object sender, EventArgs e)
    {
      Process.Start("https://pastebin.com/raw/WytB2TXz");
    }

    private void pictureBox63_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/zPF5ijUU"));
      int num = (int) MessageBox.Show("After executing, it will kill everyone, re-execute to kill everyone again!");
    }

    private void label29_Click_1(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/370731277/MeepCity");
    }

    private void pictureBox25_Click_1(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/Gn0tuWch"));
    }

    private void label59_Click_1(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/4437355485/Ilum-2-RELEASE-SALE-2X-EXP");
    }

    private void pictureBox55_Click_1(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/QUv5t5H1"));
    }

    private void label67_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/4512002843/XMAS-SALE-Dungeon-Simulator");
    }

    private void pictureBox64_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/tSLrVYpx"));
    }

    private void label68_Click(object sender, EventArgs e)
    {
      Process.Start("https://web.roblox.com/games/3392399599/UPDATE-1-Drifting-Simulator-BETA");
    }

    private void pictureBox65_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/Tj7R9HnU"));
      int num = (int) MessageBox.Show("Wait a few seconds after executing for the GUI to show up!");
    }

    private void pictureBox66_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/TmhzPEef"));
    }

    private void label69_Click(object sender, EventArgs e)
    {
      Process.Start("https://web.roblox.com/games/4390380541/NEW-Rumble-Quest");
    }

    private void label70_Click(object sender, EventArgs e)
    {
      Process.Start("https://web.roblox.com/games/379614936/Assassin");
    }

    private void label71_Click(object sender, EventArgs e)
    {
      Process.Start("https://web.roblox.com/games/292439477/Israeli-Weapons-Phantom-Forces");
    }

    private void pictureBox68_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://ghostbin.co/paste/fs2qt/raw"));
    }

    private void pictureBox67_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://ghostbin.co/paste/qua6e/raw"));
      int num = (int) MessageBox.Show("After enabeling aimbot, DO NOT DISABLE IT OR IT WILL CRASH! To use aimbot : Throw your knife into the box when it has colours!");
    }

    private void label72_Click(object sender, EventArgs e)
    {
      Process.Start("https://web.roblox.com/games/221718525/Naruto-Tycoon-v2-5");
    }

    private void label72_Click_1(object sender, EventArgs e)
    {
      Process.Start("https://web.roblox.com/games/221718525/Naruto-Tycoon-v2-5");
    }

    private void pictureBox69_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/b2XekCiR"));
    }

    private void pictureBox70_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/Qv86dKq8"));
      int num = (int) MessageBox.Show("READ CAREFULLY! After executing, it will kick you, rejoin and it will give you INFINITE of everything!");
    }

    private void label73_Click(object sender, EventArgs e)
    {
      Process.Start("https://web.roblox.com/games/137877687/RoCitizens-Christmas");
    }

    private void label74_Click(object sender, EventArgs e)
    {
      Process.Start("https://web.roblox.com/games/3016661674/Rogue-Lineage-SALE");
    }

    private void pictureBox71_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/YkNcYx4Q"));
    }

    private void label75_Click(object sender, EventArgs e)
    {
      Process.Start("https://web.roblox.com/games/2346834658/Weight-Lifting-Simulator-3");
    }

    private void pictureBox72_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://ghostbin.co/paste/nev2j/raw"));
    }

    private void label76_Click(object sender, EventArgs e)
    {
      Process.Start("https://web.roblox.com/games/2473334918/Gas-Station-Simulator");
    }

    private void pictureBox73_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://ghostbin.co/paste/mggbd/raw"));
    }

    private void label77_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/1320186298/SANTA-Island-Royale");
    }

    private void pictureBox74_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/cPNc5xV7"));
      int num = (int) MessageBox.Show("Press H for aimbot, Press Right Alt for ESP!");
    }

    private void pictureBox75_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/6qZutRWW"));
    }

    private void label78_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/71315343/SALE-Dragon-Ball-Rage");
    }

    private void label79_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/891539556/Faction-Defence-Tycoon");
    }

    private void pictureBox76_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/FuDnSAvn"));
      int num = (int) MessageBox.Show("After executing, it should give you max money!");
    }

    private void label80_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/2788229376/Da-Hood-CHRISTMAS");
    }

    private void pictureBox77_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/GZWNs9uv"));
    }

    private void label81_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/1760932596/THANOS-IS-EATING-EVERYTHING");
    }

    private void pictureBox78_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/Xrqjaz3c"));
      int num = (int) MessageBox.Show("After executing, it should give you max money and damage!");
    }

    private void label82_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/3788547128/THE-GRINCH-Dr-Seuss-Simulator");
    }

    private void pictureBox79_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/U6fBzFf2"));
      int num = (int) MessageBox.Show("After executing, it should auto farm knowledge!");
    }

    private void label83_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/4316736353/Extreme-Sprinting-Simulator");
    }

    private void pictureBox80_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/Ti1r7tWn"));
    }

    private void label84_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/621129760/KAT");
    }

    private void pictureBox81_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/1ZiryX69"));
    }

    private void label85_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/4546789281/NEW-Sprinting-Heroes");
    }

    private void pictureBox82_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/LXWxj5Ld"));
    }

    private void label86_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/2096931771/PET-Donut-Story-Tycoon-Autosave");
    }

    private void pictureBox83_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/7vSsPyMq"));
      int num = (int) MessageBox.Show("After executing, you should have MAX MONEY");
    }

    private void label87_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/1382113806/Silent-Assassin");
    }

    private void pictureBox84_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/tYLm4Fcu"));
    }

    private void label88_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/4535346003/NEW-Wing-Simulator");
    }

    private void pictureBox85_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://ghostbin.co/paste/gvf4h/raw"));
      int num = (int) MessageBox.Show("After executing, coins will teleport to you. If it stops, re execute");
    }

    private void label89_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/3284973063/GCW-The-Galactic-Conquest");
    }

    private void pictureBox86_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("http://scripts.caslus.xyz/galactic_conquest.lua"));
    }

    private void label90_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/4418413996/Monster-Simulator-FINAL-TESTING-DAY");
    }

    private void pictureBox87_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("http://scripts.caslus.xyz/monster_simulator.lua"));
    }

    private void label91_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/738339342/Flood-Escape-2");
    }

    private void pictureBox88_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/vnNahdQh"));
    }

    private void label92_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/2577423786/JOKER-BOSS-Superhero-Simulator");
    }

    private void pictureBox89_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/RxBVpBhK"));
    }

    private void label93_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/33865710/The-Really-Easy-Obby");
    }

    private void pictureBox90_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/jwM4QgHr"));
      int num = (int) MessageBox.Show("After executing, it should autofarm for you");
    }

    private void label94_Click(object sender, EventArgs e)
    {
      Process.Start("https://web.roblox.com/games/1976838656/Huge-Update-Demon-Slayer-Retribution-ALPHA");
    }

    private void pictureBox91_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/WrCXreRn"));
    }

    private void panel95_Paint(object sender, PaintEventArgs e)
    {
    }

    private void label95_Click(object sender, EventArgs e)
    {
      Process.Start("https://web.roblox.com/games/4267085951/Mineverse-Beta");
    }

    private void pictureBox92_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/jwM4QgHr"));
      int num = (int) MessageBox.Show("For the Xray : Iron Ore - Yellow, Coal Ore - Green, Diamond Ore - Blue");
    }

    private void label96_Click(object sender, EventArgs e)
    {
      Process.Start("https://web.roblox.com/games/4528239858/2x-GRASS-BEE-ISLAND-Lawn-Mowing-Simulator");
    }

    private void pictureBox93_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/YjAvvzzS"));
    }

    private void label97_Click(object sender, EventArgs e)
    {
      Process.Start("https://web.roblox.com/games/4368069325/NEW-Building-Simulator-2");
    }

    private void pictureBox94_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/hc3d2CAH"));
    }

    private void execPage_Click(object sender, EventArgs e)
    {
    }

    private void button10_Click(object sender, EventArgs e)
    {
    }

    private void button11_Click(object sender, EventArgs e)
    {
      this.api.LaunchExploit();
    }

    private void button10_Click_1(object sender, EventArgs e)
    {
    }

    private void label98_Click(object sender, EventArgs e)
    {
      Process.Start("https://web.roblox.com/games/1899149341/Vehicle-Tycoon");
    }

    private void pictureBox95_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/0G2JeB2p"));
      int num = (int) MessageBox.Show("SPAWN A CAR AND GET INTO IT BEFORE EXECUTING THE SCRIPT!");
    }

    private void label99_Click(object sender, EventArgs e)
    {
      Process.Start("https://web.roblox.com/games/3095204897/Isle-8");
    }

    private void pictureBox96_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/TXra9Typ"));
    }

    private void button12_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/3mdjJHTg"));
      int num = (int) MessageBox.Show("Type ''cmds'' in the bar to see all the commands");
    }

    private void label96_Click_1(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/4554189264/Heroes-of-Speed");
    }

    private void pictureBox93_Click_1(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/YqHXkVh4"));
    }

    private void label100_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/4502746301/Bow-Simulator-UPDATE");
    }

    private void pictureBox97_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/Ba9PnUXA"));
    }

    private void label101_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/4520749081/King-Piece-Alpha-5-5");
    }

    private void pictureBox98_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/xMCwJh8g"));
    }

    private void label16_Click_1(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/4528239858/x10-MONEY-EVOLVING-Lawn-Mowing-Simulator");
    }

    private void pictureBox99_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/CGWuQyqt"));
    }

    private void pictureBox100_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/AW2jNtkg"));
    }

    private void label102_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/4520749081/King-Piece-Alpha-7");
    }

    private void label101_Click_1(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/662417684/LUCKY-BLOCK-Battlegrounds");
    }

    private void pictureBox98_Click_1(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/ZkuQ7uwz"));
      int num = (int) MessageBox.Show("Re execute after you die, check your backpack for more gears!");
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

    private void refresh_Click(object sender, EventArgs e)
    {
      this.scriptBoxLoad();
    }

    private void scriptHub_Click(object sender, EventArgs e)
    {
    }

    private void label103_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/3475397644/WINTER-EVENT-Dragon-Adventures#!/about");
    }

    private void pictureBox101_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/6hy0nZLq"));
    }

    private void pictureBox102_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/MYXEidCP"));
    }

    private void label104_Click(object sender, EventArgs e)
    {
      Process.Start("https://web.roblox.com/games/4325400580/Army-Tycoon");
    }

    private void label105_Click(object sender, EventArgs e)
    {
      Process.Start("https://web.roblox.com/games/4330397559/NEW-Viking-Simulator");
    }

    private void pictureBox103_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/jg7fkmwa"));
    }

    private void label106_Click(object sender, EventArgs e)
    {
      Process.Start("https://web.roblox.com/games/2512643572/CIRCUS-Bubble-Gum-Simulator");
    }

    private void pictureBox104_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/4XSEyeag"));
      int num = (int) MessageBox.Show("Currently, only earth works!", nameof (FGameHubMain), MessageBoxButtons.OK);
    }

    private void label107_Click(object sender, EventArgs e)
    {
      Process.Start("https://web.roblox.com/games/619566565/Grandmas-House-Obby");
    }

    private void pictureBox105_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/SN4HKY7y"));
    }

    private void button11_Click_1(object sender, EventArgs e)
    {
      if (DialogResult.Yes != MessageBox.Show("Are you sure you want to reinstall ROBLOX?", "Chaosity", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
        return;
      int num1 = (int) MessageBox.Show("Roblox is now reinstalling!\nThis could take a while, please wait patiently.", "Chaosity", MessageBoxButtons.OK);
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

    private void label108_Click(object sender, EventArgs e)
    {
      Process.Start("https://web.roblox.com/games/3264958220/Horror-Tycoon");
    }

    private void pictureBox106_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/uUZAgkAr"));
    }

    private void label109_Click(object sender, EventArgs e)
    {
      Process.Start("https://web.roblox.com/games/70005410/Blox-Hunt-v2-7-10-Winter");
    }

    private void pictureBox107_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/fdmUSpb2"));
    }

    private void label110_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/2577423786/ADMIN-UPDATE-Superhero-Simulator");
    }

    private void pictureBox108_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/ki1dmHd8"));
    }

    private void label111_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/4580204640/NEW-KILLERS-Survive-the-Killer");
    }

    private void pictureBox109_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/5WxCNcpU"));
    }

    private void label112_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/4458447460/Shadow-The-World-A-Modded-Day");
    }

    private void pictureBox110_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://paste.ee/r/zuktL/0"));
    }

    private void label92_Click_1(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/4317347865/PHONE-Murder-Mystery-3");
    }

    private void pictureBox89_Click_1(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/E6bXGQSn"));
    }

    private void label113_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/648362523/Breaking-Point");
    }

    private void pictureBox111_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/MLPypHYv"));
    }

    private void label114_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/4519672226/Egg-Clicker");
    }

    private void pictureBox112_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/8XdJC2iX"));
    }

    private void label115_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/4399032158/Thick-Legends");
    }

    private void pictureBox113_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/Ptrnnf3D"));
    }

    private void label116_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/2693739238/THIEF-LIFE-Simulator");
    }

    private void pictureBox114_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/6sA8kvmm"));
    }

    private void label117_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/23578803/Hotel-Elephant");
    }

    private void pictureBox115_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/2XxY4tLJ"));
    }

    private void pictureBox116_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/MghRgHnM"));
    }

    private void label118_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/2990100290/2X-EXP-RPG-Simulator-UPDATE-8");
    }

    private void label119_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/1111083356/Robot-64-Import-levels");
    }

    private void pictureBox117_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/jv5tV9Ff"));
    }

    private void pictureBox118_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/h9mgPtyE"));
    }

    private void label120_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/2866967438/Fishing-Simulator?nl=true");
    }

    private void label121_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/3101667897/Legends-Of-Speed");
    }

    private void pictureBox119_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/wZsEjz5E"));
    }

    private void label122_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/2571965166/Billionaire-Simulator");
    }

    private void pictureBox120_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/YgwvjUt0"));
    }

    private void label123_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/3311165597/Dragon-Ball-Ultimate");
    }

    private void pictureBox121_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/3rk2femQ"));
    }

    private void label124_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/4237861040/Treacherous-Tower");
    }

    private void pictureBox122_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/DnkwNcgs"));
    }

    private void label125_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/4539184430/PET-CRAFTING-Speed-Champions");
    }

    private void pictureBox123_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/xR5LdmbX"));
    }

    private void label126_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/3775649046/MEGA-SALE-K-O-Simulator");
    }

    private void pictureBox124_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://raw.githubusercontent.com/iVyperion/Public-Roblox-Scripting/master/KOSimulator/KOSimulatorGUI-obfuscated.lua"));
      int num = (int) MessageBox.Show("Everything except AutoSell Works! ", nameof (FGameHubMain), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }

    private void label127_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/1525936952/Lost");
    }

    private void pictureBox125_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/qc7y8Xrz"));
    }

    private void pictureBox126_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/nuipWGnf"));
    }

    private void label128_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/3272915504/World-of-Magic-Open-Test-3");
    }

    private void label129_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/21532277/Rebalance-Notoriety");
    }

    private void pictureBox127_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/RPCYGzpu"));
    }

    private void label130_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/2990100290/2X-EXP-RPG-Simulator-UPDATE-8");
    }

    private void pictureBox128_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/uiCgAb9S"));
      int num = (int) MessageBox.Show("Everything except Boss Farm Works! ", nameof (FGameHubMain), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }

    private void label118_Click_1(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/4520536611/QUESTS-Fitness-Simulator");
    }

    private void pictureBox116_Click_1(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/Ep7nd4HD"));
    }

    private void label131_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/4513114459/Fortress-Simulator-SAVE-SYSTEM");
    }

    private void pictureBox129_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://eprx.000webhostapp.com/scripts/fortresssimulator"));
      int num = (int) MessageBox.Show("Kill Zombies will make you lag! ", nameof (FGameHubMain), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }

    private void label132_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/4379619839/TRADING-Lumberjack-Legends");
    }

    private void pictureBox130_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/GujZy0ab"));
    }

    private void label133_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/4704006941/5X-STATS-Blade-Throwing-Simulator");
    }

    private void pictureBox131_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/HcCX6Cp6"));
    }

    private void label135_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/162537373/Super-Blocky-Ball");
    }

    private void pictureBox133_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/se1NnxCg"));
    }

    private void label136_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/195845601/Castle-Heist-Adventure-OBBY-RPG");
    }

    private void pictureBox134_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://eprx.000webhostapp.com/scripts/castleheistadventure"));
    }

    private void label137_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/4737105677/Flamethrower-Simulator-NEW-ZONE");
    }

    private void pictureBox135_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/Xa2vUhkk"));
      int num = (int) MessageBox.Show("Everything Except Bring PowerUps Work! ", nameof (FGameHubMain), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }

    private void label134_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/39972972/Cake-Cars-Make-a-Cake-Back-for-Seconds");
    }

    private void pictureBox132_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://eprx.000webhostapp.com/scripts/makeacake"));
    }

    private void label138_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/2232225661/Katana-Simulator");
    }

    private void pictureBox136_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://aizen.ml/uploads/ksim.lua"));
    }

    private void label139_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/2281639237/UPDATE-Stands-Online-v014");
    }

    private void pictureBox137_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://maxv.ml/uploads/so.lua"));
    }

    private void label140_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/2312559973/FIXES-Oretary-Alpha#");
    }

    private void pictureBox138_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/pw3SAuef"));
    }

    private void pictureBox139_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/fCzJL5xQ"));
      int num = (int) MessageBox.Show("Some FE scripts might get you kicked! ", nameof (FGameHubMain), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }

    private void label141_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/4623386862/Piggy-ALPHA-CHAPTER-5");
    }

    private void label143_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/2546155523/RoVille");
    }

    private void label142_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/3725149043/Super-Doomspire");
    }

    private void pictureBox140_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/jbpeBGZD"));
      int num = (int) MessageBox.Show("After executing, it should collect all the chests! ", nameof (FGameHubMain), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }

    private void pictureBox141_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/paG30Gr8"));
    }

    private void label144_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/4072501860/SKILL-BALANCED-Ro-Slayers");
    }

    private void pictureBox142_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/nzvfUuic"));
      int num = (int) MessageBox.Show("After executing, it should autofarm! ", nameof (FGameHubMain), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }

    private void label145_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/70005410/Blox-Hunt-v2-7-13");
    }

    private void pictureBox143_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/cv4yFfQU"));
    }

    private void label109_Click_1(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/318978013/Kick-Off");
    }

    private void pictureBox107_Click_1(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("http://pastebin.com/raw/XQpZBUD5"));
    }

    private void label146_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/3454641910/SATURN-V-NEW-EFFECTS-Liftoff");
    }

    private void pictureBox144_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/nzvfUuic"));
      int num = (int) MessageBox.Show("After executing, you should get infinite money! ", nameof (FGameHubMain), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }

    private void label147_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/1417427737/Mining-Simulator");
    }

    private void pictureBox145_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/p4ihNBSw"));
      int num = (int) MessageBox.Show("Everything except Auto Sell and Auto Mine works! ", nameof (FGameHubMain), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }

    private void label148_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/4666617818/DESERT-Batting-Champions");
    }

    private void pictureBox146_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://ghostbin.co/paste/tcbuo/raw"));
    }

    private void label149_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/4572547530/NEW-Sizzling-Simulator");
    }

    private void pictureBox147_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/ZTcM4ZRE"));
    }

    private void label150_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/4743953901/ARCTIC-Soda-Simulator");
    }

    private void pictureBox148_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/F8Wr9C4t"));
    }

    private void label151_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/3671693224/YouTube-Tycoon");
    }

    private void pictureBox149_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/hb1aWL6b"));
      int num = (int) MessageBox.Show("After executing, it should autofarm money! ", nameof (FGameHubMain), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }

    private void label152_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/3813159701/Ninja-Tycoon");
    }

    private void pictureBox150_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/x1db9W2g"));
      int num = (int) MessageBox.Show("After executing, you should get infinite cash! ", nameof (FGameHubMain), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }

    private void label153_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/4254575069/x1000-COINS-Champion-Simulator");
    }

    private void pictureBox151_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/YBj7Uypt"));
    }

    private void label154_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/4186060228/RELEASE-Pickaxe-Simulator");
    }

    private void pictureBox152_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/WL5DjiCm"));
    }

    private void label155_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/2747834912/EGGHUNT-Eg");
    }

    private void pictureBox153_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/PqYFuNAA"));
      int num = (int) MessageBox.Show("After executing, it should autofarm money! ", nameof (FGameHubMain), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }

    private void label156_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/1992612043/Heroes-Online-2x-EXP");
    }

    private void pictureBox154_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://silverscripts.000webhostapp.com/Script.lua"));
    }

    private void label62_Click_1(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/2753915549/UPDATE-10-Blox-Fruits");
    }

    private void pictureBox58_Click_1(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/s6H3d4H9"));
    }

    private void label157_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/258258996/Miners-Haven-Reincarnation");
    }

    private void pictureBox155_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/pFAruFAJ"));
    }

    private void label158_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/189707/Natural-Disaster-Survival");
    }

    private void pictureBox156_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/bjgWZhDg"));
    }

    private void label159_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/4828705676/RELEASE-Reaper-Simulator-2");
    }

    private void pictureBox157_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/4553b6Rp"));
    }

    private void label160_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/178704642/FIXED-Ripull-Minigames");
    }

    private void pictureBox158_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/f1sUCsnG"));
    }

    private void label161_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/2042074173/Dancing-Simulator");
    }

    private void pictureBox159_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/fL79Mkfb"));
    }

    private void label162_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/1240123653/Zombie-Attack");
    }

    private void pictureBox160_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/tT2d7VxS"));
    }

    private void label163_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/2317712696/The-Wild-West");
    }

    private void pictureBox161_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/RNp4SaAf"));
    }

    private void label164_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/3494008884/Donut-Bakery-Tycoon-Autosave");
    }

    private void pictureBox162_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/rE1CiJGq"));
    }

    private void label165_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.roblox.com/games/4782725929/DOUBLE-Lifting-Legends");
    }

    private void pictureBox163_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/Ef6tAPyk"));
    }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {
    }

    private void button10_Click_2(object sender, EventArgs e)
    {
      if (DialogResult.Yes != MessageBox.Show("Are you sure you want to reinstall ROBLOX?", "Chaosity", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
        return;
      int num1 = (int) MessageBox.Show("Roblox is now reinstalling!\nThis could take a while, please wait patiently.", "Chaosity", MessageBoxButtons.OK);
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

    private void button12_Click_1(object sender, EventArgs e)
    {
      foreach (Process process in Process.GetProcessesByName("RobloxPlayerBeta"))
        process.Kill();
    }

    private void button18_Click(object sender, EventArgs e)
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

    private void button5_Click_1(object sender, EventArgs e)
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

    private void button7_Click_1(object sender, EventArgs e)
    {
      Chaosity chaosity = new Chaosity();
      this.Hide();
      chaosity.Show();
    }

    private void button9_Click_2(object sender, EventArgs e)
    {
      this.WindowState = FormWindowState.Minimized;
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void button11_Click_2(object sender, EventArgs e)
    {
      this.chaosityTabs.SelectTab("execPage");
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
    }

    private void InjectionButtonPannel_Click(object sender, EventArgs e)
    {
      this.chaosityTabs.SelectTab("scriptHub");
    }

    private void label2_Click_1(object sender, EventArgs e)
    {
      this.chaosityTabs.SelectTab("scriptHub");
    }

    private void cb2_CheckedChanged_1(object sender, EventArgs e)
    {
      if (this.cb2.Checked)
        NamedPipes.easy = true;
      else
        NamedPipes.easy = false;
    }

    private void cb1_CheckedChanged_1(object sender, EventArgs e)
    {
    }

    private void MultipleROBLOX_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.MultipleROBLOX.Checked)
        return;
      Mutex mutex = new Mutex(true, "ROBLOX_singletonMutex");
      int num = (int) MessageBox.Show("Multiple Roblox activated successfully, join on another account to enable another session.", "Multiple Roblox");
    }

    private void cb3_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void FGameHubMain_Leave(object sender, EventArgs e)
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FGameHubMain));
      this.border3 = new Panel();
      this.border1 = new Panel();
      this.border2 = new Panel();
      this.chaosityTabs = new TabControl();
      this.scriptHub = new TabPage();
      this.MultipleROBLOX = new CheckBox();
      this.button11 = new Button();
      this.button5 = new Button();
      this.button12 = new Button();
      this.button10 = new Button();
      this.button18 = new Button();
      this.cb2 = new CheckBox();
      this.flowLayoutPanel1 = new FlowLayoutPanel();
      this.panel6 = new Panel();
      this.label5 = new Label();
      this.pictureBox3 = new PictureBox();
      this.panel5 = new Panel();
      this.pictureBox4 = new PictureBox();
      this.label4 = new Label();
      this.panel7 = new Panel();
      this.pictureBox5 = new PictureBox();
      this.label6 = new Label();
      this.panel8 = new Panel();
      this.pictureBox6 = new PictureBox();
      this.label7 = new Label();
      this.panel9 = new Panel();
      this.pictureBox7 = new PictureBox();
      this.label8 = new Label();
      this.panel10 = new Panel();
      this.pictureBox8 = new PictureBox();
      this.label9 = new Label();
      this.panel11 = new Panel();
      this.pictureBox9 = new PictureBox();
      this.label10 = new Label();
      this.panel12 = new Panel();
      this.label11 = new Label();
      this.pictureBox10 = new PictureBox();
      this.panel13 = new Panel();
      this.label12 = new Label();
      this.pictureBox11 = new PictureBox();
      this.panel14 = new Panel();
      this.label13 = new Label();
      this.pictureBox12 = new PictureBox();
      this.panel20 = new Panel();
      this.label21 = new Label();
      this.pictureBox17 = new PictureBox();
      this.panel19 = new Panel();
      this.label20 = new Label();
      this.pictureBox16 = new PictureBox();
      this.panel18 = new Panel();
      this.label19 = new Label();
      this.pictureBox15 = new PictureBox();
      this.panel17 = new Panel();
      this.label18 = new Label();
      this.pictureBox2 = new PictureBox();
      this.panel15 = new Panel();
      this.label14 = new Label();
      this.pictureBox14 = new PictureBox();
      this.panel25 = new Panel();
      this.label26 = new Label();
      this.pictureBox22 = new PictureBox();
      this.panel23 = new Panel();
      this.label24 = new Label();
      this.pictureBox20 = new PictureBox();
      this.panel22 = new Panel();
      this.label23 = new Label();
      this.pictureBox19 = new PictureBox();
      this.panel21 = new Panel();
      this.label22 = new Label();
      this.pictureBox18 = new PictureBox();
      this.panel24 = new Panel();
      this.label25 = new Label();
      this.pictureBox21 = new PictureBox();
      this.panel16 = new Panel();
      this.label15 = new Label();
      this.pictureBox13 = new PictureBox();
      this.panel26 = new Panel();
      this.label27 = new Label();
      this.pictureBox23 = new PictureBox();
      this.panel27 = new Panel();
      this.label28 = new Label();
      this.pictureBox24 = new PictureBox();
      this.panel29 = new Panel();
      this.label30 = new Label();
      this.pictureBox26 = new PictureBox();
      this.panel30 = new Panel();
      this.label31 = new Label();
      this.pictureBox27 = new PictureBox();
      this.panel31 = new Panel();
      this.label32 = new Label();
      this.pictureBox28 = new PictureBox();
      this.panel32 = new Panel();
      this.label33 = new Label();
      this.pictureBox29 = new PictureBox();
      this.panel33 = new Panel();
      this.label34 = new Label();
      this.pictureBox30 = new PictureBox();
      this.panel34 = new Panel();
      this.label35 = new Label();
      this.pictureBox31 = new PictureBox();
      this.panel35 = new Panel();
      this.label36 = new Label();
      this.pictureBox32 = new PictureBox();
      this.panel37 = new Panel();
      this.label38 = new Label();
      this.pictureBox34 = new PictureBox();
      this.panel38 = new Panel();
      this.label39 = new Label();
      this.pictureBox35 = new PictureBox();
      this.panel39 = new Panel();
      this.label40 = new Label();
      this.pictureBox36 = new PictureBox();
      this.panel40 = new Panel();
      this.label41 = new Label();
      this.pictureBox37 = new PictureBox();
      this.panel41 = new Panel();
      this.label42 = new Label();
      this.pictureBox38 = new PictureBox();
      this.panel42 = new Panel();
      this.label43 = new Label();
      this.pictureBox39 = new PictureBox();
      this.panel43 = new Panel();
      this.label44 = new Label();
      this.pictureBox40 = new PictureBox();
      this.panel44 = new Panel();
      this.label45 = new Label();
      this.pictureBox41 = new PictureBox();
      this.panel46 = new Panel();
      this.label47 = new Label();
      this.pictureBox43 = new PictureBox();
      this.panel48 = new Panel();
      this.label49 = new Label();
      this.pictureBox45 = new PictureBox();
      this.panel49 = new Panel();
      this.label50 = new Label();
      this.pictureBox46 = new PictureBox();
      this.panel50 = new Panel();
      this.label51 = new Label();
      this.pictureBox47 = new PictureBox();
      this.panel51 = new Panel();
      this.label52 = new Label();
      this.pictureBox48 = new PictureBox();
      this.panel53 = new Panel();
      this.label54 = new Label();
      this.pictureBox50 = new PictureBox();
      this.panel54 = new Panel();
      this.label55 = new Label();
      this.pictureBox51 = new PictureBox();
      this.panel55 = new Panel();
      this.label56 = new Label();
      this.pictureBox52 = new PictureBox();
      this.panel56 = new Panel();
      this.label57 = new Label();
      this.pictureBox53 = new PictureBox();
      this.panel57 = new Panel();
      this.label58 = new Label();
      this.pictureBox54 = new PictureBox();
      this.panel60 = new Panel();
      this.label61 = new Label();
      this.pictureBox57 = new PictureBox();
      this.panel62 = new Panel();
      this.label63 = new Label();
      this.pictureBox59 = new PictureBox();
      this.panel63 = new Panel();
      this.label64 = new Label();
      this.pictureBox60 = new PictureBox();
      this.panel64 = new Panel();
      this.label65 = new Label();
      this.pictureBox61 = new PictureBox();
      this.panel65 = new Panel();
      this.label17 = new Label();
      this.pictureBox62 = new PictureBox();
      this.panel66 = new Panel();
      this.label66 = new Label();
      this.pictureBox63 = new PictureBox();
      this.panel28 = new Panel();
      this.label29 = new Label();
      this.pictureBox25 = new PictureBox();
      this.panel58 = new Panel();
      this.label59 = new Label();
      this.pictureBox55 = new PictureBox();
      this.panel67 = new Panel();
      this.label67 = new Label();
      this.pictureBox64 = new PictureBox();
      this.panel68 = new Panel();
      this.label68 = new Label();
      this.pictureBox65 = new PictureBox();
      this.panel69 = new Panel();
      this.label69 = new Label();
      this.pictureBox66 = new PictureBox();
      this.panel70 = new Panel();
      this.label70 = new Label();
      this.pictureBox67 = new PictureBox();
      this.panel72 = new Panel();
      this.label72 = new Label();
      this.pictureBox69 = new PictureBox();
      this.panel73 = new Panel();
      this.label73 = new Label();
      this.pictureBox70 = new PictureBox();
      this.panel74 = new Panel();
      this.label74 = new Label();
      this.pictureBox71 = new PictureBox();
      this.panel75 = new Panel();
      this.label75 = new Label();
      this.pictureBox72 = new PictureBox();
      this.panel76 = new Panel();
      this.label76 = new Label();
      this.pictureBox73 = new PictureBox();
      this.panel77 = new Panel();
      this.label77 = new Label();
      this.pictureBox74 = new PictureBox();
      this.panel78 = new Panel();
      this.label78 = new Label();
      this.pictureBox75 = new PictureBox();
      this.panel79 = new Panel();
      this.label79 = new Label();
      this.pictureBox76 = new PictureBox();
      this.panel80 = new Panel();
      this.label80 = new Label();
      this.pictureBox77 = new PictureBox();
      this.panel81 = new Panel();
      this.label81 = new Label();
      this.pictureBox78 = new PictureBox();
      this.panel82 = new Panel();
      this.label82 = new Label();
      this.pictureBox79 = new PictureBox();
      this.panel83 = new Panel();
      this.label83 = new Label();
      this.pictureBox80 = new PictureBox();
      this.panel85 = new Panel();
      this.label85 = new Label();
      this.pictureBox82 = new PictureBox();
      this.panel86 = new Panel();
      this.label86 = new Label();
      this.pictureBox83 = new PictureBox();
      this.panel87 = new Panel();
      this.label87 = new Label();
      this.pictureBox84 = new PictureBox();
      this.panel88 = new Panel();
      this.label88 = new Label();
      this.pictureBox85 = new PictureBox();
      this.panel89 = new Panel();
      this.label89 = new Label();
      this.pictureBox86 = new PictureBox();
      this.panel90 = new Panel();
      this.label90 = new Label();
      this.pictureBox87 = new PictureBox();
      this.panel91 = new Panel();
      this.label91 = new Label();
      this.pictureBox88 = new PictureBox();
      this.panel93 = new Panel();
      this.label93 = new Label();
      this.pictureBox90 = new PictureBox();
      this.panel94 = new Panel();
      this.label94 = new Label();
      this.pictureBox91 = new PictureBox();
      this.panel95 = new Panel();
      this.label95 = new Label();
      this.pictureBox92 = new PictureBox();
      this.panel97 = new Panel();
      this.label97 = new Label();
      this.pictureBox94 = new PictureBox();
      this.panel98 = new Panel();
      this.label98 = new Label();
      this.pictureBox95 = new PictureBox();
      this.panel99 = new Panel();
      this.label99 = new Label();
      this.pictureBox96 = new PictureBox();
      this.panel96 = new Panel();
      this.label96 = new Label();
      this.pictureBox93 = new PictureBox();
      this.panel100 = new Panel();
      this.label100 = new Label();
      this.pictureBox97 = new PictureBox();
      this.panel103 = new Panel();
      this.label102 = new Label();
      this.pictureBox100 = new PictureBox();
      this.panel101 = new Panel();
      this.label101 = new Label();
      this.pictureBox98 = new PictureBox();
      this.panel104 = new Panel();
      this.label103 = new Label();
      this.pictureBox101 = new PictureBox();
      this.panel105 = new Panel();
      this.label104 = new Label();
      this.pictureBox102 = new PictureBox();
      this.panel107 = new Panel();
      this.label106 = new Label();
      this.pictureBox104 = new PictureBox();
      this.panel108 = new Panel();
      this.label107 = new Label();
      this.pictureBox105 = new PictureBox();
      this.panel106 = new Panel();
      this.label105 = new Label();
      this.pictureBox103 = new PictureBox();
      this.panel102 = new Panel();
      this.label16 = new Label();
      this.pictureBox99 = new PictureBox();
      this.panel109 = new Panel();
      this.label108 = new Label();
      this.pictureBox106 = new PictureBox();
      this.panel111 = new Panel();
      this.label110 = new Label();
      this.pictureBox108 = new PictureBox();
      this.panel112 = new Panel();
      this.label111 = new Label();
      this.pictureBox109 = new PictureBox();
      this.panel113 = new Panel();
      this.label112 = new Label();
      this.pictureBox110 = new PictureBox();
      this.panel92 = new Panel();
      this.label92 = new Label();
      this.pictureBox89 = new PictureBox();
      this.panel114 = new Panel();
      this.label113 = new Label();
      this.pictureBox111 = new PictureBox();
      this.panel59 = new Panel();
      this.label60 = new Label();
      this.pictureBox56 = new PictureBox();
      this.panel115 = new Panel();
      this.label114 = new Label();
      this.pictureBox112 = new PictureBox();
      this.panel116 = new Panel();
      this.label115 = new Label();
      this.pictureBox113 = new PictureBox();
      this.panel117 = new Panel();
      this.label116 = new Label();
      this.pictureBox114 = new PictureBox();
      this.panel118 = new Panel();
      this.label117 = new Label();
      this.pictureBox115 = new PictureBox();
      this.panel120 = new Panel();
      this.label119 = new Label();
      this.pictureBox117 = new PictureBox();
      this.panel121 = new Panel();
      this.label120 = new Label();
      this.pictureBox118 = new PictureBox();
      this.panel122 = new Panel();
      this.label121 = new Label();
      this.pictureBox119 = new PictureBox();
      this.panel123 = new Panel();
      this.label122 = new Label();
      this.pictureBox120 = new PictureBox();
      this.panel124 = new Panel();
      this.label123 = new Label();
      this.pictureBox121 = new PictureBox();
      this.panel125 = new Panel();
      this.label124 = new Label();
      this.pictureBox122 = new PictureBox();
      this.panel126 = new Panel();
      this.label125 = new Label();
      this.pictureBox123 = new PictureBox();
      this.panel84 = new Panel();
      this.label84 = new Label();
      this.pictureBox81 = new PictureBox();
      this.panel127 = new Panel();
      this.label126 = new Label();
      this.pictureBox124 = new PictureBox();
      this.panel71 = new Panel();
      this.label71 = new Label();
      this.pictureBox68 = new PictureBox();
      this.panel128 = new Panel();
      this.label127 = new Label();
      this.pictureBox125 = new PictureBox();
      this.panel129 = new Panel();
      this.label128 = new Label();
      this.pictureBox126 = new PictureBox();
      this.panel130 = new Panel();
      this.label129 = new Label();
      this.pictureBox127 = new PictureBox();
      this.panel131 = new Panel();
      this.label130 = new Label();
      this.pictureBox128 = new PictureBox();
      this.panel119 = new Panel();
      this.label118 = new Label();
      this.pictureBox116 = new PictureBox();
      this.panel132 = new Panel();
      this.label131 = new Label();
      this.pictureBox129 = new PictureBox();
      this.panel133 = new Panel();
      this.label132 = new Label();
      this.pictureBox130 = new PictureBox();
      this.panel136 = new Panel();
      this.label135 = new Label();
      this.pictureBox133 = new PictureBox();
      this.panel137 = new Panel();
      this.label136 = new Label();
      this.pictureBox134 = new PictureBox();
      this.panel138 = new Panel();
      this.label137 = new Label();
      this.pictureBox135 = new PictureBox();
      this.panel135 = new Panel();
      this.label134 = new Label();
      this.pictureBox132 = new PictureBox();
      this.panel139 = new Panel();
      this.label138 = new Label();
      this.pictureBox136 = new PictureBox();
      this.panel140 = new Panel();
      this.label139 = new Label();
      this.pictureBox137 = new PictureBox();
      this.panel141 = new Panel();
      this.label140 = new Label();
      this.pictureBox138 = new PictureBox();
      this.panel142 = new Panel();
      this.label141 = new Label();
      this.pictureBox139 = new PictureBox();
      this.panel143 = new Panel();
      this.label142 = new Label();
      this.pictureBox140 = new PictureBox();
      this.panel144 = new Panel();
      this.label143 = new Label();
      this.pictureBox141 = new PictureBox();
      this.panel47 = new Panel();
      this.label48 = new Label();
      this.pictureBox44 = new PictureBox();
      this.panel145 = new Panel();
      this.label144 = new Label();
      this.pictureBox142 = new PictureBox();
      this.panel146 = new Panel();
      this.label145 = new Label();
      this.pictureBox143 = new PictureBox();
      this.panel110 = new Panel();
      this.label109 = new Label();
      this.pictureBox107 = new PictureBox();
      this.panel147 = new Panel();
      this.label146 = new Label();
      this.pictureBox144 = new PictureBox();
      this.panel148 = new Panel();
      this.label147 = new Label();
      this.pictureBox145 = new PictureBox();
      this.panel149 = new Panel();
      this.label148 = new Label();
      this.pictureBox146 = new PictureBox();
      this.panel150 = new Panel();
      this.label149 = new Label();
      this.pictureBox147 = new PictureBox();
      this.panel151 = new Panel();
      this.label150 = new Label();
      this.pictureBox148 = new PictureBox();
      this.panel152 = new Panel();
      this.label151 = new Label();
      this.pictureBox149 = new PictureBox();
      this.panel153 = new Panel();
      this.label152 = new Label();
      this.pictureBox150 = new PictureBox();
      this.panel134 = new Panel();
      this.label133 = new Label();
      this.pictureBox131 = new PictureBox();
      this.panel45 = new Panel();
      this.label46 = new Label();
      this.pictureBox42 = new PictureBox();
      this.panel154 = new Panel();
      this.label153 = new Label();
      this.pictureBox151 = new PictureBox();
      this.panel155 = new Panel();
      this.label154 = new Label();
      this.pictureBox152 = new PictureBox();
      this.panel156 = new Panel();
      this.label155 = new Label();
      this.pictureBox153 = new PictureBox();
      this.panel157 = new Panel();
      this.label156 = new Label();
      this.pictureBox154 = new PictureBox();
      this.panel61 = new Panel();
      this.label62 = new Label();
      this.pictureBox58 = new PictureBox();
      this.panel52 = new Panel();
      this.label53 = new Label();
      this.pictureBox49 = new PictureBox();
      this.panel158 = new Panel();
      this.label157 = new Label();
      this.pictureBox155 = new PictureBox();
      this.panel159 = new Panel();
      this.label158 = new Label();
      this.pictureBox156 = new PictureBox();
      this.panel160 = new Panel();
      this.label159 = new Label();
      this.pictureBox157 = new PictureBox();
      this.panel161 = new Panel();
      this.label160 = new Label();
      this.pictureBox158 = new PictureBox();
      this.panel162 = new Panel();
      this.label161 = new Label();
      this.pictureBox159 = new PictureBox();
      this.panel163 = new Panel();
      this.label162 = new Label();
      this.pictureBox160 = new PictureBox();
      this.panel164 = new Panel();
      this.label163 = new Label();
      this.pictureBox161 = new PictureBox();
      this.panel165 = new Panel();
      this.label164 = new Label();
      this.pictureBox162 = new PictureBox();
      this.panel166 = new Panel();
      this.label165 = new Label();
      this.pictureBox163 = new PictureBox();
      this.execPage = new TabPage();
      this.listBox1 = new ListBox();
      this.button8 = new Button();
      this.button6 = new Button();
      this.button3 = new Button();
      this.button4 = new Button();
      this.button1 = new Button();
      this.webBrowser1 = new WebBrowser();
      this.button2 = new Button();
      this.panel1 = new Panel();
      this.panel2 = new Panel();
      this.panel3 = new Panel();
      this.panel4 = new Panel();
      this.contextMenuStrip1 = new ContextMenuStrip(this.components);
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.topBar = new Panel();
      this.InjectionButtonPannel = new Button();
      this.label2 = new Label();
      this.button9 = new Button();
      this.button7 = new Button();
      this.pictureBox1 = new PictureBox();
      this.chaosityTabs.SuspendLayout();
      this.scriptHub.SuspendLayout();
      this.flowLayoutPanel1.SuspendLayout();
      this.panel6.SuspendLayout();
      ((ISupportInitialize) this.pictureBox3).BeginInit();
      this.panel5.SuspendLayout();
      ((ISupportInitialize) this.pictureBox4).BeginInit();
      this.panel7.SuspendLayout();
      ((ISupportInitialize) this.pictureBox5).BeginInit();
      this.panel8.SuspendLayout();
      ((ISupportInitialize) this.pictureBox6).BeginInit();
      this.panel9.SuspendLayout();
      ((ISupportInitialize) this.pictureBox7).BeginInit();
      this.panel10.SuspendLayout();
      ((ISupportInitialize) this.pictureBox8).BeginInit();
      this.panel11.SuspendLayout();
      ((ISupportInitialize) this.pictureBox9).BeginInit();
      this.panel12.SuspendLayout();
      ((ISupportInitialize) this.pictureBox10).BeginInit();
      this.panel13.SuspendLayout();
      ((ISupportInitialize) this.pictureBox11).BeginInit();
      this.panel14.SuspendLayout();
      ((ISupportInitialize) this.pictureBox12).BeginInit();
      this.panel20.SuspendLayout();
      ((ISupportInitialize) this.pictureBox17).BeginInit();
      this.panel19.SuspendLayout();
      ((ISupportInitialize) this.pictureBox16).BeginInit();
      this.panel18.SuspendLayout();
      ((ISupportInitialize) this.pictureBox15).BeginInit();
      this.panel17.SuspendLayout();
      ((ISupportInitialize) this.pictureBox2).BeginInit();
      this.panel15.SuspendLayout();
      ((ISupportInitialize) this.pictureBox14).BeginInit();
      this.panel25.SuspendLayout();
      ((ISupportInitialize) this.pictureBox22).BeginInit();
      this.panel23.SuspendLayout();
      ((ISupportInitialize) this.pictureBox20).BeginInit();
      this.panel22.SuspendLayout();
      ((ISupportInitialize) this.pictureBox19).BeginInit();
      this.panel21.SuspendLayout();
      ((ISupportInitialize) this.pictureBox18).BeginInit();
      this.panel24.SuspendLayout();
      ((ISupportInitialize) this.pictureBox21).BeginInit();
      this.panel16.SuspendLayout();
      ((ISupportInitialize) this.pictureBox13).BeginInit();
      this.panel26.SuspendLayout();
      ((ISupportInitialize) this.pictureBox23).BeginInit();
      this.panel27.SuspendLayout();
      ((ISupportInitialize) this.pictureBox24).BeginInit();
      this.panel29.SuspendLayout();
      ((ISupportInitialize) this.pictureBox26).BeginInit();
      this.panel30.SuspendLayout();
      ((ISupportInitialize) this.pictureBox27).BeginInit();
      this.panel31.SuspendLayout();
      ((ISupportInitialize) this.pictureBox28).BeginInit();
      this.panel32.SuspendLayout();
      ((ISupportInitialize) this.pictureBox29).BeginInit();
      this.panel33.SuspendLayout();
      ((ISupportInitialize) this.pictureBox30).BeginInit();
      this.panel34.SuspendLayout();
      ((ISupportInitialize) this.pictureBox31).BeginInit();
      this.panel35.SuspendLayout();
      ((ISupportInitialize) this.pictureBox32).BeginInit();
      this.panel37.SuspendLayout();
      ((ISupportInitialize) this.pictureBox34).BeginInit();
      this.panel38.SuspendLayout();
      ((ISupportInitialize) this.pictureBox35).BeginInit();
      this.panel39.SuspendLayout();
      ((ISupportInitialize) this.pictureBox36).BeginInit();
      this.panel40.SuspendLayout();
      ((ISupportInitialize) this.pictureBox37).BeginInit();
      this.panel41.SuspendLayout();
      ((ISupportInitialize) this.pictureBox38).BeginInit();
      this.panel42.SuspendLayout();
      ((ISupportInitialize) this.pictureBox39).BeginInit();
      this.panel43.SuspendLayout();
      ((ISupportInitialize) this.pictureBox40).BeginInit();
      this.panel44.SuspendLayout();
      ((ISupportInitialize) this.pictureBox41).BeginInit();
      this.panel46.SuspendLayout();
      ((ISupportInitialize) this.pictureBox43).BeginInit();
      this.panel48.SuspendLayout();
      ((ISupportInitialize) this.pictureBox45).BeginInit();
      this.panel49.SuspendLayout();
      ((ISupportInitialize) this.pictureBox46).BeginInit();
      this.panel50.SuspendLayout();
      ((ISupportInitialize) this.pictureBox47).BeginInit();
      this.panel51.SuspendLayout();
      ((ISupportInitialize) this.pictureBox48).BeginInit();
      this.panel53.SuspendLayout();
      ((ISupportInitialize) this.pictureBox50).BeginInit();
      this.panel54.SuspendLayout();
      ((ISupportInitialize) this.pictureBox51).BeginInit();
      this.panel55.SuspendLayout();
      ((ISupportInitialize) this.pictureBox52).BeginInit();
      this.panel56.SuspendLayout();
      ((ISupportInitialize) this.pictureBox53).BeginInit();
      this.panel57.SuspendLayout();
      ((ISupportInitialize) this.pictureBox54).BeginInit();
      this.panel60.SuspendLayout();
      ((ISupportInitialize) this.pictureBox57).BeginInit();
      this.panel62.SuspendLayout();
      ((ISupportInitialize) this.pictureBox59).BeginInit();
      this.panel63.SuspendLayout();
      ((ISupportInitialize) this.pictureBox60).BeginInit();
      this.panel64.SuspendLayout();
      ((ISupportInitialize) this.pictureBox61).BeginInit();
      this.panel65.SuspendLayout();
      ((ISupportInitialize) this.pictureBox62).BeginInit();
      this.panel66.SuspendLayout();
      ((ISupportInitialize) this.pictureBox63).BeginInit();
      this.panel28.SuspendLayout();
      ((ISupportInitialize) this.pictureBox25).BeginInit();
      this.panel58.SuspendLayout();
      ((ISupportInitialize) this.pictureBox55).BeginInit();
      this.panel67.SuspendLayout();
      ((ISupportInitialize) this.pictureBox64).BeginInit();
      this.panel68.SuspendLayout();
      ((ISupportInitialize) this.pictureBox65).BeginInit();
      this.panel69.SuspendLayout();
      ((ISupportInitialize) this.pictureBox66).BeginInit();
      this.panel70.SuspendLayout();
      ((ISupportInitialize) this.pictureBox67).BeginInit();
      this.panel72.SuspendLayout();
      ((ISupportInitialize) this.pictureBox69).BeginInit();
      this.panel73.SuspendLayout();
      ((ISupportInitialize) this.pictureBox70).BeginInit();
      this.panel74.SuspendLayout();
      ((ISupportInitialize) this.pictureBox71).BeginInit();
      this.panel75.SuspendLayout();
      ((ISupportInitialize) this.pictureBox72).BeginInit();
      this.panel76.SuspendLayout();
      ((ISupportInitialize) this.pictureBox73).BeginInit();
      this.panel77.SuspendLayout();
      ((ISupportInitialize) this.pictureBox74).BeginInit();
      this.panel78.SuspendLayout();
      ((ISupportInitialize) this.pictureBox75).BeginInit();
      this.panel79.SuspendLayout();
      ((ISupportInitialize) this.pictureBox76).BeginInit();
      this.panel80.SuspendLayout();
      ((ISupportInitialize) this.pictureBox77).BeginInit();
      this.panel81.SuspendLayout();
      ((ISupportInitialize) this.pictureBox78).BeginInit();
      this.panel82.SuspendLayout();
      ((ISupportInitialize) this.pictureBox79).BeginInit();
      this.panel83.SuspendLayout();
      ((ISupportInitialize) this.pictureBox80).BeginInit();
      this.panel85.SuspendLayout();
      ((ISupportInitialize) this.pictureBox82).BeginInit();
      this.panel86.SuspendLayout();
      ((ISupportInitialize) this.pictureBox83).BeginInit();
      this.panel87.SuspendLayout();
      ((ISupportInitialize) this.pictureBox84).BeginInit();
      this.panel88.SuspendLayout();
      ((ISupportInitialize) this.pictureBox85).BeginInit();
      this.panel89.SuspendLayout();
      ((ISupportInitialize) this.pictureBox86).BeginInit();
      this.panel90.SuspendLayout();
      ((ISupportInitialize) this.pictureBox87).BeginInit();
      this.panel91.SuspendLayout();
      ((ISupportInitialize) this.pictureBox88).BeginInit();
      this.panel93.SuspendLayout();
      ((ISupportInitialize) this.pictureBox90).BeginInit();
      this.panel94.SuspendLayout();
      ((ISupportInitialize) this.pictureBox91).BeginInit();
      this.panel95.SuspendLayout();
      ((ISupportInitialize) this.pictureBox92).BeginInit();
      this.panel97.SuspendLayout();
      ((ISupportInitialize) this.pictureBox94).BeginInit();
      this.panel98.SuspendLayout();
      ((ISupportInitialize) this.pictureBox95).BeginInit();
      this.panel99.SuspendLayout();
      ((ISupportInitialize) this.pictureBox96).BeginInit();
      this.panel96.SuspendLayout();
      ((ISupportInitialize) this.pictureBox93).BeginInit();
      this.panel100.SuspendLayout();
      ((ISupportInitialize) this.pictureBox97).BeginInit();
      this.panel103.SuspendLayout();
      ((ISupportInitialize) this.pictureBox100).BeginInit();
      this.panel101.SuspendLayout();
      ((ISupportInitialize) this.pictureBox98).BeginInit();
      this.panel104.SuspendLayout();
      ((ISupportInitialize) this.pictureBox101).BeginInit();
      this.panel105.SuspendLayout();
      ((ISupportInitialize) this.pictureBox102).BeginInit();
      this.panel107.SuspendLayout();
      ((ISupportInitialize) this.pictureBox104).BeginInit();
      this.panel108.SuspendLayout();
      ((ISupportInitialize) this.pictureBox105).BeginInit();
      this.panel106.SuspendLayout();
      ((ISupportInitialize) this.pictureBox103).BeginInit();
      this.panel102.SuspendLayout();
      ((ISupportInitialize) this.pictureBox99).BeginInit();
      this.panel109.SuspendLayout();
      ((ISupportInitialize) this.pictureBox106).BeginInit();
      this.panel111.SuspendLayout();
      ((ISupportInitialize) this.pictureBox108).BeginInit();
      this.panel112.SuspendLayout();
      ((ISupportInitialize) this.pictureBox109).BeginInit();
      this.panel113.SuspendLayout();
      ((ISupportInitialize) this.pictureBox110).BeginInit();
      this.panel92.SuspendLayout();
      ((ISupportInitialize) this.pictureBox89).BeginInit();
      this.panel114.SuspendLayout();
      ((ISupportInitialize) this.pictureBox111).BeginInit();
      this.panel59.SuspendLayout();
      ((ISupportInitialize) this.pictureBox56).BeginInit();
      this.panel115.SuspendLayout();
      ((ISupportInitialize) this.pictureBox112).BeginInit();
      this.panel116.SuspendLayout();
      ((ISupportInitialize) this.pictureBox113).BeginInit();
      this.panel117.SuspendLayout();
      ((ISupportInitialize) this.pictureBox114).BeginInit();
      this.panel118.SuspendLayout();
      ((ISupportInitialize) this.pictureBox115).BeginInit();
      this.panel120.SuspendLayout();
      ((ISupportInitialize) this.pictureBox117).BeginInit();
      this.panel121.SuspendLayout();
      ((ISupportInitialize) this.pictureBox118).BeginInit();
      this.panel122.SuspendLayout();
      ((ISupportInitialize) this.pictureBox119).BeginInit();
      this.panel123.SuspendLayout();
      ((ISupportInitialize) this.pictureBox120).BeginInit();
      this.panel124.SuspendLayout();
      ((ISupportInitialize) this.pictureBox121).BeginInit();
      this.panel125.SuspendLayout();
      ((ISupportInitialize) this.pictureBox122).BeginInit();
      this.panel126.SuspendLayout();
      ((ISupportInitialize) this.pictureBox123).BeginInit();
      this.panel84.SuspendLayout();
      ((ISupportInitialize) this.pictureBox81).BeginInit();
      this.panel127.SuspendLayout();
      ((ISupportInitialize) this.pictureBox124).BeginInit();
      this.panel71.SuspendLayout();
      ((ISupportInitialize) this.pictureBox68).BeginInit();
      this.panel128.SuspendLayout();
      ((ISupportInitialize) this.pictureBox125).BeginInit();
      this.panel129.SuspendLayout();
      ((ISupportInitialize) this.pictureBox126).BeginInit();
      this.panel130.SuspendLayout();
      ((ISupportInitialize) this.pictureBox127).BeginInit();
      this.panel131.SuspendLayout();
      ((ISupportInitialize) this.pictureBox128).BeginInit();
      this.panel119.SuspendLayout();
      ((ISupportInitialize) this.pictureBox116).BeginInit();
      this.panel132.SuspendLayout();
      ((ISupportInitialize) this.pictureBox129).BeginInit();
      this.panel133.SuspendLayout();
      ((ISupportInitialize) this.pictureBox130).BeginInit();
      this.panel136.SuspendLayout();
      ((ISupportInitialize) this.pictureBox133).BeginInit();
      this.panel137.SuspendLayout();
      ((ISupportInitialize) this.pictureBox134).BeginInit();
      this.panel138.SuspendLayout();
      ((ISupportInitialize) this.pictureBox135).BeginInit();
      this.panel135.SuspendLayout();
      ((ISupportInitialize) this.pictureBox132).BeginInit();
      this.panel139.SuspendLayout();
      ((ISupportInitialize) this.pictureBox136).BeginInit();
      this.panel140.SuspendLayout();
      ((ISupportInitialize) this.pictureBox137).BeginInit();
      this.panel141.SuspendLayout();
      ((ISupportInitialize) this.pictureBox138).BeginInit();
      this.panel142.SuspendLayout();
      ((ISupportInitialize) this.pictureBox139).BeginInit();
      this.panel143.SuspendLayout();
      ((ISupportInitialize) this.pictureBox140).BeginInit();
      this.panel144.SuspendLayout();
      ((ISupportInitialize) this.pictureBox141).BeginInit();
      this.panel47.SuspendLayout();
      ((ISupportInitialize) this.pictureBox44).BeginInit();
      this.panel145.SuspendLayout();
      ((ISupportInitialize) this.pictureBox142).BeginInit();
      this.panel146.SuspendLayout();
      ((ISupportInitialize) this.pictureBox143).BeginInit();
      this.panel110.SuspendLayout();
      ((ISupportInitialize) this.pictureBox107).BeginInit();
      this.panel147.SuspendLayout();
      ((ISupportInitialize) this.pictureBox144).BeginInit();
      this.panel148.SuspendLayout();
      ((ISupportInitialize) this.pictureBox145).BeginInit();
      this.panel149.SuspendLayout();
      ((ISupportInitialize) this.pictureBox146).BeginInit();
      this.panel150.SuspendLayout();
      ((ISupportInitialize) this.pictureBox147).BeginInit();
      this.panel151.SuspendLayout();
      ((ISupportInitialize) this.pictureBox148).BeginInit();
      this.panel152.SuspendLayout();
      ((ISupportInitialize) this.pictureBox149).BeginInit();
      this.panel153.SuspendLayout();
      ((ISupportInitialize) this.pictureBox150).BeginInit();
      this.panel134.SuspendLayout();
      ((ISupportInitialize) this.pictureBox131).BeginInit();
      this.panel45.SuspendLayout();
      ((ISupportInitialize) this.pictureBox42).BeginInit();
      this.panel154.SuspendLayout();
      ((ISupportInitialize) this.pictureBox151).BeginInit();
      this.panel155.SuspendLayout();
      ((ISupportInitialize) this.pictureBox152).BeginInit();
      this.panel156.SuspendLayout();
      ((ISupportInitialize) this.pictureBox153).BeginInit();
      this.panel157.SuspendLayout();
      ((ISupportInitialize) this.pictureBox154).BeginInit();
      this.panel61.SuspendLayout();
      ((ISupportInitialize) this.pictureBox58).BeginInit();
      this.panel52.SuspendLayout();
      ((ISupportInitialize) this.pictureBox49).BeginInit();
      this.panel158.SuspendLayout();
      ((ISupportInitialize) this.pictureBox155).BeginInit();
      this.panel159.SuspendLayout();
      ((ISupportInitialize) this.pictureBox156).BeginInit();
      this.panel160.SuspendLayout();
      ((ISupportInitialize) this.pictureBox157).BeginInit();
      this.panel161.SuspendLayout();
      ((ISupportInitialize) this.pictureBox158).BeginInit();
      this.panel162.SuspendLayout();
      ((ISupportInitialize) this.pictureBox159).BeginInit();
      this.panel163.SuspendLayout();
      ((ISupportInitialize) this.pictureBox160).BeginInit();
      this.panel164.SuspendLayout();
      ((ISupportInitialize) this.pictureBox161).BeginInit();
      this.panel165.SuspendLayout();
      ((ISupportInitialize) this.pictureBox162).BeginInit();
      this.panel166.SuspendLayout();
      ((ISupportInitialize) this.pictureBox163).BeginInit();
      this.execPage.SuspendLayout();
      this.topBar.SuspendLayout();
      ((ISupportInitialize) this.pictureBox1).BeginInit();
      this.SuspendLayout();
      this.border3.BackColor = System.Drawing.Color.Black;
      this.border3.Dock = DockStyle.Left;
      this.border3.Location = new Point(0, 30);
      this.border3.Name = "border3";
      this.border3.Size = new Size(5, 308);
      this.border3.TabIndex = 1;
      this.border1.BackColor = System.Drawing.Color.Black;
      this.border1.Dock = DockStyle.Right;
      this.border1.Location = new Point(589, 30);
      this.border1.Name = "border1";
      this.border1.Size = new Size(5, 308);
      this.border1.TabIndex = 2;
      this.border2.BackColor = System.Drawing.Color.Black;
      this.border2.Dock = DockStyle.Bottom;
      this.border2.Location = new Point(5, 333);
      this.border2.Name = "border2";
      this.border2.Size = new Size(584, 5);
      this.border2.TabIndex = 3;
      this.chaosityTabs.Appearance = TabAppearance.FlatButtons;
      this.chaosityTabs.Controls.Add((Control) this.scriptHub);
      this.chaosityTabs.Controls.Add((Control) this.execPage);
      this.chaosityTabs.ItemSize = new Size(0, 1);
      this.chaosityTabs.Location = new Point(12, 38);
      this.chaosityTabs.Name = "chaosityTabs";
      this.chaosityTabs.SelectedIndex = 0;
      this.chaosityTabs.Size = new Size(572, 291);
      this.chaosityTabs.TabIndex = 4;
      this.scriptHub.BackColor = System.Drawing.Color.Black;
      this.scriptHub.Controls.Add((Control) this.MultipleROBLOX);
      this.scriptHub.Controls.Add((Control) this.button11);
      this.scriptHub.Controls.Add((Control) this.button5);
      this.scriptHub.Controls.Add((Control) this.button12);
      this.scriptHub.Controls.Add((Control) this.button10);
      this.scriptHub.Controls.Add((Control) this.button18);
      this.scriptHub.Controls.Add((Control) this.cb2);
      this.scriptHub.Controls.Add((Control) this.flowLayoutPanel1);
      this.scriptHub.Location = new Point(4, 5);
      this.scriptHub.Name = "scriptHub";
      this.scriptHub.Padding = new Padding(3);
      this.scriptHub.Size = new Size(564, 282);
      this.scriptHub.TabIndex = 1;
      this.scriptHub.Text = "tabPage2";
      this.scriptHub.Click += new EventHandler(this.scriptHub_Click);
      this.MultipleROBLOX.AutoSize = true;
      this.MultipleROBLOX.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.MultipleROBLOX.ForeColor = System.Drawing.Color.White;
      this.MultipleROBLOX.Location = new Point(439, 33);
      this.MultipleROBLOX.Name = "MultipleROBLOX";
      this.MultipleROBLOX.Size = new Size(113, 17);
      this.MultipleROBLOX.TabIndex = 113;
      this.MultipleROBLOX.Text = "Multiple ROBLOX";
      this.MultipleROBLOX.UseVisualStyleBackColor = true;
      this.MultipleROBLOX.CheckedChanged += new EventHandler(this.MultipleROBLOX_CheckedChanged);
      this.button11.BackColor = System.Drawing.Color.Transparent;
      this.button11.Cursor = Cursors.Hand;
      this.button11.FlatAppearance.BorderColor = System.Drawing.Color.White;
      this.button11.FlatAppearance.BorderSize = 3;
      this.button11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(74, 174, 89);
      this.button11.FlatStyle = FlatStyle.Flat;
      this.button11.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.button11.ForeColor = System.Drawing.Color.White;
      this.button11.Location = new Point(299, 54);
      this.button11.Name = "button11";
      this.button11.Size = new Size(135, 34);
      this.button11.TabIndex = 112;
      this.button11.Text = "Executor";
      this.button11.UseVisualStyleBackColor = false;
      this.button11.Click += new EventHandler(this.button11_Click_2);
      this.button5.BackColor = System.Drawing.Color.Transparent;
      this.button5.Cursor = Cursors.Hand;
      this.button5.FlatAppearance.BorderColor = System.Drawing.Color.White;
      this.button5.FlatAppearance.BorderSize = 3;
      this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(74, 174, 89);
      this.button5.FlatStyle = FlatStyle.Flat;
      this.button5.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.button5.ForeColor = System.Drawing.Color.White;
      this.button5.Location = new Point(299, 13);
      this.button5.Name = "button5";
      this.button5.Size = new Size(135, 34);
      this.button5.TabIndex = 111;
      this.button5.Text = "Fix Injection Errors";
      this.button5.UseVisualStyleBackColor = false;
      this.button5.Click += new EventHandler(this.button5_Click_1);
      this.button12.BackColor = System.Drawing.Color.Transparent;
      this.button12.Cursor = Cursors.Hand;
      this.button12.FlatAppearance.BorderColor = System.Drawing.Color.White;
      this.button12.FlatAppearance.BorderSize = 3;
      this.button12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(74, 174, 89);
      this.button12.FlatStyle = FlatStyle.Flat;
      this.button12.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.button12.ForeColor = System.Drawing.Color.White;
      this.button12.Location = new Point(158, 53);
      this.button12.Name = "button12";
      this.button12.Size = new Size(135, 34);
      this.button12.TabIndex = 110;
      this.button12.Text = "Kill Roblox";
      this.button12.UseVisualStyleBackColor = false;
      this.button12.Click += new EventHandler(this.button12_Click_1);
      this.button10.BackColor = System.Drawing.Color.Transparent;
      this.button10.Cursor = Cursors.Hand;
      this.button10.FlatAppearance.BorderColor = System.Drawing.Color.White;
      this.button10.FlatAppearance.BorderSize = 3;
      this.button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(74, 174, 89);
      this.button10.FlatStyle = FlatStyle.Flat;
      this.button10.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.button10.ForeColor = System.Drawing.Color.White;
      this.button10.Location = new Point(158, 13);
      this.button10.Name = "button10";
      this.button10.Size = new Size(135, 34);
      this.button10.TabIndex = 109;
      this.button10.Text = "Re-Install Roblox";
      this.button10.UseVisualStyleBackColor = false;
      this.button10.Click += new EventHandler(this.button10_Click_2);
      this.button18.BackColor = System.Drawing.Color.Transparent;
      this.button18.Cursor = Cursors.Hand;
      this.button18.FlatAppearance.BorderColor = System.Drawing.Color.White;
      this.button18.FlatAppearance.BorderSize = 3;
      this.button18.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button18.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(74, 174, 89);
      this.button18.FlatStyle = FlatStyle.Flat;
      this.button18.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.button18.ForeColor = System.Drawing.Color.White;
      this.button18.Location = new Point(158, 93);
      this.button18.Name = "button18";
      this.button18.Size = new Size(135, 34);
      this.button18.TabIndex = 108;
      this.button18.Text = "Inject To Roblox";
      this.button18.UseVisualStyleBackColor = false;
      this.button18.Click += new EventHandler(this.button18_Click);
      this.cb2.AutoSize = true;
      this.cb2.Checked = true;
      this.cb2.CheckState = CheckState.Checked;
      this.cb2.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.cb2.ForeColor = System.Drawing.Color.White;
      this.cb2.Location = new Point(439, 13);
      this.cb2.Name = "cb2";
      this.cb2.Size = new Size(52, 17);
      this.cb2.TabIndex = 107;
      this.cb2.Text = "API 1";
      this.cb2.UseVisualStyleBackColor = true;
      this.cb2.CheckedChanged += new EventHandler(this.cb2_CheckedChanged_1);
      this.flowLayoutPanel1.AutoScroll = true;
      this.flowLayoutPanel1.Controls.Add((Control) this.panel6);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel5);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel7);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel8);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel9);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel10);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel11);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel12);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel13);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel14);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel20);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel19);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel18);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel17);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel15);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel25);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel23);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel22);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel21);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel24);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel16);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel26);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel27);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel29);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel30);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel31);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel32);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel33);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel34);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel35);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel37);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel38);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel39);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel40);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel41);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel42);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel43);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel44);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel46);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel48);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel49);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel50);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel51);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel53);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel54);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel55);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel56);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel57);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel60);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel62);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel63);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel64);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel65);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel66);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel28);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel58);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel67);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel68);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel69);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel70);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel72);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel73);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel74);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel75);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel76);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel77);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel78);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel79);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel80);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel81);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel82);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel83);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel85);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel86);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel87);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel88);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel89);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel90);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel91);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel93);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel94);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel95);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel97);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel98);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel99);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel96);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel100);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel103);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel101);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel104);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel105);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel107);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel108);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel106);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel102);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel109);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel111);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel112);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel113);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel92);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel114);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel59);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel115);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel116);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel117);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel118);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel120);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel121);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel122);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel123);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel124);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel125);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel126);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel84);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel127);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel71);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel128);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel129);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel130);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel131);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel119);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel132);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel133);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel136);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel137);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel138);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel135);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel139);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel140);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel141);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel142);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel143);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel144);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel47);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel145);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel146);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel110);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel147);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel148);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel149);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel150);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel151);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel152);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel153);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel134);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel45);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel154);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel155);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel156);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel157);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel61);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel52);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel158);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel159);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel160);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel161);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel162);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel163);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel164);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel165);
      this.flowLayoutPanel1.Controls.Add((Control) this.panel166);
      this.flowLayoutPanel1.Location = new Point(7, 7);
      this.flowLayoutPanel1.Name = "flowLayoutPanel1";
      this.flowLayoutPanel1.Size = new Size(131, 268);
      this.flowLayoutPanel1.TabIndex = 9;
      this.flowLayoutPanel1.Paint += new PaintEventHandler(this.flowLayoutPanel1_Paint);
      this.panel6.Controls.Add((Control) this.label5);
      this.panel6.Controls.Add((Control) this.pictureBox3);
      this.panel6.Location = new Point(3, 3);
      this.panel6.Name = "panel6";
      this.panel6.Size = new Size(105, 125);
      this.panel6.TabIndex = 14;
      this.label5.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label5.ForeColor = System.Drawing.Color.White;
      this.label5.Location = new Point(4, 106);
      this.label5.Name = "label5";
      this.label5.Size = new Size(98, 19);
      this.label5.TabIndex = 1;
      this.label5.Text = "Ninja Legends";
      this.label5.TextAlign = ContentAlignment.MiddleCenter;
      this.label5.Click += new EventHandler(this.label5_Click);
      this.pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox3.Location = new Point(3, 3);
      this.pictureBox3.Name = "pictureBox3";
      this.pictureBox3.Size = new Size(100, 100);
      this.pictureBox3.TabIndex = 0;
      this.pictureBox3.TabStop = false;
      this.pictureBox3.Click += new EventHandler(this.pictureBox3_Click_1);
      this.panel5.Controls.Add((Control) this.pictureBox4);
      this.panel5.Controls.Add((Control) this.label4);
      this.panel5.Location = new Point(3, 134);
      this.panel5.Name = "panel5";
      this.panel5.Size = new Size(105, 125);
      this.panel5.TabIndex = 13;
      this.pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox4.Location = new Point(3, 3);
      this.pictureBox4.Name = "pictureBox4";
      this.pictureBox4.Size = new Size(100, 100);
      this.pictureBox4.TabIndex = 2;
      this.pictureBox4.TabStop = false;
      this.pictureBox4.Click += new EventHandler(this.pictureBox4_Click);
      this.label4.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label4.ForeColor = System.Drawing.Color.White;
      this.label4.Location = new Point(4, 106);
      this.label4.Name = "label4";
      this.label4.Size = new Size(98, 19);
      this.label4.TabIndex = 1;
      this.label4.Text = "Redwood Prison";
      this.label4.TextAlign = ContentAlignment.MiddleCenter;
      this.label4.Click += new EventHandler(this.label4_Click);
      this.panel7.Controls.Add((Control) this.pictureBox5);
      this.panel7.Controls.Add((Control) this.label6);
      this.panel7.Location = new Point(3, 265);
      this.panel7.Name = "panel7";
      this.panel7.Size = new Size(105, 125);
      this.panel7.TabIndex = 15;
      this.pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox5.Location = new Point(2, 3);
      this.pictureBox5.Name = "pictureBox5";
      this.pictureBox5.Size = new Size(100, 100);
      this.pictureBox5.TabIndex = 3;
      this.pictureBox5.TabStop = false;
      this.pictureBox5.Click += new EventHandler(this.pictureBox5_Click);
      this.label6.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label6.ForeColor = System.Drawing.Color.White;
      this.label6.Location = new Point(4, 106);
      this.label6.Name = "label6";
      this.label6.Size = new Size(98, 19);
      this.label6.TabIndex = 1;
      this.label6.Text = "Prison Life";
      this.label6.TextAlign = ContentAlignment.MiddleCenter;
      this.label6.Click += new EventHandler(this.label6_Click);
      this.panel8.Controls.Add((Control) this.pictureBox6);
      this.panel8.Controls.Add((Control) this.label7);
      this.panel8.Location = new Point(3, 396);
      this.panel8.Name = "panel8";
      this.panel8.Size = new Size(105, 125);
      this.panel8.TabIndex = 16;
      this.pictureBox6.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox6.Location = new Point(3, 3);
      this.pictureBox6.Name = "pictureBox6";
      this.pictureBox6.Size = new Size(100, 100);
      this.pictureBox6.TabIndex = 4;
      this.pictureBox6.TabStop = false;
      this.pictureBox6.Click += new EventHandler(this.pictureBox6_Click);
      this.label7.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label7.ForeColor = System.Drawing.Color.White;
      this.label7.Location = new Point(4, 106);
      this.label7.Name = "label7";
      this.label7.Size = new Size(98, 19);
      this.label7.TabIndex = 1;
      this.label7.Text = "Magnet Simulator";
      this.label7.TextAlign = ContentAlignment.MiddleCenter;
      this.label7.Click += new EventHandler(this.label7_Click);
      this.panel9.Controls.Add((Control) this.pictureBox7);
      this.panel9.Controls.Add((Control) this.label8);
      this.panel9.Location = new Point(3, 527);
      this.panel9.Name = "panel9";
      this.panel9.Size = new Size(105, 125);
      this.panel9.TabIndex = 17;
      this.pictureBox7.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox7.Location = new Point(3, 3);
      this.pictureBox7.Name = "pictureBox7";
      this.pictureBox7.Size = new Size(100, 100);
      this.pictureBox7.TabIndex = 5;
      this.pictureBox7.TabStop = false;
      this.pictureBox7.Click += new EventHandler(this.pictureBox7_Click);
      this.label8.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label8.ForeColor = System.Drawing.Color.White;
      this.label8.Location = new Point(4, 106);
      this.label8.Name = "label8";
      this.label8.Size = new Size(98, 19);
      this.label8.TabIndex = 1;
      this.label8.Text = "Lumber Tycoon 2";
      this.label8.TextAlign = ContentAlignment.MiddleCenter;
      this.label8.Click += new EventHandler(this.label8_Click);
      this.panel10.Controls.Add((Control) this.pictureBox8);
      this.panel10.Controls.Add((Control) this.label9);
      this.panel10.Location = new Point(3, 658);
      this.panel10.Name = "panel10";
      this.panel10.Size = new Size(105, 125);
      this.panel10.TabIndex = 18;
      this.pictureBox8.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox8.Location = new Point(2, 3);
      this.pictureBox8.Name = "pictureBox8";
      this.pictureBox8.Size = new Size(100, 100);
      this.pictureBox8.TabIndex = 6;
      this.pictureBox8.TabStop = false;
      this.pictureBox8.Click += new EventHandler(this.pictureBox8_Click);
      this.label9.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label9.ForeColor = System.Drawing.Color.White;
      this.label9.Location = new Point(4, 106);
      this.label9.Name = "label9";
      this.label9.Size = new Size(98, 19);
      this.label9.TabIndex = 1;
      this.label9.Text = "Vehicle Simulator";
      this.label9.TextAlign = ContentAlignment.MiddleCenter;
      this.label9.Click += new EventHandler(this.label9_Click);
      this.panel11.Controls.Add((Control) this.pictureBox9);
      this.panel11.Controls.Add((Control) this.label10);
      this.panel11.Location = new Point(3, 789);
      this.panel11.Name = "panel11";
      this.panel11.Size = new Size(105, 125);
      this.panel11.TabIndex = 19;
      this.pictureBox9.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox9.Location = new Point(2, 3);
      this.pictureBox9.Name = "pictureBox9";
      this.pictureBox9.Size = new Size(100, 100);
      this.pictureBox9.TabIndex = 7;
      this.pictureBox9.TabStop = false;
      this.pictureBox9.Click += new EventHandler(this.pictureBox9_Click);
      this.label10.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label10.ForeColor = System.Drawing.Color.White;
      this.label10.Location = new Point(4, 106);
      this.label10.Name = "label10";
      this.label10.Size = new Size(98, 19);
      this.label10.TabIndex = 1;
      this.label10.Text = "Lifting Simulator";
      this.label10.TextAlign = ContentAlignment.MiddleCenter;
      this.label10.Click += new EventHandler(this.label10_Click);
      this.panel12.Controls.Add((Control) this.label11);
      this.panel12.Controls.Add((Control) this.pictureBox10);
      this.panel12.Location = new Point(3, 920);
      this.panel12.Name = "panel12";
      this.panel12.Size = new Size(105, 125);
      this.panel12.TabIndex = 20;
      this.label11.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label11.ForeColor = System.Drawing.Color.White;
      this.label11.Location = new Point(4, 106);
      this.label11.Name = "label11";
      this.label11.Size = new Size(98, 19);
      this.label11.TabIndex = 1;
      this.label11.Text = "BIG Paintball";
      this.label11.TextAlign = ContentAlignment.MiddleCenter;
      this.label11.Click += new EventHandler(this.label11_Click);
      this.pictureBox10.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox10.Location = new Point(2, 3);
      this.pictureBox10.Name = "pictureBox10";
      this.pictureBox10.Size = new Size(100, 100);
      this.pictureBox10.TabIndex = 8;
      this.pictureBox10.TabStop = false;
      this.pictureBox10.Click += new EventHandler(this.pictureBox10_Click);
      this.panel13.Controls.Add((Control) this.label12);
      this.panel13.Controls.Add((Control) this.pictureBox11);
      this.panel13.Location = new Point(3, 1051);
      this.panel13.Name = "panel13";
      this.panel13.Size = new Size(105, 125);
      this.panel13.TabIndex = 21;
      this.label12.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label12.ForeColor = System.Drawing.Color.White;
      this.label12.Location = new Point(4, 106);
      this.label12.Name = "label12";
      this.label12.Size = new Size(98, 19);
      this.label12.TabIndex = 1;
      this.label12.Text = "Strucid";
      this.label12.TextAlign = ContentAlignment.MiddleCenter;
      this.label12.Click += new EventHandler(this.label12_Click);
      this.pictureBox11.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox11.Location = new Point(3, 3);
      this.pictureBox11.Name = "pictureBox11";
      this.pictureBox11.Size = new Size(100, 100);
      this.pictureBox11.TabIndex = 9;
      this.pictureBox11.TabStop = false;
      this.pictureBox11.Click += new EventHandler(this.pictureBox11_Click);
      this.panel14.Controls.Add((Control) this.label13);
      this.panel14.Controls.Add((Control) this.pictureBox12);
      this.panel14.Location = new Point(3, 1182);
      this.panel14.Name = "panel14";
      this.panel14.Size = new Size(105, 125);
      this.panel14.TabIndex = 22;
      this.label13.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label13.ForeColor = System.Drawing.Color.White;
      this.label13.Location = new Point(4, 106);
      this.label13.Name = "label13";
      this.label13.Size = new Size(98, 19);
      this.label13.TabIndex = 1;
      this.label13.Text = "Ro Ghoul";
      this.label13.TextAlign = ContentAlignment.MiddleCenter;
      this.label13.Click += new EventHandler(this.label13_Click);
      this.pictureBox12.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox12.Location = new Point(3, 3);
      this.pictureBox12.Name = "pictureBox12";
      this.pictureBox12.Size = new Size(100, 100);
      this.pictureBox12.TabIndex = 10;
      this.pictureBox12.TabStop = false;
      this.pictureBox12.Click += new EventHandler(this.pictureBox12_Click);
      this.panel20.Controls.Add((Control) this.label21);
      this.panel20.Controls.Add((Control) this.pictureBox17);
      this.panel20.Location = new Point(3, 1313);
      this.panel20.Name = "panel20";
      this.panel20.Size = new Size(105, 125);
      this.panel20.TabIndex = 25;
      this.label21.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label21.ForeColor = System.Drawing.Color.White;
      this.label21.Location = new Point(4, 106);
      this.label21.Name = "label21";
      this.label21.Size = new Size(98, 19);
      this.label21.TabIndex = 1;
      this.label21.Text = "Iron Man Sim";
      this.label21.TextAlign = ContentAlignment.MiddleCenter;
      this.label21.Click += new EventHandler(this.label21_Click);
      this.pictureBox17.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox17.Location = new Point(3, 3);
      this.pictureBox17.Name = "pictureBox17";
      this.pictureBox17.Size = new Size(100, 100);
      this.pictureBox17.TabIndex = 11;
      this.pictureBox17.TabStop = false;
      this.pictureBox17.Click += new EventHandler(this.pictureBox17_Click);
      this.panel19.Controls.Add((Control) this.label20);
      this.panel19.Controls.Add((Control) this.pictureBox16);
      this.panel19.Location = new Point(3, 1444);
      this.panel19.Name = "panel19";
      this.panel19.Size = new Size(105, 125);
      this.panel19.TabIndex = 25;
      this.label20.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label20.ForeColor = System.Drawing.Color.White;
      this.label20.Location = new Point(4, 106);
      this.label20.Name = "label20";
      this.label20.Size = new Size(98, 19);
      this.label20.TabIndex = 1;
      this.label20.Text = "Pet Ranch Sim 2";
      this.label20.TextAlign = ContentAlignment.MiddleCenter;
      this.label20.Click += new EventHandler(this.label20_Click);
      this.pictureBox16.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox16.Location = new Point(3, 3);
      this.pictureBox16.Name = "pictureBox16";
      this.pictureBox16.Size = new Size(100, 100);
      this.pictureBox16.TabIndex = 11;
      this.pictureBox16.TabStop = false;
      this.pictureBox16.Click += new EventHandler(this.pictureBox16_Click);
      this.panel18.Controls.Add((Control) this.label19);
      this.panel18.Controls.Add((Control) this.pictureBox15);
      this.panel18.Location = new Point(3, 1575);
      this.panel18.Name = "panel18";
      this.panel18.Size = new Size(105, 125);
      this.panel18.TabIndex = 25;
      this.label19.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label19.ForeColor = System.Drawing.Color.White;
      this.label19.Location = new Point(4, 106);
      this.label19.Name = "label19";
      this.label19.Size = new Size(98, 19);
      this.label19.TabIndex = 1;
      this.label19.Text = "Pet Simulator 2";
      this.label19.TextAlign = ContentAlignment.MiddleCenter;
      this.label19.Click += new EventHandler(this.label19_Click);
      this.pictureBox15.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox15.Location = new Point(3, 3);
      this.pictureBox15.Name = "pictureBox15";
      this.pictureBox15.Size = new Size(100, 100);
      this.pictureBox15.TabIndex = 11;
      this.pictureBox15.TabStop = false;
      this.pictureBox15.Click += new EventHandler(this.pictureBox15_Click);
      this.panel17.Controls.Add((Control) this.label18);
      this.panel17.Controls.Add((Control) this.pictureBox2);
      this.panel17.Location = new Point(3, 1706);
      this.panel17.Name = "panel17";
      this.panel17.Size = new Size(105, 125);
      this.panel17.TabIndex = 25;
      this.label18.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label18.ForeColor = System.Drawing.Color.White;
      this.label18.Location = new Point(4, 106);
      this.label18.Name = "label18";
      this.label18.Size = new Size(98, 19);
      this.label18.TabIndex = 1;
      this.label18.Text = "Gun Simulator";
      this.label18.TextAlign = ContentAlignment.MiddleCenter;
      this.label18.Click += new EventHandler(this.label18_Click);
      this.pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox2.Location = new Point(3, 3);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new Size(100, 100);
      this.pictureBox2.TabIndex = 11;
      this.pictureBox2.TabStop = false;
      this.pictureBox2.Click += new EventHandler(this.pictureBox2_Click_1);
      this.panel15.Controls.Add((Control) this.label14);
      this.panel15.Controls.Add((Control) this.pictureBox14);
      this.panel15.Location = new Point(3, 1837);
      this.panel15.Name = "panel15";
      this.panel15.Size = new Size(105, 125);
      this.panel15.TabIndex = 23;
      this.label14.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label14.ForeColor = System.Drawing.Color.White;
      this.label14.Location = new Point(4, 106);
      this.label14.Name = "label14";
      this.label14.Size = new Size(98, 19);
      this.label14.TabIndex = 1;
      this.label14.Text = "BeeSwarm Sim";
      this.label14.TextAlign = ContentAlignment.MiddleCenter;
      this.label14.Click += new EventHandler(this.label14_Click);
      this.pictureBox14.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox14.Location = new Point(3, 3);
      this.pictureBox14.Name = "pictureBox14";
      this.pictureBox14.Size = new Size(100, 100);
      this.pictureBox14.TabIndex = 12;
      this.pictureBox14.TabStop = false;
      this.pictureBox14.Click += new EventHandler(this.pictureBox14_Click);
      this.panel25.Controls.Add((Control) this.label26);
      this.panel25.Controls.Add((Control) this.pictureBox22);
      this.panel25.Location = new Point(3, 1968);
      this.panel25.Name = "panel25";
      this.panel25.Size = new Size(105, 125);
      this.panel25.TabIndex = 25;
      this.label26.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label26.ForeColor = System.Drawing.Color.White;
      this.label26.Location = new Point(4, 106);
      this.label26.Name = "label26";
      this.label26.Size = new Size(98, 19);
      this.label26.TabIndex = 1;
      this.label26.Text = "Giant Survival";
      this.label26.TextAlign = ContentAlignment.MiddleCenter;
      this.label26.Click += new EventHandler(this.label26_Click);
      this.pictureBox22.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox22.Location = new Point(3, 3);
      this.pictureBox22.Name = "pictureBox22";
      this.pictureBox22.Size = new Size(100, 100);
      this.pictureBox22.TabIndex = 11;
      this.pictureBox22.TabStop = false;
      this.pictureBox22.Click += new EventHandler(this.pictureBox22_Click);
      this.panel23.Controls.Add((Control) this.label24);
      this.panel23.Controls.Add((Control) this.pictureBox20);
      this.panel23.Location = new Point(3, 2099);
      this.panel23.Name = "panel23";
      this.panel23.Size = new Size(105, 125);
      this.panel23.TabIndex = 25;
      this.label24.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label24.ForeColor = System.Drawing.Color.White;
      this.label24.Location = new Point(4, 106);
      this.label24.Name = "label24";
      this.label24.Size = new Size(98, 19);
      this.label24.TabIndex = 1;
      this.label24.Text = "Wood Chop Sim";
      this.label24.TextAlign = ContentAlignment.MiddleCenter;
      this.label24.Click += new EventHandler(this.label24_Click);
      this.pictureBox20.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox20.Location = new Point(3, 3);
      this.pictureBox20.Name = "pictureBox20";
      this.pictureBox20.Size = new Size(100, 100);
      this.pictureBox20.TabIndex = 11;
      this.pictureBox20.TabStop = false;
      this.pictureBox20.Click += new EventHandler(this.pictureBox20_Click);
      this.panel22.Controls.Add((Control) this.label23);
      this.panel22.Controls.Add((Control) this.pictureBox19);
      this.panel22.Location = new Point(3, 2230);
      this.panel22.Name = "panel22";
      this.panel22.Size = new Size(105, 125);
      this.panel22.TabIndex = 25;
      this.label23.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label23.ForeColor = System.Drawing.Color.White;
      this.label23.Location = new Point(4, 106);
      this.label23.Name = "label23";
      this.label23.Size = new Size(98, 19);
      this.label23.TabIndex = 1;
      this.label23.Text = "Booga Booga";
      this.label23.TextAlign = ContentAlignment.MiddleCenter;
      this.label23.Click += new EventHandler(this.label23_Click);
      this.pictureBox19.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox19.Location = new Point(3, 3);
      this.pictureBox19.Name = "pictureBox19";
      this.pictureBox19.Size = new Size(100, 100);
      this.pictureBox19.TabIndex = 11;
      this.pictureBox19.TabStop = false;
      this.pictureBox19.Click += new EventHandler(this.pictureBox19_Click);
      this.panel21.Controls.Add((Control) this.label22);
      this.panel21.Controls.Add((Control) this.pictureBox18);
      this.panel21.Location = new Point(3, 2361);
      this.panel21.Name = "panel21";
      this.panel21.Size = new Size(105, 125);
      this.panel21.TabIndex = 25;
      this.label22.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label22.ForeColor = System.Drawing.Color.White;
      this.label22.Location = new Point(4, 106);
      this.label22.Name = "label22";
      this.label22.Size = new Size(98, 19);
      this.label22.TabIndex = 1;
      this.label22.Text = "Skywars";
      this.label22.TextAlign = ContentAlignment.MiddleCenter;
      this.label22.Click += new EventHandler(this.label22_Click);
      this.pictureBox18.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox18.Location = new Point(3, 3);
      this.pictureBox18.Name = "pictureBox18";
      this.pictureBox18.Size = new Size(100, 100);
      this.pictureBox18.TabIndex = 11;
      this.pictureBox18.TabStop = false;
      this.pictureBox18.Click += new EventHandler(this.pictureBox18_Click);
      this.panel24.Controls.Add((Control) this.label25);
      this.panel24.Controls.Add((Control) this.pictureBox21);
      this.panel24.Location = new Point(3, 2492);
      this.panel24.Name = "panel24";
      this.panel24.Size = new Size(105, 125);
      this.panel24.TabIndex = 25;
      this.label25.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label25.ForeColor = System.Drawing.Color.White;
      this.label25.Location = new Point(4, 106);
      this.label25.Name = "label25";
      this.label25.Size = new Size(98, 19);
      this.label25.TabIndex = 1;
      this.label25.Text = "Robot INC";
      this.label25.TextAlign = ContentAlignment.MiddleCenter;
      this.label25.Click += new EventHandler(this.label25_Click);
      this.pictureBox21.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox21.Location = new Point(3, 3);
      this.pictureBox21.Name = "pictureBox21";
      this.pictureBox21.Size = new Size(100, 100);
      this.pictureBox21.TabIndex = 11;
      this.pictureBox21.TabStop = false;
      this.pictureBox21.Click += new EventHandler(this.pictureBox21_Click);
      this.panel16.Controls.Add((Control) this.label15);
      this.panel16.Controls.Add((Control) this.pictureBox13);
      this.panel16.Location = new Point(3, 2623);
      this.panel16.Name = "panel16";
      this.panel16.Size = new Size(105, 125);
      this.panel16.TabIndex = 24;
      this.label15.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label15.ForeColor = System.Drawing.Color.White;
      this.label15.Location = new Point(4, 106);
      this.label15.Name = "label15";
      this.label15.Size = new Size(98, 19);
      this.label15.TabIndex = 1;
      this.label15.Text = "Flight Simulator";
      this.label15.TextAlign = ContentAlignment.MiddleCenter;
      this.label15.Click += new EventHandler(this.label15_Click);
      this.pictureBox13.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox13.Location = new Point(3, 3);
      this.pictureBox13.Name = "pictureBox13";
      this.pictureBox13.Size = new Size(100, 100);
      this.pictureBox13.TabIndex = 11;
      this.pictureBox13.TabStop = false;
      this.pictureBox13.Click += new EventHandler(this.pictureBox13_Click);
      this.panel26.Controls.Add((Control) this.label27);
      this.panel26.Controls.Add((Control) this.pictureBox23);
      this.panel26.Location = new Point(3, 2754);
      this.panel26.Name = "panel26";
      this.panel26.Size = new Size(105, 125);
      this.panel26.TabIndex = 25;
      this.label27.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label27.ForeColor = System.Drawing.Color.White;
      this.label27.Location = new Point(4, 106);
      this.label27.Name = "label27";
      this.label27.Size = new Size(98, 19);
      this.label27.TabIndex = 1;
      this.label27.Text = "Counter Blox";
      this.label27.TextAlign = ContentAlignment.MiddleCenter;
      this.label27.Click += new EventHandler(this.label27_Click);
      this.pictureBox23.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox23.Location = new Point(3, 3);
      this.pictureBox23.Name = "pictureBox23";
      this.pictureBox23.Size = new Size(100, 100);
      this.pictureBox23.TabIndex = 11;
      this.pictureBox23.TabStop = false;
      this.pictureBox23.Click += new EventHandler(this.pictureBox23_Click);
      this.panel27.Controls.Add((Control) this.label28);
      this.panel27.Controls.Add((Control) this.pictureBox24);
      this.panel27.Location = new Point(3, 2885);
      this.panel27.Name = "panel27";
      this.panel27.Size = new Size(105, 125);
      this.panel27.TabIndex = 26;
      this.label28.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label28.ForeColor = System.Drawing.Color.White;
      this.label28.Location = new Point(4, 106);
      this.label28.Name = "label28";
      this.label28.Size = new Size(98, 19);
      this.label28.TabIndex = 1;
      this.label28.Text = "Arsenal";
      this.label28.TextAlign = ContentAlignment.MiddleCenter;
      this.label28.Click += new EventHandler(this.label28_Click);
      this.pictureBox24.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox24.Location = new Point(3, 3);
      this.pictureBox24.Name = "pictureBox24";
      this.pictureBox24.Size = new Size(100, 100);
      this.pictureBox24.TabIndex = 11;
      this.pictureBox24.TabStop = false;
      this.pictureBox24.Click += new EventHandler(this.pictureBox24_Click);
      this.panel29.Controls.Add((Control) this.label30);
      this.panel29.Controls.Add((Control) this.pictureBox26);
      this.panel29.Location = new Point(3, 3016);
      this.panel29.Name = "panel29";
      this.panel29.Size = new Size(105, 125);
      this.panel29.TabIndex = 25;
      this.label30.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label30.ForeColor = System.Drawing.Color.White;
      this.label30.Location = new Point(4, 106);
      this.label30.Name = "label30";
      this.label30.Size = new Size(98, 19);
      this.label30.TabIndex = 1;
      this.label30.Text = "SharkBite";
      this.label30.TextAlign = ContentAlignment.MiddleCenter;
      this.label30.Click += new EventHandler(this.label30_Click);
      this.pictureBox26.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox26.Location = new Point(3, 3);
      this.pictureBox26.Name = "pictureBox26";
      this.pictureBox26.Size = new Size(100, 100);
      this.pictureBox26.TabIndex = 11;
      this.pictureBox26.TabStop = false;
      this.pictureBox26.Click += new EventHandler(this.pictureBox26_Click);
      this.panel30.Controls.Add((Control) this.label31);
      this.panel30.Controls.Add((Control) this.pictureBox27);
      this.panel30.Location = new Point(3, 3147);
      this.panel30.Name = "panel30";
      this.panel30.Size = new Size(105, 125);
      this.panel30.TabIndex = 26;
      this.label31.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label31.ForeColor = System.Drawing.Color.White;
      this.label31.Location = new Point(4, 106);
      this.label31.Name = "label31";
      this.label31.Size = new Size(98, 19);
      this.label31.TabIndex = 1;
      this.label31.Text = "Apocalypse-Rising";
      this.label31.TextAlign = ContentAlignment.MiddleCenter;
      this.label31.Click += new EventHandler(this.label31_Click);
      this.pictureBox27.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox27.Location = new Point(3, 3);
      this.pictureBox27.Name = "pictureBox27";
      this.pictureBox27.Size = new Size(100, 100);
      this.pictureBox27.TabIndex = 11;
      this.pictureBox27.TabStop = false;
      this.pictureBox27.Click += new EventHandler(this.pictureBox27_Click);
      this.panel31.Controls.Add((Control) this.label32);
      this.panel31.Controls.Add((Control) this.pictureBox28);
      this.panel31.Location = new Point(3, 3278);
      this.panel31.Name = "panel31";
      this.panel31.Size = new Size(105, 125);
      this.panel31.TabIndex = 27;
      this.label32.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label32.ForeColor = System.Drawing.Color.White;
      this.label32.Location = new Point(4, 106);
      this.label32.Name = "label32";
      this.label32.Size = new Size(98, 19);
      this.label32.TabIndex = 1;
      this.label32.Text = "Work At Pizza";
      this.label32.TextAlign = ContentAlignment.MiddleCenter;
      this.label32.Click += new EventHandler(this.label32_Click);
      this.pictureBox28.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox28.Location = new Point(3, 3);
      this.pictureBox28.Name = "pictureBox28";
      this.pictureBox28.Size = new Size(100, 100);
      this.pictureBox28.TabIndex = 11;
      this.pictureBox28.TabStop = false;
      this.pictureBox28.Click += new EventHandler(this.pictureBox28_Click);
      this.panel32.Controls.Add((Control) this.label33);
      this.panel32.Controls.Add((Control) this.pictureBox29);
      this.panel32.Location = new Point(3, 3409);
      this.panel32.Name = "panel32";
      this.panel32.Size = new Size(105, 125);
      this.panel32.TabIndex = 28;
      this.label33.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label33.ForeColor = System.Drawing.Color.White;
      this.label33.Location = new Point(4, 106);
      this.label33.Name = "label33";
      this.label33.Size = new Size(98, 19);
      this.label33.TabIndex = 1;
      this.label33.Text = "Gift Simulator";
      this.label33.TextAlign = ContentAlignment.MiddleCenter;
      this.label33.Click += new EventHandler(this.label33_Click);
      this.pictureBox29.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox29.Location = new Point(3, 3);
      this.pictureBox29.Name = "pictureBox29";
      this.pictureBox29.Size = new Size(100, 100);
      this.pictureBox29.TabIndex = 11;
      this.pictureBox29.TabStop = false;
      this.pictureBox29.Click += new EventHandler(this.pictureBox29_Click);
      this.panel33.Controls.Add((Control) this.label34);
      this.panel33.Controls.Add((Control) this.pictureBox30);
      this.panel33.Location = new Point(3, 3540);
      this.panel33.Name = "panel33";
      this.panel33.Size = new Size(105, 125);
      this.panel33.TabIndex = 29;
      this.label34.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label34.ForeColor = System.Drawing.Color.White;
      this.label34.Location = new Point(4, 106);
      this.label34.Name = "label34";
      this.label34.Size = new Size(98, 19);
      this.label34.TabIndex = 1;
      this.label34.Text = "Boxing Sim.";
      this.label34.TextAlign = ContentAlignment.MiddleCenter;
      this.label34.Click += new EventHandler(this.label34_Click);
      this.pictureBox30.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox30.Location = new Point(3, 3);
      this.pictureBox30.Name = "pictureBox30";
      this.pictureBox30.Size = new Size(100, 100);
      this.pictureBox30.TabIndex = 11;
      this.pictureBox30.TabStop = false;
      this.pictureBox30.Click += new EventHandler(this.pictureBox30_Click);
      this.panel34.Controls.Add((Control) this.label35);
      this.panel34.Controls.Add((Control) this.pictureBox31);
      this.panel34.Location = new Point(3, 3671);
      this.panel34.Name = "panel34";
      this.panel34.Size = new Size(105, 125);
      this.panel34.TabIndex = 30;
      this.label35.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label35.ForeColor = System.Drawing.Color.White;
      this.label35.Location = new Point(4, 106);
      this.label35.Name = "label35";
      this.label35.Size = new Size(98, 19);
      this.label35.TabIndex = 1;
      this.label35.Text = "Anime Fighting Sim";
      this.label35.TextAlign = ContentAlignment.MiddleCenter;
      this.label35.Click += new EventHandler(this.label35_Click);
      this.pictureBox31.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox31.Location = new Point(3, 3);
      this.pictureBox31.Name = "pictureBox31";
      this.pictureBox31.Size = new Size(100, 100);
      this.pictureBox31.TabIndex = 11;
      this.pictureBox31.TabStop = false;
      this.pictureBox31.Click += new EventHandler(this.pictureBox31_Click);
      this.panel35.Controls.Add((Control) this.label36);
      this.panel35.Controls.Add((Control) this.pictureBox32);
      this.panel35.Location = new Point(3, 3802);
      this.panel35.Name = "panel35";
      this.panel35.Size = new Size(105, 125);
      this.panel35.TabIndex = 31;
      this.label36.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label36.ForeColor = System.Drawing.Color.White;
      this.label36.Location = new Point(4, 106);
      this.label36.Name = "label36";
      this.label36.Size = new Size(98, 19);
      this.label36.TabIndex = 1;
      this.label36.Text = "Magician Simulator";
      this.label36.TextAlign = ContentAlignment.MiddleCenter;
      this.label36.Click += new EventHandler(this.label36_Click);
      this.pictureBox32.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox32.Location = new Point(3, 3);
      this.pictureBox32.Name = "pictureBox32";
      this.pictureBox32.Size = new Size(100, 100);
      this.pictureBox32.TabIndex = 11;
      this.pictureBox32.TabStop = false;
      this.pictureBox32.Click += new EventHandler(this.pictureBox32_Click);
      this.panel37.Controls.Add((Control) this.label38);
      this.panel37.Controls.Add((Control) this.pictureBox34);
      this.panel37.Location = new Point(3, 3933);
      this.panel37.Name = "panel37";
      this.panel37.Size = new Size(105, 125);
      this.panel37.TabIndex = 33;
      this.label38.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label38.ForeColor = System.Drawing.Color.White;
      this.label38.Location = new Point(4, 106);
      this.label38.Name = "label38";
      this.label38.Size = new Size(98, 19);
      this.label38.TabIndex = 1;
      this.label38.Text = "A Bizzare Day";
      this.label38.TextAlign = ContentAlignment.MiddleCenter;
      this.label38.Click += new EventHandler(this.label38_Click);
      this.pictureBox34.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox34.Location = new Point(3, 3);
      this.pictureBox34.Name = "pictureBox34";
      this.pictureBox34.Size = new Size(100, 100);
      this.pictureBox34.TabIndex = 11;
      this.pictureBox34.TabStop = false;
      this.pictureBox34.Click += new EventHandler(this.pictureBox34_Click);
      this.panel38.Controls.Add((Control) this.label39);
      this.panel38.Controls.Add((Control) this.pictureBox35);
      this.panel38.Location = new Point(3, 4064);
      this.panel38.Name = "panel38";
      this.panel38.Size = new Size(105, 125);
      this.panel38.TabIndex = 34;
      this.label39.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label39.ForeColor = System.Drawing.Color.White;
      this.label39.Location = new Point(4, 106);
      this.label39.Name = "label39";
      this.label39.Size = new Size(98, 19);
      this.label39.TabIndex = 1;
      this.label39.Text = "Present Simulator";
      this.label39.TextAlign = ContentAlignment.MiddleCenter;
      this.label39.Click += new EventHandler(this.label39_Click);
      this.pictureBox35.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox35.Location = new Point(3, 3);
      this.pictureBox35.Name = "pictureBox35";
      this.pictureBox35.Size = new Size(100, 100);
      this.pictureBox35.TabIndex = 11;
      this.pictureBox35.TabStop = false;
      this.pictureBox35.Click += new EventHandler(this.pictureBox35_Click);
      this.panel39.Controls.Add((Control) this.label40);
      this.panel39.Controls.Add((Control) this.pictureBox36);
      this.panel39.Location = new Point(3, 4195);
      this.panel39.Name = "panel39";
      this.panel39.Size = new Size(105, 125);
      this.panel39.TabIndex = 35;
      this.label40.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label40.ForeColor = System.Drawing.Color.White;
      this.label40.Location = new Point(4, 106);
      this.label40.Name = "label40";
      this.label40.Size = new Size(98, 19);
      this.label40.TabIndex = 1;
      this.label40.Text = "Zombie Strike";
      this.label40.TextAlign = ContentAlignment.MiddleCenter;
      this.label40.Click += new EventHandler(this.label40_Click);
      this.pictureBox36.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox36.Location = new Point(3, 3);
      this.pictureBox36.Name = "pictureBox36";
      this.pictureBox36.Size = new Size(100, 100);
      this.pictureBox36.TabIndex = 11;
      this.pictureBox36.TabStop = false;
      this.pictureBox36.Click += new EventHandler(this.pictureBox36_Click);
      this.panel40.Controls.Add((Control) this.label41);
      this.panel40.Controls.Add((Control) this.pictureBox37);
      this.panel40.Location = new Point(3, 4326);
      this.panel40.Name = "panel40";
      this.panel40.Size = new Size(105, 125);
      this.panel40.TabIndex = 36;
      this.label41.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label41.ForeColor = System.Drawing.Color.White;
      this.label41.Location = new Point(4, 106);
      this.label41.Name = "label41";
      this.label41.Size = new Size(98, 19);
      this.label41.TabIndex = 1;
      this.label41.Text = "SPTS";
      this.label41.TextAlign = ContentAlignment.MiddleCenter;
      this.label41.Click += new EventHandler(this.label41_Click);
      this.pictureBox37.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox37.Location = new Point(3, 3);
      this.pictureBox37.Name = "pictureBox37";
      this.pictureBox37.Size = new Size(100, 100);
      this.pictureBox37.TabIndex = 11;
      this.pictureBox37.TabStop = false;
      this.pictureBox37.Click += new EventHandler(this.pictureBox37_Click);
      this.panel41.Controls.Add((Control) this.label42);
      this.panel41.Controls.Add((Control) this.pictureBox38);
      this.panel41.Location = new Point(3, 4457);
      this.panel41.Name = "panel41";
      this.panel41.Size = new Size(105, 125);
      this.panel41.TabIndex = 37;
      this.label42.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label42.ForeColor = System.Drawing.Color.White;
      this.label42.Location = new Point(4, 106);
      this.label42.Name = "label42";
      this.label42.Size = new Size(98, 19);
      this.label42.TabIndex = 1;
      this.label42.Text = "LOL Tycoon";
      this.label42.TextAlign = ContentAlignment.MiddleCenter;
      this.label42.Click += new EventHandler(this.label42_Click);
      this.pictureBox38.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox38.Location = new Point(3, 3);
      this.pictureBox38.Name = "pictureBox38";
      this.pictureBox38.Size = new Size(100, 100);
      this.pictureBox38.TabIndex = 11;
      this.pictureBox38.TabStop = false;
      this.pictureBox38.Click += new EventHandler(this.pictureBox38_Click);
      this.panel42.Controls.Add((Control) this.label43);
      this.panel42.Controls.Add((Control) this.pictureBox39);
      this.panel42.Location = new Point(3, 4588);
      this.panel42.Name = "panel42";
      this.panel42.Size = new Size(105, 125);
      this.panel42.TabIndex = 38;
      this.label43.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label43.ForeColor = System.Drawing.Color.White;
      this.label43.Location = new Point(4, 106);
      this.label43.Name = "label43";
      this.label43.Size = new Size(98, 19);
      this.label43.TabIndex = 1;
      this.label43.Text = "D-DAY";
      this.label43.TextAlign = ContentAlignment.MiddleCenter;
      this.label43.Click += new EventHandler(this.label43_Click);
      this.pictureBox39.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox39.Location = new Point(3, 3);
      this.pictureBox39.Name = "pictureBox39";
      this.pictureBox39.Size = new Size(100, 100);
      this.pictureBox39.TabIndex = 11;
      this.pictureBox39.TabStop = false;
      this.pictureBox39.Click += new EventHandler(this.pictureBox39_Click);
      this.panel43.Controls.Add((Control) this.label44);
      this.panel43.Controls.Add((Control) this.pictureBox40);
      this.panel43.Location = new Point(3, 4719);
      this.panel43.Name = "panel43";
      this.panel43.Size = new Size(105, 125);
      this.panel43.TabIndex = 39;
      this.label44.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label44.ForeColor = System.Drawing.Color.White;
      this.label44.Location = new Point(4, 106);
      this.label44.Name = "label44";
      this.label44.Size = new Size(98, 19);
      this.label44.TabIndex = 1;
      this.label44.Text = "Slicing Simulator";
      this.label44.TextAlign = ContentAlignment.MiddleCenter;
      this.label44.Click += new EventHandler(this.label44_Click);
      this.pictureBox40.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox40.Location = new Point(3, 3);
      this.pictureBox40.Name = "pictureBox40";
      this.pictureBox40.Size = new Size(100, 100);
      this.pictureBox40.TabIndex = 11;
      this.pictureBox40.TabStop = false;
      this.pictureBox40.Click += new EventHandler(this.pictureBox40_Click);
      this.panel44.Controls.Add((Control) this.label45);
      this.panel44.Controls.Add((Control) this.pictureBox41);
      this.panel44.Location = new Point(3, 4850);
      this.panel44.Name = "panel44";
      this.panel44.Size = new Size(105, 125);
      this.panel44.TabIndex = 40;
      this.label45.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label45.ForeColor = System.Drawing.Color.White;
      this.label45.Location = new Point(4, 106);
      this.label45.Name = "label45";
      this.label45.Size = new Size(98, 19);
      this.label45.TabIndex = 1;
      this.label45.Text = "Magic Simulator";
      this.label45.TextAlign = ContentAlignment.MiddleCenter;
      this.label45.Click += new EventHandler(this.label45_Click_1);
      this.pictureBox41.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox41.Location = new Point(3, 3);
      this.pictureBox41.Name = "pictureBox41";
      this.pictureBox41.Size = new Size(100, 100);
      this.pictureBox41.TabIndex = 11;
      this.pictureBox41.TabStop = false;
      this.pictureBox41.Click += new EventHandler(this.pictureBox41_Click);
      this.panel46.Controls.Add((Control) this.label47);
      this.panel46.Controls.Add((Control) this.pictureBox43);
      this.panel46.Location = new Point(3, 4981);
      this.panel46.Name = "panel46";
      this.panel46.Size = new Size(105, 125);
      this.panel46.TabIndex = 42;
      this.label47.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label47.ForeColor = System.Drawing.Color.White;
      this.label47.Location = new Point(4, 106);
      this.label47.Name = "label47";
      this.label47.Size = new Size(98, 19);
      this.label47.TabIndex = 1;
      this.label47.Text = "Fighting Simulator";
      this.label47.TextAlign = ContentAlignment.MiddleCenter;
      this.label47.Click += new EventHandler(this.label47_Click);
      this.pictureBox43.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox43.Location = new Point(3, 3);
      this.pictureBox43.Name = "pictureBox43";
      this.pictureBox43.Size = new Size(100, 100);
      this.pictureBox43.TabIndex = 11;
      this.pictureBox43.TabStop = false;
      this.pictureBox43.Click += new EventHandler(this.pictureBox43_Click);
      this.panel48.Controls.Add((Control) this.label49);
      this.panel48.Controls.Add((Control) this.pictureBox45);
      this.panel48.Location = new Point(3, 5112);
      this.panel48.Name = "panel48";
      this.panel48.Size = new Size(105, 125);
      this.panel48.TabIndex = 44;
      this.label49.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label49.ForeColor = System.Drawing.Color.White;
      this.label49.Location = new Point(4, 106);
      this.label49.Name = "label49";
      this.label49.Size = new Size(98, 19);
      this.label49.TabIndex = 1;
      this.label49.Text = "MadCity";
      this.label49.TextAlign = ContentAlignment.MiddleCenter;
      this.label49.Click += new EventHandler(this.label49_Click);
      this.pictureBox45.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox45.Location = new Point(3, 3);
      this.pictureBox45.Name = "pictureBox45";
      this.pictureBox45.Size = new Size(100, 100);
      this.pictureBox45.TabIndex = 11;
      this.pictureBox45.TabStop = false;
      this.pictureBox45.Click += new EventHandler(this.pictureBox45_Click);
      this.panel49.Controls.Add((Control) this.label50);
      this.panel49.Controls.Add((Control) this.pictureBox46);
      this.panel49.Location = new Point(3, 5243);
      this.panel49.Name = "panel49";
      this.panel49.Size = new Size(105, 125);
      this.panel49.TabIndex = 45;
      this.label50.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label50.ForeColor = System.Drawing.Color.White;
      this.label50.Location = new Point(4, 106);
      this.label50.Name = "label50";
      this.label50.Size = new Size(98, 19);
      this.label50.TabIndex = 1;
      this.label50.Text = "Murder Mystery 2";
      this.label50.TextAlign = ContentAlignment.MiddleCenter;
      this.label50.Click += new EventHandler(this.label50_Click);
      this.pictureBox46.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox46.Location = new Point(3, 3);
      this.pictureBox46.Name = "pictureBox46";
      this.pictureBox46.Size = new Size(100, 100);
      this.pictureBox46.TabIndex = 11;
      this.pictureBox46.TabStop = false;
      this.pictureBox46.Click += new EventHandler(this.pictureBox46_Click);
      this.panel50.Controls.Add((Control) this.label51);
      this.panel50.Controls.Add((Control) this.pictureBox47);
      this.panel50.Location = new Point(3, 5374);
      this.panel50.Name = "panel50";
      this.panel50.Size = new Size(105, 125);
      this.panel50.TabIndex = 45;
      this.label51.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label51.ForeColor = System.Drawing.Color.White;
      this.label51.Location = new Point(4, 106);
      this.label51.Name = "label51";
      this.label51.Size = new Size(98, 19);
      this.label51.TabIndex = 1;
      this.label51.Text = "Zombie Rush";
      this.label51.TextAlign = ContentAlignment.MiddleCenter;
      this.label51.Click += new EventHandler(this.label51_Click);
      this.pictureBox47.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox47.Location = new Point(3, 3);
      this.pictureBox47.Name = "pictureBox47";
      this.pictureBox47.Size = new Size(100, 100);
      this.pictureBox47.TabIndex = 11;
      this.pictureBox47.TabStop = false;
      this.pictureBox47.Click += new EventHandler(this.pictureBox47_Click);
      this.panel51.Controls.Add((Control) this.label52);
      this.panel51.Controls.Add((Control) this.pictureBox48);
      this.panel51.Location = new Point(3, 5505);
      this.panel51.Name = "panel51";
      this.panel51.Size = new Size(105, 125);
      this.panel51.TabIndex = 46;
      this.label52.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label52.ForeColor = System.Drawing.Color.White;
      this.label52.Location = new Point(4, 106);
      this.label52.Name = "label52";
      this.label52.Size = new Size(98, 19);
      this.label52.TabIndex = 1;
      this.label52.Text = "Restaurant Tyc 2";
      this.label52.TextAlign = ContentAlignment.MiddleCenter;
      this.label52.Click += new EventHandler(this.label52_Click);
      this.pictureBox48.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox48.Location = new Point(3, 3);
      this.pictureBox48.Name = "pictureBox48";
      this.pictureBox48.Size = new Size(100, 100);
      this.pictureBox48.TabIndex = 11;
      this.pictureBox48.TabStop = false;
      this.pictureBox48.Click += new EventHandler(this.pictureBox48_Click);
      this.panel53.Controls.Add((Control) this.label54);
      this.panel53.Controls.Add((Control) this.pictureBox50);
      this.panel53.Location = new Point(3, 5636);
      this.panel53.Name = "panel53";
      this.panel53.Size = new Size(105, 125);
      this.panel53.TabIndex = 48;
      this.label54.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label54.ForeColor = System.Drawing.Color.White;
      this.label54.Location = new Point(4, 106);
      this.label54.Name = "label54";
      this.label54.Size = new Size(98, 19);
      this.label54.TabIndex = 1;
      this.label54.Text = "Blade Simulator";
      this.label54.TextAlign = ContentAlignment.MiddleCenter;
      this.label54.Click += new EventHandler(this.label54_Click);
      this.pictureBox50.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox50.Location = new Point(3, 3);
      this.pictureBox50.Name = "pictureBox50";
      this.pictureBox50.Size = new Size(100, 100);
      this.pictureBox50.TabIndex = 11;
      this.pictureBox50.TabStop = false;
      this.pictureBox50.Click += new EventHandler(this.pictureBox50_Click);
      this.panel54.Controls.Add((Control) this.label55);
      this.panel54.Controls.Add((Control) this.pictureBox51);
      this.panel54.Location = new Point(3, 5767);
      this.panel54.Name = "panel54";
      this.panel54.Size = new Size(105, 125);
      this.panel54.TabIndex = 49;
      this.label55.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label55.ForeColor = System.Drawing.Color.White;
      this.label55.Location = new Point(4, 106);
      this.label55.Name = "label55";
      this.label55.Size = new Size(98, 19);
      this.label55.TabIndex = 1;
      this.label55.Text = "Champion Sim.";
      this.label55.TextAlign = ContentAlignment.MiddleCenter;
      this.label55.Click += new EventHandler(this.label55_Click);
      this.pictureBox51.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox51.Location = new Point(3, 3);
      this.pictureBox51.Name = "pictureBox51";
      this.pictureBox51.Size = new Size(100, 100);
      this.pictureBox51.TabIndex = 11;
      this.pictureBox51.TabStop = false;
      this.pictureBox51.Click += new EventHandler(this.pictureBox51_Click);
      this.panel55.Controls.Add((Control) this.label56);
      this.panel55.Controls.Add((Control) this.pictureBox52);
      this.panel55.Location = new Point(3, 5898);
      this.panel55.Name = "panel55";
      this.panel55.Size = new Size(105, 125);
      this.panel55.TabIndex = 50;
      this.label56.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label56.ForeColor = System.Drawing.Color.White;
      this.label56.Location = new Point(4, 106);
      this.label56.Name = "label56";
      this.label56.Size = new Size(98, 19);
      this.label56.TabIndex = 1;
      this.label56.Text = "Mad Paintball 2";
      this.label56.TextAlign = ContentAlignment.MiddleCenter;
      this.label56.Click += new EventHandler(this.label56_Click);
      this.pictureBox52.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox52.Location = new Point(3, 3);
      this.pictureBox52.Name = "pictureBox52";
      this.pictureBox52.Size = new Size(100, 100);
      this.pictureBox52.TabIndex = 11;
      this.pictureBox52.TabStop = false;
      this.pictureBox52.Click += new EventHandler(this.pictureBox52_Click);
      this.panel56.Controls.Add((Control) this.label57);
      this.panel56.Controls.Add((Control) this.pictureBox53);
      this.panel56.Location = new Point(3, 6029);
      this.panel56.Name = "panel56";
      this.panel56.Size = new Size(105, 125);
      this.panel56.TabIndex = 51;
      this.label57.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label57.ForeColor = System.Drawing.Color.White;
      this.label57.Location = new Point(4, 106);
      this.label57.Name = "label57";
      this.label57.Size = new Size(98, 19);
      this.label57.TabIndex = 1;
      this.label57.Text = "Texting Simulator";
      this.label57.TextAlign = ContentAlignment.MiddleCenter;
      this.label57.Click += new EventHandler(this.label57_Click);
      this.pictureBox53.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox53.Location = new Point(3, 3);
      this.pictureBox53.Name = "pictureBox53";
      this.pictureBox53.Size = new Size(100, 100);
      this.pictureBox53.TabIndex = 11;
      this.pictureBox53.TabStop = false;
      this.pictureBox53.Click += new EventHandler(this.pictureBox53_Click);
      this.panel57.Controls.Add((Control) this.label58);
      this.panel57.Controls.Add((Control) this.pictureBox54);
      this.panel57.Location = new Point(3, 6160);
      this.panel57.Name = "panel57";
      this.panel57.Size = new Size(105, 125);
      this.panel57.TabIndex = 52;
      this.label58.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label58.ForeColor = System.Drawing.Color.White;
      this.label58.Location = new Point(4, 106);
      this.label58.Name = "label58";
      this.label58.Size = new Size(98, 19);
      this.label58.TabIndex = 1;
      this.label58.Text = "Flee The Facility";
      this.label58.TextAlign = ContentAlignment.MiddleCenter;
      this.label58.Click += new EventHandler(this.label58_Click);
      this.pictureBox54.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox54.Location = new Point(3, 3);
      this.pictureBox54.Name = "pictureBox54";
      this.pictureBox54.Size = new Size(100, 100);
      this.pictureBox54.TabIndex = 11;
      this.pictureBox54.TabStop = false;
      this.pictureBox54.Click += new EventHandler(this.pictureBox54_Click);
      this.panel60.Controls.Add((Control) this.label61);
      this.panel60.Controls.Add((Control) this.pictureBox57);
      this.panel60.Location = new Point(3, 6291);
      this.panel60.Name = "panel60";
      this.panel60.Size = new Size(105, 125);
      this.panel60.TabIndex = 55;
      this.label61.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label61.ForeColor = System.Drawing.Color.White;
      this.label61.Location = new Point(4, 106);
      this.label61.Name = "label61";
      this.label61.Size = new Size(98, 19);
      this.label61.TabIndex = 1;
      this.label61.Text = "Speed City";
      this.label61.TextAlign = ContentAlignment.MiddleCenter;
      this.label61.Click += new EventHandler(this.label61_Click);
      this.pictureBox57.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox57.Location = new Point(3, 3);
      this.pictureBox57.Name = "pictureBox57";
      this.pictureBox57.Size = new Size(100, 100);
      this.pictureBox57.TabIndex = 11;
      this.pictureBox57.TabStop = false;
      this.pictureBox57.Click += new EventHandler(this.pictureBox57_Click);
      this.panel62.Controls.Add((Control) this.label63);
      this.panel62.Controls.Add((Control) this.pictureBox59);
      this.panel62.Location = new Point(3, 6422);
      this.panel62.Name = "panel62";
      this.panel62.Size = new Size(105, 125);
      this.panel62.TabIndex = 57;
      this.label63.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label63.ForeColor = System.Drawing.Color.White;
      this.label63.Location = new Point(4, 106);
      this.label63.Name = "label63";
      this.label63.Size = new Size(98, 19);
      this.label63.TabIndex = 1;
      this.label63.Text = "SnowMan Sim.";
      this.label63.TextAlign = ContentAlignment.MiddleCenter;
      this.label63.Click += new EventHandler(this.label63_Click);
      this.pictureBox59.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox59.Location = new Point(3, 3);
      this.pictureBox59.Name = "pictureBox59";
      this.pictureBox59.Size = new Size(100, 100);
      this.pictureBox59.TabIndex = 11;
      this.pictureBox59.TabStop = false;
      this.pictureBox59.Click += new EventHandler(this.pictureBox59_Click);
      this.panel63.Controls.Add((Control) this.label64);
      this.panel63.Controls.Add((Control) this.pictureBox60);
      this.panel63.Location = new Point(3, 6553);
      this.panel63.Name = "panel63";
      this.panel63.Size = new Size(105, 125);
      this.panel63.TabIndex = 58;
      this.label64.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label64.ForeColor = System.Drawing.Color.White;
      this.label64.Location = new Point(4, 106);
      this.label64.Name = "label64";
      this.label64.Size = new Size(98, 19);
      this.label64.TabIndex = 1;
      this.label64.Text = "Boss Fighting Sim";
      this.label64.TextAlign = ContentAlignment.MiddleCenter;
      this.label64.Click += new EventHandler(this.label64_Click);
      this.pictureBox60.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox60.Location = new Point(3, 3);
      this.pictureBox60.Name = "pictureBox60";
      this.pictureBox60.Size = new Size(100, 100);
      this.pictureBox60.TabIndex = 11;
      this.pictureBox60.TabStop = false;
      this.pictureBox60.Click += new EventHandler(this.pictureBox60_Click);
      this.panel64.Controls.Add((Control) this.label65);
      this.panel64.Controls.Add((Control) this.pictureBox61);
      this.panel64.Location = new Point(3, 6684);
      this.panel64.Name = "panel64";
      this.panel64.Size = new Size(105, 125);
      this.panel64.TabIndex = 59;
      this.label65.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label65.ForeColor = System.Drawing.Color.White;
      this.label65.Location = new Point(4, 106);
      this.label65.Name = "label65";
      this.label65.Size = new Size(98, 19);
      this.label65.TabIndex = 1;
      this.label65.Text = "Sprinting Sim.";
      this.label65.TextAlign = ContentAlignment.MiddleCenter;
      this.label65.Click += new EventHandler(this.label65_Click);
      this.pictureBox61.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox61.Location = new Point(3, 3);
      this.pictureBox61.Name = "pictureBox61";
      this.pictureBox61.Size = new Size(100, 100);
      this.pictureBox61.TabIndex = 11;
      this.pictureBox61.TabStop = false;
      this.pictureBox61.Click += new EventHandler(this.pictureBox61_Click);
      this.panel65.Controls.Add((Control) this.label17);
      this.panel65.Controls.Add((Control) this.pictureBox62);
      this.panel65.Location = new Point(3, 6815);
      this.panel65.Name = "panel65";
      this.panel65.Size = new Size(105, 125);
      this.panel65.TabIndex = 60;
      this.label17.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label17.ForeColor = System.Drawing.Color.White;
      this.label17.Location = new Point(4, 106);
      this.label17.Name = "label17";
      this.label17.Size = new Size(98, 19);
      this.label17.TabIndex = 1;
      this.label17.Text = "Treasure Quest";
      this.label17.TextAlign = ContentAlignment.MiddleCenter;
      this.label17.Click += new EventHandler(this.label17_Click);
      this.pictureBox62.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox62.Location = new Point(3, 3);
      this.pictureBox62.Name = "pictureBox62";
      this.pictureBox62.Size = new Size(100, 100);
      this.pictureBox62.TabIndex = 11;
      this.pictureBox62.TabStop = false;
      this.pictureBox62.Click += new EventHandler(this.pictureBox62_Click);
      this.panel66.Controls.Add((Control) this.label66);
      this.panel66.Controls.Add((Control) this.pictureBox63);
      this.panel66.Location = new Point(3, 6946);
      this.panel66.Name = "panel66";
      this.panel66.Size = new Size(105, 125);
      this.panel66.TabIndex = 61;
      this.label66.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label66.ForeColor = System.Drawing.Color.White;
      this.label66.Location = new Point(4, 106);
      this.label66.Name = "label66";
      this.label66.Size = new Size(98, 19);
      this.label66.TabIndex = 1;
      this.label66.Text = "Project Jojo";
      this.label66.TextAlign = ContentAlignment.MiddleCenter;
      this.label66.Click += new EventHandler(this.label66_Click);
      this.pictureBox63.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox63.Location = new Point(3, 3);
      this.pictureBox63.Name = "pictureBox63";
      this.pictureBox63.Size = new Size(100, 100);
      this.pictureBox63.TabIndex = 11;
      this.pictureBox63.TabStop = false;
      this.pictureBox63.Click += new EventHandler(this.pictureBox63_Click);
      this.panel28.Controls.Add((Control) this.label29);
      this.panel28.Controls.Add((Control) this.pictureBox25);
      this.panel28.Location = new Point(3, 7077);
      this.panel28.Name = "panel28";
      this.panel28.Size = new Size(105, 131);
      this.panel28.TabIndex = 62;
      this.label29.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label29.ForeColor = System.Drawing.Color.White;
      this.label29.Location = new Point(4, 106);
      this.label29.Name = "label29";
      this.label29.Size = new Size(98, 19);
      this.label29.TabIndex = 1;
      this.label29.Text = "Meep City";
      this.label29.TextAlign = ContentAlignment.MiddleCenter;
      this.label29.Click += new EventHandler(this.label29_Click_1);
      this.pictureBox25.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox25.Location = new Point(3, 3);
      this.pictureBox25.Name = "pictureBox25";
      this.pictureBox25.Size = new Size(100, 100);
      this.pictureBox25.TabIndex = 11;
      this.pictureBox25.TabStop = false;
      this.pictureBox25.Click += new EventHandler(this.pictureBox25_Click_1);
      this.panel58.Controls.Add((Control) this.label59);
      this.panel58.Controls.Add((Control) this.pictureBox55);
      this.panel58.Location = new Point(3, 7214);
      this.panel58.Name = "panel58";
      this.panel58.Size = new Size(105, 131);
      this.panel58.TabIndex = 63;
      this.label59.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label59.ForeColor = System.Drawing.Color.White;
      this.label59.Location = new Point(4, 106);
      this.label59.Name = "label59";
      this.label59.Size = new Size(98, 19);
      this.label59.TabIndex = 1;
      this.label59.Text = "ILUM 2";
      this.label59.TextAlign = ContentAlignment.MiddleCenter;
      this.label59.Click += new EventHandler(this.label59_Click_1);
      this.pictureBox55.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox55.Location = new Point(3, 3);
      this.pictureBox55.Name = "pictureBox55";
      this.pictureBox55.Size = new Size(100, 100);
      this.pictureBox55.TabIndex = 11;
      this.pictureBox55.TabStop = false;
      this.pictureBox55.Click += new EventHandler(this.pictureBox55_Click_1);
      this.panel67.Controls.Add((Control) this.label67);
      this.panel67.Controls.Add((Control) this.pictureBox64);
      this.panel67.Location = new Point(3, 7351);
      this.panel67.Name = "panel67";
      this.panel67.Size = new Size(105, 131);
      this.panel67.TabIndex = 64;
      this.label67.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label67.ForeColor = System.Drawing.Color.White;
      this.label67.Location = new Point(4, 106);
      this.label67.Name = "label67";
      this.label67.Size = new Size(98, 19);
      this.label67.TabIndex = 1;
      this.label67.Text = "Dungeon Simulator";
      this.label67.TextAlign = ContentAlignment.MiddleCenter;
      this.label67.Click += new EventHandler(this.label67_Click);
      this.pictureBox64.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox64.Location = new Point(3, 3);
      this.pictureBox64.Name = "pictureBox64";
      this.pictureBox64.Size = new Size(100, 100);
      this.pictureBox64.TabIndex = 11;
      this.pictureBox64.TabStop = false;
      this.pictureBox64.Click += new EventHandler(this.pictureBox64_Click);
      this.panel68.Controls.Add((Control) this.label68);
      this.panel68.Controls.Add((Control) this.pictureBox65);
      this.panel68.Location = new Point(3, 7488);
      this.panel68.Name = "panel68";
      this.panel68.Size = new Size(105, 131);
      this.panel68.TabIndex = 65;
      this.label68.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label68.ForeColor = System.Drawing.Color.White;
      this.label68.Location = new Point(4, 106);
      this.label68.Name = "label68";
      this.label68.Size = new Size(98, 19);
      this.label68.TabIndex = 1;
      this.label68.Text = "Drifting Simulator";
      this.label68.TextAlign = ContentAlignment.MiddleCenter;
      this.label68.Click += new EventHandler(this.label68_Click);
      this.pictureBox65.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox65.Location = new Point(3, 3);
      this.pictureBox65.Name = "pictureBox65";
      this.pictureBox65.Size = new Size(100, 100);
      this.pictureBox65.TabIndex = 11;
      this.pictureBox65.TabStop = false;
      this.pictureBox65.Click += new EventHandler(this.pictureBox65_Click);
      this.panel69.Controls.Add((Control) this.label69);
      this.panel69.Controls.Add((Control) this.pictureBox66);
      this.panel69.Location = new Point(3, 7625);
      this.panel69.Name = "panel69";
      this.panel69.Size = new Size(105, 131);
      this.panel69.TabIndex = 66;
      this.label69.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label69.ForeColor = System.Drawing.Color.White;
      this.label69.Location = new Point(4, 106);
      this.label69.Name = "label69";
      this.label69.Size = new Size(98, 19);
      this.label69.TabIndex = 1;
      this.label69.Text = "Rumble Quest";
      this.label69.TextAlign = ContentAlignment.MiddleCenter;
      this.label69.Click += new EventHandler(this.label69_Click);
      this.pictureBox66.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox66.Location = new Point(3, 3);
      this.pictureBox66.Name = "pictureBox66";
      this.pictureBox66.Size = new Size(100, 100);
      this.pictureBox66.TabIndex = 11;
      this.pictureBox66.TabStop = false;
      this.pictureBox66.Click += new EventHandler(this.pictureBox66_Click);
      this.panel70.Controls.Add((Control) this.label70);
      this.panel70.Controls.Add((Control) this.pictureBox67);
      this.panel70.Location = new Point(3, 7762);
      this.panel70.Name = "panel70";
      this.panel70.Size = new Size(105, 131);
      this.panel70.TabIndex = 67;
      this.label70.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label70.ForeColor = System.Drawing.Color.White;
      this.label70.Location = new Point(4, 106);
      this.label70.Name = "label70";
      this.label70.Size = new Size(98, 19);
      this.label70.TabIndex = 1;
      this.label70.Text = "Assassin!";
      this.label70.TextAlign = ContentAlignment.MiddleCenter;
      this.label70.Click += new EventHandler(this.label70_Click);
      this.pictureBox67.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox67.Location = new Point(3, 3);
      this.pictureBox67.Name = "pictureBox67";
      this.pictureBox67.Size = new Size(100, 100);
      this.pictureBox67.TabIndex = 11;
      this.pictureBox67.TabStop = false;
      this.pictureBox67.Click += new EventHandler(this.pictureBox67_Click);
      this.panel72.Controls.Add((Control) this.label72);
      this.panel72.Controls.Add((Control) this.pictureBox69);
      this.panel72.Location = new Point(3, 7899);
      this.panel72.Name = "panel72";
      this.panel72.Size = new Size(105, 131);
      this.panel72.TabIndex = 69;
      this.label72.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label72.ForeColor = System.Drawing.Color.White;
      this.label72.Location = new Point(4, 106);
      this.label72.Name = "label72";
      this.label72.Size = new Size(98, 19);
      this.label72.TabIndex = 1;
      this.label72.Text = "Naruto Tycoon";
      this.label72.TextAlign = ContentAlignment.MiddleCenter;
      this.label72.Click += new EventHandler(this.label72_Click_1);
      this.pictureBox69.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox69.Location = new Point(3, 3);
      this.pictureBox69.Name = "pictureBox69";
      this.pictureBox69.Size = new Size(100, 100);
      this.pictureBox69.TabIndex = 11;
      this.pictureBox69.TabStop = false;
      this.pictureBox69.Click += new EventHandler(this.pictureBox69_Click);
      this.panel73.Controls.Add((Control) this.label73);
      this.panel73.Controls.Add((Control) this.pictureBox70);
      this.panel73.Location = new Point(3, 8036);
      this.panel73.Name = "panel73";
      this.panel73.Size = new Size(105, 131);
      this.panel73.TabIndex = 70;
      this.label73.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label73.ForeColor = System.Drawing.Color.White;
      this.label73.Location = new Point(4, 106);
      this.label73.Name = "label73";
      this.label73.Size = new Size(98, 19);
      this.label73.TabIndex = 1;
      this.label73.Text = "Rocitizens";
      this.label73.TextAlign = ContentAlignment.MiddleCenter;
      this.label73.Click += new EventHandler(this.label73_Click);
      this.pictureBox70.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox70.Location = new Point(3, 3);
      this.pictureBox70.Name = "pictureBox70";
      this.pictureBox70.Size = new Size(100, 100);
      this.pictureBox70.TabIndex = 11;
      this.pictureBox70.TabStop = false;
      this.pictureBox70.Click += new EventHandler(this.pictureBox70_Click);
      this.panel74.Controls.Add((Control) this.label74);
      this.panel74.Controls.Add((Control) this.pictureBox71);
      this.panel74.Location = new Point(3, 8173);
      this.panel74.Name = "panel74";
      this.panel74.Size = new Size(105, 131);
      this.panel74.TabIndex = 71;
      this.label74.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label74.ForeColor = System.Drawing.Color.White;
      this.label74.Location = new Point(4, 106);
      this.label74.Name = "label74";
      this.label74.Size = new Size(98, 19);
      this.label74.TabIndex = 1;
      this.label74.Text = "Rogue Lineage";
      this.label74.TextAlign = ContentAlignment.MiddleCenter;
      this.label74.Click += new EventHandler(this.label74_Click);
      this.pictureBox71.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox71.Location = new Point(3, 3);
      this.pictureBox71.Name = "pictureBox71";
      this.pictureBox71.Size = new Size(100, 100);
      this.pictureBox71.TabIndex = 11;
      this.pictureBox71.TabStop = false;
      this.pictureBox71.Click += new EventHandler(this.pictureBox71_Click);
      this.panel75.Controls.Add((Control) this.label75);
      this.panel75.Controls.Add((Control) this.pictureBox72);
      this.panel75.Location = new Point(3, 8310);
      this.panel75.Name = "panel75";
      this.panel75.Size = new Size(105, 131);
      this.panel75.TabIndex = 72;
      this.label75.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label75.ForeColor = System.Drawing.Color.White;
      this.label75.Location = new Point(4, 106);
      this.label75.Name = "label75";
      this.label75.Size = new Size(98, 19);
      this.label75.TabIndex = 1;
      this.label75.Text = "WeightLifting Sim. 3";
      this.label75.TextAlign = ContentAlignment.MiddleCenter;
      this.label75.Click += new EventHandler(this.label75_Click);
      this.pictureBox72.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox72.Location = new Point(3, 3);
      this.pictureBox72.Name = "pictureBox72";
      this.pictureBox72.Size = new Size(100, 100);
      this.pictureBox72.TabIndex = 11;
      this.pictureBox72.TabStop = false;
      this.pictureBox72.Click += new EventHandler(this.pictureBox72_Click);
      this.panel76.Controls.Add((Control) this.label76);
      this.panel76.Controls.Add((Control) this.pictureBox73);
      this.panel76.Location = new Point(3, 8447);
      this.panel76.Name = "panel76";
      this.panel76.Size = new Size(105, 131);
      this.panel76.TabIndex = 73;
      this.label76.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label76.ForeColor = System.Drawing.Color.White;
      this.label76.Location = new Point(4, 106);
      this.label76.Name = "label76";
      this.label76.Size = new Size(98, 19);
      this.label76.TabIndex = 1;
      this.label76.Text = "Gas Station Sim.";
      this.label76.TextAlign = ContentAlignment.MiddleCenter;
      this.label76.Click += new EventHandler(this.label76_Click);
      this.pictureBox73.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox73.Location = new Point(3, 3);
      this.pictureBox73.Name = "pictureBox73";
      this.pictureBox73.Size = new Size(100, 100);
      this.pictureBox73.TabIndex = 11;
      this.pictureBox73.TabStop = false;
      this.pictureBox73.Click += new EventHandler(this.pictureBox73_Click);
      this.panel77.Controls.Add((Control) this.label77);
      this.panel77.Controls.Add((Control) this.pictureBox74);
      this.panel77.Location = new Point(3, 8584);
      this.panel77.Name = "panel77";
      this.panel77.Size = new Size(105, 131);
      this.panel77.TabIndex = 74;
      this.label77.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label77.ForeColor = System.Drawing.Color.White;
      this.label77.Location = new Point(4, 106);
      this.label77.Name = "label77";
      this.label77.Size = new Size(98, 19);
      this.label77.TabIndex = 1;
      this.label77.Text = "Island Royale";
      this.label77.TextAlign = ContentAlignment.MiddleCenter;
      this.label77.Click += new EventHandler(this.label77_Click);
      this.pictureBox74.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox74.Location = new Point(3, 3);
      this.pictureBox74.Name = "pictureBox74";
      this.pictureBox74.Size = new Size(100, 100);
      this.pictureBox74.TabIndex = 11;
      this.pictureBox74.TabStop = false;
      this.pictureBox74.Click += new EventHandler(this.pictureBox74_Click);
      this.panel78.Controls.Add((Control) this.label78);
      this.panel78.Controls.Add((Control) this.pictureBox75);
      this.panel78.Location = new Point(3, 8721);
      this.panel78.Name = "panel78";
      this.panel78.Size = new Size(105, 131);
      this.panel78.TabIndex = 75;
      this.label78.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label78.ForeColor = System.Drawing.Color.White;
      this.label78.Location = new Point(4, 106);
      this.label78.Name = "label78";
      this.label78.Size = new Size(98, 19);
      this.label78.TabIndex = 1;
      this.label78.Text = "Dragon Ball Rage";
      this.label78.TextAlign = ContentAlignment.MiddleCenter;
      this.label78.Click += new EventHandler(this.label78_Click);
      this.pictureBox75.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox75.Location = new Point(3, 3);
      this.pictureBox75.Name = "pictureBox75";
      this.pictureBox75.Size = new Size(100, 100);
      this.pictureBox75.TabIndex = 11;
      this.pictureBox75.TabStop = false;
      this.pictureBox75.Click += new EventHandler(this.pictureBox75_Click);
      this.panel79.Controls.Add((Control) this.label79);
      this.panel79.Controls.Add((Control) this.pictureBox76);
      this.panel79.Location = new Point(3, 8858);
      this.panel79.Name = "panel79";
      this.panel79.Size = new Size(105, 131);
      this.panel79.TabIndex = 76;
      this.label79.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label79.ForeColor = System.Drawing.Color.White;
      this.label79.Location = new Point(4, 106);
      this.label79.Name = "label79";
      this.label79.Size = new Size(98, 19);
      this.label79.TabIndex = 1;
      this.label79.Text = "Faction Defence ";
      this.label79.TextAlign = ContentAlignment.MiddleCenter;
      this.label79.Click += new EventHandler(this.label79_Click);
      this.pictureBox76.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox76.Location = new Point(3, 3);
      this.pictureBox76.Name = "pictureBox76";
      this.pictureBox76.Size = new Size(100, 100);
      this.pictureBox76.TabIndex = 11;
      this.pictureBox76.TabStop = false;
      this.pictureBox76.Click += new EventHandler(this.pictureBox76_Click);
      this.panel80.Controls.Add((Control) this.label80);
      this.panel80.Controls.Add((Control) this.pictureBox77);
      this.panel80.Location = new Point(3, 8995);
      this.panel80.Name = "panel80";
      this.panel80.Size = new Size(105, 131);
      this.panel80.TabIndex = 77;
      this.label80.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label80.ForeColor = System.Drawing.Color.White;
      this.label80.Location = new Point(4, 106);
      this.label80.Name = "label80";
      this.label80.Size = new Size(98, 19);
      this.label80.TabIndex = 1;
      this.label80.Text = "Da Hood";
      this.label80.TextAlign = ContentAlignment.MiddleCenter;
      this.label80.Click += new EventHandler(this.label80_Click);
      this.pictureBox77.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox77.Location = new Point(3, 3);
      this.pictureBox77.Name = "pictureBox77";
      this.pictureBox77.Size = new Size(100, 100);
      this.pictureBox77.TabIndex = 11;
      this.pictureBox77.TabStop = false;
      this.pictureBox77.Click += new EventHandler(this.pictureBox77_Click);
      this.panel81.Controls.Add((Control) this.label81);
      this.panel81.Controls.Add((Control) this.pictureBox78);
      this.panel81.Location = new Point(3, 9132);
      this.panel81.Name = "panel81";
      this.panel81.Size = new Size(105, 131);
      this.panel81.TabIndex = 78;
      this.label81.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label81.ForeColor = System.Drawing.Color.White;
      this.label81.Location = new Point(4, 106);
      this.label81.Name = "label81";
      this.label81.Size = new Size(98, 19);
      this.label81.TabIndex = 1;
      this.label81.Text = "Thanos Is Eating";
      this.label81.TextAlign = ContentAlignment.MiddleCenter;
      this.label81.Click += new EventHandler(this.label81_Click);
      this.pictureBox78.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox78.Location = new Point(3, 3);
      this.pictureBox78.Name = "pictureBox78";
      this.pictureBox78.Size = new Size(100, 100);
      this.pictureBox78.TabIndex = 11;
      this.pictureBox78.TabStop = false;
      this.pictureBox78.Click += new EventHandler(this.pictureBox78_Click);
      this.panel82.Controls.Add((Control) this.label82);
      this.panel82.Controls.Add((Control) this.pictureBox79);
      this.panel82.Location = new Point(3, 9269);
      this.panel82.Name = "panel82";
      this.panel82.Size = new Size(105, 131);
      this.panel82.TabIndex = 79;
      this.label82.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label82.ForeColor = System.Drawing.Color.White;
      this.label82.Location = new Point(4, 106);
      this.label82.Name = "label82";
      this.label82.Size = new Size(98, 19);
      this.label82.TabIndex = 1;
      this.label82.Text = "Dr. Seuss Simulator";
      this.label82.TextAlign = ContentAlignment.MiddleCenter;
      this.label82.Click += new EventHandler(this.label82_Click);
      this.pictureBox79.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox79.Location = new Point(3, 3);
      this.pictureBox79.Name = "pictureBox79";
      this.pictureBox79.Size = new Size(100, 100);
      this.pictureBox79.TabIndex = 11;
      this.pictureBox79.TabStop = false;
      this.pictureBox79.Click += new EventHandler(this.pictureBox79_Click);
      this.panel83.Controls.Add((Control) this.label83);
      this.panel83.Controls.Add((Control) this.pictureBox80);
      this.panel83.Location = new Point(3, 9406);
      this.panel83.Name = "panel83";
      this.panel83.Size = new Size(105, 131);
      this.panel83.TabIndex = 80;
      this.label83.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label83.ForeColor = System.Drawing.Color.White;
      this.label83.Location = new Point(4, 106);
      this.label83.Name = "label83";
      this.label83.Size = new Size(98, 19);
      this.label83.TabIndex = 1;
      this.label83.Text = "Extreme Sprinting";
      this.label83.TextAlign = ContentAlignment.MiddleCenter;
      this.label83.Click += new EventHandler(this.label83_Click);
      this.pictureBox80.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox80.Location = new Point(3, 3);
      this.pictureBox80.Name = "pictureBox80";
      this.pictureBox80.Size = new Size(100, 100);
      this.pictureBox80.TabIndex = 11;
      this.pictureBox80.TabStop = false;
      this.pictureBox80.Click += new EventHandler(this.pictureBox80_Click);
      this.panel85.Controls.Add((Control) this.label85);
      this.panel85.Controls.Add((Control) this.pictureBox82);
      this.panel85.Location = new Point(3, 9543);
      this.panel85.Name = "panel85";
      this.panel85.Size = new Size(105, 131);
      this.panel85.TabIndex = 82;
      this.label85.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label85.ForeColor = System.Drawing.Color.White;
      this.label85.Location = new Point(4, 106);
      this.label85.Name = "label85";
      this.label85.Size = new Size(98, 19);
      this.label85.TabIndex = 1;
      this.label85.Text = "Sprinting Heroes";
      this.label85.TextAlign = ContentAlignment.MiddleCenter;
      this.label85.Click += new EventHandler(this.label85_Click);
      this.pictureBox82.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox82.Location = new Point(3, 3);
      this.pictureBox82.Name = "pictureBox82";
      this.pictureBox82.Size = new Size(100, 100);
      this.pictureBox82.TabIndex = 11;
      this.pictureBox82.TabStop = false;
      this.pictureBox82.Click += new EventHandler(this.pictureBox82_Click);
      this.panel86.Controls.Add((Control) this.label86);
      this.panel86.Controls.Add((Control) this.pictureBox83);
      this.panel86.Location = new Point(3, 9680);
      this.panel86.Name = "panel86";
      this.panel86.Size = new Size(105, 131);
      this.panel86.TabIndex = 83;
      this.label86.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label86.ForeColor = System.Drawing.Color.White;
      this.label86.Location = new Point(4, 106);
      this.label86.Name = "label86";
      this.label86.Size = new Size(98, 19);
      this.label86.TabIndex = 1;
      this.label86.Text = "Donut Story Tyc.";
      this.label86.TextAlign = ContentAlignment.MiddleCenter;
      this.label86.Click += new EventHandler(this.label86_Click);
      this.pictureBox83.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox83.Location = new Point(3, 3);
      this.pictureBox83.Name = "pictureBox83";
      this.pictureBox83.Size = new Size(100, 100);
      this.pictureBox83.TabIndex = 11;
      this.pictureBox83.TabStop = false;
      this.pictureBox83.Click += new EventHandler(this.pictureBox83_Click);
      this.panel87.Controls.Add((Control) this.label87);
      this.panel87.Controls.Add((Control) this.pictureBox84);
      this.panel87.Location = new Point(3, 9817);
      this.panel87.Name = "panel87";
      this.panel87.Size = new Size(105, 131);
      this.panel87.TabIndex = 84;
      this.label87.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label87.ForeColor = System.Drawing.Color.White;
      this.label87.Location = new Point(4, 106);
      this.label87.Name = "label87";
      this.label87.Size = new Size(98, 19);
      this.label87.TabIndex = 1;
      this.label87.Text = "Silent Assassin";
      this.label87.TextAlign = ContentAlignment.MiddleCenter;
      this.label87.Click += new EventHandler(this.label87_Click);
      this.pictureBox84.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox84.Location = new Point(3, 3);
      this.pictureBox84.Name = "pictureBox84";
      this.pictureBox84.Size = new Size(100, 100);
      this.pictureBox84.TabIndex = 11;
      this.pictureBox84.TabStop = false;
      this.pictureBox84.Click += new EventHandler(this.pictureBox84_Click);
      this.panel88.Controls.Add((Control) this.label88);
      this.panel88.Controls.Add((Control) this.pictureBox85);
      this.panel88.Location = new Point(3, 9954);
      this.panel88.Name = "panel88";
      this.panel88.Size = new Size(105, 131);
      this.panel88.TabIndex = 85;
      this.label88.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label88.ForeColor = System.Drawing.Color.White;
      this.label88.Location = new Point(4, 106);
      this.label88.Name = "label88";
      this.label88.Size = new Size(98, 19);
      this.label88.TabIndex = 1;
      this.label88.Text = "Wing Simulator";
      this.label88.TextAlign = ContentAlignment.MiddleCenter;
      this.label88.Click += new EventHandler(this.label88_Click);
      this.pictureBox85.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox85.Location = new Point(3, 3);
      this.pictureBox85.Name = "pictureBox85";
      this.pictureBox85.Size = new Size(100, 100);
      this.pictureBox85.TabIndex = 11;
      this.pictureBox85.TabStop = false;
      this.pictureBox85.Click += new EventHandler(this.pictureBox85_Click);
      this.panel89.Controls.Add((Control) this.label89);
      this.panel89.Controls.Add((Control) this.pictureBox86);
      this.panel89.Location = new Point(3, 10091);
      this.panel89.Name = "panel89";
      this.panel89.Size = new Size(105, 131);
      this.panel89.TabIndex = 86;
      this.label89.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label89.ForeColor = System.Drawing.Color.White;
      this.label89.Location = new Point(4, 106);
      this.label89.Name = "label89";
      this.label89.Size = new Size(98, 19);
      this.label89.TabIndex = 1;
      this.label89.Text = "Galactic Conquest";
      this.label89.TextAlign = ContentAlignment.MiddleCenter;
      this.label89.Click += new EventHandler(this.label89_Click);
      this.pictureBox86.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox86.Location = new Point(3, 3);
      this.pictureBox86.Name = "pictureBox86";
      this.pictureBox86.Size = new Size(100, 100);
      this.pictureBox86.TabIndex = 11;
      this.pictureBox86.TabStop = false;
      this.pictureBox86.Click += new EventHandler(this.pictureBox86_Click);
      this.panel90.Controls.Add((Control) this.label90);
      this.panel90.Controls.Add((Control) this.pictureBox87);
      this.panel90.Location = new Point(3, 10228);
      this.panel90.Name = "panel90";
      this.panel90.Size = new Size(105, 131);
      this.panel90.TabIndex = 87;
      this.label90.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label90.ForeColor = System.Drawing.Color.White;
      this.label90.Location = new Point(4, 106);
      this.label90.Name = "label90";
      this.label90.Size = new Size(98, 19);
      this.label90.TabIndex = 1;
      this.label90.Text = "Monster Simulator";
      this.label90.TextAlign = ContentAlignment.MiddleCenter;
      this.label90.Click += new EventHandler(this.label90_Click);
      this.pictureBox87.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox87.Location = new Point(3, 3);
      this.pictureBox87.Name = "pictureBox87";
      this.pictureBox87.Size = new Size(100, 100);
      this.pictureBox87.TabIndex = 11;
      this.pictureBox87.TabStop = false;
      this.pictureBox87.Click += new EventHandler(this.pictureBox87_Click);
      this.panel91.Controls.Add((Control) this.label91);
      this.panel91.Controls.Add((Control) this.pictureBox88);
      this.panel91.Location = new Point(3, 10365);
      this.panel91.Name = "panel91";
      this.panel91.Size = new Size(105, 131);
      this.panel91.TabIndex = 88;
      this.label91.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label91.ForeColor = System.Drawing.Color.White;
      this.label91.Location = new Point(4, 106);
      this.label91.Name = "label91";
      this.label91.Size = new Size(98, 19);
      this.label91.TabIndex = 1;
      this.label91.Text = "Flood Escape 2";
      this.label91.TextAlign = ContentAlignment.MiddleCenter;
      this.label91.Click += new EventHandler(this.label91_Click);
      this.pictureBox88.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox88.Location = new Point(3, 3);
      this.pictureBox88.Name = "pictureBox88";
      this.pictureBox88.Size = new Size(100, 100);
      this.pictureBox88.TabIndex = 11;
      this.pictureBox88.TabStop = false;
      this.pictureBox88.Click += new EventHandler(this.pictureBox88_Click);
      this.panel93.Controls.Add((Control) this.label93);
      this.panel93.Controls.Add((Control) this.pictureBox90);
      this.panel93.Location = new Point(3, 10502);
      this.panel93.Name = "panel93";
      this.panel93.Size = new Size(105, 131);
      this.panel93.TabIndex = 90;
      this.label93.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label93.ForeColor = System.Drawing.Color.White;
      this.label93.Location = new Point(4, 106);
      this.label93.Name = "label93";
      this.label93.Size = new Size(98, 19);
      this.label93.TabIndex = 1;
      this.label93.Text = " Really Easy Obby";
      this.label93.TextAlign = ContentAlignment.MiddleCenter;
      this.label93.Click += new EventHandler(this.label93_Click);
      this.pictureBox90.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox90.Location = new Point(3, 3);
      this.pictureBox90.Name = "pictureBox90";
      this.pictureBox90.Size = new Size(100, 100);
      this.pictureBox90.TabIndex = 11;
      this.pictureBox90.TabStop = false;
      this.pictureBox90.Click += new EventHandler(this.pictureBox90_Click);
      this.panel94.Controls.Add((Control) this.label94);
      this.panel94.Controls.Add((Control) this.pictureBox91);
      this.panel94.Location = new Point(3, 10639);
      this.panel94.Name = "panel94";
      this.panel94.Size = new Size(105, 131);
      this.panel94.TabIndex = 91;
      this.label94.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label94.ForeColor = System.Drawing.Color.White;
      this.label94.Location = new Point(4, 106);
      this.label94.Name = "label94";
      this.label94.Size = new Size(98, 19);
      this.label94.TabIndex = 1;
      this.label94.Text = "Demon Slayer";
      this.label94.TextAlign = ContentAlignment.MiddleCenter;
      this.label94.Click += new EventHandler(this.label94_Click);
      this.pictureBox91.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox91.Location = new Point(3, 3);
      this.pictureBox91.Name = "pictureBox91";
      this.pictureBox91.Size = new Size(100, 100);
      this.pictureBox91.TabIndex = 11;
      this.pictureBox91.TabStop = false;
      this.pictureBox91.Click += new EventHandler(this.pictureBox91_Click);
      this.panel95.Controls.Add((Control) this.label95);
      this.panel95.Controls.Add((Control) this.pictureBox92);
      this.panel95.Location = new Point(3, 10776);
      this.panel95.Name = "panel95";
      this.panel95.Size = new Size(105, 131);
      this.panel95.TabIndex = 92;
      this.panel95.Paint += new PaintEventHandler(this.panel95_Paint);
      this.label95.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label95.ForeColor = System.Drawing.Color.White;
      this.label95.Location = new Point(4, 106);
      this.label95.Name = "label95";
      this.label95.Size = new Size(98, 19);
      this.label95.TabIndex = 1;
      this.label95.Text = "Mineverse";
      this.label95.TextAlign = ContentAlignment.MiddleCenter;
      this.label95.Click += new EventHandler(this.label95_Click);
      this.pictureBox92.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox92.Location = new Point(3, 3);
      this.pictureBox92.Name = "pictureBox92";
      this.pictureBox92.Size = new Size(100, 100);
      this.pictureBox92.TabIndex = 11;
      this.pictureBox92.TabStop = false;
      this.pictureBox92.Click += new EventHandler(this.pictureBox92_Click);
      this.panel97.Controls.Add((Control) this.label97);
      this.panel97.Controls.Add((Control) this.pictureBox94);
      this.panel97.Location = new Point(3, 10913);
      this.panel97.Name = "panel97";
      this.panel97.Size = new Size(105, 131);
      this.panel97.TabIndex = 94;
      this.label97.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label97.ForeColor = System.Drawing.Color.White;
      this.label97.Location = new Point(4, 106);
      this.label97.Name = "label97";
      this.label97.Size = new Size(98, 19);
      this.label97.TabIndex = 1;
      this.label97.Text = "Building Sim 2";
      this.label97.TextAlign = ContentAlignment.MiddleCenter;
      this.label97.Click += new EventHandler(this.label97_Click);
      this.pictureBox94.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox94.Location = new Point(3, 3);
      this.pictureBox94.Name = "pictureBox94";
      this.pictureBox94.Size = new Size(100, 100);
      this.pictureBox94.TabIndex = 11;
      this.pictureBox94.TabStop = false;
      this.pictureBox94.Click += new EventHandler(this.pictureBox94_Click);
      this.panel98.Controls.Add((Control) this.label98);
      this.panel98.Controls.Add((Control) this.pictureBox95);
      this.panel98.Location = new Point(3, 11050);
      this.panel98.Name = "panel98";
      this.panel98.Size = new Size(105, 131);
      this.panel98.TabIndex = 95;
      this.label98.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label98.ForeColor = System.Drawing.Color.White;
      this.label98.Location = new Point(4, 106);
      this.label98.Name = "label98";
      this.label98.Size = new Size(98, 19);
      this.label98.TabIndex = 1;
      this.label98.Text = "Vehicle Tycoon";
      this.label98.TextAlign = ContentAlignment.MiddleCenter;
      this.label98.Click += new EventHandler(this.label98_Click);
      this.pictureBox95.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox95.Location = new Point(3, 3);
      this.pictureBox95.Name = "pictureBox95";
      this.pictureBox95.Size = new Size(100, 100);
      this.pictureBox95.TabIndex = 11;
      this.pictureBox95.TabStop = false;
      this.pictureBox95.Click += new EventHandler(this.pictureBox95_Click);
      this.panel99.Controls.Add((Control) this.label99);
      this.panel99.Controls.Add((Control) this.pictureBox96);
      this.panel99.Location = new Point(3, 11187);
      this.panel99.Name = "panel99";
      this.panel99.Size = new Size(105, 131);
      this.panel99.TabIndex = 96;
      this.label99.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label99.ForeColor = System.Drawing.Color.White;
      this.label99.Location = new Point(4, 106);
      this.label99.Name = "label99";
      this.label99.Size = new Size(98, 19);
      this.label99.TabIndex = 1;
      this.label99.Text = "Isle, 8";
      this.label99.TextAlign = ContentAlignment.MiddleCenter;
      this.label99.Click += new EventHandler(this.label99_Click);
      this.pictureBox96.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox96.Location = new Point(3, 3);
      this.pictureBox96.Name = "pictureBox96";
      this.pictureBox96.Size = new Size(100, 100);
      this.pictureBox96.TabIndex = 11;
      this.pictureBox96.TabStop = false;
      this.pictureBox96.Click += new EventHandler(this.pictureBox96_Click);
      this.panel96.Controls.Add((Control) this.label96);
      this.panel96.Controls.Add((Control) this.pictureBox93);
      this.panel96.Location = new Point(3, 11324);
      this.panel96.Name = "panel96";
      this.panel96.Size = new Size(105, 131);
      this.panel96.TabIndex = 97;
      this.label96.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label96.ForeColor = System.Drawing.Color.White;
      this.label96.Location = new Point(4, 106);
      this.label96.Name = "label96";
      this.label96.Size = new Size(98, 19);
      this.label96.TabIndex = 1;
      this.label96.Text = "Heroes Of Speed";
      this.label96.TextAlign = ContentAlignment.MiddleCenter;
      this.label96.Click += new EventHandler(this.label96_Click_1);
      this.pictureBox93.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox93.Location = new Point(3, 3);
      this.pictureBox93.Name = "pictureBox93";
      this.pictureBox93.Size = new Size(100, 100);
      this.pictureBox93.TabIndex = 11;
      this.pictureBox93.TabStop = false;
      this.pictureBox93.Click += new EventHandler(this.pictureBox93_Click_1);
      this.panel100.Controls.Add((Control) this.label100);
      this.panel100.Controls.Add((Control) this.pictureBox97);
      this.panel100.Location = new Point(3, 11461);
      this.panel100.Name = "panel100";
      this.panel100.Size = new Size(105, 131);
      this.panel100.TabIndex = 98;
      this.label100.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label100.ForeColor = System.Drawing.Color.White;
      this.label100.Location = new Point(4, 106);
      this.label100.Name = "label100";
      this.label100.Size = new Size(98, 19);
      this.label100.TabIndex = 1;
      this.label100.Text = "Bow Simulator";
      this.label100.TextAlign = ContentAlignment.MiddleCenter;
      this.label100.Click += new EventHandler(this.label100_Click);
      this.pictureBox97.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox97.Location = new Point(3, 3);
      this.pictureBox97.Name = "pictureBox97";
      this.pictureBox97.Size = new Size(100, 100);
      this.pictureBox97.TabIndex = 11;
      this.pictureBox97.TabStop = false;
      this.pictureBox97.Click += new EventHandler(this.pictureBox97_Click);
      this.panel103.Controls.Add((Control) this.label102);
      this.panel103.Controls.Add((Control) this.pictureBox100);
      this.panel103.Location = new Point(3, 11598);
      this.panel103.Name = "panel103";
      this.panel103.Size = new Size(105, 131);
      this.panel103.TabIndex = 101;
      this.label102.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label102.ForeColor = System.Drawing.Color.White;
      this.label102.Location = new Point(4, 106);
      this.label102.Name = "label102";
      this.label102.Size = new Size(98, 19);
      this.label102.TabIndex = 1;
      this.label102.Text = "King Piece";
      this.label102.TextAlign = ContentAlignment.MiddleCenter;
      this.label102.Click += new EventHandler(this.label102_Click);
      this.pictureBox100.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox100.Location = new Point(3, 3);
      this.pictureBox100.Name = "pictureBox100";
      this.pictureBox100.Size = new Size(100, 100);
      this.pictureBox100.TabIndex = 11;
      this.pictureBox100.TabStop = false;
      this.pictureBox100.Click += new EventHandler(this.pictureBox100_Click);
      this.panel101.Controls.Add((Control) this.label101);
      this.panel101.Controls.Add((Control) this.pictureBox98);
      this.panel101.Location = new Point(3, 11735);
      this.panel101.Name = "panel101";
      this.panel101.Size = new Size(105, 131);
      this.panel101.TabIndex = 102;
      this.label101.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label101.ForeColor = System.Drawing.Color.White;
      this.label101.Location = new Point(4, 106);
      this.label101.Name = "label101";
      this.label101.Size = new Size(98, 19);
      this.label101.TabIndex = 1;
      this.label101.Text = "LUCKY BLOCK";
      this.label101.TextAlign = ContentAlignment.MiddleCenter;
      this.label101.Click += new EventHandler(this.label101_Click_1);
      this.pictureBox98.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox98.Location = new Point(3, 3);
      this.pictureBox98.Name = "pictureBox98";
      this.pictureBox98.Size = new Size(100, 100);
      this.pictureBox98.TabIndex = 11;
      this.pictureBox98.TabStop = false;
      this.pictureBox98.Click += new EventHandler(this.pictureBox98_Click_1);
      this.panel104.Controls.Add((Control) this.label103);
      this.panel104.Controls.Add((Control) this.pictureBox101);
      this.panel104.Location = new Point(3, 11872);
      this.panel104.Name = "panel104";
      this.panel104.Size = new Size(105, 131);
      this.panel104.TabIndex = 103;
      this.label103.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label103.ForeColor = System.Drawing.Color.White;
      this.label103.Location = new Point(4, 106);
      this.label103.Name = "label103";
      this.label103.Size = new Size(100, 19);
      this.label103.TabIndex = 1;
      this.label103.Text = "Dragon Adventures";
      this.label103.TextAlign = ContentAlignment.MiddleCenter;
      this.label103.Click += new EventHandler(this.label103_Click);
      this.pictureBox101.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox101.Location = new Point(3, 3);
      this.pictureBox101.Name = "pictureBox101";
      this.pictureBox101.Size = new Size(100, 100);
      this.pictureBox101.TabIndex = 11;
      this.pictureBox101.TabStop = false;
      this.pictureBox101.Click += new EventHandler(this.pictureBox101_Click);
      this.panel105.Controls.Add((Control) this.label104);
      this.panel105.Controls.Add((Control) this.pictureBox102);
      this.panel105.Location = new Point(3, 12009);
      this.panel105.Name = "panel105";
      this.panel105.Size = new Size(105, 131);
      this.panel105.TabIndex = 103;
      this.label104.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label104.ForeColor = System.Drawing.Color.White;
      this.label104.Location = new Point(4, 106);
      this.label104.Name = "label104";
      this.label104.Size = new Size(98, 19);
      this.label104.TabIndex = 1;
      this.label104.Text = "Army Tycoon";
      this.label104.TextAlign = ContentAlignment.MiddleCenter;
      this.label104.Click += new EventHandler(this.label104_Click);
      this.pictureBox102.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox102.Location = new Point(3, 3);
      this.pictureBox102.Name = "pictureBox102";
      this.pictureBox102.Size = new Size(100, 100);
      this.pictureBox102.TabIndex = 11;
      this.pictureBox102.TabStop = false;
      this.pictureBox102.Click += new EventHandler(this.pictureBox102_Click);
      this.panel107.Controls.Add((Control) this.label106);
      this.panel107.Controls.Add((Control) this.pictureBox104);
      this.panel107.Location = new Point(3, 12146);
      this.panel107.Name = "panel107";
      this.panel107.Size = new Size(105, 131);
      this.panel107.TabIndex = 105;
      this.label106.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label106.ForeColor = System.Drawing.Color.White;
      this.label106.Location = new Point(4, 106);
      this.label106.Name = "label106";
      this.label106.Size = new Size(98, 19);
      this.label106.TabIndex = 1;
      this.label106.Text = "Bubble Gum Sim";
      this.label106.TextAlign = ContentAlignment.MiddleCenter;
      this.label106.Click += new EventHandler(this.label106_Click);
      this.pictureBox104.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox104.Location = new Point(3, 3);
      this.pictureBox104.Name = "pictureBox104";
      this.pictureBox104.Size = new Size(100, 100);
      this.pictureBox104.TabIndex = 11;
      this.pictureBox104.TabStop = false;
      this.pictureBox104.Click += new EventHandler(this.pictureBox104_Click);
      this.panel108.Controls.Add((Control) this.label107);
      this.panel108.Controls.Add((Control) this.pictureBox105);
      this.panel108.Location = new Point(3, 12283);
      this.panel108.Name = "panel108";
      this.panel108.Size = new Size(105, 131);
      this.panel108.TabIndex = 106;
      this.label107.FlatStyle = FlatStyle.Flat;
      this.label107.Font = new Font("Segoe UI Semilight", 7f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label107.ForeColor = System.Drawing.Color.White;
      this.label107.Location = new Point(4, 106);
      this.label107.Name = "label107";
      this.label107.Size = new Size(98, 25);
      this.label107.TabIndex = 1;
      this.label107.Text = "Grandma's House\r\nObby";
      this.label107.TextAlign = ContentAlignment.TopCenter;
      this.label107.UseMnemonic = false;
      this.label107.Click += new EventHandler(this.label107_Click);
      this.pictureBox105.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox105.Location = new Point(3, 3);
      this.pictureBox105.Name = "pictureBox105";
      this.pictureBox105.Size = new Size(100, 100);
      this.pictureBox105.TabIndex = 11;
      this.pictureBox105.TabStop = false;
      this.pictureBox105.Click += new EventHandler(this.pictureBox105_Click);
      this.panel106.Controls.Add((Control) this.label105);
      this.panel106.Controls.Add((Control) this.pictureBox103);
      this.panel106.Location = new Point(3, 12420);
      this.panel106.Name = "panel106";
      this.panel106.Size = new Size(105, 131);
      this.panel106.TabIndex = 104;
      this.label105.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label105.ForeColor = System.Drawing.Color.White;
      this.label105.Location = new Point(4, 106);
      this.label105.Name = "label105";
      this.label105.Size = new Size(98, 19);
      this.label105.TabIndex = 1;
      this.label105.Text = "Viking Simulator";
      this.label105.TextAlign = ContentAlignment.MiddleCenter;
      this.label105.Click += new EventHandler(this.label105_Click);
      this.pictureBox103.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox103.Location = new Point(3, 3);
      this.pictureBox103.Name = "pictureBox103";
      this.pictureBox103.Size = new Size(100, 100);
      this.pictureBox103.TabIndex = 11;
      this.pictureBox103.TabStop = false;
      this.pictureBox103.Click += new EventHandler(this.pictureBox103_Click);
      this.panel102.Controls.Add((Control) this.label16);
      this.panel102.Controls.Add((Control) this.pictureBox99);
      this.panel102.Location = new Point(3, 12557);
      this.panel102.Name = "panel102";
      this.panel102.Size = new Size(105, 131);
      this.panel102.TabIndex = 100;
      this.label16.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label16.ForeColor = System.Drawing.Color.White;
      this.label16.Location = new Point(4, 106);
      this.label16.Name = "label16";
      this.label16.Size = new Size(98, 19);
      this.label16.TabIndex = 1;
      this.label16.Text = "Lawn Mowing Sim";
      this.label16.TextAlign = ContentAlignment.MiddleCenter;
      this.label16.Click += new EventHandler(this.label16_Click_1);
      this.pictureBox99.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox99.Location = new Point(3, 3);
      this.pictureBox99.Name = "pictureBox99";
      this.pictureBox99.Size = new Size(100, 100);
      this.pictureBox99.TabIndex = 11;
      this.pictureBox99.TabStop = false;
      this.pictureBox99.Click += new EventHandler(this.pictureBox99_Click);
      this.panel109.Controls.Add((Control) this.label108);
      this.panel109.Controls.Add((Control) this.pictureBox106);
      this.panel109.Location = new Point(3, 12694);
      this.panel109.Name = "panel109";
      this.panel109.Size = new Size(105, 131);
      this.panel109.TabIndex = 69;
      this.label108.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label108.ForeColor = System.Drawing.Color.White;
      this.label108.Location = new Point(4, 106);
      this.label108.Name = "label108";
      this.label108.Size = new Size(98, 19);
      this.label108.TabIndex = 1;
      this.label108.Text = "Horror Tycoon";
      this.label108.TextAlign = ContentAlignment.MiddleCenter;
      this.label108.Click += new EventHandler(this.label108_Click);
      this.pictureBox106.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox106.Location = new Point(3, 3);
      this.pictureBox106.Name = "pictureBox106";
      this.pictureBox106.Size = new Size(100, 100);
      this.pictureBox106.TabIndex = 11;
      this.pictureBox106.TabStop = false;
      this.pictureBox106.Click += new EventHandler(this.pictureBox106_Click);
      this.panel111.Controls.Add((Control) this.label110);
      this.panel111.Controls.Add((Control) this.pictureBox108);
      this.panel111.Location = new Point(3, 12831);
      this.panel111.Name = "panel111";
      this.panel111.Size = new Size(105, 131);
      this.panel111.TabIndex = 71;
      this.label110.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label110.ForeColor = System.Drawing.Color.White;
      this.label110.Location = new Point(4, 106);
      this.label110.Name = "label110";
      this.label110.Size = new Size(98, 19);
      this.label110.TabIndex = 1;
      this.label110.Text = "Saber Simulator";
      this.label110.TextAlign = ContentAlignment.MiddleCenter;
      this.label110.Click += new EventHandler(this.label110_Click);
      this.pictureBox108.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox108.Location = new Point(3, 3);
      this.pictureBox108.Name = "pictureBox108";
      this.pictureBox108.Size = new Size(100, 100);
      this.pictureBox108.TabIndex = 11;
      this.pictureBox108.TabStop = false;
      this.pictureBox108.Click += new EventHandler(this.pictureBox108_Click);
      this.panel112.Controls.Add((Control) this.label111);
      this.panel112.Controls.Add((Control) this.pictureBox109);
      this.panel112.Location = new Point(3, 12968);
      this.panel112.Name = "panel112";
      this.panel112.Size = new Size(105, 131);
      this.panel112.TabIndex = 72;
      this.label111.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label111.ForeColor = System.Drawing.Color.White;
      this.label111.Location = new Point(4, 106);
      this.label111.Name = "label111";
      this.label111.Size = new Size(98, 19);
      this.label111.TabIndex = 1;
      this.label111.Text = "Survive the Killer!";
      this.label111.TextAlign = ContentAlignment.MiddleCenter;
      this.label111.Click += new EventHandler(this.label111_Click);
      this.pictureBox109.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox109.Location = new Point(3, 3);
      this.pictureBox109.Name = "pictureBox109";
      this.pictureBox109.Size = new Size(100, 100);
      this.pictureBox109.TabIndex = 11;
      this.pictureBox109.TabStop = false;
      this.pictureBox109.Click += new EventHandler(this.pictureBox109_Click);
      this.panel113.Controls.Add((Control) this.label112);
      this.panel113.Controls.Add((Control) this.pictureBox110);
      this.panel113.Location = new Point(3, 13105);
      this.panel113.Name = "panel113";
      this.panel113.Size = new Size(105, 131);
      this.panel113.TabIndex = 73;
      this.label112.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label112.ForeColor = System.Drawing.Color.White;
      this.label112.Location = new Point(4, 106);
      this.label112.Name = "label112";
      this.label112.Size = new Size(98, 19);
      this.label112.TabIndex = 1;
      this.label112.Text = "A Modded Day";
      this.label112.TextAlign = ContentAlignment.MiddleCenter;
      this.label112.Click += new EventHandler(this.label112_Click);
      this.pictureBox110.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox110.Location = new Point(3, 3);
      this.pictureBox110.Name = "pictureBox110";
      this.pictureBox110.Size = new Size(100, 100);
      this.pictureBox110.TabIndex = 11;
      this.pictureBox110.TabStop = false;
      this.pictureBox110.Click += new EventHandler(this.pictureBox110_Click);
      this.panel92.Controls.Add((Control) this.label92);
      this.panel92.Controls.Add((Control) this.pictureBox89);
      this.panel92.Location = new Point(3, 13242);
      this.panel92.Name = "panel92";
      this.panel92.Size = new Size(105, 131);
      this.panel92.TabIndex = 74;
      this.label92.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label92.ForeColor = System.Drawing.Color.White;
      this.label92.Location = new Point(4, 106);
      this.label92.Name = "label92";
      this.label92.Size = new Size(98, 19);
      this.label92.TabIndex = 1;
      this.label92.Text = "Murder Mystery 3";
      this.label92.TextAlign = ContentAlignment.MiddleCenter;
      this.label92.Click += new EventHandler(this.label92_Click_1);
      this.pictureBox89.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox89.Location = new Point(3, 3);
      this.pictureBox89.Name = "pictureBox89";
      this.pictureBox89.Size = new Size(100, 100);
      this.pictureBox89.TabIndex = 11;
      this.pictureBox89.TabStop = false;
      this.pictureBox89.Click += new EventHandler(this.pictureBox89_Click_1);
      this.panel114.Controls.Add((Control) this.label113);
      this.panel114.Controls.Add((Control) this.pictureBox111);
      this.panel114.Location = new Point(3, 13379);
      this.panel114.Name = "panel114";
      this.panel114.Size = new Size(105, 131);
      this.panel114.TabIndex = 75;
      this.label113.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label113.ForeColor = System.Drawing.Color.White;
      this.label113.Location = new Point(4, 106);
      this.label113.Name = "label113";
      this.label113.Size = new Size(98, 19);
      this.label113.TabIndex = 1;
      this.label113.Text = "Breaking Point";
      this.label113.TextAlign = ContentAlignment.MiddleCenter;
      this.label113.Click += new EventHandler(this.label113_Click);
      this.pictureBox111.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox111.Location = new Point(3, 3);
      this.pictureBox111.Name = "pictureBox111";
      this.pictureBox111.Size = new Size(100, 100);
      this.pictureBox111.TabIndex = 11;
      this.pictureBox111.TabStop = false;
      this.pictureBox111.Click += new EventHandler(this.pictureBox111_Click);
      this.panel59.Controls.Add((Control) this.label60);
      this.panel59.Controls.Add((Control) this.pictureBox56);
      this.panel59.Location = new Point(3, 13516);
      this.panel59.Name = "panel59";
      this.panel59.Size = new Size(105, 125);
      this.panel59.TabIndex = 54;
      this.label60.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label60.ForeColor = System.Drawing.Color.White;
      this.label60.Location = new Point(4, 106);
      this.label60.Name = "label60";
      this.label60.Size = new Size(98, 19);
      this.label60.TabIndex = 1;
      this.label60.Text = "Dungeon Quest";
      this.label60.TextAlign = ContentAlignment.MiddleCenter;
      this.label60.Click += new EventHandler(this.label60_Click);
      this.pictureBox56.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox56.Location = new Point(3, 3);
      this.pictureBox56.Name = "pictureBox56";
      this.pictureBox56.Size = new Size(100, 100);
      this.pictureBox56.TabIndex = 11;
      this.pictureBox56.TabStop = false;
      this.pictureBox56.Click += new EventHandler(this.pictureBox56_Click);
      this.panel115.Controls.Add((Control) this.label114);
      this.panel115.Controls.Add((Control) this.pictureBox112);
      this.panel115.Location = new Point(3, 13647);
      this.panel115.Name = "panel115";
      this.panel115.Size = new Size(105, 125);
      this.panel115.TabIndex = 55;
      this.label114.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label114.ForeColor = System.Drawing.Color.White;
      this.label114.Location = new Point(4, 106);
      this.label114.Name = "label114";
      this.label114.Size = new Size(98, 19);
      this.label114.TabIndex = 1;
      this.label114.Text = "Egg Clicker";
      this.label114.TextAlign = ContentAlignment.MiddleCenter;
      this.label114.Click += new EventHandler(this.label114_Click);
      this.pictureBox112.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox112.Location = new Point(3, 3);
      this.pictureBox112.Name = "pictureBox112";
      this.pictureBox112.Size = new Size(100, 100);
      this.pictureBox112.TabIndex = 11;
      this.pictureBox112.TabStop = false;
      this.pictureBox112.Click += new EventHandler(this.pictureBox112_Click);
      this.panel116.Controls.Add((Control) this.label115);
      this.panel116.Controls.Add((Control) this.pictureBox113);
      this.panel116.Location = new Point(3, 13778);
      this.panel116.Name = "panel116";
      this.panel116.Size = new Size(105, 125);
      this.panel116.TabIndex = 56;
      this.label115.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label115.ForeColor = System.Drawing.Color.White;
      this.label115.Location = new Point(4, 106);
      this.label115.Name = "label115";
      this.label115.Size = new Size(98, 19);
      this.label115.TabIndex = 1;
      this.label115.Text = "Thick Legends";
      this.label115.TextAlign = ContentAlignment.MiddleCenter;
      this.label115.Click += new EventHandler(this.label115_Click);
      this.pictureBox113.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox113.Location = new Point(3, 3);
      this.pictureBox113.Name = "pictureBox113";
      this.pictureBox113.Size = new Size(100, 100);
      this.pictureBox113.TabIndex = 11;
      this.pictureBox113.TabStop = false;
      this.pictureBox113.Click += new EventHandler(this.pictureBox113_Click);
      this.panel117.Controls.Add((Control) this.label116);
      this.panel117.Controls.Add((Control) this.pictureBox114);
      this.panel117.Location = new Point(3, 13909);
      this.panel117.Name = "panel117";
      this.panel117.Size = new Size(105, 125);
      this.panel117.TabIndex = 57;
      this.label116.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label116.ForeColor = System.Drawing.Color.White;
      this.label116.Location = new Point(4, 106);
      this.label116.Name = "label116";
      this.label116.Size = new Size(98, 19);
      this.label116.TabIndex = 1;
      this.label116.Text = "Thief Life Simulator";
      this.label116.TextAlign = ContentAlignment.MiddleCenter;
      this.label116.Click += new EventHandler(this.label116_Click);
      this.pictureBox114.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox114.Location = new Point(3, 3);
      this.pictureBox114.Name = "pictureBox114";
      this.pictureBox114.Size = new Size(100, 100);
      this.pictureBox114.TabIndex = 11;
      this.pictureBox114.TabStop = false;
      this.pictureBox114.Click += new EventHandler(this.pictureBox114_Click);
      this.panel118.Controls.Add((Control) this.label117);
      this.panel118.Controls.Add((Control) this.pictureBox115);
      this.panel118.Location = new Point(3, 14040);
      this.panel118.Name = "panel118";
      this.panel118.Size = new Size(105, 125);
      this.panel118.TabIndex = 58;
      this.label117.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label117.ForeColor = System.Drawing.Color.White;
      this.label117.Location = new Point(4, 106);
      this.label117.Name = "label117";
      this.label117.Size = new Size(98, 19);
      this.label117.TabIndex = 1;
      this.label117.Text = "Hotel Elephant";
      this.label117.TextAlign = ContentAlignment.MiddleCenter;
      this.label117.Click += new EventHandler(this.label117_Click);
      this.pictureBox115.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox115.Location = new Point(3, 3);
      this.pictureBox115.Name = "pictureBox115";
      this.pictureBox115.Size = new Size(100, 100);
      this.pictureBox115.TabIndex = 11;
      this.pictureBox115.TabStop = false;
      this.pictureBox115.Click += new EventHandler(this.pictureBox115_Click);
      this.panel120.Controls.Add((Control) this.label119);
      this.panel120.Controls.Add((Control) this.pictureBox117);
      this.panel120.Location = new Point(3, 14171);
      this.panel120.Name = "panel120";
      this.panel120.Size = new Size(105, 125);
      this.panel120.TabIndex = 60;
      this.label119.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label119.ForeColor = System.Drawing.Color.White;
      this.label119.Location = new Point(4, 106);
      this.label119.Name = "label119";
      this.label119.Size = new Size(98, 19);
      this.label119.TabIndex = 1;
      this.label119.Text = "Robot 64";
      this.label119.TextAlign = ContentAlignment.MiddleCenter;
      this.label119.Click += new EventHandler(this.label119_Click);
      this.pictureBox117.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox117.Location = new Point(3, 3);
      this.pictureBox117.Name = "pictureBox117";
      this.pictureBox117.Size = new Size(100, 100);
      this.pictureBox117.TabIndex = 11;
      this.pictureBox117.TabStop = false;
      this.pictureBox117.Click += new EventHandler(this.pictureBox117_Click);
      this.panel121.Controls.Add((Control) this.label120);
      this.panel121.Controls.Add((Control) this.pictureBox118);
      this.panel121.Location = new Point(3, 14302);
      this.panel121.Name = "panel121";
      this.panel121.Size = new Size(105, 125);
      this.panel121.TabIndex = 61;
      this.label120.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label120.ForeColor = System.Drawing.Color.White;
      this.label120.Location = new Point(4, 106);
      this.label120.Name = "label120";
      this.label120.Size = new Size(98, 19);
      this.label120.TabIndex = 1;
      this.label120.Text = "Fishing Simulator";
      this.label120.TextAlign = ContentAlignment.MiddleCenter;
      this.label120.Click += new EventHandler(this.label120_Click);
      this.pictureBox118.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox118.Location = new Point(3, 3);
      this.pictureBox118.Name = "pictureBox118";
      this.pictureBox118.Size = new Size(100, 100);
      this.pictureBox118.TabIndex = 11;
      this.pictureBox118.TabStop = false;
      this.pictureBox118.Click += new EventHandler(this.pictureBox118_Click);
      this.panel122.Controls.Add((Control) this.label121);
      this.panel122.Controls.Add((Control) this.pictureBox119);
      this.panel122.Location = new Point(3, 14433);
      this.panel122.Name = "panel122";
      this.panel122.Size = new Size(105, 125);
      this.panel122.TabIndex = 62;
      this.label121.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label121.ForeColor = System.Drawing.Color.White;
      this.label121.Location = new Point(4, 106);
      this.label121.Name = "label121";
      this.label121.Size = new Size(98, 19);
      this.label121.TabIndex = 1;
      this.label121.Text = "Legends Of Speed";
      this.label121.TextAlign = ContentAlignment.MiddleCenter;
      this.label121.Click += new EventHandler(this.label121_Click);
      this.pictureBox119.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox119.Location = new Point(3, 3);
      this.pictureBox119.Name = "pictureBox119";
      this.pictureBox119.Size = new Size(100, 100);
      this.pictureBox119.TabIndex = 11;
      this.pictureBox119.TabStop = false;
      this.pictureBox119.Click += new EventHandler(this.pictureBox119_Click);
      this.panel123.Controls.Add((Control) this.label122);
      this.panel123.Controls.Add((Control) this.pictureBox120);
      this.panel123.Location = new Point(3, 14564);
      this.panel123.Name = "panel123";
      this.panel123.Size = new Size(105, 125);
      this.panel123.TabIndex = 63;
      this.label122.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label122.ForeColor = System.Drawing.Color.White;
      this.label122.Location = new Point(4, 106);
      this.label122.Name = "label122";
      this.label122.Size = new Size(98, 19);
      this.label122.TabIndex = 1;
      this.label122.Text = "Billionaire Simulator";
      this.label122.TextAlign = ContentAlignment.MiddleCenter;
      this.label122.Click += new EventHandler(this.label122_Click);
      this.pictureBox120.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox120.Location = new Point(3, 3);
      this.pictureBox120.Name = "pictureBox120";
      this.pictureBox120.Size = new Size(100, 100);
      this.pictureBox120.TabIndex = 11;
      this.pictureBox120.TabStop = false;
      this.pictureBox120.Click += new EventHandler(this.pictureBox120_Click);
      this.panel124.Controls.Add((Control) this.label123);
      this.panel124.Controls.Add((Control) this.pictureBox121);
      this.panel124.Location = new Point(3, 14695);
      this.panel124.Name = "panel124";
      this.panel124.Size = new Size(105, 125);
      this.panel124.TabIndex = 64;
      this.label123.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label123.ForeColor = System.Drawing.Color.White;
      this.label123.Location = new Point(3, 99);
      this.label123.Name = "label123";
      this.label123.Size = new Size(99, 29);
      this.label123.TabIndex = 1;
      this.label123.Text = "Dragon Ball \r\n Ultimate";
      this.label123.TextAlign = ContentAlignment.MiddleCenter;
      this.label123.Click += new EventHandler(this.label123_Click);
      this.pictureBox121.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox121.Location = new Point(3, 3);
      this.pictureBox121.Name = "pictureBox121";
      this.pictureBox121.Size = new Size(100, 100);
      this.pictureBox121.TabIndex = 11;
      this.pictureBox121.TabStop = false;
      this.pictureBox121.Click += new EventHandler(this.pictureBox121_Click);
      this.panel125.Controls.Add((Control) this.label124);
      this.panel125.Controls.Add((Control) this.pictureBox122);
      this.panel125.Location = new Point(3, 14826);
      this.panel125.Name = "panel125";
      this.panel125.Size = new Size(105, 125);
      this.panel125.TabIndex = 64;
      this.label124.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label124.ForeColor = System.Drawing.Color.White;
      this.label124.Location = new Point(4, 106);
      this.label124.Name = "label124";
      this.label124.Size = new Size(98, 19);
      this.label124.TabIndex = 1;
      this.label124.Text = "Treacherous Tower";
      this.label124.TextAlign = ContentAlignment.MiddleCenter;
      this.label124.Click += new EventHandler(this.label124_Click);
      this.pictureBox122.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox122.Location = new Point(3, 3);
      this.pictureBox122.Name = "pictureBox122";
      this.pictureBox122.Size = new Size(100, 100);
      this.pictureBox122.TabIndex = 11;
      this.pictureBox122.TabStop = false;
      this.pictureBox122.Click += new EventHandler(this.pictureBox122_Click);
      this.panel126.Controls.Add((Control) this.label125);
      this.panel126.Controls.Add((Control) this.pictureBox123);
      this.panel126.Location = new Point(3, 14957);
      this.panel126.Name = "panel126";
      this.panel126.Size = new Size(105, 125);
      this.panel126.TabIndex = 65;
      this.label125.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label125.ForeColor = System.Drawing.Color.White;
      this.label125.Location = new Point(4, 106);
      this.label125.Name = "label125";
      this.label125.Size = new Size(98, 19);
      this.label125.TabIndex = 1;
      this.label125.Text = "Speed Champions";
      this.label125.TextAlign = ContentAlignment.MiddleCenter;
      this.label125.Click += new EventHandler(this.label125_Click);
      this.pictureBox123.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox123.Location = new Point(3, 3);
      this.pictureBox123.Name = "pictureBox123";
      this.pictureBox123.Size = new Size(100, 100);
      this.pictureBox123.TabIndex = 11;
      this.pictureBox123.TabStop = false;
      this.pictureBox123.Click += new EventHandler(this.pictureBox123_Click);
      this.panel84.Controls.Add((Control) this.label84);
      this.panel84.Controls.Add((Control) this.pictureBox81);
      this.panel84.Location = new Point(3, 15088);
      this.panel84.Name = "panel84";
      this.panel84.Size = new Size(105, 131);
      this.panel84.TabIndex = 81;
      this.label84.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label84.ForeColor = System.Drawing.Color.White;
      this.label84.Location = new Point(4, 106);
      this.label84.Name = "label84";
      this.label84.Size = new Size(98, 19);
      this.label84.TabIndex = 1;
      this.label84.Text = "KAT";
      this.label84.TextAlign = ContentAlignment.MiddleCenter;
      this.label84.Click += new EventHandler(this.label84_Click);
      this.pictureBox81.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox81.Location = new Point(3, 3);
      this.pictureBox81.Name = "pictureBox81";
      this.pictureBox81.Size = new Size(100, 100);
      this.pictureBox81.TabIndex = 11;
      this.pictureBox81.TabStop = false;
      this.pictureBox81.Click += new EventHandler(this.pictureBox81_Click);
      this.panel127.Controls.Add((Control) this.label126);
      this.panel127.Controls.Add((Control) this.pictureBox124);
      this.panel127.Location = new Point(3, 15225);
      this.panel127.Name = "panel127";
      this.panel127.Size = new Size(105, 131);
      this.panel127.TabIndex = 82;
      this.label126.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label126.ForeColor = System.Drawing.Color.White;
      this.label126.Location = new Point(4, 106);
      this.label126.Name = "label126";
      this.label126.Size = new Size(98, 19);
      this.label126.TabIndex = 1;
      this.label126.Text = "K.O Simulator";
      this.label126.TextAlign = ContentAlignment.MiddleCenter;
      this.label126.Click += new EventHandler(this.label126_Click);
      this.pictureBox124.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox124.Location = new Point(3, 3);
      this.pictureBox124.Name = "pictureBox124";
      this.pictureBox124.Size = new Size(100, 100);
      this.pictureBox124.TabIndex = 11;
      this.pictureBox124.TabStop = false;
      this.pictureBox124.Click += new EventHandler(this.pictureBox124_Click);
      this.panel71.Controls.Add((Control) this.label71);
      this.panel71.Controls.Add((Control) this.pictureBox68);
      this.panel71.Location = new Point(3, 15362);
      this.panel71.Name = "panel71";
      this.panel71.Size = new Size(105, 131);
      this.panel71.TabIndex = 68;
      this.label71.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label71.ForeColor = System.Drawing.Color.White;
      this.label71.Location = new Point(4, 106);
      this.label71.Name = "label71";
      this.label71.Size = new Size(98, 19);
      this.label71.TabIndex = 1;
      this.label71.Text = "Phantom Forces";
      this.label71.TextAlign = ContentAlignment.MiddleCenter;
      this.label71.Click += new EventHandler(this.label71_Click);
      this.pictureBox68.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox68.Location = new Point(3, 3);
      this.pictureBox68.Name = "pictureBox68";
      this.pictureBox68.Size = new Size(100, 100);
      this.pictureBox68.TabIndex = 11;
      this.pictureBox68.TabStop = false;
      this.pictureBox68.Click += new EventHandler(this.pictureBox68_Click);
      this.panel128.Controls.Add((Control) this.label127);
      this.panel128.Controls.Add((Control) this.pictureBox125);
      this.panel128.Location = new Point(3, 15499);
      this.panel128.Name = "panel128";
      this.panel128.Size = new Size(105, 131);
      this.panel128.TabIndex = 69;
      this.label127.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label127.ForeColor = System.Drawing.Color.White;
      this.label127.Location = new Point(4, 106);
      this.label127.Name = "label127";
      this.label127.Size = new Size(98, 19);
      this.label127.TabIndex = 1;
      this.label127.Text = "Lost";
      this.label127.TextAlign = ContentAlignment.MiddleCenter;
      this.label127.Click += new EventHandler(this.label127_Click);
      this.pictureBox125.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox125.Location = new Point(3, 3);
      this.pictureBox125.Name = "pictureBox125";
      this.pictureBox125.Size = new Size(100, 100);
      this.pictureBox125.TabIndex = 11;
      this.pictureBox125.TabStop = false;
      this.pictureBox125.Click += new EventHandler(this.pictureBox125_Click);
      this.panel129.Controls.Add((Control) this.label128);
      this.panel129.Controls.Add((Control) this.pictureBox126);
      this.panel129.Location = new Point(3, 15636);
      this.panel129.Name = "panel129";
      this.panel129.Size = new Size(105, 131);
      this.panel129.TabIndex = 70;
      this.label128.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label128.ForeColor = System.Drawing.Color.White;
      this.label128.Location = new Point(4, 106);
      this.label128.Name = "label128";
      this.label128.Size = new Size(98, 19);
      this.label128.TabIndex = 1;
      this.label128.Text = "World Of Magic";
      this.label128.TextAlign = ContentAlignment.MiddleCenter;
      this.label128.Click += new EventHandler(this.label128_Click);
      this.pictureBox126.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox126.Location = new Point(3, 3);
      this.pictureBox126.Name = "pictureBox126";
      this.pictureBox126.Size = new Size(100, 100);
      this.pictureBox126.TabIndex = 11;
      this.pictureBox126.TabStop = false;
      this.pictureBox126.Click += new EventHandler(this.pictureBox126_Click);
      this.panel130.Controls.Add((Control) this.label129);
      this.panel130.Controls.Add((Control) this.pictureBox127);
      this.panel130.Location = new Point(3, 15773);
      this.panel130.Name = "panel130";
      this.panel130.Size = new Size(105, 131);
      this.panel130.TabIndex = 71;
      this.label129.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label129.ForeColor = System.Drawing.Color.White;
      this.label129.Location = new Point(4, 106);
      this.label129.Name = "label129";
      this.label129.Size = new Size(98, 19);
      this.label129.TabIndex = 1;
      this.label129.Text = "Notoriety";
      this.label129.TextAlign = ContentAlignment.MiddleCenter;
      this.label129.Click += new EventHandler(this.label129_Click);
      this.pictureBox127.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox127.Location = new Point(3, 3);
      this.pictureBox127.Name = "pictureBox127";
      this.pictureBox127.Size = new Size(100, 100);
      this.pictureBox127.TabIndex = 11;
      this.pictureBox127.TabStop = false;
      this.pictureBox127.Click += new EventHandler(this.pictureBox127_Click);
      this.panel131.Controls.Add((Control) this.label130);
      this.panel131.Controls.Add((Control) this.pictureBox128);
      this.panel131.Location = new Point(3, 15910);
      this.panel131.Name = "panel131";
      this.panel131.Size = new Size(105, 131);
      this.panel131.TabIndex = 72;
      this.label130.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label130.ForeColor = System.Drawing.Color.White;
      this.label130.Location = new Point(4, 106);
      this.label130.Name = "label130";
      this.label130.Size = new Size(98, 19);
      this.label130.TabIndex = 1;
      this.label130.Text = "RPG Simulator";
      this.label130.TextAlign = ContentAlignment.MiddleCenter;
      this.label130.Click += new EventHandler(this.label130_Click);
      this.pictureBox128.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox128.Location = new Point(3, 3);
      this.pictureBox128.Name = "pictureBox128";
      this.pictureBox128.Size = new Size(100, 100);
      this.pictureBox128.TabIndex = 11;
      this.pictureBox128.TabStop = false;
      this.pictureBox128.Click += new EventHandler(this.pictureBox128_Click);
      this.panel119.Controls.Add((Control) this.label118);
      this.panel119.Controls.Add((Control) this.pictureBox116);
      this.panel119.Location = new Point(3, 16047);
      this.panel119.Name = "panel119";
      this.panel119.Size = new Size(105, 131);
      this.panel119.TabIndex = 73;
      this.label118.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label118.ForeColor = System.Drawing.Color.White;
      this.label118.Location = new Point(4, 106);
      this.label118.Name = "label118";
      this.label118.Size = new Size(98, 19);
      this.label118.TabIndex = 1;
      this.label118.Text = "Fitness Simulator";
      this.label118.TextAlign = ContentAlignment.MiddleCenter;
      this.label118.Click += new EventHandler(this.label118_Click_1);
      this.pictureBox116.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox116.Location = new Point(3, 3);
      this.pictureBox116.Name = "pictureBox116";
      this.pictureBox116.Size = new Size(100, 100);
      this.pictureBox116.TabIndex = 11;
      this.pictureBox116.TabStop = false;
      this.pictureBox116.Click += new EventHandler(this.pictureBox116_Click_1);
      this.panel132.Controls.Add((Control) this.label131);
      this.panel132.Controls.Add((Control) this.pictureBox129);
      this.panel132.Location = new Point(3, 16184);
      this.panel132.Name = "panel132";
      this.panel132.Size = new Size(105, 131);
      this.panel132.TabIndex = 74;
      this.label131.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label131.ForeColor = System.Drawing.Color.White;
      this.label131.Location = new Point(4, 106);
      this.label131.Name = "label131";
      this.label131.Size = new Size(98, 19);
      this.label131.TabIndex = 1;
      this.label131.Text = "Fortress Simulator";
      this.label131.TextAlign = ContentAlignment.MiddleCenter;
      this.label131.Click += new EventHandler(this.label131_Click);
      this.pictureBox129.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox129.Location = new Point(3, 3);
      this.pictureBox129.Name = "pictureBox129";
      this.pictureBox129.Size = new Size(100, 100);
      this.pictureBox129.TabIndex = 11;
      this.pictureBox129.TabStop = false;
      this.pictureBox129.Click += new EventHandler(this.pictureBox129_Click);
      this.panel133.Controls.Add((Control) this.label132);
      this.panel133.Controls.Add((Control) this.pictureBox130);
      this.panel133.Location = new Point(3, 16321);
      this.panel133.Name = "panel133";
      this.panel133.Size = new Size(105, 131);
      this.panel133.TabIndex = 75;
      this.label132.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label132.ForeColor = System.Drawing.Color.White;
      this.label132.Location = new Point(3, 103);
      this.label132.Name = "label132";
      this.label132.Size = new Size(99, 28);
      this.label132.TabIndex = 1;
      this.label132.Text = "Lumberjack \r\nLegends";
      this.label132.TextAlign = ContentAlignment.MiddleCenter;
      this.label132.Click += new EventHandler(this.label132_Click);
      this.pictureBox130.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox130.Location = new Point(3, 3);
      this.pictureBox130.Name = "pictureBox130";
      this.pictureBox130.Size = new Size(100, 100);
      this.pictureBox130.TabIndex = 11;
      this.pictureBox130.TabStop = false;
      this.pictureBox130.Click += new EventHandler(this.pictureBox130_Click);
      this.panel136.Controls.Add((Control) this.label135);
      this.panel136.Controls.Add((Control) this.pictureBox133);
      this.panel136.Location = new Point(3, 16458);
      this.panel136.Name = "panel136";
      this.panel136.Size = new Size(105, 131);
      this.panel136.TabIndex = 76;
      this.label135.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label135.ForeColor = System.Drawing.Color.White;
      this.label135.Location = new Point(4, 103);
      this.label135.Name = "label135";
      this.label135.Size = new Size(98, 28);
      this.label135.TabIndex = 1;
      this.label135.Text = "Super Blocky\r\n Ball";
      this.label135.TextAlign = ContentAlignment.MiddleCenter;
      this.label135.Click += new EventHandler(this.label135_Click);
      this.pictureBox133.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox133.Location = new Point(3, 3);
      this.pictureBox133.Name = "pictureBox133";
      this.pictureBox133.Size = new Size(100, 100);
      this.pictureBox133.TabIndex = 11;
      this.pictureBox133.TabStop = false;
      this.pictureBox133.Click += new EventHandler(this.pictureBox133_Click);
      this.panel137.Controls.Add((Control) this.label136);
      this.panel137.Controls.Add((Control) this.pictureBox134);
      this.panel137.Location = new Point(3, 16595);
      this.panel137.Name = "panel137";
      this.panel137.Size = new Size(105, 131);
      this.panel137.TabIndex = 77;
      this.label136.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label136.ForeColor = System.Drawing.Color.White;
      this.label136.Location = new Point(4, 103);
      this.label136.Name = "label136";
      this.label136.Size = new Size(98, 28);
      this.label136.TabIndex = 1;
      this.label136.Text = "Castle Heist \r\nAdventure";
      this.label136.TextAlign = ContentAlignment.MiddleCenter;
      this.label136.Click += new EventHandler(this.label136_Click);
      this.pictureBox134.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox134.Location = new Point(3, 3);
      this.pictureBox134.Name = "pictureBox134";
      this.pictureBox134.Size = new Size(100, 100);
      this.pictureBox134.TabIndex = 11;
      this.pictureBox134.TabStop = false;
      this.pictureBox134.Click += new EventHandler(this.pictureBox134_Click);
      this.panel138.Controls.Add((Control) this.label137);
      this.panel138.Controls.Add((Control) this.pictureBox135);
      this.panel138.Location = new Point(3, 16732);
      this.panel138.Name = "panel138";
      this.panel138.Size = new Size(105, 131);
      this.panel138.TabIndex = 78;
      this.label137.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label137.ForeColor = System.Drawing.Color.White;
      this.label137.Location = new Point(4, 103);
      this.label137.Name = "label137";
      this.label137.Size = new Size(98, 28);
      this.label137.TabIndex = 1;
      this.label137.Text = " Flamethrower \r\nSimulator";
      this.label137.TextAlign = ContentAlignment.MiddleCenter;
      this.label137.Click += new EventHandler(this.label137_Click);
      this.pictureBox135.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox135.Location = new Point(3, 3);
      this.pictureBox135.Name = "pictureBox135";
      this.pictureBox135.Size = new Size(100, 100);
      this.pictureBox135.TabIndex = 11;
      this.pictureBox135.TabStop = false;
      this.pictureBox135.Click += new EventHandler(this.pictureBox135_Click);
      this.panel135.Controls.Add((Control) this.label134);
      this.panel135.Controls.Add((Control) this.pictureBox132);
      this.panel135.Location = new Point(3, 16869);
      this.panel135.Name = "panel135";
      this.panel135.Size = new Size(105, 131);
      this.panel135.TabIndex = 79;
      this.label134.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label134.ForeColor = System.Drawing.Color.White;
      this.label134.Location = new Point(4, 103);
      this.label134.Name = "label134";
      this.label134.Size = new Size(98, 28);
      this.label134.TabIndex = 1;
      this.label134.Text = "Make a Cake";
      this.label134.TextAlign = ContentAlignment.MiddleCenter;
      this.label134.Click += new EventHandler(this.label134_Click);
      this.pictureBox132.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox132.Location = new Point(3, 3);
      this.pictureBox132.Name = "pictureBox132";
      this.pictureBox132.Size = new Size(100, 100);
      this.pictureBox132.TabIndex = 11;
      this.pictureBox132.TabStop = false;
      this.pictureBox132.Click += new EventHandler(this.pictureBox132_Click);
      this.panel139.Controls.Add((Control) this.label138);
      this.panel139.Controls.Add((Control) this.pictureBox136);
      this.panel139.Location = new Point(3, 17006);
      this.panel139.Name = "panel139";
      this.panel139.Size = new Size(105, 131);
      this.panel139.TabIndex = 80;
      this.label138.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label138.ForeColor = System.Drawing.Color.White;
      this.label138.Location = new Point(4, 103);
      this.label138.Name = "label138";
      this.label138.Size = new Size(98, 28);
      this.label138.TabIndex = 1;
      this.label138.Text = "Katana Simulator";
      this.label138.TextAlign = ContentAlignment.MiddleCenter;
      this.label138.Click += new EventHandler(this.label138_Click);
      this.pictureBox136.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox136.Location = new Point(3, 3);
      this.pictureBox136.Name = "pictureBox136";
      this.pictureBox136.Size = new Size(100, 100);
      this.pictureBox136.TabIndex = 11;
      this.pictureBox136.TabStop = false;
      this.pictureBox136.Click += new EventHandler(this.pictureBox136_Click);
      this.panel140.Controls.Add((Control) this.label139);
      this.panel140.Controls.Add((Control) this.pictureBox137);
      this.panel140.Location = new Point(3, 17143);
      this.panel140.Name = "panel140";
      this.panel140.Size = new Size(105, 131);
      this.panel140.TabIndex = 81;
      this.label139.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label139.ForeColor = System.Drawing.Color.White;
      this.label139.Location = new Point(4, 103);
      this.label139.Name = "label139";
      this.label139.Size = new Size(98, 28);
      this.label139.TabIndex = 1;
      this.label139.Text = "Stands Online";
      this.label139.TextAlign = ContentAlignment.MiddleCenter;
      this.label139.Click += new EventHandler(this.label139_Click);
      this.pictureBox137.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox137.Location = new Point(3, 3);
      this.pictureBox137.Name = "pictureBox137";
      this.pictureBox137.Size = new Size(100, 100);
      this.pictureBox137.TabIndex = 11;
      this.pictureBox137.TabStop = false;
      this.pictureBox137.Click += new EventHandler(this.pictureBox137_Click);
      this.panel141.Controls.Add((Control) this.label140);
      this.panel141.Controls.Add((Control) this.pictureBox138);
      this.panel141.Location = new Point(3, 17280);
      this.panel141.Name = "panel141";
      this.panel141.Size = new Size(105, 131);
      this.panel141.TabIndex = 82;
      this.label140.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label140.ForeColor = System.Drawing.Color.White;
      this.label140.Location = new Point(4, 103);
      this.label140.Name = "label140";
      this.label140.Size = new Size(98, 28);
      this.label140.TabIndex = 1;
      this.label140.Text = "Oretary";
      this.label140.TextAlign = ContentAlignment.MiddleCenter;
      this.label140.Click += new EventHandler(this.label140_Click);
      this.pictureBox138.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox138.Location = new Point(3, 3);
      this.pictureBox138.Name = "pictureBox138";
      this.pictureBox138.Size = new Size(100, 100);
      this.pictureBox138.TabIndex = 11;
      this.pictureBox138.TabStop = false;
      this.pictureBox138.Click += new EventHandler(this.pictureBox138_Click);
      this.panel142.Controls.Add((Control) this.label141);
      this.panel142.Controls.Add((Control) this.pictureBox139);
      this.panel142.Location = new Point(3, 17417);
      this.panel142.Name = "panel142";
      this.panel142.Size = new Size(105, 131);
      this.panel142.TabIndex = 83;
      this.label141.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label141.ForeColor = System.Drawing.Color.White;
      this.label141.Location = new Point(4, 103);
      this.label141.Name = "label141";
      this.label141.Size = new Size(98, 28);
      this.label141.TabIndex = 1;
      this.label141.Text = "Piggy";
      this.label141.TextAlign = ContentAlignment.MiddleCenter;
      this.label141.Click += new EventHandler(this.label141_Click);
      this.pictureBox139.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox139.Location = new Point(3, 3);
      this.pictureBox139.Name = "pictureBox139";
      this.pictureBox139.Size = new Size(100, 100);
      this.pictureBox139.TabIndex = 11;
      this.pictureBox139.TabStop = false;
      this.pictureBox139.Click += new EventHandler(this.pictureBox139_Click);
      this.panel143.Controls.Add((Control) this.label142);
      this.panel143.Controls.Add((Control) this.pictureBox140);
      this.panel143.Location = new Point(3, 17554);
      this.panel143.Name = "panel143";
      this.panel143.Size = new Size(105, 131);
      this.panel143.TabIndex = 84;
      this.label142.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label142.ForeColor = System.Drawing.Color.White;
      this.label142.Location = new Point(4, 103);
      this.label142.Name = "label142";
      this.label142.Size = new Size(98, 28);
      this.label142.TabIndex = 1;
      this.label142.Text = "Super Doomspire";
      this.label142.TextAlign = ContentAlignment.MiddleCenter;
      this.label142.Click += new EventHandler(this.label142_Click);
      this.pictureBox140.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox140.Location = new Point(3, 3);
      this.pictureBox140.Name = "pictureBox140";
      this.pictureBox140.Size = new Size(100, 100);
      this.pictureBox140.TabIndex = 11;
      this.pictureBox140.TabStop = false;
      this.pictureBox140.Click += new EventHandler(this.pictureBox140_Click);
      this.panel144.Controls.Add((Control) this.label143);
      this.panel144.Controls.Add((Control) this.pictureBox141);
      this.panel144.Location = new Point(3, 17691);
      this.panel144.Name = "panel144";
      this.panel144.Size = new Size(105, 131);
      this.panel144.TabIndex = 84;
      this.label143.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label143.ForeColor = System.Drawing.Color.White;
      this.label143.Location = new Point(4, 103);
      this.label143.Name = "label143";
      this.label143.Size = new Size(98, 28);
      this.label143.TabIndex = 1;
      this.label143.Text = "RoVille";
      this.label143.TextAlign = ContentAlignment.MiddleCenter;
      this.label143.Click += new EventHandler(this.label143_Click);
      this.pictureBox141.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox141.Location = new Point(3, 3);
      this.pictureBox141.Name = "pictureBox141";
      this.pictureBox141.Size = new Size(100, 100);
      this.pictureBox141.TabIndex = 11;
      this.pictureBox141.TabStop = false;
      this.pictureBox141.Click += new EventHandler(this.pictureBox141_Click);
      this.panel47.Controls.Add((Control) this.label48);
      this.panel47.Controls.Add((Control) this.pictureBox44);
      this.panel47.Location = new Point(3, 17828);
      this.panel47.Name = "panel47";
      this.panel47.Size = new Size(105, 125);
      this.panel47.TabIndex = 43;
      this.label48.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label48.ForeColor = System.Drawing.Color.White;
      this.label48.Location = new Point(4, 106);
      this.label48.Name = "label48";
      this.label48.Size = new Size(98, 19);
      this.label48.TabIndex = 1;
      this.label48.Text = "Jailbreak";
      this.label48.TextAlign = ContentAlignment.MiddleCenter;
      this.label48.Click += new EventHandler(this.label48_Click);
      this.pictureBox44.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox44.Location = new Point(3, 3);
      this.pictureBox44.Name = "pictureBox44";
      this.pictureBox44.Size = new Size(100, 100);
      this.pictureBox44.TabIndex = 11;
      this.pictureBox44.TabStop = false;
      this.pictureBox44.Click += new EventHandler(this.pictureBox44_Click);
      this.panel145.Controls.Add((Control) this.label144);
      this.panel145.Controls.Add((Control) this.pictureBox142);
      this.panel145.Location = new Point(3, 17959);
      this.panel145.Name = "panel145";
      this.panel145.Size = new Size(105, 131);
      this.panel145.TabIndex = 84;
      this.label144.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label144.ForeColor = System.Drawing.Color.White;
      this.label144.Location = new Point(4, 103);
      this.label144.Name = "label144";
      this.label144.Size = new Size(98, 28);
      this.label144.TabIndex = 1;
      this.label144.Text = "Ro-Slayers";
      this.label144.TextAlign = ContentAlignment.MiddleCenter;
      this.label144.Click += new EventHandler(this.label144_Click);
      this.pictureBox142.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox142.Location = new Point(3, 3);
      this.pictureBox142.Name = "pictureBox142";
      this.pictureBox142.Size = new Size(100, 100);
      this.pictureBox142.TabIndex = 11;
      this.pictureBox142.TabStop = false;
      this.pictureBox142.Click += new EventHandler(this.pictureBox142_Click);
      this.panel146.Controls.Add((Control) this.label145);
      this.panel146.Controls.Add((Control) this.pictureBox143);
      this.panel146.Location = new Point(3, 18096);
      this.panel146.Name = "panel146";
      this.panel146.Size = new Size(105, 131);
      this.panel146.TabIndex = 85;
      this.label145.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label145.ForeColor = System.Drawing.Color.White;
      this.label145.Location = new Point(4, 103);
      this.label145.Name = "label145";
      this.label145.Size = new Size(98, 28);
      this.label145.TabIndex = 1;
      this.label145.Text = "Blox Hunt";
      this.label145.TextAlign = ContentAlignment.MiddleCenter;
      this.label145.Click += new EventHandler(this.label145_Click);
      this.pictureBox143.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox143.Location = new Point(3, 3);
      this.pictureBox143.Name = "pictureBox143";
      this.pictureBox143.Size = new Size(100, 100);
      this.pictureBox143.TabIndex = 11;
      this.pictureBox143.TabStop = false;
      this.pictureBox143.Click += new EventHandler(this.pictureBox143_Click);
      this.panel110.Controls.Add((Control) this.label109);
      this.panel110.Controls.Add((Control) this.pictureBox107);
      this.panel110.Location = new Point(3, 18233);
      this.panel110.Name = "panel110";
      this.panel110.Size = new Size(105, 131);
      this.panel110.TabIndex = 86;
      this.label109.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label109.ForeColor = System.Drawing.Color.White;
      this.label109.Location = new Point(4, 103);
      this.label109.Name = "label109";
      this.label109.Size = new Size(98, 28);
      this.label109.TabIndex = 1;
      this.label109.Text = "Kick Off";
      this.label109.TextAlign = ContentAlignment.MiddleCenter;
      this.label109.Click += new EventHandler(this.label109_Click_1);
      this.pictureBox107.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox107.Location = new Point(3, 3);
      this.pictureBox107.Name = "pictureBox107";
      this.pictureBox107.Size = new Size(100, 100);
      this.pictureBox107.TabIndex = 11;
      this.pictureBox107.TabStop = false;
      this.pictureBox107.Click += new EventHandler(this.pictureBox107_Click_1);
      this.panel147.Controls.Add((Control) this.label146);
      this.panel147.Controls.Add((Control) this.pictureBox144);
      this.panel147.Location = new Point(3, 18370);
      this.panel147.Name = "panel147";
      this.panel147.Size = new Size(105, 131);
      this.panel147.TabIndex = 87;
      this.label146.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label146.ForeColor = System.Drawing.Color.White;
      this.label146.Location = new Point(4, 103);
      this.label146.Name = "label146";
      this.label146.Size = new Size(98, 28);
      this.label146.TabIndex = 1;
      this.label146.Text = "Liftoff ";
      this.label146.TextAlign = ContentAlignment.MiddleCenter;
      this.label146.Click += new EventHandler(this.label146_Click);
      this.pictureBox144.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox144.Location = new Point(3, 3);
      this.pictureBox144.Name = "pictureBox144";
      this.pictureBox144.Size = new Size(100, 100);
      this.pictureBox144.TabIndex = 11;
      this.pictureBox144.TabStop = false;
      this.pictureBox144.Click += new EventHandler(this.pictureBox144_Click);
      this.panel148.Controls.Add((Control) this.label147);
      this.panel148.Controls.Add((Control) this.pictureBox145);
      this.panel148.Location = new Point(3, 18507);
      this.panel148.Name = "panel148";
      this.panel148.Size = new Size(105, 131);
      this.panel148.TabIndex = 88;
      this.label147.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label147.ForeColor = System.Drawing.Color.White;
      this.label147.Location = new Point(4, 103);
      this.label147.Name = "label147";
      this.label147.Size = new Size(98, 28);
      this.label147.TabIndex = 1;
      this.label147.Text = "Mining Simulator";
      this.label147.TextAlign = ContentAlignment.MiddleCenter;
      this.label147.Click += new EventHandler(this.label147_Click);
      this.pictureBox145.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox145.Location = new Point(3, 3);
      this.pictureBox145.Name = "pictureBox145";
      this.pictureBox145.Size = new Size(100, 100);
      this.pictureBox145.TabIndex = 11;
      this.pictureBox145.TabStop = false;
      this.pictureBox145.Click += new EventHandler(this.pictureBox145_Click);
      this.panel149.Controls.Add((Control) this.label148);
      this.panel149.Controls.Add((Control) this.pictureBox146);
      this.panel149.Location = new Point(3, 18644);
      this.panel149.Name = "panel149";
      this.panel149.Size = new Size(105, 131);
      this.panel149.TabIndex = 89;
      this.label148.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label148.ForeColor = System.Drawing.Color.White;
      this.label148.Location = new Point(4, 103);
      this.label148.Name = "label148";
      this.label148.Size = new Size(98, 28);
      this.label148.TabIndex = 1;
      this.label148.Text = "Batting Champions";
      this.label148.TextAlign = ContentAlignment.MiddleCenter;
      this.label148.Click += new EventHandler(this.label148_Click);
      this.pictureBox146.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox146.Location = new Point(3, 3);
      this.pictureBox146.Name = "pictureBox146";
      this.pictureBox146.Size = new Size(100, 100);
      this.pictureBox146.TabIndex = 11;
      this.pictureBox146.TabStop = false;
      this.pictureBox146.Click += new EventHandler(this.pictureBox146_Click);
      this.panel150.Controls.Add((Control) this.label149);
      this.panel150.Controls.Add((Control) this.pictureBox147);
      this.panel150.Location = new Point(3, 18781);
      this.panel150.Name = "panel150";
      this.panel150.Size = new Size(105, 131);
      this.panel150.TabIndex = 90;
      this.label149.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label149.ForeColor = System.Drawing.Color.White;
      this.label149.Location = new Point(4, 103);
      this.label149.Name = "label149";
      this.label149.Size = new Size(98, 28);
      this.label149.TabIndex = 1;
      this.label149.Text = "Sizzling Simulator";
      this.label149.TextAlign = ContentAlignment.MiddleCenter;
      this.label149.Click += new EventHandler(this.label149_Click);
      this.pictureBox147.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox147.Location = new Point(3, 3);
      this.pictureBox147.Name = "pictureBox147";
      this.pictureBox147.Size = new Size(100, 100);
      this.pictureBox147.TabIndex = 11;
      this.pictureBox147.TabStop = false;
      this.pictureBox147.Click += new EventHandler(this.pictureBox147_Click);
      this.panel151.Controls.Add((Control) this.label150);
      this.panel151.Controls.Add((Control) this.pictureBox148);
      this.panel151.Location = new Point(3, 18918);
      this.panel151.Name = "panel151";
      this.panel151.Size = new Size(105, 131);
      this.panel151.TabIndex = 91;
      this.label150.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label150.ForeColor = System.Drawing.Color.White;
      this.label150.Location = new Point(4, 103);
      this.label150.Name = "label150";
      this.label150.Size = new Size(98, 28);
      this.label150.TabIndex = 1;
      this.label150.Text = "Soda Simulator";
      this.label150.TextAlign = ContentAlignment.MiddleCenter;
      this.label150.Click += new EventHandler(this.label150_Click);
      this.pictureBox148.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox148.Location = new Point(3, 3);
      this.pictureBox148.Name = "pictureBox148";
      this.pictureBox148.Size = new Size(100, 100);
      this.pictureBox148.TabIndex = 11;
      this.pictureBox148.TabStop = false;
      this.pictureBox148.Click += new EventHandler(this.pictureBox148_Click);
      this.panel152.Controls.Add((Control) this.label151);
      this.panel152.Controls.Add((Control) this.pictureBox149);
      this.panel152.Location = new Point(3, 19055);
      this.panel152.Name = "panel152";
      this.panel152.Size = new Size(105, 131);
      this.panel152.TabIndex = 92;
      this.label151.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label151.ForeColor = System.Drawing.Color.White;
      this.label151.Location = new Point(4, 103);
      this.label151.Name = "label151";
      this.label151.Size = new Size(98, 28);
      this.label151.TabIndex = 1;
      this.label151.Text = "YouTube Tycoon";
      this.label151.TextAlign = ContentAlignment.MiddleCenter;
      this.label151.Click += new EventHandler(this.label151_Click);
      this.pictureBox149.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox149.Location = new Point(3, 3);
      this.pictureBox149.Name = "pictureBox149";
      this.pictureBox149.Size = new Size(100, 100);
      this.pictureBox149.TabIndex = 11;
      this.pictureBox149.TabStop = false;
      this.pictureBox149.Click += new EventHandler(this.pictureBox149_Click);
      this.panel153.Controls.Add((Control) this.label152);
      this.panel153.Controls.Add((Control) this.pictureBox150);
      this.panel153.Location = new Point(3, 19192);
      this.panel153.Name = "panel153";
      this.panel153.Size = new Size(105, 131);
      this.panel153.TabIndex = 93;
      this.label152.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label152.ForeColor = System.Drawing.Color.White;
      this.label152.Location = new Point(4, 103);
      this.label152.Name = "label152";
      this.label152.Size = new Size(98, 28);
      this.label152.TabIndex = 1;
      this.label152.Text = "Ninja Tycoon";
      this.label152.TextAlign = ContentAlignment.MiddleCenter;
      this.label152.Click += new EventHandler(this.label152_Click);
      this.pictureBox150.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox150.Location = new Point(3, 3);
      this.pictureBox150.Name = "pictureBox150";
      this.pictureBox150.Size = new Size(100, 100);
      this.pictureBox150.TabIndex = 11;
      this.pictureBox150.TabStop = false;
      this.pictureBox150.Click += new EventHandler(this.pictureBox150_Click);
      this.panel134.Controls.Add((Control) this.label133);
      this.panel134.Controls.Add((Control) this.pictureBox131);
      this.panel134.Location = new Point(3, 19329);
      this.panel134.Name = "panel134";
      this.panel134.Size = new Size(105, 131);
      this.panel134.TabIndex = 75;
      this.label133.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label133.ForeColor = System.Drawing.Color.White;
      this.label133.Location = new Point(4, 103);
      this.label133.Name = "label133";
      this.label133.Size = new Size(98, 28);
      this.label133.TabIndex = 1;
      this.label133.Text = "Blade Throwing \r\nSimulator";
      this.label133.TextAlign = ContentAlignment.MiddleCenter;
      this.label133.Click += new EventHandler(this.label133_Click);
      this.pictureBox131.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox131.Location = new Point(3, 3);
      this.pictureBox131.Name = "pictureBox131";
      this.pictureBox131.Size = new Size(100, 100);
      this.pictureBox131.TabIndex = 11;
      this.pictureBox131.TabStop = false;
      this.pictureBox131.Click += new EventHandler(this.pictureBox131_Click);
      this.panel45.Controls.Add((Control) this.label46);
      this.panel45.Controls.Add((Control) this.pictureBox42);
      this.panel45.Location = new Point(3, 19466);
      this.panel45.Name = "panel45";
      this.panel45.Size = new Size(105, 125);
      this.panel45.TabIndex = 41;
      this.label46.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label46.ForeColor = System.Drawing.Color.White;
      this.label46.Location = new Point(4, 106);
      this.label46.Name = "label46";
      this.label46.Size = new Size(98, 19);
      this.label46.TabIndex = 1;
      this.label46.Text = "Saber Simulator";
      this.label46.TextAlign = ContentAlignment.MiddleCenter;
      this.label46.Click += new EventHandler(this.label46_Click);
      this.pictureBox42.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox42.Location = new Point(3, 3);
      this.pictureBox42.Name = "pictureBox42";
      this.pictureBox42.Size = new Size(100, 100);
      this.pictureBox42.TabIndex = 11;
      this.pictureBox42.TabStop = false;
      this.pictureBox42.Click += new EventHandler(this.pictureBox42_Click);
      this.panel154.Controls.Add((Control) this.label153);
      this.panel154.Controls.Add((Control) this.pictureBox151);
      this.panel154.Location = new Point(3, 19597);
      this.panel154.Name = "panel154";
      this.panel154.Size = new Size(105, 131);
      this.panel154.TabIndex = 76;
      this.label153.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label153.ForeColor = System.Drawing.Color.White;
      this.label153.Location = new Point(4, 103);
      this.label153.Name = "label153";
      this.label153.Size = new Size(98, 28);
      this.label153.TabIndex = 1;
      this.label153.Text = "Champion Simulator";
      this.label153.TextAlign = ContentAlignment.MiddleCenter;
      this.label153.Click += new EventHandler(this.label153_Click);
      this.pictureBox151.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox151.Location = new Point(3, 3);
      this.pictureBox151.Name = "pictureBox151";
      this.pictureBox151.Size = new Size(100, 100);
      this.pictureBox151.TabIndex = 11;
      this.pictureBox151.TabStop = false;
      this.pictureBox151.Click += new EventHandler(this.pictureBox151_Click);
      this.panel155.Controls.Add((Control) this.label154);
      this.panel155.Controls.Add((Control) this.pictureBox152);
      this.panel155.Location = new Point(3, 19734);
      this.panel155.Name = "panel155";
      this.panel155.Size = new Size(105, 131);
      this.panel155.TabIndex = 77;
      this.label154.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label154.ForeColor = System.Drawing.Color.White;
      this.label154.Location = new Point(4, 103);
      this.label154.Name = "label154";
      this.label154.Size = new Size(98, 28);
      this.label154.TabIndex = 1;
      this.label154.Text = "Pickaxe Simulator";
      this.label154.TextAlign = ContentAlignment.MiddleCenter;
      this.label154.Click += new EventHandler(this.label154_Click);
      this.pictureBox152.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox152.Location = new Point(3, 3);
      this.pictureBox152.Name = "pictureBox152";
      this.pictureBox152.Size = new Size(100, 100);
      this.pictureBox152.TabIndex = 11;
      this.pictureBox152.TabStop = false;
      this.pictureBox152.Click += new EventHandler(this.pictureBox152_Click);
      this.panel156.Controls.Add((Control) this.label155);
      this.panel156.Controls.Add((Control) this.pictureBox153);
      this.panel156.Location = new Point(3, 19871);
      this.panel156.Name = "panel156";
      this.panel156.Size = new Size(105, 131);
      this.panel156.TabIndex = 78;
      this.label155.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label155.ForeColor = System.Drawing.Color.White;
      this.label155.Location = new Point(4, 103);
      this.label155.Name = "label155";
      this.label155.Size = new Size(98, 28);
      this.label155.TabIndex = 1;
      this.label155.Text = "Eg!";
      this.label155.TextAlign = ContentAlignment.MiddleCenter;
      this.label155.Click += new EventHandler(this.label155_Click);
      this.pictureBox153.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox153.Location = new Point(3, 3);
      this.pictureBox153.Name = "pictureBox153";
      this.pictureBox153.Size = new Size(100, 100);
      this.pictureBox153.TabIndex = 11;
      this.pictureBox153.TabStop = false;
      this.pictureBox153.Click += new EventHandler(this.pictureBox153_Click);
      this.panel157.Controls.Add((Control) this.label156);
      this.panel157.Controls.Add((Control) this.pictureBox154);
      this.panel157.Location = new Point(3, 20008);
      this.panel157.Name = "panel157";
      this.panel157.Size = new Size(105, 131);
      this.panel157.TabIndex = 79;
      this.label156.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label156.ForeColor = System.Drawing.Color.White;
      this.label156.Location = new Point(4, 103);
      this.label156.Name = "label156";
      this.label156.Size = new Size(98, 28);
      this.label156.TabIndex = 1;
      this.label156.Text = "Heroes Online";
      this.label156.TextAlign = ContentAlignment.MiddleCenter;
      this.label156.Click += new EventHandler(this.label156_Click);
      this.pictureBox154.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox154.Location = new Point(3, 3);
      this.pictureBox154.Name = "pictureBox154";
      this.pictureBox154.Size = new Size(100, 100);
      this.pictureBox154.TabIndex = 11;
      this.pictureBox154.TabStop = false;
      this.pictureBox154.Click += new EventHandler(this.pictureBox154_Click);
      this.panel61.Controls.Add((Control) this.label62);
      this.panel61.Controls.Add((Control) this.pictureBox58);
      this.panel61.Location = new Point(3, 20145);
      this.panel61.Name = "panel61";
      this.panel61.Size = new Size(105, 131);
      this.panel61.TabIndex = 80;
      this.label62.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label62.ForeColor = System.Drawing.Color.White;
      this.label62.Location = new Point(4, 103);
      this.label62.Name = "label62";
      this.label62.Size = new Size(98, 28);
      this.label62.TabIndex = 1;
      this.label62.Text = "Blox Fruits";
      this.label62.TextAlign = ContentAlignment.MiddleCenter;
      this.label62.Click += new EventHandler(this.label62_Click_1);
      this.pictureBox58.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox58.Location = new Point(3, 3);
      this.pictureBox58.Name = "pictureBox58";
      this.pictureBox58.Size = new Size(100, 100);
      this.pictureBox58.TabIndex = 11;
      this.pictureBox58.TabStop = false;
      this.pictureBox58.Click += new EventHandler(this.pictureBox58_Click_1);
      this.panel52.Controls.Add((Control) this.label53);
      this.panel52.Controls.Add((Control) this.pictureBox49);
      this.panel52.Location = new Point(3, 20282);
      this.panel52.Name = "panel52";
      this.panel52.Size = new Size(105, 125);
      this.panel52.TabIndex = 47;
      this.label53.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label53.ForeColor = System.Drawing.Color.White;
      this.label53.Location = new Point(4, 106);
      this.label53.Name = "label53";
      this.label53.Size = new Size(98, 19);
      this.label53.TabIndex = 1;
      this.label53.Text = "Tree Planting Sim";
      this.label53.TextAlign = ContentAlignment.MiddleCenter;
      this.label53.Click += new EventHandler(this.label53_Click);
      this.pictureBox49.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox49.Location = new Point(3, 3);
      this.pictureBox49.Name = "pictureBox49";
      this.pictureBox49.Size = new Size(100, 100);
      this.pictureBox49.TabIndex = 11;
      this.pictureBox49.TabStop = false;
      this.pictureBox49.Click += new EventHandler(this.pictureBox49_Click);
      this.panel158.Controls.Add((Control) this.label157);
      this.panel158.Controls.Add((Control) this.pictureBox155);
      this.panel158.Location = new Point(3, 20413);
      this.panel158.Name = "panel158";
      this.panel158.Size = new Size(105, 131);
      this.panel158.TabIndex = 81;
      this.label157.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label157.ForeColor = System.Drawing.Color.White;
      this.label157.Location = new Point(4, 103);
      this.label157.Name = "label157";
      this.label157.Size = new Size(98, 28);
      this.label157.TabIndex = 1;
      this.label157.Text = "Miner's Haven\r\nReincarnation";
      this.label157.TextAlign = ContentAlignment.MiddleCenter;
      this.label157.Click += new EventHandler(this.label157_Click);
      this.pictureBox155.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox155.Location = new Point(3, 3);
      this.pictureBox155.Name = "pictureBox155";
      this.pictureBox155.Size = new Size(100, 100);
      this.pictureBox155.TabIndex = 11;
      this.pictureBox155.TabStop = false;
      this.pictureBox155.Click += new EventHandler(this.pictureBox155_Click);
      this.panel159.Controls.Add((Control) this.label158);
      this.panel159.Controls.Add((Control) this.pictureBox156);
      this.panel159.Location = new Point(3, 20550);
      this.panel159.Name = "panel159";
      this.panel159.Size = new Size(105, 131);
      this.panel159.TabIndex = 81;
      this.label158.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label158.ForeColor = System.Drawing.Color.White;
      this.label158.Location = new Point(4, 103);
      this.label158.Name = "label158";
      this.label158.Size = new Size(98, 28);
      this.label158.TabIndex = 1;
      this.label158.Text = "Natural Disaster\r\n Survival";
      this.label158.TextAlign = ContentAlignment.MiddleCenter;
      this.label158.Click += new EventHandler(this.label158_Click);
      this.pictureBox156.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox156.Location = new Point(3, 3);
      this.pictureBox156.Name = "pictureBox156";
      this.pictureBox156.Size = new Size(100, 100);
      this.pictureBox156.TabIndex = 11;
      this.pictureBox156.TabStop = false;
      this.pictureBox156.Click += new EventHandler(this.pictureBox156_Click);
      this.panel160.Controls.Add((Control) this.label159);
      this.panel160.Controls.Add((Control) this.pictureBox157);
      this.panel160.Location = new Point(3, 20687);
      this.panel160.Name = "panel160";
      this.panel160.Size = new Size(105, 131);
      this.panel160.TabIndex = 82;
      this.label159.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label159.ForeColor = System.Drawing.Color.White;
      this.label159.Location = new Point(4, 103);
      this.label159.Name = "label159";
      this.label159.Size = new Size(98, 28);
      this.label159.TabIndex = 1;
      this.label159.Text = "Reaper Simulator 2";
      this.label159.TextAlign = ContentAlignment.MiddleCenter;
      this.label159.Click += new EventHandler(this.label159_Click);
      this.pictureBox157.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox157.Location = new Point(3, 3);
      this.pictureBox157.Name = "pictureBox157";
      this.pictureBox157.Size = new Size(100, 100);
      this.pictureBox157.TabIndex = 11;
      this.pictureBox157.TabStop = false;
      this.pictureBox157.Click += new EventHandler(this.pictureBox157_Click);
      this.panel161.Controls.Add((Control) this.label160);
      this.panel161.Controls.Add((Control) this.pictureBox158);
      this.panel161.Location = new Point(3, 20824);
      this.panel161.Name = "panel161";
      this.panel161.Size = new Size(105, 131);
      this.panel161.TabIndex = 83;
      this.label160.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label160.ForeColor = System.Drawing.Color.White;
      this.label160.Location = new Point(4, 103);
      this.label160.Name = "label160";
      this.label160.Size = new Size(98, 28);
      this.label160.TabIndex = 1;
      this.label160.Text = "Ripull minigames";
      this.label160.TextAlign = ContentAlignment.MiddleCenter;
      this.label160.Click += new EventHandler(this.label160_Click);
      this.pictureBox158.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox158.Location = new Point(3, 3);
      this.pictureBox158.Name = "pictureBox158";
      this.pictureBox158.Size = new Size(100, 100);
      this.pictureBox158.TabIndex = 11;
      this.pictureBox158.TabStop = false;
      this.pictureBox158.Click += new EventHandler(this.pictureBox158_Click);
      this.panel162.Controls.Add((Control) this.label161);
      this.panel162.Controls.Add((Control) this.pictureBox159);
      this.panel162.Location = new Point(3, 20961);
      this.panel162.Name = "panel162";
      this.panel162.Size = new Size(105, 131);
      this.panel162.TabIndex = 84;
      this.label161.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label161.ForeColor = System.Drawing.Color.White;
      this.label161.Location = new Point(4, 103);
      this.label161.Name = "label161";
      this.label161.Size = new Size(98, 28);
      this.label161.TabIndex = 1;
      this.label161.Text = "Dancing Simulator";
      this.label161.TextAlign = ContentAlignment.MiddleCenter;
      this.label161.Click += new EventHandler(this.label161_Click);
      this.pictureBox159.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox159.Location = new Point(3, 3);
      this.pictureBox159.Name = "pictureBox159";
      this.pictureBox159.Size = new Size(100, 100);
      this.pictureBox159.TabIndex = 11;
      this.pictureBox159.TabStop = false;
      this.pictureBox159.Click += new EventHandler(this.pictureBox159_Click);
      this.panel163.Controls.Add((Control) this.label162);
      this.panel163.Controls.Add((Control) this.pictureBox160);
      this.panel163.Location = new Point(3, 21098);
      this.panel163.Name = "panel163";
      this.panel163.Size = new Size(105, 131);
      this.panel163.TabIndex = 85;
      this.label162.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label162.ForeColor = System.Drawing.Color.White;
      this.label162.Location = new Point(4, 103);
      this.label162.Name = "label162";
      this.label162.Size = new Size(98, 28);
      this.label162.TabIndex = 1;
      this.label162.Text = "Zombie Attack";
      this.label162.TextAlign = ContentAlignment.MiddleCenter;
      this.label162.Click += new EventHandler(this.label162_Click);
      this.pictureBox160.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox160.Location = new Point(3, 3);
      this.pictureBox160.Name = "pictureBox160";
      this.pictureBox160.Size = new Size(100, 100);
      this.pictureBox160.TabIndex = 11;
      this.pictureBox160.TabStop = false;
      this.pictureBox160.Click += new EventHandler(this.pictureBox160_Click);
      this.panel164.Controls.Add((Control) this.label163);
      this.panel164.Controls.Add((Control) this.pictureBox161);
      this.panel164.Location = new Point(3, 21235);
      this.panel164.Name = "panel164";
      this.panel164.Size = new Size(105, 131);
      this.panel164.TabIndex = 86;
      this.label163.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label163.ForeColor = System.Drawing.Color.White;
      this.label163.Location = new Point(4, 103);
      this.label163.Name = "label163";
      this.label163.Size = new Size(98, 28);
      this.label163.TabIndex = 1;
      this.label163.Text = "The Wild West";
      this.label163.TextAlign = ContentAlignment.MiddleCenter;
      this.label163.Click += new EventHandler(this.label163_Click);
      this.pictureBox161.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox161.Location = new Point(3, 3);
      this.pictureBox161.Name = "pictureBox161";
      this.pictureBox161.Size = new Size(100, 100);
      this.pictureBox161.TabIndex = 11;
      this.pictureBox161.TabStop = false;
      this.pictureBox161.Click += new EventHandler(this.pictureBox161_Click);
      this.panel165.Controls.Add((Control) this.label164);
      this.panel165.Controls.Add((Control) this.pictureBox162);
      this.panel165.Location = new Point(3, 21372);
      this.panel165.Name = "panel165";
      this.panel165.Size = new Size(105, 131);
      this.panel165.TabIndex = 87;
      this.label164.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label164.ForeColor = System.Drawing.Color.White;
      this.label164.Location = new Point(4, 103);
      this.label164.Name = "label164";
      this.label164.Size = new Size(98, 28);
      this.label164.TabIndex = 1;
      this.label164.Text = "Donut Bakery Tycoon";
      this.label164.TextAlign = ContentAlignment.MiddleCenter;
      this.label164.Click += new EventHandler(this.label164_Click);
      this.pictureBox162.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox162.Location = new Point(3, 3);
      this.pictureBox162.Name = "pictureBox162";
      this.pictureBox162.Size = new Size(100, 100);
      this.pictureBox162.TabIndex = 11;
      this.pictureBox162.TabStop = false;
      this.pictureBox162.Click += new EventHandler(this.pictureBox162_Click);
      this.panel166.Controls.Add((Control) this.label165);
      this.panel166.Controls.Add((Control) this.pictureBox163);
      this.panel166.Location = new Point(3, 21509);
      this.panel166.Name = "panel166";
      this.panel166.Size = new Size(105, 131);
      this.panel166.TabIndex = 88;
      this.label165.Font = new Font("Segoe UI Semilight", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label165.ForeColor = System.Drawing.Color.White;
      this.label165.Location = new Point(4, 103);
      this.label165.Name = "label165";
      this.label165.Size = new Size(98, 28);
      this.label165.TabIndex = 1;
      this.label165.Text = "Lifting Legends";
      this.label165.TextAlign = ContentAlignment.MiddleCenter;
      this.label165.Click += new EventHandler(this.label165_Click);
      this.pictureBox163.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox163.Location = new Point(3, 3);
      this.pictureBox163.Name = "pictureBox163";
      this.pictureBox163.Size = new Size(100, 100);
      this.pictureBox163.TabIndex = 11;
      this.pictureBox163.TabStop = false;
      this.pictureBox163.Click += new EventHandler(this.pictureBox163_Click);
      this.execPage.BackColor = System.Drawing.Color.Black;
      this.execPage.Controls.Add((Control) this.listBox1);
      this.execPage.Controls.Add((Control) this.button8);
      this.execPage.Controls.Add((Control) this.button6);
      this.execPage.Controls.Add((Control) this.button3);
      this.execPage.Controls.Add((Control) this.button4);
      this.execPage.Controls.Add((Control) this.button1);
      this.execPage.Controls.Add((Control) this.webBrowser1);
      this.execPage.Controls.Add((Control) this.button2);
      this.execPage.Location = new Point(4, 5);
      this.execPage.Name = "execPage";
      this.execPage.Padding = new Padding(3);
      this.execPage.Size = new Size(564, 282);
      this.execPage.TabIndex = 0;
      this.execPage.Text = "tabPage1";
      this.execPage.Click += new EventHandler(this.execPage_Click);
      this.listBox1.BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
      this.listBox1.BorderStyle = BorderStyle.None;
      this.listBox1.Font = new Font("Roboto", 9f);
      this.listBox1.ForeColor = System.Drawing.Color.White;
      this.listBox1.FormattingEnabled = true;
      this.listBox1.ItemHeight = 14;
      this.listBox1.Items.AddRange(new object[1]
      {
        (object) "Script List"
      });
      this.listBox1.Location = new Point(428, 6);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new Size(130, 238);
      this.listBox1.TabIndex = 10;
      this.listBox1.SelectedIndexChanged += new EventHandler(this.listBox1_SelectedIndexChanged);
      this.listBox1.DoubleClick += new EventHandler(this.listBox1_DoubleClick);
      this.listBox1.MouseUp += new MouseEventHandler(this.listBox1_MouseUp);
      this.button8.BackColor = System.Drawing.Color.Black;
      this.button8.FlatAppearance.BorderSize = 0;
      this.button8.FlatStyle = FlatStyle.Flat;
      this.button8.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.button8.ForeColor = System.Drawing.Color.White;
      this.button8.Location = new Point(428, 250);
      this.button8.Name = "button8";
      this.button8.Size = new Size(130, 26);
      this.button8.TabIndex = 8;
      this.button8.Text = "Refresh Script List";
      this.button8.UseVisualStyleBackColor = false;
      this.button8.Click += new EventHandler(this.button8_Click_1);
      this.button6.BackColor = System.Drawing.Color.Black;
      this.button6.FlatAppearance.BorderSize = 0;
      this.button6.FlatStyle = FlatStyle.Flat;
      this.button6.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.button6.ForeColor = System.Drawing.Color.White;
      this.button6.Location = new Point(335, 250);
      this.button6.Name = "button6";
      this.button6.Size = new Size(90, 26);
      this.button6.TabIndex = 7;
      this.button6.Text = "Game Hub";
      this.button6.UseVisualStyleBackColor = false;
      this.button6.Click += new EventHandler(this.Button6_Click);
      this.button3.BackColor = System.Drawing.Color.Black;
      this.button3.FlatAppearance.BorderSize = 0;
      this.button3.FlatStyle = FlatStyle.Flat;
      this.button3.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.button3.ForeColor = System.Drawing.Color.White;
      this.button3.Location = new Point(244, 250);
      this.button3.Name = "button3";
      this.button3.Size = new Size(76, 26);
      this.button3.TabIndex = 5;
      this.button3.Text = "Save File";
      this.button3.UseVisualStyleBackColor = false;
      this.button3.Click += new EventHandler(this.Button3_Click);
      this.button4.BackColor = System.Drawing.Color.Black;
      this.button4.FlatAppearance.BorderSize = 0;
      this.button4.FlatStyle = FlatStyle.Flat;
      this.button4.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.button4.ForeColor = System.Drawing.Color.White;
      this.button4.Location = new Point(89, 250);
      this.button4.Name = "button4";
      this.button4.Size = new Size(88, 26);
      this.button4.TabIndex = 4;
      this.button4.Text = "Open File";
      this.button4.UseVisualStyleBackColor = false;
      this.button4.Click += new EventHandler(this.Button4_Click);
      this.button1.BackColor = System.Drawing.Color.Black;
      this.button1.FlatAppearance.BorderSize = 0;
      this.button1.FlatStyle = FlatStyle.Flat;
      this.button1.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.button1.ForeColor = System.Drawing.Color.White;
      this.button1.Location = new Point(183, 250);
      this.button1.Name = "button1";
      this.button1.Size = new Size(55, 26);
      this.button1.TabIndex = 3;
      this.button1.Text = "Clear";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new EventHandler(this.Button1_Click);
      this.webBrowser1.AllowWebBrowserDrop = false;
      this.webBrowser1.Location = new Point(6, 6);
      this.webBrowser1.MinimumSize = new Size(20, 20);
      this.webBrowser1.Name = "webBrowser1";
      this.webBrowser1.ScriptErrorsSuppressed = true;
      this.webBrowser1.Size = new Size(416, 238);
      this.webBrowser1.TabIndex = 2;
      this.webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(this.Monaco_DocumentCompleted);
      this.button2.BackColor = System.Drawing.Color.Black;
      this.button2.FlatAppearance.BorderSize = 0;
      this.button2.FlatStyle = FlatStyle.Flat;
      this.button2.Font = new Font("Roboto", 8f, FontStyle.Bold);
      this.button2.ForeColor = System.Drawing.Color.White;
      this.button2.Location = new Point(6, 250);
      this.button2.Name = "button2";
      this.button2.Size = new Size(77, 26);
      this.button2.TabIndex = 1;
      this.button2.Text = "Execute";
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new EventHandler(this.Button2_Click);
      this.panel1.Location = new Point(12, 32);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(572, 11);
      this.panel1.TabIndex = 5;
      this.panel1.Paint += new PaintEventHandler(this.panel1_Paint);
      this.panel2.Location = new Point(11, 433);
      this.panel2.Name = "panel2";
      this.panel2.Size = new Size(774, 11);
      this.panel2.TabIndex = 6;
      this.panel3.Location = new Point(784, 30);
      this.panel3.Name = "panel3";
      this.panel3.Size = new Size(10, 414);
      this.panel3.TabIndex = 7;
      this.panel4.Location = new Point(6, 40);
      this.panel4.Name = "panel4";
      this.panel4.Size = new Size(10, 289);
      this.panel4.TabIndex = 8;
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new Size(61, 4);
      this.timer1.Enabled = true;
      this.timer1.Interval = 1;
      this.timer1.Tick += new EventHandler(this.timer1_Tick);
      this.topBar.BackColor = System.Drawing.Color.Black;
      this.topBar.Controls.Add((Control) this.InjectionButtonPannel);
      this.topBar.Controls.Add((Control) this.label2);
      this.topBar.Controls.Add((Control) this.button9);
      this.topBar.Controls.Add((Control) this.button7);
      this.topBar.Controls.Add((Control) this.pictureBox1);
      this.topBar.Dock = DockStyle.Top;
      this.topBar.Location = new Point(0, 0);
      this.topBar.Name = "topBar";
      this.topBar.Size = new Size(594, 30);
      this.topBar.TabIndex = 0;
      this.topBar.MouseDown += new MouseEventHandler(this.dragUi);
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
      this.InjectionButtonPannel.Location = new Point(34, 3);
      this.InjectionButtonPannel.Name = "InjectionButtonPannel";
      this.InjectionButtonPannel.Size = new Size(20, 24);
      this.InjectionButtonPannel.TabIndex = 114;
      this.InjectionButtonPannel.UseVisualStyleBackColor = false;
      this.InjectionButtonPannel.Click += new EventHandler(this.InjectionButtonPannel_Click);
      this.label2.AutoSize = true;
      this.label2.Font = new Font("Segoe UI", 7.8f, FontStyle.Bold | FontStyle.Italic);
      this.label2.ForeColor = System.Drawing.Color.White;
      this.label2.Location = new Point(60, 9);
      this.label2.Name = "label2";
      this.label2.Size = new Size(55, 13);
      this.label2.TabIndex = 113;
      this.label2.Text = "Injection!";
      this.label2.Click += new EventHandler(this.label2_Click_1);
      this.button9.BackColor = System.Drawing.Color.Transparent;
      this.button9.Cursor = Cursors.Hand;
      this.button9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button9.FlatAppearance.BorderSize = 0;
      this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button9.FlatStyle = FlatStyle.Flat;
      this.button9.Font = new Font("Bahnschrift", 8f);
      this.button9.ForeColor = System.Drawing.Color.White;
      this.button9.Location = new Point(545, 6);
      this.button9.Name = "button9";
      this.button9.Size = new Size(20, 20);
      this.button9.TabIndex = 112;
      this.button9.Text = "-";
      this.button9.UseVisualStyleBackColor = false;
      this.button9.Click += new EventHandler(this.button9_Click_2);
      this.button7.BackColor = System.Drawing.Color.Black;
      this.button7.Cursor = Cursors.Hand;
      this.button7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button7.FlatAppearance.BorderSize = 0;
      this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
      this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 40);
      this.button7.FlatStyle = FlatStyle.Flat;
      this.button7.Font = new Font("Bahnschrift", 8f);
      this.button7.ForeColor = System.Drawing.Color.White;
      this.button7.Location = new Point(564, 6);
      this.button7.Name = "button7";
      this.button7.Size = new Size(20, 20);
      this.button7.TabIndex = 112;
      this.button7.Text = "X";
      this.button7.UseVisualStyleBackColor = false;
      this.button7.Click += new EventHandler(this.button7_Click_1);
      this.pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox1.Location = new Point(3, 3);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new Size(25, 25);
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      this.pictureBox1.MouseDown += new MouseEventHandler(this.dragUi);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new Size(594, 338);
      this.Controls.Add((Control) this.panel3);
      this.Controls.Add((Control) this.panel2);
      this.Controls.Add((Control) this.panel1);
      this.Controls.Add((Control) this.chaosityTabs);
      this.Controls.Add((Control) this.border2);
      this.Controls.Add((Control) this.border1);
      this.Controls.Add((Control) this.border3);
      this.Controls.Add((Control) this.topBar);
      this.Controls.Add((Control) this.panel4);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Name = "FGameHubMain";
      this.Text = "Chaosity Executor";
      this.Load += new EventHandler(this.FGameHubMain_Load);
      this.Leave += new EventHandler(this.FGameHubMain_Leave);
      this.chaosityTabs.ResumeLayout(false);
      this.scriptHub.ResumeLayout(false);
      this.scriptHub.PerformLayout();
      this.flowLayoutPanel1.ResumeLayout(false);
      this.panel6.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox3).EndInit();
      this.panel5.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox4).EndInit();
      this.panel7.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox5).EndInit();
      this.panel8.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox6).EndInit();
      this.panel9.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox7).EndInit();
      this.panel10.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox8).EndInit();
      this.panel11.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox9).EndInit();
      this.panel12.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox10).EndInit();
      this.panel13.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox11).EndInit();
      this.panel14.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox12).EndInit();
      this.panel20.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox17).EndInit();
      this.panel19.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox16).EndInit();
      this.panel18.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox15).EndInit();
      this.panel17.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox2).EndInit();
      this.panel15.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox14).EndInit();
      this.panel25.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox22).EndInit();
      this.panel23.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox20).EndInit();
      this.panel22.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox19).EndInit();
      this.panel21.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox18).EndInit();
      this.panel24.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox21).EndInit();
      this.panel16.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox13).EndInit();
      this.panel26.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox23).EndInit();
      this.panel27.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox24).EndInit();
      this.panel29.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox26).EndInit();
      this.panel30.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox27).EndInit();
      this.panel31.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox28).EndInit();
      this.panel32.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox29).EndInit();
      this.panel33.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox30).EndInit();
      this.panel34.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox31).EndInit();
      this.panel35.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox32).EndInit();
      this.panel37.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox34).EndInit();
      this.panel38.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox35).EndInit();
      this.panel39.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox36).EndInit();
      this.panel40.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox37).EndInit();
      this.panel41.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox38).EndInit();
      this.panel42.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox39).EndInit();
      this.panel43.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox40).EndInit();
      this.panel44.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox41).EndInit();
      this.panel46.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox43).EndInit();
      this.panel48.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox45).EndInit();
      this.panel49.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox46).EndInit();
      this.panel50.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox47).EndInit();
      this.panel51.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox48).EndInit();
      this.panel53.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox50).EndInit();
      this.panel54.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox51).EndInit();
      this.panel55.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox52).EndInit();
      this.panel56.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox53).EndInit();
      this.panel57.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox54).EndInit();
      this.panel60.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox57).EndInit();
      this.panel62.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox59).EndInit();
      this.panel63.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox60).EndInit();
      this.panel64.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox61).EndInit();
      this.panel65.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox62).EndInit();
      this.panel66.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox63).EndInit();
      this.panel28.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox25).EndInit();
      this.panel58.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox55).EndInit();
      this.panel67.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox64).EndInit();
      this.panel68.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox65).EndInit();
      this.panel69.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox66).EndInit();
      this.panel70.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox67).EndInit();
      this.panel72.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox69).EndInit();
      this.panel73.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox70).EndInit();
      this.panel74.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox71).EndInit();
      this.panel75.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox72).EndInit();
      this.panel76.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox73).EndInit();
      this.panel77.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox74).EndInit();
      this.panel78.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox75).EndInit();
      this.panel79.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox76).EndInit();
      this.panel80.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox77).EndInit();
      this.panel81.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox78).EndInit();
      this.panel82.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox79).EndInit();
      this.panel83.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox80).EndInit();
      this.panel85.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox82).EndInit();
      this.panel86.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox83).EndInit();
      this.panel87.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox84).EndInit();
      this.panel88.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox85).EndInit();
      this.panel89.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox86).EndInit();
      this.panel90.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox87).EndInit();
      this.panel91.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox88).EndInit();
      this.panel93.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox90).EndInit();
      this.panel94.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox91).EndInit();
      this.panel95.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox92).EndInit();
      this.panel97.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox94).EndInit();
      this.panel98.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox95).EndInit();
      this.panel99.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox96).EndInit();
      this.panel96.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox93).EndInit();
      this.panel100.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox97).EndInit();
      this.panel103.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox100).EndInit();
      this.panel101.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox98).EndInit();
      this.panel104.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox101).EndInit();
      this.panel105.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox102).EndInit();
      this.panel107.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox104).EndInit();
      this.panel108.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox105).EndInit();
      this.panel106.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox103).EndInit();
      this.panel102.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox99).EndInit();
      this.panel109.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox106).EndInit();
      this.panel111.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox108).EndInit();
      this.panel112.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox109).EndInit();
      this.panel113.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox110).EndInit();
      this.panel92.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox89).EndInit();
      this.panel114.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox111).EndInit();
      this.panel59.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox56).EndInit();
      this.panel115.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox112).EndInit();
      this.panel116.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox113).EndInit();
      this.panel117.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox114).EndInit();
      this.panel118.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox115).EndInit();
      this.panel120.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox117).EndInit();
      this.panel121.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox118).EndInit();
      this.panel122.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox119).EndInit();
      this.panel123.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox120).EndInit();
      this.panel124.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox121).EndInit();
      this.panel125.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox122).EndInit();
      this.panel126.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox123).EndInit();
      this.panel84.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox81).EndInit();
      this.panel127.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox124).EndInit();
      this.panel71.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox68).EndInit();
      this.panel128.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox125).EndInit();
      this.panel129.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox126).EndInit();
      this.panel130.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox127).EndInit();
      this.panel131.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox128).EndInit();
      this.panel119.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox116).EndInit();
      this.panel132.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox129).EndInit();
      this.panel133.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox130).EndInit();
      this.panel136.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox133).EndInit();
      this.panel137.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox134).EndInit();
      this.panel138.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox135).EndInit();
      this.panel135.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox132).EndInit();
      this.panel139.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox136).EndInit();
      this.panel140.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox137).EndInit();
      this.panel141.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox138).EndInit();
      this.panel142.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox139).EndInit();
      this.panel143.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox140).EndInit();
      this.panel144.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox141).EndInit();
      this.panel47.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox44).EndInit();
      this.panel145.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox142).EndInit();
      this.panel146.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox143).EndInit();
      this.panel110.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox107).EndInit();
      this.panel147.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox144).EndInit();
      this.panel148.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox145).EndInit();
      this.panel149.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox146).EndInit();
      this.panel150.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox147).EndInit();
      this.panel151.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox148).EndInit();
      this.panel152.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox149).EndInit();
      this.panel153.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox150).EndInit();
      this.panel134.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox131).EndInit();
      this.panel45.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox42).EndInit();
      this.panel154.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox151).EndInit();
      this.panel155.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox152).EndInit();
      this.panel156.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox153).EndInit();
      this.panel157.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox154).EndInit();
      this.panel61.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox58).EndInit();
      this.panel52.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox49).EndInit();
      this.panel158.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox155).EndInit();
      this.panel159.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox156).EndInit();
      this.panel160.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox157).EndInit();
      this.panel161.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox158).EndInit();
      this.panel162.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox159).EndInit();
      this.panel163.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox160).EndInit();
      this.panel164.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox161).EndInit();
      this.panel165.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox162).EndInit();
      this.panel166.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox163).EndInit();
      this.execPage.ResumeLayout(false);
      this.topBar.ResumeLayout(false);
      this.topBar.PerformLayout();
      ((ISupportInitialize) this.pictureBox1).EndInit();
      this.ResumeLayout(false);
    }
  }
}
