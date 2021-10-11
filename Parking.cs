using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace BelyaevaTank
{
    public class Parking<T> where T : class, ITransport
    {
        private readonly T[] _places; //array of objects

        private readonly int pictureWidth;
        private readonly int pictureHeight;
        //size of a parking lot
        private readonly int _placeSizeWidth = 270;
        private readonly int _placeSizeHeight = 90;
        private int width;
        private int height;

        public Parking(int picWidth, int picHeight)
        {
            width = picWidth / _placeSizeWidth;//2
            height = picHeight / _placeSizeHeight;//5
            _places = new T[width * height];
            pictureHeight = picHeight;
            pictureWidth = picWidth;
        }

        public static int operator +(Parking<T> p, T tank)
        {
            int i = 0;
            int j = 0;
            while (i < p.height)
            {
                j = 0;
                while (j < p.width)
                {
                    if (p._places[i*p.width + j] == null)
                    {
                        p._places[i*p.width + j] = tank;
                        tank.SetPosition(20 + j * p._placeSizeWidth, 13 + i * p._placeSizeHeight, p.pictureWidth, p.pictureHeight);
                        return i*p.width + j;
                    }
                    j++;
                }
                i++;
            }
            return -1;
        }

        public static T operator -(Parking<T> p, int index)
        {
            if ((index >= p.width * p.height)||(p._places[index] == null))
            {
                return null;
            }
            if (p._places[index] != null) 
            {
                T obj = p._places[index];
                p._places[index] = null;
                return obj;
            }
            else
            {
                return null;
            }
        }

        public void Draw(Graphics g) 
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Length; i++)
            {
                _places[i]?.DrawTransport(g);
            }
        }

        private void DrawMarking(Graphics g) 
        {
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < pictureWidth / _placeSizeWidth; i++) 
            {
                for (int j = 0; j < pictureHeight / _placeSizeHeight + 1; ++j)
                {
                    g.DrawLine(pen, i * _placeSizeWidth + 5, j * _placeSizeHeight + 5, i * _placeSizeWidth + _placeSizeWidth / 2 + 5, j * _placeSizeHeight + 5);
                }
                g.DrawLine(pen, i * _placeSizeWidth + 5, 5, i * _placeSizeWidth + 5, (pictureHeight / _placeSizeHeight)*_placeSizeHeight+ 5);
            }
        }
    }
}
