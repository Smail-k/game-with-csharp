using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Media;

namespace app
{
    class CibleExplosiveTaille : CibleExplosive
    {
        
         
        public CibleExplosiveTaille(int vitesse,int vitesseX):base(vitesse,vitesseX)
        {
            
            CibleImage.Image = Properties.Resources.CibleExpTaille;

            CibleImage.Top = Y;
            CibleImage.Left = X;
            
        }

        

        public override void Comportement()
        {
            if ((string)this.CibleImage.Tag == "touche")
            {
                CibleImage.Left = X;
                CibleImage.Top = Y;

                this.Degat += 30;
                CibleImage.Size = new Size(CibleImage.Height - 15, CibleImage.Width - 15);
                

                this.CibleImage.Tag = "cible";
                if (this.Degat == 90)
                {
                    if (Transformable)
                    {
                        Program.f.Controls.Remove(CibleImage);//supprimer l'ancienne cible explosive
                        CibleBonus Cibleb = new CibleBonus(X, Y, Vitesse, VitesseX);
                        Program.f.Controls.Add(Cibleb.CibleImage);
                    }
                    else
                    {
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
