using beta.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beta.Buisness
{
    interface UtilisiateurBusiness
    {
        Utilisateur connecterUtilisateur(String username, String password);
    }
}
