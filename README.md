⛽ Benzin İstasyonu Stok & Alış Sistemi

Bu proje, C# Windows Forms kullanılarak geliştirilen akaryakıt stok takibi ve alış işlemleri uygulamasıdır. Kullanıcı, benzin türünü seçerek alış fiyatını görüntüleyebilir, alınacak litre miktarını girerek toplam tutarı otomatik hesaplatabilir ve stok güncellemesi yapabilir.

🔧 Kullanılan Teknolojiler

C# (.NET Framework / Windows Forms)
Uygulamanın arayüzü ve iş mantığı oluşturuldu.

SQL Server (MSSQL)
Benzin türleri, alış fiyatları, satış fiyatları ve stokların tutulduğu veritabanı.

ADO.NET (SqlConnection, SqlCommand)
Veritabanı bağlantıları, sorgular ve güncellemeler bu yapı ile gerçekleştirildi.

📌 Sistem Özeti

Uygulamada 4 farklı akaryakıt türü ComboBox üzerinden seçilebiliyor.

Seçilen akaryakıt türüne göre ALIŞ fiyatı otomatik olarak SQL Server’dan çekiliyor.

Kullanıcı alınacak litre miktarını girdiğinde, toplam alış tutarı otomatik hesaplanıyor.

“Satın Al” işlemi yapıldığında:

Seçili akaryakıt türünün stoğu artırılıyor,

Kasa veya işlem tablosu isteğe göre güncellenebiliyor,

ProgressBar ilgili depo seviyesini gösteriyor.

Arayüz tamamen Windows Forms bileşenleri (ComboBox, TextBox, ProgressBar vb.) ile oluşturulmuştur.

🎯 Amaç

Bu proje, küçük ölçekte bir benzin istasyonu için:

Stok yönetimini kolaylaştırmak,

Alış fiyatı üzerinden otomatik hesaplama yapmak,

Hatalı veri girişlerini önlemek,

Kullanıcıya hızlı ve anlaşılır bir arayüz sunmak

amacıyla geliştirilmiştir.

📸 Uygulama Görseli
![Petrol](https://github.com/user-attachments/assets/ce02b540-7022-4976-bf44-48f9abd3c217)
