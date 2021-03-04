using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace app
{
    class Jeu : Form 
    {
        Joueur joueur;
        Timer GameTimer;
        Balle balle;
        Label Score;
        Label Time;
        Label LabelNiveau;
        int miliseconde=0;
        int seconde=15;
        int minute=0;
        static int cibleCompteur=0;
        int intervalle=0;
        int compteur=0;
        int vitesseCibles;
 
        public static int CibleCompteur { get => cibleCompteur; set => cibleCompteur = value; }
        internal Joueur Joueur { get => joueur; set => joueur = value; }

        public Jeu()
        {   
            this.Size = new Size(1000, 600);
            this.BackColor= ColorTranslator.FromHtml("#272d42");
            this.MaximumSize = this.Size;

            Joueur = new Joueur();
            Score = new Label();
            Time = new Label();
            GameTimer = new Timer();
            LabelNiveau = new Label();
             

            MouseMove += Jeu_MouseMove1;
            GameTimer.Tick += GameTimer_Tick1;
            MouseClick += Jeu_MouseClick;

            //entete :  

            Score.Font= new Font("Arial", 15, FontStyle.Bold);
            Score.Size = new Size(150, 50);
            Time.Font = new Font("Arial", 15, FontStyle.Bold);
            Time.Size = new Size(200, 50);
            Time.Location = new Point(0, 0);
            Score.BackColor = Color.Transparent;
            LabelNiveau.ForeColor = Color.Green; 

            LabelNiveau.Font = new Font("Arial", 15, FontStyle.Bold);
            LabelNiveau.Size = new Size(150, 50);
            LabelNiveau.Location = new Point(400, 0);
        }
        public void CommencerJeu()
        {
            GameTimer.Start();
        }
       

        private void Jeu_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                balle = new Balle(Joueur.JoueurImage.Left-10, Joueur.JoueurImage.Top+20,30);
                Controls.Add(balle.BalleImage);     
            }
            else if (e.Button == MouseButtons.Right)
            {
                balle = new Balle(Joueur.JoueurImage.Left-10, Joueur.JoueurImage.Top + 20, 30,true);
                Controls.Add(balle.BalleImage);
            }
        }
        public void init()
        {
            if (!Controls.Contains(Joueur.JoueurImage))
            {
                Controls.Add(Joueur.JoueurImage);
                Joueur.BarDeVie(); Score.Location = new Point(600, 0); Controls.Add(Score);
                Time.Location = new Point(100, 0); Controls.Add(Time); Controls.Add(LabelNiveau);
            }
            Score.ForeColor = Color.Black;
            if (Partie.Niveau == Niveau.level1)
            {
                intervalle = 30; vitesseCibles = 10; 
            }
                
            if (Partie.Niveau == Niveau.level2)
            {
                intervalle = 20; vitesseCibles = 12;
            }
            if (Partie.Niveau == Niveau.level3)
            {
                intervalle = 15; vitesseCibles = 14;
            }
            if (Partie.Niveau == Niveau.level4)
            {
                intervalle = 10; vitesseCibles = 18;
            }
            
        }
       

        private void GameTimer_Tick1(object sender, EventArgs e)
        {
            
            PrintScore_Time();
            joueur.Collision();
             
            TempsPartie(); 
        }
        private void PrintScore_Time()
        {
            Score.Text = "SCORE : " + Joueur.Score;
            if (Joueur.Score >= Partie.ScorePartie)
                Score.ForeColor = Color.Green; 
            Time.Text = "Temps : " + minute + " : " + seconde + " : " + miliseconde;
            
            LabelNiveau.Text = Partie.Niveau.ToString();
            
        }
 

        private void Jeu_MouseMove1(object sender, MouseEventArgs e)
        {
            if (e.X <= 950)
            {
                Joueur.JoueurImage.Left = e.X-25;
                Joueur.X = e.X - 25;
            }

        }
        
        private void TempsPartie()
        {
            miliseconde-=1; compteur++; 
            if (miliseconde <= 0)
            {
                seconde-=1;
                miliseconde = 60;
            }

            
            if(minute==0 && seconde <= 5)
            {
                Time.ForeColor = Color.Red; 
            }
            
            if (seconde<0 || joueur.Mort() || Joueur.Score<0 || Joueur.Score>=Partie.ScorePartie)
            {
                SupprimerCibles(); GameTimer.Stop();   

                if (!Partie.FinPartie())
                {
                    GameTimer = null;
                    GameTimer = new Timer();
                    GameTimer.Tick += GameTimer_Tick1;
                    GameTimer.Start();
                    init(); 
                    joueur.Init();
                    InitDurePartie();
                }
            }
            //generer les cibles 

            if (compteur == intervalle)
            {
                Random randNum = new Random();
                
                compteur = 0;
                int choice = randNum.Next(1, 5);
                if (choice == 1)
                    Controls.Add(new CibleBonus(vitesseCibles, vitesseCibles).CibleImage);
                else if (choice == 2)
                    Controls.Add(new CibleExplosiveTaille(vitesseCibles, vitesseCibles).CibleImage);
                else if (choice == 3)
                    Controls.Add(new CibleExplosiveVitesse(vitesseCibles, vitesseCibles).CibleImage);
                else if (choice == 4)
                    Controls.Add(new CibleExplosive(vitesseCibles, vitesseCibles).CibleImage);

            }

        }
        private void InitDurePartie()
        {
            miliseconde = 0;
            seconde = 15;
            minute = 0; 
        }

        private void SupprimerCibles()
        {
            foreach (Control item in this.Controls)
            {
                if ((string)item.Tag == "cible" || (string)item.Tag == "cible_bonus" || (string)item.Tag == "touche" || (string)item.Tag == "detriute")
                {
                    this.Controls.Remove(item);
                    Control cible = item;
                    cible = null; 
                }
                  
            }
        }


    }
}
