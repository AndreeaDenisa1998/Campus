using AutoMapper;
using Campus.Business.Campus.Models;
using Campus.Business.Campus.Models.Comments;
using Campus.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Campus.Entities;

namespace Campus.Business.Campus.Services
{
    
    class CommentService : ICommentService
    {
        private readonly ICommentRepository commentRepository;
        private readonly IMapper mapper;
        public CommentService(ICommentRepository commentRepository, IMapper mapper)
        {
            this.commentRepository = commentRepository;
            this.mapper = mapper;
        }
        public async Task<CommentModel> GetById(Guid id)
        {
            var comments = await commentRepository.GetCommentById(id);
            return mapper.Map<CommentModel>(comments);
        }
        public async Task<CommentModel> Create(CreateModelComment model)
        {
            var comment = this.mapper.Map<Comments>(model);

            await this.commentRepository.Create(comment);

            await this.commentRepository.SaveChanges();

            return mapper.Map<CommentModel>(comment);
        }
        public async Task Delete(Guid commentId)
        {
            var comment = await commentRepository.GetCommentById(commentId);

            commentRepository.Delete(comment);

            await commentRepository.SaveChanges();
        }
        public async Task Update(Guid commentId, CreateModelComment model)
        {
            var comment = await commentRepository.GetCommentById(commentId);

            mapper.Map(model, comment);

            commentRepository.Update(comment);

            await commentRepository.SaveChanges();
        }


    }
}
