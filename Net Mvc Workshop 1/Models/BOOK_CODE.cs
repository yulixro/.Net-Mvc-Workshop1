using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Net_Mvc_Workshop_1.Models
{
    public class BOOK_CODE
    {
        /// <summary>
        /// CodeType
        /// </summary>
        public string CODE_TYPE { get; set; }

        /// <summary>
        /// CodeId
        /// </summary>
        public string CODE_ID { get; set; }

        /// <summary>
        /// CodeType描述
        /// </summary>
        public string CODE_TYPE_DESC { get; set; }

        /// <summary>
        /// CodeId描述
        /// </summary>
        public string CODE_NAME { get; set; }

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