using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BelyaevaTank
{
    public class ArmoredCar : Vehicle, IEquatable<ArmoredCar>
    {
        protected readonly int tankWidth = 120;
        protected readonly int tankHeight = 60;
        protected readonly char separator = ',';

        public ArmoredCar(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }

        public ArmoredCar(string info) 
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 3) 
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromArgb(Convert.ToInt32(strs[2]));
            }
        }

        protected ArmoredCar(int maxSpeed, float weight, Color mainColor, int tankWidth, int tankHeight)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            this.tankWidth = tankWidth;
            this.tankHeight = tankHeight;
        }

        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
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

        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Green);

            Brush mainBr = new SolidBrush(MainColor);
            Brush empty = new SolidBrush(Color.White);
            //track
            g.FillRectangle(mainBr, _startPosX, _startPosY + 35, 110, 30);
            g.FillEllipse(mainBr, _startPosX - 10, _startPosY + 35, 30, 30);
            g.FillEllipse(mainBr, _startPosX + 90, _startPosY + 35, 30, 30);
            //wheels
            g.FillEllipse(empty, _startPosX + 2, _startPosY + 40, 15, 15);
            g.FillEllipse(empty, _startPosX + 27, _startPosY + 45, 10, 10);
            g.FillEllipse(empty, _startPosX + 49, _startPosY + 45, 10, 10);
            g.FillEllipse(empty, _startPosX + 71, _startPosY + 45, 10, 10);
            g.FillEllipse(empty, _startPosX + 93, _startPosY + 40, 15, 15);
            //upper part whatever this is
            g.FillRectangle(mainBr, _startPosX + 5, _startPosY + 25, 100, 10);
            g.FillRectangle(mainBr, _startPosX + 30, _startPosY + 10, 50, 30);
            //additional part for upper parts
            g.FillRectangle(empty, _startPosX + 40, _startPosY + 15, 30, 10);

        }

        public override string ToString()
        {
            string color = Convert.ToString(MainColor.ToArgb());
            return $"{MaxSpeed}{separator}{Weight}{separator}{color}";
        }

        public bool Equals(ArmoredCar other) 
        {
            if (other == null) 
            {
                return false;
            }
            if (GetType().Name != other.GetType().Name) 
            {
                return false;
            }
            if (MaxSpeed != other.MaxSpeed) 
            {
                return false;
            }
            if (Weight != other.Weight) 
            {
                return false;
            }
            if (MainColor != other.MainColor) 
            {
                return false;
            }
            return true;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null) 
            { 
                return false;
            }
            if (!(obj is ArmoredCar armoredCarObj))
            {
                return false;
            }
            else 
            {
                return Equals(armoredCarObj);
            }
        }
    }
}
