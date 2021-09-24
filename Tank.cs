using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BelyaevaTank
{
    public class Tank : ArmoredCar
    {
        public Color DopColor { private set; get; }
        public bool Tower { private set; get; } // наличие башни у танка
        public bool Weapon { private set; get; } // наличие оружия у танка

        public Tank(int maxSpeed, float weight, Color mainColor, Color dopColor,
            bool tower, bool weapon) : base(maxSpeed, weight, mainColor, 120, 60) 
        {
            DopColor = dopColor;
            Tower = tower;
            Weapon = weapon;
        }
        public override void DrawTransport(Graphics g) 
        {
            Brush dopBr = new SolidBrush(DopColor);

            if (Tower)
            {
                //one more additional part but upper and behind these 2 which are under
                g.FillEllipse(dopBr, _startPosX + 31, _startPosY + 5, 45, 30);
            }

            base.DrawTransport(g);

            if (Weapon)
            {
                //additional part
                g.FillRectangle(dopBr, _startPosX + 80, _startPosY + 10, 40, 5);
            }    
        }
    }
}
