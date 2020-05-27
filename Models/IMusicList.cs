using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPGHelper.Models
{
    public interface IMusicList
    {
        MusicList Add(MusicList musicList);

        MusicList Remove(int id);

        MusicList Get(int id);
    }
}
