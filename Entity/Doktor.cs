namespace Entity;

class Doktor
{
    public int Id { get; set; }
    public string Isim { get; set; }
    public int BolumId { get; set; }

    public Doktor(int id, string isim, int bolumId) {
        this.Id = id;
        this.Isim = isim;
        this.BolumId = bolumId;
    }
}