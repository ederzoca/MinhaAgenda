using CoreBusiness.Entidades;

namespace CasosDeUso.PluginsInterfaces
{
    public interface IRepositorioDeObservacao
    {
        Task AdicionarObservacao(Observacao observacao);
    }
}
