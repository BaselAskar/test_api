using test_api.Models.Entities;

namespace test_api.Models.Repos
{
    public interface IPeopleRepo
    {
        List<Person> GetPeople();
        Person? GetPersonById(int id);
        void AddPerson(Person person);
        void RemovePerson(Person person);
    }
}
