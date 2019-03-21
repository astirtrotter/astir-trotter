using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATDesktopWin.Helpers
{
    public static class ImageHelper
    {
        public static Bitmap CropBitmap(Bitmap srcImage, int destWidth, int destHeight)
        {
            float cropRatio = Math.Min((float)srcImage.Width / destWidth, (float)srcImage.Height / destHeight);
            int srcCropWidth = (int)(destWidth * cropRatio);
            int srcCropHeight = (int)(destHeight * cropRatio);
            int offsetX = (srcImage.Width - srcCropWidth) / 2;
            int offsetY = (srcImage.Height - srcCropHeight) / 2;
            Bitmap destImage = new Bitmap(destWidth, destHeight);
            using (Graphics g = Graphics.FromImage(destImage))
            {
                g.DrawImage(srcImage,
                    new Rectangle(0, 0, destWidth, destHeight),
                    offsetX, offsetY, srcCropWidth, srcCropHeight,
                    GraphicsUnit.Pixel);
            }

            return destImage;
        }
    }
}
