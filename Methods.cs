using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArticPolar.Dev.PanelToImage
{
    public class PanelToImage
    {
        public static void SaveToImage(Panel panel, ImageFormat imgFormat, string pathToSave)
        {
            using (Bitmap graphicSurface = new Bitmap(panel.Width, panel.Height))
            {
                using (StreamWriter bitmapWriter = new StreamWriter(pathToSave))
                {
                    panel.DrawToBitmap(graphicSurface, new Rectangle(0, 0, panel.Width, panel.Height));
                    graphicSurface.Save(bitmapWriter.BaseStream, imgFormat);
                }
            }
        }
    }
}
