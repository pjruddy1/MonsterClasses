using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterClasses
{
    interface TradeStoreTrade
    {
        Monster.MonsterCommunications MonsterTradeInteractionResponse(SpaceMonster spaceMonster, SeaMonster seaMonster);
    }
}
