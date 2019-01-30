using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KillerApp.Objects
{
    public class ForumPost
    {
        public int id { get; set; }
        public string Title { get; set; }
        public string Decription { get; set; }
        public User createdby { get; set; }
        public string Categorie { get; set; }
    }
}
