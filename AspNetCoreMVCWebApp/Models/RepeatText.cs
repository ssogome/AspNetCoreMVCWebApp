using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMVCWebApp.Models
{
    public class RepeatText
    {
        public RepeatText()
        {
            Options = new RepeatTextOptions();
        }
        public string Text { get; set; }
        public int Number { get; set; }
        public RepeatTextOptions Options { get; set; }
    }
    public class RepeatTextOptions
    {
        public RepeatTextOptions()
        {
            Factor = 1;
        }
        public int Factor { get; set; }
    }
}
