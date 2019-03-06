namespace Client
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
            this.btnInvocarService = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.dtResult = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtResult)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInvocarService
            // 
            this.btnInvocarService.Location = new System.Drawing.Point(21, 23);
            this.btnInvocarService.Name = "btnInvocarService";
            this.btnInvocarService.Size = new System.Drawing.Size(75, 23);
            this.btnInvocarService.TabIndex = 0;
            this.btnInvocarService.Text = "Invocar";
            this.btnInvocarService.UseVisualStyleBackColor = true;
            this.btnInvocarService.Click += new System.EventHandler(this.btnInvocarService_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(21, 61);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(207, 20);
            this.txtResult.TabIndex = 1;
            // 
            // dtResult
            // 
            this.dtResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtResult.Location = new System.Drawing.Point(21, 97);
            this.dtResult.Name = "dtResult";
            this.dtResult.Size = new System.Drawing.Size(345, 204);
            this.dtResult.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 309);
            this.Controls.Add(this.dtResult);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnInvocarService);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInvocarService;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.DataGridView dtResult;
    }
}

