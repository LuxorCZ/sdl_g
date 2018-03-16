using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using Game.Engine.Entities;
using System.Drawing.Imaging;

namespace Game.Engine.Utilities
{
    static class ImageUtilities
    {

        public static byte[] getBytesFromImage(string path)
        {


            return new byte[0];
            //return Image.FromFile(path)
            

        }

        public static Sprite getSprite(string path)
        {

            Image im = Image.FromFile(path);

            using (MemoryStream ms = new MemoryStream())
            {

                using (Bitmap b = new Bitmap(im))
                {

                    for(int y = 0; y < im.Height; y++)
                    {
                        for(int x = 0; x < im.Width; x++)
                        {
                            System.Drawing.Color c = b.GetPixel(x, y);

                            ms.WriteByte(c.A);
                            ms.WriteByte(c.R);
                            ms.WriteByte(c.G);
                            ms.WriteByte(c.B);
                        }
                    }

                }

                //im.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                byte[] bytes = ms.ToArray();
                return new Sprite(bytes, im.Width, im.Height);

            }
        }


    }
}
