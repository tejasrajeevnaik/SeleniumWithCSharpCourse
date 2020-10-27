using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSectionExam
{
    class PageObjectOne : IPageObject
    {
        // Private variables

        // Constructor
        public PageObjectOne()
        {
            PageName = "Page Name 1";
        }

        // Properties
        public string PageName
        {
            get;
            set;
        }

        // Methods
    }
}
