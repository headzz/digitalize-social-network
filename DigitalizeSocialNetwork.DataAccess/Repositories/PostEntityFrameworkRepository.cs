using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalizeSocialNetwork.DataAccess.Contexts;
using DigitalizeSocialNetwork.DomainModel.Entities;

namespace DigitalizeSocialNetwork.DataAccess.Repositories
{
    public class PostEntityFrameworkRepository
    {
        private SocialNetworkContext db = new SocialNetworkContext();

        public void Create(Post post)
        {
            db.Posts.Add(post);
            db.SaveChanges();
        }

        public void Delete(Guid postId)
        {
            Post post = Read(postId);
            db.Posts.Remove(post);
            db.SaveChanges();
        }

        public Post Read(Guid postId)
        {
            //return db.Posts.Find(postId);
            return db.Posts.Include(p => p.Sender).Include(p => p.Recipient).SingleOrDefault(p => p.Id == postId);
        }

        public IEnumerable<Post> ReadAll()
        {
            return db.Posts.Include(p => p.Sender).Include(p => p.Recipient);
        }

        public void Update(Post post)
        {
            db.Entry(post).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
