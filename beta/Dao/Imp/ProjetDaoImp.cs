using beta.Entities;
using beta.Handlers;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beta.Dao.Imp
{
    class ProjetDaoImp : ProjetDao
    {
        public List<Projet> GetProjetsByUtilisateur(Utilisateur util)
        {
            throw new NotImplementedException();
        }

        List<Projet> ProjetDao.GetProjetsByUtilisateur(Utilisateur util)
        {
            List<Projet> listOfProjects;
            using (IDbConnection connection = ConnectionHandler.Instance.getConnection())
            {
                String query = $"SELECT P.idProjet,P.nomProjet,P.dateCreationProjet,P.idUtilisateur FROM projet as P , acces as A WHERE P.idProjet=A.idProjet AND A.idUtilisateur={util.idUtilisateur}";
                listOfProjects = connection.Query<Projet>(query).ToList();
                

                
                return listOfProjects;
            }
        }
    }
}
