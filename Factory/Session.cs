using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Ftec.Cadastro.Site.Models;
using Newtonsoft.Json; 

namespace Ftec.Cadastro.Site.Factory
{
    public class Session
    {
        public static SetList(string SessionKeyList, List<Produto> produtos) 
        {
            HttpContext.Session.SetString(SessionKeyList, JsonConvert.SerializeObject(produtos));
        }

        public static List<Produto> GetList(string SessionKeyList) 
        {
            var json = HttpContext.Session.GetString(SessionKeyList); 
            
            return json == null ? new List<Produto>() : JsonConvert.DeserializeObject(json);
        }
    }
}