using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //product ile ilgili veritabanında 
    //yapacağım operasyonları içeren interface
    public interface IProductDal: IEntityRepository<Product>
    {
        
    }
}
