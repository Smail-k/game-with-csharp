using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace app
{
    class CibleBonus : Cible
    {

         
        public CibleBonus(int vitesse,int vitesseX=0):base(vitesse,vitesseX)
        {
            
            CibleImage.Size = new Size(50, 50);
            CibleImage.Image = Properties.Resources.bonus;
            Random randNum = new Random();
            X = randNum.Next(0, 900);
            CibleImage.Left = X;
            Bonus = randNum.Next(10, 25);//modifier le bonus (car c'est une cible specifique au bonus) 
            
            CibleImage.Tag = "cible_bonus";
            
        }
        public CibleBonus(int x,int y,int vitesse, int vitesseX) : base(vitesse, vitesseX)
        {
            CibleImage.Size = new Size(50, 50);
            CibleImage.Image = Properties.Resources.bonus;
            Random randNum = new Random();
            X = x;
            Y = y;
            CibleImage.Left = X;
            CibleImage.Top = Y;
            Bonus = randNum.Next(10, 25);
            
            CibleImage.Tag = "cible_bonus";
  
        }
       

        public override void Comportement()
        {
            if ((string)this.CibleImage.Tag == "touche")
            {
                this.CibleImage.Tag = "detruite";
                Joueur.Score -= Bonus;
                
                Program.f.Controls.Remove(this.CibleImage);
            }
            else if ((string)this.CibleImage.Tag == "gagne")
            {
                this.CibleImage.Tag = "detruite";
                Joueur.Score += Bonus;
            
                Program.f.Controls.Remove(this.CibleImage);
            }
        }

        


    }
}
