using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DnDCampaignAssistant.Models
{
    public class Stats
    {
        [Key]
        public int StatsId { get; set; }
        [Display(Name = "Str")]                
        public int Strength { get; set; }
        [Display(Name = "Dex")]
        public int Dexterity { get; set; }
        [Display(Name = "Con")]
        public int Constitution { get; set; }
        [Display(Name = "Int")]
        public int Intelligence { get; set; }
        [Display(Name = "Wis")]
        public int Wisdom { get; set; }
        [Display(Name = "Cha")]
        public int Charisma { get; set; }
    }
}