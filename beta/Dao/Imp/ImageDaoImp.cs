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
    public class ImageDaoImp : ImageDao
    {
       

        void ImageDao.SaveImage(Image image)
        {

            using (IDbConnection connection = ConnectionHandler.Instance.getConnection())
            {
                
                    connection.Query("INSERT INTO image (nomImage, dateTransfert, idProjet,idUtilisateur) VALUES(@nomImage,CURRENT_TIMESTAMP,@idProjet,@idUtilisateur)",
                        new
                        {
                            nomImage = image.nomImage,
                            dateTransfer = image.dateTransfer,
                            idProjet = image.idProjet,
                            idUtilisateur = image.idUtilisateur,
                        });
                


            }

        }
       

    }
}
