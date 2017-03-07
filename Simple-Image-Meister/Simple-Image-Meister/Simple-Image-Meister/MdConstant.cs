using System.IO;
using System.Reflection;

namespace Simple_Image_Meister
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
        public static string DOC_PREFIX = "<!DOCTYPE html><html><body bgcolor=\"#566573\"><center>";
        public static string IMAGE_PREFIX = "\n<div style=\"padding:20px\"><img src=\"";
        public static string Image_MIDFIX = "\" style=\"width:";
        public static string IMAGE_SUFFIX = "px;\"></div>\n";
        public static string DOC_SUFFIX = "</center></body></html>";
    }
}
