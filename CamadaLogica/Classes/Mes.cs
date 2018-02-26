using CamadaBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaLogica.Classes
{
    public class Mes : Base
    {
        public DataTable BuscarMes( string Mes )
        {
            StringBuilder sql = new StringBuilder ();
            sql.AppendLine ( "SELECT * FROM MES " );
            sql.AppendLine ( "WHERE 0=0" );
            //if ( Inativos )
            //    sql.AppendLine ( "DAT_DESATIVADO IS NOT NULL" );
            //else
            //    sql.AppendLine ( "DAT_DESATIVADO IS NULL" );
            if ( !string.IsNullOrEmpty ( Mes ) )
                sql.AppendLine ( $"AND UPPER (IDE_MES) LIKE '%{Mes.ToUpper ()}%'" );

            return Select ( sql );
        }
    }
}
