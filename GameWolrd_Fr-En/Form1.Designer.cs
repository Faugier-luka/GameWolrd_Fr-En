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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_Valider = new System.Windows.Forms.Button();
            this.tB_WorldFrench = new System.Windows.Forms.TextBox();
            this.tB_WorldEnglish = new System.Windows.Forms.TextBox();
            this.lb_Francais = new System.Windows.Forms.Label();
            this.lb_English = new System.Windows.Forms.Label();
            this.tb_C_French = new System.Windows.Forms.TextBox();
            this.tb_C_English = new System.Windows.Forms.TextBox();
            this.b_Gener = new System.Windows.Forms.Button();
            this.tbNombreCorrecte = new System.Windows.Forms.TextBox();
            this.tbNombreFaux = new System.Windows.Forms.TextBox();
            this.b_enchange = new System.Windows.Forms.Button();
            this.tb_nombreVisibleV = new System.Windows.Forms.TextBox();
            this.tb_nombreVisibleF = new System.Windows.Forms.TextBox();
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
            this.tB_WorldFrench.Size = new System.Drawing.Size(313, 74);
            this.tB_WorldFrench.TabIndex = 1;
            // 
            // tB_WorldEnglish
            // 
            this.tB_WorldEnglish.Enabled = false;
            this.tB_WorldEnglish.Location = new System.Drawing.Point(456, 106);
            this.tB_WorldEnglish.Multiline = true;
            this.tB_WorldEnglish.Name = "tB_WorldEnglish";
            this.tB_WorldEnglish.Size = new System.Drawing.Size(313, 74);
            this.tB_WorldEnglish.TabIndex = 2;
            // 
            // lb_Francais
            // 
            this.lb_Francais.AutoSize = true;
            this.lb_Francais.Location = new System.Drawing.Point(163, 80);
            this.lb_Francais.Name = "lb_Francais";
            this.lb_Francais.Size = new System.Drawing.Size(47, 13);
            this.lb_Francais.TabIndex = 3;
            this.lb_Francais.Text = "Français";
            // 
            // lb_English
            // 
            this.lb_English.AutoSize = true;
            this.lb_English.Location = new System.Drawing.Point(618, 79);
            this.lb_English.Name = "lb_English";
            this.lb_English.Size = new System.Drawing.Size(41, 13);
            this.lb_English.TabIndex = 4;
            this.lb_English.Text = "Englais";
            // 
            // tb_C_French
            // 
            this.tb_C_French.BackColor = System.Drawing.SystemColors.MenuText;
            this.tb_C_French.Location = new System.Drawing.Point(298, 428);
            this.tb_C_French.Name = "tb_C_French";
            this.tb_C_French.Size = new System.Drawing.Size(100, 20);
            this.tb_C_French.TabIndex = 5;
            // 
            // tb_C_English
            // 
            this.tb_C_English.BackColor = System.Drawing.SystemColors.MenuText;
            this.tb_C_English.Location = new System.Drawing.Point(394, 428);
            this.tb_C_English.Name = "tb_C_English";
            this.tb_C_English.Size = new System.Drawing.Size(100, 20);
            this.tb_C_English.TabIndex = 6;
            this.tb_C_English.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // b_Gener
            // 
            this.b_Gener.Location = new System.Drawing.Point(366, 12);
            this.b_Gener.Name = "b_Gener";
            this.b_Gener.Size = new System.Drawing.Size(75, 23);
            this.b_Gener.TabIndex = 7;
            this.b_Gener.Text = "Générer";
            this.b_Gener.UseVisualStyleBackColor = true;
            this.b_Gener.Click += new System.EventHandler(this.b_Gener_Click);
            // 
            // tbNombreCorrecte
            // 
            this.tbNombreCorrecte.BackColor = System.Drawing.Color.Green;
            this.tbNombreCorrecte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tbNombreCorrecte.Location = new System.Drawing.Point(240, 238);
            this.tbNombreCorrecte.Name = "tbNombreCorrecte";
            this.tbNombreCorrecte.Size = new System.Drawing.Size(100, 20);
            this.tbNombreCorrecte.TabIndex = 8;
            // 
            // tbNombreFaux
            // 
            this.tbNombreFaux.BackColor = System.Drawing.Color.DarkRed;
            this.tbNombreFaux.ForeColor = System.Drawing.Color.Red;
            this.tbNombreFaux.Location = new System.Drawing.Point(456, 238);
            this.tbNombreFaux.Name = "tbNombreFaux";
            this.tbNombreFaux.Size = new System.Drawing.Size(100, 20);
            this.tbNombreFaux.TabIndex = 9;
            // 
            // b_enchange
            // 
            this.b_enchange.Image = global::GameWolrd_Fr_En.Properties.Resources.R;
            this.b_enchange.Location = new System.Drawing.Point(366, 124);
            this.b_enchange.Name = "b_enchange";
            this.b_enchange.Size = new System.Drawing.Size(75, 38);
            this.b_enchange.TabIndex = 10;
            this.b_enchange.Text = "échange";
            this.b_enchange.UseVisualStyleBackColor = true;
            this.b_enchange.Click += new System.EventHandler(this.b_enchange_Click);
            // 
            // tb_nombreVisibleV
            // 
            this.tb_nombreVisibleV.BackColor = System.Drawing.Color.Green;
            this.tb_nombreVisibleV.ForeColor = System.Drawing.Color.Lime;
            this.tb_nombreVisibleV.Location = new System.Drawing.Point(266, 264);
            this.tb_nombreVisibleV.Name = "tb_nombreVisibleV";
            this.tb_nombreVisibleV.Size = new System.Drawing.Size(47, 20);
            this.tb_nombreVisibleV.TabIndex = 11;
            // 
            // tb_nombreVisibleF
            // 
            this.tb_nombreVisibleF.BackColor = System.Drawing.Color.Maroon;
            this.tb_nombreVisibleF.ForeColor = System.Drawing.Color.Red;
            this.tb_nombreVisibleF.Location = new System.Drawing.Point(485, 264);
            this.tb_nombreVisibleF.Name = "tb_nombreVisibleF";
            this.tb_nombreVisibleF.Size = new System.Drawing.Size(47, 20);
            this.tb_nombreVisibleF.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_nombreVisibleF);
            this.Controls.Add(this.tb_nombreVisibleV);
            this.Controls.Add(this.b_enchange);
            this.Controls.Add(this.tbNombreFaux);
            this.Controls.Add(this.tbNombreCorrecte);
            this.Controls.Add(this.b_Gener);
            this.Controls.Add(this.tb_C_English);
            this.Controls.Add(this.tb_C_French);
            this.Controls.Add(this.lb_English);
            this.Controls.Add(this.lb_Francais);
            this.Controls.Add(this.tB_WorldEnglish);
            this.Controls.Add(this.tB_WorldFrench);
            this.Controls.Add(this.button_Valider);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Valider;
        private System.Windows.Forms.TextBox tB_WorldFrench;
        private System.Windows.Forms.TextBox tB_WorldEnglish;
        private System.Windows.Forms.Label lb_Francais;
        private System.Windows.Forms.Label lb_English;
        private System.Windows.Forms.TextBox tb_C_French;
        private System.Windows.Forms.TextBox tb_C_English;
        private System.Windows.Forms.Button b_Gener;
        private System.Windows.Forms.TextBox tbNombreCorrecte;
        private System.Windows.Forms.TextBox tbNombreFaux;
        private System.Windows.Forms.TextBox tb_nombreVisibleV;
        private System.Windows.Forms.TextBox tb_nombreVisibleF;
        private System.Windows.Forms.Button b_enchange;
    }
}

