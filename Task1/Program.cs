string[] A = new string[10];
Console.WriteLine("Введите масcив строк через пробел: ");
A = Console.ReadLine().Split(" ");
string[] resultat = new string[A .Length];
int i = 0;
foreach (string elementfromA in A)
{
    if (elementfromA.Length <= 3)
    {
        resultat[i] = elementfromA;
        i++;
    }
}
Console.WriteLine(string.Join(Environment.NewLine, resultat, 0, i));