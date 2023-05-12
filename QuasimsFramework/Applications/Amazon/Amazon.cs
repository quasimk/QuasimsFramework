using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuasimsFramework.Applications.Amazon.pages;
using QuasimsFramework.Helpers;

namespace QuasimsFramework.Applications.Amazon
{
    public class Amazon
    {
        Driver _driver;
        public Amazon(Driver driver)
        {
            _driver = driver; 
        }
        public Homepage Homepage => new Homepage(_driver);
        public LoginPage LoginPage => new LoginPage(_driver);
        
        public SearchedResults SearchedResults => new SearchedResults(_driver);
    }
}
