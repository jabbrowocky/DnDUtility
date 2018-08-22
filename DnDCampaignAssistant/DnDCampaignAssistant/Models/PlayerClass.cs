using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DnDCampaignAssistant.Models
{
    public class PlayerClass
    {
        [Key]
        public int ClassId { get; set; }
        public string ClassType { get; set; }
        


    }
}