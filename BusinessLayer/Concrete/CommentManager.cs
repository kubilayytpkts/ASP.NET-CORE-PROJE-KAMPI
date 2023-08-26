using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDal _ıCommentDal;
        public CommentManager(ICommentDal ıCommentDal)
        {
            _ıCommentDal = ıCommentDal;
        }

        public void AddComment(Comment comment)
        {
            throw new NotImplementedException();
        }

        public void DeleteComment(Comment comment)
        {
            throw new NotImplementedException();
        }

        public Comment GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Comment> ListAllComment(int id)
        {
            return _ıCommentDal.GetListAll(x => x.BlogID == id);
        }

        public void UpdateComment(Comment comment)
        {
            throw new NotImplementedException();
        }
    }
}
