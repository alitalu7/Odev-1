/*
 Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
 */

Console.WriteLine("İki adet doğal sayı giriniz...");
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());

int[] sayilar = new int[n];
for (int i = 0; i < n; i++)
{
    Console.WriteLine($"{n} adet sayıdan {i + 1}. sayıyı giriniz...");
    sayilar[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Sonuç olarak dönen sayılar : ");
foreach (int say in sayilar)
{
    if (say % m == 0)
    {
        Console.WriteLine(say);
    }
    else if (say == m)
    {
        Console.WriteLine(say);
    }
}

