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
        private readonly List<T> _places; //array of objects
        private readonly int _maxCount;
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
            _maxCount = width * height;
            pictureHeight = picHeight;
            pictureWidth = picWidth;
            _places = new List<T>();
        }

        public static int operator +(Parking<T> p, T tank)
        {
            if (p._places.Count >= p._maxCount) 
            {
                return -1;
            }
            p._places.Add(tank);
            return 1;
        }

        public static T operator -(Parking<T> p, int index)
        {
            if ((index >= p._maxCount) || (index < 0))
            {
                return null;
            }
            T obj = p._places[index];
            p._places.RemoveAt(index);
            return obj;
        }

        public void Draw(Graphics g)
        {
            DrawMarking(g);

            int x = 20, y = 10;
            for(int i = 0; i < _places.Count; ++i)
            {
                if(i % width == 0 && i > 0)
                {
                    x = 20;
                    y += 100;
                }
                _places[i]?.SetPosition(x, y, pictureWidth, pictureHeight);
                _places[i]?.DrawTransport(g);
                x += 270;
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
