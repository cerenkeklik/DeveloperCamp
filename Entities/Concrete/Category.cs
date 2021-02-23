using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Category: IEntity
    {
        //Çıplak class kalmasın
        public int CatgeoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
