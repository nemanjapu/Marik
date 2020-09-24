using Marik.Core;
using Marik.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace Marik.Areas.Admin.Controllers.APIControllers
{
    [Authorize]
    public class BlogTypesController : ApiController
    {
        private readonly IUnitOfWork _unitOfWork;

        public BlogTypesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IQueryable<BlogType> GetBlogTypes()
        {
            return _unitOfWork.BlogTypes.GetBlogTypes();
        }

        [ResponseType(typeof(BlogType))]
        public IHttpActionResult GetBlogType(int id)
        {
            BlogType BlogType = _unitOfWork.BlogTypes.GetBlogType(id);
            if (BlogType == null)
            {
                return NotFound();
            }

            return Ok(BlogType);
        }

        [ResponseType(typeof(BlogType))]
        public IHttpActionResult AddNewBlogType(BlogType BlogType)
        {
            _unitOfWork.BlogTypes.AddBlogType(BlogType);
            _unitOfWork.Complete();

            return CreatedAtRoute("DefaultApi", new { id = BlogType.Id }, BlogType);
        }

        [HttpPost]
        public IHttpActionResult DeleteBlogType(int id)
        {
            if (!_unitOfWork.BlogTypes.RemoveBlogType(id))
            {
                return BadRequest();
            }
            _unitOfWork.Complete();

            return Ok();
        }
    }
}
