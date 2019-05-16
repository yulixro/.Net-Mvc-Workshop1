using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Net_Mvc_Workshop_1.Models
{
    public class BookClassService
    {
        public static List<Models.BOOK_CLASS> bookClassData = null;

        /// <summary>
        /// 讀取圖書類別資料
        /// </summary>
        /// <returns></returns>
        public List<Models.BOOK_CLASS> GetBookClass()
        {
            if (bookClassData == null)
            {
                bookClassData = new List<BOOK_CLASS>
                {
                    new BOOK_CLASS() {
                        BOOK_CLASS_ID = "1",
                        BOOK_CLASS_NAME = "資料庫"
                    },

                    new BOOK_CLASS() {
                        BOOK_CLASS_ID = "2",
                        BOOK_CLASS_NAME = "網際網路"
                    },

                    new BOOK_CLASS() {
                        BOOK_CLASS_ID = "3",
                        BOOK_CLASS_NAME = "應用系統整合"
                    },

                    new BOOK_CLASS() {
                        BOOK_CLASS_ID = "4",
                        BOOK_CLASS_NAME = "家庭保健"
                    },

                    new BOOK_CLASS() {
                        BOOK_CLASS_ID = "5",
                        BOOK_CLASS_NAME = "語言"
                    },
                };
            }

            return bookClassData;
        }

        /// <summary>
        /// 建立下拉式選單
        /// </summary>
        /// <returns></returns>
        public List<SelectListItem> GetBookClassSelectList()
        {
            List<SelectListItem> result = new List<SelectListItem>();
            foreach (var row in BookClassService.bookClassData)
            {
                result.Add(new SelectListItem()
                {
                    Text = row.BOOK_CLASS_NAME.ToString(),
                    Value = row.BOOK_CLASS_ID.ToString()
                });
            }
            return result;
        }
    }
}