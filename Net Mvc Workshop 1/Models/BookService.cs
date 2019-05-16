using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Net_Mvc_Workshop_1.Models
{
    public class BookService
    {
        public static List<Models.BOOK_DATA> bookData = null;
        /// <summary>
        /// 讀取書籍資料
        /// </summary>
        /// <returns></returns>
        public List<Models.BOOK_DATA> GetBook()
        {
            if (bookData == null)
            {
                bookData = new List<BOOK_DATA>
                {
                    new BOOK_DATA() {
                        BOOK_ID = 1,
                        BOOK_NAME = "一本書",
                        BOOK_CLASS_ID = "1",
                        BOOK_AUTHOR = "我"
                    },

                    new BOOK_DATA() {
                        BOOK_ID = 2,
                        BOOK_NAME = "二本書",
                        BOOK_CLASS_ID = "2",
                        BOOK_AUTHOR = "他"
                    }
                };
            }

            return bookData;
        }

        /// <summary>
        /// 查詢書籍資料
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
    
        //public List<Models.BOOK_DATA> GetBookByCondition(Models.BookSearchArg arg)
        //{
        //    return ;
        //}
    }
}