using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerritorialHQ_Library.Entities
{
    public enum DiplomaticRelationType
    {
        None = 0,
        Ally = 1,
        Friendly = 2,
        Cautious = 3,
        Unfriendly = 4,
        Hostile = 5,
        War = 6
    }

    public enum HierachicalRelationType
    {
        None = 0,
        Protector = 1,
        Protectorate= 2,
        Federation = 3,
        Union = 4,
        Sovereign = 5,
        Subject = 6
    }

    public enum MilitaryRelationType
    {
        None = 0,
        Alliance = 1,
        War = 2,
        Ceasefire = 3,
        DefensivePact = 4,
        OffensivePact = 5,
    }
}
