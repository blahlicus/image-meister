using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Image_Meister
{
    public class MdConfig
    {
        public int SidebarWidth { get; set; }
        public bool SidebarCollapsed { get; set; }
        public bool EntireFolderShow { get; set; }
        public int ZoomLevel { get; set; }
        public static MdConfig Main { get; set; }
        public MdConfig()
        {
            SidebarWidth = 200;
            SidebarCollapsed = false;
            EntireFolderShow = true;
            ZoomLevel = 100;
        }


        public static void Init()
        {
            if (File.Exists(Path.Combine(MdPersistentData.ConfigPath, MdConstant.N_CONFIG)))
            {
                Main = MdCore.Deserialize<MdConfig>(Path.Combine(MdPersistentData.ConfigPath, MdConstant.N_CONFIG));
            }
            else
            {
                Main = new MdConfig();
                Save();
            }
        }

        public static void Save()
        {
            MdCore.Serialize<MdConfig>(Main ,Path.Combine(MdPersistentData.ConfigPath, MdConstant.N_CONFIG));
        }

    }
}
