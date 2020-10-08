// Decompiled with JetBrains decompiler
// Type: DiscordRpcDemo.DiscordRpc
// Assembly: Chaosity, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8FD1C12D-B5CF-4C0B-B451-47DE735C992C
// Assembly location: C:\Users\povar\Desktop\Chaosity (Exploit)\ChaosityExploit.exe

using System;
using System.Net;
using System.Runtime.InteropServices;

namespace DiscordRpcDemo
{
  public class DiscordRpc
  {
    public DiscordRpc()
    {
      new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/679526951068893187/688753204111867985/discord-rpc-w32.dll", "discord-rpc-w32.dll");
    }

    [DllImport("discord-rpc-w32.dll", EntryPoint = "Discord_Initialize", CallingConvention = CallingConvention.Cdecl)]
    public static extern void Initialize(
      string applicationId,
      ref DiscordRpc.EventHandlers handlers,
      bool autoRegister,
      string optionalSteamId);

    [DllImport("discord-rpc-w32.dll", EntryPoint = "Discord_RunCallbacks", CallingConvention = CallingConvention.Cdecl)]
    public static extern void RunCallbacks();

    [DllImport("discord-rpc-w32.dll", EntryPoint = "Discord_Shutdown", CallingConvention = CallingConvention.Cdecl)]
    public static extern void Shutdown();

    [DllImport("discord-rpc-w32.dll", EntryPoint = "Discord_UpdatePresence", CallingConvention = CallingConvention.Cdecl)]
    public static extern void UpdatePresence(ref DiscordRpc.RichPresence presence);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void DisconnectedCallback(int errorCode, string message);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void ErrorCallback(int errorCode, string message);

    public struct EventHandlers
    {
      public DiscordRpc.ReadyCallback readyCallback;
      public DiscordRpc.DisconnectedCallback disconnectedCallback;
      public DiscordRpc.ErrorCallback errorCallback;
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void ReadyCallback();

    [Serializable]
    public struct RichPresence
    {
      public string state;
      public string details;
      public long startTimestamp;
      public long endTimestamp;
      public string largeImageKey;
      public string largeImageText;
      public string smallImageKey;
      public string smallImageText;
      public string partyId;
      public int partySize;
      public int partyMax;
      public string matchSecret;
      public string joinSecret;
      public string spectateSecret;
      public bool instance;
    }
  }
}
