using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterClasses
{
    public class SeaMonster : Monster, IChat, IBattle, ITrade
    {

        private bool _hasGills;
        private string _seaName;


        public string SeaName
        {
            get { return _seaName; }
            set { _seaName = value; }
        }

        public bool HasGills
        {
            get { return _hasGills; }
            set { _hasGills = value; }
        }

        #region Abstract & virtual Methods
        public override string Greeting()
        {
            return $"Hello, I am a Sea Monster and my name is {Name}.\n I currently have {Gold} Gold and {HitPoints} Hitpoints" +
                $"\nMy Armour is {ArmourCarried} and im wielding {WeaponsCarried}.";
        }

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
                if(actionProbability >= 75)
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
        #endregion


        #region Interfaces

       

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

        public Armour MonsterTradeArmourResponse(TradeStore tradeStore)
        {
            if (Gold > 75)
            {
                Gold = Gold - 75;
                return Armour.WETSUIT;

            }
            else if (Gold > 50)
            {
                Gold = Gold - 50;
                return Armour.HELMET;
            }
            else if (Gold > 25)
            {
                Gold = Gold - 25;
                return Armour.CHESTPLATE;
            }
            else
            {
                return Armour.NONE;
            }
        }

        public Weapons MonsterTradeWeaponResponse(TradeStore tradeStore)
        {

            if (Gold >= 75)
            {
                Gold = Gold - 75;
                return Weapons.WATERCANON;

            }
            else if (Gold >= 50)
            {
                Gold = Gold - 50;
                return Weapons.BEAMRAY;
            }
            else if (Gold > 25)
            {
                Gold = Gold - 25;
                return Weapons.CATAPULT;
            }
            else
            {
                return Weapons.NONE;
            }
        }

        #endregion

        
    }
}
