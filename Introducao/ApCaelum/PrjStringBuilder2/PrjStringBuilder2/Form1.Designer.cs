namespace PrjStringBuilder2
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtStrings = new System.Windows.Forms.TextBox();
            this.txtStringReader = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "Teste";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtStrings
            // 
            this.txtStrings.Location = new System.Drawing.Point(12, 12);
            this.txtStrings.Multiline = true;
            this.txtStrings.Name = "txtStrings";
            this.txtStrings.Size = new System.Drawing.Size(168, 109);
            this.txtStrings.TabIndex = 1;
            // 
            // txtStringReader
            // 
            this.txtStringReader.Location = new System.Drawing.Point(202, 12);
            this.txtStringReader.Multiline = true;
            this.txtStringReader.Name = "txtStringReader";
            this.txtStringReader.Size = new System.Drawing.Size(167, 109);
            this.txtStringReader.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 176);
            this.Controls.Add(this.txtStringReader);
            this.Controls.Add(this.txtStrings);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "StringWriter e StringReader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtStrings;
        private System.Windows.Forms.TextBox txtStringReader;
    }
}

