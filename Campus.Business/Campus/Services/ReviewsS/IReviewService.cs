using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Campus.Business.Campus.Models;
using Campus.Business.Campus.Models.Comments;
using Campus.Business.Campus.Models.Reviews;

namespace Campus.Business.Campus.Services.ReviewsS
{
    public interface IReviewService
    {
        Task<ReviewModel> GetById(Guid id);
        Task<ReviewModel> Create(CreateReviewModel model);

        Task Delete(Guid reviewId);

        Task Update(Guid reviewId, CreateReviewModel model);
    }
}
