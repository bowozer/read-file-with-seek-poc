namespace ReadFileWithSeekPoC
{
    partial class ReadFile
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
            this.Read = new System.Windows.Forms.Button();
            this.FileContent = new System.Windows.Forms.TextBox();
            this.UpdatedTimestampLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Read
            // 
            this.Read.Location = new System.Drawing.Point(373, 10);
            this.Read.Name = "Read";
            this.Read.Size = new System.Drawing.Size(75, 23);
            this.Read.TabIndex = 0;
            this.Read.Text = "Read";
            this.Read.UseVisualStyleBackColor = true;
            this.Read.Click += new System.EventHandler(this.Read_Click);
            // 
            // FileContent
            // 
            this.FileContent.Location = new System.Drawing.Point(12, 12);
            this.FileContent.Multiline = true;
            this.FileContent.Name = "FileContent";
            this.FileContent.Size = new System.Drawing.Size(355, 321);
            this.FileContent.TabIndex = 1;
            // 
            // UpdatedTimestampLbl
            // 
            this.UpdatedTimestampLbl.AutoSize = true;
            this.UpdatedTimestampLbl.Location = new System.Drawing.Point(373, 36);
            this.UpdatedTimestampLbl.Name = "UpdatedTimestampLbl";
            this.UpdatedTimestampLbl.Size = new System.Drawing.Size(35, 13);
            this.UpdatedTimestampLbl.TabIndex = 2;
            this.UpdatedTimestampLbl.Text = "label1";
            // 
            // ReadFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UpdatedTimestampLbl);
            this.Controls.Add(this.FileContent);
            this.Controls.Add(this.Read);
            this.Name = "ReadFile";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ReadFile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Read;
        private System.Windows.Forms.TextBox FileContent;
        private System.Windows.Forms.Label UpdatedTimestampLbl;
    }
}

