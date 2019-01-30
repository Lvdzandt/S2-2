using KillerApp.Data.Repositories;
using KillerApp.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KillerApp.Logic
{
    public class ForumLogic
    {
        private ForumRepository _rep = new ForumRepository();

        public void AddPost(ForumPost post)
        {
            _rep.AddPost(post);
        }

        public List<ForumPost> GetAllForumPosts()
        {
            return _rep.GetAllForumPosts();
        }
    }
}
