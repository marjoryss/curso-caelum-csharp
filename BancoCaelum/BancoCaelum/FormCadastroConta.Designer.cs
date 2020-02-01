namespace BancoCaelum
{
    partial class FormCadastroConta
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textNumero = new System.Windows.Forms.TextBox();
            this.textTitular = new System.Windows.Forms.TextBox();
            this.botaoCadastro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Titular";
            // 
            // textNumero
            // 
            this.textNumero.Location = new System.Drawing.Point(62, 17);
            this.textNumero.Name = "textNumero";
            this.textNumero.Size = new System.Drawing.Size(121, 20);
            this.textNumero.TabIndex = 2;
            // 
            // textTitular
            // 
            this.textTitular.Location = new System.Drawing.Point(62, 61);
            this.textTitular.Name = "textTitular";
            this.textTitular.Size = new System.Drawing.Size(121, 20);
            this.textTitular.TabIndex = 3;
            // 
            // botaoCadastro
            // 
            this.botaoCadastro.Location = new System.Drawing.Point(62, 104);
            this.botaoCadastro.Name = "botaoCadastro";
            this.botaoCadastro.Size = new System.Drawing.Size(121, 23);
            this.botaoCadastro.TabIndex = 4;
            this.botaoCadastro.Text = "Cadastrar";
            this.botaoCadastro.UseVisualStyleBackColor = true;
            this.botaoCadastro.Click += new System.EventHandler(this.FormCadastroConta_Click);
            // 
            // FormCadastroConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 181);
            this.Controls.Add(this.botaoCadastro);
            this.Controls.Add(this.textTitular);
            this.Controls.Add(this.textNumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCadastroConta";
            this.Text = "FormCadastroConta";
            this.Click += new System.EventHandler(this.FormCadastroConta_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNumero;
        private System.Windows.Forms.TextBox textTitular;
        private System.Windows.Forms.Button botaoCadastro;
    }
}