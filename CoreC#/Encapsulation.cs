class Urun
{
    private double _fiyat;

    public string Ad { get; set; }

    public double Fiyat
    {
        get { return _fiyat; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Hata: Fiyat eksi olamaz! 0 yapıldı.");
                _fiyat = 0;
            }
            else
            {
                _fiyat = value;
            }
        }
    }
}
