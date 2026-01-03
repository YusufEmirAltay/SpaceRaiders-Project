# Arduino Leonardo & Unity: Space Raiders HID Controller Project

[cite_start]Bu proje, **Arduino Leonardo** mikrodenetleyicisinin yerleşik USB desteği kullanılarak geliştirilen özel bir oyun kontrolcüsünün (Custom Gamepad), **Unity** oyun motoru ile entegrasyonunu kapsamaktadır[cite: 15, 16]. [cite_start]Proje, düşük gecikmeli veri iletim protokolleri ve nesne yönelimli yazılım mimarisi üzerine kurgulanmıştır[cite: 16, 20].

## 🚀 Proje Özellikleri

* [cite_start]**HID Protokolü:** ATmega32U4 çipli Arduino Leonardo üzerinden "Sürücüsüz" (Zero-Driver) tak-çalıştır desteği[cite: 16, 19, 97].
* [cite_start]**Gecikme Optimizasyonu:** Kablolu bağlantı ile 8ms - 12ms aralığında düşük girdi gecikmesi[cite: 98, 159].
* [cite_start]**Yazılım Mimarisi:** Unity üzerinde **Observer Design Pattern** ile bağımsızlaştırılmış UI yönetimi[cite: 21, 133].
* [cite_start]**Sinyal İşleme:** Analog joystick verileri için yazılımsal **"Deadzone"** filtreleme[cite: 17, 127].
* [cite_start]**Endüstriyel Tasarım:** Ergonomik kullanım için FDM teknolojisi ile üretilmiş özel 3D baskı kasa[cite: 60, 108].

## 🛠️ Teknik Detaylar

### Donanım Katmanı
[cite_start]Sistem, 2 eksenli bir analog joystick ve 7 adet dijital butondan oluşur[cite: 118]. [cite_start]Joystickten alınan 10-bitlik ADC verileri, mikro-titreşimleri engellemek adına 20 birimlik bir eşik değeriyle filtrelenmektedir[cite: 127, 128, 161].



### Yazılım Katmanı
[cite_start]Oyun mekanikleri, %25 olasılıklı bir ganimet (Loot) sistemi ve `Time.deltaTime` tabanlı zamanlayıcılar ile yönetilmektedir[cite: 22, 23, 167].



## 🏗️ Kullanılan Teknolojiler

| Kategori | Bileşen |
| :--- | :--- |
| **Mikrodenetleyici** | [cite_start]Arduino Leonardo (ATmega32U4) [cite: 102, 119] |
| **Oyun Motoru** | [cite_start]Unity (C#) [cite: 106, 107] |
| **Kütüphaneler** | [cite_start]`Joystick.h`, `UnityEngine.UI` [cite: 105, 134] |
| **Üretim** | [cite_start]3D Printing (PLA Filament) [cite: 109, 152] |

## 📦 Kurulum ve Çalıştırma

1. [cite_start]**Arduino:** `/Arduino` klasöründeki kodları Leonardo kartınıza yükleyin[cite: 204].
2. [cite_start]**Unity:** `/UnityProject` klasörünü Unity Hub ile açın[cite: 206].
3. [cite_start]**Bağlantı:** Cihazı USB üzerinden bağladığınızda sistem otomatik olarak bir Gamepad (HID) olarak algılanacaktır[cite: 16, 124].

## 🔧 Sorun Giderme (Debug Log)
[cite_start]Geliştirme sürecinde başlangıçta hedeflenen Bluetooth mimarisi, yüksek paket kaybı ve gecikme nedeniyle iptal edilmiş; kararlılık adına kablolu HID mimarisine geçilmiştir[cite: 18, 182].

## 🔮 Gelecek Planları (Roadmap)
* [cite_start]**Haptik Geri Bildirim:** ERM motoru ile fiziksel titreşim uyarısı[cite: 187].
* [cite_start]**RGB Durum Bildirimi:** Kalkan miktarına göre kontrolcü üzerinde renk değişimi[cite: 188].
* [cite_start]**AI Entegrasyonu:** Oyuncu becerisine göre dinamik zorluk ayarı[cite: 200].

---

[cite_start]**Yusuf Emir ALTAY** [cite: 4]
[cite_start]*Bilişim Sistemleri Mühendisliği* [cite: 12]
[cite_start]*Kocaeli Üniversitesi* [cite: 11]