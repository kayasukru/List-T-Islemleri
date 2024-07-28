using System.Collections;
using System.Collections.Generic;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        var list = new List<int>()
        {
            {101 },
            {102 },
            {103 },
            {104 },
            {105 }
        };

        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);
        list.Add(5);
        list.Add(6);
        list.Add(7);
        list.Add(8);
        list.Add(9);
        list.Add(10);

        list.Sort(); // artan sıralar
        list.Reverse(); // sıralamayı tersine çevirir

        foreach (var s in list)
        {
            Console.Write($"{s}  ");
        }
        Console.WriteLine();
        Console.WriteLine("------------------------");
        Console.WriteLine();

        var sayilar = new List<int>() { 53, 25, 65, 12, 3, 28 };
        sayilar.Sort(); // elemanları artan şekilde sıralar
        sayilar.ForEach(s => Console.WriteLine(s));

        Console.WriteLine();
        Console.WriteLine("------------------------");
        Console.WriteLine();

        var sehirler = new List<Sehir>()
        {
            new Sehir(6, "Ankara"),
            new Sehir(1, "Adana"),
            new Sehir(7, "Antalya"),
            new Sehir(67, "Zonguldak"),
            new Sehir(31, "Hatay"),
            new Sehir(16, "Bursa"),
        };

        //Aşağıdaki sıralama 2 elemanlı list öğelerinde çalışmaz
        //IComparable<Sehir> implemente edilip CompareTo(String other) metodu kullanılarak sıralama yapılabilir.
        //Burada bu metodla PlakaNo alanına göre sıralama yapıldı
        sehirler.Sort();
        //sehirler.ForEach(s => Console.WriteLine($"{s.PlakaNo} {s.SehirAdi}"));
        sehirler.ForEach(s => Console.WriteLine(s));

    }
}

public class Sehir : IComparable<Sehir>
{
    public int PlakaNo { get; set; }
    public string SehirAdi {  get; set; }

    public Sehir(int plakaNo, string sehirAdi)
    {
        PlakaNo = plakaNo;
        SehirAdi = sehirAdi;
    }
    public override string? ToString()
    {
        return $"{PlakaNo,-5} {SehirAdi,-15}";
    }

    // IComparable<Sehir> dan alınan implement ile aşağıda
    // plaka no ya göre ARTAN sıralandı
    public int CompareTo(Sehir? other)
    {
        if (this.PlakaNo < other.PlakaNo)
        {
            return -1;
        }
        else if (this.PlakaNo == other.PlakaNo)
        {
            return 0;
        }
        else
        {
            return 1;
        }
    }
}


