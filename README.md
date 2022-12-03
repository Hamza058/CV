# Proje Veri Tabanı Tabloları

<b>Admin Tablosu</b>

<table>
  <tr>
    <th>ID</th>
    <th>KullaniciAd</th>
    <th>Sifre</th>
  </tr>
  <tr>
    <td>int</td>
    <td>varchar(10)</td>
    <td>varchar(10)</td>
  </tr>
</table>

<hr>

<b>Calismalar Tablosu</b>

<table>
  <tr>
    <th>ID</th>
    <th>Calisma</th>
  </tr>
  <tr>
    <td>int</td>
    <td>varchar(100)</td>
  </tr>
</table>

<hr>

<b>Deneyim Tablosu</b>

<table>
  <tr>
    <th>ID</th>
    <th>IsDeneyimi</th>
  </tr>
  <tr>
    <td>int</td>
    <td>varchar(100)</td>
  </tr>
</table>

<hr>

<b>Hakkinda Tablosu</b>

<table>
  <tr>
    <th>ID</th>
    <th>Bilgiler</th>
    <th>Egitim</th>
  </tr>
  <tr>
    <td>int</td>
    <td>varchar(500)</td>
    <td>varchar(500)</td>
  </tr>
</table>

<hr>

<b>Iletisim Tablosu</b>

<table>
  <tr>
    <th>ID</th>
    <th>AdSoyad</th>
    <th>Mail</th>
    <th>Mesaj</th>
    <th>Konu</th>
  </tr>
  <tr>
    <td>int</td>
    <td>varchar(50)</td>
    <td>varchar(50)</td>
    <td>varchar(500)</td>
    <td>varchar(50)</td>
  </tr>
</table>

<hr>

<b>Yetenekler Tablosu</b>

<table>
  <tr>
    <th>ID</th>
    <th>Yetenek</th>
    <th>Derece</th>
  </tr>
  <tr>
    <td>int</td>
    <td>varchar(100)</td>
    <td>tinyint</td>
  </tr>
</table>
