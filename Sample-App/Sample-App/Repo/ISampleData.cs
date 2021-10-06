using Sample_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample_App.Repo
{
    public interface ISampleData
    {

       // IEnumerable<Sample> GetAll();
       // Sample GetById(int EmployeeID);
        void Insert(Sample sample);
        
      

    }
}
