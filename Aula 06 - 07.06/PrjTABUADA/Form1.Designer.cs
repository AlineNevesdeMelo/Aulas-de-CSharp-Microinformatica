
namespace PrjTABUADA
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.btncalc = new System.Windows.Forms.Button();
            this.btnclean = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.lsttab = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(171, 25);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(154, 46);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Tabuada";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(34, 91);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(182, 24);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Informe o número:";
            // 
            // txtnum
            // 
            this.txtnum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum.Location = new System.Drawing.Point(31, 129);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(185, 30);
            this.txtnum.TabIndex = 2;
            // 
            // btncalc
            // 
            this.btncalc.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalc.Location = new System.Drawing.Point(31, 189);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(184, 46);
            this.btncalc.TabIndex = 3;
            this.btncalc.Text = "Visualizar";
            this.btncalc.UseVisualStyleBackColor = true;
            this.btncalc.Click += new System.EventHandler(this.btncalc_Click);
            // 
            // btnclean
            // 
            this.btnclean.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclean.Location = new System.Drawing.Point(30, 269);
            this.btnclean.Name = "btnclean";
            this.btnclean.Size = new System.Drawing.Size(184, 43);
            this.btnclean.TabIndex = 4;
            this.btnclean.Text = "Limpar";
            this.btnclean.UseVisualStyleBackColor = true;
            this.btnclean.Click += new System.EventHandler(this.btnclean_Click);
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(31, 344);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(182, 44);
            this.btnclose.TabIndex = 5;
            this.btnclose.Text = "Sair";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // lsttab
            // 
            this.lsttab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsttab.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsttab.FormattingEnabled = true;
            this.lsttab.ItemHeight = 24;
            this.lsttab.Location = new System.Drawing.Point(245, 88);
            this.lsttab.Name = "lsttab";
            this.lsttab.Size = new System.Drawing.Size(258, 314);
            this.lsttab.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(529, 419);
            this.Controls.Add(this.lsttab);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnclean);
            this.Controls.Add(this.btncalc);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Tabuada";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.Button btncalc;
        private System.Windows.Forms.Button btnclean;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.ListBox lsttab;
    }
}

