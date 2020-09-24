using Marik.Core.Interfaces;
using Marik.Core.Models;
using Marik.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Marik.Core.Repositories
{
    public class GlobalValuesRepository : IGlobalSettingsRepository
    {
        private readonly ApplicationDbContext _ctx;

        public GlobalValuesRepository(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public GlobalValues GetGlobalValues()
        {
            return _ctx.GlobalValues.FirstOrDefault();
        }
    }
}