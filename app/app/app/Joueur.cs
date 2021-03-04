using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing; 

namespace app
{
    enum Etat
    {
        EnVie,mort
    }
    class Joueur
    {
         string nom;
        Etat etatJoueur; 
        static int vie;
        static PictureBox joueurImage=new PictureBox();
        static int score;
        static int x, y;
        static ProgressBar HealthBar; 
        
        public Joueur()
        {
            Vie = 100;
            Score = 0;
            etatJoueur = Etat.EnVie;
            joueurImage.Size = new Size(100, 100);
            joueurImage.SizeMode = PictureBoxSizeMode.Zoom;
            joueurImage.Left = 480;
            joueurImage.Top = 450;
            JoueurImage.Image = Properties.Resources.Joueur;
            joueurImage.MouseClick += JoueurImage_MouseClick;
            
        }

  

        private void JoueurImage_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Balle balle = new Balle(Joueur.JoueurImage.Left + 25, Joueur.JoueurImage.Top + 20, 30);
                Program.f.Controls.Add(balle.BalleImage);
            }
        }
        public static int Vie { get => vie; set => vie = value; }
        public static PictureBox JoueurImage { get => joueurImage; set => joueurImage = value; }
        public PictureBox JoueurImagee { get => joueurImage; set => joueurImage = value; }

        public static int Score { get => score; set => score = value; }
        public static int X { get => x; set => x = value; }
        public static int Y { get => y; set => y = value; }
        public  string Nom { get => nom; set => nom = value; }

        public void Collision()
        {
            foreach (Control item in Program.f.Controls)
            {
                if((string) item.Tag == "cible" && this.JoueurImagee.Bounds.IntersectsWith(item.Bounds))
                {
                    vie -= 1;
                    HealthBar.Increment(-1);
                    if (HealthBar.Value == 0)
                        etatJoueur = Etat.mort;
                }
            }
        }
        public void Mouvement(int x)
        {
            joueurImage.Left = x; 
            
        }
        public void BarDeVie()
        {
            if (HealthBar == null)
            {
                HealthBar = new ProgressBar();
                HealthBar.Value = 100;
                HealthBar.ForeColor = Color.Red;
                HealthBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
                HealthBar.Location = new Point(780, 3);
                HealthBar.Width = 200;
                HealthBar.Height = 20;
                Program.f.Controls.Add(HealthBar);
            }

        }
        public void Init()
        {
            Vie = 100;
            Score = 0;
            HealthBar.Value = 100;
        }
        public bool Mort()
        {
            if (etatJoueur == Etat.EnVie)
                return false;
            else 
                return true; 
        }


    }
}
