﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Models
{
    public class AddSalesPersonModel
    {
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }

        public string LastName { get; set; }

        public DateTime HireDate { get; set; }
        public int TerritoryId { get; set; }
        public string Gender { get; set; }
        public string JobTitle { get; set; }
        public string MaritalStatus { get; set; }
        public string LoginId { get; set; }
        public string NationalIdNumber { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
