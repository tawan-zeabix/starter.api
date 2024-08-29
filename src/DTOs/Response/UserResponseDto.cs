using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using src.Models;

namespace src.DTOs.Response
{
    public class UserResponseDto
    {
        public int Id { get; set; }
        public string Fullname { get; set; } = string.Empty;
        public List<BookModel>? OwnBooks { get; set; }
    }
}