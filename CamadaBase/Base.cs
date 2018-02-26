using CamadaBanco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaBase
{
    public class Base : Component
    {
        #region [Atributos]

        private AcessoBanco oAcessoBanco = null;

        #endregion

        #region [Construtor]

        /// <summary>
        /// Construtor padrão
        /// </summary>
        public Base()
        {
            oAcessoBanco = new AcessoBanco ();
        }

        #endregion

        #region [Métodos]

        /// <summary>
        /// Realiza as alterações no banco
        /// </summary>
        /// <param name="pTabela"></param>
        public void Atualizar( DataTable pTabela )
        {
            oAcessoBanco.Atualizar ( pTabela );
        }

        public DataTable Select (StringBuilder sql)
        {          
            return oAcessoBanco.Select ( sql.ToString () );
        }

        #endregion
    }
}
