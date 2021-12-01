namespace GameWolrd_Fr_En
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
            this.button_Valider = new System.Windows.Forms.Button();
            this.tB_WorldFrench = new System.Windows.Forms.TextBox();
            this.tB_WorldEnglish = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_Valider
            // 
            this.button_Valider.Location = new System.Drawing.Point(366, 50);
            this.button_Valider.Name = "button_Valider";
            this.button_Valider.Size = new System.Drawing.Size(75, 23);
            this.button_Valider.TabIndex = 0;
            this.button_Valider.Text = "Valider";
            this.button_Valider.UseVisualStyleBackColor = true;
            this.button_Valider.Click += new System.EventHandler(this.button_Valider_Click);
            // 
            // tB_WorldFrench
            // 
            this.tB_WorldFrench.Location = new System.Drawing.Point(28, 106);
            this.tB_WorldFrench.Multiline = true;
            this.tB_WorldFrench.Name = "tB_WorldFrench";
            this.tB_WorldFrench.Size = new System.Drawing.Size(313, 313);
            this.tB_WorldFrench.TabIndex = 1;
            // 
            // tB_WorldEnglish
            // 
            this.tB_WorldEnglish.Enabled = false;
            this.tB_WorldEnglish.Location = new System.Drawing.Point(456, 106);
            this.tB_WorldEnglish.Multiline = true;
            this.tB_WorldEnglish.Name = "tB_WorldEnglish";
            this.tB_WorldEnglish.Size = new System.Drawing.Size(313, 313);
            this.tB_WorldEnglish.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tB_WorldEnglish);
            this.Controls.Add(this.tB_WorldFrench);
            this.Controls.Add(this.button_Valider);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Valider;
        private System.Windows.Forms.TextBox tB_WorldFrench;
        private System.Windows.Forms.TextBox tB_WorldEnglish;
    }
}

