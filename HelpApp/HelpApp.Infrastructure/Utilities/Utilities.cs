using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HelpApp.WebApi.Utilities
{
    public class Utilities
    {
        public static bool Remove(string root, string image)
        {
            string path = Path.Combine(root , image);
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
                return true;
            }
            return false;
        }
    }
}
