using KillerApp.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KillerApp.Data.Interface
{
    public interface IForumContext
    {
        void AddPost(ForumPost post);

        List<ForumPost> GetAllForumPosts();
    }
}
