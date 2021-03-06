﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MplayerUnitTests
{
    public class GlobalVariables
    {

        // Test videos can be downloaded from:
        // http://files.majorsilence.com/TestVideos.zip
        // TODO: You must point the path to the mplayer.exe and the test videos to the location
        // were they exist on your computer.

        private static string _basePath;
        private static string _mplayerPath;

        public static void InitPath(string basePath, string mplayerPath)
        {
            _basePath = basePath;
            _mplayerPath = mplayerPath;
        }

        public static string BasePath
        {
            get { return _basePath; }
        }

        public static string MplayerPath
        {
            get { return _mplayerPath; }
        }

        public static string Video1Path
        {
            get { return Path.Combine(_basePath, "TestVideo1-á.flv"); }
        }

        public static string Video2Path
        {
            get { return Path.Combine(_basePath, "TestVideo2.flv"); }
        }

        public static string Video8Path
        {
            get { return Path.Combine(_basePath, "TestVideo8.flv"); }
        }

        public static string OutputVideoWebM
        {
            get { return Path.Combine(_basePath, "OutputVideoWebM.webm"); }
        }

        public static string OutputVideoX264
        {
            get { return Path.Combine(_basePath, "OutputVideoX264.mp4"); }
        }

        public static string OutputVideoDvdMpegPal
        {
            get { return Path.Combine(_basePath, "OutputVideoDvdMpegPal.mpg"); }
        }

        public static string OutputVideoDvdMpegNtsc
        {
            get { return Path.Combine(_basePath, "OutputVideoDvdMpegNtsc.mpg"); }
        }

    }
}
