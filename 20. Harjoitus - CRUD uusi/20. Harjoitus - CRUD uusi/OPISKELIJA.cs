using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20.Harjoitus___CRUD_uusi
{
    internal class OPISKELIJA
    {
        private Yhdista yhteys = new Yhdista();

        // Добавление нового студента
        public bool lisääOpiskelija(string enimi, string snimi, string puh, string email, int onro)
        {
            MySqlCommand komento = new MySqlCommand();
            string lisäkysely = @"
            INSERT INTO yhteystiedot 
            (etunimi, sukunimi, puhelin, sahkoposti, opiskelijanumero)
            VALUES (@enm, @snm, @puh, @eml, @ono)";

            komento.CommandText = lisäkysely;
            komento.Connection = yhteys.otaYhteys();

            komento.Parameters.Add("@enm", MySqlDbType.VarChar).Value = enimi;
            komento.Parameters.Add("@snm", MySqlDbType.VarChar).Value = snimi;
            komento.Parameters.Add("@puh", MySqlDbType.VarChar).Value = puh;
            komento.Parameters.Add("@eml", MySqlDbType.VarChar).Value = email;
            komento.Parameters.Add("@ono", MySqlDbType.UInt32).Value = onro;

            try
            {
                yhteys.avaaYhteys();

                if (komento.ExecuteNonQuery() == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
            finally
            {
                yhteys.suljeYhteys();
            }
        }

        // Получение всех студентов
        public DataTable haeOpiskelijat()
        {
            MySqlCommand komento = new MySqlCommand(
                "SELECT oid, etunimi, sukunimi, puhelin, sahkoposti, opiskelijanumero " +
                "FROM yhteystiedot",
                yhteys.otaYhteys()
            );

            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulukko = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulukko);

            return taulukko;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = opiskelija.haeOpiskelijat();
        }


    }
}
