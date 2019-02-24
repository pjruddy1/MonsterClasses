using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterClasses
{
    public abstract class Monster
    {
        public enum MonsterAction {
            NONE, ATTACK, DEFEND, RETREAT
        }
        public enum Armour {
            NONE, HELMET, CHESTPLATE, WETSUIT
        }
        public enum Weapons {
            NONE, BEAMRAY, CATAPULT, WATERCANON
        }
        public enum MonsterCommunications
        {
            NONE, HAPPY, SAD, BEG, ANGRY, TRADE, THREATEN, STUNNED
        }
        public enum Species
        {
            UNKNOWN, ALIEN, MERMAID,
        }

        #region Fields
        private int _id;
        private string _name;
        private int _age;
        private int _gold;
        private Armour _armour;
        private Weapons _weaponsCarried;
        private int _hitPoints;
        private Species _isSpecies;

        #endregion

        #region Properties
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }        

        public int Gold
        {
            get { return _gold; }
            set { _gold = value; }
        }

        public Armour ArmourCarried
        {
            get { return _armour; }
            set { _armour = value; }
        }

        public Weapons WeaponsCarried
        {
            get { return _weaponsCarried; }
            set { _weaponsCarried = value; }
        }

        public int HitPoints
        {
            get { return _hitPoints; }
            set { _hitPoints = value; }
        }

        public Species IsSpecies
        {
            get { return _isSpecies; }
            set { _isSpecies = value; }
        }

        private MonsterCommunications _communications;

        public MonsterCommunications Communications
        {
            get { return _communications; }
            set { _communications = value; }
        }

        #endregion

        #region Constructor
        public Monster()
        {

        }

        public Monster(int id, string name, int hitPoints)
        {
            _id = id;
            _name = name;
            _hitPoints = hitPoints;
        }

        public Monster(string name)
        {
            _name = name;
        }

        #endregion

        public Species DisplaySpecies(int id)
        {
            if (id <= 100)
            {
                return Species.MERMAID;
            }
            else if (id <=200)
            {
                return Species.ALIEN;
            }
            else
            {
                return Species.UNKNOWN;
            }
        }

        #region Abstract & Virtual Methods

        public virtual string Greeting()
        {
            return $"Hello, my name is {_name}.";
        }

        public abstract bool IsActive();

        public abstract bool WillAttack();

        #endregion
    }
}
