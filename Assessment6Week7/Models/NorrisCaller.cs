using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace Assessment6Week7.Models
{
    public class NorrisCaller
    {
        public static Norris GetNorris()
        { 
            Norris newNorris = new Norris();
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(@"https://api.chucknorris.io/jokes/random");
            request.Method = WebRequestMethods.Http.Get;
            request.Accept = "application/json";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            try
            {
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    newNorris = JsonConvert.DeserializeObject<Norris>(reader.ReadToEnd());
                }
            }
            catch(Exception e)
            {
                newNorris.value = "Something went wrong and the joke wasn't found, try loading again";
            }

            return newNorris;
        }
    }
}