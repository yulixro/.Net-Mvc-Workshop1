using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Net_Mvc_Workshop_1.Models
{
    public class BookStatusService
    {
        public static List<Models.BOOK_CODE> bookStatusData = null;


        public List<Models.BOOK_CODE> GetStatus()
        {
            if (bookStatusData == null)
            {
                bookStatusData = new List<BOOK_CODE>
                {
                    new BOOK_CODE
                    {
                        CODE_TYPE = "可以借出",
                        CODE_ID = "A"
                    },
                    new BOOK_CODE
                    {
                        CODE_TYPE = "已借出",
                        CODE_ID = "B"
                    },
                    new BOOK_CODE
                    {
                        CODE_TYPE = "不可借出",
                        CODE_ID = "U"
                    },
                    new BOOK_CODE
                    {
                        CODE_TYPE = "已借出(未領)",
                        CODE_ID = "C"
                    }
                };
            }
            return bookStatusData;
        }

        public List<SelectListItem> GetBookStatusSelectList()
        {
            List<SelectListItem> result = new List<SelectListItem>();
            foreach (var row in BookStatusService.bookStatusData)
            {
                result.Add(new SelectListItem()
                {
                    Text = row.CODE_TYPE.ToString(),
                    Value = row.CODE_ID.ToString()
                });
            }
            return result;
        }

    }
}