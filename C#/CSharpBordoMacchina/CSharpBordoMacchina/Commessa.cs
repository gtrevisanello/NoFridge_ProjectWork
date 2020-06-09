using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Sharp7;

namespace CSharpBordoMacchina
{
    class Commessa
    {
        #region "Attributi"
        //db connection
        private string connection = "Server=(local);Database=Catalogo_Prodotti;Trusted_Connection=True;";

        //plc connection
        private string plcConnection = "192.168.0.100";
        private S7Client Client;
        int Rack = Convert.ToInt32(0);
        int Slot = Convert.ToInt32(1);
        private byte[] dbBuffer;

        //data to plc
        public string Codice { get; private set; }
        public string Articolo { get; private set; }
        public int PzLotto { get; private set; }
        protected int ControlWord;
        protected string Avviso;
        protected int Velocita;
        protected int Guasto;
        protected int WatchDog;
        #endregion

        #region "Costruttori"
        public Commessa() { }

        public Commessa(string cod, string art, int pz, int cw, string avv, int vel, int g, int wd)
        {
            this.Codice = cod;
            this.Articolo = art;
            this.PzLotto = pz;
            this.ControlWord = cw;
            this.Avviso = avv;
            this.Velocita = vel;
            this.Guasto = g;
            this.WatchDog = wd;
        }
        #endregion

        #region "Metodi"
        public DataTable getDB()
        {
            DataTable Articoli = new DataTable("Articoli");
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("select * from Articoli order by Codice_Prodotto", con);
            SqlDataReader dr;

            try
            {
                con.Open();
                dr = cmd.ExecuteReader();

                DataRow tmpRow;
                DataColumn tmpCol;

                tmpCol = new DataColumn();
                tmpCol.ColumnName = "Codice_Prodotto";
                tmpCol.DataType = System.Type.GetType("System.String");
                Articoli.Columns.Add(tmpCol);

                tmpCol = new DataColumn();
                tmpCol.ColumnName = "Articolo";
                tmpCol.DataType = System.Type.GetType("System.String");
                Articoli.Columns.Add(tmpCol);

                tmpCol = new DataColumn();
                tmpCol.ColumnName = "Descrizione";
                tmpCol.DataType = System.Type.GetType("System.String");
                Articoli.Columns.Add(tmpCol);

                tmpCol = new DataColumn();
                tmpCol.ColumnName = "Nr_Pezzi";
                tmpCol.DataType = System.Type.GetType("System.Int32");
                Articoli.Columns.Add(tmpCol);

                while (dr.Read())
                {
                    tmpRow = Articoli.NewRow();

                    tmpRow["Codice_Prodotto"] = dr.GetString(dr.GetOrdinal("Codice_Prodotto"));
                    tmpRow["Articolo"] = dr.GetString(dr.GetOrdinal("Articolo"));
                    tmpRow["Descrizione"] = dr.GetString(dr.GetOrdinal("Descrizione"));
                    tmpRow["Nr_Pezzi"] = dr.GetInt32(dr.GetOrdinal("Nr_Pezzi"));
                    Articoli.Rows.Add(tmpRow);
                }
            }
            catch ( Exception e )
            {
                throw new Exception(e.Message);
            }
            finally
            {
                con.Close();
                con.Dispose();
            }

            return Articoli;
        }

        public void getCommessa(string id)
        {
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("select * from Articoli where Codice_Prodotto = @id", con);
            SqlDataReader dr;

            try
            {
                con.Open();
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);

                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    this.Codice = id;
                    this.Articolo = dr.GetString(dr.GetOrdinal("Articolo"));
                    this.PzLotto = dr.GetInt32(dr.GetOrdinal("Nr_Pezzi"));
                }
                else
                {
                    this.Codice = id;
                    this.Articolo = "404";
                    this.PzLotto = 404;
                }
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }

        public int PCtoPLC()
        {
            this.Client = new S7Client();
            this.dbBuffer = new byte[214];

            int result = this.Client.ConnectTo(plcConnection, Rack, Slot);
            if(result != 0)
                throw new Exception(Client.ErrorText(result));

            S7.SetCharsAt(this.dbBuffer, 0, this.Codice);
            S7.SetCharsAt(this.dbBuffer, 50, this.Articolo);
            S7.SetIntAt(this.dbBuffer, 100, (short)this.PzLotto);
            S7.SetBitAt(ref this.dbBuffer, 104, this.ControlWord, true);
            S7.SetIntAt(this.dbBuffer, 106, (short)this.Velocita);
            S7.SetCharsAt(this.dbBuffer, 108, this.Avviso);
            S7.SetBitAt(ref this.dbBuffer, 208, this.Guasto, true);
            S7.SetIntAt(this.dbBuffer, 212, (short)this.WatchDog);

            result = this.Client.DBWrite(30, 0, this.dbBuffer.Length, this.dbBuffer);
            if (result != 0)
                throw new Exception(Client.ErrorText(result));
            else
                return 200;
        }
        #endregion
    }
}
