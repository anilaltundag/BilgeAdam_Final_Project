﻿using ApplicationCore.Entities.Abstract;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities.Concrete
{
    public class Movie : BaseEntity
    {
        [Required]
        [MaxLength(400)]
        public string Name { get; set; }

        [Required]
        [MaxLength(600)]
        public string Description { get; set; }
        
        public int Year { get; set; }

        public int DirectorId { get; set; }
        public Director Director { get; set; }
        
        public string Image { get; set; }

        [NotMapped]
        public IFormFile UploadImage { get; set; }

        public List<MovieCategory> MovieCategories { get; set; }
    }
}
