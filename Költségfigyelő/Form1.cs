using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace winformProject
{
    public partial class Koltsegfigyelo : Form
    {
        public Koltsegfigyelo()
        {
            InitializeComponent();
            tbDesign();
            cbAdatokBetoltes();
        }

        private void btnAdatok_Click(object sender, EventArgs e)
        {
            ListaF(sender, e);
            cbAdatokBetoltes();
        }

        private void btnMentes_Click(object sender, EventArgs e)
        {
            try
            {
                dtpDatum.Update();
                dtpDatum.Format = DateTimePickerFormat.Custom;
                dtpDatum.CustomFormat = "yyyy.MM.dd";

                string conn = @"Server=(localdb)\MSSQLLocalDB;Database=koltesek";
                SqlConnection kapcsolat = new SqlConnection(conn);
                kapcsolat.Open();
                SqlCommand parancs = new SqlCommand();

                parancs.Connection = kapcsolat;
                parancs.CommandText = @"INSERT INTO koltes VALUES (@Megnevezés, @Összeg, @Kategória, @Dátum)";
                parancs.Parameters.AddWithValue("@Megnevezés", tbMegnevezes.Text);
                parancs.Parameters.AddWithValue("@Összeg", tbOsszeg.Text);
                parancs.Parameters.AddWithValue("@Kategória", cbKategoria.Text);
                parancs.Parameters.AddWithValue("@Dátum", dtpDatum.Text);

                parancs.ExecuteNonQuery();
                kapcsolat.Close();

                if (!cbKategoria.Items.Contains(cbKategoria.Text) && cbKategoria.Items.ToString() != "")
                {
                    cbAdatokMentes();
                    cbAdatokBetoltes();
                }

                dtpDatum.Text = "";
                cbKategoria.Text = "";
                tbDesign();
                ListaF(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTorles_Click(object sender, EventArgs e)
        {
            const string message = "Biztos törölni szeretnéd az adatokat? A törlés után nincs lehetőség azok visszaállítására!";
            const string caption = "Figyelem!";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string conn = @"Server=(localdb)\MSSQLLocalDB;Database=koltesek";
                SqlConnection kapcsolat = new SqlConnection(conn);
                kapcsolat.Open();
                SqlCommand parancs = new SqlCommand();

                parancs.Connection = kapcsolat;
                parancs.CommandText = @"DELETE FROM koltes";
                parancs.ExecuteNonQuery();
                kapcsolat.Close();
            }
            if (result == DialogResult.Yes)
            {
                string conn = @"Server=(localdb)\MSSQLLocalDB;Database=kategoriak";
                SqlConnection kapcsolat = new SqlConnection(conn);
                kapcsolat.Open();
                SqlCommand parancs = new SqlCommand();

                parancs.Connection = kapcsolat;
                parancs.CommandText = @"DELETE FROM Kategoria";
                parancs.ExecuteNonQuery();
                kapcsolat.Close();

                cbKategoria.Text = "";
                AdatokIndexTorles(sender, e);
                KategoriakIndexTorles(sender, e);
                ListaF(sender, e);
                cbAdatokBetoltes();
            }
        }

        private void btnFajlba_Click(object sender, EventArgs e)
        {
            string conn = @"Server=(localdb)\MSSQLLocalDB;Database=koltesek";
            SqlConnection kapcsolat = new SqlConnection(conn);
            kapcsolat.Open();
            string sql = @"SELECT id, Megnevezés, Összeg, Kategória, FORMAT(Dátum, 'd', 'hu-HU') as date FROM koltes";
            SqlCommand parancs = new SqlCommand(sql, kapcsolat);
            SqlDataReader lekerdez = parancs.ExecuteReader();

            StreamWriter sw = new StreamWriter("Adatok.csv", false, Encoding.UTF8);
            sw.Write("Megnevezés;Összeg;Kategória;Dátum\n");
            while (lekerdez.Read())
            {
                sw.Write($"{lekerdez[1]};{lekerdez[2]};{lekerdez[3]};{lekerdez[4]}\n");
            }

            kapcsolat.Close();
            sw.Close();

            MessageBox.Show("Az adatok mentve lettek az Adatok.csv állományba!", "Figyelem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvTabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 5)
                {
                    DataGridViewRow sor = dgvTabla.Rows[e.RowIndex];
                    if (MessageBox.Show("Biztos törölni akarod ezt a sort?", "Figyelem!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string conn = @"Server=(localdb)\MSSQLLocalDB;Database=koltesek";
                        SqlConnection kapcsolat = new SqlConnection(conn);
                        kapcsolat.Open();
                        string sql = @"DELETE FROM koltes WHERE ID=@ID";
                        SqlCommand parancs = new SqlCommand(sql, kapcsolat);

                        parancs.Parameters.AddWithValue("ID", sor.Cells["ID"].Value);
                        parancs.ExecuteReader();
                        kapcsolat.Close();
                        ListaF(sender, e);
                    }
                }
            }
            catch (Exception adat)
            {
                MessageBox.Show(adat.Message);
            }
        }

        private void dgvTabla_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex % 2 == 0)
            {
                dgvTabla.Rows[e.RowIndex].DefaultCellStyle.BackColor = SystemColors.GradientActiveCaption;
            }
        }

        private void AdatokIndexTorles(object sender, EventArgs e)
        {
            string conn = @"Server=(localdb)\MSSQLLocalDB;Database=koltesek";
            SqlConnection kapcsolat = new SqlConnection(conn);
            kapcsolat.Open();
            SqlCommand parancs = new SqlCommand();

            parancs.Connection = kapcsolat;
            parancs.CommandText = @"DBCC CHECKIDENT('koltes',RESEED,0);";

            parancs.ExecuteNonQuery();
            kapcsolat.Close();
        }

        private void KategoriakIndexTorles(object sender, EventArgs e)
        {
            string conn = @"Server=(localdb)\MSSQLLocalDB;Database=kategoriak";
            SqlConnection kapcsolat = new SqlConnection(conn);
            kapcsolat.Open();
            SqlCommand parancs = new SqlCommand();

            parancs.Connection = kapcsolat;
            parancs.CommandText = @"DBCC CHECKIDENT('Kategoria',RESEED,0);";

            parancs.ExecuteNonQuery();
            kapcsolat.Close();
        }

        private void ListaF(object sender, EventArgs e)
        {
            try
            {
                dgvTabla.Rows.Clear();
                string conn = @"Server=(localdb)\MSSQLLocalDB;Database=koltesek";
                SqlConnection kapcsolat = new SqlConnection(conn);
                kapcsolat.Open();
                string sql = @"SELECT id, Megnevezés, REPLACE(CONVERT(varchar(20), (CAST(Összeg AS money)), 1), '.00', ''), Kategória, FORMAT(Dátum, 'd', 'hu-HU') as date FROM koltes";
                SqlCommand parancs = new SqlCommand(sql, kapcsolat);
                SqlDataReader lekerdez = parancs.ExecuteReader();

                while (lekerdez.Read())
                {
                    dgvTabla.Rows.Add(lekerdez[0], lekerdez[1], lekerdez[2].ToString().Replace(",", " "), lekerdez[3], lekerdez[4], "Törlés");
                }
                kapcsolat.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbAdatokBetoltes()
        {
            cbKategoria.Items.Clear();
            string conn = @"Server=(localdb)\MSSQLLocalDB;Database=kategoriak";
            SqlConnection kapcsolat = new SqlConnection(conn);
            kapcsolat.Open();
            string sql = @"SELECT id, Kategória FROM kategoria";
            SqlCommand parancs = new SqlCommand(sql, kapcsolat);
            SqlDataReader lekerdez = parancs.ExecuteReader();

            while (lekerdez.Read())
            {
                cbKategoria.Items.Add(lekerdez[1]);
            }
            kapcsolat.Close();
        }
        private void cbAdatokMentes()
        {
            string conn = @"Server=(localdb)\MSSQLLocalDB;Database=kategoriak";
            SqlConnection kapcsolat = new SqlConnection(conn);
            kapcsolat.Open();

            SqlCommand parancs = new SqlCommand();
            parancs.Connection = kapcsolat;
            parancs.CommandText = @"INSERT INTO kategoria VALUES (@Kategória)";
            parancs.Parameters.AddWithValue("@Kategória", cbKategoria.Text);
            parancs.ExecuteNonQuery();

            kapcsolat.Close();
            cbAdatokBetoltes();
        }

        private void tbMegnevezes_Click(object sender, EventArgs e)
        {
            tbMegnevezes.Text = "";
            tbMegnevezes.ForeColor = Color.Black;
            tbMegnevezes.Font = new Font("Segoe UI", 11, FontStyle.Regular);
        }

        private void tbOsszeg_Click(object sender, EventArgs e)
        {
            tbOsszeg.Text = "";
            tbOsszeg.ForeColor = Color.Black;
            tbOsszeg.Font = new Font("Segoe UI", 11, FontStyle.Regular);
        }

        private void tbDesign()
        {
            tbMegnevezes.Text = "Megnevezés";
            tbMegnevezes.ForeColor = Color.Gray;
            tbMegnevezes.Font = new Font("Segoe UI", 11, FontStyle.Italic);
            tbOsszeg.Text = "Összeg";
            tbOsszeg.ForeColor = Color.Gray;
            tbOsszeg.Font = new Font("Segoe UI", 11, FontStyle.Italic);
        }
    }
}
