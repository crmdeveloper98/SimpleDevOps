using SimpleDevOps.Models;
using System.Collections.Generic;

namespace SimpleDevOps.Repository
{
    public interface IPostRepository
    {
        List<PostViewModel> GetPosts();
    }
}
