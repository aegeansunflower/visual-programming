
class TemelKart
{
    public string AdSoyad { get; set; }
    public int KartNo { get; set; }

    public TemelKart(string ad, int no)
    {
        AdSoyad = ad;
        KartNo = no;
    }


    public void KapiyiAc()
    {
        Console.WriteLine(AdSoyad + " için kapı açıldı.");
    }
}

//INHERITANCE KISMI

class OgrenciKarti : TemelKart
{
    public double NotOrtalamasi { get; set; }

    public OgrenciKarti(string ad, int no, double ortalama) : base(ad, no)
    {
        NotOrtalamasi = ortalama;
    }

    public void DersSec()
    {
        Console.WriteLine("Ders seçimi yapıldı.");
    }
}
