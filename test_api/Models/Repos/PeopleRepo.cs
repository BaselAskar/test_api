using test_api.Data;
using test_api.Models.Entities;

namespace test_api.Models.Repos
{
    public class PeopleRepo : IPeopleRepo
    {
        private readonly AppDbContext _context;

        public PeopleRepo(AppDbContext context)
        {
            _context = context;
        }

        public void AddPerson(Person person)
        {
            _context.People!.Add(person);
            _context.SaveChanges();
        }

        public List<Person> GetPeople()
        {
            return _context.People!.ToList();
        }

        public Person? GetPersonById(int id)
        {
            return _context.People!.Find(id);
        }

        public void RemovePerson(Person person)
        {
            _context.People!.Remove(person);
            _context.SaveChanges();
        }
    }
}
