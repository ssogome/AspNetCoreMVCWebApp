using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMVCWebApp.Models
{
    public class Emails
    {
        [DisplayName("EMAIL #1")]
        public string EMAIL1 { get; set; }
        [DisplayName("EMAIL #2")]
        public string EMAIL2 { get; set; }
        [DisplayName("EMAIL #3")]
        public string EMAIL3 { get; set; }

    }
}
