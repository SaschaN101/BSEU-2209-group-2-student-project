public class Characteristics
{
    private Head head;
    private Torso torso;
    private Arms arms;
    private Legs legs;
    private Weapon weapon;

    public Characteristics()
    {
        head = new Head();
        torso = new Torso();
        arms = new Arms();
        legs = new Legs();
        weapon = new Weapon();
    }

    /*public void defaultCharacteristics(){
        head.setLevel(1);
        torso.setLevel(1);
        arms.setLevel(1);
        legs.setLevel(1);
        weapon.setLevel(1);
    }*/

    public Head getHead()
    {
        return head;
    }

    public Torso getTorso()
    {
        return torso;
    }

    public Arms getArms()
    {
        return arms;
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
        return base.ToString() + ": \nhead: " + head.getDefence()
            + "\nTorso defence: " + torso.getDefence()
            + "\nArms defence: " + arms.getDefence()
            + "\nLegs defence: " + legs.getDefence()
            + "\nWeapon damage: " + weapon.getDamage();
    }

    public class Head
    {

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

        public Head()
        {
            setLevel(1);
        }
    }

    public class Torso
    {

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

        public Torso()
        {
            setLevel(1);
        }
    }

    public class Arms
    {

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
        public Arms()
        {
            setLevel(1);
        }
    }

    public class Legs
    {

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