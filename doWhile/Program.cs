int sayac = 0;
Console.Write("Lütfen bir limit değeri giriniz.");
int limit = int.Parse(Console.ReadLine());

do
{
    Console.WriteLine("Ben bir Patika'lıyım.");
    sayac++;
} while (sayac <= limit);

//doWhile döngüsünde "do" içindeki komut "while" içindeki koşul geçersiz olsa bile en az 1 kez çalışarak ekrana Ben bir Patika'lıyım yazdıracaktır
//bu nedenle örnek input -5 girildiğinde geçersiz değer girilmesine rağmen do komutu 1 kez çalışır.


Console.Write("Lütfen bir limit değeri giriniz.");
int sayac = 0;
int limit = int.Parse(Console.ReadLine());

while (sayac<=limit)
{
    Console.WriteLine("Ben bir Patika'lıyım.");
    sayac++;
}

//while döngüsünde koşul başlangıçta kontrol edilir ve sağlanmadıysa döngü hiç çalışmaz.
//bu nedenle geçersiz input olan -5 girildiğinde döngü hiç çalışmaz.
