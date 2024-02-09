using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pozdravlyator.Domein.Entities
{

    public abstract class EntityBase
    {
        [Required]
        public Guid Id { get; set; }

        [Display(Name = "Имя друга")]
        public virtual string fio { get; set; }

        [Display(Name = "Дата дня рождения")]
        public virtual DateTime date { get; set; }

        [Display(Name = "Фотография друга")]
        public virtual string photo { get; set; }
    }
}
