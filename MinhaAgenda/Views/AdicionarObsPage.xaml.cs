using CasosDeUso.Interface;

namespace MinhaAgenda.Views;

public partial class AdicionarObservacaoPage : ContentPage
{
    private readonly IAdicionarObservacaoUseCase _adicionarObservacaoUseCase;
	public AdicionarObservacaoPage(IAdicionarObservacaoUseCase _adicionarObservacaoUseCase)
	{
		InitializeComponent();
        _adicionarObservacaoUseCase = _adicionarObservacaoUseCase;
	}

    private async void observacoesCtrl_OnSave(object sender, EventArgs e)
    {
        var observacao1 = observacoesCtrl.Observacao1;
        var observacao2 = observacoesCtrl.Observacao2;

        var novaObservacao = new Observacao(observacao1, observacao2);
        await _adicionarObservacaoUseCase.ExecutaAsync(novaObservacao);

        await Shell.Current.GoToAsync($"//{nameof(ContatosPage)}");
    }

}
