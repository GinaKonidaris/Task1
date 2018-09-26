using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POE18013130
{
    class RangedUnit : Unit
    {

        private int range;

        public int Range
        {
            get { return range; }
            set { range = value; }
        }

        private int damage;
        public int Damage
        {
            get { return damage; }
            set { damage = value; }
        }

        public override int CalDamage()
        {
            return Damage - Range;
        }

        private int xpostion;

        public int Xpostion
        {
            get { return xpostion; }
            set { xpostion = value; }
        }

        private int ypostion;

        public int Ypostion
        {
            get { return ypostion; }
            set { ypostion = value; }
        }

        public void DisplayImage()
        {
            PictureBox myPicture = new PictureBox();

            myPicture.Width = 400;
            myPicture.Height = 400;

        }
        public override int Move()
        {
            if (xpostion > ypostion)
            {
                return xpostion - attackrange;
            }
            else if (xpostion < ypostion)
            {
                return xpostion + attackrange;
            }
            return attackrange;
        }
        private bool Isdead()
        {
            return false;
        }
    }
    //El0ei
}
