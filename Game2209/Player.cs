public class Player
{
    private string name;
    public string Name { get { return name; } }
    private int healthPoints = 100;

    public int HealthPoints
    {
        get { return healthPoints; }
        set { healthPoints = value; }
    }

    private Characteristics characteristics = new Characteristics();

    public Player(string name)
    {
        this.name = name;
    }

    public void reduceHealthPoints(int points)
    {
        healthPoints = healthPoints - points;
    }

    public int GetDamageLevel()
    {
        return characteristics.GetWeapon().GetDamage();
    }

    public int GetDefenceLevelFor(string defenceElement)
    {
        switch (defenceElement)
        {
            case "h": //Head
                return characteristics.GetHead().GetDefence();
            case "t": //Torso
                return characteristics.GetTorso().GetDefence();
            case "a": //Arms
                return characteristics.GetArms().GetDefence();
            case "l": //Legs
                return characteristics.GetLegs().GetDefence();
            default:
                return 0;
        }
    }
    public void SetDefenceLevelFor(string defenceElement, int level)
    {
        switch (defenceElement)
        {
            case "h": //Head
                characteristics.GetHead().SetLevel(level); break;
            case "t": //Torso
                characteristics.GetTorso().SetLevel(level); break;
            case "a": //Arms
                characteristics.GetArms().SetLevel(level); break;
            case "l": //Legs
                characteristics.GetLegs().SetLevel(level); break;
            case "w": //Weapon
                characteristics.GetWeapon().SetLevel(level); break;
            default: break;
        }
    }

    public override string ToString()
    {
        return base.ToString() + " " + name;
        //+ " " + healthPoints;
        //+ "\n" + characteristics.ToString();
    }
}
