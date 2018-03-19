﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SDMS.DTO.DTO;

namespace Chat.FrontWeb.Models.Finance
{
    public class JournalListModel
    {
        public JournalDTO[] journalList { get; set; }
        public string Page { get; set; }
        public List<CurrencyNameDTO> currencyList { get; set; }
    }
}