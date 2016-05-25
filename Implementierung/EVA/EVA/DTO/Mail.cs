using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVA.DTO
{
    public class Mail
    {
        public string To { get; set; }
        public string Sender { get; set; }
        public string Subject { get; set; }
        public string Text { get; set; }
    }
}
