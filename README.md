# Villa Emlak Yönetimi Projesi

## 📚 Proje Hakkında

Bu proje, **Villa Emlak Yönetimi** uygulamasıdır. Kullanıcılar kayıt olabilir, giriş yapabilir ve admin paneli üzerinden CRUD işlemleri gerçekleştirebilir. Proje, MongoDB veritabanı kullanarak güçlü ve esnek bir yapı sunmaktadır. Backend ve frontend taraflarında geliştirme yapılabilir, böylece farklı işlevsellikler eklenebilir.

## 🚀 Kullanılan Teknolojiler

- **MongoDb** – Veritabanı yönetimi için
- **Entity Framework Core (EF Core)** – ORM aracı olarak
- **ASP.NET Core** – Backend geliştirme
- **HTML, CSS, JavaScript** – Frontend geliştirme
- **Çok Katmanlı Mimari (Layered Architecture)**
- **Repository Design Pattern** – Veri erişimi soyutlama
- **JWT (JSON Web Token)** – Kimlik doğrulama için
- **Bootstrap** – UI bileşenleri için

## 💻 Projeyi Çalıştırmak

Projeyi yerel bilgisayarınızda çalıştırmak için aşağıdaki adımları takip edebilirsiniz:

### 1. Projeyi İndirin

Proje dosyalarını bilgisayarınıza klonlayın:

```bash
git clone https://github.com/YasarDogann/Villa.git
```
## 2. Gerekli Paketleri Yükleyin

Projede kullanılan NuGet paketlerini yüklemek için aşağıdaki komutu çalıştırabilirsiniz:

```bash
dotnet restore
```
### 3. Veritabanı Bağlantılarını Yapılandırın

`appsettings.json` dosyasındaki MongoDB bağlantı ayarlarını aşağıdaki gibi güncelleyin:
```bash
"ConnectionStrings": {
    "MongoDb": "mongodb://localhost:27017"
}
```
### 4. Uygulamayı Başlatın

Projeyi başlatmak için aşağıdaki komutu kullanabilirsiniz:
```bash
dotnet run
```
Projeyi başlattıktan sonra uygulama varsayılan olarak https://localhost:5001 adresinde çalışacaktır.


## 👩‍💻 Admin Paneli

Admin paneline giriş yaptıktan sonra aşağıdaki işlemleri gerçekleştirebilirsiniz:

 - Kullanıcılar üzerinde CRUD işlemleri yapılabilir.
 - Admin paneline erişim için kimlik doğrulama işlemi gereklidir.

## 🔑 Kimlik Doğrulama

Bu projede JWT (JSON Web Token) kullanılarak kimlik doğrulama sağlanmaktadır. Kullanıcılar, sisteme kayıt olduktan sonra giriş yaparak uygulamanın tüm özelliklerine erişebilirler.

## 📄 Proje Yapısı

Proje, Layered Architecture prensiplerine uygun şekilde yapılandırılmıştır:

  - Data Layer – Veritabanı işlemleri için
  - Business Layer – İş mantığı ve iş kuralları
  - API Layer – Controller ve API uç noktaları

## 🤝 Katkı Sağlamak

Projenin geliştirilmesine katkı sağlamak isterseniz, aşağıdaki adımları izleyebilirsiniz:
1. Fork yapın.
2. Yeni bir branch oluşturun (git checkout -b feature/your-feature).
3. Değişikliklerinizi yapın ve commit edin (git commit -am 'Add new feature').
4. Push edin (git push origin feature/your-feature).
5. Pull request açın.

##📧 İletişim

Herhangi bir sorunuz olursa, bana GitHub üzerinden ulaşabilirsiniz: YasarDogann
