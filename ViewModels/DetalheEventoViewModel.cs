using MauiGerenteDeEventos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiGerenteDeEventos.ViewModels
{
    // Não vou mentir, eu fiz isso aqui com IA
    public class CadastroEventosViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string nome;
        private string local;
        private DateTime dataInicio;
        private DateTime dataTermino;
        private int numeroParticipantes;
        private decimal custoPorParticipante;

        public string Nome
        {
            get => nome;
            set { nome = value; OnPropertyChanged(nameof(Nome)); }
        }

        public string Local
        {
            get => local;
            set { local = value; OnPropertyChanged(nameof(Local)); }
        }

        public DateTime DataInicio
        {
            get => dataInicio;
            set { dataInicio = value; OnPropertyChanged(nameof(DataInicio)); }
        }

        public DateTime DataTermino
        {
            get => dataTermino;
            set { dataTermino = value; OnPropertyChanged(nameof(DataTermino)); }
        }

        public int NumeroParticipantes
        {
            get => numeroParticipantes;
            set { numeroParticipantes = value; OnPropertyChanged(nameof(NumeroParticipantes)); }
        }

        public decimal CustoPorParticipante
        {
            get => custoPorParticipante;
            set { custoPorParticipante = value; OnPropertyChanged(nameof(CustoPorParticipante)); }
        }

        protected virtual void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

}
