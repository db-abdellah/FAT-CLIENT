using beta.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace beta.Handlers
{
    public static class  ProjectHandler
    {
        public static List<Projet> sortAscending(List<Projet> listProjets)
        {
            var projects = from p in listProjets
                           orderby p.dateCreationProjet ascending
                           select p;
            projects.ToList().ForEach(p => Console.WriteLine(p.nomProjet + " " + p.dateCreationProjet));
            return projects.ToList<Projet>();
        }  
        
        public static List<Projet> sortDescending(List<Projet> listProjets)
        {
            var projects = from p in listProjets
                           orderby p.dateCreationProjet descending
                           select p;
            projects.ToList().ForEach(p => Console.WriteLine(p.nomProjet + " " + p.dateCreationProjet));
            return projects.ToList<Projet>();
        }
    }
}
