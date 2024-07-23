for (int s=1; s<11; s++)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
}

for (int s= 1; s<11; s++)
{
    Console.WriteLine(s);
}

for (int b = 1; b < 21;b++)                    //1 ile 20 arasi cift sayilar ve for ile ic ice if kullanimi.
{
    if (b % 2 == 0)
    {
        Console.WriteLine(b);
    }

}
int i, toplam = 0;
for (i = 50; i < 151; i++)
{
    toplam = toplam + i;
}
Console.WriteLine("1 ile 150 arasindaki sayilarin toplami {0}'a esittir.",toplam);                      
int tekTotal = 0;                            //Son iki kisimda, for disinda tanimlanmis integerler ile, loopun sonuclarina uygulanan
int ciftTotal = 0;                           // islemlerin sonuclarinin, loop disi yazdirimi
int z;
for(z=1;z<121;z++)
{
    if (z % 2 == 0)
    {
        ciftTotal = ciftTotal + z;
    }
    else
        tekTotal = tekTotal + z;

}
Console.WriteLine("1 ile 120 arasindaki cift sayilarin toplami {0}'a esittir.",ciftTotal);
Console.WriteLine("1 ile 120 arasindaki tek sayilari sayilarin toplami {0}'a esittir.",tekTotal);


