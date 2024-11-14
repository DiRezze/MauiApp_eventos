using MauiGerenteDeEventos.Models;

namespace MauiGerenteDeEventos.Views;

public partial class DetalhesEvento : ContentPage
{
	public DetalhesEvento(Evento eventoExibido)
	{
		InitializeComponent();

        nomeLabel.Text = $"{eventoExibido.nome}";
        localLabel.Text = $"Local: {eventoExibido.local}";

        dataInicioLabel.Text = $"Início: {eventoExibido.dataInicio:dd/MM/yyyy}";
        dataTerminoLabel.Text = $"Término: {eventoExibido.dataTermino:dd/MM/yyyy}";

        string unidadeDuracao = eventoExibido.duracaoEmDias > TimeSpan.FromDays(1) ? "dias" : "dia";

        duracaoLabel.Text = $"Duração: {eventoExibido.duracaoEmDias.Days} {unidadeDuracao}"; 

        participantesLabel.Text = $"Participantes: {eventoExibido.numeroParticipantes}";
        custoLabel.Text = $"Custo por Participante: {eventoExibido.custoPorParticipante:C}";
        custoTotalLabel.Text = $"Custo Total: {eventoExibido.custoTotal:C}";

    }

    private async void retornar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }
}