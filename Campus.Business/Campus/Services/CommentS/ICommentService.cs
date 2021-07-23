using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Campus.Business.Campus.Models;
using Campus.Business.Campus.Models.Comments;

namespace Campus.Business.Campus.Services
{
    public interface ICommentService
    {
        Task<CommentModel> GetById(Guid id);
        Task<CommentModel> Create(CreateModelComment model);

        Task Delete(Guid commentId);

        Task Update(Guid commentId, CreateModelComment model);
    }
}
