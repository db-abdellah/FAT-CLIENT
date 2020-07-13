using beta.Buisness;
using beta.Dao;
using beta.Dao.Imp;
using beta.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace beta.Business.Imp
{
    class UtilisateurBusinessImp : UtilisiateurBusiness
    {
        public Utilisateur connecterUtilisateur(string username, string password)
        {
            UtilisateurDao utilDao = new UtilisateurDaoImp();
            Utilisateur utilisateur = new Utilisateur();
            utilisateur = utilDao.GetUtilisateurByLogin(username, password);

            return utilisateur;
        }
    }
}
