using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using src.Data;
using src.Models;
using src.Repositories.Interfaces;
using Starter.API.Models;

namespace src.Repositories
{
    public class BookRepository : BaseRepository<BookModel>, IBookRepository
    {
        public BookRepository(AppDbContext context) : base(context)
        {

        }
    }
}