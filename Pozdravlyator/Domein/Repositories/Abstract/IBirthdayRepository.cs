using Pozdravlyator.Domein.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pozdravlyator.Domein.Repositories.Abstract
{
    public interface IBirthdayRepository
    {
        IQueryable<Birthday> GetBirthdays();
        IQueryable<Birthday> GetTodayBirthdays();
        Birthday GetBirthdayById(int id);
        void SaveBirthday(Birthday entity);
        void DeleteBirthday(int id);
    }
}
