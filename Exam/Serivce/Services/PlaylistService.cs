using Exam.Data;
using Exam.Models;
using Exam.Serivce.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Serivce.Services
{
    public class PlaylistService : IPlaylistService
    {
        private readonly MusicDbContext _mdb;


        public PlaylistService()
        {
            _mdb = new MusicDbContext();
        }

        public async Task<Playlist> AddMusicAsync(int playlistId, int musicId)
        {
            var playlist = _mdb.Playlists.Find(playlistId);
            var music = _mdb.Musics.Find(musicId);
            playlist.Musics.Add(music);

            await _mdb.SaveChangesAsync();

            return playlist;            
        }
    }
}
