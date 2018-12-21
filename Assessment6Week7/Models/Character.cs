using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assessment6Week7.Models
{
    public class Character
    {
        [Key]
        public int id { get; set; }
        [Display(Name = "API Url")]
        public string url { get; set; }
        [Display(Name = "Name")]
        public string name { get; set; }
        [Display(Name = "Gender")]
        public string gender { get; set; }
        [Display(Name = "Culture")]
        public string culture { get; set; }
        [Display(Name = "Born")]
        public string born { get; set; }
        [Display(Name = "Died")]
        public string died { get; set; }
        [Display(Name = "Titles")]
        public string titles { get; set; }
        [Display(Name = "Aliases")]
        public string aliases { get; set; }
        [Display(Name = "Father")]
        public string father { get; set; }
        [Display(Name = "Mother")]
        public string mother { get; set; }
        [Display(Name = "Spouse")]
        public string spouse { get; set; }
        [Display(Name = "Allegiances")]
        public string allegiances { get; set; }
        [Display(Name = "Books")]
        public string books { get; set; }
        [Display(Name = "TV Series")]
        public string tvSeries { get; set; }
        [Display(Name = "Played By")]
        public string playedBy { get; set; }
    }
}