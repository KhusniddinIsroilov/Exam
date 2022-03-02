
using Exam.Data;
using Exam.Data.IRepositories;
using Exam.Data.Repositories;
using Exam.Models;
using Exam.Serivce.Interfaces;
using Exam.Serivce.Services;
using System;
using System.Threading.Tasks;

namespace Exam
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            MusicDbContext ms = new MusicDbContext();

            IMusicRepository musicRepo = new MusicRepository();
            ISingerRepository singerRepo = new SingerRepository();
            IPlaylistRepository playlistRepo = new PlaylistRepository();

            ISingerService singerSer = new SingerSerivce();


            await singerSer.AddMusic(6, 3);


            //var singer = await singerRepo.CreateAsync(new Singer
            //{
            //    FullName = "Abuduhakim Hamidjonov",
            //    CreateDate = DateTime.Now,



            //});






            var music = await musicRepo.CreateAsync(new Music()
            {
                Title = "Tugadi",
                Description = "Eng zo'r open source product",

            });

            //var playlist = await playlistRepo.CreateAsync(new Playlist
            //{
            //    Name = "Yorvordi Muzikalar",
            //    CreateDate = DateTime.Now

            //});





        }
    }
}
