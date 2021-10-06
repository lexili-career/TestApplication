using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Sample_App.data;
using Sample_App.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;


namespace Sample_App.Repo
{
    public class SampleDataService : ISampleData
    {
       // private readonly IOptions<Sample> config;

        private readonly IConfiguration _configuration;
        private readonly IWebHostEnvironment _env;
        private readonly MyUser _myUser;
     
        //private readonly IApplicationEnvironment _appEnv;
        public SampleDataService(IConfiguration configuration, IWebHostEnvironment env, IOptions<MyUser> myUser)
        {
            _configuration = configuration;
            _env = env;
            _myUser = myUser.Value;
        }
       
     
        public void Insert(Sample sample)
        {
            try
            {
                string path = _env.ContentRootPath + '/' + "sampledata.json";
                var JSON = System.IO.File.ReadAllText(path);
                dynamic array = JsonConvert.DeserializeObject(JSON);
                var jsonData = array["result"];
                var sampleList = jsonData.ToObject<List<Sample>>();

                // Add any new Item
                sampleList.Add(sample);
                JSONResponse result = new JSONResponse();
                //s.result = "result";
                result.result = sampleList;
                jsonData = JsonConvert.SerializeObject(result, Formatting.Indented); //JsonConvert.SerializeObject(sampleList);

                System.IO.File.WriteAllText(path, jsonData);
            }
            catch(Exception ex)
            { }

        }

    }
}
