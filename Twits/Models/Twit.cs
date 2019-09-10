using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Twits.Models
{
    public class Twit
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
    }
}