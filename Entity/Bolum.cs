namespace Entity;

class Bolum
{
    public int Id { get; set; }
    public string Isim { get; set; }

    public Bolum(int id, string isim) {
        this.Id = id;
        this.Isim = isim;
    }
}