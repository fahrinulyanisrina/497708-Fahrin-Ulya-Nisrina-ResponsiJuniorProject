using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace junproresponsi_497708
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private NpgsqlConnection conn;
        string connstring = "Host=localhost;port=5432;Username=postgres;password=informatika;Database=responsi";

        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;


        public string NamaKaryawan
        {
            get { return tbNama.Text; }
            set { tbNama.Text = value; }
        }

        public string NamaDepartemen
        {
            get { return cbDepartemen.SelectedText; }
            set {  cbDepartemen.SelectedText = value;}
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);

            try
            {
                conn.Open();
                dgvData.DataSource = null;
                sql = "SELECT * FROM select_karyawan()";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);


                dgvData.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close(); // Pastikan koneksi ditutup
            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgvData.Rows[e.RowIndex];
                tbNama.Text = r.Cells["_nama"].Value.ToString();
                cbDepartemen.Text = r.Cells["_departemen"].Value.ToString();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            //validasi input sudah terisi
            if (cbDepartemen.SelectedIndex == -1)
            {
                //jika ada yang belum terisi, tampilkan feedback
                MessageBox.Show("Pastikan sudah memilih ID Departemen!");
                return;
            }
            if (string.IsNullOrWhiteSpace(tbNama.Text))
            {
                //jika ada yang belum terisi, tampilkan feedback

                MessageBox.Show("Pastikan sudah memasukkan nama karyawan!");

                return;
            }

            try
            {
                conn.Open();
                sql = "SELECT * FROM add_karyawan (:_nama, :_departemen)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_nama", tbNama.Text);
                cmd.Parameters.AddWithValue("_departemen", cbDepartemen.SelectedText);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data Users Berhasil diinputkan", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Insert FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            {
                conn.Close();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Memastikan bahwa baris telah dipilih
            if (r == null)
            {
                MessageBox.Show("Mohon pilih baris data yang akan diupdate", "Good!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                conn.Open();
                sql = "SELECT edit_karyawan (:_id, :_nama, :_departemen)";
                cmd = new NpgsqlCommand(sql, conn);

                // Mengambil ID dari baris yang dipilih
                cmd.Parameters.AddWithValue("_id", r.Cells["_id"].Value.ToString()); // Sesuaikan dengan nama kolom ID Anda
                cmd.Parameters.AddWithValue("_nama", tbNama.Text);
                cmd.Parameters.AddWithValue("_departemen", cbDepartemen.Text);

                // Mengeksekusi perintah
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data Users Berhasil diupdate", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                r = null; // Mengatur ulang pilihan baris
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Update FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close(); // Pastikan koneksi ditutup
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Memastikan bahwa baris telah dipilih
            if (r == null)
            {
                MessageBox.Show("Mohon pilih baris data yang akan dihapus", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Konfirmasi sebelum menghapus
            if (MessageBox.Show("Apakah benar anda ingin menghapus data " + r.Cells["_nama"].Value.ToString() + " ?",
                "Hapus data terkonfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    sql = "SELECT delete_karyawan (:_id);";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_id", r.Cells["_id"].Value.ToString()); // Sesuaikan dengan nama kolom ID Anda

                    // Mengeksekusi perintah
                    if ((int)cmd.ExecuteScalar() == 1)
                    {
                        MessageBox.Show("Data Users Berhasil dihapus", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        r = null; // Mengatur ulang pilihan baris
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Delete FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

       
    }
}
