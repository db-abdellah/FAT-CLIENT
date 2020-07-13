using beta.Entities;
using beta.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using beta.Dao.Imp;

namespace beta.Buisness.Imp
{
    class ProjetBusinessImp : ProjetBusiness
    {
        public List<Projet> getProjetsList(Utilisateur utilisateur)
        {
            ProjetDao daoProjet = new ProjetDaoImp();
            return daoProjet.GetProjetsByUtilisateur(utilisateur);
        }
    }
}
