using Pozdravlyator.Domein.Entities;
using Pozdravlyator.Domein.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pozdravlyator.Domein.Repositories.EntityFramework
{
    public class EFBirthdayRepository : IBirthdayRepository
    {
        private readonly AppDBContext context;

        public EFBirthdayRepository(AppDBContext context)
        {
            this.context = context;
        }
        public void DeleteBirthday(int id)
        {
            context.Birthdays.Remove(new Birthday() { Id = id });
            context.SaveChanges();
        }

        public Birthday GetBirthdayById(int id)
        {
            return context.Birthdays.FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<Birthday> GetBirthdays()
        {
            return context.Birthdays;
        }

        public IQueryable<Birthday> GetTodayBirthdays()
        {
            //Определим даты ближайших трех дней
            DateTime day1 = DateTime.Now.AddDays(1);
            DateTime day2 = DateTime.Now.AddDays(2);
            DateTime day3 = DateTime.Now.AddDays(3);
            return context.Birthdays.Where(p => ((p.date.Day == DateTime.Now.Day && p.date.Month == DateTime.Now.Month))||
                                                    (p.date.Day == day1.Day && p.date.Month == day1.Month) ||
                                                    (p.date.Day == day2.Day && p.date.Month == day2.Month) ||
                                                    (p.date.Day == day3.Day && p.date.Month == day3.Month));
        }

        public void SaveBirthday(Birthday entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            else
                context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
