namespace Joueurs_de_foot
{
    partial class frmPlayer
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
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrénom = new System.Windows.Forms.Label();
            this.lblNumTéléphone = new System.Windows.Forms.Label();
            this.txtPrénom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtNumTéléphone = new System.Windows.Forms.TextBox();
            this.cmdAddModify = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(87, 174);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(42, 20);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nom";
            // 
            // lblPrénom
            // 
            this.lblPrénom.AutoSize = true;
            this.lblPrénom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrénom.Location = new System.Drawing.Point(87, 68);
            this.lblPrénom.Name = "lblPrénom";
            this.lblPrénom.Size = new System.Drawing.Size(64, 20);
            this.lblPrénom.TabIndex = 2;
            this.lblPrénom.Text = "Prénom";
            // 
            // lblNumTéléphone
            // 
            this.lblNumTéléphone.AutoSize = true;
            this.lblNumTéléphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumTéléphone.Location = new System.Drawing.Point(87, 294);
            this.lblNumTéléphone.Name = "lblNumTéléphone";
            this.lblNumTéléphone.Size = new System.Drawing.Size(117, 20);
            this.lblNumTéléphone.TabIndex = 3;
            this.lblNumTéléphone.Text = "N de téléphone";
            // 
            // txtPrénom
            // 
            this.txtPrénom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrénom.Location = new System.Drawing.Point(91, 113);
            this.txtPrénom.Name = "txtPrénom";
            this.txtPrénom.Size = new System.Drawing.Size(100, 26);
            this.txtPrénom.TabIndex = 4;
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(91, 223);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 26);
            this.txtNom.TabIndex = 5;
            // 
            // txtNumTéléphone
            // 
            this.txtNumTéléphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumTéléphone.Location = new System.Drawing.Point(91, 355);
            this.txtNumTéléphone.Name = "txtNumTéléphone";
            this.txtNumTéléphone.Size = new System.Drawing.Size(100, 26);
            this.txtNumTéléphone.TabIndex = 6;
            // 
            // cmdAddModify
            // 
            this.cmdAddModify.Location = new System.Drawing.Point(316, 334);
            this.cmdAddModify.Name = "cmdAddModify";
            this.cmdAddModify.Size = new System.Drawing.Size(114, 23);
            this.cmdAddModify.TabIndex = 7;
            this.cmdAddModify.Text = "Ajouter / Modifer";
            this.cmdAddModify.UseVisualStyleBackColor = true;
            this.cmdAddModify.Click += new System.EventHandler(this.cmdAddModify_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(489, 334);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 8;
            this.cmdCancel.Text = "Annuler";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // frmPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdAddModify);
            this.Controls.Add(this.txtNumTéléphone);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtPrénom);
            this.Controls.Add(this.lblNumTéléphone);
            this.Controls.Add(this.lblPrénom);
            this.Controls.Add(this.lblNom);
            this.Name = "frmPlayer";
            this.Text = "Création / modification d’un joueur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrénom;
        private System.Windows.Forms.Label lblNumTéléphone;
        private System.Windows.Forms.TextBox txtPrénom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtNumTéléphone;
        private System.Windows.Forms.Button cmdAddModify;
        private System.Windows.Forms.Button cmdCancel;
    }
}

