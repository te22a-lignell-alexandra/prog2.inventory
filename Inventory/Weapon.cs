public class Weapon : Item
{
    public int MinDamage = 1;
    public int MaxDamage = 5;
    public int Attack()
    {
        int damage = Random.Shared.Next(MinDamage, MaxDamage);
        return damage;
    }
}
