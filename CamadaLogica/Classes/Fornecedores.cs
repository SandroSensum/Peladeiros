using CamadaBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaLogica.Classes
{
    public class Fornecedores : Base
    {
        public DataTable BuscarFornecedor (string Fornecedor)
        {
            StringBuilder sql = new StringBuilder ();
            sql.AppendLine ( "SELECT * FROM FORNECEDORES " );
            sql.AppendLine ( "WHERE 0=0" );
            if ( !string.IsNullOrEmpty ( Fornecedor ) )
                sql.AppendLine ( $"AND UPPER (NOM_FORNECEDOR) LIKE '%{Fornecedor.ToUpper ()}%'" );
            return Select ( sql );
        }
    }
}

