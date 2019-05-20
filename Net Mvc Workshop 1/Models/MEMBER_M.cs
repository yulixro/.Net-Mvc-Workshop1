using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Net_Mvc_Workshop_1.Models
{
    public class MEMBER_M
    {
        /// <summary>
        /// 人員編號
        /// </summary>
        public string USER_ID { get; set; }

        /// <summary>
        /// 中文名稱
        /// </summary>
        public string USER_CNAME { get; set; }

        /// <summary>
        /// 英文名稱
        /// </summary>
        public string USER_ENAME { get; set; }

        /// <summary>
        /// 建立時間
        /// </summary>
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime CREATE_DATE { get; set; }

        /// <summary>
        /// 建立使用者
        /// </summary>
        public string CREATE_USER { get; set; }

        /// <summary>
        /// 修改時間
        /// </summary>
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime MODIFY_DATE { get; set; }

        /// <summary>
        /// 修改使用者
        /// </summary>
        public string MODIFY_USER { get; set; }

    }
}