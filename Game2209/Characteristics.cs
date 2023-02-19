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

    /*public void DefaultCharacteristics(){
        head.SetLevel(1);
        torso.SetLevel(1);
        arms.SetLevel(1);
        legs.SetLevel(1);
        weapon.SetLevel(1);
    }*/

    public Head GetHead()
    {
        return head;
    }

    public Torso GetTorso()
    {
        return torso;
    }

    public Arms GetArms()
    {
        return arms;
    }

    public Legs GetLegs()
    {
        return legs;
    }

    public Weapon GetWeapon()
    {
        return weapon;
    }

    public override string ToString()
    {
        return base.ToString() + ": \nhead: " + head.GetDefence()
            + "\nTorso defence: " + torso.GetDefence()
            + "\nArms defence: " + arms.GetDefence()
            + "\nLegs defence: " + legs.GetDefence()
            + "\nWeapon damage: " + weapon.GetDamage();
    }

    public class Head
    {

        private int level;
        private int defence;
        public int GetLevel()
        {
            return level;
        }
        public void SetLevel(int level)
        {
            this.level = level;
            SetDefence();
        }
        public int GetDefence()
        {
            return defence;
        }

        public void SetDefence()
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
            SetLevel(1);
        }
    }

    public class Torso
    {

        private int level;
        private int defence;
        public int GetLevel()
        {
            return level;
        }
        public void SetLevel(int level)
        {
            this.level = level;
            SetDefence();
        }
        public int GetDefence()
        {
            return defence;
        }
        public void SetDefence()
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
            SetLevel(1);
        }
    }

    public class Arms
    {

        private int level;
        private int defence;
        public int GetLevel()
        {
            return level;
        }
        public void SetLevel(int level)
        {
            this.level = level;
            SetDefence();
        }
        public int GetDefence()
        {
            return defence;
        }
        public void SetDefence()
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
            SetLevel(1);
        }
    }

    public class Legs
    {

        private int level;
        private int defence;
        public int GetLevel()
        {
            return level;
        }
        public void SetLevel(int level)
        {
            this.level = level;
            SetDefence();
        }
        public int GetDefence()
        {
            return defence;
        }
        public void SetDefence()
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
            SetLevel(1);
        }
    }

    public class Weapon
    {

        private int level;
        private int damage;
        public int GetLevel()
        {
            return level;
        }
        public void SetLevel(int level)
        {
            this.level = level;
            setDamage();
        }
        public int GetDamage()
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
            SetLevel(1);
        }
    }
}