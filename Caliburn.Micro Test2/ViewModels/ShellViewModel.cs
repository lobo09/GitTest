using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caliburn.Micro_Test2.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        private List<string> myList;
        private List<string> mySecondList;

        public ShellViewModel()
        {
            MyList = Model.GetList();
        }

        public List<string> MyList
        {
            get { return myList; }
            set
            {
                myList = value;
                NotifyOfPropertyChange(() => MyList);
            }
        }

    }
}
