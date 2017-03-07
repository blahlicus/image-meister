using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Meister
{
    public partial class FmMain : Form
    {
        List<Bitmap> Images;
        List<PictureBox> PictureBoxes;
        List<UCSidebarThumbItem> SideItems;
        public FmMain()
        {
            Images = new List<Bitmap>();
            PictureBoxes = new List<PictureBox>();
            SideItems = new List<UCSidebarThumbItem>();
            InitializeComponent();
            SCMain.SplitterDistance = MdConfig.Main.SidebarWidth;
            SCMain.Panel1Collapsed = MdConfig.Main.SidebarCollapsed;
            foreach(var item in TSCMBZoom.Items)
            {
                if (item.ToString() == MdConfig.Main.ZoomLevel.ToString())
                {
                    TSCMBZoom.SelectedItem = item;
                }
            }
            LoadImages();
        }

        private void LoadImages()
        {
            
            Images = new List<Bitmap>();
            PictureBoxes = new List<PictureBox>();
            SideItems = new List<UCSidebarThumbItem>();

            FLPMain.Controls.Clear();
            FLPSide.Controls.Clear();
            int ind = 0;
            
            foreach (var ele in MdSessionData.CurrentFiles)
            {

                Bitmap bmp = null;
                if (MdConfig.Main.EntireFolderShow || ele == MdSessionData.CurrentFile)
                {
                    bmp = new Bitmap(ele);
                    AddImage(bmp, ind);
                }
                AddThumb(ele, ind, bmp);
                ind++;

            }
            var np = new Panel();
            np.Size = new Size(0, 0);
            np.Margin = new Padding(0, 0, 0, 0);
            FLPMain.Controls.Add(np);
            ResizeDisplay();
        }

        private void ClickedSideItem(object sender, EventArgs e)
        {
            foreach(var ele in SideItems)
            {
                if (ele.BackColor != SystemColors.Control)
                {
                    ele.BackColor = SystemColors.Control;
                }
            }
            var tab = (sender as UCSidebarThumbItem);
            tab.BackColor = SystemColors.Highlight;
            if (MdConfig.Main.EntireFolderShow)
            {
                SCMain.Panel2.ScrollControlIntoView(PictureBoxes[tab.Index]);
            }
            else
            {
                var pb = PictureBoxes[0];
                var img = new Bitmap(tab.Filepath);
                tab.SetThumb(img);
                pb.BackgroundImage = img;
                pb.Size = img.Size;
                Images[0] = img;
            }
            ResizeDisplay();
        }

        private void AddImage(Bitmap Img, int ind)
        {
            var pb = new PictureBox();
            pb.Margin = new Padding(0, 0, 0, 0);
            pb.BackgroundImageLayout = ImageLayout.Stretch;
            pb.BackgroundImage = Img;
            pb.Size = Img.Size;
            pb.Tag = ind;
            PictureBoxes.Add(pb);
            Images.Add(Img);
            FLPMain.Controls.Add(pb);
            
        }

        private void AddThumb(string path, int index, Bitmap img = null)
        {
            var tmb = new UCSidebarThumbItem(path, index, img);
            SideItems.Add(tmb);
            FLPSide.Controls.Add(tmb);
            tmb.ClickedElement += (sender, e) => ClickedSideItem(sender, e);
        }

        private void showSidebarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SCMain.Panel1Collapsed = !SCMain.Panel1Collapsed;
            MdConfig.Main.SidebarCollapsed = SCMain.Panel1Collapsed;
            MdConfig.Save();
        }

        private void SCMain_SplitterMoved(object sender, SplitterEventArgs e)
        {
            MdConfig.Main.SidebarWidth = SCMain.SplitterDistance;
            MdConfig.Save();
        }
    

        private void ResizeDisplay()
        {

            TLPMain.Width = SCMain.Panel2.Width;
            if (TLPMain.ColumnCount > 2 && Images.Count > 0)
            {
                int setwidth = (TLPMain.Width * MdConfig.Main.ZoomLevel) / 100;
                TLPMain.ColumnStyles[1].Width = setwidth;
                int totalow = 0;
                int totalw = 0;
                int HSize = 0;
                foreach(var ele in PictureBoxes)
                {
                    totalow = totalow + Images[Convert.ToInt32(ele.Tag)].Width;
                    double hratio = Convert.ToDouble(setwidth) / Images[Convert.ToInt32(ele.Tag)].Width;
                    ele.Width = setwidth;
                    totalw = totalw + setwidth;
                    ele.Height = Convert.ToInt32(hratio * Images[Convert.ToInt32(ele.Tag)].Height);
                    HSize = HSize + Images[Convert.ToInt32(ele.Tag)].Height;
                }
                double thratio = Convert.ToDouble(totalw) / totalow;
                TLPMain.Height = Convert.ToInt32(thratio * HSize) + 1080;
            }
        }
        
        private void showAllFilesInFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MdConfig.Main.EntireFolderShow = !MdConfig.Main.EntireFolderShow;
            MdConfig.Save();
            LoadImages();
        }

        private void TSCMBZoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            MdConfig.Main.ZoomLevel = Convert.ToInt32(TSCMBZoom.SelectedItem.ToString());
            MdConfig.Save();
            ResizeDisplay();
        }
        

        private void SCMain_Panel2_Resize(object sender, EventArgs e)
        {

            ResizeDisplay();
        }
    }
}
