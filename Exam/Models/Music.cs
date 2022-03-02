using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Models
{
    public class Music 
    {
        public int Id { get; set; }

        public DateTime CreateDate { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public virtual Playlist Playlist { get;  }

        public virtual Singer Singer { get;  }

        public Music()
        {
            Playlist = new Playlist();
            Singer = new Singer();
        }


    }
}
