using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleKitSala
{
    class Conexao
    {
        static public string conectar()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\silvio.wflorentino.SENACEDU\source\repos\ControleKitSala\ControleKitSala\bdkitsala.mdf;Integrated Security=True";
        }

    }
}
