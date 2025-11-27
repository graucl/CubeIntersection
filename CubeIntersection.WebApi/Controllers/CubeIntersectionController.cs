using Microsoft.AspNetCore.Mvc;
using CubeIntersection.Distributed.Dtos;
using CubeIntersection.Application.Services.Contracts;

namespace CubeIntersection.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CubeIntersectionController(IIntersectionApplicationService service) : ControllerBase
    {
        private readonly IIntersectionApplicationService _service = service;

        [HttpPost("intersect")]
        public ActionResult<IntersectionResultDto> Intersect([FromBody] IntersectRequest model)
        {
            if (model == null) return BadRequest();


            var req = new IntersectRequest
            {
                A = new CubeDto { CenterX = model.A.CenterX, CenterY = model.A.CenterY, CenterZ = model.A.CenterZ, Side = model.A.Side },
                B = new CubeDto { CenterX = model.B.CenterX, CenterY = model.B.CenterY, CenterZ = model.B.CenterZ, Side = model.B.Side }
            };


            var result = _service.Intersect(req);

            return Ok(new IntersectionResultDto { Intersects = result.Intersects, IntersectedVolume = result.IntersectedVolume });
        }
    }
}
