namespace Aula_2
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
            this.Label_name = new System.Windows.Forms.Label();
            this.btn_listar = new System.Windows.Forms.Button();
            this.chk_lp1 = new System.Windows.Forms.CheckBox();
            this.lbl_cursos = new System.Windows.Forms.Label();
            this.chk_lp2 = new System.Windows.Forms.CheckBox();
            this.chk_ed = new System.Windows.Forms.CheckBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Label_name
            // 
            this.Label_name.AutoSize = true;
            this.Label_name.Location = new System.Drawing.Point(12, 9);
            this.Label_name.Name = "Label_name";
            this.Label_name.Size = new System.Drawing.Size(48, 16);
            this.Label_name.TabIndex = 1;
            this.Label_name.Text = "Nome:";
            this.Label_name.Click += new System.EventHandler(this.Label_name_Click);
            // 
            // btn_listar
            // 
            this.btn_listar.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_listar.Location = new System.Drawing.Point(428, 25);
            this.btn_listar.Name = "btn_listar";
            this.btn_listar.Size = new System.Drawing.Size(103, 30);
            this.btn_listar.TabIndex = 2;
            this.btn_listar.Text = "Listar";
            this.btn_listar.UseVisualStyleBackColor = true;
            this.btn_listar.Click += new System.EventHandler(this.btn_listar_Click);
            // 
            // chk_lp1
            // 
            this.chk_lp1.AutoSize = true;
            this.chk_lp1.Location = new System.Drawing.Point(15, 87);
            this.chk_lp1.Name = "chk_lp1";
            this.chk_lp1.Size = new System.Drawing.Size(50, 20);
            this.chk_lp1.TabIndex = 3;
            this.chk_lp1.Text = "LP1";
            this.chk_lp1.UseVisualStyleBackColor = true;
            // 
            // lbl_cursos
            // 
            this.lbl_cursos.AutoSize = true;
            this.lbl_cursos.Location = new System.Drawing.Point(12, 68);
            this.lbl_cursos.Name = "lbl_cursos";
            this.lbl_cursos.Size = new System.Drawing.Size(90, 16);
            this.lbl_cursos.TabIndex = 4;
            this.lbl_cursos.Text = "Cursos Extras";
            // 
            // chk_lp2
            // 
            this.chk_lp2.AutoSize = true;
            this.chk_lp2.Location = new System.Drawing.Point(15, 114);
            this.chk_lp2.Name = "chk_lp2";
            this.chk_lp2.Size = new System.Drawing.Size(50, 20);
            this.chk_lp2.TabIndex = 5;
            this.chk_lp2.Text = "LP2";
            this.chk_lp2.UseVisualStyleBackColor = true;
            this.chk_lp2.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chk_ed
            // 
            this.chk_ed.AutoSize = true;
            this.chk_ed.Location = new System.Drawing.Point(15, 140);
            this.chk_ed.Name = "chk_ed";
            this.chk_ed.Size = new System.Drawing.Size(142, 20);
            this.chk_ed.TabIndex = 6;
            this.chk_ed.Text = "Estrutura de Dados";
            this.chk_ed.UseVisualStyleBackColor = true;
            // 
            // txt_nome
            // 
            this.txt_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.Location = new System.Drawing.Point(13, 29);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(304, 26);
            this.txt_nome.TabIndex = 7;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(543, 399);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.chk_ed);
            this.Controls.Add(this.chk_lp2);
            this.Controls.Add(this.lbl_cursos);
            this.Controls.Add(this.chk_lp1);
            this.Controls.Add(this.btn_listar);
            this.Controls.Add(this.Label_name);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label Label_name;
        private System.Windows.Forms.Button btn_listar;
        private System.Windows.Forms.CheckBox chk_lp1;
        private System.Windows.Forms.Label lbl_cursos;
        private System.Windows.Forms.CheckBox chk_lp2;
        private System.Windows.Forms.CheckBox chk_ed;
        private System.Windows.Forms.TextBox txt_nome;
    }
}

