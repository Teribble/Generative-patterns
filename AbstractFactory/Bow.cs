namespace AbstractFactory
{
    public class Bow : Weapon
    {
        public override void Hit()
        {
            Console.WriteLine("Персонаж стреляет из лука");
        }
    }
}
