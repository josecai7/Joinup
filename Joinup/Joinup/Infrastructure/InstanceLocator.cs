using Joinup.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joinup.Infrastructure
{
    public class InstanceLocator
    {
        #region Properties

        public MainViewModel Main 
            {
                get;
                set; 
            }

        #endregion

        #region Constructors

        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }

        #endregion
    }
}
