namespace QuanLyFile_BTCuoiKi.Views
{
    partial class frmShowTxt
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
            this.rtbReadTxt = new System.Windows.Forms.RichTextBox();
            this.Note = new System.Windows.Forms.Label();
            this.rtbNote = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbReadTxt
            // 
            this.rtbReadTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbReadTxt.Location = new System.Drawing.Point(12, 12);
            this.rtbReadTxt.Name = "rtbReadTxt";
            this.rtbReadTxt.Size = new System.Drawing.Size(1099, 667);
            this.rtbReadTxt.TabIndex = 1;
            this.rtbReadTxt.Text = "";
            // 
            // Note
            // 
            this.Note.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Note.AutoSize = true;
            this.Note.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Note.Location = new System.Drawing.Point(13, 701);
            this.Note.Name = "Note";
            this.Note.Size = new System.Drawing.Size(46, 16);
            this.Note.TabIndex = 2;
            this.Note.Text = "Note : ";
            // 
            // rtbNote
            // 
            this.rtbNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbNote.Location = new System.Drawing.Point(16, 731);
            this.rtbNote.Name = "rtbNote";
            this.rtbNote.Size = new System.Drawing.Size(1095, 51);
            this.rtbNote.TabIndex = 3;
            this.rtbNote.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(1011, 685);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 40);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save Note";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmShowTxt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 794);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rtbNote);
            this.Controls.Add(this.Note);
            this.Controls.Add(this.rtbReadTxt);
            this.Name = "frmShowTxt";
            this.Text = "frmShowTxt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtbReadTxt;
        private System.Windows.Forms.Label Note;
        private System.Windows.Forms.RichTextBox rtbNote;
        private System.Windows.Forms.Button btnSave;
    }
}