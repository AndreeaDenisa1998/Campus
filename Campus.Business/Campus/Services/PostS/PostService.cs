using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Campus.Business.Campus.Models.Post;
using Campus.Entities;
using Campus.Persistence;

namespace Campus.Business.Campus.Services.PostS
{
    class PostService : IPostService
    {
        private readonly IPostRepository commentRepository;
        private readonly IMapper mapper;
        public PostService(IPostRepository commentRepository, IMapper mapper)
        {
            this.commentRepository = commentRepository;
            this.mapper = mapper;
        }
        public async Task<PostModel> GetById(Guid id)
        {
            var posts = await commentRepository.GetCommentById(id);
            return mapper.Map<PostModel>(posts);
        }
        public async Task<PostModel> Create(CreateModelPost model)
        {
            var posts = this.mapper.Map<Comments>(model);

            await this.commentRepository.Create(posts);

            await this.commentRepository.SaveChanges();

            return mapper.Map<PostModel>(posts);
        }
        public async Task Delete(Guid commentId)
        {
            var posts = await commentRepository.GetCommentById(commentId);

            commentRepository.Delete(posts);

            await commentRepository.SaveChanges();
        }
        public async Task Update(Guid commentId, CreateModelPost model)
        {
            var posts = await commentRepository.GetCommentById(commentId);

            mapper.Map(model, posts);

            commentRepository.Update(posts);

            await commentRepository.SaveChanges();
        }
    }
}
