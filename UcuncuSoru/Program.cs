/*
 Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
Sonrasında kullanıcıdan n adet kelime girmesi isteyin.
Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
 */

Console.WriteLine("Kaç adet kelime yazacağınızı sayı ile yazınız...");
int n = Convert.ToInt32(Console.ReadLine());

string[] kelimeler = new string[n];

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"{n} adet kelimeden {i + 1}. kelimeyi yazınız..");
    kelimeler[i] = Console.ReadLine();
}

for (int j = (kelimeler.Length - 1); j >= 0; j--)
{
    Console.WriteLine("Dizinin" + (j + 1) + ". elemanı : " + kelimeler[j]);
}
