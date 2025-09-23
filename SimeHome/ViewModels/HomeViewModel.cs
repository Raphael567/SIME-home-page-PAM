using SimeHome.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace SimeHome.ViewModels
{
    public class HomeViewModel : BindableObject
    {
        public ObservableCollection<string> Filtros { get; set; }
        public ObservableCollection<Sala> Salas { get; set; }

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

            IsPressed = new Command<Sala>(isPressed);
        }

        public void isPressed(Sala sala)
        {
            System.Diagnostics.Debug.WriteLine($"Sala clicada: {sala.Num}");
        }
    }
}
