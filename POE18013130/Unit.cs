using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE18013130
{
    abstract class Unit
    {

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

        private int Health;

        public int health
        {
            get { return Health; }
            set { Health = value; }
        }

        private int Speed;

        public int speed
        {
            get { return Speed; }
            set { Speed = value; }
        }

        private int Attack;

        public int attack
        {
            get { return Attack; }
            set { Attack = value; }
        }
        private int AttackRange;

        public int attackrange
        {
            get { return AttackRange; }
            set { AttackRange = value; }
        }

        private string Team;

        public string team
        {
            get { return Team; }
            set { Team = value; }
        }

        private void DisplayImage()
        {

        }

        private bool Isdead()
        {
            return false;
        }

        public class Alive
        {
            public bool isInitialized;
            public Alive()
            {
                isInitialized = true;
            }
        }

        abstract public int Move();
       
        private int damage;

        protected int combat;
        abstract public int CalDamage();
        public int ReturnPostion()
        {
            if (xpostion > ypostion)
            {
                return xpostion;
            }
            else if( ypostion > xpostion)
            {
                return ypostion;
            }
            return xpostion - ypostion;
        }

        public override string ToString()
        {
            return health.ToString();
        }
    }
    //El0ei
}
