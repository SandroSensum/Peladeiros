using CamadaBase;
using System.Data;
using System.Text;

namespace CamadaLogica.Classes
{
    public class Usuario : Base
    {
        public DataTable BuscarUsuarios( string NomeUsuario )
        {
            StringBuilder sql = new StringBuilder ();
            sql.AppendLine ( "SELECT * FROM USUARIOS " );
            sql.AppendLine ( "WHERE 0=0" );
            //if ( Inativos )
            //    sql.AppendLine ( "DAT_DESATIVADO IS NOT NULL" );
            //else
            //    sql.AppendLine ( "DAT_DESATIVADO IS NULL" );
            if ( !string.IsNullOrEmpty ( NomeUsuario ) )
                sql.AppendLine ( $"AND UPPER (NOM_USUARIO) LIKE '%{NomeUsuario.ToUpper ()}%'" );

            return Select ( sql );
        }
    }
}