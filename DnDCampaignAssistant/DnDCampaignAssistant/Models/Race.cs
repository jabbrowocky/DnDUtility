﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DnDCampaignAssistant.Models
{
    public class Race
    {
        [Key]
        public int RaceId { get; set; }
        public string RaceName {get;set;}

    }
}