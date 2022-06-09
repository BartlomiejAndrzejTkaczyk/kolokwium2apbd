using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication5.DataAccess;
using WebApplication5.Models.DBModels;

namespace WebApplication5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicController : ControllerBase
    {
        private MyDbContext _context;
        public MusicController(MyDbContext context)
        {
            _context = context; 
        }

        [HttpGet("Album/{idAlbum}")]
        public IActionResult GetAlbum(int idAlbum)
        {
            var res = _context
                            .Tracks
                            .Include(t => t.TheAlbum)
                            .Where(t => t.IdMusicAlbum == idAlbum)
                            .OrderBy(t => t.Duration);
            return Ok(res);
        }

        [HttpDelete("Musician/{idMusician}")]
        public IActionResult DelMusician(int idMusician)
        {
            var count = _context
                            .MusicianTracks
                            .Where(mt => mt.IdMusician == idMusician)
                            .Include(mt => mt.TheTrack)
                            .Where(mt => mt.TheTrack.IdMusicAlbum != null)
                            .Count();
            if (count > 0)
                return BadRequest("Nie można usunąć tego muzyka");
            var tempList =
            _context
                .MusicianTracks
                .Include(mt => mt.TheTrack)
                .Where(mt => mt.IdMusician == idMusician)
                .ToList();

            var delTracks = new LinkedList<MusicianTrackDbModel>();
            var delMusicianTracks = new LinkedList<MusicianTrackDbModel>();
            var delMusicians = new LinkedList<MusicianTrackDbModel>();
            
            foreach(var e in tempList)
            {
                _context.Musicians.Attach(new MusicianDbModel
                {
                    IdMusician = e.IdMusician
                });
                _context.MusicianTracks.Attach(new MusicianTrackDbModel
                {
                    IdMusician = idMusician,
                    IdTrack = e.IdTrack
                });
                _context.Tracks(
                    new TrackDbModel
                    {
                        IdTrack = e.IdTrack
                    });
            }


            return Ok();
        }
    }
}
