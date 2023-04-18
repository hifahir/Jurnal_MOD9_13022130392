using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace modul9_1302213092.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class mahasiswaController : Controller
    {
        public static List<mahasiswa> mh = new List<mahasiswa>()
        {
            new mahasiswa("Hilman Fariz Hirzi","1302213092", new List<String>{"KPL", "Basis Data", "PBO"}, 2021),
            new mahasiswa("Rihan Hidayat","1302210028", new List<String>{"KPL", "Basis Data", "PBO"}, 2021),
            new mahasiswa("Jaatsiyah Maulidina Astrianto","1302213043", new List<String>{"KPL", "Basis Data", "PBO"}, 2021),
            new mahasiswa("Putri Auliya Rahmah","1302210033", new List<String>{"KPL", "Basis Data", "PBO"}, 2021),
            new mahasiswa("Liyan Made Leon WAYAN","1302213037", new List<String>{"KPL", "Basis Data", "PBO"}, 2021),
        };

        [HttpGet]
        public IEnumerable<mahasiswa> Get()
        {
            return mh;
        }

        [HttpPost]
        public void Post([FromBody] mahasiswa mahasiswa)
        { 
            mh.Add(mahasiswa);
        }

        [HttpGet("{idx}")]
        public mahasiswa Get(int idx)
        {
            return mh[idx];
        }

        [HttpDelete("{idx}")]
        public void Delete(int idx) 
        {
            mh.RemoveAt(idx);
        }
    }
}