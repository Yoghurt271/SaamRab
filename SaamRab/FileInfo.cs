using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SaamRab
{
    class FileInfo
    {
        string path = @"D:\SamRab";
        public void Name()
        {
            string[] files = Directory.GetFiles(path);
            string[] dir = Directory.GetDirectories(path);
            return;

        }
    }
}
