using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Campus.Business.Campus.Models;
using Campus.Business.Campus.Models.Comments;
using Campus.Business.Campus.Models.Reviews;
using Campus.Entities;
using Campus.Persistence;

namespace Campus.Business.Campus.Services.ReviewsS
{
    class ReviewService : IReviewService
    {
        
            private readonly IReviewRepository reviewRepository;
            private readonly IMapper mapper;
            public ReviewService(IReviewRepository reviewRepository, IMapper mapper)
            {
                this.reviewRepository = reviewRepository;
                this.mapper = mapper;
            }
            public async Task<ReviewModel> GetById(Guid id)
            {
                var review = await reviewRepository.GetReviewById(id);
                return mapper.Map<ReviewModel>(review);
            }
            public async Task<ReviewModel> Create(CreateReviewModel model)
            {
                var review = this.mapper.Map<Review>(model);

                await this.reviewRepository.Create(review);

                await this.reviewRepository.SaveChanges();

                return mapper.Map<ReviewModel>(review);
            }
            public async Task Delete(Guid reviewId)
            {
                var review = await reviewRepository.GetReviewById(reviewId);

                reviewRepository.Delete(review);

                await reviewRepository.SaveChanges();
            }
            public async Task Update(Guid reviewId, CreateReviewModel model)
            {
                var review = await reviewRepository.GetReviewById(reviewId);

                mapper.Map(model, review);

                reviewRepository.Update(review);

                await reviewRepository.SaveChanges();
            }


        }

    }

