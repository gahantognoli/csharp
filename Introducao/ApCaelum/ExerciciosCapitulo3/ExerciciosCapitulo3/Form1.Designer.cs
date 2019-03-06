namespace ExerciciosCapitulo3
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
            this.btnExercicio1 = new System.Windows.Forms.Button();
            this.btnExercicio3 = new System.Windows.Forms.Button();
            this.btnExercicio2 = new System.Windows.Forms.Button();
            this.btnExercicio4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExercicio1
            // 
            this.btnExercicio1.Location = new System.Drawing.Point(12, 12);
            this.btnExercicio1.Name = "btnExercicio1";
            this.btnExercicio1.Size = new System.Drawing.Size(142, 68);
            this.btnExercicio1.TabIndex = 0;
            this.btnExercicio1.Text = "Exercicio 1";
            this.btnExercicio1.UseVisualStyleBackColor = true;
            this.btnExercicio1.Click += new System.EventHandler(this.btnExercicio1_Click);
            // 
            // btnExercicio3
            // 
            this.btnExercicio3.Location = new System.Drawing.Point(12, 86);
            this.btnExercicio3.Name = "btnExercicio3";
            this.btnExercicio3.Size = new System.Drawing.Size(142, 68);
            this.btnExercicio3.TabIndex = 1;
            this.btnExercicio3.Text = "Exercicio 3";
            this.btnExercicio3.UseVisualStyleBackColor = true;
            this.btnExercicio3.Click += new System.EventHandler(this.btnExercicio3_Click);
            // 
            // btnExercicio2
            // 
            this.btnExercicio2.Location = new System.Drawing.Point(160, 12);
            this.btnExercicio2.Name = "btnExercicio2";
            this.btnExercicio2.Size = new System.Drawing.Size(142, 68);
            this.btnExercicio2.TabIndex = 2;
            this.btnExercicio2.Text = "Exercicio 2";
            this.btnExercicio2.UseVisualStyleBackColor = true;
            this.btnExercicio2.Click += new System.EventHandler(this.btnExercicio2_Click);
            // 
            // btnExercicio4
            // 
            this.btnExercicio4.Location = new System.Drawing.Point(160, 86);
            this.btnExercicio4.Name = "btnExercicio4";
            this.btnExercicio4.Size = new System.Drawing.Size(142, 68);
            this.btnExercicio4.TabIndex = 3;
            this.btnExercicio4.Text = "Exercicio 1";
            this.btnExercicio4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 165);
            this.Controls.Add(this.btnExercicio4);
            this.Controls.Add(this.btnExercicio2);
            this.Controls.Add(this.btnExercicio3);
            this.Controls.Add(this.btnExercicio1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExercicio1;
        private System.Windows.Forms.Button btnExercicio3;
        private System.Windows.Forms.Button btnExercicio2;
        private System.Windows.Forms.Button btnExercicio4;
    }
}

