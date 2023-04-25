using BUS.IBus;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Website_selling_jewelry_APIAdmin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NhaCungCapController : ControllerBase
    {
        private INhaCungCapBus _nhacungcapbus;
        public NhaCungCapController(INhaCungCapBus NHACUNGCAPBUS)
        {
            _nhacungcapbus = NHACUNGCAPBUS;
        }
        [HttpGet]
        [Route("GetNhaCungCap")]
        public IActionResult GetAllNhaCungCap()
        {
            return Ok(_nhacungcapbus.GetAllNhaCungCap());
        }
    }
}
