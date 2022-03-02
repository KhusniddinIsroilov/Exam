using Exam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Serivce.Interfaces
{
    public interface IPlaylistService
    {
        Task<Playlist> AddMusicAsync(int playlistId, int musicId);
    }
}
