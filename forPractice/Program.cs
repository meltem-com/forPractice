for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
}

Console.WriteLine("------------------------------------------");



for (int i= 1; i<= 20; i++)
{
    Console.WriteLine($"i değeri {i}");
}

Console.WriteLine("--------------------------------");


for (int i= 1; i<= 20; i++)
{
    if (i % 2==0)
    {
        Console.WriteLine(i);
    }
}

Console.WriteLine("---------------------------");


int toplam = 0;

for (int i = 50; i <= 150; i++)
{
    toplam += i; // toplam = toplam + i
}

Console.WriteLine($"50 ile 150 arasındaki sayıların toplamı: {toplam}");

Console.WriteLine("-------------------------------");


int tekToplam = 0;
int ciftToplam = 0;

for (int i = 1; i <= 120; i++)
{
    if (i % 2 == 0)
    {
        ciftToplam += i; // Çift sayıların toplamı
    }
    else
    {
        tekToplam += i; // Tek sayıların toplamı
    }
}

Console.WriteLine($"Tek sayıların toplamı: {tekToplam}");
Console.WriteLine($"Çift sayıların toplamı: {ciftToplam}");