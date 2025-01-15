using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public interface IGraczSerwis
    {
        public void EdycjaSalda(int wygrana);
        public bool Zaloguj(string haslo, string nick);
        public void ZmienHaslo(string haslo);
        public void WyswietlGraczy(); // wyświetl nicki wszystkich graczy na konsole
    }
}
