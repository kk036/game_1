using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game_1
{
    public class Class1
    {
        public int RNDNumber { get; set; }
        public string Win { get; set; }
        public string Loose { get; set; }
        public int btn_Shoot { get; set; }
        public int btn_ShootAway { get; set; } = 2;
        public int Winscore { get; set; } = 0;
        public int Losescore { get; set; } = 0;
        public string Messagebox { get; set; }

        public int RNDNumbergenerate()
        {
            Random myrandom = new Random();
            return myrandom.Next(1, 7);

        }
        public string Wingame()
        {
            Win = "you win";
            return Win;
        }
        public string Loosegame()
        {
            Loose = "you Loose";
            return Loose;
        }
        public string Messageboxgame()
        {
            MessageBox.Show("you win");
            return Messagebox;
        }
        public int Shoot()
        {
            btn_Shoot++;
            if (btn_Shoot > 6)
            {
                MessageBox.Show("all shoots finish no more");
                btn_Shoot = 0;
            }
            return btn_Shoot;
        }
        public int Shootaway()
        {
            btn_ShootAway--;
            if (btn_ShootAway < 0)
            {
                MessageBox.Show("no more shoots");
                btn_ShootAway = 2;
            }
            return btn_ShootAway;






        }
    }
}

