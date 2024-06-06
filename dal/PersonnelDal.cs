using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using MediaTek86.bddmanager;
using MediaTek86.Modele;

namespace MediaTek86.dal
{
    public class PersonnelDal
    {
        private BddManager bddManager;

        public PersonnelDal()
        {
            string connectionString = Connection.GetConnectionString();
            bddManager = new BddManager(connectionString);
        }

        public DataTable GetAllPersonnel()
        {
            string query = "SELECT * FROM personnel";
            return bddManager.ExecuteQuery(query);
        }

        public void AddPersonnel(Personnel personnel)
        {
            string query = "INSERT INTO personnel (nom, prenom, tel, mail, idservice) VALUES (@Nom, @Prenom, @Tel, @Mail, @IdService)";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@Nom", personnel.Nom),
                new SqlParameter("@Prenom", personnel.Prenom),
                new SqlParameter("@Tel", personnel.Tel),
                new SqlParameter("@Mail", personnel.Mail),
                new SqlParameter("@IdService", personnel.IdService)
            };
            bddManager.ExecuteNonQuery(query, parameters);
        }

        public void UpdatePersonnel(Personnel personnel)
        {
            string query = "UPDATE personnel SET nom = @Nom, prenom = @Prenom, tel = @Tel, mail = @Mail, idservice = @IdService WHERE idpersonnel = @IdPersonnel";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@IdPersonnel", personnel.IdPersonnel),
                new SqlParameter("@Nom", personnel.Nom),
                new SqlParameter("@Prenom", personnel.Prenom),
                new SqlParameter("@Tel", personnel.Tel),
                new SqlParameter("@Mail", personnel.Mail),
                new SqlParameter("@IdService", personnel.IdService)
            };
            bddManager.ExecuteNonQuery(query, parameters);
        }

        public void DeletePersonnel(int idPersonnel)
        {
            string query = "DELETE FROM personnel WHERE idpersonnel = @IdPersonnel";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@IdPersonnel", idPersonnel)
            };
            bddManager.ExecuteNonQuery(query, parameters);
        }
    }
}
