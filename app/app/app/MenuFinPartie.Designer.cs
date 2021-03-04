
namespace app
{
    partial class MenuFinPartie
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.scorePartie = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.Rejouer = new System.Windows.Forms.Button();
            this.Quitter = new System.Windows.Forms.Button();
            this.Continuer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Le Score pour gagner la Partie : ";
            // 
            // scorePartie
            // 
            this.scorePartie.AutoSize = true;
            this.scorePartie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorePartie.ForeColor = System.Drawing.Color.Red;
            this.scorePartie.Location = new System.Drawing.Point(203, 119);
            this.scorePartie.Name = "scorePartie";
            this.scorePartie.Size = new System.Drawing.Size(59, 20);
            this.scorePartie.TabIndex = 2;
            this.scorePartie.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(180, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Votre Score : ";
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.Location = new System.Drawing.Point(203, 199);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(59, 20);
            this.score.TabIndex = 4;
            this.score.Text = "label5";
            // 
            // Rejouer
            // 
            this.Rejouer.Location = new System.Drawing.Point(84, 273);
            this.Rejouer.Name = "Rejouer";
            this.Rejouer.Size = new System.Drawing.Size(97, 44);
            this.Rejouer.TabIndex = 5;
            this.Rejouer.Text = "Rejouer";
            this.Rejouer.UseVisualStyleBackColor = true;
            this.Rejouer.Click += new System.EventHandler(this.Rejouer_Click);
            // 
            // Quitter
            // 
            this.Quitter.Location = new System.Drawing.Point(207, 273);
            this.Quitter.Name = "Quitter";
            this.Quitter.Size = new System.Drawing.Size(100, 44);
            this.Quitter.TabIndex = 6;
            this.Quitter.Text = "Quitter";
            this.Quitter.UseVisualStyleBackColor = true;
            this.Quitter.Click += new System.EventHandler(this.Quitter_Click);
            // 
            // Continuer
            // 
            this.Continuer.Location = new System.Drawing.Point(327, 273);
            this.Continuer.Name = "Continuer";
            this.Continuer.Size = new System.Drawing.Size(94, 44);
            this.Continuer.TabIndex = 7;
            this.Continuer.Text = "Continuer";
            this.Continuer.UseVisualStyleBackColor = true;
            this.Continuer.Click += new System.EventHandler(this.Continuer_Click);
            // 
            // MenuFinPartie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 348);
            this.Controls.Add(this.Continuer);
            this.Controls.Add(this.Quitter);
            this.Controls.Add(this.Rejouer);
            this.Controls.Add(this.score);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.scorePartie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MenuFinPartie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MenuFinPartie";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuFinPartie_FormClosing);
            this.Load += new System.EventHandler(this.MenuFinPartie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label scorePartie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Button Rejouer;
        private System.Windows.Forms.Button Quitter;
        private System.Windows.Forms.Button Continuer;
    }
}