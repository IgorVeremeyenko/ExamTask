using System;
using System.Text.RegularExpressions;

namespace ExamTask
{
    public class Validation
    {
        public string Url { get; set; }
        public string Validate(string url)
        {
            bool isUri = Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute);
            /*Regex r = new Regex("http(s)?://([\\w+?\\.\\w+])+([a-zA-Z0-9\\~\\!\\@\\#\\$\\%\\^\\&amp;\\*\\(\\)_\\-\\=\\+\\\\\\/\\?\\.\\:\\;\\'\\,]*)?", RegexOptions.IgnoreCase);*/
            /*Match match = r.Match(url);*/
            if (isUri)
            {
                Url = url;
            }
            return null;
        }
    }
}
