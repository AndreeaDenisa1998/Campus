using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Campus.Business.Campus.Models;
using Campus.Business.Campus.Models.Post;

namespace Campus.Business.Campus.Services.PostS
{
    public interface IPostService
    {
        Task<PostModel> GetById(Guid id);
        Task<PostModel> Create(CreateModelPost model);

        Task Delete(Guid commentId);

        Task Update(Guid commentId, CreateModelPost model);
    }
}
