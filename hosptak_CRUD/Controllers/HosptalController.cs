using hosptal_CRUD.services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace hosptal_CRUD.Controllers
{
    [ApiController]
    [Route("Doctor_crud")]
    public class DoctorController : ControllerBase
    {
        private IHosptalService _docService;

        public DoctorController(IHosptalService docService)
        {
            _docService = docService;
        }

        [HttpPost]
        public Hosptal Post(Hosptal hosptal)
        {
            var hosptalResult = _docService.Create(hosptal);
            return hosptalResult;
        }

        [HttpGet]
        public List<Hosptal> Get()
        {
            return _docService.Get();
        }

        [HttpGet]
        [Route("{hosptalId}")]
        public Hosptal GetById(string hosptalId)
        {
            return _docService.Get(hosptalId);
        }

        [HttpDelete]
        [Route("{hosptalId}")]
        public long DeletById(string hosptalId)
        {
            return _docService.Remove(hosptalId);
        }

        [HttpPut]
        [Route("{hosptalId}")]
        public long UpdateById(string hosptalId, [FromBody] Hosptal hosptal)
        {
            return _docService.Update(hosptalId, hosptal);
        }
    }
}
