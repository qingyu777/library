using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    class borrowRecord
    {
        private int borrow_record_id;
        private String book_name;
        private String book_borrow_time;
        private String student_name;

        public int Borrow_record_id { get => borrow_record_id; set => borrow_record_id = value; }
        public string Book_borrow_time { get => book_borrow_time; set => book_borrow_time = value; }
        public string Book_name { get => book_name; set => book_name = value; }
        public string Student_name { get => student_name; set => student_name = value; }
    }
}
