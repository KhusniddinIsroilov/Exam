using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.domain
{
    public class Music : BaseEntity
    {

        public string Title { get; set; }

        public string Description { get; set; }

        public virtual Playlist Playlist { get; set; }

        public virtual Singer Singer { get; set; }

        public Music()
        {
            Playlist = new Playlist();
            Singer = new Singer();
        }


    }
}
