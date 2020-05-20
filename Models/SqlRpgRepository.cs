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

        public CharacterSheet Edit(CharacterSheet characterSheetChanges)
        {
            var characterSheet = Context.CharacterSheets.Attach(characterSheetChanges);
            characterSheet.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Context.SaveChanges();
            return characterSheetChanges;
        }

        public CharacterSheet Get(int id)
        {
            CharacterSheet characterSheet = Context.CharacterSheets.Find(id);
            return characterSheet;
        }

        public IEnumerable<CharacterSheet> GetAllSheets(string id)
        {
            return Context.CharacterSheets.Where(e => e.ApplicationUserId.Equals(id));
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
    }
}
