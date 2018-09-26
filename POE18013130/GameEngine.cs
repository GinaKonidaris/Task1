using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POE18013130
{
    class GameEngine :Map
    {
        MeleeUnit[] Meleeunits = new MeleeUnit[20];
        RangedUnit[] rangedunits = new RangedUnit[20];
        Random r = new Random();


        Timer timer = new Timer();

        private void timer1_Tick(object sender, EventArgs e)
        {
            Unit[] units = new Unit[20];
          
            Random r = new Random();

            if (sender == timer)
            {
                timer.Interval = (1000) * (1);
            }
        }

        void Combat()
        {
            for(int i = 0; i<20; i++)
            {
                double Value = r.Next();

                for (int k = +i; k < 20; k++)
                {
                    if (Value > 0 && Value <= 0.25)
                    {
                        MeleeUnit swordperson = new MeleeUnit();
                        swordperson.Damage = 10;
                        Meleeunits[i] = swordperson;

                    }
                    else if(Value > 0.25 && Value <= 0.5)
                    {
                        RangedUnit archer = new RangedUnit();
                        archer.Damage = 10;
                        archer.Range = 5;
                        rangedunits[i] = archer;
                    }                   
                }
            }
        }
    }
    //El0ei
}
