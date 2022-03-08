using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace OfficeNote.Models
{
    public class OfficeNoteDbContext : DbContext
    {
        public DbSet<PartnerInfo> PartnerInfo { get; set; }
        public OfficeNoteDbContext(DbContextOptions<OfficeNoteDbContext> options)
            : base(options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    // 닷넷 프레임워크 기반에서 호출되는 코드 영역: 
        //    // App.Config 또는 Web.Config의 연결 문자열 사용
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        string connectionString = ConfigurationManager.ConnectionStrings[
        //            "ConnectionString"].ConnectionString;
        //        optionsBuilder.UseSqlServer(connectionString);
        //    }
        //}
    }

}
