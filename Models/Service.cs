namespace MediaTek86.Modele
{
    public class Service
    {
        public int IdService { get; set; }
        public string Nom { get; set; }

        public Service(int idService, string nom)
        {
            IdService = idService;
            Nom = nom;
        }
    }
}
