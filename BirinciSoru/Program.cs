/*
Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın. 
*/

Console.WriteLine("Kaç adet sayının kontrol edilmesini istiyorsunuz?");
int n = Convert.ToInt32(Console.ReadLine());
int[] dizi = new int[n];


Console.WriteLine($"Kontrol edilmesi istediğiniz {n} adet sayıyı giriniz...");

for (int i = 0; i < n; i++)
{
    dizi[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Çift sayılar : ");
foreach (int j in dizi)
{
    if (j % 2 == 0)
    {
        Console.WriteLine(j);
    }
}