using Marik.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marik.Core.Interfaces
{
    public interface ILeadRepository
    {
        IEnumerable<Lead> GetAllLeads();
        Lead GetLeadById(int id);
        void AddNewLead(Lead lead);
        void DeleteLead(int id);
    }
}
