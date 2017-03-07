using System.IO;
using System.Reflection;

namespace Image_Meister
{
    public class MdConstant
    {
        // ReSharper disable once InconsistentNaming
        public static char psep = Path.DirectorySeparatorChar;

        // ReSharper disable once InconsistentNaming
        public static string root = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

        public static string N_PERSISTENT_DATA = "persistent-data.tlpd";
        public static string N_CONFIG = "config.tlcfg";

        public static string[] FormatList = { ".bmp", ".cut", ".dcx", ".dds", ".ico", ".gif", ".jpg", ".lbm", ".lif", ".mdl", ".pcd", ".pcx", ".pic", ".png", ".pnm", ".raw", ".sgi", ".tga", ".tif", ".wal", ".act", ".pal", ".hdr" };

    }
}
