using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DnDCampaignAssistant.Models
{
    public class Player
    {
        [Key]
        public int Id { get; set; }
        public string PlayerName { get; set; }
        public int ClassId { get; set;}
        public PlayerClass PlayerClass { get; set; }
        public int StatsId { get; set; }
        public Stats Stats { get; set; }               
        public bool IsDM { get; set; }

    }
}