using FamilyTree.Data.Dto;
using FamilyTree.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace FamilyTree.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet]
        public async Task<List<PersonDto>> Get()
            => await _personService.GetAllAsync();

        [HttpGet("{id}")]
        public async Task<PersonDto> Get(int id)
            => await _personService.GetAsync(id);

        [HttpPost]
        public async Task Post([FromBody] PersonDto dto, CancellationToken cancellationToken)
        => await _personService.SaveAsync(dto, cancellationToken);

        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] PersonDto dto, CancellationToken cancellationToken)
            => await _personService.SaveAsync(dto, cancellationToken);

        [HttpDelete, Route("{id}")]
        public async Task Delete(int id, CancellationToken cancellationToken)
            => await _personService.DeleteAsync(id, cancellationToken);

        [HttpPost, Route("DeleteByIds")]
        public async Task DeleteByIds(List<int> ids, CancellationToken cancellationToken)
        => await _personService.DeleteAsync(ids, cancellationToken);
    }
}