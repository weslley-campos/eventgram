using System;
using System.Collections.Generic;
using System.Text;
using Persistence.Persistence;
using Model.Models;

namespace Business.Business
{
    public class PostManager
    {
        PostPersistence postPersistence;

        public PostManager() => postPersistence = new PostPersistence();

        public List<Post> GetAll() => postPersistence.GetAll();

        public Post GetBy(int id) => postPersistence.GetBy(id);

        public void Create(Post post) => postPersistence.Add(post);

        public void Edit(Post post) => postPersistence.Update(post);

        public void Delete(int id) => postPersistence.Delete(id);
    }
}
