using Exam.Data;
using Exam.Data.IRepositories;
using Exam.Data.Repositories;
using Exam.Models;
using Exam.Serivce.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Serivce.Services
{
    public class SingerSerivce :ISingerService
    {
        private readonly MusicDbContext _mdb;


        public SingerSerivce()
        {
             _mdb = new MusicDbContext();
        }



        public async Task<Singer> AddMusic(int singerId, int musicId)
        {
            var singer =  _mdb.Singers.Find(singerId);
            var music = _mdb.Musics.Find(musicId);

              singer.Musics.Add(music);
           await   _mdb.SaveChangesAsync();

            return singer;

        }
    }
}
