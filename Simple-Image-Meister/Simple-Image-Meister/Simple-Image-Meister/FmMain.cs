using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Simple_Image_Meister
{
    public partial class FmMain : Form
    {
        int maxWidth;
        int screenWidth = Screen.PrimaryScreen.Bounds.Width;
        public FmMain()
        {
            InitializeComponent();
            LoadDocument();
        }


        private void LoadDocument()
        {

            var html = MdConstant.DOC_PREFIX;
            int tw = 0;
            if (MdSessionData.CurrentDirectory != null && MdSessionData.CurrentDirectory != "NULL")
            {

                if (MdSessionData.ShowAll)
                {
                    foreach (var ele in MdSessionData.CurrentFiles)
                    {
                        int w = ImageHelper.GetDimensions(ele).Width;
                        if (w > tw)
                        {
                            tw = w;
                        }
                    }

                    foreach (var ele in MdSessionData.CurrentFiles)
                    {
                        html = html + MdConstant.IMAGE_PREFIX + ele + MdConstant.Image_MIDFIX + tw + MdConstant.IMAGE_SUFFIX;
                    }
                }
                else
                {
                    tw = ImageHelper.GetDimensions(MdSessionData.CurrentFile).Width;
                    html = html + MdConstant.IMAGE_PREFIX + MdSessionData.CurrentFile + MdConstant.Image_MIDFIX + tw + MdConstant.IMAGE_SUFFIX;
                }
            }
            maxWidth = tw;
            html = html + MdConstant.DOC_SUFFIX;
            //MessageBox.Show(html);
            WBMain.DocumentText = html;
        }

        private void displayAllFilesInFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MdSessionData.CurrentFiles.Count < 1)
            {

                var fileList = Directory.GetFiles(MdSessionData.CurrentDirectory, "*.*", SearchOption.TopDirectoryOnly)
                    .Where(s => MdConstant.FormatList.Any(ele => s.ToLower().EndsWith(ele)));

                string[] sFileList = fileList.ToArray();
                Array.Sort(sFileList, MdUtil.CompareNatural);
                MdSessionData.CurrentFiles = sFileList.ToList();
            }
            MdSessionData.ShowAll = !MdSessionData.ShowAll;
            LoadDocument();
        }

        private void openInExplorerToolStripMenuItem_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start("explorer.exe", "/select, \"" + MdSessionData.CurrentFile + "\"");
        }

        private void WBMain_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

            int zoomlevel = Convert.ToInt32(((100 * screenWidth) / maxWidth) * 0.95);
            ((SHDocVw.WebBrowser)WBMain.ActiveXInstance).ExecWB(SHDocVw.OLECMDID.OLECMDID_OPTICAL_ZOOM, SHDocVw.OLECMDEXECOPT.OLECMDEXECOPT_DONTPROMPTUSER, zoomlevel, IntPtr.Zero);
        }
    }
}
