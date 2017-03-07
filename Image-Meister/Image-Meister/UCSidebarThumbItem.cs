using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Image_Meister
{
    public partial class UCSidebarThumbItem : UserControl
    {
        public event EventHandler ClickedElement;
        public string Filepath { get; set; }
        private Bitmap Img { get; set; }
        public int Index { get; set; }
        public UCSidebarThumbItem()
        {
            InitializeComponent();
            Filepath = "NULL";
            Img = null;
            Index = -1;
        }



        public UCSidebarThumbItem(string path, int index, Bitmap img = null) : this()
        {
            Filepath = path;
            Img = img;
            Index = index;
            this.Tag = Filepath;
        }

        private void UCSidebarThumbItem_Load(object sender, EventArgs e)
        {
            if (Img != null)
            {
                PBMain.BackgroundImage = new Bitmap(Img, 94, 94);
            }

            LFileName.Text = Path.GetFileName(Filepath);
        }

        public void SetThumb(Bitmap img)
        {
            Img = img;

            if (Img != null)
            {
                PBMain.BackgroundImage = new Bitmap(Img, 94, 94);
            }
        }

        private void PBMain_Click(object sender, EventArgs e)
        {

            if (ClickedElement != null)
            {
                ClickedElement(this, e);
            }
        }

        private void LFileName_Click(object sender, EventArgs e)
        {
            if (ClickedElement != null)
            {
                ClickedElement(this, e);
            }
        }
        

        private void UCSidebarThumbItem_Click(object sender, EventArgs e)
        {

            if (ClickedElement != null)
            {
                ClickedElement(this, e);
            }
        }
    }
}
