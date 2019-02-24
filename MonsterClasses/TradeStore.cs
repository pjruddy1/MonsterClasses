using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterClasses
{
    public class TradeStore : Monster, TradeStoreTrade
    {
        #region Fields
        private Armour _armourInventorySlot1;
        private Armour _armourInventorySlot2;
        private Armour _armourInventorySlot3;
        private Weapons _weaponInventorySlot1;
        private Weapons _weaponInventorySlot2;
        private Weapons _weaponInventorySlot3;
        private int _weaponSlotPrice1;
        private int _weaponSlotPrice2;
        private int _weaponSlotPrice3;
        private int _armourSlotPrice1;
        private int _armourSlotPrice2;
        private int _armourSlotPrice3;

        #endregion

        #region Properties
        public Armour  ArmourInventorySlot1
        {
            get { return _armourInventorySlot1; }
            set { _armourInventorySlot1 = value; }
        }

        public Armour ArmourInventorySlot2
        {
            get { return _armourInventorySlot2; }
            set { _armourInventorySlot2 = value; }
        }

        public Armour ArmourInventorySlot3
        {
            get { return _armourInventorySlot3; }
            set { _armourInventorySlot3 = value; }
        }

        public Weapons WeaponInventorySlot1
        {
            get { return _weaponInventorySlot1; }
            set { _weaponInventorySlot1 = value; }
        }

        public Weapons WeaponInventorySlot2
        {
            get { return _weaponInventorySlot2; }
            set { _weaponInventorySlot2 = value; }
        }

        public Weapons WeaponInventorySlot3
        {
            get { return _weaponInventorySlot3; }
            set { _weaponInventorySlot3 = value; }
        }

        public int WeaponSlotPrice1
        {
            get { return _weaponSlotPrice1; }
            set { _weaponSlotPrice1 = value; }
        }

        public int WeaponSlotPrice2
        {
            get { return _weaponSlotPrice2; }
            set { _weaponSlotPrice2 = value; }
        }

        public int WeaponSlotPrice3
        {
            get { return _weaponSlotPrice3; }
            set { _weaponSlotPrice3 = value; }
        }

        public int ArmourSlotPrice1
        {
            get { return _armourSlotPrice1; }
            set { _armourSlotPrice1 = value; }
        }

        public int ArmourSlotPrice2
        {
            get { return _armourSlotPrice2; }
            set { _armourSlotPrice2 = value; }
        }

        public int ArmourSlotPrice3
        {
            get { return _armourSlotPrice3; }
            set { _armourSlotPrice3 = value; }
        }

        #endregion

        #region Interface Regions
        
        #endregion

        public override bool IsActive()
        {
            return true;
        }

        public override bool WillAttack()
        {
            return false;
        }

        public MonsterCommunications MonsterTradeInteractionResponse(SpaceMonster spaceMonster, SeaMonster seaMonster)
        {
            if (seaMonster.Gold <= WeaponSlotPrice3 && spaceMonster.Gold <= WeaponSlotPrice3 && seaMonster.Gold >= ArmourSlotPrice3 && spaceMonster.Gold >= ArmourSlotPrice3)
            {
                return MonsterCommunications.THREATEN;
            }
            else if (seaMonster.Gold >= WeaponSlotPrice1 || spaceMonster.Gold >= WeaponSlotPrice1 || seaMonster.Gold >= ArmourSlotPrice1 || spaceMonster.Gold >= ArmourSlotPrice1)
            {
                return MonsterCommunications.TRADE;
            }
            else if (seaMonster.Gold >= WeaponSlotPrice2 || seaMonster.Gold >= ArmourSlotPrice2 || spaceMonster.Gold >= ArmourSlotPrice2)
            {
                return MonsterCommunications.HAPPY;
            }
            else if (seaMonster.Gold >= WeaponSlotPrice3 || spaceMonster.Gold >= WeaponSlotPrice3 || seaMonster.Gold >= ArmourSlotPrice3|| spaceMonster.Gold >= ArmourSlotPrice3)
            {
                return MonsterCommunications.BEG;
            }
            else
            {
                return MonsterCommunications.ANGRY;
            }
        }
    }
}
