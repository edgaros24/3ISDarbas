
namespace WinFormsApp1
{
    partial class WithoutLib
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
            this.label3 = new System.Windows.Forms.Label();
            this.txt_tekstas = new System.Windows.Forms.TextBox();
            this.txt_Uzsifruotas = new System.Windows.Forms.TextBox();
            this.txt_Desifruotas = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_publicKey = new System.Windows.Forms.TextBox();
            this.txt_privateKey = new System.Windows.Forms.TextBox();
            this.txt_p = new System.Windows.Forms.TextBox();
            this.txt_q = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tekstas*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Uzsifruotas tekstas";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Desifruotas tekstas";
            // 
            // txt_tekstas
            // 
            this.txt_tekstas.Location = new System.Drawing.Point(96, 89);
            this.txt_tekstas.Name = "txt_tekstas";
            this.txt_tekstas.Size = new System.Drawing.Size(588, 27);
            this.txt_tekstas.TabIndex = 3;
            // 
            // txt_Uzsifruotas
            // 
            this.txt_Uzsifruotas.Location = new System.Drawing.Point(96, 183);
            this.txt_Uzsifruotas.Name = "txt_Uzsifruotas";
            this.txt_Uzsifruotas.Size = new System.Drawing.Size(588, 27);
            this.txt_Uzsifruotas.TabIndex = 4;
            // 
            // txt_Desifruotas
            // 
            this.txt_Desifruotas.Location = new System.Drawing.Point(96, 282);
            this.txt_Desifruotas.Name = "txt_Desifruotas";
            this.txt_Desifruotas.Size = new System.Drawing.Size(588, 27);
            this.txt_Desifruotas.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(811, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 7;
            this.button2.Text = "back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Public Key";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(462, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Private Key";
            // 
            // txt_publicKey
            // 
            this.txt_publicKey.Location = new System.Drawing.Point(96, 386);
            this.txt_publicKey.Name = "txt_publicKey";
            this.txt_publicKey.Size = new System.Drawing.Size(275, 27);
            this.txt_publicKey.TabIndex = 10;
            // 
            // txt_privateKey
            // 
            this.txt_privateKey.Location = new System.Drawing.Point(462, 386);
            this.txt_privateKey.Name = "txt_privateKey";
            this.txt_privateKey.Size = new System.Drawing.Size(275, 27);
            this.txt_privateKey.TabIndex = 11;
            // 
            // txt_p
            // 
            this.txt_p.Location = new System.Drawing.Point(96, 477);
            this.txt_p.Name = "txt_p";
            this.txt_p.Size = new System.Drawing.Size(275, 27);
            this.txt_p.TabIndex = 12;
            // 
            // txt_q
            // 
            this.txt_q.Location = new System.Drawing.Point(462, 477);
            this.txt_q.Name = "txt_q";
            this.txt_q.Size = new System.Drawing.Size(275, 27);
            this.txt_q.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(462, 439);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Prime number q*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(96, 433);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Prime number p*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(96, 562);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "label8";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(811, 87);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 18;
            this.button3.Text = "Sifruoti";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(811, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 19;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // WithoutLib
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 637);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_q);
            this.Controls.Add(this.txt_p);
            this.Controls.Add(this.txt_privateKey);
            this.Controls.Add(this.txt_publicKey);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_Desifruotas);
            this.Controls.Add(this.txt_Uzsifruotas);
            this.Controls.Add(this.txt_tekstas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "WithoutLib";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_tekstas;
        private System.Windows.Forms.TextBox txt_Uzsifruotas;
        private System.Windows.Forms.TextBox txt_Desifruotas;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_publicKey;
        private System.Windows.Forms.TextBox txt_privateKey;
        private System.Windows.Forms.TextBox txt_p;
        private System.Windows.Forms.TextBox txt_q;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}