using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BelyaevaTank
{
    class Tank
    {
        private float _startPosX; // левая координата
        private float _startPosY; // правая координата
        private int _pictureWidth; // ширина окна отрисовки
        private int _pictureHeight; // высота окна отрисовки
        private readonly int tankWidth = 120;
        private readonly int tankHeight = 60;
        public int MaxSpeed { private set; get; }
        public float Weight { private set; get; }
        public Color MainColor { private set; get; }
        public Color DopColor { private set; get; }
        public bool Tower { private set; get; } // наличие башни у танка
        public bool Weapon { private set; get; } // наличие оружия у танка
       

        public void Init(int maxSpeed, float weight, Color mainColor, Color dopColor, bool tower, bool weapon)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Tower = tower;
            Weapon = weapon;
        }

        public void SetPosition(int x, int y, int width, int height) 
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }

        public void MoveTransport(Direction direction) 
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction) {
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - tankWidth) 
                    {
                        _startPosX += step;
                    }
                    break;

                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;

                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;

                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - tankHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }

        public void DrawTransport(Graphics g) 
        {
            Pen pen = new Pen(Color.Green);

            Brush mainBr = new SolidBrush(MainColor);
            Brush empty = new SolidBrush(Color.White);
            Brush dopBr = new SolidBrush(DopColor);

            //track
            g.FillRectangle(mainBr, _startPosX, _startPosY+35, 110, 30);
            //g.FillRectangle(empty, _startPosX+1, _startPosY+36, 110+1, 30+1);
            g.FillEllipse(mainBr, _startPosX-10, _startPosY+35, 30, 30);
            g.FillEllipse(mainBr, _startPosX+90, _startPosY+35, 30, 30);

            //wheels
            g.FillEllipse(empty, _startPosX + 2, _startPosY + 40, 15, 15);
            g.FillEllipse(empty, _startPosX + 27, _startPosY + 45, 10, 10);
            g.FillEllipse(empty, _startPosX + 49, _startPosY + 45, 10, 10);
            g.FillEllipse(empty, _startPosX + 71, _startPosY + 45, 10, 10);
            g.FillEllipse(empty, _startPosX + 93, _startPosY + 40, 15, 15);

            if (Tower)
            {
                //one more additional part but upper and behind these 2 which are under
                g.FillEllipse(dopBr, _startPosX + 31, _startPosY + 5, 45, 30);
            }

            //upper part whatever this is
            g.FillRectangle(mainBr, _startPosX + 5, _startPosY + 25, 100, 10);
            g.FillRectangle(mainBr, _startPosX + 30, _startPosY + 10, 50, 30);
            
            //additional part for upper parts
            g.FillRectangle(empty, _startPosX+40, _startPosY+15, 30, 10);

            if (Weapon)
            {
                //additional part
                g.FillRectangle(dopBr, _startPosX + 80, _startPosY + 10, 40, 5);
            }    
        }
    }
}
