using MauiGerenteDeEventos.Models;

namespace MauiGerenteDeEventos.Views;

public partial class DetalhesEvento : ContentPage
{
	public DetalhesEvento(Evento eventoExibido)
	{
		InitializeComponent();

        nomeLabel.Text = $"Nome do Evento: {eventoExibido.nome}";
        localLabel.Text = $"Local: {eventoExibido.local}";

        dataInicioLabel.Text = $"Data de Início: {eventoExibido.dataInicio:dd/MM/yyyy}";
        dataTerminoLabel.Text = $"Data de Término: {eventoExibido.dataTermino:dd/MM/yyyy}";

        string unidadeDuracao = eventoExibido.duracaoEmDias > TimeSpan.FromDays(1) ? "dias" : "dia";

        duracaoLabel.Text = $"Duração do Evento: {eventoExibido.duracaoEmDias.Days} {unidadeDuracao}"; 

        participantesLabel.Text = $"Número de Participantes: {eventoExibido.numeroParticipantes}";
        custoLabel.Text = $"Custo por Participante: {eventoExibido.custoPorParticipante:C}";
        custoTotalLabel.Text = $"Custo Total do Eventoo: {eventoExibido.custoTotal:C}";

    }

    private async void retornar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }
}