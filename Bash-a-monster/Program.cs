Winston Winston = new();
Supports Supports = new();

while (Supports.Health!=0 && Winston.Health!=0)
{
    Console.WriteLine("Winston's Health: " + Winston.Health + 
                     "\nSupports's Health: " + Supports.Health);

    Winston.Health-=Supports.Damage;
    Supports.Health-=Winston.Damage;

    Console.ReadLine();
    
}


