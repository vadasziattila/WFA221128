using Microsoft.Data.SqlClient;
using WFA221128.Properties;

namespace WFA221128
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DgvreLoad()
        {
            dgv.Rows.Clear();
            using SqlConnection conn = new(Resources.ConnectionString);
            conn.Open();
            var rdr = new SqlCommand(
                "SELECT * FROM emberek",
                conn).ExecuteReader();

            while (rdr.Read())
            {
                dgv.Rows.Add(
                    rdr[0],
                    rdr[1],
                    rdr.GetBoolean(2) ? "f�rfi" : "n�",
                    rdr.GetDateTime(3).ToString("yyyy.MM.dd"));
            }
        }

        private void Form1_Load(object sender, EventArgs e) => DgvreLoad();

        private void BTN_ujSzemely_Click(object sender, EventArgs e)
        {
            // TODO: "felt�telek teljes�lnek-e?"

            if(string.IsNullOrWhiteSpace(TXTB_Nev.Text))
            {
                MessageBox.Show(caption: "HIBA",
                    text: "A 'n�v' mez� kit�lt�se k�telez�",
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Error);
            }
            else
            {
                // TODO: "ha nem, akkor kezelj�k"

                string nev = TXTB_Nev.Text;
                string nem = RB_FF.Checked ? "1" : "0";
                string szul = DTP_Szul.Value.ToString("yyyy.MM.dd");

                using SqlConnection conn = new(Resources.ConnectionString);
                conn.Open();

                // TODO: Insert

                SqlDataAdapter sda = new()
                {
                    InsertCommand = new SqlCommand(
                        cmdText: "INSERT INTO emberek VALUES " +
                        $"('{nev}','{nem}','{szul}')",
                        connection: conn),
                };

                sda.InsertCommand.ExecuteNonQuery();

                // m�k�dik, de nem biztons�gos:
                //_ = new SqlCommand("", conn).ExecuteNonQuery();

                // TODO: Reload Main DGV

                DgvreLoad();
            }
        }
    }
}