﻿using System;

namespace VedaYOU.Persistence.DocumentTypes
{
    public class Article : ArticlesFolder
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Body { get; set; }

        public string HeaderImage { get; set; }

        public string Icon { get; set; }

        public DateTime CreateDate { get; set; }
    }
}