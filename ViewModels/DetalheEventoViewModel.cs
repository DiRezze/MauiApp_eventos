using MauiGerenteDeEventos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiGerenteDeEventos.ViewModels
{
    public class DetalheEventoViewModel
    {
        private Evento _evento;

        public Evento Evento
        {
            get => _evento;
            set.OnPropertyChanged()
            {
                _evento = value;
                OnPropertyChanged();
            }
        }



    }
}
