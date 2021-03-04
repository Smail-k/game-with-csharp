using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
namespace app
{
    class Program
    {
        public static Jeu f;
        
        public Program()
        {
            DebutJeu();
        }
         
        public static void DebutJeu()
        {
            f = new Jeu();
            MenuDebut f2 = new MenuDebut();
            
            f2.ShowDialog();
            f.init();
            f.CommencerJeu();
            f.ShowDialog();
        }
        static void Main(string[] args)
        {
            new Program(); 
        }
    }
}
