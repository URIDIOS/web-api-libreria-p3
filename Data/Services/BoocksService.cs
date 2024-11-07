using Librerias_JUOO.Data;
using Librerias_JUOO.Data.Models;
using Librerias_UrielOsuna.Data.ViewModels;
using System;
using System.Threading;

namespace Librerias_UrielOsuna.Data.Services
{
    public class BoocksService
    {
        private AppDbContext _context;
        public BoocksService(AppDbContext context)
        {
            _context = context;

        }
        public void AddBook(BookVM book)
        {
            var _book = new Book()
            {
                Title = book.Title,
                Descripcion = book.Descripcion,
                IsRead = book.IsRead,
                DataRead = book.DataRead,
                Rate = book.Rate,
                Genero = book.Genero,
                Autor = book.Autor,
                CoverUrl = book.CoverUrl,
                DateAdded = DateTime.Now,

            };
            _context.Books.Add(_book);
            _context.SaveChanges();
        }

	}
}
