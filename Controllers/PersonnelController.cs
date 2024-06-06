using System.Collections.Generic;
using System.Data;
using MediaTek86.dal;
using MediaTek86.Modele;

namespace MediaTek86.Controllers
{
    public class PersonnelController
    {
        private PersonnelDal personnelDal;

        public PersonnelController()
        {
            personnelDal = new PersonnelDal();
        }

        public DataTable GetAllPersonnel()
        {
            return personnelDal.GetAllPersonnel();
        }

        public void AddPersonnel(Personnel personnel)
        {
            personnelDal.AddPersonnel(personnel);
        }

        public void UpdatePersonnel(Personnel personnel)
        {
            personnelDal.UpdatePersonnel(personnel);
        }

        public void DeletePersonnel(int idPersonnel)
        {
            personnelDal.DeletePersonnel(idPersonnel);
        }
    }
}
