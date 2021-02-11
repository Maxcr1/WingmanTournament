﻿using System;
using System.Diagnostics;
using WebSocketSharp;

namespace WingmanRelay {
    
    public class MainClass {

        public static void Main(string[] args) {
            const string url = "http://localhost:3000/";
            const string serverUrl = "http://13.58.40.89:3254/";
            
            Process[] processes = Process.GetProcessesByName("Lexogrine HUD Manager");
            if (processes.Length == 0) {
                Console.Write("Lexogrine is not running!");
                Environment.Exit(0);
            }
            
            Process[] csgo = Process.GetProcessesByName("csgo.exe");
            if (csgo.Length == 0) {
                Console.Write("WARNING: CSGO is not running!");
            }
            
            var gsiServer = new GsiServer(url, serverUrl);
            gsiServer.start();
        }
    }
}