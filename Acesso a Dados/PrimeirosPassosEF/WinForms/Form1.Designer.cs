namespace WinForms
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
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnSelectMoreInsert = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSelectWhere = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdateEntityState = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(2, 0);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(289, 36);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnSelectMoreInsert
            // 
            this.btnSelectMoreInsert.Location = new System.Drawing.Point(2, 42);
            this.btnSelectMoreInsert.Name = "btnSelectMoreInsert";
            this.btnSelectMoreInsert.Size = new System.Drawing.Size(289, 36);
            this.btnSelectMoreInsert.TabIndex = 1;
            this.btnSelectMoreInsert.Text = "Select + Insert";
            this.btnSelectMoreInsert.UseVisualStyleBackColor = true;
            this.btnSelectMoreInsert.Click += new System.EventHandler(this.btnSelectMoreInsert_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(289, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Select Loja do Produto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSelectWhere
            // 
            this.btnSelectWhere.Location = new System.Drawing.Point(2, 126);
            this.btnSelectWhere.Name = "btnSelectWhere";
            this.btnSelectWhere.Size = new System.Drawing.Size(289, 36);
            this.btnSelectWhere.TabIndex = 3;
            this.btnSelectWhere.Text = "Select com Where";
            this.btnSelectWhere.UseVisualStyleBackColor = true;
            this.btnSelectWhere.Click += new System.EventHandler(this.btnSelectWhere_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(2, 168);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(289, 36);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(2, 210);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(289, 36);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdateEntityState
            // 
            this.btnUpdateEntityState.Location = new System.Drawing.Point(2, 252);
            this.btnUpdateEntityState.Name = "btnUpdateEntityState";
            this.btnUpdateEntityState.Size = new System.Drawing.Size(289, 36);
            this.btnUpdateEntityState.TabIndex = 6;
            this.btnUpdateEntityState.Text = "Update via EntityState";
            this.btnUpdateEntityState.UseVisualStyleBackColor = true;
            this.btnUpdateEntityState.Click += new System.EventHandler(this.btnUpdateEntityState_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 291);
            this.Controls.Add(this.btnUpdateEntityState);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSelectWhere);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSelectMoreInsert);
            this.Controls.Add(this.btnInsert);
            this.Name = "Form1";
            this.Text = "Crud com Entity Framework";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnSelectMoreInsert;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSelectWhere;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdateEntityState;
    }
}

