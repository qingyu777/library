using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System.Collections;

namespace library
{
    class SqlConnect
    {
        public MySqlConnection myCon = null;
        public SqlConnect()
        {
            try
            {
                String constr = System.Configuration.ConfigurationManager.ConnectionStrings["library"].ConnectionString;
                myCon = new MySqlConnection(constr);
                if (myCon.State == ConnectionState.Closed)
                {
                    myCon.Open();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("获取查询结果集出错" + e.Message);
            }
        }

        public MySqlCommand ExcuteOrder(string sql, MySqlConnection myCon)     //执行命令语句sql  
        {
            MySqlCommand myCom = new MySqlCommand(sql, myCon);
            return myCom;
        }

        public String GetSerchResult(MySqlCommand myCom)    //获取查询结果  
        {
            String a = "";
            try
            {
                MySqlDataReader msDr = myCom.ExecuteReader();
                int column = msDr.FieldCount;  //获取集合列数  
                while (msDr.Read())
                {
                    if (msDr.HasRows)
                    {
                        for (int i = 0; i < column; i++)
                        {
                            a += msDr.GetString(i);
                        }
                    }
                }
                msDr.Close(); //关闭数据集
                return a;
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Data);
                Console.WriteLine("获取查询结果集出错" + e.Message);
                return "false";
            }
        }

        public Book[] GetBookArraySerchResult(MySqlCommand myCom)    //获取书籍查询结果  
        {
            try
            {
                MySqlDataReader msDr = myCom.ExecuteReader();
                int column = msDr.FieldCount;  //获取集合列数 
                                               //ArrayList big = new ArrayList();
                int j = 0;
                List<Book> books = new List<Book>();
                while (msDr.Read())
                {
                    if (msDr.HasRows)
                    {
                        Book book = new Book();
                        book.Book_id = msDr.GetInt32(0);
                        book.Book_name = msDr.GetString(1).Trim();
                        book.Book_type = msDr.GetString(2).Trim();
                        book.Book_author = msDr.GetString(3).Trim();
                        book.Book_location = msDr.GetString(4).Trim();
                        book.Book_number = msDr.GetInt32(5);
                        books.Add(book);

                    }
                    j++;
                }

                Book[] booksArray = books.ToArray();
                msDr.Close(); //关闭数据集
                return booksArray;
            }

            catch (Exception e)
            {
                Book[] a = new Book[0];
                Console.WriteLine(e.Data);
                Console.WriteLine("获取查询结果集出错"+e.Message);
                return a;
            }
        }

        public int isSerchResult(MySqlCommand myCom)    //判断查询是否有结果  
        {
            try
            {
                MySqlDataReader msDr = myCom.ExecuteReader();
                if (msDr.HasRows)
                {
                    msDr.Close();  //关闭数据集  
                    return 1;
                }

                else
                {
                    msDr.Close();  //关闭数据集  
                    return 0;

                }
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return -1;
            }
        }

        public int GetDelInsertUpdateResult(MySqlCommand myCom)       //获取删、插、更新执行结果  
        {
            try
            {
                myCom.ExecuteNonQuery();
                return 1;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Data);
                Console.WriteLine("执行出错");
                return 0;
            }
        }

        public void CloseMySqlConnection()      //关闭数据库连接句柄  
        {
            myCon.Close();
        }
    }
}
