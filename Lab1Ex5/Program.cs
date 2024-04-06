//Ex 5
//Se citesc doua numere de la tastatura, x, y. Scrieti un program care va afisa cele
//doua valori in ordine crescatoare.
//• Exemplu: citim 9,0 Afisam : 0 9 

Console.WriteLine("Scrieti primul numar");
int n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Scriteti al doilea numar");
int n2 = int.Parse(Console.ReadLine());


if  (n1 > n2)
{
    Console.WriteLine("Ordinea numerelor este");
    Console.WriteLine(n2 + " " + n1);
}
else if (n1 < n2)
{
    Console.WriteLine("Ordinea numerelor este");
    Console.WriteLine(n1 + " " + n2);
}
else
{
    Console.WriteLine("Numerele sunt egale");
}