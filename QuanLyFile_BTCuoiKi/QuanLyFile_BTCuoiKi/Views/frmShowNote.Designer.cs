namespace QuanLyFile_BTCuoiKi.Views
{
    partial class frmShowNote
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
            this.dgvShowNote = new System.Windows.Forms.DataGridView();
            this.cFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowNote)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvShowNote
            // 
            this.dgvShowNote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowNote.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cFileName,
            this.cNote});
            this.dgvShowNote.Location = new System.Drawing.Point(12, 86);
            this.dgvShowNote.Name = "dgvShowNote";
            this.dgvShowNote.Size = new System.Drawing.Size(749, 464);
            this.dgvShowNote.TabIndex = 1;
            this.dgvShowNote.DoubleClick += new System.EventHandler(this.dgvShowNote_DoubleClick);
            // 
            // cFileName
            // 
            this.cFileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cFileName.HeaderText = "File Path";
            this.cFileName.Name = "cFileName";
            // 
            // cNote
            // 
            this.cNote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cNote.HeaderText = "Note";
            this.cNote.Name = "cNote";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 80);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(348, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Note";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Double click the File Path to edit the note";
            // 
            // frmShowNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 562);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvShowNote);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmShowNote";
            this.Text = "frmShowNote";
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowNote)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvShowNote;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNote;
        private System.Windows.Forms.Label label2;
    }
}