using Entity;

namespace Service;

class BolumService
{
    public List<Bolum> bolumler = new List<Bolum>{
        new Bolum(1, "Acil Servis"),
        new Bolum(2, "Beyin Ve Sinir Cerrahisi"),
        new Bolum(3, "Dermatoloji"),
        new Bolum(4, "Göz Hastalıkları"),
        new Bolum(5, "Kulak Burun Boğaz"),
        new Bolum(6, "Nöroloji"),
    };
}