using OfficeNote.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OfficeNote.BLL
{
    interface IPartnerInfoRepository
    {
        List<PartnerInfo> GetListAll();
        PartnerInfo GetDetail(int id);
    }
    public class PartnerInfoRepository : IPartnerInfoRepository
    {
        private readonly OfficeNoteDbContext _context;

        public PartnerInfoRepository(OfficeNoteDbContext context)
        {
            _context = context;
        }
        public List<PartnerInfo> GetListAll()
        {
            return _context.PartnerInfo.ToList();
        }
        public PartnerInfo GetDetail(int id)
        {
            throw new NotImplementedException();
        }

        
    }
}
