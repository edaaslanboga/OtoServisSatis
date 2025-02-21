using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OtoServisSatis.Data.Abstract;
using OtoServisSatis.Entities;

namespace OtoServisSatis.Service.Abstract
{
    public interface IService<T> : IRepository<T> where T : class,IEntity,new()
    {
    }
}
