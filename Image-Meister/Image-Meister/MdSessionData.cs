using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Image_Meister
{
    public class MdSessionData
    {
        public static string CurrentDirectory = "NULL";
        public static string CurrentFile = "NULL";
        public static List<string> CurrentFiles;
        public static void Init()
        {
            CurrentFiles = new List<string>();
            MdPersistentData.Init();
            MdConfig.Init();

        }
    }
}
