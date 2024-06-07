
namespace ProgramaMediaAlunos
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
            this.aprovados = new System.Windows.Forms.ListBox();
            this.reprovados = new System.Windows.Forms.ListBox();
            this.lblnome = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.lblnota1 = new System.Windows.Forms.Label();
            this.txtnota1 = new System.Windows.Forms.TextBox();
            this.lblnota2 = new System.Windows.Forms.Label();
            this.txtnota2 = new System.Windows.Forms.TextBox();
            this.lblnota3 = new System.Windows.Forms.Label();
            this.txtnota3 = new System.Windows.Forms.TextBox();
            this.lblnota4 = new System.Windows.Forms.Label();
            this.txtnota4 = new System.Windows.Forms.TextBox();
            this.btnmedia = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.btnlimparlst = new System.Windows.Forms.Button();
            this.lblaprovados = new System.Windows.Forms.Label();
            this.lblreprovados = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblqtap = new System.Windows.Forms.Label();
            this.lblqtrep = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // aprovados
            // 
            this.aprovados.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.aprovados.FormattingEnabled = true;
            this.aprovados.ItemHeight = 16;
            this.aprovados.Location = new System.Drawing.Point(350, 47);
            this.aprovados.Name = "aprovados";
            this.aprovados.Size = new System.Drawing.Size(201, 356);
            this.aprovados.TabIndex = 0;
            // 
            // reprovados
            // 
            this.reprovados.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.reprovados.FormattingEnabled = true;
            this.reprovados.ItemHeight = 16;
            this.reprovados.Location = new System.Drawing.Point(576, 47);
            this.reprovados.Name = "reprovados";
            this.reprovados.Size = new System.Drawing.Size(211, 356);
            this.reprovados.TabIndex = 1;
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.ForeColor = System.Drawing.Color.White;
            this.lblnome.Location = new System.Drawing.Point(26, 20);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(147, 25);
            this.lblnome.TabIndex = 2;
            this.lblnome.Text = "Nome do Aluno";
            // 
            // txtnome
            // 
            this.txtnome.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtnome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.Location = new System.Drawing.Point(31, 54);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(270, 30);
            this.txtnome.TabIndex = 3;
            // 
            // lblnota1
            // 
            this.lblnota1.AutoSize = true;
            this.lblnota1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblnota1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnota1.ForeColor = System.Drawing.Color.White;
            this.lblnota1.Location = new System.Drawing.Point(44, 101);
            this.lblnota1.Name = "lblnota1";
            this.lblnota1.Size = new System.Drawing.Size(69, 25);
            this.lblnota1.TabIndex = 4;
            this.lblnota1.Text = "Nota 1";
            // 
            // txtnota1
            // 
            this.txtnota1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtnota1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnota1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnota1.Location = new System.Drawing.Point(119, 99);
            this.txtnota1.Name = "txtnota1";
            this.txtnota1.Size = new System.Drawing.Size(98, 30);
            this.txtnota1.TabIndex = 5;
            // 
            // lblnota2
            // 
            this.lblnota2.AutoSize = true;
            this.lblnota2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblnota2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnota2.ForeColor = System.Drawing.Color.White;
            this.lblnota2.Location = new System.Drawing.Point(44, 148);
            this.lblnota2.Name = "lblnota2";
            this.lblnota2.Size = new System.Drawing.Size(69, 25);
            this.lblnota2.TabIndex = 6;
            this.lblnota2.Text = "Nota 2";
            // 
            // txtnota2
            // 
            this.txtnota2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtnota2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnota2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnota2.Location = new System.Drawing.Point(120, 143);
            this.txtnota2.Name = "txtnota2";
            this.txtnota2.Size = new System.Drawing.Size(99, 30);
            this.txtnota2.TabIndex = 7;
            // 
            // lblnota3
            // 
            this.lblnota3.AutoSize = true;
            this.lblnota3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblnota3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnota3.ForeColor = System.Drawing.Color.White;
            this.lblnota3.Location = new System.Drawing.Point(44, 190);
            this.lblnota3.Name = "lblnota3";
            this.lblnota3.Size = new System.Drawing.Size(69, 25);
            this.lblnota3.TabIndex = 8;
            this.lblnota3.Text = "Nota 3";
            // 
            // txtnota3
            // 
            this.txtnota3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtnota3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnota3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnota3.Location = new System.Drawing.Point(121, 186);
            this.txtnota3.Name = "txtnota3";
            this.txtnota3.Size = new System.Drawing.Size(98, 30);
            this.txtnota3.TabIndex = 9;
            // 
            // lblnota4
            // 
            this.lblnota4.AutoSize = true;
            this.lblnota4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblnota4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnota4.ForeColor = System.Drawing.Color.White;
            this.lblnota4.Location = new System.Drawing.Point(44, 228);
            this.lblnota4.Name = "lblnota4";
            this.lblnota4.Size = new System.Drawing.Size(69, 25);
            this.lblnota4.TabIndex = 10;
            this.lblnota4.Text = "Nota 4";
            // 
            // txtnota4
            // 
            this.txtnota4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtnota4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnota4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnota4.Location = new System.Drawing.Point(120, 228);
            this.txtnota4.Name = "txtnota4";
            this.txtnota4.Size = new System.Drawing.Size(98, 30);
            this.txtnota4.TabIndex = 11;
            // 
            // btnmedia
            // 
            this.btnmedia.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnmedia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnmedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmedia.ForeColor = System.Drawing.Color.Black;
            this.btnmedia.Location = new System.Drawing.Point(22, 297);
            this.btnmedia.Name = "btnmedia";
            this.btnmedia.Size = new System.Drawing.Size(131, 39);
            this.btnmedia.TabIndex = 12;
            this.btnmedia.Text = "MÉDIA";
            this.btnmedia.UseVisualStyleBackColor = false;
            this.btnmedia.Click += new System.EventHandler(this.btnmedia_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnlimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Location = new System.Drawing.Point(168, 297);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(133, 39);
            this.btnlimpar.TabIndex = 13;
            this.btnlimpar.Text = "LIMPAR";
            this.btnlimpar.UseVisualStyleBackColor = false;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnsair
            // 
            this.btnsair.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnsair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.Location = new System.Drawing.Point(22, 358);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(131, 39);
            this.btnsair.TabIndex = 14;
            this.btnsair.Text = "SAIR";
            this.btnsair.UseVisualStyleBackColor = false;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btnlimparlst
            // 
            this.btnlimparlst.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnlimparlst.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlimparlst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimparlst.Location = new System.Drawing.Point(168, 358);
            this.btnlimparlst.Name = "btnlimparlst";
            this.btnlimparlst.Size = new System.Drawing.Size(133, 39);
            this.btnlimparlst.TabIndex = 15;
            this.btnlimparlst.Text = "LIMPAR LISTAS";
            this.btnlimparlst.UseVisualStyleBackColor = false;
            this.btnlimparlst.Click += new System.EventHandler(this.btnlimparlst_Click);
            // 
            // lblaprovados
            // 
            this.lblaprovados.AutoSize = true;
            this.lblaprovados.BackColor = System.Drawing.Color.Transparent;
            this.lblaprovados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaprovados.ForeColor = System.Drawing.Color.White;
            this.lblaprovados.Location = new System.Drawing.Point(399, 9);
            this.lblaprovados.Name = "lblaprovados";
            this.lblaprovados.Size = new System.Drawing.Size(107, 25);
            this.lblaprovados.TabIndex = 16;
            this.lblaprovados.Text = "Aprovados";
            // 
            // lblreprovados
            // 
            this.lblreprovados.AutoSize = true;
            this.lblreprovados.BackColor = System.Drawing.Color.Transparent;
            this.lblreprovados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreprovados.ForeColor = System.Drawing.Color.White;
            this.lblreprovados.Location = new System.Drawing.Point(628, 9);
            this.lblreprovados.Name = "lblreprovados";
            this.lblreprovados.Size = new System.Drawing.Size(117, 25);
            this.lblreprovados.TabIndex = 17;
            this.lblreprovados.Text = "Reprovados";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(326, 453);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // lblqtap
            // 
            this.lblqtap.AutoSize = true;
            this.lblqtap.ForeColor = System.Drawing.Color.White;
            this.lblqtap.Location = new System.Drawing.Point(445, 417);
            this.lblqtap.Name = "lblqtap";
            this.lblqtap.Size = new System.Drawing.Size(16, 17);
            this.lblqtap.TabIndex = 19;
            this.lblqtap.Text = "0";
            // 
            // lblqtrep
            // 
            this.lblqtrep.AutoSize = true;
            this.lblqtrep.ForeColor = System.Drawing.Color.White;
            this.lblqtrep.Location = new System.Drawing.Point(675, 417);
            this.lblqtrep.Name = "lblqtrep";
            this.lblqtrep.Size = new System.Drawing.Size(16, 17);
            this.lblqtrep.TabIndex = 20;
            this.lblqtrep.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(811, 454);
            this.Controls.Add(this.lblqtrep);
            this.Controls.Add(this.lblqtap);
            this.Controls.Add(this.lblreprovados);
            this.Controls.Add(this.lblaprovados);
            this.Controls.Add(this.btnlimparlst);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnmedia);
            this.Controls.Add(this.txtnota4);
            this.Controls.Add(this.lblnota4);
            this.Controls.Add(this.txtnota3);
            this.Controls.Add(this.lblnota3);
            this.Controls.Add(this.txtnota2);
            this.Controls.Add(this.lblnota2);
            this.Controls.Add(this.txtnota1);
            this.Controls.Add(this.lblnota1);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.reprovados);
            this.Controls.Add(this.aprovados);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "q";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox aprovados;
        private System.Windows.Forms.ListBox reprovados;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label lblnota1;
        private System.Windows.Forms.TextBox txtnota1;
        private System.Windows.Forms.Label lblnota2;
        private System.Windows.Forms.TextBox txtnota2;
        private System.Windows.Forms.Label lblnota3;
        private System.Windows.Forms.TextBox txtnota3;
        private System.Windows.Forms.Label lblnota4;
        private System.Windows.Forms.TextBox txtnota4;
        private System.Windows.Forms.Button btnmedia;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btnlimparlst;
        private System.Windows.Forms.Label lblaprovados;
        private System.Windows.Forms.Label lblreprovados;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblqtap;
        private System.Windows.Forms.Label lblqtrep;
    }
}

