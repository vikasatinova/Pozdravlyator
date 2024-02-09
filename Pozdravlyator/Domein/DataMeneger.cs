using Pozdravlyator.Domein.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pozdravlyator.Domein
{
    public class DataMeneger
    {

        public IBirthdayRepository Birthdays { get; set; }

        public DataMeneger(IBirthdayRepository birthday)
        {
            Birthdays = birthday;
        }
    }
}
