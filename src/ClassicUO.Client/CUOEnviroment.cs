﻿#region license

// Copyright (c) 2024, andreakarasho
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without
// modification, are permitted provided that the following conditions are met:
// 1. Redistributions of source code must retain the above copyright
//    notice, this list of conditions and the following disclaimer.
// 2. Redistributions in binary form must reproduce the above copyright
//    notice, this list of conditions and the following disclaimer in the
//    documentation and/or other materials provided with the distribution.
// 3. All advertising materials mentioning features or use of this software
//    must display the following acknowledgement:
//    This product includes software developed by andreakarasho - https://github.com/andreakarasho
// 4. Neither the name of the copyright holder nor the
//    names of its contributors may be used to endorse or promote products
//    derived from this software without specific prior written permission.
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS ''AS IS'' AND ANY
// EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
// WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
// DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER BE LIABLE FOR ANY
// DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
// (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
// LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
// ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
// (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
// SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

#endregion

using System;
using System.IO;
using System.Reflection;
using System.Threading;

namespace ClassicUO
{
    internal static class CUOEnviroment
    {
        public static Thread GameThread;
        public static float DPIScaleFactor = 1.0f;
        public static bool NoSound;
        public static string[] Args;
        public static string[] Plugins;
        public static bool Debug;
        public static bool IsHighDPI;
        public static uint CurrentRefreshRate;
        public static bool SkipLoginScreen;
        public static bool NoServerPing;

        public static readonly bool IsUnix = Environment.OSVersion.Platform != PlatformID.Win32NT && Environment.OSVersion.Platform != PlatformID.Win32Windows && Environment.OSVersion.Platform != PlatformID.Win32S && Environment.OSVersion.Platform != PlatformID.WinCE;

        public static readonly string Version = Assembly.GetExecutingAssembly()?.GetName()?.Version?.ToString() ?? "0.0.0.0";
        public static readonly string ExecutablePath =
#if NETFRAMEWORK
           AppContext.BaseDirectory; // Path.GetDirectoryName(Assembly.GetEntryAssembly()?.Location);
#else
            Environment.CurrentDirectory;
#endif
    }
}