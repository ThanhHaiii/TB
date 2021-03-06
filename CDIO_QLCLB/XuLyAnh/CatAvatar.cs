﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CDIO_QLCLB.XuLyAnh
{
    class CatAvatar
    {
        Image anh;
        public Bitmap catAnh(string linkAnh)
        {
            anh = Image.FromFile(linkAnh);
            
            int x = 0, y = 0, imagewidth = anh.Size.Width, imageheight = anh.Size.Height;
            int ngang;
            if (imageheight > imagewidth)
            {
                x = 0;
                y = (imageheight - imagewidth) / 2;
                ngang = imagewidth;
            }
            else
            {
                y = 0;
                x = (imagewidth - imageheight) / 2;
                ngang = imageheight;
            }

            Rectangle cropRect = new Rectangle(x, y, ngang, ngang);
            Bitmap src = anh as Bitmap;
            Bitmap target = new Bitmap(cropRect.Width, cropRect.Height);

            using (Graphics g = Graphics.FromImage(target))
            {
                g.DrawImage(src, new Rectangle(0, 0, ngang, ngang),
                                 cropRect,
                                 GraphicsUnit.Pixel);
                if (ngang > 200)
                {
                    ngang = 200;
                }
                target = Resize(target, ngang, ngang);
                return target;
            }
        }

        public Bitmap Resize(Bitmap b, int nWidth, int nHeight)
        {
            Bitmap bTemp = (Bitmap)b.Clone();
            b = new Bitmap(nWidth, nHeight, bTemp.PixelFormat);

            double nXFactor = (double)bTemp.Width / (double)nWidth;
            double nYFactor = (double)bTemp.Height / (double)nHeight;//lấy tỷ lệ kích thước gốc với kích thước cần

            double fraction_x, fraction_y, one_minus_x, one_minus_y;
            int ceil_x, ceil_y, floor_x, floor_y;
            Color c1 = new Color();
            Color c2 = new Color();
            Color c3 = new Color();
            Color c4 = new Color();
            byte red, green, blue;

            byte b1, b2;

            for (int x = 0; x < b.Width; ++x)
            {
                for (int y = 0; y < b.Height; ++y)
                {
                    floor_x = (int)Math.Floor(x * nXFactor);
                    floor_y = (int)Math.Floor(y * nYFactor);
                    ceil_x = floor_x + 1;
                    if (ceil_x >= bTemp.Width) ceil_x = floor_x;
                    ceil_y = floor_y + 1;
                    if (ceil_y >= bTemp.Height) ceil_y = floor_y;
                    fraction_x = x * nXFactor - floor_x;
                    fraction_y = y * nYFactor - floor_y;
                    one_minus_x = 1.0 - fraction_x;
                    one_minus_y = 1.0 - fraction_y;

                    c1 = bTemp.GetPixel(floor_x, floor_y);
                    c2 = bTemp.GetPixel(ceil_x, floor_y);
                    c3 = bTemp.GetPixel(floor_x, ceil_y);
                    c4 = bTemp.GetPixel(ceil_x, ceil_y);

                    // Tính màu xanh dương cho pixel đang xét
                    b1 = (byte)(one_minus_x * c1.B + fraction_x * c2.B);
                    b2 = (byte)(one_minus_x * c3.B + fraction_x * c4.B);
                    blue = (byte)(one_minus_y * (double)(b1) + fraction_y * (double)(b2));

                    // Tính màu xanh lá cho pixel đang xét
                    b1 = (byte)(one_minus_x * c1.G + fraction_x * c2.G);
                    b2 = (byte)(one_minus_x * c3.G + fraction_x * c4.G);
                    green = (byte)(one_minus_y * (double)(b1) + fraction_y * (double)(b2));

                    // Tính màu dỏ cho pixel đang xét
                    b1 = (byte)(one_minus_x * c1.R + fraction_x * c2.R);
                    b2 = (byte)(one_minus_x * c3.R + fraction_x * c4.R);
                    red = (byte)(one_minus_y * (double)(b1) + fraction_y * (double)(b2));

                    b.SetPixel(x, y, System.Drawing.Color.FromArgb(255, red, green, blue));
                }
            }
            return b;
        }
    }
}
