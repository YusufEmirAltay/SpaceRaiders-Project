# Arduino Leonardo & Unity: Space Raiders HID Controller Project

Bu proje, **Arduino Leonardo** mikrodenetleyicisinin yerleşik USB desteği kullanılarak geliştirilen özel bir oyun kontrolcüsünün (Custom Gamepad), **Unity** oyun motoru ile entegrasyonunu kapsamaktadır[cite: 15, 16]. [cite_start]Sistem, düşük gecikmeli veri iletim protokolleri ve nesne yönelimli yazılım mimarisi üzerine kurgulanmıştır[cite: 16, 20].

## 🚀 Proje Özellikleri

* [cite_start]**HID Protokolü:** ATmega32U4 çipli Arduino Leonardo üzerinden "Sürücüsüz" (Zero-Driver) tak-çalıştır desteği[cite: 16, 19, 97].
* [cite_start]**Gecikme Optimizasyonu:** Kablolu bağlantı ile 8ms - 12ms aralığında düşük girdi gecikmesi[cite: 98, 159].
* [cite_start]**Yazılım Mimarisi:** Unity üzerinde **Observer Design Pattern** ile bağımsızlaştırılmış UI yönetimi[cite: 21, 133].
* [cite_start]**Sinyal İşleme:** Analog joystick verileri için yazılımsal **"Deadzone"** filtreleme[cite: 17, 127].
* [cite_start]**Endüstriyel Tasarım:** Ergonomik kullanım için FDM teknolojisi ile üretilmiş özel 3D baskı kasa[cite: 60, 108].

## 🛠 Teknik Detaylar

### Donanım Katmanı
[cite_start]Sistem, 2 eksenli bir analog joystick ve 7 adet dijital butondan oluşur[cite: 118]. [cite_start]Joystickten alınan 10-bitlik ADC verileri, mikro-titreşimleri engellemek adına 20 birimlik bir eşik değeriyle filtrelenmektedir[cite: 127, 128, 161].

### Yazılım Katmanı
[cite_start]Oyun mekanikleri, %25 olasılıklı bir ganimet (Loot) sistemi ve `Time.deltaTime` tabanlı zamanlayıcılar ile yönetilmektedir[cite: 22, 23, 167].

## 🏗 Kullanılan Teknolojiler

| Kategori | Bileşen |
| :--- | :--- |
| **Mikrodenetleyici** | Arduino Leonardo (ATmega32U4) |
| **Oyun Motoru** | Unity (C#) |
| **Kütüphaneler** | `Joystick.h`, `UnityEngine.UI` |
| **Üretim** | 3D Printing (PLA Filament) |

## 📦 Kurulum ve Çalıştırma

1.  **Arduino:** `/Arduino` klasöründeki kodları Leonardo kartınıza yükleyin.
2.  **Unity:** `/UnityProject` klasörünü Unity Hub ile açın.
3.  **Bağlantı:** Cihazı USB üzerinden bağladığınızda sistem otomatik olarak bir Gamepad (HID) olarak algılanacaktır.

## 🔮 Gelecek Planları (Roadmap)
* [cite_start]**Haptik Geri Bildirim:** ERM motoru ile fiziksel titreşim uyarısı[cite: 187].
* [cite_start]**RGB Durum Bildirimi:** Kalkan miktarına göre kontrolcü üzerinde renk değişimi[cite: 188].

---
**Yusuf Emir ALTAY** *Bilişim Sistemleri Mühendisliği* *Kocaeli Üniversitesi*