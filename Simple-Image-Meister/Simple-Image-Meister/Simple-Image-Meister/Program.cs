using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Simple_Image_Meister
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            MdSessionData.Init();
            if (args.Length > 0)
            {
                string filename = args[0];
                if (filename.Contains(@":\"))
                {
                    // do nothing
                }
                else
                {
                    filename = Path.GetFullPath(filename);
                }
                string directoryname = System.IO.Path.GetDirectoryName(filename);
                MdSessionData.CurrentDirectory = directoryname;
                MdSessionData.CurrentFile = filename;

            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FmMain());
        }
    }
}
