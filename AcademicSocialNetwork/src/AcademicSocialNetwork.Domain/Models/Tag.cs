﻿namespace AcademicSocialNetwork.Domain.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Publication> Publications { get; set; }
    }
}
