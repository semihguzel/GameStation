using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GameStation.DAL
{
    public static class Tools
    {
        public static readonly Guid adminId = Guid.NewGuid();
        public static readonly Guid userId = Guid.NewGuid();
        private static string rootDirectory;
        public static string RootDirectory
        {
            get
            {
                rootDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "/GameStation";
                return rootDirectory;
            }
        }
    }
}
