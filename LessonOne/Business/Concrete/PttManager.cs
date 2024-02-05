using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager : ISupplierService
    {
        private IApplicationService _applicationService;

        public PttManager()
        {
        }
        public PttManager(IApplicationService applicationService)
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
