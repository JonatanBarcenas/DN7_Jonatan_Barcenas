using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    public class Customer
    {
       
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }

        public Customer(int Id, string name, DateTime date) { 
            this.Id = Id;
            this.Name = name;
            this.Date = date;
        }
    }
}
