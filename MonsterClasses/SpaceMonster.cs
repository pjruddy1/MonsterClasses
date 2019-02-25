using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterClasses
{
    public class SpaceMonster : Monster , IBattle, ITrade, IChat
    {
        private bool _hasSpaceship;

        public bool HasSpaceship
        {
            get { return _hasSpaceship; }
            set { _hasSpaceship = value; }
        }

        #region Abstract & Virtual Methods

        public override bool IsActive()
        {
            if (HitPoints > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool WillAttack()
        {
            Random randomNumber = new Random();
            int actionProbability = randomNumber.Next(0, 101);

            if (HitPoints >= 50 && ArmourCarried != Armour.NONE && WeaponsCarried != Weapons.NONE)
            {
                return true;
            }
            else if (ArmourCarried != Armour.NONE && WeaponsCarried != Weapons.NONE)
            {
                if (actionProbability >= 25)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else if (ArmourCarried != Armour.NONE || WeaponsCarried != Weapons.NONE)
            {
                if (actionProbability >= 50)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (HitPoints >= 50 && (ArmourCarried == Armour.NONE || WeaponsCarried == Weapons.NONE))
            {
                if (actionProbability >= 75)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public override string Greeting()
        {
            return $"Hello, I am a Space Monster and my name is {Name}.\n I currently have {Gold} Gold and {HitPoints} Hitpoints" +
                $"\nMy Armour is {ArmourCarried} and im wielding {WeaponsCarried}.";
        }

        #endregion

        #region Interfaces
        public Armour MonsterTradeArmourResponse(TradeStore tradeStore)
        {
            if (Gold >= tradeStore.ArmourSlotPrice1)
            {
                Gold = Gold - tradeStore.ArmourSlotPrice1;
                return Armour.WETSUIT;

            }
            else if (Gold >= tradeStore.ArmourSlotPrice2)
            {
                Gold = Gold - tradeStore.ArmourSlotPrice2;
                return Armour.HELMET;
            }
            else if (Gold >= tradeStore.ArmourSlotPrice3)
            {
                Gold = Gold - tradeStore.ArmourSlotPrice3;
                return Armour.CHESTPLATE;
            }
            else
            {
                return Armour.NONE;
            }
        }

        public Weapons MonsterTradeWeaponResponse(TradeStore tradeStore)
        {

            if (Gold >= tradeStore.WeaponSlotPrice1)
            {
                Gold = Gold - tradeStore.WeaponSlotPrice1;
                return Weapons.WATERCANON;

            }
            else if (Gold >= tradeStore.WeaponSlotPrice2)
            {
                Gold = Gold - tradeStore.WeaponSlotPrice2;
                return Weapons.BEAMRAY;
            }
            else if (Gold > tradeStore.WeaponSlotPrice3)
            {
                Gold = Gold - tradeStore.WeaponSlotPrice3;
                return Weapons.CATAPULT;
            }
            else
            {
                return Weapons.NONE;
            }
        }

        public MonsterAction MonsterBattleResponse()
        {
            Random randomNumber = new Random();
            int actionProbability = randomNumber.Next(0, 101);

            if (WillAttack())
            {
                return MonsterAction.ATTACK;
            }
            else if (actionProbability >= 67)
            {
                return MonsterAction.RETREAT;
            }
            else
            {
                return MonsterAction.DEFEND;
            }

        }

        public MonsterCommunications MonsterInteractionResponse()
        {
            if (WeaponsCarried != Weapons.NONE || ArmourCarried != Armour.NONE)
            {
                Communications = MonsterCommunications.THREATEN;
                return MonsterCommunications.THREATEN;
            }
            else if (WeaponsCarried == Weapons.NONE || ArmourCarried == Armour.NONE)
            {
                return MonsterCommunications.TRADE;
            }
            else if (HitPoints > 75 || Gold > 100)
            {
                return MonsterCommunications.HAPPY;
            }
            else if (HitPoints < 75 || Gold < 100)
            {
                return MonsterCommunications.BEG;
            }
            else
            {
                return MonsterCommunications.ANGRY;
            }
        }
        #endregion

        public SpaceMonster(string name) : base(name)
        {

        }
    }
}
