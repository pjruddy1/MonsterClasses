using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterClasses
{
    public interface ITrade
    {
        Monster.Armour MonsterTradeArmourResponse(TradeStore tradeStore);
        Monster.Weapons MonsterTradeWeaponResponse(TradeStore tradeStore);
    }
}
