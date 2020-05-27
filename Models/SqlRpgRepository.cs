using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPGHelper.Models
{
    public class SqlRpgRepository : ISqlRpgRepository
    {
        private readonly AppDbContext Context;

        public SqlRpgRepository(AppDbContext context)
        {
            this.Context = context;
        }

        public CharacterSheet Add(CharacterSheet characterSheet)
        {
            Context.CharacterSheets.Add(characterSheet);
            Context.SaveChanges();
            return characterSheet;
        }

        public MusicTrack Add(MusicTrack musicTrack)
        {
            Context.MusicTracks.Add(musicTrack);
            Context.SaveChanges();
            return musicTrack;
        }

        public CharacterSheet Edit(CharacterSheet characterSheetChanges)
        {
            var characterSheet = Context.CharacterSheets.Attach(characterSheetChanges);
            characterSheet.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Context.SaveChanges();
            return characterSheetChanges;
        }

        public CharacterSheet Get(int id)
        {
            return Context.CharacterSheets.Find(id);
        }

        public IEnumerable<CharacterSheet> GetAllSheets(string id)
        {
            return Context.CharacterSheets.Where(e => e.ApplicationUserId.Equals(id));
        }

        public IEnumerable<MusicTrack> GetByCategory(string category, string id)
        {
            return Context.MusicTracks.Where(e => e.ApplicationUserId.Equals(id)).Where(e => e.Category.Equals(category) || (e.Category2.Equals(category) || e.Category3.Equals(category)));
        }

        public MusicTrack GetMusic(int id)
        {
            return Context.MusicTracks.Find(id);
        }

        public CharacterSheet Remove(int id)
        {
            CharacterSheet characterSheet = Context.CharacterSheets.Find(id);
            if(characterSheet != null)
            {
                Context.CharacterSheets.Remove(characterSheet);
                Context.SaveChanges();
            }
            return characterSheet;
        }

        public MusicTrack RemoveMusic(int id)
        {
            MusicTrack musicTrack = Context.MusicTracks.Find(id);
            if(musicTrack != null)
            {
                Context.MusicTracks.Remove(musicTrack);
                Context.SaveChanges();
            }
            return musicTrack;
        }
    }
}
