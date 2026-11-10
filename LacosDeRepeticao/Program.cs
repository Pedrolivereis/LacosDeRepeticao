int contador = 0;
while (contador > 0)
{
    Console.WriteLine(contador);
    contador--;
    Thread.Sleep(1000);
}
Console.WriteLine("Happy new Year!");
contador = 10;
do
{
    Console.WriteLine(contador);
    contador--;
} while (contador > 0);
Thread.Sleep(1000);

for (contador = 10; contador > 0; contador--)
{
    Console.WriteLine(contador);
    Thread.Sleep(1000);
}
