﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Alduin.Server.Modules
{
    public class ServerFileManager
    {
        public static string FileReader(string file)
        {
            return File.ReadAllText(file, Encoding.UTF8);
        }
        public static void FileWriter(string path, string data)
        {
            File.WriteAllText(path, data, Encoding.UTF8);
        }
        public static void FileAppendText(string path, string data)
        {
            File.AppendAllText(path, data);
        }
        public static void FileAppendTextWithDate(string path, string data)
        {
            File.AppendAllText(path, "[" + DateTime.UtcNow + "]" + data);
        }
        public static void FileDelete(string file)
        {
            File.Delete(file);
        }
    }
}
