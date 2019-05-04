using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Net_Mvc_Workshop_1.Models
{
    public class BookSearchArg
    {
        /// <summary>
        /// 書籍名稱
        /// </summary>
        public string BOOK_NAME { get; set; }

        /// <summary>
        /// 書籍類別
        /// </summary>
        public int BOOK_CLASS_ID { get; set; }

        /// <summary>
        /// 借閱人中文名
        /// </summary>
        public string USER_CNAME { get; set; }

        /// <summary>
        /// 書籍狀態
        /// </summary>
        public char BOOK_STATUS { get; set; }

    }
}