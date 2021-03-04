using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace app
{
    class CibleExplosiveVitesse : CibleExplosive
    {
        
       
        
        public CibleExplosiveVitesse(int vitesse,int vitesseX):base(vitesse,vitesseX)
        {
            
            CibleImage.Image = Properties.Resources.cibleExpVitesse;
            //CibleImage.Tag = "cible";
            
            
        }

        

        public override void Comportement()
        {
            if ((string)this.CibleImage.Tag == "touche")
            {
                CibleImage.Left = X;
                CibleImage.Top = Y;

                this.Degat += 30;
                Vitesse-=3; 

                this.CibleImage.Tag = "cible";
                if (this.Degat == 90)
                {
                    if (Transformable)
                    {
                        Program.f.Controls.Remove(CibleImage);
                        CibleBonus Cibleb = new CibleBonus(X, Y,Vitesse+9,VitesseX);
                        Program.f.Controls.Add(Cibleb.CibleImage);
                    }
                    else {
                        Joueur.Score += Bonus;
                        CibleImage.Size = new Size(80, 80);
                        this.CibleImage.Image = Properties.Resources.explo;
                        CibleImage.Tag = "detruite";
                        Vitesse += 9;
                        }
                     
                }
               
            }else if((string)CibleImage.Tag=="detruite")
                CibleImage.Size = new Size(CibleImage.Height -1, CibleImage.Width - 1);

        }

        
    }
}
