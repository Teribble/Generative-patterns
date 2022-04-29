namespace AbstractFactory
{
    public class Elf : HeroFactory
    {
        public override Movement CreateMovement()
        {
            return new FlyMovement();
        }

        public override Weapon CreateWeapon()
        {
            return new Bow();
        }
    }
}
