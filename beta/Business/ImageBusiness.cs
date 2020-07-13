using beta.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beta.Buisness
{
    interface ImageBusiness
    {
        int saveImages(List<Image> images);
    }
}
