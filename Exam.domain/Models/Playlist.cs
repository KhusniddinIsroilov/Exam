using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.domain
{
    public class Playlist : BaseEntity
    {
        public string Name { get; set; }

        public virtual ICollection<Music> Musics { get; }
        
        public virtual ICollection<Singer> Singers { get; }

        public Playlist()
        {
            Singers = new List<Singer>();

            Musics = new List<Music>();
        }
    }
}
