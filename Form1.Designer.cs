
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
            this.beginGameButton = new System.Windows.Forms.Button();
            this.moveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addPlayerButton
            // 
            this.addPlayerButton.Location = new System.Drawing.Point(748, 78);
            this.addPlayerButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addPlayerButton.Name = "addPlayerButton";
            this.addPlayerButton.Size = new System.Drawing.Size(248, 28);
            this.addPlayerButton.TabIndex = 0;
            this.addPlayerButton.Text = "Ajouter un joueur";
            this.addPlayerButton.UseVisualStyleBackColor = true;
            this.addPlayerButton.Click += new System.EventHandler(this.addPlayerButton_Click);
            // 
            // createGame
            // 
            this.createGame.Location = new System.Drawing.Point(748, 42);
            this.createGame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.createGame.Name = "createGame";
            this.createGame.Size = new System.Drawing.Size(248, 28);
            this.createGame.TabIndex = 1;
            this.createGame.Text = "Créer la partie";
            this.createGame.UseVisualStyleBackColor = true;
            this.createGame.Click += new System.EventHandler(this.createGame_Click);
            // 
            // alertBox
            // 
            this.alertBox.Location = new System.Drawing.Point(81, 398);
            this.alertBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.alertBox.Multiline = true;
            this.alertBox.Name = "alertBox";
            this.alertBox.Size = new System.Drawing.Size(912, 112);
            this.alertBox.TabIndex = 2;
            // 
            // beginGameButton
            // 
            this.beginGameButton.Location = new System.Drawing.Point(749, 115);
            this.beginGameButton.Margin = new System.Windows.Forms.Padding(4);
            this.beginGameButton.Name = "beginGameButton";
            this.beginGameButton.Size = new System.Drawing.Size(248, 28);
            this.beginGameButton.TabIndex = 3;
            this.beginGameButton.Text = "Commencer la partie";
            this.beginGameButton.UseVisualStyleBackColor = true;
            this.beginGameButton.Click += new System.EventHandler(this.beginGameButton_Click);
            // 
            // moveButton
            // 
            this.moveButton.Location = new System.Drawing.Point(748, 151);
            this.moveButton.Margin = new System.Windows.Forms.Padding(4);
            this.moveButton.Name = "moveButton";
            this.moveButton.Size = new System.Drawing.Size(248, 28);
            this.moveButton.TabIndex = 4;
            this.moveButton.Text = "Paul avance de 1";
            this.moveButton.UseVisualStyleBackColor = true;
            this.moveButton.Click += new System.EventHandler(this.moveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.moveButton);
            this.Controls.Add(this.beginGameButton);
            this.Controls.Add(this.alertBox);
            this.Controls.Add(this.createGame);
            this.Controls.Add(this.addPlayerButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addPlayerButton;
        private System.Windows.Forms.Button createGame;
        private System.Windows.Forms.TextBox alertBox;
        private System.Windows.Forms.Button beginGameButton;
        private System.Windows.Forms.Button moveButton;
    }
}

