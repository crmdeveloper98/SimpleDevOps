using SimpleDevOps.Models;
using System.Collections.Generic;

namespace SimpleDevOps.Repository
{
    public class PostRepository : IPostRepository
    {
        public List<PostViewModel> GetPosts()
        {
            var posts = new List<PostViewModel>
            {
                new PostViewModel()
                {
                    Id = 101,
                    Title = "DevOps Demo Title 1",
                    Description = "DevOps Description 1",
                    Author = "Crm Developer98"
                },
                new PostViewModel()
                {
                    Id = 102,
                    Title = "DevOps Demo Title 2",
                    Description = "DevOps Description 2",
                    Author = "Crm Developer98"
                },
                new PostViewModel()
                {
                    Id = 103,
                    Title = "DevOps Demo Title 3",
                    Description = "DevOps Description 3",
                    Author = "Crm Developer98"
                }               

            };

            return posts;
        }
    }
}
