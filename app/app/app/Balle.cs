using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing; 
namespace app
{
   
    class Balle
    {
        PictureBox balleImage = new PictureBox();
        
        Timer balleTimer;
        int vitesse;
        static Image balleAttrape = Properties.Resources.BalleAttrape;
        bool attrape=false; 

        public Balle(int x,int y,int vitesse,bool attrape=false)
        {
            balleImage.SizeMode = PictureBoxSizeMode.Zoom;
            balleImage.Image = Properties.Resources.Balle;
            balleTimer = new Timer();
            balleTimer.Tick += BalleTimer_Tick;
            balleTimer.Interval = vitesse; 
            balleTimer.Start();
            this.balleImage.Left = x;
            this.balleImage.Top = y; 
            this.Vitesse = vitesse;  
            this.Attrape = attrape;
            balleAttrape.Tag = "balleAttrape";
            Program.f.Controls.Add(balleImage);
        }

     

        public PictureBox BalleImage { get => balleImage; set => balleImage = value; }
        public Timer BalleTimer { get => balleTimer; set => balleTimer = value; }
        public int Vitesse { get => vitesse; set => vitesse = value; }
        public bool Attrape { get => attrape; set
            {   if (value)
                    balleImage.Image = balleAttrape; 
            } 
        }


        private void BalleTimer_Tick(object sender, EventArgs e)
        {
            balleImage.Top -= Vitesse;
            bool etat = Collision();
            if (balleImage.Top <= 0 || etat)
            {   
                Program.f.Controls.Remove(balleImage);
                balleTimer.Stop(); balleTimer.Dispose();
                balleTimer = null;   
            }
                
        }
        public bool Collision()
        { 
            foreach (Control item in Program.f.Controls)
            {
                if (balleImage.Image!=balleAttrape && balleImage.Bounds.IntersectsWith(item.Bounds) && ((string)item.Tag=="cible" || (string)item.Tag == "cible_bonus"))
                {
                   
                    item.Tag = "touche"; 
                    return true;
               
                }else if ((string)balleImage.Image.Tag == "balleAttrape" && balleImage.Bounds.IntersectsWith(item.Bounds) && (string)item.Tag == "cible_bonus")
                {   
                    item.Tag = "gagne";
                    return true;
                }
            }
            return false;
        }
    }
}
