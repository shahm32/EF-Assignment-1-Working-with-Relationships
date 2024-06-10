using Assignment_1_Working_with_Relationships;
using Core;
using Microsoft.EntityFrameworkCore;

namespace Assignment_1_Working_with_Relationships
{
    public class Program
    {
        static void Main(string[] args)
        {
           

            using (var context = new DataContext())
            {
                var users = new[]
                {
                    new User { UserName = "Manushi Shah", Email = "manushi@gmail.com", PhoneNumber = 12345678 },
                new User { UserName = "Prahil", Email = "prahil@gmail.com", PhoneNumber = 12345678 },
                new User { UserName = "Bhaumik", Email = "bhaumik@gmail.com", PhoneNumber = 12345678 },
            };

                context.Users.AddRange(users);
                context.SaveChanges();


                var posttypes = new[]
            {
                 new PostType { Status = "Active", Name = "Manushi Shah", Description = "Hi! I m Manushi" },
                new PostType { Status = "InActive", Name = "Prahil", Description = "Hi! I m Prahil" },
            };


                context.PostTypes.AddRange(posttypes);
                context.SaveChanges();



                var blogTypes = new[]
                {
            new BlogType { Status = "Active", Name = "Manushi Shah", Description = "Manushi's Blog" },
            new BlogType { Status = "Active", Name = "Prahil", Description = "Prahil's Blog" },
            };

                context.BlogTypes.AddRange(blogTypes);
                context.SaveChanges();

                var blog = new Blog { Url = "https://in.pinterest.com/", IsPublic = true, BlogTypeId = 1 };

                context.Blogs.Add(blog);
                context.SaveChanges();

                var post = new Post
                {
                    Title = "Check out my First Post",
                    Content = "Hello Everyone, Check out my first Post",
                    BlogId = blog.Id,
                    PostTypeId = posttypes.First().Id,
                    UserId = users.First().Id,
                };


                context.Posts.AddRange(post);
                context.SaveChanges();



            }


            Console.WriteLine("Hello, World!");

        }
    }
}
