/*
Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. 
Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
 */

Console.WriteLine("Bir cümle yazınız...");
string cumle = Console.ReadLine();
int sayac = 0;
int harf = 0;

string[] kelime = cumle.Split(" ");

Console.WriteLine("kelime sayısı = " + kelime.Length);

for (int i = 0; i < cumle.Length; i++)
{
    sayac++;
}
harf = (sayac+1) - kelime.Length;

Console.WriteLine("Harf sayısı = " + harf);