using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sharp7;
using Newtonsoft.Json;
using System.IO;
using System.Net;

namespace PLCtoJson
{
    class Connetting
    {
        private S7Client Client;
        int Rack ;
        int Slot ;
        private byte[] dbBuffer;
        
        
        public Connetting()
        {
            Rack = Convert.ToInt32(0);
            Slot = Convert.ToInt32(1);
            dbBuffer = new byte[224];
            this.Client = new S7Client();
           
            
        }
        public DatiJson connect()
        {
            DatiJson commessa = new DatiJson(); 
            int result = this.Client.ConnectTo("192.168.0.100", Rack, Slot);
            if (result != 0) {
                Console.WriteLine("Connection failed: " + this.Client.ErrorText(result).ToString());
                return commessa;
            }
            else
            {
                Console.WriteLine("Connect: " + result.ToString());

                result = this.Client.DBRead(10, 0, 224, dbBuffer);

                // lettura codice
                int x = 0;
                for (int i = 0; i < 25; i++)
                {
                    commessa.codice+=S7.GetWordAt(dbBuffer,x);
                    x += 2;
                }

                // lettura Articolo       
                for (int i = 0; i < 25; i++)
                {
                    commessa.articolo += S7.GetWordAt(dbBuffer, x);
                    x += 2;
                }

                //lettura parziale pezzi 
                commessa.parzialeDiProduzione = Convert.ToInt32(S7.GetDWordAt(dbBuffer,x));
                x+=4;

                //lettura pezzi buoni
               
                commessa.PezziBuoni = Convert.ToInt32(S7.GetDWordAt(dbBuffer, x));
                x += 4;

                //lettura pezzi Scarto
                
                commessa.PezziScarto= Convert.ToInt32(S7.GetDWordAt(dbBuffer, x));
                x += 4;

                //lettura stato Macchina

                for (int i = 0; i < commessa.statoMacchina.Length; i++)
                {
                    commessa.statoMacchina[i] = S7.GetBitAt(dbBuffer, x, i);
                }
                x += 2;

                //lettura velocità macchina
                commessa.velocitàMacchina = Convert.ToInt32(S7.GetWordAt(dbBuffer, x));
                x += 2;

                //lettura variabile non utilizzata...
                commessa.out1 = Convert.ToInt32(S7.GetDWordAt(dbBuffer, x));
                x += 4;

                //lettura variabile non utilizzata...
                commessa.out2 = Convert.ToInt32(S7.GetDWordAt(dbBuffer, x));
                x += 4;

                //lettura avviso per uffici 
                for (int i = 0; i < 25; i++)
                {
                    commessa.avvisoPerUffici += S7.GetDWordAt(dbBuffer, x);
                    x += 4;
                }
                return commessa;
            }
        }
        
        private static void PostJson(string uri, DatiJson commessa)
        {

            string postData = JsonConvert.SerializeObject(commessa);

            byte[] bytes = Encoding.UTF8.GetBytes(postData);
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(uri);
            httpWebRequest.Method = "POST";
            httpWebRequest.ContentLength = bytes.Length;
            httpWebRequest.ContentType = "text/xml";
            using (Stream requestStream = httpWebRequest.GetRequestStream())
            {
                requestStream.Write(bytes, 0, bytes.Count());
            }
            var httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            if (httpWebResponse.StatusCode != HttpStatusCode.OK)
            {
                string message = String.Format("POST failed. Received HTTP {0}", httpWebResponse.StatusCode);
                throw new ApplicationException(message);
            }

        }




    }
}
