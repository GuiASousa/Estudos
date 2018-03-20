namespace Aula_1
{
    partial class main
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
            this.btn_show = new System.Windows.Forms.Button();
            this.txtbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_show
            // 
            this.btn_show.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_show.Location = new System.Drawing.Point(12, 325);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(100, 25);
            this.btn_show.TabIndex = 0;
            this.btn_show.Text = "Wow";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtbox
            // 
            this.txtbox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox.ForeColor = System.Drawing.Color.Purple;
            this.txtbox.Location = new System.Drawing.Point(12, 12);
            this.txtbox.Name = "txtbox";
            this.txtbox.Size = new System.Drawing.Size(185, 30);
            this.txtbox.TabIndex = 1;
            this.txtbox.Text = "Batatas";
            this.txtbox.TextChanged += new System.EventHandler(this.txtbox_TextChanged);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.txtbox);
            this.Controls.Add(this.btn_show);
            this.Name = "main";
            this.Text = "Aula 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.TextBox txtbox;
    }
}

