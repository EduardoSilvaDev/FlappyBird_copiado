using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlapBird
{
    public partial class flapbird : Form
    {
        int pipeSpeed = 5;
        int gravity = 5;
        int score = 0;
        Random random = new Random();
        int auxrnd;
        public flapbird()
        {
            InitializeComponent();
            auxrnd = random.Next(1, 180);
        }


        private void gameTimerEvents(object sender, EventArgs e)
        {
            bird.Top += gravity;
            pipetop.Left -= pipeSpeed;
            pipebuttom.Left -= pipeSpeed;
            lb_score.Text = "SCORE: " + score + "rnd: " + auxrnd;

            if (pipebuttom.Left < -50)
            {
                pipebuttom.Left = 400;
                pipetop.Left = 400;
                score++;

                auxrnd = random.Next(150);


                pipetop.Size = new Size(pipetop.Size.Width, 70+auxrnd);
                
                pipebuttom.Location = new Point(pipebuttom.Location.X, 170+auxrnd);
                //Height = auxrnd;
                
            }
            if (bird.Bounds.IntersectsWith(pipebuttom.Bounds) ||
                bird.Bounds.IntersectsWith(pipetop.Bounds) ||
                bird.Bounds.IntersectsWith(ground.Bounds) ||
                bird.Top < -25
                )
            {
                endGame();
            }
        }

        private void gamekeyisDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -5;
                bird.Image = FlapBird.Properties.Resources.up;
            }
        }

        private void gamekeyisUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) gravity = 5;
            bird.Image = FlapBird.Properties.Resources.down;
        }
        private void flapbird_Load(object sender, EventArgs e)
        {
            bird.Image = FlapBird.Properties.Resources.stop;
        }
        private void endGame()
        {
            gameTimer.Stop();
            lb_score.Text += "    GAME OVER";

            if(MessageBox.Show("Jogar Novamente?", "GAME OVER", MessageBoxButtons.YesNo, MessageBoxIcon.None) == DialogResult.Yes)
            {
                gameTimer.Start();
                pipetop.Left = 400;
                pipebuttom.Left = 400;
                score = 0;
                
                bird.Location = new Point(10,100);
            }
            else 
            {
                Application.Exit();
            }
        }


        private void previerKeyDown_func(object sender, PreviewKeyDownEventArgs e)
        {

        }
    }
}
