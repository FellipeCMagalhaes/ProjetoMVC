namespace ProjetoMVC.UI
{
    partial class Login
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
            this.btn_login = new System.Windows.Forms.Button();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.txtCpfA11 = new System.Windows.Forms.TextBox();
            this.txtNomeA11 = new System.Windows.Forms.TextBox();
            this.txtNomeMaeA11 = new System.Windows.Forms.TextBox();
            this.lbl_mae = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(164, 201);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(98, 33);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Location = new System.Drawing.Point(25, 24);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(30, 13);
            this.lbl_cpf.TabIndex = 2;
            this.lbl_cpf.Text = "CPF:";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(25, 73);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(85, 13);
            this.lbl_nome.TabIndex = 3;
            this.lbl_nome.Text = "Nome Completo:";
            // 
            // txtCpfA11
            // 
            this.txtCpfA11.Location = new System.Drawing.Point(28, 40);
            this.txtCpfA11.Name = "txtCpfA11";
            this.txtCpfA11.Size = new System.Drawing.Size(368, 20);
            this.txtCpfA11.TabIndex = 4;
            // 
            // txtNomeA11
            // 
            this.txtNomeA11.Location = new System.Drawing.Point(28, 89);
            this.txtNomeA11.Name = "txtNomeA11";
            this.txtNomeA11.Size = new System.Drawing.Size(368, 20);
            this.txtNomeA11.TabIndex = 5;
            // 
            // txtNomeMaeA11
            // 
            this.txtNomeMaeA11.Location = new System.Drawing.Point(28, 138);
            this.txtNomeMaeA11.Name = "txtNomeMaeA11";
            this.txtNomeMaeA11.Size = new System.Drawing.Size(368, 20);
            this.txtNomeMaeA11.TabIndex = 7;
            // 
            // lbl_mae
            // 
            this.lbl_mae.AutoSize = true;
            this.lbl_mae.Location = new System.Drawing.Point(25, 122);
            this.lbl_mae.Name = "lbl_mae";
            this.lbl_mae.Size = new System.Drawing.Size(77, 13);
            this.lbl_mae.TabIndex = 6;
            this.lbl_mae.Text = "Nome da Mãe:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 246);
            this.Controls.Add(this.txtNomeMaeA11);
            this.Controls.Add(this.lbl_mae);
            this.Controls.Add(this.txtNomeA11);
            this.Controls.Add(this.txtCpfA11);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.lbl_cpf);
            this.Controls.Add(this.btn_login);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.TextBox txtCpfA11;
        private System.Windows.Forms.TextBox txtNomeA11;
        private System.Windows.Forms.TextBox txtNomeMaeA11;
        private System.Windows.Forms.Label lbl_mae;
    }
}