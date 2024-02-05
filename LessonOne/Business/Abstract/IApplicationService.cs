using Entities.Concrete;

namespace Business.Abstract
{
    public interface IApplicationService
    {
        void ApplyForMask(Person person);


        List<Person> GetList();


        bool CheckPerson(Person person);

    }
}
