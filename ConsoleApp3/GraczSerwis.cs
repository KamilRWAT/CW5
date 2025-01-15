using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class GraczSerwis : IGraczSerwis
    {
        private Gracz _aktualnyGracz;
        private List<Gracz> _listaGraczy;

        public GraczSerwis(List<Gracz> listaGraczy)
        {
            _listaGraczy = listaGraczy;
        }

        public void EdycjaSalda(int wygrana)
        {
            _aktualnyGracz.saldo = _aktualnyGracz.saldo + wygrana;
        }

        public void WyswietlGraczy()
        {
            foreach (var gracz in _listaGraczy)
            {
                Console.WriteLine(gracz.Nick);
            }
        }

        public bool Zaloguj(string haslo, string nick)
        {
            foreach (var gracz in _listaGraczy)
            {
                if (gracz.Haslo == haslo && gracz.Nick == nick)
                {
                    _aktualnyGracz = gracz;
                    return true;
                }
            }
            return false;
        }

        public void ZmienHaslo(string haslo)
        {
            _aktualnyGracz.Haslo = haslo;
        }
    }
}
