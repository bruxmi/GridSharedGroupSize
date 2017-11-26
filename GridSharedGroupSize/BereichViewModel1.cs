using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridSharedGroupSize
{
    public class BereichViewModel1: ViewModelBase, IBereich
    {
        public BereichViewModel1()
        {
            this.Title = "BereichViewModel1 BereichViewModel1";
            this.City = "Berlin";
            this.Name = "BereichViewModel1";
            this.Department = "BereichViewModel1 Department";
            this.BeginDate = DateTime.Now;
            this.EndDate = DateTime.Now;
        }
        public string Title { get { return GetValue<string>(); } set { SetValue(value); } }
        public string City { get { return GetValue<string>(); } set { SetValue(value); } }
        public string Name { get { return GetValue<string>(); } set { SetValue(value); } }
        public string Department { get { return GetValue<string>(); } set { SetValue(value); } }
        public DateTime BeginDate { get { return GetValue<DateTime>(); } set { SetValue(value); } }
        public DateTime EndDate { get { return GetValue<DateTime>(); } set { SetValue(value); } }

    }
}
