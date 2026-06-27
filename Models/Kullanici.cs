namespace MiniKahveBackend.Models
{
    public class Kullanici
    {
        public int Id { get; set; }
        public string KullaniciAdi { get; set; }
        public string Email { get; set; }
        public string Sifre { get; set; }
        
        // İşte senin o dahiyane fikrini backend'de tutacak yeni alanımız!
        public string KahveTercihi { get; set; } 
    }
}