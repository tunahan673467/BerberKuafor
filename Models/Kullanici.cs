using Microsoft.AspNetCore.Identity;

namespace BerberKuafor.Models
{
    public class Kullanici : IdentityUser
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Eposta { get; set; }
        public string Sifre { get; set; }
        public Salon Salon { get; set; }
    }
}
