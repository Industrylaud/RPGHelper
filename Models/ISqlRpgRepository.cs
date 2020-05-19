using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPGHelper.Models
{
    interface ISqlRpgRepository
    {
        CharacterSheet Add(CharacterSheet characterSheet);

        CharacterSheet Remove(int Id);

        CharacterSheet Get(int Id);

        IEnumerable<CharacterSheet> GetAllSheets();

        CharacterSheet Edit(CharacterSheet characterSheet);
    }
}
