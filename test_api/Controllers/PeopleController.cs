using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using test_api.Models.Entities;
using test_api.Models.Repos;

namespace test_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {

        private readonly IPeopleRepo _peopleRepo;

        public PeopleController(IPeopleRepo peopleRepo)
        {
            _peopleRepo = peopleRepo;
        }

        [HttpGet]
        public ActionResult<List<Person>> GetPeople()
        {
            return _peopleRepo.GetPeople();
        }


        [HttpDelete]
        public ActionResult<string> DeletePerson(int id)
        {
            Person? person = _peopleRepo.GetPersonById(id);

            if (person == null)
            {
                return NotFound("the person has not found !");
            }

            _peopleRepo.RemovePerson(person);

            return Ok("Success in Deleting");
        }

    }
}
