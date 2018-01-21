namespace PassGenerator
{
    partial class MainForm
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
            this.txtBxSeed = new System.Windows.Forms.TextBox();
            this.lblTxtSeed = new System.Windows.Forms.Label();
            this.btnValidate = new System.Windows.Forms.Button();
            this.sizePass = new System.Windows.Forms.NumericUpDown();
            this.lblSize = new System.Windows.Forms.Label();
            this.txtFinalPass = new System.Windows.Forms.TextBox();
            this.lblFinalPass = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sizePass)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBxSeed
            // 
            this.txtBxSeed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBxSeed.Location = new System.Drawing.Point(160, 138);
            this.txtBxSeed.Name = "txtBxSeed";
            this.txtBxSeed.Size = new System.Drawing.Size(284, 20);
            this.txtBxSeed.TabIndex = 0;
            this.txtBxSeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTxtSeed
            // 
            this.lblTxtSeed.AutoSize = true;
            this.lblTxtSeed.ForeColor = System.Drawing.Color.White;
            this.lblTxtSeed.Location = new System.Drawing.Point(237, 122);
            this.lblTxtSeed.Name = "lblTxtSeed";
            this.lblTxtSeed.Size = new System.Drawing.Size(107, 13);
            this.lblTxtSeed.TabIndex = 1;
            this.lblTxtSeed.Text = "Entrez ici vos graines";
            // 
            // btnValidate
            // 
            this.btnValidate.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnValidate.Location = new System.Drawing.Point(256, 286);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(75, 23);
            this.btnValidate.TabIndex = 2;
            this.btnValidate.Text = "Valider";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // sizePass
            // 
            this.sizePass.Location = new System.Drawing.Point(240, 214);
            this.sizePass.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.sizePass.Name = "sizePass";
            this.sizePass.Size = new System.Drawing.Size(120, 20);
            this.sizePass.TabIndex = 3;
            this.sizePass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.ForeColor = System.Drawing.Color.White;
            this.lblSize.Location = new System.Drawing.Point(202, 198);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(188, 13);
            this.lblSize.TabIndex = 4;
            this.lblSize.Text = "Entre ici la taille de votre mot de passe";
            // 
            // txtFinalPass
            // 
            this.txtFinalPass.Location = new System.Drawing.Point(195, 357);
            this.txtFinalPass.Name = "txtFinalPass";
            this.txtFinalPass.ReadOnly = true;
            this.txtFinalPass.Size = new System.Drawing.Size(204, 20);
            this.txtFinalPass.TabIndex = 5;
            this.txtFinalPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblFinalPass
            // 
            this.lblFinalPass.AutoSize = true;
            this.lblFinalPass.ForeColor = System.Drawing.Color.White;
            this.lblFinalPass.Location = new System.Drawing.Point(242, 341);
            this.lblFinalPass.Name = "lblFinalPass";
            this.lblFinalPass.Size = new System.Drawing.Size(98, 13);
            this.lblFinalPass.TabIndex = 6;
            this.lblFinalPass.Text = "Votre mot de passe";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(610, 455);
            this.Controls.Add(this.lblFinalPass);
            this.Controls.Add(this.txtFinalPass);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.sizePass);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.lblTxtSeed);
            this.Controls.Add(this.txtBxSeed);
            this.Name = "MainForm";
            this.Text = "Pass Generator";
            ((System.ComponentModel.ISupportInitialize)(this.sizePass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxSeed;
        private System.Windows.Forms.Label lblTxtSeed;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.NumericUpDown sizePass;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.TextBox txtFinalPass;
        private System.Windows.Forms.Label lblFinalPass;
    }
}

