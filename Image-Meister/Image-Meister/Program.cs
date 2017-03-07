using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Image_Meister
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MdSessionData.Init();
            if (args.Length == 1)
            {
                string filename = args[0];
                string directoryname = System.IO.Path.GetDirectoryName(filename);
                MdSessionData.CurrentDirectory = directoryname;
                MdSessionData.CurrentFile = filename;
                var fileList = Directory.GetFiles(directoryname, "*.*", SearchOption.TopDirectoryOnly)
                    .Where(s => MdConstant.FormatList.Any(e => s.EndsWith(e)));

                string[] sFileList = fileList.ToArray();
                Array.Sort(sFileList, MdUtil.CompareNatural);
                MdSessionData.CurrentFiles = sFileList.ToList();

            }
            Application.Run(new FmMain());
        }
    }
}
