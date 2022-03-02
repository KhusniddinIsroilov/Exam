using Exam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Serivce.Interfaces
{
    public interface ISingerService
    {
        Task<Singer> AddMusic(int singerId, int musicId);
    }
}
