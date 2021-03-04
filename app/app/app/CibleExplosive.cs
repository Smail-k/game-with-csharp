using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing; 
namespace app
{
    class CibleExplosive : Cible
    {
        int degat;
        bool transformable = false;
        
            
        public int Degat { get => degat; set => degat = value; }
        public bool Transformable { get => transformable; set => transformable = value; }

        public CibleExplosive(int vitesse, int vitesseX):base(vitesse,vitesseX)
        {
            Degat = 0;
            Random randNum = new Random();
            Bonus = randNum.Next(5, 20);
            CibleImage.Image = Properties.Resources.CibleExplosive1;
            CibleImage.Left = X;
            CibleImage.Top = 0;
            if (randNum.Next(0, 6) == 5)
                Transformable = true;
         
            
        }

        

        public override void Comportement()
        {
            if ((string)this.CibleImage.Tag == "touche")
            {
                CibleImage.Left = X;
                CibleImage.Top = Y;

                this.Degat += 30;
                

                this.CibleImage.Tag = "cible";
                if (this.Degat == 90)
                {
                    if (this.Transformable)
                    {
                        Program.f.Controls.Remove(CibleImage);
                        CibleBonus Cibleb = new CibleBonus(X, Y, Vitesse, VitesseX);
                        Program.f.Controls.Add(Cibleb.CibleImage);
                    }
                    else
                    {
                        Console.WriteLine("hnaaa");
                        Joueur.Score += Bonus;
                        CibleImage.Size = new Size(80, 80);
                        this.CibleImage.Image = Properties.Resources.explo;
                        CibleImage.Tag = "detruite";
                    }

                }

            }
            else if ((string)CibleImage.Tag == "detruite")
                CibleImage.Size = new Size(CibleImage.Height - 1, CibleImage.Width - 1);

        }



    }
}
