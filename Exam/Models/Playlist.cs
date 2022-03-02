using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Models
{
    public class Playlist
    {
        public int Id { get; set; }

        public DateTime CreateDate { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Music> Musics { get; set; }
        
        public Playlist()
        {  
            Musics = new List<Music>();
        }
    }
}
