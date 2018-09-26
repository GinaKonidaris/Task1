using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE18013130
{
    class Map
    {
        int[,] map = new int[20, 20];
        MeleeUnit[] Meleeunits = new MeleeUnit[10];
        RangedUnit[] rangedunits = new RangedUnit[10];
        const int STEP = 128;
        const int MAX_STEP = 5;
        int current_step = 5;
        bool ismovingright = true;

        public int RandomUnits()
        {
            Random r = new Random();

            return r.Next(1, 20);
        }

        public int Update()
        {
            int Ypostion = 1 ;
            while (RandomUnits() > 0)
            {             
                for (int i = 0; i < 5; i++)
                {
                    int Xpostion = 20;
                    for (int k = 0; k < 50; i++)
                    {
                        Xpostion = Xpostion + 50;
                    }
                    Ypostion = Ypostion + 50;
                }
            }
            return Ypostion = 2;
        }
    }
    //El0ei
}
