using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using dovtest.MODAL;
using dovtest.DATA;
using System.Net.Http;

using System.Net.Http.Headers; 
using Newtonsoft.Json;

namespace dovtest.REPOSITORY
{
    public class ContinateRepository:IContinateRepository
    {
      
         public  async Task<object> GetContinate(){
         
            object text = System.IO.File.ReadAllText(@"..\dovtest.DATA\\conitnate.txt");
            await Task.Delay(1000);
            return  text;
         }
          public  async Task<object> GetContinateGraphQl(){
            var query = "?query={continents{name,code}}";
            var path = "https://countries.trevorblades.com/"+query;
            List<Continate> res= null;
            Continate tmpobj;
            var client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(path);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
         return responseBody;
         }
         
    }
}