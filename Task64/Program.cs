Console.Write("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());
Sequence(1);
void Sequence(int i)
{
    if (i==n+1) return;
    Sequence(i+1);
    Console.Write(i+" ");
    
}
