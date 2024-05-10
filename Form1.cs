using System.Data.SQLite;
using System.Data;

namespace AS2324._3G.SpagnoliEnrico.PSDBPCTO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnElencoPiloti_Click_1(object sender, EventArgs e)
        {
            string query = "";
            string strConnessione = "";

            // https://www.connectionstrings.com/

            // imposta la connessione

            // sqlite Data Source=c:\mydb.db;Version=3;
            strConnessione = "Data Source=" + @"C:\Users\Enrico Spagnoli\Downloads\MotoGP.db" + ";Version=3;";

            // contenitore per i dati estratti
            DataTable dtDati = new DataTable();

            // query per l'estrazione dei dati dal database
            query = "SELECT * FROM Piloti";

            //connessione e query
            SQLiteDataAdapter da = new SQLiteDataAdapter(query, strConnessione);

            try
            {
                // riempie il DataTable
                da.Fill(dtDati);

                // binda la DataGridView
                dgvDati.DataSource = dtDati;
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

        private void btnElencoGare_Click_1(object sender, EventArgs e)
        {
            string query = "";
            string strConnessione = "";

            // https://www.connectionstrings.com/

            // imposta la connessione

            // sqlite Data Source=c:\mydb.db;Version=3;
            strConnessione = "Data Source=" + @"C:\Users\Enrico Spagnoli\Downloads\MotoGP.db" + ";Version=3;";

            // contenitore per i dati estratti
            DataTable dtDati = new DataTable();

            // query per l'estrazione dei dati dal database
            query = "SELECT * FROM Gare";

            //connessione e query
            SQLiteDataAdapter da = new SQLiteDataAdapter(query, strConnessione);

            try
            {
                // riempie il DataTable
                da.Fill(dtDati);

                // binda la DataGridView
                dgvDati.DataSource = dtDati;
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

        private void cmbDatabase_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string query = "";
            string strConnessione = "";

            // https://www.connectionstrings.com/

            // imposta la connessione

            // sqlite Data Source=c:\mydb.db;Version=3;
            strConnessione = "Data Source=" + @"C:\Users\Enrico Spagnoli\Downloads\MotoGP.db" + ";Version=3;";

            // contenitore per i dati estratti
            DataTable dtDati = new DataTable();

            // query per l'estrazione dei dati dal database

            switch (cmbDatabase.Text)
            {
                case "Elenco squadre non italiane ordinate per nome":
                    query = "SELECT * FROM Squadre WHERE Nazionalita <> 'ITA' ORDER BY Nome";
                    break;
                case "Elenco piloti Ducati ordinati per cognome e nome":
                    query = "SELECT * FROM Piloti WHERE IdSquadre <> '30' ORDER BY Nome";
                    break;
                case "Elenco circuiti ordinati per nome":
                    query = "SELECT * FROM Circuiti ORDER BY Nome";
                    break;
                default:
                    break;
            }

            //connessione e query
            SQLiteDataAdapter da = new SQLiteDataAdapter(query, strConnessione);

            try
            {
                // riempie il DataTable
                da.Fill(dtDati);

                // binda la DataGridView
                dgvDati.DataSource = dtDati;
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }
    }
}
