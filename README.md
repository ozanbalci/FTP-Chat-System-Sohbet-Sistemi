# FTP Chat System // Sohbet-Sistemi

## TR
FTp üzerinde bağlanarak çalışan bir sohbet sistemidir 

# Nasıl Kullanacağız 

Bedava hosting veren bir site bularak orada açacağınız bir ftp sunucusu ile rahatlıkla kullanabillirsiniz ben size alt tarafda bir kaç örnek site vereceğim 

- [HostingAll](http://www.uhostall.com) -  bu Site için sahte mail kullanmanızı öneriyorum 
- [000webhost](https://tr.000webhost.com)
- [poyrazhosting](https://www.poyrazhosting.com.tr)

```C#
 ftp.Credentials = new NetworkCredential("Ftp Login Name", "Enter Ftp Password"); 
         richTextBox1.Text = ftp.DownloadString("ftp://chatverti.com/panel.txt");
         
 ftp.Credentials = new NetworkCredential("örnek1", "şifre123456); 
          ichTextBox1.Text = ftp.DownloadString("ftp://örnek1.com/panel.txt"); 

```
<img src="https://cdn.discordapp.com/attachments/556828295941980170/721351662395981895/unknown.png"/>  
<img src="https://cdn.discordapp.com/attachments/556828295941980170/721351718591528990/unknown.png"/>
<img src="https://cdn.discordapp.com/attachments/556828295941980170/721351790523711558/unknown.png"/>

# Örnek URL

- ftp://vasts_999999@ftp.vastserve.com/htdocs/panel.txt [UhostingAll](http://www.uhostall.com) üzerinde açıldı 
yani sizin yol uzantınız farklı olabillir 

# hatırlatma 
- yukarıdaki işlemleri kaynak koda 3 defa yapacaksınız sakın unutmayın 

- Birinci 
<img src="https://cdn.discordapp.com/attachments/556828295941980170/721353425358684183/unknown.png"/>  
- İkinci 
<img src="https://cdn.discordapp.com/attachments/556828295941980170/721353467393867796/unknown.png"/>
- Üçüncü
<img src="https://cdn.discordapp.com/attachments/556828295941980170/721353499861844018/unknown.png"/>

- Yukarıda Örnek SS bıraktım 
