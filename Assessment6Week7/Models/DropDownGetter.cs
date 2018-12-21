using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assessment6Week7.Models
{
    public class DropDownGetter
    {
        public static List<SelectListItem> GetDropDown()
        {
            List<SelectListItem> sl = new List<SelectListItem>();
            CharacterDbContext db = new CharacterDbContext();
            foreach (var temp in db.Characters)
            {
                sl.Add(new SelectListItem() { Text = temp.name, Value = temp.id.ToString() });
            }
            return sl;
        }
    }
}