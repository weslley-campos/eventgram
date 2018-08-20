using System;
using System.Collections.Generic;
using System.Text;
using Model.Models;

namespace Persistence.Persistence
{
    public class PostPersistence
    {
        private static List<Post> posts;

        static PostPersistence()
        {
            if (posts == null)
            {
                posts = new List<Post>();
                //new PostPersistence().Add(new Post("Lorem ipsum", "Lorem ipsum", "Rua D", "20/06/95", "Thiago"));
                //new PostPersistence().Add(new Post("Lorem ipsum", "Lorem ipsum", "Rua C", "20/06/95", "Thiago"));
            }
        }

        public void Add(Post post)
        {
            post.Id = posts.Count + 1;
            posts.Add(post);
        }

        public int Find(Post post) => posts.FindIndex(e => e.Id == post.Id);

        public void Update(Post post) => posts[Find(post)] = post;

        public List<Post> GetAll() => posts;

        public Post GetBy(int? id) => id.HasValue ? posts.Find(post => post.Id == id) : null;

        public void Delete(int id) => posts.Remove(GetBy(id));
    }
}
