using ConsoleApp3;
using System.Text;

string path = "./test.txt";
Gracz gracz1 = new Gracz();
gracz1.Nick = "Tomek";
gracz1.Haslo = "Tomek123";
gracz1.saldo = 100;

Gracz gracz2 = new Gracz();
gracz2.Nick = "Piotr";
gracz2.Haslo = "Piotr12";
gracz2.saldo = 200;

Gracz gracz3 = new Gracz();
gracz3.Nick = "Adam";
gracz3.Haslo = "Adam12";
gracz3.saldo = 300;

List<Gracz> gracze = new List<Gracz>();
gracze.Add(gracz1);
gracze.Add(gracz2);
gracze.Add(gracz3);

List<string> list = new List<string>();
foreach (Gracz g in gracze)
{
    list.Add(g.PelneDane);
    //Console.WriteLine(g.PelneDane);
}

GraczSerwis graczSerwis = new GraczSerwis(gracze);
Console.WriteLine("Podaj nick");
string nick = Console.ReadLine();
Console.WriteLine("Podaj haslo");
string haslo = Console.ReadLine();

if(graczSerwis.Zaloguj(haslo, nick))
{
    Console.WriteLine("Zalogowano");
}
else
{
    Console.WriteLine("Błędne dane");
}

graczSerwis.Usun();

graczSerwis.WyswietlGraczy();


File.WriteAllLines(path,list.ToArray());

Console.ReadLine();