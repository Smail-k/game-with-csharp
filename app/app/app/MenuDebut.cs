using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing; 
namespace app
{
    class MenuDebut : Form
    {
        
        private ComboBox partie;
        private TextBox NomJoueur;
        private Label label1;
        private Label label2;
        private Button Jouer;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        bool clickjouer = false; 
    

        public MenuDebut()
        {
            InitializeComponent();
            
        }

   

      
        private void InitializeComponent()
        {
            this.partie = new System.Windows.Forms.ComboBox();
            this.NomJoueur = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Jouer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // partie
            // 
            this.partie.FormattingEnabled = true;
            this.partie.Location = new System.Drawing.Point(275, 140);
            this.partie.Name = "partie";
            this.partie.Size = new System.Drawing.Size(202, 24);
            this.partie.TabIndex = 0;
            this.partie.SelectedIndexChanged += new System.EventHandler(this.partie_SelectedIndexChanged);
            // 
            // NomJoueur
            // 
            this.NomJoueur.Location = new System.Drawing.Point(275, 88);
            this.NomJoueur.Name = "NomJoueur";
            this.NomJoueur.Size = new System.Drawing.Size(202, 22);
            this.NomJoueur.TabIndex = 1;
            this.NomJoueur.TextChanged += new System.EventHandler(this.NomJoueur_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(123, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom Joueur : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Desktop;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(123, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Niveu : ";
            // 
            // Jouer
            // 
            this.Jouer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Jouer.Location = new System.Drawing.Point(243, 382);
            this.Jouer.Name = "Jouer";
            this.Jouer.Size = new System.Drawing.Size(141, 43);
            this.Jouer.TabIndex = 4;
            this.Jouer.Text = "Jouer";
            this.Jouer.UseVisualStyleBackColor = false;
            this.Jouer.Click += new System.EventHandler(this.Jouer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Desktop;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(107, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(389, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Partie 1 : Vous devez avoir un score de 400 .";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Desktop;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(107, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(389, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Partie 2 : Vous devez avoir un score de 650 .";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Desktop;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(107, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(389, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Partie 3 : Vous devez avoir un score de 800 .";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Desktop;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(107, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(393, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Partie 4 : Vous devez avoir un score de 1300.";
            // 
            // MenuDebut
            // 
            this.ClientSize = new System.Drawing.Size(588, 437);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Jouer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NomJoueur);
            this.Controls.Add(this.partie);
            this.Name = "MenuDebut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuDebut_FormClosing);
            this.Load += new System.EventHandler(this.MenuDebut_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void MenuDebut_Load(object sender, EventArgs e)
        {
            partie.Items.Clear(); 
            partie.Items.Add("Niveau 1");
            partie.Items.Add("Niveau 2");
            partie.Items.Add("Niveau 3");
            partie.Items.Add("Niveau 4");
            partie.Text = "";
            Jouer.Enabled = false; 
        }

        private void Jouer_Click(object sender, EventArgs e)
        {
            
            //Joueur.Nom = ;
            if (partie.SelectedIndex == 0)
                Partie.Niveau = Niveau.level1;
            if (partie.SelectedIndex == 1)
                Partie.Niveau = Niveau.level2;
            if (partie.SelectedIndex == 2)
                Partie.Niveau = Niveau.level3;
            if (partie.SelectedIndex == 3)
                Partie.Niveau = Niveau.level4;
            clickjouer = true; 
            Program.f.Joueur.Nom = NomJoueur.Text;
            this.Dispose();
            

        }
        
        private void partie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NomJoueur.Text != "")
                Jouer.Enabled = true; 
        }

        

        private void NomJoueur_TextChanged(object sender, EventArgs e)
        {
            if(partie.Text!="")
                Jouer.Enabled = true;
        }

        private void MenuDebut_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!clickjouer)
                Application.Exit();
        }
    }
}
