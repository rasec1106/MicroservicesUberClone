using BlogPost.dbContexts;
using BlogPost.Model;
using Microsoft.EntityFrameworkCore;

namespace BlogPost.Repository
{
    public class IPostSQL : IPostRepository
    {
        private AppDbContext _appDbContext;

        public IPostSQL(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }

        public Task<bool> add(Comment comment)
        {
            throw new NotImplementedException();
        }

        public Task<bool> add(User user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> delete(Comment comment)
        {
            throw new NotImplementedException();
        }

        public Task<bool> delete(User user)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Comment>> GetComments()
        {
            return await _appDbContext.comments.ToListAsync();
        }

        public Task<IEnumerable<User>> GetUsers()
        {
            throw new NotImplementedException();
        }

        public Task<bool> update(Comment comment)
        {
            throw new NotImplementedException();
        }

        public Task<bool> update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
