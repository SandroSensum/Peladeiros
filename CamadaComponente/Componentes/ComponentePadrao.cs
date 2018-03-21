using CamadaFuncao.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CamadaFuncao;

namespace CamadaComponente.Componentes
{
    public class scBso : BindingSource
    {
        #region [Construtores]

        public scBso() { }

        public scBso( IContainer container )
            : base ( container ) { }

        public scBso( object dataSource, string dataMember )
            : base ( dataSource, dataMember ) { }

        #endregion

        public DataRowView Linha
        {
            get
            {
                return ( ( DataRowView ) this.Current );
            }
        }
    }

    public class scPanel : Panel, IComponente
    {
        private bool bDesabilitar = true;

        [Description ( "Define se o campo será desabilitado em navegação" ), Category ( "Peladeiros" ), DefaultValue ( true )]
        public bool Desabilitar
        {
            get { return bDesabilitar; }
            set { bDesabilitar = value; }
        }

        public void AtualizarNavegacao( Enumerados.eModoNavegacao pModoNavegacao )
        {
            if ( Desabilitar )
                Enabled = pModoNavegacao != Enumerados.eModoNavegacao.navegacao;
        }
    }

    public class scButton : Button, IComponente
    {
        private bool bDesabilitar = true;

        [Description ( "Define se o campo será desabilitado em navegação" ), Category ( "Peladeiros" ), DefaultValue ( true )]
        public bool Desabilitar
        {
            get { return bDesabilitar; }
            set { bDesabilitar = value; }
        }

        public void AtualizarNavegacao( Enumerados.eModoNavegacao pModoNavegacao )
        {
            if ( Desabilitar )
                Enabled = Enabled = pModoNavegacao != Enumerados.eModoNavegacao.navegacao;
        }
    }

    public class scDataGridView : DataGridView, IComponente
    {
        private bool bDesabilitar = true;

        [Description ( "Define se o campo será desabilitado em navegação" ), Category ( "Peladeiros" ), DefaultValue ( true )]
        public bool Desabilitar
        {
            get { return bDesabilitar; }
            set { bDesabilitar = value; }
        }

        public void AtualizarNavegacao( Enumerados.eModoNavegacao pModoNavegacao )
        {
            if ( Desabilitar )
                Enabled = Enabled = pModoNavegacao != Enumerados.eModoNavegacao.navegacao;
        }
    }

    public class scTextBox : TextBox, IComponente
    {
        private bool bDesabilitar = true;

        [Description ( "Define se o campo será desabilitado em navegação" ), Category ( "Peladeiros" ), DefaultValue ( true )]
        public bool Desabilitar
        {
            get { return bDesabilitar; }
            set { bDesabilitar = value; }
        }

        public void AtualizarNavegacao( Enumerados.eModoNavegacao pModoNavegacao )
        {
            if ( Desabilitar )
                Enabled = Enabled = pModoNavegacao != Enumerados.eModoNavegacao.navegacao;
        }
    }
}
