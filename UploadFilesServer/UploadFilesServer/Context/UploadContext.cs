using Microsoft.EntityFrameworkCore;
using UploadFilesServer.Models;

namespace UploadFilesServer.Context
{
    public class UploadContext: DbContext
    {
        public UploadContext(DbContextOptions options)
            :base(options)
        {
        }

        public DbSet<Document>? Documents { get; set; }
    }
}
