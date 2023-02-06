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
        Driver driver;
        public Amazon(Driver driver)
        {
            this.driver = driver;
        }
        public Homepage Homepage => new Homepage(driver);
        public LoginPage LoginPage => new LoginPage(driver);
        
        public SearchedResults SearchedResults => new SearchedResults(driver);
    }
}
