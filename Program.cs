Console.WriteLine("Írd le a termék termék nevét, árát, darabszámát");
string Termék1 = Console.ReadLine();
int Ár1 = int.Parse(Console.ReadLine());
int Vásároltmennyiseg1=int.Parse(Console.ReadLine());
Console.WriteLine("Add meg a másik termék nevét, árát, darabszámát");
string Termék2 = Console.ReadLine();
int Ár2 = int.Parse(Console.ReadLine());
int Vásároltmennyiseg2 = int.Parse(Console.ReadLine());
int alapossz = (Ár1 * Vásároltmennyiseg1) + (Ár2 * Vásároltmennyiseg2);
bool kedvezmeny = false;
int kedvezettar = 0;
if (alapossz>=10000)
{
    kedvezettar=alapossz*0,9;
}

