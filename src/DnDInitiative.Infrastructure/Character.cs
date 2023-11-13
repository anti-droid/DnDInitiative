namespace DnDInitiative.Infrastructure;
public class Character : IComparable<Character>
{
    public string name;
    public int initiative;
    public Character(string name, int initiative)
    {
        this.name = name;
        this.initiative = initiative;
    }

    public int CompareTo(Character? other)
    {
        return initiative == other.initiative ? 0 : 
        initiative > other.initiative ? -1: 1;
    }

    public override string ToString(){
        return $"{name}: {initiative}";
    }
}