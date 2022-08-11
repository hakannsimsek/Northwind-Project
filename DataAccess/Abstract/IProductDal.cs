using Core.DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        //listeme ekleme silme güncelleme vs imza atılır concretede implementasyonları yapılrı
    }
}
