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

            List<UInt32> ms = new List<UInt32>();

            using (Bitmap b = new Bitmap(im))
            {

                    for(int y = 0; y < im.Height; y++)
                    {
                        for(int x = 0; x < im.Width; x++)
                        {
                            System.Drawing.Color c = b.GetPixel(x, y);
                            ms.Add((UInt32)(c.R << 24 | c.G << 16 | c.B << 8 | c.A));
                        }
                    }

                UInt32[] integers = ms.ToArray();
                return new Sprite(integers, im.Width, im.Height);

            }
        }


    }
}
