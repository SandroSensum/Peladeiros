using CamadaBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaLogica.Classes
{
    public class Valor : Base
    {
        public DataTable Buscarvalor( string Valor )
        {
            StringBuilder sql = new StringBuilder ();
            sql.AppendLine ( "SELECT * FROM VALOR " );
            //sql.AppendLine ( "WHERE " );
            //if ( Inativos )
            //    sql.AppendLine ( "DAT_DESATIVADO IS NOT NULL" );
            //else
            //    sql.AppendLine ( "DAT_DESATIVADO IS NULL" );
            //if ( !string.IsNullOrEmpty ( NomeJogador ) )
            //    sql.AppendLine ( $"AND UPPER (NOM_JOGADOR) LIKE '%{NomeJogador.ToUpper ()}%'" );

            return Select ( sql );
        }
    }
}
