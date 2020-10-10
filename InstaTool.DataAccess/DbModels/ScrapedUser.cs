using System;
using System.Collections.Generic;
using System.Text;

namespace InstaTool.DataAccess.DbModels
{
    public class ScrapedUser
    {
        public string UserURL { get; set; }
        public string Description { get; set; }
        public bool IsPrivate { get; set; }
    }
}
