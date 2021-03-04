using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
namespace app
{
    enum Niveau
    {
        level1,level2,level3,level4
    }
    class Partie
    {
        
        static Niveau niveau;
        static long scorePartie;
        Label partie; 

        public Partie()
        {
            Niveau = Niveau.level1;
        }

 
        internal static Niveau Niveau { get => niveau;
            set {
                niveau = value;
                if (niveau == Niveau.level1)
                    ScorePartie = 400; 
                else if (niveau == Niveau.level2)
                    ScorePartie = 650; 
                else if (niveau == Niveau.level3)
                    ScorePartie = 800;
                else if (niveau == Niveau.level4)
                    ScorePartie = 1100;

            }
        }

        public static long ScorePartie { get => scorePartie; set => scorePartie = value; }



        public static bool FinPartie()
        {
            MenuFinPartie menu = new MenuFinPartie();
            menu.ShowDialog(); 
            
            if(menu.Continuer1 && Niveau!=Niveau.level4){
                Niveau++;  
                return false;
            }else if (menu.Rejouer1)
            {
                return false; 
            }
            return true; 
        }
        
        public static bool CheckVictoire()
        {

            if (Joueur.Score >= scorePartie)
                return true ;                
            return false; 
        }

        public static void FinJeu()
        {
            Application.Exit();
        }
    }
}
