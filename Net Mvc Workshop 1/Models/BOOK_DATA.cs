using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Net_Mvc_Workshop_1.Models
{
    public class BOOK_DATA
    {
        /// <summary>
        /// PK 流水號
        /// </summary>
        [DisplayName("書籍編號")]
        [Required()] ///必要欄位
        public int BOOK_ID { get; set; }

        /// <summary>
        /// 書籍名稱
        /// </summary>
        [DisplayName("書籍名稱")]
        [Required()]
        public string BOOK_NAME { get; set; }

        /// <summary>
        /// 類別代號 BOOK_CLASS.BOOK_CLASS_ID
        /// </summary>
        [DisplayName("圖書類別")]
        [Required()]
        public int BOOK_CLASS_ID { get; set; }

        /// <summary>
        /// 書籍作者
        /// </summary>
        [DisplayName("書籍作者")]
        [Required()]
        public string BOOK_AUTHOR { get; set; }

        /// <summary>
        /// 書籍購書日期
        /// </summary>
        [DisplayName("購買日期")]
        [Required()]
        public string BOOK_BOUGHT_DATE { get; set; }

        /// <summary>
        /// 出版商
        /// </summary>
        [DisplayName("出版商")]
        [Required()]
        public string BOOK_PUBLISHER { get; set; }

        /// <summary>
        /// 內容簡介
        /// </summary>
        [DisplayName("內容簡介")]
        [Required()]
        public string BOOK_NOTE { get; set; }

        /// <summary>
        /// 狀態BOOK_CODE.CODE_ID
        /// (A可以借出/B已借出/U不可借出/C已借出(未領))
        /// </summary>
        [DisplayName("借閱狀態")]
        [Required()]
        public string BOOK_STATUS { get; set; }

        /// <summary>
        /// 書籍保管人
        /// </summary>
        [DisplayName("書籍保管人")]
        public string BOOK_KEEPER { get; set; }

        /// <summary>
        /// 建立時間
        /// </summary>
        [DisplayName("建立時間")]
        public DateTime CREATE_DATE { get; set; }

        /// <summary>
        /// 建立使用者
        /// </summary>
        [DisplayName("建立使用者")]
        public string CREATE_USER { get; set; }

        /// <summary>
        /// 修改時間
        /// </summary>
        [DisplayName("修改時間")]
        public DateTime MODIFY_DATE { get; set; }

        /// <summary>
        /// 修改使用者
        /// </summary>
        [DisplayName("修改使用者")]
        public string MODIFY_USER { get; set; }

    }
}