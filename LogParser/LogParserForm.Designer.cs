namespace LogParser
{
    partial class LogParserForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txtBox = new System.Windows.Forms.RichTextBox();
            this.lblNoFile = new System.Windows.Forms.Label();
            this.lblBox = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearchedFor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Click to Open Folder Browser";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(66, 149);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(683, 324);
            this.txtBox.TabIndex = 1;
            this.txtBox.Text = "";
            // 
            // lblNoFile
            // 
            this.lblNoFile.AutoSize = true;
            this.lblNoFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoFile.ForeColor = System.Drawing.Color.DarkRed;
            this.lblNoFile.Location = new System.Drawing.Point(63, 111);
            this.lblNoFile.Name = "lblNoFile";
            this.lblNoFile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNoFile.Size = new System.Drawing.Size(76, 17);
            this.lblNoFile.TabIndex = 2;
            this.lblNoFile.Text = "ErrorText";
            this.lblNoFile.Visible = false;
            // 
            // lblBox
            // 
            this.lblBox.AutoSize = true;
            this.lblBox.Location = new System.Drawing.Point(63, 28);
            this.lblBox.Name = "lblBox";
            this.lblBox.Size = new System.Drawing.Size(105, 13);
            this.lblBox.TabIndex = 3;
            this.lblBox.Text = "Enter the search text";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(202, 21);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(299, 20);
            this.txtSearch.TabIndex = 5;
            // 
            // lblSearchedFor
            // 
            this.lblSearchedFor.AutoSize = true;
            this.lblSearchedFor.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchedFor.Location = new System.Drawing.Point(226, 111);
            this.lblSearchedFor.Name = "lblSearchedFor";
            this.lblSearchedFor.Size = new System.Drawing.Size(98, 21);
            this.lblSearchedFor.TabIndex = 6;
            this.lblSearchedFor.Text = "Search Text";
            this.lblSearchedFor.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "(If left empty, searches for memory exceptions)";
            // 
            // LogParserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 562);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSearchedFor);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblBox);
            this.Controls.Add(this.lblNoFile);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.button1);
            this.Name = "LogParserForm";
            this.Text = "LogParserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.RichTextBox txtBox;
        private System.Windows.Forms.Label lblNoFile;
        private System.Windows.Forms.Label lblBox;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearchedFor;
        private System.Windows.Forms.Label label1;
    }
}

