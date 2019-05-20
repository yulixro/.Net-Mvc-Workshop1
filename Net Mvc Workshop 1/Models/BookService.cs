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
                        BOOK_AUTHOR = "我",
                        BOOK_BOUGHT_DATE = DateTime.Parse("1999/01/01"),
                        BOOK_PUBLISHER = "第一出版",
                        BOOK_NOTE = "這是第一本書",
                        BOOK_STATUS = 'A',
                        CREATE_DATE = DateTime.Parse("2019/05/20"),
                        CREATE_USER = "YuLi",
                        MODIFY_DATE = DateTime.Parse("2019/05/20"),
                        MODIFY_USER = "KuLi"
                    },

                    new BOOK_DATA() {
                        BOOK_ID = 2,
                        BOOK_NAME = "二本書",
                        BOOK_CLASS_ID = "2",
                        BOOK_AUTHOR = "他",
                        BOOK_BOUGHT_DATE = DateTime.Parse("1999/02/01"),
                        BOOK_PUBLISHER = "第二出版",
                        BOOK_NOTE = "這是第二本書",
                        BOOK_STATUS = 'A',
                        CREATE_DATE = DateTime.Parse("2019/05/21"),
                        CREATE_USER = "YuLi",
                        MODIFY_DATE = DateTime.Parse("2019/05/21"),
                        MODIFY_USER = "KuLi"

                    }
                };
            }

            return bookData;
        }
    }
}