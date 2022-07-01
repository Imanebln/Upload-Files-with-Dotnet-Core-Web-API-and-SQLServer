using System.ComponentModel.DataAnnotations;

namespace UploadFilesServer.Models
{
    public class Document
    {
     
        public int Id { get; set; }
        public string Name { get; set; }
        public string FileType { get; set; }
        public string Extension { get; set; }
        public DateTime CreatedOn { get; set; }  
        public string FilePath { get; set; }
        public byte[] Data { get; set; }

    }
}
