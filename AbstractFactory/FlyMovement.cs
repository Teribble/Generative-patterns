namespace AbstractFactory
{
    public class FlyMovement : Movement
    {
        public override void Move()
        {
            Console.WriteLine("Персонаж летает в воздухе");
        }
    }
}
