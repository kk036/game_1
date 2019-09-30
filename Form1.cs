using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace game_1
{
    public partial class Form1 : Form
    {
        Class1 bandook = new Class1();
       
        public Form1()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        //internal void show()
        //{
          //  throw new NotImplementedException();
        //}
        // below code is for load the gun//
        private void Btn_Load_Click(object sender, EventArgs e)
        {
            //bandook.Load();
            btn_Load.Enabled = false;
             btn_Spin.Enabled = true;
            btn_Shoot.Enabled = false;
            btn_ShootAway.Enabled = false;

            //below code is for the image
           // Assembly myAssembly = Assembly.GetExecutingAssembly();
            //Stream myStream = myAssembly.GetManifestResouresStream(game_2.Resource.load);
            //Bitmap bmp = new Bitmap(mystream);

            var bmp_2 = new Bitmap(game_1.Properties.Resources1.load);


            //pictureBox1.Image = img;

            //below code is for load the image
           // Image img = Image.FromFile("game_1.Resources1.load2.gif");
            pictureBox1.Image = bmp_2;
            
            // below code is for load the sound
            SoundPlayer player = new SoundPlayer(Resource1.load1);
            player.Play();
        }
        //below coding is for spin button //
        private void Btn_Spin_Click(object sender, EventArgs e)
        {
           // bandook.Spin();
            btn_Load.Enabled = false;
            btn_Spin.Enabled = false;
            btn_Shoot.Enabled = true;
            btn_ShootAway.Enabled = true;

             //below code is for the image
            //Assembly myAssembly = Assembly.GetExecutingAssembly();
            //Stream myStream = myAssembly.GetManifestResouresStream(game_2.Resource\spin.gif);
            //Bitmap bmp = new Bitmap(mystream);

            var bmp_2 = new Bitmap(game_1.Properties.Resources1.spin);


            pictureBox1.Image = bmp_2;


            //below code is for spin the image
            //Image img = Image.FromFile("game_1.Resources.spin.gif");
            pictureBox1.Image = bmp_2;
            // below code is for spin the sound
            SoundPlayer player = new SoundPlayer(Resource1.spin1);
            player.Play();
        }
          //below code is for shoot button//
        private void Btn_Shoot_Click(object sender, EventArgs e)
        {
            bandook.Shoot();
            btn_Load.Enabled = false;
            btn_Spin.Enabled = false;
            btn_Shoot.Enabled = true;
            btn_ShootAway.Enabled = true;

             //below code is for the image
            //Assembly myAssembly = Assembly.GetExecutingAssembly();
            //Stream myStream = myAssembly.GetManifestResouresStream(game_2.Resource\shoot.gif);
            //Bitmap bmp = new Bitmap(mystream);

            var bmp_2 = new Bitmap(game_1.Properties.Resources1.shoot);


            pictureBox1.Image = bmp_2;
            

            //below code is for shoot the image
            //Image img = Image.FromFile("game_1.Resource1.bullet.gif");
            pictureBox1.Image = bmp_2;
            //Image img2 = Image.FromFile("game_1.Resource1.mx.jpg");

            pictureBox2.Image = bmp_2;
            // below code is for shoot the sound
           SoundPlayer player = new SoundPlayer(Resource1.shoot1);
            player.Play();
            bandook.btn_Shoot = bandook.Shoot();
            lblshots.Text = bandook.btn_Shoot.ToString();

        }
        
        //below code is for shootaway button//
        private void Btn_ShootAway_Click(object sender, EventArgs e)
        {
            bandook.Shootaway();
            btn_Load.Enabled = false;
            btn_Spin.Enabled = false;
            btn_Shoot.Enabled = true;
            btn_ShootAway.Enabled = true;

             //below code is for the image
            //Assembly myAssembly = Assembly.GetExecutingAssembly();
            //Stream myStream = myAssembly.GetManifestResouresStream(game_2.Resource\shootAway.gif);
            //Bitmap bmp = new Bitmap(mystream);

            Bitmap bmp_2 = new Bitmap(game_1.Properties.Resources1.shoot);


            pictureBox1.Image = bmp_2;


            //below code is for shootaway the image
           // Image img = Image.FromFile("game_1.Resource1.shot.gif");
            pictureBox1.Image = bmp_2;
            //Image img2 = Image.FromFile("game_1.Resource1.sky.gif");

            pictureBox2.Image = bmp_2;
          // below code is for shootawaythe sound
            SoundPlayer player = new SoundPlayer(Resource1.shoot1);
            player.Play();
            bandook.btn_ShootAway = bandook.Shoot();
            lbllivs.Text = bandook.btn_ShootAway.ToString();

        }
        // below coding for playagain
        private void Btn_PlayAgain_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            btn_Load.Enabled = true;
            btn_Spin.Enabled = false;
            btn_Shoot.Enabled = false;
            btn_ShootAway.Enabled = false;
        }
        
        // code below for load //
        private void Form1_Load(object sender, EventArgs e)
        {
            btn_Spin.Enabled = false;
            btn_Shoot.Enabled = false;
            btn_ShootAway.Enabled = false;
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }
        //below coding for exit buton 
        private void Exit_Click(object sender, EventArgs e)
        {
            {
                this.Close();
            }
            {
                btn_Spin.Enabled = false;
                btn_Shoot.Enabled = false;
                btn_ShootAway.Enabled = false;
            }

        }
        private void Endgame_check()
        {
            if (lblshots.Text == bandook.RNDNumber.ToString()) 
            {
                bandook.Loose = bandook.Loosegame();
                lblshots.Text = bandook.Losescore.ToString();
                btn_Shoot.Enabled = false;
                btn_Load.Enabled = false;
                btn_Spin.Enabled = false;
                btn_PlayAgain.Enabled = false;
                btn_Exit.Enabled = false;
                bandook.Losescore++;
                lblshots.Text = bandook.Losescore.ToString();
            }
        }
        private void Fireattempt()
            {
                if (lblshots.Text == bandook.RNDNumber.ToString())
                {
                bandook.Losescore--;
                    Endgame_check();

                }
               
            }
        private void ShootAway()
            {
                bandook.Winscore++;
                lblshots.Text = bandook.Winscore.ToString();
            }
        }


       

       
       

        
    }
