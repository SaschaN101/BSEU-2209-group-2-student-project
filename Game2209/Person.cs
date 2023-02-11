using System;

public class Person
{
    private string name;
    private int healthPoints = 100;

    public int HealthPoints
    {
        get { return healthPoints; }
        set { healthPoints = value; }
    }
    private Characteristics characteristics = new Characteristics();

    public Person(string name)
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
    /* public int setDefenceLevelFor(string defenceElement, int level)
    {
        switch (defenceElement)
        {
            case "h": //Head
                return characteristics.getHead().setLevel(level);
            case "t": //Torso
                return characteristics.getTorso().setLevel(level);
            case "a": //Arms
                return characteristics.getArms().setLevel(level);
            case "l": //Legs
                return characteristics.getLegs().setLevel(level);
            default:
                return 0;
        }
    } */

    public override string ToString()
    {
        return base.ToString() + " " + name;
        //+ " " + healthPoints;
        //+ "\n" + characteristics.ToString();
    }
}
