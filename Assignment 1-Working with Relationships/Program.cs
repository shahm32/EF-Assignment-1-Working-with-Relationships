using Assignment_1_Working_with_Relationships;
using Core;

class Program
{
    static void Main(string[] args)
    {
        using (var context = new DataContext())
        {
            context.Database.EnsureCreated();

            var users = new User[]
            {
                new User { Name = "Manushi", EmailAddress = "manushi@gmail.com", PhoneNumber = "123-456-7890" },
                new User { Name = "Prahil", EmailAddress = "prahil@gmail.com", PhoneNumber = "123-456-7890" },
                new User { Name = "Bhaumik", EmailAddress = "bhaumik@gmail.com", PhoneNumber = "123-456-7890" }
            };

            context.AddRange(users);
            context.SaveChanges();

            //Console.WriteLine("Users saved successfully.");

            var user = context.Users.FirstOrDefault(u => u.Name == "Manushi");

            var blogType = new BlogType { Status = "Active", Name = "Designer", Description = "Graphic Style blog" };
            context.Add(blogType);
            context.SaveChanges();

            var blog = new Blog
            {
                Url = "https://in.pinterest.com/",
                IsPublic = true,
                BlogTypeId = blogType.BlogTypeId,
                UserId = user.UserId
            };
            context.Add(blog);
            context.SaveChanges();

            var postType = new PostType { Status = "Active", Name = "Logo Design", Description = "Company Logo Design Post" };
            context.Add(postType);
            context.SaveChanges();

            var post = new Post
            {
                Title = "Illustrator",
                Content = "This is a post about how to create logo in Illustrator",
                BlogId = blog.BlogId,
                PostTypeId = postType.PostTypeId,
                UserId = user.UserId
            };
            context.Add(post);
            context.SaveChanges();

            //Console.WriteLine("1 Blog and 1 Post saved successfully.");

            var savedUsers = context.Users.ToList();
            Console.WriteLine("\nSaved Users:");
            foreach (var u in savedUsers)
            {
                Console.WriteLine($"ID: {u.UserId}, Name: {u.Name}, Email: {u.EmailAddress}, Phone: {u.PhoneNumber}");
            }

            var savedBlogs = context.Blogs.ToList();
            Console.WriteLine("\nSaved Blogs:");
            foreach (var b in savedBlogs)
            {
                Console.WriteLine($"ID: {b.BlogId}, URL: {b.Url}, IsPublic: {b.IsPublic}, BlogTypeId: {b.BlogTypeId}, UserId: {b.UserId}");
            }

            var savedPosts = context.Posts.ToList();
            Console.WriteLine("\nSaved Posts:");
            foreach (var p in savedPosts)
            {
                Console.WriteLine($"ID: {p.PostId}, Title: {p.Title}, Content: {p.Content}, BlogId: {p.BlogId}, PostTypeId: {p.PostTypeId}, UserId: {p.UserId}");
            }
        }
    }
}
