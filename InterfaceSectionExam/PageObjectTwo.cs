using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSectionExam
{
    class PageObjectTwo : IPageObject
    {
        // Private variables

        // Constructor
        public PageObjectTwo()
        {
            PageName = "Page Name 2";
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
