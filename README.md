# Arduino Leonardo & Unity: Space Raiders HID Controller Project

Bu proje, **Arduino Leonardo** mikrodenetleyicisinin yerleşik USB desteği kullanılarak geliştirilen özel bir oyun kontrolcüsünün (Custom Gamepad), **Unity** oyun motoru ile entegrasyonunu kapsamaktadır. Proje, düşük gecikmeli veri iletim protokolleri ve nesne yönelimli yazılım mimarisi üzerine kurgulanmıştır.

## 🚀 Proje Özellikleri

* **HID Protokolü:** ATmega32U4 çipli Arduino Leonardo üzerinden "Sürücüsüz" (Zero-Driver) tak-çalıştır desteği.
* **Gecikme Optimizasyonu:** Kablolu bağlantı ile 8ms - 12ms aralığında düşük girdi gecikmesi.
* **Yazılım Mimarisi:** Unity üzerinde **Observer Design Pattern** ile bağımsızlaştırılmış UI yönetimi.
* **Sinyal İşleme:** Analog joystick verileri için yazılımsal **"Deadzone"** filtreleme.
* **Endüstriyel Tasarım:** Ergonomik kullanım için FDM teknolojisi ile üretilmiş özel 3D baskı kasa.

## 🛠 Teknik Detaylar

### Donanım Katmanı
Sistem, 2 eksenli bir analog joystick ve 7 adet dijital butondan oluşur. Joystickten alınan 10-bitlik ADC verileri, mikro-titreşimleri engellemek adına 20 birimlik bir eşik değeriyle filtrelenmektedir.

### Yazılım Katmanı
Oyun mekanikleri, %25 olasılıklı bir ganimet (Loot) sistemi ve `Time.deltaTime` tabanlı zamanlayıcılar ile yönetilmektedir.

## 🏗 Kullanılan Teknolojiler

| Kategori | Bileşen |
| :--- | :--- |
| **Mikrodenetleyici** | Arduino Leonardo (ATmega32U4) |
| **Oyun Motoru** | Unity (C#) |
| **Kütüphaneler** | `Joystick.h`, `UnityEngine.UI` |
| **Üretim** | 3D Printing (PLA Filament) |

## 📦 Kurulum ve Çalıştırma

1. **Arduino:** `/Arduino` klasöründeki kodları Leonardo kartınıza yükleyin.
2. **Unity:** `/UnityProject` klasörünü Unity Hub ile açın.
3. **Bağlantı:** Cihazı USB üzerinden bağladığınızda sistem otomatik olarak bir Gamepad (HID) olarak algılanacaktır.

---
**Yusuf Emir ALTAY** *Bilişim Sistemleri Mühendisliği* *Kocaeli Üniversitesi*