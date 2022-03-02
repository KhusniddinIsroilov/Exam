using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.domain
{
    public class Singer :BaseEntity
    {
        public string FullName { get; set; }
        
        public virtual ICollection<Music> Musics { get; }

        public virtual Playlist Playlist { get; set; }

        public Singer()
        {
            Playlist = new Playlist();
            Musics = new List<Music>();
        }
    }
}
