namespace aula241024
{
    partial class FormCadastro
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
            txtNome = new TextBox();
            txtPreco = new TextBox();
            btnSalvar = new Button();
            lblNome = new Label();
            lblPreco = new Label();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(335, 105);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(125, 27);
            txtNome.TabIndex = 0;
            txtNome.Text = "Nome";
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // txtPreco
            // 
            txtPreco.AcceptsReturn = true;
            txtPreco.Location = new Point(335, 173);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(125, 27);
            txtPreco.TabIndex = 1;
            txtPreco.Text = "Preço";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(347, 236);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 29);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(255, 108);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(0, 20);
            lblNome.TabIndex = 3;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(255, 176);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(0, 20);
            lblPreco.TabIndex = 4;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 399);
            Controls.Add(lblPreco);
            Controls.Add(lblNome);
            Controls.Add(btnSalvar);
            Controls.Add(txtPreco);
            Controls.Add(txtNome);
            Name = "FormCadastro";
            Text = "FormCadastro";
            Load += FormCadastro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtPreco;
        private Button btnSalvar;
        private Label lblNome;
        private Label lblPreco;
    }
}