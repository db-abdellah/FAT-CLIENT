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
    class UtilisateurDaoImp : UtilisateurDao
    {
        Utilisateur UtilisateurDao.GetUtilisateurByLogin(string username, string password)
        {
            using (IDbConnection connection = ConnectionHandler.Instance.getConnection())
            {
               
                List<Utilisateur> util = connection.Query<Utilisateur>($"SELECT * FROM utilisateur WHERE  loginUtilisateur = '{username}' AND motDePasseUtilisateur ='{password}'").ToList();
               

                if (util.Count > 0)
                    return util[0];
                else return null;
            }
        }
    }
}
