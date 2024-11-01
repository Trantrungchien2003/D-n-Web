﻿using System.ComponentModel.DataAnnotations;

namespace Shopping_Tutorial.Models
{
    public class CategoryModel
    {
        [Key]
        public int Id { get; set; }
        [Required,MinLength(4, ErrorMessage = "Yêu cầu nhập Tên Danh mục")]
        public string Name { get; set; }

		[Required, MinLength(4, ErrorMessage = "Yêu cầu nhập Mô tả Danh mục")]

		public string Description { get; set; }
        [Required]
        public string slug { get; set; }

        public int Status { get; set; }
    }
}
