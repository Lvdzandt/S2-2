using KillerApp.Data.Interface;
using KillerApp.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KillerApp.Data.Context
{
    public class ForumSQLContext : IForumContext
    {
        public void AddPost(ForumPost post)
        {
            
        }

        public List<ForumPost> GetAllForumPosts()
        {
            List<ForumPost> output = new List<ForumPost>();
            return output;
        }
    }
}
