# ArticPolar.Dev.PanelToImage
Save Panel to a Image.


## Example Code
````
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArticPolar.Dev.PanelToImage;
using System.Drawing.Imaging;

namespace PanelToImg
{
    public partial class PanelFrm: Form
    {
        public PanelFrm()
        {
            InitializeComponent();
        }

        private void bntSave_Click(object sender, EventArgs e)
        {
            PanelToImage.SaveToImage(MyPanel1, ImageFormat.Png, Application.StartupPath + @"\Img.png");
        }
    }
}
````
