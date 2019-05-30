using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    class Book
    {
        private int book_id;
        private String book_name;
        private String book_type;
        private String book_author;
        private String book_location;
        private int book_number;

        public int Book_id { get => book_id; set => book_id = value; }
        public string Book_name { get => book_name; set => book_name = value; }
        public string Book_type { get => book_type; set => book_type = value; }
        public string Book_author { get => book_author; set => book_author = value; }
        public string Book_location { get => book_location; set => book_location = value; }
        public int Book_number { get => book_number; set => book_number = value; }
    }
}
