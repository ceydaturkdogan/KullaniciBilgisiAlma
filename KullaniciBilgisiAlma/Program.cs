

string message = "Lutfen asagidaki bilgileri giriniz";

Console.WriteLine(message);

Console.Write("T.C. Kimlik Numarasi:");

long tc= Convert.ToInt64(Console.ReadLine()); //default olarak string olduğu için ve 32 bitten büyük olduğu için int64e convert edildi

Console.Write("Adi:");

string name = Console.ReadLine();

Console.Write("Soyadi:");

string surname = Console.ReadLine();

Console.Write("Telefon Numarasi:");

long phoneNumber= Convert.ToInt64(Console.ReadLine()); //default olarak string olduğu için ve 32 bitten büyük olduğu için int64e convert edildi

Console.Write("Yas:");

int age = Convert.ToInt32(Console.ReadLine()); //default oldugu için convert ettim fakat 32 bitten bütük olmayacağı için 32bite convert edildi


Console.Write("İlk Aldigi Urunun Fiyati:");

int firstPrice = Convert.ToInt32(Console.ReadLine()); //default oldugu için convert ettim fakat 32 bitten bütük olmayacağı için 32bite convert edildi

Console.Write("İkinci Aldigi Urunun Fiyati:");

int secondPrice = Convert.ToInt32(Console.ReadLine()); //default oldugu için convert ettim fakat 32 bitten bütük olmayacağı için 32bite convert edildi

int lastPrice = firstPrice + secondPrice;

Console.WriteLine("-------------------------------------------------------");

Console.WriteLine(tc + " Tc numarali " + name +" " + surname + " isimli kisi icin kayit olusturulmustur." );
Console.WriteLine(phoneNumber + " telefon numarasina bildirim mesaji gonderilmistir.");
Console.WriteLine((lastPrice) + " toplam harcama karsiligi kazanilan %10 patika puan miktari" + " "+ (lastPrice * 0.1) + "dir");

