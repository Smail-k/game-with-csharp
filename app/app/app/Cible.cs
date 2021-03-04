using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms; 
namespace app
{
    abstract class Cible
    {
        int x, y;
        int vitesse;
        int vitesseX;
        PictureBox cibleImage;
        int bonus;
        Timer CibleTimer; 


        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public PictureBox CibleImage { get => cibleImage; set => cibleImage = value; }
        public int Bonus { get => bonus; set => bonus = value; }
        public int Vitesse { get => vitesse; set => vitesse = value; }
        public int VitesseX { get => vitesseX; set => vitesseX = value; }

        public Cible(int vitesse, int vitesseX)
        {
            Random randNum = new Random();
            X = randNum.Next(0, 900);
            Y = 0;
            cibleImage = new PictureBox();
            cibleImage.SizeMode = PictureBoxSizeMode.StretchImage;
            cibleImage.Size = new Size(80, 80);
            cibleImage.Tag = "cible";
            cibleImage.MouseClick += CibleImage_MouseClick;
            
            Bonus = randNum.Next(5, 20);
           
            this.vitesse = vitesse;
            this.vitesseX = vitesseX* randNum.Next(-1, 2);//[-1,1] -1 0 1 
            CibleTimer = new Timer();
            CibleTimer.Tick += CibleTimer_Tick;
            CibleTimer.Start(); 
        }

        private void CibleTimer_Tick(object sender, EventArgs e)
        {
            CibleImage.Top = Y;
            CibleImage.Left = X;
            Comportement();
            this.Y += Vitesse;
            if ((string)CibleImage.Tag != "detruite")
                X += VitesseX;
            else if((string)CibleImage.Tag == "gagner")
            {
                CibleTimer.Stop();
                CibleTimer.Dispose();
                CibleTimer = null;
            }
            if (this.FinTrajetVertical())
            {
                Program.f.Controls.Remove(this.CibleImage);
                CibleTimer.Stop();
                CibleTimer.Dispose();
                CibleTimer = null;
                CibleImage = null; 
            }
            else if (this.FinTrajetHorizontal())
            {   
                if (X >= 920 || X <= 0)
                {
                    VitesseX = -VitesseX;
                }
            }
        }

        private void CibleImage_MouseClick(object sender, MouseEventArgs e)
        {
            Joueur.JoueurImage.Left = this.X;
            Joueur.X = this.X;
            if (e.Button == MouseButtons.Left)
            {
                Balle balle = new Balle(Joueur.X, 450, 30);
                Program.f.Controls.Add(balle.BalleImage);
            }
            else if (e.Button == MouseButtons.Right)
            {
                Balle balle = new Balle(Joueur.X, 450, 30,true);
                Program.f.Controls.Add(balle.BalleImage);
            }
        }
        public bool FinTrajetVertical()
        {
            if(Y>=600)
                return true;
            return false; 
        }
        public bool FinTrajetHorizontal()
        {
            if (X >= 920 || X<=0)
                return true;
            return false;
        }

        public abstract void Comportement(); 

    }
}
