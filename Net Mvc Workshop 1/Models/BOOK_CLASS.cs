using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Net_Mvc_Workshop_1.Models
{
    public class BOOK_CLASS
    {
        /// <summary>
        /// 類別代號
        /// </summary>
        public int BOOK_CLASS_ID { get; set; }

        /// <summary>
        /// 類別名稱
        /// </summary>
        public string BOOK_CLASS_NAME { get; set; }

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