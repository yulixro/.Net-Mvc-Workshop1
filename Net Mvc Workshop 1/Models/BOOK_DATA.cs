using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Net_Mvc_Workshop_1.Models
{
    public class BOOK_DATA
    {
        /// <summary>
        /// PK 流水號
        /// </summary>
        public int BOOK_ID { get; set; }

        /// <summary>
        /// 書籍名稱
        /// </summary>
        public string BOOK_NAME { get; set; }

        /// <summary>
        /// 類別代號 BOOK_CLASS.BOOK_CLASS_ID
        /// </summary>
        public string BOOK_CLASS_ID { get; set; }

        /// <summary>
        /// 書籍作者
        /// </summary>
        public string BOOK_AUTHOR { get; set; }

        /// <summary>
        /// 書籍購書日期
        /// </summary>
        public string BOOK_BOUGHT_DATE { get; set; }
        
        /// <summary>
        /// 出版商
        /// </summary>
        public string BOOK_PUBLISHER { get; set; }

        /// <summary>
        /// 內容簡介
        /// </summary>
        public string BOOK_NOTE { get; set; }

        /// <summary>
        /// 狀態BOOK_CODE.CODE_ID
        /// (A可以借出/B已借出/U不可借出/C已借出(未領))
        /// </summary>
        public char BOOK_STATUS { get; set; }

        /// <summary>
        /// 書籍保管人
        /// </summary>
        public string BOOK_KEEPER { get; set; }

        /// <summary>
        /// 建立時間
        /// </summary>
        public DateTime CREATE_DATE { get; set; }

        /// <summary>
        /// 建立使用者
        /// </summary>
        public string CREATE_USER { get; set; }

        /// <summary>
        /// 修改時間
        /// </summary>
        public DateTime MODIFY_DATE { get; set; }

        /// <summary>
        /// 修改使用者
        /// </summary>
        public string MODIFY_USER { get; set; }

    }
}