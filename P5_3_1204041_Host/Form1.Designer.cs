namespace P5_3_1204044_Host
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rbJk1 = new System.Windows.Forms.RadioButton();
            this.rbJk2 = new System.Windows.Forms.RadioButton();
            this.tbAlamat = new System.Windows.Forms.TextBox();
            this.tbTa = new System.Windows.Forms.TextBox();
            this.cbProdi = new System.Windows.Forms.ComboBox();
            this.PilihButton = new System.Windows.Forms.Button();
            this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWrong = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbNama = new P5_3_1204044.CharTextBox();
            this.tbSemester = new P5_3_1204044.NumericTextBox();
            this.tbNim = new P5_3_1204044.NumericTextBox();
            this.gbKurikulum = new System.Windows.Forms.GroupBox();
            this.gbMatkul = new System.Windows.Forms.GroupBox();
            this.cbMatematika = new System.Windows.Forms.CheckBox();
            this.rb2006 = new System.Windows.Forms.RadioButton();
            this.rb2010 = new System.Windows.Forms.RadioButton();
            this.rb2014 = new System.Windows.Forms.RadioButton();
            this.cbP1 = new System.Windows.Forms.CheckBox();
            this.cbP2 = new System.Windows.Forms.CheckBox();
            this.cbP3 = new System.Windows.Forms.CheckBox();
            this.cbP4 = new System.Windows.Forms.CheckBox();
            this.cbP5 = new System.Windows.Forms.CheckBox();
            this.cbP6 = new System.Windows.Forms.CheckBox();
            this.cbP7 = new System.Windows.Forms.CheckBox();
            this.cbLogistik = new System.Windows.Forms.CheckBox();
            this.cbJarkom = new System.Windows.Forms.CheckBox();
            this.cbSisop = new System.Windows.Forms.CheckBox();
            this.cbManajemen = new System.Windows.Forms.CheckBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).BeginInit();
            this.gbKurikulum.SuspendLayout();
            this.gbMatkul.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NIM                :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama              :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(207, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "PILIHAN MATA KULIAH MAHASISWA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Alamat            :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Jenis Kelamin  :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(338, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Program Studi        : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(338, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Tahun Akademik   :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(338, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Semester               :";
            // 
            // rbJk1
            // 
            this.rbJk1.AutoSize = true;
            this.rbJk1.Location = new System.Drawing.Point(110, 140);
            this.rbJk1.Name = "rbJk1";
            this.rbJk1.Size = new System.Drawing.Size(74, 17);
            this.rbJk1.TabIndex = 10;
            this.rbJk1.TabStop = true;
            this.rbJk1.Text = "Laki - Laki";
            this.rbJk1.UseVisualStyleBackColor = true;
            // 
            // rbJk2
            // 
            this.rbJk2.AutoSize = true;
            this.rbJk2.Location = new System.Drawing.Point(190, 140);
            this.rbJk2.Name = "rbJk2";
            this.rbJk2.Size = new System.Drawing.Size(79, 17);
            this.rbJk2.TabIndex = 11;
            this.rbJk2.TabStop = true;
            this.rbJk2.Text = "Perempuan";
            this.rbJk2.UseVisualStyleBackColor = true;
            // 
            // tbAlamat
            // 
            this.tbAlamat.Location = new System.Drawing.Point(109, 174);
            this.tbAlamat.Multiline = true;
            this.tbAlamat.Name = "tbAlamat";
            this.tbAlamat.Size = new System.Drawing.Size(190, 60);
            this.tbAlamat.TabIndex = 12;
            // 
            // tbTa
            // 
            this.tbTa.Location = new System.Drawing.Point(443, 107);
            this.tbTa.Name = "tbTa";
            this.tbTa.Size = new System.Drawing.Size(189, 20);
            this.tbTa.TabIndex = 14;
            this.tbTa.TextChanged += new System.EventHandler(this.txtTa_TextChanged);
            // 
            // cbProdi
            // 
            this.cbProdi.FormattingEnabled = true;
            this.cbProdi.Items.AddRange(new object[] {
            "D4 - Teknik Informatika",
            "D4 - Logistik Bisnis",
            "D4 - Manajemen Bisnis",
            "D4 - Akutansi"});
            this.cbProdi.Location = new System.Drawing.Point(443, 79);
            this.cbProdi.Name = "cbProdi";
            this.cbProdi.Size = new System.Drawing.Size(189, 21);
            this.cbProdi.TabIndex = 15;
            this.cbProdi.Text = "- Pilih Program Studi -";
            // 
            // PilihButton
            // 
            this.PilihButton.Location = new System.Drawing.Point(480, 192);
            this.PilihButton.Name = "PilihButton";
            this.PilihButton.Size = new System.Drawing.Size(116, 24);
            this.PilihButton.TabIndex = 16;
            this.PilihButton.Text = "Pilih Mata Kuliah";
            this.PilihButton.UseVisualStyleBackColor = true;
            this.PilihButton.Click += new System.EventHandler(this.PilihButton_Click);
            // 
            // epWarning
            // 
            this.epWarning.ContainerControl = this;
            this.epWarning.Icon = ((System.Drawing.Icon)(resources.GetObject("epWarning.Icon")));
            // 
            // epCorrect
            // 
            this.epCorrect.ContainerControl = this;
            this.epCorrect.Icon = ((System.Drawing.Icon)(resources.GetObject("epCorrect.Icon")));
            // 
            // epWrong
            // 
            this.epWrong.ContainerControl = this;
            this.epWrong.Icon = ((System.Drawing.Icon)(resources.GetObject("epWrong.Icon")));
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(111, 108);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(188, 20);
            this.tbNama.TabIndex = 17;
            // 
            // tbSemester
            // 
            this.tbSemester.Location = new System.Drawing.Point(443, 141);
            this.tbSemester.Name = "tbSemester";
            this.tbSemester.Size = new System.Drawing.Size(189, 20);
            this.tbSemester.TabIndex = 13;
            // 
            // tbNim
            // 
            this.tbNim.Location = new System.Drawing.Point(110, 72);
            this.tbNim.Name = "tbNim";
            this.tbNim.Size = new System.Drawing.Size(189, 20);
            this.tbNim.TabIndex = 1;
            // 
            // gbKurikulum
            // 
            this.gbKurikulum.Controls.Add(this.rb2014);
            this.gbKurikulum.Controls.Add(this.rb2010);
            this.gbKurikulum.Controls.Add(this.rb2006);
            this.gbKurikulum.Location = new System.Drawing.Point(49, 289);
            this.gbKurikulum.Name = "gbKurikulum";
            this.gbKurikulum.Size = new System.Drawing.Size(152, 131);
            this.gbKurikulum.TabIndex = 18;
            this.gbKurikulum.TabStop = false;
            this.gbKurikulum.Text = "Kurikulum Pilihan";
            // 
            // gbMatkul
            // 
            this.gbMatkul.Controls.Add(this.cbManajemen);
            this.gbMatkul.Controls.Add(this.cbSisop);
            this.gbMatkul.Controls.Add(this.cbJarkom);
            this.gbMatkul.Controls.Add(this.cbLogistik);
            this.gbMatkul.Controls.Add(this.cbP7);
            this.gbMatkul.Controls.Add(this.cbP6);
            this.gbMatkul.Controls.Add(this.cbP5);
            this.gbMatkul.Controls.Add(this.cbP4);
            this.gbMatkul.Controls.Add(this.cbP3);
            this.gbMatkul.Controls.Add(this.cbP2);
            this.gbMatkul.Controls.Add(this.cbP1);
            this.gbMatkul.Controls.Add(this.cbMatematika);
            this.gbMatkul.Location = new System.Drawing.Point(239, 289);
            this.gbMatkul.Name = "gbMatkul";
            this.gbMatkul.Size = new System.Drawing.Size(393, 152);
            this.gbMatkul.TabIndex = 19;
            this.gbMatkul.TabStop = false;
            this.gbMatkul.Text = "Mata Kuliah Pilihan";
            this.gbMatkul.Enter += new System.EventHandler(this.gbMatkul_Enter);
            // 
            // cbMatematika
            // 
            this.cbMatematika.AutoSize = true;
            this.cbMatematika.Location = new System.Drawing.Point(6, 34);
            this.cbMatematika.Name = "cbMatematika";
            this.cbMatematika.Size = new System.Drawing.Size(81, 17);
            this.cbMatematika.TabIndex = 0;
            this.cbMatematika.Text = "Matematika";
            this.cbMatematika.UseVisualStyleBackColor = true;
            // 
            // rb2006
            // 
            this.rb2006.AutoSize = true;
            this.rb2006.Location = new System.Drawing.Point(6, 31);
            this.rb2006.Name = "rb2006";
            this.rb2006.Size = new System.Drawing.Size(98, 17);
            this.rb2006.TabIndex = 0;
            this.rb2006.TabStop = true;
            this.rb2006.Text = "Kurikulum 2006";
            this.rb2006.UseVisualStyleBackColor = true;
            // 
            // rb2010
            // 
            this.rb2010.AutoSize = true;
            this.rb2010.Location = new System.Drawing.Point(6, 69);
            this.rb2010.Name = "rb2010";
            this.rb2010.Size = new System.Drawing.Size(101, 17);
            this.rb2010.TabIndex = 1;
            this.rb2010.TabStop = true;
            this.rb2010.Text = "Kurikulum 2010 ";
            this.rb2010.UseVisualStyleBackColor = true;
            // 
            // rb2014
            // 
            this.rb2014.AutoSize = true;
            this.rb2014.Location = new System.Drawing.Point(6, 108);
            this.rb2014.Name = "rb2014";
            this.rb2014.Size = new System.Drawing.Size(101, 17);
            this.rb2014.TabIndex = 2;
            this.rb2014.TabStop = true;
            this.rb2014.Text = "Kurikulum 2014 ";
            this.rb2014.UseVisualStyleBackColor = true;
            // 
            // cbP1
            // 
            this.cbP1.AutoSize = true;
            this.cbP1.Location = new System.Drawing.Point(6, 57);
            this.cbP1.Name = "cbP1";
            this.cbP1.Size = new System.Drawing.Size(100, 17);
            this.cbP1.TabIndex = 1;
            this.cbP1.Text = "Pemrograman 1";
            this.cbP1.UseVisualStyleBackColor = true;
            // 
            // cbP2
            // 
            this.cbP2.AutoSize = true;
            this.cbP2.Location = new System.Drawing.Point(6, 80);
            this.cbP2.Name = "cbP2";
            this.cbP2.Size = new System.Drawing.Size(100, 17);
            this.cbP2.TabIndex = 2;
            this.cbP2.Text = "Pemrograman 2";
            this.cbP2.UseVisualStyleBackColor = true;
            // 
            // cbP3
            // 
            this.cbP3.AutoSize = true;
            this.cbP3.Location = new System.Drawing.Point(6, 103);
            this.cbP3.Name = "cbP3";
            this.cbP3.Size = new System.Drawing.Size(100, 17);
            this.cbP3.TabIndex = 3;
            this.cbP3.Text = "Pemrograman 3";
            this.cbP3.UseVisualStyleBackColor = true;
            // 
            // cbP4
            // 
            this.cbP4.AutoSize = true;
            this.cbP4.Location = new System.Drawing.Point(122, 34);
            this.cbP4.Name = "cbP4";
            this.cbP4.Size = new System.Drawing.Size(100, 17);
            this.cbP4.TabIndex = 4;
            this.cbP4.Text = "Pemrograman 4";
            this.cbP4.UseVisualStyleBackColor = true;
            // 
            // cbP5
            // 
            this.cbP5.AutoSize = true;
            this.cbP5.Location = new System.Drawing.Point(122, 57);
            this.cbP5.Name = "cbP5";
            this.cbP5.Size = new System.Drawing.Size(100, 17);
            this.cbP5.TabIndex = 5;
            this.cbP5.Text = "Pemrograman 5";
            this.cbP5.UseVisualStyleBackColor = true;
            // 
            // cbP6
            // 
            this.cbP6.AutoSize = true;
            this.cbP6.Location = new System.Drawing.Point(122, 80);
            this.cbP6.Name = "cbP6";
            this.cbP6.Size = new System.Drawing.Size(100, 17);
            this.cbP6.TabIndex = 6;
            this.cbP6.Text = "Pemrograman 6";
            this.cbP6.UseVisualStyleBackColor = true;
            // 
            // cbP7
            // 
            this.cbP7.AutoSize = true;
            this.cbP7.Location = new System.Drawing.Point(122, 103);
            this.cbP7.Name = "cbP7";
            this.cbP7.Size = new System.Drawing.Size(100, 17);
            this.cbP7.TabIndex = 7;
            this.cbP7.Text = "Pemrograman 7";
            this.cbP7.UseVisualStyleBackColor = true;
            // 
            // cbLogistik
            // 
            this.cbLogistik.AutoSize = true;
            this.cbLogistik.Location = new System.Drawing.Point(241, 31);
            this.cbLogistik.Name = "cbLogistik";
            this.cbLogistik.Size = new System.Drawing.Size(114, 17);
            this.cbLogistik.TabIndex = 8;
            this.cbLogistik.Text = "Pengantar Logistik";
            this.cbLogistik.UseVisualStyleBackColor = true;
            // 
            // cbJarkom
            // 
            this.cbJarkom.AutoSize = true;
            this.cbJarkom.Location = new System.Drawing.Point(241, 57);
            this.cbJarkom.Name = "cbJarkom";
            this.cbJarkom.Size = new System.Drawing.Size(114, 17);
            this.cbJarkom.TabIndex = 9;
            this.cbJarkom.Text = "Jaringan Komputer";
            this.cbJarkom.UseVisualStyleBackColor = true;
            // 
            // cbSisop
            // 
            this.cbSisop.AutoSize = true;
            this.cbSisop.Location = new System.Drawing.Point(241, 80);
            this.cbSisop.Name = "cbSisop";
            this.cbSisop.Size = new System.Drawing.Size(96, 17);
            this.cbSisop.TabIndex = 10;
            this.cbSisop.Text = "Sistem Operasi";
            this.cbSisop.UseVisualStyleBackColor = true;
            // 
            // cbManajemen
            // 
            this.cbManajemen.AutoSize = true;
            this.cbManajemen.Location = new System.Drawing.Point(241, 103);
            this.cbManajemen.Name = "cbManajemen";
            this.cbManajemen.Size = new System.Drawing.Size(148, 17);
            this.cbManajemen.TabIndex = 11;
            this.cbManajemen.Text = "Manajemen Rantai Pasok";
            this.cbManajemen.UseVisualStyleBackColor = true;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(190, 464);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 20;
            this.btnSimpan.Text = "Simpan ";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(361, 464);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(75, 23);
            this.btnBatal.TabIndex = 21;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 269);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.gbMatkul);
            this.Controls.Add(this.gbKurikulum);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.PilihButton);
            this.Controls.Add(this.cbProdi);
            this.Controls.Add(this.tbTa);
            this.Controls.Add(this.tbSemester);
            this.Controls.Add(this.tbAlamat);
            this.Controls.Add(this.rbJk2);
            this.Controls.Add(this.rbJk1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNim);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form Mata Kuliah Mahasiswa";
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).EndInit();
            this.gbKurikulum.ResumeLayout(false);
            this.gbKurikulum.PerformLayout();
            this.gbMatkul.ResumeLayout(false);
            this.gbMatkul.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private P5_3_1204044.NumericTextBox tbNim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rbJk1;
        private System.Windows.Forms.RadioButton rbJk2;
        private System.Windows.Forms.TextBox tbAlamat;
        private P5_3_1204044.NumericTextBox tbSemester;
        private System.Windows.Forms.TextBox tbTa;
        private System.Windows.Forms.ComboBox cbProdi;
        private System.Windows.Forms.Button PilihButton;
        private System.Windows.Forms.ErrorProvider epWarning;
        private System.Windows.Forms.ErrorProvider epCorrect;
        private System.Windows.Forms.ErrorProvider epWrong;
        private P5_3_1204044.CharTextBox tbNama;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.GroupBox gbMatkul;
        private System.Windows.Forms.CheckBox cbManajemen;
        private System.Windows.Forms.CheckBox cbSisop;
        private System.Windows.Forms.CheckBox cbJarkom;
        private System.Windows.Forms.CheckBox cbLogistik;
        private System.Windows.Forms.CheckBox cbP7;
        private System.Windows.Forms.CheckBox cbP6;
        private System.Windows.Forms.CheckBox cbP5;
        private System.Windows.Forms.CheckBox cbP4;
        private System.Windows.Forms.CheckBox cbP3;
        private System.Windows.Forms.CheckBox cbP2;
        private System.Windows.Forms.CheckBox cbP1;
        private System.Windows.Forms.CheckBox cbMatematika;
        private System.Windows.Forms.GroupBox gbKurikulum;
        private System.Windows.Forms.RadioButton rb2014;
        private System.Windows.Forms.RadioButton rb2010;
        private System.Windows.Forms.RadioButton rb2006;
    }
}

