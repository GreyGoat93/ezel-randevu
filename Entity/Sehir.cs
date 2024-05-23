namespace Entity;

public class Sehir
{
    public int Id { get; set; }
    public string Isim { get; set; }

    public Sehir(int id, string isim)
    {
        Id = id;
        Isim = isim;
    }
}