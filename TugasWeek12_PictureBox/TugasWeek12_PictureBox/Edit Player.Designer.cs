namespace TugasWeek12_PictureBox
{
    partial class formEditPlayer
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
            this.pbProfile = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxPlayerName = new System.Windows.Forms.TextBox();
            this.rbutAktif = new System.Windows.Forms.RadioButton();
            this.rbutTidakAktif = new System.Windows.Forms.RadioButton();
            this.butChange = new System.Windows.Forms.Button();
            this.butOKE = new System.Windows.Forms.Button();
            this.cboxTeam = new System.Windows.Forms.ComboBox();
            this.cboxNation = new System.Windows.Forms.ComboBox();
            this.cboxPlayingPos = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // pbProfile
            // 
            this.pbProfile.Image = global::TugasWeek12_PictureBox.Properties.Resources._6525a08f1df98a2e3a545fe2ace4be47;
            this.pbProfile.Location = new System.Drawing.Point(35, 35);
            this.pbProfile.Name = "pbProfile";
            this.pbProfile.Size = new System.Drawing.Size(327, 402);
            this.pbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfile.TabIndex = 0;
            this.pbProfile.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(423, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nama Pemain";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(423, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Asal Tim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(423, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Posisi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(423, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Asal Negara";
            // 
            // tboxPlayerName
            // 
            this.tboxPlayerName.Enabled = false;
            this.tboxPlayerName.Location = new System.Drawing.Point(519, 76);
            this.tboxPlayerName.Name = "tboxPlayerName";
            this.tboxPlayerName.Size = new System.Drawing.Size(121, 20);
            this.tboxPlayerName.TabIndex = 5;
            // 
            // rbutAktif
            // 
            this.rbutAktif.AutoSize = true;
            this.rbutAktif.Location = new System.Drawing.Point(519, 244);
            this.rbutAktif.Name = "rbutAktif";
            this.rbutAktif.Size = new System.Drawing.Size(46, 17);
            this.rbutAktif.TabIndex = 9;
            this.rbutAktif.TabStop = true;
            this.rbutAktif.Text = "Aktif";
            this.rbutAktif.UseVisualStyleBackColor = true;
            // 
            // rbutTidakAktif
            // 
            this.rbutTidakAktif.AutoSize = true;
            this.rbutTidakAktif.Location = new System.Drawing.Point(603, 244);
            this.rbutTidakAktif.Name = "rbutTidakAktif";
            this.rbutTidakAktif.Size = new System.Drawing.Size(77, 17);
            this.rbutTidakAktif.TabIndex = 10;
            this.rbutTidakAktif.TabStop = true;
            this.rbutTidakAktif.Text = "TIdak Aktif";
            this.rbutTidakAktif.UseVisualStyleBackColor = true;
            // 
            // butChange
            // 
            this.butChange.Location = new System.Drawing.Point(159, 473);
            this.butChange.Name = "butChange";
            this.butChange.Size = new System.Drawing.Size(75, 23);
            this.butChange.TabIndex = 11;
            this.butChange.Text = "Change";
            this.butChange.UseVisualStyleBackColor = true;
            this.butChange.Click += new System.EventHandler(this.butChange_Click);
            // 
            // butOKE
            // 
            this.butOKE.Location = new System.Drawing.Point(553, 297);
            this.butOKE.Name = "butOKE";
            this.butOKE.Size = new System.Drawing.Size(75, 23);
            this.butOKE.TabIndex = 12;
            this.butOKE.Text = "OK";
            this.butOKE.UseVisualStyleBackColor = true;
            this.butOKE.Click += new System.EventHandler(this.butOKE_Click);
            // 
            // cboxTeam
            // 
            this.cboxTeam.FormattingEnabled = true;
            this.cboxTeam.Location = new System.Drawing.Point(519, 116);
            this.cboxTeam.Name = "cboxTeam";
            this.cboxTeam.Size = new System.Drawing.Size(121, 21);
            this.cboxTeam.TabIndex = 13;
            // 
            // cboxNation
            // 
            this.cboxNation.FormattingEnabled = true;
            this.cboxNation.Location = new System.Drawing.Point(519, 159);
            this.cboxNation.Name = "cboxNation";
            this.cboxNation.Size = new System.Drawing.Size(121, 21);
            this.cboxNation.TabIndex = 14;
            // 
            // cboxPlayingPos
            // 
            this.cboxPlayingPos.FormattingEnabled = true;
            this.cboxPlayingPos.Location = new System.Drawing.Point(519, 199);
            this.cboxPlayingPos.Name = "cboxPlayingPos";
            this.cboxPlayingPos.Size = new System.Drawing.Size(121, 21);
            this.cboxPlayingPos.TabIndex = 15;
            // 
            // formEditPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 699);
            this.Controls.Add(this.cboxPlayingPos);
            this.Controls.Add(this.cboxNation);
            this.Controls.Add(this.cboxTeam);
            this.Controls.Add(this.butOKE);
            this.Controls.Add(this.butChange);
            this.Controls.Add(this.rbutTidakAktif);
            this.Controls.Add(this.rbutAktif);
            this.Controls.Add(this.tboxPlayerName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbProfile);
            this.Name = "formEditPlayer";
            this.Text = "Edit Player";
            this.Load += new System.EventHandler(this.formEditPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbProfile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tboxPlayerName;
        private System.Windows.Forms.RadioButton rbutAktif;
        private System.Windows.Forms.RadioButton rbutTidakAktif;
        private System.Windows.Forms.Button butChange;
        private System.Windows.Forms.Button butOKE;
        private System.Windows.Forms.ComboBox cboxTeam;
        private System.Windows.Forms.ComboBox cboxNation;
        private System.Windows.Forms.ComboBox cboxPlayingPos;
    }
}