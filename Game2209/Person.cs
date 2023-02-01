using System;

public class Person
{
	private String name;
	private int healthPoints = 100;
	private Characteristics characteristics = new Characteristics();

	public Person(String name)
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

	public int getDefenceLevelFor(String defenceElement)
	{
		switch (defenceElement)
		{
			case "helmet":
				return characteristics.getHelmet().getDefence();
			case "chest":
				return characteristics.getChest().getDefence();
			case "wrist":
				return characteristics.getWrist().getDefence();
			case "legs":
				return characteristics.getLegs().getDefence();
			default:
				return 0;
		}
	}

	public override string ToString()
	{
		return base.ToString() + " " + name;
		//+ " " + healthPoints;
		//+ "\n" + characteristics.ToString();
	}
}
