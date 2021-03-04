using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    public partial class MenuFinPartie : Form
    {
        private bool continuer = false;
        private bool rejouer = false; 

        public bool Continuer1 { get => continuer; set => continuer = value; }
        public bool Rejouer1 { get => rejouer; set => rejouer = value; }

        public MenuFinPartie()
        {
            InitializeComponent();
        }

        private void Rejouer_Click(object sender, EventArgs e)
        {
            Rejouer1 = true;
            this.Close();
        }

        private void Quitter_Click(object sender, EventArgs e)
        {
            Partie.FinJeu(); 
        }

        private void Continuer_Click(object sender, EventArgs e)
        {
            Continuer1 = true;
            this.Close(); 
        }

        private void MenuFinPartie_Load(object sender, EventArgs e)
        {
            scorePartie.Text = Partie.ScorePartie.ToString();
            score.Text = Joueur.Score.ToString();
            if (Partie.CheckVictoire())
            {
                score.ForeColor = Color.Green;
                label1.Text = "Felicitation "+Program.f.Joueur.Nom+" vous avez gagner la Partie"; 
                if(Partie.Niveau==Niveau.level4)
                    label1.Text = "Felicitation " + Program.f.Joueur.Nom + " vous avez Finie tout les Niveaux";
            }
            else
            {
                label1.Text = "Malheuresement " + Program.f.Joueur.Nom + " vous avez perdu la Partie";
                Continuer.Enabled = false;
            }
                 
        }

        private void MenuFinPartie_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Rejouer1 && !Continuer1)
                Partie.FinJeu();
        }
    }
}
