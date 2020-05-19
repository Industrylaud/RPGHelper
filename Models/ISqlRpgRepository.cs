using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPGHelper.Models
{
    interface ISqlRpgRepository
    {
        CharacterSheet Add(CharacterSheet characterSheet);

        CharacterSheet Remove(int id);

        CharacterSheet Get(int id);

        IEnumerable<CharacterSheet> GetAllSheets(string id);

        CharacterSheet Edit(CharacterSheet characterSheet);
    }
}
