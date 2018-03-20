namespace ExercAV1
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
            this.txt_cand = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_ing = new System.Windows.Forms.CheckBox();
            this.chk_esp = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rd_sup = new System.Windows.Forms.RadioButton();
            this.rd_pos = new System.Windows.Forms.RadioButton();
            this.rd_fem = new System.Windows.Forms.RadioButton();
            this.rd_masc = new System.Windows.Forms.RadioButton();
            this.cmb_estciv = new System.Windows.Forms.ComboBox();
            this.btn_exb = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_cand
            // 
            this.txt_cand.Location = new System.Drawing.Point(12, 73);
            this.txt_cand.Name = "txt_cand";
            this.txt_cand.Size = new System.Drawing.Size(335, 20);
            this.txt_cand.TabIndex = 0;
            this.txt_cand.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome do Candidato:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(404, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Estado Civil:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rd_fem);
            this.groupBox3.Controls.Add(this.rd_masc);
            this.groupBox3.Location = new System.Drawing.Point(12, 124);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(140, 90);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sexo:";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rd_pos);
            this.groupBox1.Controls.Add(this.rd_sup);
            this.groupBox1.Location = new System.Drawing.Point(207, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 90);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nível Escolaridade:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chk_ing
            // 
            this.chk_ing.AutoSize = true;
            this.chk_ing.Location = new System.Drawing.Point(407, 153);
            this.chk_ing.Name = "chk_ing";
            this.chk_ing.Size = new System.Drawing.Size(54, 17);
            this.chk_ing.TabIndex = 7;
            this.chk_ing.Text = "Inglês";
            this.chk_ing.UseVisualStyleBackColor = true;
            // 
            // chk_esp
            // 
            this.chk_esp.AutoSize = true;
            this.chk_esp.Location = new System.Drawing.Point(407, 176);
            this.chk_esp.Name = "chk_esp";
            this.chk_esp.Size = new System.Drawing.Size(70, 17);
            this.chk_esp.TabIndex = 8;
            this.chk_esp.Text = "Espanhol";
            this.chk_esp.UseVisualStyleBackColor = true;
            this.chk_esp.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Idiomas:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // rd_sup
            // 
            this.rd_sup.AutoSize = true;
            this.rd_sup.Location = new System.Drawing.Point(6, 28);
            this.rd_sup.Name = "rd_sup";
            this.rd_sup.Size = new System.Drawing.Size(64, 17);
            this.rd_sup.TabIndex = 0;
            this.rd_sup.TabStop = true;
            this.rd_sup.Text = "Superior";
            this.rd_sup.UseVisualStyleBackColor = true;
            this.rd_sup.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rd_pos
            // 
            this.rd_pos.AutoSize = true;
            this.rd_pos.Location = new System.Drawing.Point(6, 51);
            this.rd_pos.Name = "rd_pos";
            this.rd_pos.Size = new System.Drawing.Size(99, 17);
            this.rd_pos.TabIndex = 1;
            this.rd_pos.TabStop = true;
            this.rd_pos.Text = "Pós-Graduação";
            this.rd_pos.UseVisualStyleBackColor = true;
            this.rd_pos.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rd_fem
            // 
            this.rd_fem.AutoSize = true;
            this.rd_fem.Location = new System.Drawing.Point(16, 52);
            this.rd_fem.Name = "rd_fem";
            this.rd_fem.Size = new System.Drawing.Size(67, 17);
            this.rd_fem.TabIndex = 3;
            this.rd_fem.TabStop = true;
            this.rd_fem.Text = "Feminino";
            this.rd_fem.UseVisualStyleBackColor = true;
            this.rd_fem.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged_1);
            // 
            // rd_masc
            // 
            this.rd_masc.AutoSize = true;
            this.rd_masc.Location = new System.Drawing.Point(16, 29);
            this.rd_masc.Name = "rd_masc";
            this.rd_masc.Size = new System.Drawing.Size(73, 17);
            this.rd_masc.TabIndex = 2;
            this.rd_masc.TabStop = true;
            this.rd_masc.Text = "Masculino";
            this.rd_masc.UseVisualStyleBackColor = true;
            this.rd_masc.CheckedChanged += new System.EventHandler(this.btn_masc_CheckedChanged);
            // 
            // cmb_estciv
            // 
            this.cmb_estciv.FormattingEnabled = true;
            this.cmb_estciv.Location = new System.Drawing.Point(407, 73);
            this.cmb_estciv.Name = "cmb_estciv";
            this.cmb_estciv.Size = new System.Drawing.Size(177, 21);
            this.cmb_estciv.TabIndex = 10;
            this.cmb_estciv.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_exb
            // 
            this.btn_exb.Location = new System.Drawing.Point(469, 292);
            this.btn_exb.Name = "btn_exb";
            this.btn_exb.Size = new System.Drawing.Size(115, 37);
            this.btn_exb.TabIndex = 11;
            this.btn_exb.Text = "Exibir";
            this.btn_exb.UseVisualStyleBackColor = true;
            this.btn_exb.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 341);
            this.Controls.Add(this.btn_exb);
            this.Controls.Add(this.cmb_estciv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chk_esp);
            this.Controls.Add(this.chk_ing);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_cand);
            this.Name = "Form1";
            this.Text = "Exercício Avaliação 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_cand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chk_ing;
        private System.Windows.Forms.CheckBox chk_esp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rd_pos;
        private System.Windows.Forms.RadioButton rd_sup;
        private System.Windows.Forms.RadioButton rd_fem;
        private System.Windows.Forms.RadioButton rd_masc;
        private System.Windows.Forms.ComboBox cmb_estciv;
        private System.Windows.Forms.Button btn_exb;
    }
}

