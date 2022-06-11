namespace TugasWeek12_PictureBox
{
    partial class FormMainMenu
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
            this.dgvPlayer = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxTim = new System.Windows.Forms.ComboBox();
            this.tboxNamaPlayer = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPlayer
            // 
            this.dgvPlayer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayer.Location = new System.Drawing.Point(21, 60);
            this.dgvPlayer.Name = "dgvPlayer";
            this.dgvPlayer.Size = new System.Drawing.Size(748, 616);
            this.dgvPlayer.TabIndex = 0;
            this.dgvPlayer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlayer_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nama Tim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama Pemain";
            // 
            // cboxTim
            // 
            this.cboxTim.FormattingEnabled = true;
            this.cboxTim.Location = new System.Drawing.Point(83, 21);
            this.cboxTim.Name = "cboxTim";
            this.cboxTim.Size = new System.Drawing.Size(205, 21);
            this.cboxTim.TabIndex = 3;
            this.cboxTim.SelectedIndexChanged += new System.EventHandler(this.cboxTim_SelectedIndexChanged);
            // 
            // tboxNamaPlayer
            // 
            this.tboxNamaPlayer.Location = new System.Drawing.Point(538, 21);
            this.tboxNamaPlayer.Name = "tboxNamaPlayer";
            this.tboxNamaPlayer.Size = new System.Drawing.Size(200, 20);
            this.tboxNamaPlayer.TabIndex = 4;
            this.tboxNamaPlayer.TextChanged += new System.EventHandler(this.tboxNamaPlayer_TextChanged);
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 721);
            this.Controls.Add(this.tboxNamaPlayer);
            this.Controls.Add(this.cboxTim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPlayer);
            this.Name = "FormMainMenu";
            this.Text = "Main Menu";
            this.Activated += new System.EventHandler(this.FormMainMenu_Activated);
            this.Load += new System.EventHandler(this.FormMainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxTim;
        private System.Windows.Forms.TextBox tboxNamaPlayer;
    }
}

