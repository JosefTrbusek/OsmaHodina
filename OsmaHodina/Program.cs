using OsmaHodina;

double Kasa = 0;
List<Zbozi> zbozi = new List<Zbozi>();

Notebook vybornyNotebook = new Notebook()
{
    Cena = 50000,
    MaMechaniku = false,
    MnozstviSkladem = 5,
    Nazev = "Vyborny notebook",
    Vaha = 1,
    Velikost = 15,
    Vyrobce = "Vyborna tovarna s.r.o."
};
zbozi.Add(vybornyNotebook);
Notebook neUplneDobryNotebook = new Notebook()
{
    Cena = 5000,
    MaMechaniku = false,    
    Nazev = "Vrakbook",
    Vaha = 6,
    Velikost = 10,
    Vyrobce = "Smelinar s.r.o"
};

zbozi.Add(neUplneDobryNotebook);
Mys mysak = new Mys()
{
    Cena = 100,
    Barva = "Ruzova",
    JeBezdratova = false,
    MnozstviSkladem = 100,
    Nazev = "MickeyMousey",
    PocetTlacitek = 1,
    Vyrobce = "TiTang a.s."
};
zbozi.Add(mysak);

foreach(var item in zbozi)
{
    Console.Write($"{item.Nazev}\t{item.MnozstviSkladem}\t{item.Cena}\t");
    if(item is Notebook)
    {
        Notebook notas = (Notebook)item;
        Console.WriteLine($"{notas.Vaha}\t{notas.Velikost}");
    }
    if(item is Mys)
    {
        Mys mys = (Mys)item;
        Console.WriteLine($"{mys.Barva}\t{mys.PocetTlacitek}");
    }
}

Console.WriteLine("1 - Naskladni polozku");
Console.WriteLine("2 - Prodej");
Console.WriteLine("3 - pridat nove zbozi");

int volba = Convert.ToInt32(Console.ReadLine());
switch(volba)
{
    case 1:
        // obdobny zpusob jako prodeje.
        break;
    case 2:
        Console.WriteLine("Zadej název položky:");
        string nazev = Console.ReadLine();
        Console.WriteLine("Kolik kusu prodavas?");
        int pocetKusu = Convert.ToInt32(Console.ReadLine());
        double cellkovaCena=zbozi[zbozi.FindIndex(x => x.Nazev == nazev)].Prodej(pocetKusu);
        Console.WriteLine("Prodano zboží za " + cellkovaCena + " Kč");
        break;
    case 3:
        //switch(typ zbozi)
        //jakoze vybran notebook
        Zbozi z = new Notebook();
        z.NactiParametry();
        zbozi.Add(z);
        z = new Mys();
        z.NactiParametry();
        zbozi.Add(z);
        break;
}
Console.ReadLine();
