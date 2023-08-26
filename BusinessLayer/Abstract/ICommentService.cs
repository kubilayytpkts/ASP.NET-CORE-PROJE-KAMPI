using Entity;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICommentService
    {
        void AddComment(Comment comment);
        void DeleteComment(Comment comment);
        List<Comment> ListAllComment(int id);
        Comment GetById(int id);
        void UpdateComment(Comment comment);
    }
}
