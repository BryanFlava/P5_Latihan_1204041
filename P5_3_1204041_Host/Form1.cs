using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace P5_3_1204044_Host
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtTa_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(tbTa.Text, @"^\d{4}/\d{4}$"))
            {
                epWarning.SetError(tbTa, "");
                epWrong.SetError(tbTa, "");
                epCorrect.SetError(tbTa, "Betul!");
            }
            else
            {
                epWrong.SetError(tbTa, "Format tahun salah\ncontoh: nnnn/nnnn");
                epWarning.SetError(tbTa, "");
                epCorrect.SetError(tbTa, "");
            }
        }

        private void PilihButton_Click(object sender, EventArgs e)
        {
            string jkelamin = "";

            if (tbNim.Text == "")
            {
                epWarning.SetError(tbNim, "Textbox NIM tidak boleh kosong!");
            }

            if (tbNama.Text == "")
            {
                epWarning.SetError(tbNama, "Textbox NIM tidak boleh kosong!");
            }

            if (rbJk1.Checked)
            {
                jkelamin = jkelamin + "Laki-laki";
            }
            if (rbJk2.Checked)
            {
                jkelamin = jkelamin + "Perempuan";
            }
            if(jkelamin == "")
            {
                MessageBox.Show("Harus memilih salah satu dari pilihan jenis kelamin", "warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if(tbAlamat.Text == "")
            {
                epWarning.SetError(tbAlamat, "Textbox Alamat tidak boleh kosong!");
            }
            if(cbProdi.Text == "-Pilih Program Studi-")
            {
                epWarning.SetError(cbProdi, "Pilih Program Studi!");
            }
            else
            {
                epCorrect.SetError(cbProdi, "Betul!");
            }
            if(tbTa.Text == "")
            {
                epWarning.SetError(tbTa, "Textbox Tahun Akademik tidak boleh kosong!");
            }
            if (tbSemester.Text == "")
            {
                epWarning.SetError(tbSemester, "Textbox Semester tidak boleh kosong!");
            }
            else
            {
                this.Size = new Size(680, 550);
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string kurikulum = "";
            string matkul = "";
            string jkelamin = "";

            if (rb2006.Checked)
            {
                kurikulum = rb2006.Text;
            }
            else if (rb2010.Checked)
            {
                kurikulum = rb2010.Text;
            }
            else if(rb2014.Checked)
            {
                kurikulum = rb2014.Text;
            }
            if (cbMatematika.Checked)
            {
                matkul += cbMatematika.Text + ",";
            }
            if (cbP1.Checked)
            {
                matkul += cbP1.Text + ",";
            }
            if (cbP2.Checked)
            {
                matkul += cbP2.Text + ",";
            }
            if (cbP3.Checked)
            {
                matkul += cbP3.Text + ",";
            }
            if (cbP4.Checked)
            {
                matkul += cbP4.Text + ",";
            }
            if (cbP5.Checked)
            {
                matkul += cbP5.Text + ",";
            }
            if (cbP6.Checked)
            {
                matkul += cbP6.Text + ",";
            }
            if (cbP7.Checked)
            {
                matkul += cbP7.Text + ",";
            }
            if (cbLogistik.Checked)
            {
                matkul += cbLogistik.Text + ",";
            }
            if (cbJarkom.Checked)
            {
                matkul += cbJarkom.Text + ",";
            }
            if (cbSisop.Checked)
            {
                matkul += cbSisop.Text + ",";
            }
            if (cbManajemen.Checked)
            {
                matkul += cbManajemen.Text + ",";
            }
            MessageBox.Show
            ("NIM:" + tbNim.Text +
             "\nNama :" + tbNama.Text +
             "\nJenis Kelamin:" + jkelamin +
             "\nAlamat:" + tbAlamat.Text +
             "\nProgram Studi :" + cbProdi.Text +
             "\nTahun Akademik :" + tbTa.Text +
             "\nSemester :" + tbSemester.Text +
             "\nKurikulum :" + kurikulum +
             "\nMata Kuliah :" + matkul ,
             "Data Mata Kuliah Mahasiswa",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gbMatkul_Enter(object sender, EventArgs e)
        {

        }
    }
}
