using MauiGerenteDeEventos.Models;

namespace MauiGerenteDeEventos.Views;

public partial class CadastroEventos : ContentPage
{
	public CadastroEventos()
	{
		InitializeComponent();

		dataInicioPicker.MinimumDate = DateTime.Now;
		dataTerminoPicker.MinimumDate = DateTime.Now.AddDays(1);
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			string nome = nomeEntry.Text;

			if (string.IsNullOrEmpty(nome))
			{
				await DisplayAlert("Erro", "O nome do evento é um campo obrigatório.", "OK");
			}

			string local = localEntry.Text;
			DateTime dataInicio = dataInicioPicker.Date;
			DateTime dataTermino = dataTerminoPicker.Date;
			int numeroParticipantes = int.TryParse(numeroParticipantesEntry.Text, out var num) ? num : 0;

            if (numeroParticipantes <= 0)
            {
                await DisplayAlert("Erro", "Número de participantes deve ser maior que zero.", "OK");
                return;
            }

            decimal custoPorParticipante = decimal.TryParse(custoPorParticipanteEntry.Text, out var custo) ? custo : 0m;

			if(custoPorParticipante == 0)
			{
                await DisplayAlert("Opa!", "Você definiu o custo por participante como GRATUITO. Tem certeza disso?", "Voltar");
                return;
            }

			Evento eventoCriado = new Evento() { 
				nome = nome, 
				local = local, 
				dataInicio = dataInicio, 
				dataTermino = dataTermino, 
				numeroParticipantes=numeroParticipantes,
				custoPorParticipante=custoPorParticipante,
			};

			await Navigation.PushAsync(new DetalhesEvento(eventoCriado));

		}
		catch (Exception ex)
		{
			await DisplayAlert("Ops, algo deu errado!", ex.Message, "Tentar novamente.");
		}

    }

    private void dataInicioPicker_DateSelected(object sender, DateChangedEventArgs e)
    {
		dataTerminoPicker.MinimumDate = dataInicioPicker.Date.AddDays(1);
    }

}