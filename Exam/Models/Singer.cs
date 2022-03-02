using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Models
{
    public class Singer
    {
        public int Id { get; set; }

        public DateTime CreateDate { get; set; }

        public string FullName { get; set; }
        
        public virtual ICollection<Music> Musics { get; set; }

        public Singer()
        { 
            Musics = new List<Music>();
        }
    }
}
