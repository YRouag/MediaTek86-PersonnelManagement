using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using MediaTek86.bddmanager;
using MediaTek86.Modele;

namespace MediaTek86.dal
{
    public class AbsenceDal
    {
        private BddManager bddManager;

        public AbsenceDal()
        {
            string connectionString = Connection.GetConnectionString();
            bddManager = new BddManager(connectionString);
        }

        public DataTable GetAllAbsences()
        {
            string query = "SELECT * FROM absence";
            return bddManager.ExecuteQuery(query);
        }

        public void AddAbsence(Absence absence)
        {
            string query = "INSERT INTO absence (idpersonnel, datedebut, datefin, idmotif) VALUES (@IdPersonnel, @DateDebut, @DateFin, @IdMotif)";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@IdPersonnel", absence.IdPersonnel),
                new SqlParameter("@DateDebut", absence.DateDebut),
                new SqlParameter("@DateFin", absence.DateFin),
                new SqlParameter("@IdMotif", absence.IdMotif)
            };
            bddManager.ExecuteNonQuery(query, parameters);
        }

        public void UpdateAbsence(Absence absence)
        {
            string query = "UPDATE absence SET datedebut = @DateDebut, datefin = @DateFin, idmotif = @IdMotif WHERE idpersonnel = @IdPersonnel";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@IdPersonnel", absence.IdPersonnel),
                new SqlParameter("@DateDebut", absence.DateDebut),
                new SqlParameter("@DateFin", absence.DateFin),
                new SqlParameter("@IdMotif", absence.IdMotif)
            };
            bddManager.ExecuteNonQuery(query, parameters);
        }

        public void DeleteAbsence(int idPersonnel, DateTime dateDebut)
        {
            string query = "DELETE FROM absence WHERE idpersonnel = @IdPersonnel AND datedebut = @DateDebut";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@IdPersonnel", idPersonnel),
                new SqlParameter("@DateDebut", dateDebut)
            };
            bddManager.ExecuteNonQuery(query, parameters);
        }
    }
}
