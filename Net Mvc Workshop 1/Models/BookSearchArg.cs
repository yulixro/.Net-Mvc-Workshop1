using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Net_Mvc_Workshop_1.Models
{
    public class BookSearchArg
    {
        /// <summary>
        /// 書籍名稱
        /// </summary>
        [DisplayName("書籍名稱")]
        public string BOOK_NAME { get; set; }

        /// <summary>
        /// 書籍類別
        /// </summary>
        [DisplayName("圖書類別")]
        public string BOOK_CLASS_ID { get; set; }

        /// <summary>
        /// 借閱人編號
        /// </summary>
        [DisplayName("借閱人")]
        public string USER_ID { get; set; }

        /// <summary>
        /// 書籍狀態
        /// </summary>
        public string BOOK_STATUS { get; set; }

    }
}