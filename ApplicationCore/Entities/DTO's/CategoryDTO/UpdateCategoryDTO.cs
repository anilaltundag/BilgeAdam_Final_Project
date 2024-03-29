﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities.DTO_s.CategoryDTO
{
    public class UpdateCategoryDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Bu alan zorunludur")]
        [MaxLength(100, ErrorMessage = " Maximum 100 karakter olmalı")]
        public string Name { get; set; }

    }
}
