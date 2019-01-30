using KillerApp.Data.Context;
using KillerApp.Data.Interface;
using KillerApp.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KillerApp.Data.Repositories
{
    public class ForumRepository
    {
        IForumContext forumContext = new ForumSQLContext();

        public void AddPost(ForumPost post)
        {
            forumContext.AddPost(post);
        }
        
        public List<ForumPost> GetAllForumPosts()
        {
            return forumContext.GetAllForumPosts();
        }
    }
}
