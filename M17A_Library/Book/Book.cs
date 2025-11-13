using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M17A_Library.Book
{
    internal class Book : iItem
    {
        public int nBook { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public string isbn { get; set; }
        public int year { get; set; }
        public DateTime aquisitionDate { get; set; }
        public decimal price { get; set; }
        public string coverImage { get; set; }
        public bool state { get; set; }

        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Edit()
        {
            throw new NotImplementedException();
        }

        public List<string> Validate()
        {
            List<string> errors = new List<string>();

            if (string.IsNullOrEmpty(title) || title.Length < 3)
            {
                errors.Add("Title is required and must be more than 3 characters long.");
            }

            if (string.IsNullOrEmpty(author) || author.Length < 3)
            {
                errors.Add("Author is required and must be more than 3 characters long.");
            }

            if (year > 0 && year <= DateTime.Now.Year)
            {
                errors.Add("Year must be a positive number and cannot be in the future.");
            }

            if (isbn.Length != 13)
            {
                errors.Add("ISBN must be exactly 13 characters long.");
            }

            return errors;
        }
    }
}
