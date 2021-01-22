
namespace MonopolyINFO807
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.addPlayerButton = new System.Windows.Forms.Button();
            this.createGame = new System.Windows.Forms.Button();
            this.alertBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addPlayerButton
            // 
            this.addPlayerButton.Location = new System.Drawing.Point(561, 63);
            this.addPlayerButton.Name = "addPlayerButton";
            this.addPlayerButton.Size = new System.Drawing.Size(186, 23);
            this.addPlayerButton.TabIndex = 0;
            this.addPlayerButton.Text = "Ajouter un joueur";
            this.addPlayerButton.UseVisualStyleBackColor = true;
            this.addPlayerButton.Click += new System.EventHandler(this.addPlayerButton_Click);
            // 
            // createGame
            // 
            this.createGame.Location = new System.Drawing.Point(561, 25);
            this.createGame.Name = "createGame";
            this.createGame.Size = new System.Drawing.Size(186, 23);
            this.createGame.TabIndex = 1;
            this.createGame.Text = "Créer la partie";
            this.createGame.UseVisualStyleBackColor = true;
            this.createGame.Click += new System.EventHandler(this.createGame_Click);
            // 
            // alertBox
            // 
            this.alertBox.Location = new System.Drawing.Point(61, 323);
            this.alertBox.Multiline = true;
            this.alertBox.Name = "alertBox";
            this.alertBox.Size = new System.Drawing.Size(685, 92);
            this.alertBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.alertBox);
            this.Controls.Add(this.createGame);
            this.Controls.Add(this.addPlayerButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addPlayerButton;
        private System.Windows.Forms.Button createGame;
        private System.Windows.Forms.TextBox alertBox;
    }
}

