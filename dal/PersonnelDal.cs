using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using MediaTek86.bddmanager;

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

        // Ajoutez d'autres méthodes pour ajouter, modifier, supprimer du personnel ici
    }
}
