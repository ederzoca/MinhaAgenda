using CasosDeUso.Interface;
using CasosDeUso.PluginsInterfaces;
using CoreBusiness.Entidades;

namespace CasosDeUso
{

    public class AdicionarObservacaoUseCase : IAdicionarObservacaoUseCase
    {
        private readonly IRepositorioDeObservacao _observacaoRepository;

        public AdicionarObservacaoUseCase(IRepositorioDeObservacao observacaoRepository)
        {
            _observacaoRepository = observacaoRepository;
        }

        public async Task ExecutaAsync(Observacao observacao)
        {
            await _observacaoRepository.AdicionarObservacao(observacao);
        }
    }
}
