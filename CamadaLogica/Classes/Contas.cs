using CamadaBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaLogica.Classes
{
    public class Contas : Base
    {
        public DataTable BuscarContas (string Conta, bool Inativos)
        {
            StringBuilder sql = new StringBuilder ();
            sql.AppendLine ( "SELECT * FROM CONTAS " );
            sql.AppendLine ( "WHERE " );
            if ( Inativos )
                sql.AppendLine ( "DAT_DESATIVADO IS NOT NULL" );
            else
                sql.AppendLine ( "DAT_DESATIVADO IS NULL" );
            if ( !string.IsNullOrEmpty ( Conta ) )
                sql.AppendLine ( $"AND UPPER (DES_CONTA) LIKE '%{Conta.ToUpper ()}%'" );
            return Select ( sql );
        }
    }
}
