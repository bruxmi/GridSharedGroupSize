using System;
namespace GridSharedGroupSize
{
    public class BereichViewModel2 : ViewModelBase, IBereich
    {
        public BereichViewModel2()
        {
            this.Title = "BereichViewModel2 BereichViewModel2";
            this.City = "Berlin";
            this.Name = "BereichViewModel2 mit gaaaaaaaaaaaaanz laaaangeeeeem Namen";
            this.Department = "Department 2";
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
