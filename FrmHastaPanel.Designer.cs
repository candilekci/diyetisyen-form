
namespace Yazilim_Mimarisi_Project
{
    partial class FrmHastaPanel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDiyet = new System.Windows.Forms.Label();
            this.lblHastalik = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.dataGridDiyet = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDiyet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblDiyet);
            this.panel1.Controls.Add(this.lblHastalik);
            this.panel1.Controls.Add(this.lblTC);
            this.panel1.Controls.Add(this.lblAdSoyad);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 68);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(607, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Diyet :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hastalık :";
            // 
            // lblDiyet
            // 
            this.lblDiyet.AutoSize = true;
            this.lblDiyet.Location = new System.Drawing.Point(607, 35);
            this.lblDiyet.Name = "lblDiyet";
            this.lblDiyet.Size = new System.Drawing.Size(70, 25);
            this.lblDiyet.TabIndex = 3;
            this.lblDiyet.Text = "DİYET";
            // 
            // lblHastalik
            // 
            this.lblHastalik.AutoSize = true;
            this.lblHastalik.Location = new System.Drawing.Point(305, 35);
            this.lblHastalik.Name = "lblHastalik";
            this.lblHastalik.Size = new System.Drawing.Size(111, 25);
            this.lblHastalik.TabIndex = 2;
            this.lblHastalik.Text = "HASTALIK";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(3, 35);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(40, 25);
            this.lblTC.TabIndex = 1;
            this.lblTC.Text = "TC";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(3, 10);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(142, 25);
            this.lblAdSoyad.TabIndex = 0;
            this.lblAdSoyad.Text = "İSİM SOYİSİM";
            // 
            // dataGridDiyet
            // 
            this.dataGridDiyet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dataGridDiyet.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridDiyet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDiyet.Location = new System.Drawing.Point(12, 76);
            this.dataGridDiyet.Name = "dataGridDiyet";
            this.dataGridDiyet.RowHeadersWidth = 51;
            this.dataGridDiyet.RowTemplate.Height = 24;
            this.dataGridDiyet.Size = new System.Drawing.Size(862, 333);
            this.dataGridDiyet.TabIndex = 16;
            // 
            // FrmHastaPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 418);
            this.Controls.Add(this.dataGridDiyet);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmHastaPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmHastaPanel";
            this.Load += new System.EventHandler(this.FrmHastaPanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDiyet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblDiyet;
        private System.Windows.Forms.Label lblHastalik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridDiyet;
    }
}