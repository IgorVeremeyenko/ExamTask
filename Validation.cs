using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTask
{
    public class Validation
    {
        public string Url { get; set; }
        public string Validate(string url)
        {
            if (url == null)
            {
                return string.Empty;
            }

            return url;
        }
    }
}
