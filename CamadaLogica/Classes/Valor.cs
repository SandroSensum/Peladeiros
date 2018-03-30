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
        public DataTable BuscarMesAno( string Referencia )
        {
            StringBuilder sql = new StringBuilder ();
            sql.AppendLine ( "SELECT * FROM VALOR " );
            //sql.AppendLine ( "WHERE " );
            //if (! string.IsNullOrEmpty ( Referencia ) )
            //    sql.AppendLine ( $"DAT_VALOR = '{Referencia}'" );
            return Select ( sql );
        }
    
        //public DataTable Buscarvalref( string Referencia )
        //{
        //    StringBuilder sql = new StringBuilder ();
        //    sql.AppendLine ( "SELECT * FROM VALOR " );            
        //    sql.AppendLine ( $"WHERE DAT_VALOR = '{Referencia}'");
        //    return Convert.ToInt32( Select ( sql ).Rows[0]["COD_VALOR"] );

    }


        /* Método igual o de cima para buscar o valor pela referência(mes/ano)
         * Como parâmetro tem que passar a referencia que vem lá da tela igual ao de cima ( string referencia )
         *  return Convert.ToInt32(Select(sql).Rows[0]["COD_VALOR"])
         */
}
