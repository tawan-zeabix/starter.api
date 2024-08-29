using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Starter.API.Models;

namespace src.Models
{
    [Table("tbm_book")]
    public class BookModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public int Price { get; set; }

        [ForeignKey("Writer")]
        public int WriterId { get; set; }
        [JsonIgnore]
        public UserModel? Writer { get; set; }

    }
}