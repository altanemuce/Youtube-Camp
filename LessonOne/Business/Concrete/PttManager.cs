using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class PttManager : ISupplierService
    {
        private IApplicationService _applicationService;

        public PttManager()
        {
        }

        public PttManager(IApplicationService applicationService) //Constructor new yapıldığında çalışır.
        {
            _applicationService = applicationService;
        }

        public void GiveMask(Person person)
        {
            if (_applicationService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " için maske verildi");
            }
            else
            {
                Console.WriteLine(person.FirstName + " için maske Verilemedi");
            }
        }
    }
}
