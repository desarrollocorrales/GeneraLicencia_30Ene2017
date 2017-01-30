namespace GeneraLicencia
{
    partial class Genera13
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
            this.tbDecifrado = new System.Windows.Forms.TextBox();
            this.tbCifrado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCifrar = new System.Windows.Forms.Button();
            this.btnDecifrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbDecifrado
            // 
            this.tbDecifrado.Location = new System.Drawing.Point(14, 229);
            this.tbDecifrado.Margin = new System.Windows.Forms.Padding(5);
            this.tbDecifrado.Multiline = true;
            this.tbDecifrado.Name = "tbDecifrado";
            this.tbDecifrado.Size = new System.Drawing.Size(622, 108);
            this.tbDecifrado.TabIndex = 12;
            // 
            // tbCifrado
            // 
            this.tbCifrado.Location = new System.Drawing.Point(14, 37);
            this.tbCifrado.Margin = new System.Windows.Forms.Padding(5);
            this.tbCifrado.Multiline = true;
            this.tbCifrado.Name = "tbCifrado";
            this.tbCifrado.Size = new System.Drawing.Size(622, 108);
            this.tbCifrado.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(14, 201);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Texto Encriptado";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Texto Normal";
            // 
            // btnCifrar
            // 
            this.btnCifrar.Location = new System.Drawing.Point(478, 155);
            this.btnCifrar.Margin = new System.Windows.Forms.Padding(5);
            this.btnCifrar.Name = "btnCifrar";
            this.btnCifrar.Size = new System.Drawing.Size(125, 41);
            this.btnCifrar.TabIndex = 7;
            this.btnCifrar.Text = "Cifrar";
            this.btnCifrar.UseVisualStyleBackColor = true;
            this.btnCifrar.Click += new System.EventHandler(this.btnCifrar_Click);
            // 
            // btnDecifrar
            // 
            this.btnDecifrar.Location = new System.Drawing.Point(478, 347);
            this.btnDecifrar.Margin = new System.Windows.Forms.Padding(5);
            this.btnDecifrar.Name = "btnDecifrar";
            this.btnDecifrar.Size = new System.Drawing.Size(125, 41);
            this.btnDecifrar.TabIndex = 8;
            this.btnDecifrar.Text = "Decifrar";
            this.btnDecifrar.UseVisualStyleBackColor = true;
            this.btnDecifrar.Click += new System.EventHandler(this.btnDecifrar_Click);
            // 
            // Genera13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 403);
            this.Controls.Add(this.tbDecifrado);
            this.Controls.Add(this.tbCifrado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCifrar);
            this.Controls.Add(this.btnDecifrar);
            this.Font = new System.Drawing.Font("Tahoma", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Genera13";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Genera";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDecifrado;
        private System.Windows.Forms.TextBox tbCifrado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCifrar;
        private System.Windows.Forms.Button btnDecifrar;
    }
}