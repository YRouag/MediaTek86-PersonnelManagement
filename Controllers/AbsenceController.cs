using System.Collections.Generic;
using System.Data;
using MediaTek86.dal;
using MediaTek86.Modele;

namespace MediaTek86.Controllers
{
    public class AbsenceController
    {
        private AbsenceDal absenceDal;

        public AbsenceController()
        {
            absenceDal = new AbsenceDal();
        }

        public DataTable GetAllAbsences()
        {
            return absenceDal.GetAllAbsences();
        }

        public void AddAbsence(Absence absence)
        {
            absenceDal.AddAbsence(absence);
        }

        public void UpdateAbsence(Absence absence)
        {
            absenceDal.UpdateAbsence(absence);
        }

        public void DeleteAbsence(int idPersonnel, DateTime dateDebut)
        {
            absenceDal.DeleteAbsence(idPersonnel, dateDebut);
        }
    }
}
