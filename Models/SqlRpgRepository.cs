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

        public CharacterSheet Edit(CharacterSheet characterSheet)
        {
            throw new NotImplementedException();
        }

        public CharacterSheet Get(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CharacterSheet> GetAllSheets()
        {
            throw new NotImplementedException();
        }

        public CharacterSheet Remove(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
