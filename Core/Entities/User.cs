using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFitness.API.Core.Entities
{
    public class User : BaseEntity
    {
        public User(string fullName, decimal height, decimal weight, DateTime bithDate) : base()
        {
            FullName = fullName;
            Height = height;
            Weight = weight;
            BithDate = bithDate;
        }

        public string FullName { get; private set; }

        public decimal Height { get; private set; }

        public decimal Weight { get;private set; }

        public DateTime BithDate { get; private set; }

        public IEnumerable<Meal> Meals { get; private set; }

        public void Update(decimal height, decimal weight)
        {
            Height = height;
            Weight = weight;
        }
    }
}
