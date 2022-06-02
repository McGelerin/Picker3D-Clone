# Picker 3D Clone

Projemi ziyaret eden herkese merhabalar, size kendimdimden bahsetmek istiyorum. Ben yazılım mühendisi ve oyun geliştiricisiyim. Arkadaşlarım ile şimdiye kadar google play storeda 3 adat bağımsız oyunumuz bulunmakta. Bu projeyi tek başıma geliştirdim ve size projemden bahsetmek istiyorum.

Projemi yaklaşık 4.5 gün içinde geliştirdim, SOLID prensiplerine özellikle dikkat etmeye çalıştım. Oyunumu deneyebilmeniz için bir pc buildi oluşturdum. Projemi beğenirseniz çok sevinirim. Şimdiden iyi eğlenceler..

## Oyun İçi Görüntüler

![](https://raw.githubusercontent.com/McGelerin/Picker3D-Clone/main/Game%20Pic/Picker3D_SS1.png)

------------

![](https://raw.githubusercontent.com/McGelerin/Picker3D-Clone/main/Game%20Pic/Picker3D_SS2.png)

------------

![](https://raw.githubusercontent.com/McGelerin/Picker3D-Clone/main/Game%20Pic/Picker3D_SS3.png)

------------

## Oyunumun Videosu

[![WatchMe](https://raw.githubusercontent.com/McGelerin/Picker3D-Clone/main/Game%20Pic/YoutubeLinkPic.png "WatchMe")](https://youtu.be/XsYK0quHcVs "WatchMe")

------------

## Oyunumun Özellikleri

### Unity
Oyunumu Unity 2021.1.17f1 sürümü kullanarak yazdım.
### Scriptable Objects
Oyunda ayarlanması gereken özelliklerin çoğunu scriptable obje kullanarak yazdım. Özellikle levelleri kolay bir şekilde oluşturabilirsiniz. Oluşturduğunuz scriptable objenizi level kontrollera atarak yeni levelinizi oyunda görebilirsiniz.
![](https://raw.githubusercontent.com/McGelerin/Picker3D-Clone/main/Game%20Pic/Picker3D_SS4_ScriptableObjects2.png)
![](https://raw.githubusercontent.com/McGelerin/Picker3D-Clone/main/Game%20Pic/Picker3D_SS4_ScriptableObjects.png)
![](https://raw.githubusercontent.com/McGelerin/Picker3D-Clone/main/Game%20Pic/Picker3D_SS4_LevelControllerInspector.png)
![](https://raw.githubusercontent.com/McGelerin/Picker3D-Clone/main/Game%20Pic/Picker3D_SS4_LevelScriptableObjectsInspector.png)


------------

Ek olarak magnet scriptable objesinde hız, renk, boyut bulunmaktadır. Fakat şimdilik sadece hız kullanılmatadır. İleriki zamanlarda diğer değişlenleride kullanacağım.

![](https://raw.githubusercontent.com/McGelerin/Picker3D-Clone/main/Game%20Pic/Picker3D_SS4_MagnetInspector.png)

------------

### Swerve Mechanic
Oyunu mouse ile oynanacak şekilde ve herhangi bir lane olmayacak şekilde tasarladım. Gerçek oyun sewerve mekaniğe sahip olduğu için bende oyunumde swerve mekanik yazdım. Swerve mekaniğimin özelliklerini oluşturduğum scriptable objeden ayarlayabilirsiniz.

![](https://raw.githubusercontent.com/McGelerin/Picker3D-Clone/main/Game%20Pic/Picker3D_SS4_SwerveScriptableObjects.png)

------------

### Save System
Oyunumda herhangi bir score puanım bulunmamaktadır. Score yerine, level geçmenin scora eşit olacağını düşündüm. Bu yüzden leveli oyun açılırken load ediyor, level geçince save ediyorum.
### Cinemachine
Oyunumda magnetimin takibini Cinemachine kamera kullandım.
### Universal Render Pipline
Oyunun renderlanmasının daha performaslı olmasını sağlayan Universal Render Pipline kullandım.
### DOTween (Hot v2)
Oyunumda platformların harekentide kullandım.
### Oyun Sonu Easter Egg
Ekran görüntülerinde paylaştığım gibi oyun sonunda **Dark Souls** göndermesi bulunmaktadır.
