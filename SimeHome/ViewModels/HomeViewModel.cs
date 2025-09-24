using SimeHome.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace SimeHome.ViewModels
{
    public class HomeViewModel : BindableObject
    {
        public ObservableCollection<string> Filtros { get; set; }
        public ObservableCollection<Sala> Salas { get; set; }
        public ObservableCollection<int> Dias { get; set; }
        public ObservableCollection<Semana> Semana { get; set; }
        public ObservableCollection<string> FooterIcons { get; set; }

        public ICommand IsPressed { get; }

        public HomeViewModel()
        {
            Filtros = new ObservableCollection<string>()
            {
                "Salas",
                "Labs",
                "Outros"
            };

            Salas = new ObservableCollection<Sala>()
            {
                new Sala { Num = "1", NumChamados = "01" },
                new Sala { Num = "2", NumChamados = "00" },
                new Sala { Num = "3", NumChamados = "02" },
                new Sala { Num = "4", NumChamados = "01" }
            };

            Semana = new ObservableCollection<Semana>()
            {
                new Semana { Dia = "29", Nome = "seg" },
                new Semana { Dia = "30", Nome = "ter" },
                new Semana { Dia = "1", Nome = "qua" },
                new Semana { Dia = "2", Nome = "qui" },
                new Semana { Dia = "3", Nome = "sex" },
                new Semana { Dia = "4", Nome = "sab" },
            };

            IsPressed = new Command<Sala>(isPressed);

            Dias = new ObservableCollection<int>(
                Enumerable.Range(1, 30)
            );

            var nomesBase = new string[]
            {
                "home",
                "pendentes",
                "criar_chamado",
                "concluidas",
                "criar",
            };

            FooterIcons = new ObservableCollection<string>(nomesBase.Select(nome => $"{nome}.png"));
        }

        public void isPressed(Sala sala)
        {
            System.Diagnostics.Debug.WriteLine($"Sala clicada: {sala.Num}");
        }
    }
}
