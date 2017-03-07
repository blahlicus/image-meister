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
        int maxHeight;
        int screenWidth = Screen.PrimaryScreen.Bounds.Width;
        int screenHeight = Screen.PrimaryScreen.Bounds.Height;
        public FmMain()
        {
            InitializeComponent();
            LoadDocument();
        }


        private void LoadDocument()
        {

            var html = MdConstant.DOC_PREFIX;
            int tw = 0;
            int th = 0;
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
                        int h = ImageHelper.GetDimensions(ele).Height;
                        if (h > th)
                        {
                            th = h;
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
                    th = ImageHelper.GetDimensions(MdSessionData.CurrentFile).Height;
                    html = html + MdConstant.IMAGE_PREFIX + MdSessionData.CurrentFile + MdConstant.Image_MIDFIX + tw + MdConstant.IMAGE_SUFFIX;
                }
            }
            maxWidth = tw;
            maxHeight = th;
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
            int zoomlevel;
            if (Convert.ToDouble(maxWidth)/screenWidth > Convert.ToDouble(maxHeight)/screenHeight)
            {

                zoomlevel = Convert.ToInt32(((100 * screenWidth) / maxWidth) * 0.8);
            }
            else
            {
                zoomlevel = Convert.ToInt32(((100 * screenHeight) / maxHeight) * 0.8);

            }
            this.Height = Convert.ToInt32(maxHeight * zoomlevel / 100 * 1.1);
            this.Width = Convert.ToInt32(maxWidth * zoomlevel / 100 * 1.1);
            ((SHDocVw.WebBrowser)WBMain.ActiveXInstance).ExecWB(SHDocVw.OLECMDID.OLECMDID_OPTICAL_ZOOM, SHDocVw.OLECMDEXECOPT.OLECMDEXECOPT_DONTPROMPTUSER, zoomlevel, IntPtr.Zero);
        }
    }
}
