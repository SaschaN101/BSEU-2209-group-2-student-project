using System;

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

    public int getDamageLevel()
    {
        return characteristics.getWeapon().getDamage();
    }

    public int getDefenceLevelFor(string defenceElement)
    {
        switch (defenceElement)
        {
            case "h": //Head
                return characteristics.getHead().getDefence();
            case "t": //Torso
                return characteristics.getTorso().getDefence();
            case "a": //Arms
                return characteristics.getArms().getDefence();
            case "l": //Legs
                return characteristics.getLegs().getDefence();
            default:
                return 0;
        }
    }
    public void setDefenceLevelFor(string defenceElement, int level)
    {
        switch (defenceElement)
        {
            case "h": //Head
                characteristics.getHead().setLevel(level); break;
            case "t": //Torso
                characteristics.getTorso().setLevel(level); break;
            case "a": //Arms
                characteristics.getArms().setLevel(level); break;
            case "l": //Legs
                characteristics.getLegs().setLevel(level); break;
            case "w": //Weapon
                characteristics.getWeapon().setLevel(level); break;
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
