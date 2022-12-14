﻿namespace music_info_app.Entities
{
    public class Artist : BaseEntity
    {
        public string Name { get; set; }
        public string About { get; set; }
        public List<Album> Albums { get; set; }
    }
}
