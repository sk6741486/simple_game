using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simple_game
{
    public partial class s : Form
    {
        Class_Game Class_obj = new Class_Game();
        public s()
        {
            InitializeComponent();
        }

        private void LOAD_Click(object sender, EventArgs e)
        {
            //code to display image in picture box on button click  

            Assembly myAssembly = Assembly.GetExecutingAssembly();

            Stream myStream = myAssembly.GetManifestResourceStream("simple_game.Resources.newload.gif");

            Bitmap bmp_Object = new Bitmap(myStream);

            PICTURESHOW.Image = bmp_Object;

            System.Media.SoundPlayer Sound_Object = new System.Media.SoundPlayer(Properties.Resources.gun_cocking_01);

            Sound_Object.Play();

            Class_obj.load();
            spin_btn.Enabled = true;
            load_btn.Enabled = false;
        }

        private void SPIN_Click(object sender, EventArgs e)
        {

        //code to display image in picture box on button click  

         Assembly myAssembly = Assembly.GetExecutingAssembly();

         Stream myStream = myAssembly.GetManifestResourceStream("simple_game.Resources.newspin.gif");

         Bitmap bmp_Object = new Bitmap(myStream);

         PICTURESHOW.Image = bmp_Object;

            System.Media.SoundPlayer Sound_Object = new System.Media.SoundPlayer(Properties.Resources.gun_cocking_01);

            Sound_Object.Play();



            MessageBox.Show(Class_obj.spin().ToString());

            spin_btn.Enabled = false;
            shoot_btn.Enabled = true;
            shootaway_btn.Enabled = true;


        }

        private void SHOOT_Click(object sender, EventArgs e)
        {
            //code to display image in picture box on button click  

            Assembly myAssembly = Assembly.GetExecutingAssembly();

            Stream myStream = myAssembly.GetManifestResourceStream("simple_game.Resources.newonhead.gif");

            Bitmap bmp_Object = new Bitmap(myStream);

            PICTURESHOW.Image = bmp_Object;

            System.Media.SoundPlayer Sound_Object = new System.Media.SoundPlayer(Properties.Resources.gun_gunshot_01);

            Sound_Object.Play();

            if (Class_obj.shoot() == 0)
            {
                MessageBox.Show("Try again");
            }
           else
            {
                MessageBox.Show("Please restart the game");
                    
            }


        }

        private void SHOOT_AWAY_Click(object sender, EventArgs e)
        {
            //code to display image in picture box on button click  

            Assembly myAssembly = Assembly.GetExecutingAssembly();

            Stream myStream = myAssembly.GetManifestResourceStream("simple_game.Resources.inair.gif");

            Bitmap bmp_Object = new Bitmap(myStream);

            PICTURESHOW.Image = bmp_Object;
            System.Media.SoundPlayer Sound_Object = new System.Media.SoundPlayer(Properties.Resources.gun_gunshot_01);

            Sound_Object.Play();

            if (Class_obj.chance < 2)
            {
                if (Class_obj.shoot() == 0)
                    MessageBox.Show("wow!! You win the game");
                    shoot_btn.Enabled = false;
                    shootaway_btn.Enabled = false;
            }
            else
            {
                Class_obj.chance++;
                if (Class_obj.chance == 2)
                {
                    MessageBox.Show("Play Again");
                    shoot_btn.Enabled = false;
                    shootaway_btn.Enabled = false;

                }
                else
                {
                    MessageBox.Show("Builts are finished");
                }
            }
        }

        private void PLAY_AGAIN_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
