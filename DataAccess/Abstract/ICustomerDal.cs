using Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    interface ICustomerDal:IEntityRepository<Customer>
    {
    }
}
