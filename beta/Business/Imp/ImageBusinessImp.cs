using beta.Dao;
using beta.Dao.Imp;
using beta.Entities;
using beta.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beta.Buisness
{
    class ImageBusinessImp : ImageBusiness
    {
        public int saveImages(List<Image> images)
        {
          
            ImageDao imageDao = new ImageDaoImp();
            foreach(Image img in images)
            {
                ClientServer server = new ClientServer(); 
                //random Name generator
                Random random = new Random();
                int num = random.Next(10000);
                img.nomImage = (num.ToString() +"_"+DateTime.Now.ToString("HH_mm_ss"));

                try {
                    //Database Connection Test
                    if (ConnectionHandler.Instance.testConnction()) { 
                    server.sendImage(img);
                    imageDao.SaveImage(img);
                    }
                }
                catch
                {
                    return -1;
                }
                
            }
            return 1;



        }

     }

}


