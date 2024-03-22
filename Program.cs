//builder objesi içerisine bir web applicaiton kurulduğunu belirtiyor.
var builder = WebApplication.CreateBuilder(args);
//Burada boş olan projemizde controller ve view kullanımı yapılacağını belirtiyoruz. Yani MVC yapısını kullanacağımızı belirtiyoruz.
builder.Services.AddControllersWithViews();
// proje build ediliyor. İlgili servisler ayağa kaldırılıyor.
var app = builder.Build();

//static olarak proje içerisindeki dosyaların çağırılabilmesi için bu fonksiyon kullanılır
app.UseStaticFiles();

//middleware lerin yönlendirmelerden önce çalıştığından emin olmak için ekledik.
app.UseRouting();

//default olarak rota eklemek için bu yapıda kullanılabilir. {controller=Home}/{action=Index}/{id?}
//app.MapDefaultControllerRoute();

//direkt default değerleri elimizle de verebiliriz. name değeri ve pattern değerlerini gönderiyoruz.
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

//gidilecek olan rotalar, middleware yapılarının eklendiği satırlar.
//app.MapGet("/", () => "Hello World!");

//projenin çalıştırılması için yazılan kod kısmıdır.
app.Run();
