namespace QuanLyFile_BTCuoiKi.Views
{
    partial class Form1
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnNote = new System.Windows.Forms.Button();
            this.btnLibrary = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.btnHistory = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.btnHistory);
            this.panelMain.Controls.Add(this.btnNote);
            this.panelMain.Controls.Add(this.btnLibrary);
            this.panelMain.Controls.Add(this.panelLogo);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(200, 601);
            this.panelMain.TabIndex = 0;
            // 
            // btnNote
            // 
            this.btnNote.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnNote.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNote.FlatAppearance.BorderSize = 0;
            this.btnNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNote.Location = new System.Drawing.Point(0, 120);
            this.btnNote.Name = "btnNote";
            this.btnNote.Size = new System.Drawing.Size(200, 40);
            this.btnNote.TabIndex = 4;
            this.btnNote.Text = "Note";
            this.btnNote.UseVisualStyleBackColor = false;
            this.btnNote.Click += new System.EventHandler(this.btnNote_Click);
            // 
            // btnLibrary
            // 
            this.btnLibrary.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnLibrary.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLibrary.FlatAppearance.BorderSize = 0;
            this.btnLibrary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibrary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibrary.Location = new System.Drawing.Point(0, 80);
            this.btnLibrary.Name = "btnLibrary";
            this.btnLibrary.Size = new System.Drawing.Size(200, 40);
            this.btnLibrary.TabIndex = 1;
            this.btnLibrary.Text = "Library";
            this.btnLibrary.UseVisualStyleBackColor = false;
            this.btnLibrary.Click += new System.EventHandler(this.btnLibrary_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // panelChildForm
            // 
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(200, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(789, 601);
            this.panelChildForm.TabIndex = 1;
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistory.FlatAppearance.BorderSize = 0;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.Location = new System.Drawing.Point(0, 160);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(200, 40);
            this.btnHistory.TabIndex = 5;
            this.btnHistory.Text = "History";
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 601);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelMain);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "File Management";
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnLibrary;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Button btnNote;
        private System.Windows.Forms.Button btnHistory;
    }
}

