namespace WindowsFormsApplication1
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
            this.btn_exibir = new System.Windows.Forms.Button();
            this.rdio_casa = new System.Windows.Forms.RadioButton();
            this.rdio_solt = new System.Windows.Forms.RadioButton();
            this.rdio_outros = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdio_masc = new System.Windows.Forms.RadioButton();
            this.rdio_fem = new System.Windows.Forms.RadioButton();
            this.cmbo_curso = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbo_niv = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_exibir
            // 
            this.btn_exibir.Location = new System.Drawing.Point(316, 274);
            this.btn_exibir.Name = "btn_exibir";
            this.btn_exibir.Size = new System.Drawing.Size(75, 23);
            this.btn_exibir.TabIndex = 3;
            this.btn_exibir.Text = "Exibir";
            this.btn_exibir.UseVisualStyleBackColor = true;
            this.btn_exibir.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdio_casa
            // 
            this.rdio_casa.AutoSize = true;
            this.rdio_casa.Location = new System.Drawing.Point(22, 88);
            this.rdio_casa.Name = "rdio_casa";
            this.rdio_casa.Size = new System.Drawing.Size(61, 17);
            this.rdio_casa.TabIndex = 5;
            this.rdio_casa.TabStop = true;
            this.rdio_casa.Text = "Casado";
            this.rdio_casa.UseVisualStyleBackColor = true;
            // 
            // rdio_solt
            // 
            this.rdio_solt.Location = new System.Drawing.Point(22, 65);
            this.rdio_solt.Name = "rdio_solt";
            this.rdio_solt.Size = new System.Drawing.Size(85, 17);
            this.rdio_solt.TabIndex = 4;
            this.rdio_solt.TabStop = true;
            this.rdio_solt.Text = "Solteiro";
            this.rdio_solt.UseVisualStyleBackColor = true;
            // 
            // rdio_outros
            // 
            this.rdio_outros.Location = new System.Drawing.Point(22, 111);
            this.rdio_outros.Name = "rdio_outros";
            this.rdio_outros.Size = new System.Drawing.Size(85, 17);
            this.rdio_outros.TabIndex = 7;
            this.rdio_outros.TabStop = true;
            this.rdio_outros.Text = "Outros";
            this.rdio_outros.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdio_solt);
            this.groupBox1.Controls.Add(this.rdio_outros);
            this.groupBox1.Controls.Add(this.rdio_casa);
            this.groupBox1.Location = new System.Drawing.Point(256, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 184);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado Civil";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdio_masc);
            this.groupBox2.Controls.Add(this.rdio_fem);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(135, 184);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sexo";
            // 
            // rdio_masc
            // 
            this.rdio_masc.Location = new System.Drawing.Point(22, 65);
            this.rdio_masc.Name = "rdio_masc";
            this.rdio_masc.Size = new System.Drawing.Size(85, 17);
            this.rdio_masc.TabIndex = 4;
            this.rdio_masc.TabStop = true;
            this.rdio_masc.Text = "Masculino";
            this.rdio_masc.UseVisualStyleBackColor = true;
            // 
            // rdio_fem
            // 
            this.rdio_fem.AutoSize = true;
            this.rdio_fem.Location = new System.Drawing.Point(22, 88);
            this.rdio_fem.Name = "rdio_fem";
            this.rdio_fem.Size = new System.Drawing.Size(67, 17);
            this.rdio_fem.TabIndex = 5;
            this.rdio_fem.TabStop = true;
            this.rdio_fem.Text = "Feminino";
            this.rdio_fem.UseVisualStyleBackColor = true;
            // 
            // cmbo_curso
            // 
            this.cmbo_curso.FormattingEnabled = true;
            this.cmbo_curso.Items.AddRange(new object[] {
            "Análise e Desenvolvimento de Sistemas",
            "Sistemas Biomédicos",
            "Projetos Mecânicos",
            "Polímeros"});
            this.cmbo_curso.Location = new System.Drawing.Point(12, 233);
            this.cmbo_curso.Name = "cmbo_curso";
            this.cmbo_curso.Size = new System.Drawing.Size(135, 21);
            this.cmbo_curso.TabIndex = 10;
            this.cmbo_curso.SelectedIndexChanged += new System.EventHandler(this.cmbo_curso_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Curso";
            // 
            // cmbo_niv
            // 
            this.cmbo_niv.FormattingEnabled = true;
            this.cmbo_niv.Location = new System.Drawing.Point(12, 274);
            this.cmbo_niv.Name = "cmbo_niv";
            this.cmbo_niv.Size = new System.Drawing.Size(135, 21);
            this.cmbo_niv.TabIndex = 12;
            this.cmbo_niv.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nível";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 309);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbo_niv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbo_curso);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_exibir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exibir;
        private System.Windows.Forms.RadioButton rdio_casa;
        private System.Windows.Forms.RadioButton rdio_solt;
        private System.Windows.Forms.RadioButton rdio_outros;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdio_masc;
        private System.Windows.Forms.RadioButton rdio_fem;
        private System.Windows.Forms.ComboBox cmbo_curso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbo_niv;
        private System.Windows.Forms.Label label2;
    }
}

