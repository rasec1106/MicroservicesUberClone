using BlogPost.Model;

namespace BlogPost.Repository
{
    public interface IPostRepository
    {
        public Task<IEnumerable<Comment>> GetComments();

        public Task<bool> add(Comment comment);  

        public Task<bool> update(Comment comment);

        public Task<bool> delete(Comment comment);

        
        
        
        
        public Task<IEnumerable<User>> GetUsers();


        public Task<bool> add(User user);

        public Task<bool> update(User user);

        public Task<bool> delete(User user);


    }
}
