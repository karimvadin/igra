using ConsoleApp5;
internal class Program
{
    private static void Main(string[] args)
    {


        Cat barsik = new Cat();
        barsik.name = "Барсик";
        barsik.age = 7;

        Dog sharik = new Dog();
        sharik.age = 6;
        sharik.name = "Шарик";

        barsik.getHealth(100);
        sharik.getHealth(100);

        Console.WriteLine("Забив начинается:");
        barsik.talk();
        sharik.talk();
        Console.WriteLine();

        while (sharik.health > 0 && barsik.health > 0) {
            if (barsik.hit() > 0) {
                Console.WriteLine("Барсик бьет шарика и наносит " + barsik.hit() + " урона, у шарика остается " + sharik.health + " hp");
                sharik.getDamage(barsik.hit());
            }
            if (sharik.hit() > 0)
            {
                Console.WriteLine("Шарик бьет барсика и наносит " + sharik.hit() + " урона, у барсика остается " + barsik.health + " hp");
                barsik.getDamage(barsik.hit());
            }
        }
        if (barsik.health <= 0 && sharik.health <= 0 )
        {
            Console.WriteLine();
            Console.WriteLine("Ничья короче");

        }
        else if (barsik.health <= 0)
        {
            Console.WriteLine();
            Console.WriteLine("Барсик погибает в бою, шарик победил");
        }
        else if (sharik.health <= 0) {
            Console.WriteLine();
            Console.WriteLine("Шарик погибает в бою, барсик победил");
        }

        barsik.getInfo();
        sharik.getInfo();

    }
    
        

        
}