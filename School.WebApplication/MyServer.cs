using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace School.WebApplication
{
    public class MyServer
    {
        public static string MapPath(string path)
        {
            return Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
        }
    }
}

