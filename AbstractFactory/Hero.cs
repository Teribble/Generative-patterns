namespace AbstractFactory
{
    public class Hero
    {
        private Movement _move;

        private Weapon _weapon;

        public Hero(HeroFactory factory)
        {
            _move = factory.CreateMovement();
            _weapon = factory.CreateWeapon();
        }

        public void Hit()
        {
            _weapon.Hit();
        }

        public void Move()
        {
            _move.Move();
        }
    }
}
