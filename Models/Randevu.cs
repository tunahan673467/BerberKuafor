namespace BerberKuafor.Models
{
    public class Randevu
    {
        public int Id { get; set; }
        public string MusteriId { get; set; }
        public int CalisanId { get; set; }
        public int HizmetId { get; set; }
        public DateTime RandevuZamani { get; set; }
        public RandevuDurumu Durum { get; set; }
    }
}
