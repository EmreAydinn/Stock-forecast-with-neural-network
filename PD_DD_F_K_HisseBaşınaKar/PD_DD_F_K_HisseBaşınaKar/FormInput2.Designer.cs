namespace PD_DD_F_K_HisseBaşınaKar
{
    partial class FormInput2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelepochsayısı = new System.Windows.Forms.Label();
            this.textBoxhepsiaynı = new System.Windows.Forms.TextBox();
            this.radioButtonhepsiaynı = new System.Windows.Forms.RadioButton();
            this.radioButtontektek = new System.Windows.Forms.RadioButton();
            this.buttontest = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttoneğit = new System.Windows.Forms.Button();
            this.backgroundWorkereğitim = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttongeri = new System.Windows.Forms.Button();
            this.buttoniptal = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxşirketler = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Gizli katmandaki nöron sayıları ";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelepochsayısı);
            this.panel1.Controls.Add(this.textBoxhepsiaynı);
            this.panel1.Controls.Add(this.radioButtonhepsiaynı);
            this.panel1.Controls.Add(this.radioButtontektek);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(334, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 455);
            this.panel1.TabIndex = 6;
            // 
            // labelepochsayısı
            // 
            this.labelepochsayısı.AutoSize = true;
            this.labelepochsayısı.Location = new System.Drawing.Point(140, 103);
            this.labelepochsayısı.Name = "labelepochsayısı";
            this.labelepochsayısı.Size = new System.Drawing.Size(10, 13);
            this.labelepochsayısı.TabIndex = 7;
            this.labelepochsayısı.Text = " ";
            // 
            // textBoxhepsiaynı
            // 
            this.textBoxhepsiaynı.Location = new System.Drawing.Point(137, 59);
            this.textBoxhepsiaynı.Name = "textBoxhepsiaynı";
            this.textBoxhepsiaynı.Size = new System.Drawing.Size(75, 20);
            this.textBoxhepsiaynı.TabIndex = 1;
            this.textBoxhepsiaynı.TextChanged += new System.EventHandler(this.textBoxhepsiaynı_TextChanged);
            this.textBoxhepsiaynı.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxhepsiaynı_KeyPress);
            // 
            // radioButtonhepsiaynı
            // 
            this.radioButtonhepsiaynı.AutoSize = true;
            this.radioButtonhepsiaynı.Checked = true;
            this.radioButtonhepsiaynı.Location = new System.Drawing.Point(137, 35);
            this.radioButtonhepsiaynı.Name = "radioButtonhepsiaynı";
            this.radioButtonhepsiaynı.Size = new System.Drawing.Size(75, 17);
            this.radioButtonhepsiaynı.TabIndex = 0;
            this.radioButtonhepsiaynı.TabStop = true;
            this.radioButtonhepsiaynı.Text = "Hepsi Aynı";
            this.radioButtonhepsiaynı.UseVisualStyleBackColor = true;
            this.radioButtonhepsiaynı.CheckedChanged += new System.EventHandler(this.radioButtonhepsiaynı_CheckedChanged);
            // 
            // radioButtontektek
            // 
            this.radioButtontektek.AutoSize = true;
            this.radioButtontektek.Location = new System.Drawing.Point(27, 37);
            this.radioButtontektek.Name = "radioButtontektek";
            this.radioButtontektek.Size = new System.Drawing.Size(69, 17);
            this.radioButtontektek.TabIndex = 0;
            this.radioButtontektek.Text = " Tek Tek";
            this.radioButtontektek.UseVisualStyleBackColor = true;
            // 
            // buttontest
            // 
            this.buttontest.Enabled = false;
            this.buttontest.Location = new System.Drawing.Point(578, 112);
            this.buttontest.Name = "buttontest";
            this.buttontest.Size = new System.Drawing.Size(124, 55);
            this.buttontest.TabIndex = 13;
            this.buttontest.Text = "Test Et";
            this.buttontest.UseVisualStyleBackColor = true;
            this.buttontest.Click += new System.EventHandler(this.buttontest_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(168, 38);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(160, 459);
            this.listBox2.TabIndex = 9;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(2, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(160, 459);
            this.listBox1.TabIndex = 10;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar1.Location = new System.Drawing.Point(334, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(368, 23);
            this.progressBar1.TabIndex = 8;
            // 
            // buttoneğit
            // 
            this.buttoneğit.Location = new System.Drawing.Point(578, 51);
            this.buttoneğit.Name = "buttoneğit";
            this.buttoneğit.Size = new System.Drawing.Size(124, 55);
            this.buttoneğit.TabIndex = 7;
            this.buttoneğit.Text = "Eğit";
            this.buttoneğit.UseVisualStyleBackColor = true;
            this.buttoneğit.Click += new System.EventHandler(this.buttoneğit_Click);
            // 
            // backgroundWorkereğitim
            // 
            this.backgroundWorkereğitim.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkereğitim_DoWork);
            this.backgroundWorkereğitim.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkereğitim_ProgressChanged);
            this.backgroundWorkereğitim.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkereğitim_RunWorkerCompleted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(28, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Gerçek Sonuçlar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(195, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Eğitim Sonuçları";
            // 
            // buttongeri
            // 
            this.buttongeri.Location = new System.Drawing.Point(578, 473);
            this.buttongeri.Name = "buttongeri";
            this.buttongeri.Size = new System.Drawing.Size(75, 23);
            this.buttongeri.TabIndex = 15;
            this.buttongeri.Text = "Geri";
            this.buttongeri.UseVisualStyleBackColor = true;
            this.buttongeri.Click += new System.EventHandler(this.buttongeri_Click);
            // 
            // buttoniptal
            // 
            this.buttoniptal.Location = new System.Drawing.Point(659, 473);
            this.buttoniptal.Name = "buttoniptal";
            this.buttoniptal.Size = new System.Drawing.Size(75, 23);
            this.buttoniptal.TabIndex = 16;
            this.buttoniptal.Text = "İptal";
            this.buttoniptal.UseVisualStyleBackColor = true;
            this.buttoniptal.Click += new System.EventHandler(this.buttoniptal_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(605, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = " Şirket Lİstesi";
            // 
            // comboBoxşirketler
            // 
            this.comboBoxşirketler.FormattingEnabled = true;
            this.comboBoxşirketler.Items.AddRange(new object[] {
            "Ak Bankası",
            "İş Bankası",
            "Koç Holding"});
            this.comboBoxşirketler.Location = new System.Drawing.Point(581, 228);
            this.comboBoxşirketler.Name = "comboBoxşirketler";
            this.comboBoxşirketler.Size = new System.Drawing.Size(121, 21);
            this.comboBoxşirketler.TabIndex = 18;
            this.comboBoxşirketler.SelectedIndexChanged += new System.EventHandler(this.comboBoxşirketler_SelectedIndexChanged);
            // 
            // FormInput2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(738, 514);
            this.Controls.Add(this.comboBoxşirketler);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttoniptal);
            this.Controls.Add(this.buttongeri);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttontest);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttoneğit);
            this.Controls.Add(this.panel1);
            this.Name = "FormInput2";
            this.Text = "FormInput2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormInput2_FormClosed);
            this.Load += new System.EventHandler(this.FormInput2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxhepsiaynı;
        private System.Windows.Forms.RadioButton radioButtonhepsiaynı;
        private System.Windows.Forms.RadioButton radioButtontektek;
        private System.Windows.Forms.Button buttontest;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button buttoneğit;
        private System.ComponentModel.BackgroundWorker backgroundWorkereğitim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttongeri;
        private System.Windows.Forms.Button buttoniptal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxşirketler;
        private System.Windows.Forms.Label labelepochsayısı;
    }
}