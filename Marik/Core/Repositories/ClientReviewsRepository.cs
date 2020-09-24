using Marik.Core.Interfaces;
using Marik.Core.Models;
using Marik.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Marik.Core.Repositories
{
    public class ClientReviewsRepository : IClientReviewsRepository
    {
        private readonly ApplicationDbContext _ctx;

        public ClientReviewsRepository(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public void AddReview(ClientReview review)
        {
            _ctx.ClientReviews.Add(review);
        }

        public IEnumerable<ClientReview> GetActiveReviews()
        {
            return _ctx.ClientReviews.Where(r => r.isActive);
        }

        public IEnumerable<ClientReview> GetAllReviews()
        {
            return _ctx.ClientReviews;
        }

        public IEnumerable<ClientReview> GetInactiveReviews()
        {
            return _ctx.ClientReviews.Where(r => !r.isActive);
        }

        public ClientReview GetReviewById(int id)
        {
            return _ctx.ClientReviews.Find(id);
        }

        public void RemoveReview(int id)
        {
            var review = _ctx.ClientReviews.Find(id);
            _ctx.ClientReviews.Remove(review);
        }
    }
}