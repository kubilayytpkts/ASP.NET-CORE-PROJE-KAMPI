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
        ICommentDal ıCommentDal;
        public CommentManager(ICommentDal _ıCommentDal)
        {
            ıCommentDal = _ıCommentDal;
        }

        public void AddComment(Comment comment)
        {
            ıCommentDal.Insert(comment);
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
            return ıCommentDal.GetListAll(x => x.BlogID == id);
        }

        public void UpdateComment(Comment comment)
        {
            throw new NotImplementedException();
        }
    }
}
