 public class Winston
{
   
    public String Name = "Winston";
    public Random generator = new Random();
    public int Health;
    public int Damage= 20;

    public Winston()
    {
        Health = generator.Next(10,100);
    }
}

public class Supports
{
    public String Name = "Supports";
    public int Health = 100;
    public int Damage = 10;
}




