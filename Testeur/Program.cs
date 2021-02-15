using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testeur
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * --300	AC de Saint-Gilles		13-02-21 03:07:26	12-02-21 09:41:11		12-02-21 09:40:53		11-02-21 08:50:00		11-02-21 08:50:00
             * 
             if (m.MaxDateEnvoiClient < m.MaxDateRecuInterne.Value.AddSeconds(-15) || m.MaxDateEnvoiClient > m.MaxDateRecuInterne.Value.AddSeconds(15))
                erreurs += "<b>" + customer.Name + "</b> : Les dates maximales d'envoi client et de reception interne ne correspondent pas <br/>"; 
            */


            //DateTime dateEnvoi = Convert.ToDateTime("12-02-21 09:41:11");
            //DateTime dateReception = Convert.ToDateTime("12-02-21 09:40:53");

            //if (dateEnvoi < dateReception.AddSeconds(-15) || dateEnvoi > dateReception.AddSeconds(15))
            //{
            //    Console.WriteLine("Erreur");
            //}

            int nbreTentatives = 0;
            bool ok = false;

            while (nbreTentatives < 3 && !ok)
            {
                try
                {
                    throw new Exception("Prout");

                    ok = true;
                }
                catch (Exception ex)
                {
                    nbreTentatives++;
                }
            }

            Console.ReadLine();
        }
    }
}
