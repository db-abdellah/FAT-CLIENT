using beta.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beta.Dao
{
    interface UtilisateurDao
    {
        Utilisateur GetUtilisateurByLogin(String username, String password);
    }
}
