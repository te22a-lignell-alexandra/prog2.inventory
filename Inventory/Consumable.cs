public class Consumable : Item
{
    public int UsesMax;
    public int UsesCurrent;
    public void Use(Character character)
    {
        UsesCurrent++;
        character.Hp += 10;
    }
}
