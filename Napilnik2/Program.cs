namespace Napilnik2
{
    class Weapon
    {
        private int _damage;
        private int _bullets;

        public void Fire(Player player)
        {
            player.TakeDamage(_damage);
            RemoveBullet();
        }

        private void RemoveBullet()
        {
            int minBullets = 0;
            int oneBullet = 1;

            if (_bullets > minBullets)
                _bullets -= oneBullet;
        }
    }

    class Player
    {
        private int _health;

        public void TakeDamage(int damage)
        {
            int minHealth = 0;

            if (_health > minHealth)
                _health -= damage;
        }
    }

    class Bot
    {
        private Weapon _weapon;

        public void OnSeePlayer(Player player)
        {
            if (player != null)
                _weapon.Fire(player);
        }
    }
}