using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProjectWorkForm
{
    class Commessa
    {
        private string _connectionString = "Server=(local);Database=Catalogo_Prodotti;Trusted_Connection=True;";
        
        #region "Attributi"
        protected Int32 Codice_Prodotto;
        protected string Articolo;
        protected string Descrizione;
        protected Int32 Nr_Pezzi;
        #endregion

        #region "Costruttori"
        public Commessa()
        {
            Codice_Prodotto = 0;
            Articolo = "";
            Descrizione = "";
            Nr_Pezzi = 0;
        }

        public Commessa(Int32 sCodice, string sArticolo, string sDescrizione, Int32 sNPezzi)
        {
            Codice_Prodotto = sCodice;
            Articolo = sArticolo;
            Descrizione = sDescrizione;
            Nr_Pezzi = sNPezzi;
        }
        #endregion

        #region "Metodi"
        public DataTable GetCommesse(string Ricerca)
        {
            DataTable dtRet = new DataTable("Commesse");
            SqlConnection con = new SqlConnection(_connectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Articoli WHERE Articolo = \'" + Ricerca + "\' ORDER BY Codice_Prodotto", con);
            SqlDataReader dr;

            try
            {
                con.Open();
                dr = cmd.ExecuteReader();

                // Definizone tabella tramite Righe e Colonne
                DataRow tmpRow;
                DataColumn tmpCol;

                tmpCol = new DataColumn();
                tmpCol.ColumnName = "Codice_Prodotto";
                tmpCol.DataType = System.Type.GetType("System.Int32");
                dtRet.Columns.Add(tmpCol);

                tmpCol = new DataColumn();
                tmpCol.ColumnName = "Articolo";
                tmpCol.DataType = System.Type.GetType("System.String");
                dtRet.Columns.Add(tmpCol);

                tmpCol = new DataColumn();
                tmpCol.ColumnName = "Descrizione";
                tmpCol.DataType = System.Type.GetType("System.String");
                dtRet.Columns.Add(tmpCol);

                tmpCol = new DataColumn();
                tmpCol.ColumnName = "Nr_Pezzi";
                tmpCol.DataType = System.Type.GetType("System.Int32");
                dtRet.Columns.Add(tmpCol);

                while (dr.Read())
                {
                    tmpRow = dtRet.NewRow();

                    tmpRow["Codice_Prodotto"] = dr.GetInt32(dr.GetOrdinal("Codice_Prodotto"));
                    tmpRow["Articolo"] = dr.GetString(dr.GetOrdinal("Articolo"));
                    tmpRow["Descrizione"] = dr.GetString(dr.GetOrdinal("Descrizione"));
                    tmpRow["Nr_Pezzi"] = dr.GetInt32(dr.GetOrdinal("Nr_Pezzi"));
                    dtRet.Rows.Add(tmpRow);

                }

            }

            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            finally
            {
                con.Close();
                con.Dispose();
            }

            return dtRet;
        }
    }
        #endregion
}