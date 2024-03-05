using System.Security.Cryptography;
using Blog.Entity;
using Microsoft.EntityFrameworkCore;

namespace Blog.Data.Concrete.EfCore
{
    public static class SeedData
    {
        public static void TestVerileriniDoldur(IApplicationBuilder app)
        {
            var context = app.ApplicationServices.CreateScope().ServiceProvider.GetService<BlogContext>();

            if(context != null)
            {
                if(context.Database.GetPendingMigrations().Any())
                {
                    context.Database.Migrate();
                }

                if(!context.Tags.Any())
                {
                    context.Tags.AddRange(
                        new Tag { Text = "web programlama", Url="web-programlama",Color=TagColors.warning},
                        new Tag { Text = "backend", Url="backend" ,Color=TagColors.info},
                        new Tag { Text = "frontend",Url="frontend",Color=TagColors.success},
                        new Tag { Text = "fullstack",Url="fullstack",Color=TagColors.secondary},
                        new Tag { Text = "php",Url="php",Color=TagColors.primary }
                    );
                    context.SaveChanges();
                }

                if(!context.Users.Any())
                {
                    context.Users.AddRange(
                        new User { UserName = "iremnurmemis",Name="İremnur Memiş",Email="info@iremnurmemis.com",Password="123456",Image="p1.jpg"},
                        new User { UserName = "karamellikiraz",Name="Deniz",Email="info@karamellikiraz.com",Password="123456",Image="p2.jpg"}
                    );
                    context.SaveChanges();
                }

                if(!context.Posts.Any())
                {
                    context.Posts.AddRange(
                        new Post {
                            Title = "Asp.net core",
                            Description = "Asp.net core dersleri",
                            Content = "Asp.net core dersleri",
                            Url="aspnet-core",
                            IsActive = true,
                            Image = "1.jpg",
                            PublishedOn = DateTime.Now.AddDays(-10),
                            Tags = context.Tags.Take(3).ToList(),
                            UserId = 1,
                            Comments=new List<Comment>{
                                new Comment {Text="çok faydalandığım bir kurs",PublishedOn=DateTime.Now.AddDays(-20),UserId=2},
                                new Comment {Text="iyi bir kurs",PublishedOn=DateTime.Now.AddDays(-10),UserId=1},
                                
                            }
                        },
                        new Post {
                            Title = "Php",
                            Description = "Php core dersleri",
                            Content = "Php core dersleri",
                            Url="php",
                            IsActive = true,
                            Image = "2.jpg",
                            PublishedOn = DateTime.Now.AddDays(-20),
                            Tags = context.Tags.Take(2).ToList(),
                            UserId = 1
                        },
                        new Post {
                            Title = "Django",
                            Description="Django dersleri",
                            Content = "Django dersleri",
                            Url="django",
                            IsActive = true,
                            Image = "3.jpg",
                            PublishedOn = DateTime.Now.AddDays(-5),
                            Tags = context.Tags.Take(4).ToList(),
                            UserId = 2
                        },
                        new Post {
                            Title = "React",
                            Description="React dersleri",
                            Content = "React dersleri",
                            Url="react-dersleri",
                            IsActive = true,
                            Image = "3.jpg",
                            PublishedOn = DateTime.Now.AddDays(-40),
                            Tags = context.Tags.Take(4).ToList(),
                            UserId = 2
                        }
                        
                    );
                    context.SaveChanges();
                }
            }
        }
    }
}