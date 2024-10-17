public class Weapon : Item
{
    public int MinDamage;
    public int MaxDamage;
    public int Attack()
    {
        int damage = Random.Shared.Next(MinDamage, MaxDamage);
        return damage;
    }
}
