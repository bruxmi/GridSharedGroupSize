using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridSharedGroupSize
{
    public class BereicheViewModel: ViewModelBase
    {
        public BereicheViewModel()
        {
            this.Bereiche = new ObservableCollection<IBereich>();
            this.Bereiche.Add(new BereichViewModel1());
            this.Bereiche.Add(new BereichViewModel2());
            this.Bereiche.Add(new BereichViewModel1());
            this.Bereiche.Add(new BereichViewModel2());

            this.Bereiche.Add(new BereichViewModel1());
            this.Bereiche.Add(new BereichViewModel2());
            this.Bereiche.Add(new BereichViewModel1());
            this.Bereiche.Add(new BereichViewModel2());

            this.Bereich1 = new BereichViewModel1();
            this.Bereich2 = new BereichViewModel2();
        }

        public BereichViewModel1 Bereich1
        {
            get { return GetValue<BereichViewModel1>(); }
            set { SetValue(value); }
        }

        public BereichViewModel2 Bereich2
        {
            get { return GetValue<BereichViewModel2>(); }
            set { SetValue(value); }
        }

        public ObservableCollection<IBereich> Bereiche
        {
            get { return GetValue<ObservableCollection<IBereich>>(); }
            set { SetValue(value); }
        }
    }
}
