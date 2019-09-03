using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GameStation.DAL
{
    public static class Tools
    {
        private static string picturesDirectory;
        public static string PicturesDirectory
        {
            get
            {
                picturesDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "/Pictures/";
                return picturesDirectory;
            }
        }
    }
}
