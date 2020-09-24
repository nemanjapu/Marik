using Marik.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marik.Core
{
    public interface IUnitOfWork
    {
        IBlogRepository Blog { get; }
        IProductRepository Product { get; }
        IProductImagesRepository ProductImage { get; }
        IGlobalSettingsRepository GlobalSettings { get; }
        IBlogTypeRepository BlogTypes { get; }
        IClientReviewsRepository ClientReviews { get; }
        ILeadRepository Lead { get; }
        IWebsiteContentRepository WebsiteContent { get; }

        void Complete();
    }
}
