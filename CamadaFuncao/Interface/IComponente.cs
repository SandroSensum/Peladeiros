using static CamadaFuncao.Enumerados;

namespace CamadaFuncao.Interface
{
    public interface IComponente
    {
        bool Desabilitar { get; set; }
        void AtualizarNavegacao( eModoNavegacao pModoNavegacao );
    }
}
