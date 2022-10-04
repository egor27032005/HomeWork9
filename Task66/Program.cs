Console.Write("Введите первое число ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int n = Convert.ToInt32(Console.ReadLine());
Sequence(1);
int Sequence(int n)
{
    if (n==m) return m;
    else return n+Sequence(n-1);
    
    
}
Console.Write("сумма элементов от n до m: " +Sequence(n));