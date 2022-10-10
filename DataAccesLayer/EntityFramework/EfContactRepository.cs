using DataAccesLayer.Abstract;
using DataAccesLayer.Repositories;
using EntityLayer.Concreat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.EntityFramework
{
    public class EfContactRepository:GenericRepository<Contact>,IContactDal
    {

    }
}
