using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPGHelper.Models
{
    public interface ISqlRpgRepository
    {
        CharacterSheet Add(CharacterSheet characterSheet);

        CharacterSheet Remove(int id);

        CharacterSheet Get(int id);

        IEnumerable<CharacterSheet> GetAllSheets(string id);
        IEnumerable<MusicTrack> GetAllMusic(string id);

        CharacterSheet Edit(CharacterSheet characterSheet);
       
        MusicTrack Add(MusicTrack musicTrack);

        MusicTrack RemoveMusic(int id);

        MusicTrack GetMusic(int id);

        IEnumerable<MusicTrack> GetByCategory(string category, string id);
    }
}
