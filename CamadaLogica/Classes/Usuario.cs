using CamadaBase;
using System.Data;
using System.Text;
using System.Linq;

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
        public bool VerificaUsuario (string IdeUsuario)
        {
            StringBuilder sql = new StringBuilder ();
            sql.AppendLine ( "SELECT IDE_USUARIO FROM USUARIOS " );
            sql.AppendLine ( $"WHERE UPPER (IDE_USUARIO) LIKE '{IdeUsuario.ToUpper()}'" );
            DataRow Usuario = Select ( sql ).AsEnumerable().FirstOrDefault();

            if ( Usuario == null )
                return false;

            return true;

        }
        public bool VerificaUsuarioSenha( string IdeUsuario, string Senha )
        {
            StringBuilder sql = new StringBuilder ();
            sql.AppendLine ( "SELECT * FROM USUARIOS " );
            sql.AppendLine ( $"WHERE UPPER (IDE_USUARIO) LIKE '{IdeUsuario.ToUpper ()}' AND SENHA LIKE '{Senha}'" );
            DataRow Usuario = Select ( sql ).AsEnumerable ().FirstOrDefault ();

            if ( Usuario == null )
                return false;

            return true;

        }
    }
}