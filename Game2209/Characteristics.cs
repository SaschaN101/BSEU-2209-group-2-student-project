using System;

public class Characteristics
{
    private Helmet helmet;
    private Chest chest;
    private Wrist wrist;
    private Legs legs;
    private Weapon weapon;

    public Characteristics()
    {
        helmet = new Helmet();
        chest = new Chest();
        wrist = new Wrist();
        legs = new Legs();
        weapon = new Weapon();
    }

    /*public void defaultCharacteristics(){
        helmet.setLevel(1);
        chest.setLevel(1);
        wrist.setLevel(1);
        legs.setLevel(1);
        weapon.setLevel(1);
    }*/

    public Helmet getHelmet()
    {
        return helmet;
    }

    public Chest getChest()
    {
        return chest;
    }

    public Wrist getWrist()
    {
        return wrist;
    }

    public Legs getLegs()
    {
        return legs;
    }

    public Weapon getWeapon()
    {
        return weapon;
    }

    public override string ToString()
    {
        return base.ToString() + ": \nHelmet: " + helmet.getDefence()
            + "\nChest defence: " + chest.getDefence()
            + "\nWrist defence: " + wrist.getDefence() 
            + "\nLegs defence: " + legs.getDefence()
            + "\nWeapon damage: " + weapon.getDamage();
    }

    public class Helmet {

        private int level;
        private int defence;
        public int getLevel()
        {
            return level;
        }
        public void setLevel(int level)
        {
            this.level = level;
            setDefence();
        }
        public int getDefence()
        {
            return defence;
        }

        public void setDefence()
        {
            if (level == 1)
                defence = 10;
            if (level == 2)
                defence = 15;
            if (level == 3)
                defence = 20;
        }

        public Helmet()
        {
            setLevel(1);
        }
    }

    public class Chest {

        private int level;
        private int defence;
        public int getLevel()
        {
            return this.level;
        }
        public void setLevel(int level)
        {
            this.level = level;
            setDefence();
        }
        public int getDefence()
        {
            return defence;
        }
        public void setDefence()
        {
            if (level == 1)
                defence = 10;
            if (level == 2)
                defence = 15;
            if (level == 3)
                defence = 20;
        }

        public Chest()
        {
            setLevel(1);
        }
    }

    public class Wrist {

        private int level;
        private int defence;
        public int getLevel()
        {
            return level;
        }
        public void setLevel(int level)
        {
            this.level = level;
            setDefence();
        }
        public int getDefence()
        {
            return defence;
        }
        public void setDefence()
        {
            if (level == 1)
                defence = 5;
            if (level == 2)
                defence = 10;
            if (level == 3)
                defence = 15;
        }
        public Wrist()
        {
            setLevel(1);
        }
    }

    public class Legs {

        private int level;
        private int defence;
        public int getLevel()
        {
            return this.level;
        }
        public void setLevel(int level)
        {
            this.level = level;
            setDefence();
        }
        public int getDefence()
        {
            return defence;
        }
        public void setDefence()
        {
            if (level == 1)
                defence = 5;
            if (level == 2)
                defence = 10;
            if (level == 3)
                defence = 15;
        }
        public Legs()
        {
            setLevel(1);
        }
    }

    public class Weapon
    {

        private int level;
        private int damage;
        public int getLevel()
        {
            return level;
        }
        public void setLevel(int level)
        {
            this.level = level;
            setDamage();
        }
        public int getDamage()
        {
            return damage;
        }
        public void setDamage()
        {
            if (level == 1)
                damage = 15;
            if (level == 2)
                damage = 20;
            if (level == 3)
                damage = 25;
        }
        public Weapon()
        {
            setLevel(1);
        }
    }
}