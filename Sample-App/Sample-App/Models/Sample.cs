using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample_App.Models
{
    public class Sample
    {  
         public string FirstName { get; set; }
         public string LastName { get; set; }

    }

    public class JSONResponse
    {
        [JsonProperty("result")]
     
        public List<Sample> result { get; set; }
    }
}
