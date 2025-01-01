namespace RSAAlgoritmi
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtD = new System.Windows.Forms.TextBox();
            this.txtE = new System.Windows.Forms.TextBox();
            this.txtQ = new System.Windows.Forms.TextBox();
            this.txtP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txttekstiperkriptim = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txttekstiikriptuar = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtbytearray = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txttekstiidekriptuar = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "RSA Parametra te ri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtD);
            this.groupBox1.Controls.Add(this.txtE);
            this.groupBox1.Controls.Add(this.txtQ);
            this.groupBox1.Controls.Add(this.txtP);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 43);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(663, 248);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RSAParametrat";
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(70, 181);
            this.txtD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtD.Multiline = true;
            this.txtD.Name = "txtD";
            this.txtD.ReadOnly = true;
            this.txtD.Size = new System.Drawing.Size(582, 58);
            this.txtD.TabIndex = 7;
            // 
            // txtE
            // 
            this.txtE.Location = new System.Drawing.Point(70, 124);
            this.txtE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtE.Multiline = true;
            this.txtE.Name = "txtE";
            this.txtE.ReadOnly = true;
            this.txtE.Size = new System.Drawing.Size(582, 53);
            this.txtE.TabIndex = 6;
            // 
            // txtQ
            // 
            this.txtQ.Location = new System.Drawing.Point(70, 65);
            this.txtQ.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtQ.Multiline = true;
            this.txtQ.Name = "txtQ";
            this.txtQ.ReadOnly = true;
            this.txtQ.Size = new System.Drawing.Size(582, 55);
            this.txtQ.TabIndex = 5;
            // 
            // txtP
            // 
            this.txtP.Location = new System.Drawing.Point(70, 11);
            this.txtP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtP.Multiline = true;
            this.txtP.Name = "txtP";
            this.txtP.ReadOnly = true;
            this.txtP.Size = new System.Drawing.Size(582, 50);
            this.txtP.TabIndex = 4;
            this.txtP.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 193);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "d";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "e";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "q";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "p";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txttekstiperkriptim);
            this.groupBox2.Location = new System.Drawing.Point(14, 296);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(663, 62);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TekstiPerKriptim";
            // 
            // txttekstiperkriptim
            // 
            this.txttekstiperkriptim.Location = new System.Drawing.Point(14, 22);
            this.txttekstiperkriptim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txttekstiperkriptim.Multiline = true;
            this.txttekstiperkriptim.Name = "txttekstiperkriptim";
            this.txttekstiperkriptim.Size = new System.Drawing.Size(163, 36);
            this.txttekstiperkriptim.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txttekstiikriptuar);
            this.groupBox3.Location = new System.Drawing.Point(18, 409);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(659, 62);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Teksti i kriptuar";
            // 
            // txttekstiikriptuar
            // 
            this.txttekstiikriptuar.Location = new System.Drawing.Point(14, 22);
            this.txttekstiikriptuar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txttekstiikriptuar.Multiline = true;
            this.txttekstiikriptuar.Name = "txttekstiikriptuar";
            this.txttekstiikriptuar.ReadOnly = true;
            this.txttekstiikriptuar.Size = new System.Drawing.Size(626, 36);
            this.txttekstiikriptuar.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(14, 362);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 28);
            this.button2.TabIndex = 4;
            this.button2.Text = "Kripto";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtbytearray);
            this.groupBox4.Location = new System.Drawing.Point(14, 488);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(663, 109);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Teksti i kriptuar si Byte Array";
            // 
            // txtbytearray
            // 
            this.txtbytearray.Location = new System.Drawing.Point(14, 22);
            this.txtbytearray.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbytearray.Multiline = true;
            this.txtbytearray.Name = "txtbytearray";
            this.txtbytearray.ReadOnly = true;
            this.txtbytearray.Size = new System.Drawing.Size(630, 72);
            this.txtbytearray.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(14, 615);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 28);
            this.button3.TabIndex = 5;
            this.button3.Text = "dekripto";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txttekstiidekriptuar);
            this.groupBox5.Location = new System.Drawing.Point(14, 661);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Size = new System.Drawing.Size(663, 62);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Teksti i dekriptuar";
            // 
            // txttekstiidekriptuar
            // 
            this.txttekstiidekriptuar.Location = new System.Drawing.Point(14, 22);
            this.txttekstiidekriptuar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txttekstiidekriptuar.Multiline = true;
            this.txttekstiidekriptuar.Name = "txttekstiidekriptuar";
            this.txttekstiidekriptuar.ReadOnly = true;
            this.txttekstiidekriptuar.Size = new System.Drawing.Size(630, 36);
            this.txttekstiidekriptuar.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 750);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RSA Algoritmi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.TextBox txtE;
        private System.Windows.Forms.TextBox txtQ;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txttekstiperkriptim;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txttekstiikriptuar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtbytearray;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txttekstiidekriptuar;
    }
}

