using System;

namespace DatingAppNew.API.Dtos
{
    public class PhotosForDetailedDto
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Descriptio { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsMain { get; set; }       
    }
}