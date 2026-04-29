using Microsoft.AspNetCore.Mvc;

namespace tpmodul9_103082400039
{
    [ApiController]
    [Route("api/[controller]")]
    public class MahasiswaController : ControllerBase
    {
        // Static list
        private static List<Mahasiswa> mahasiswaList = new List<Mahasiswa>
        {
            new Mahasiswa { Nama = "Nama Kamu", Nim = "NIM Kamu" },
            new Mahasiswa { Nama = "Teman 1", Nim = "NIM1" },
            new Mahasiswa { Nama = "Teman 2", Nim = "NIM2" }
        };

        // GET /api/mahasiswa
        [HttpGet]
        public ActionResult<List<Mahasiswa>> GetAll()
        {
            return mahasiswaList;
        }

        // GET /api/mahasiswa/{index}
        [HttpGet("{index}")]
        public ActionResult<Mahasiswa> GetByIndex(int index)
        {
            if (index < 0 || index >= mahasiswaList.Count)
                return NotFound();

            return mahasiswaList[index];
        }

        // POST /api/mahasiswa
        [HttpPost]
        public ActionResult AddMahasiswa(Mahasiswa mhs)
        {
            mahasiswaList.Add(mhs);
            return Ok();
        }

        // DELETE /api/mahasiswa/{index}
        [HttpDelete("{index}")]
        public ActionResult DeleteMahasiswa(int index)
        {
            if (index < 0 || index >= mahasiswaList.Count)
                return NotFound();

            mahasiswaList.RemoveAt(index);
            return Ok();
        }
    }
}
