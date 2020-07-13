using beta.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beta.Dao
{
    interface ProjetDao
    {
        List<Projet> GetProjetsByUtilisateur(Utilisateur util);
    }
}
