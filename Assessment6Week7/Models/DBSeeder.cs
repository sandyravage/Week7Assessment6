using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace Assessment6Week7.Models
{
    public class DBSeeder
    {
        public static void FillDB()
        {
            CharacterDbContext db = new CharacterDbContext();

            if (db.Characters.ToList().Count == 0)
            {
                for (int i = 1; i < 2138; i++)
                {
                    try
                    {
                        JsonGetCharacter newChars = new JsonGetCharacter();
                        HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create($@"https://anapioficeandfire.com/api/characters/{i}");
                        request.Method = WebRequestMethods.Http.Get;
                        request.Accept = "application/json";
                        HttpWebResponse response = (HttpWebResponse)request.GetResponse();



                        using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                        {
                            newChars = JsonConvert.DeserializeObject<JsonGetCharacter>(reader.ReadToEnd());
                        }

                        Character character = new Character()
                        {
                            url = newChars.url,
                            aliases = string.Join(", ", newChars.aliases),
                            allegiances = string.Join(", ", newChars.allegiances),
                            books = string.Join(", ", newChars.books),
                            born = newChars.born,
                            culture = newChars.culture,
                            died = newChars.died,
                            father = newChars.father,
                            gender = newChars.gender,
                            mother = newChars.mother,
                            name = newChars.name,
                            playedBy = string.Join(", ", newChars.playedBy),
                            spouse = newChars.spouse,
                            titles = string.Join(", ", newChars.titles),
                            tvSeries = string.Join(", ", newChars.tvSeries)
                        };

                        db.Characters.Add(character);
                    }
                    catch(Exception e)
                    {
                        continue;
                    }
                }
            }
            db.SaveChanges();
        }
    }
}
