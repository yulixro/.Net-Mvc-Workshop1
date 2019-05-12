using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Net_Mvc_Workshop_1.Models
{
    public class MemberService
    {
        public static List<Models.MEMBER_M> memberData = null;
        public List<Models.MEMBER_M> GetMember()
        {
            if(memberData == null)
            {
                memberData = new List<MEMBER_M>
                {
                    new MEMBER_M()
                    {
                        USER_ID = 1,
                        USER_CNAME = "尤莉",
                        USER_ENAME = "YuLi"
                    },
                    new MEMBER_M()
                    {
                        USER_ID = 2,
                        USER_CNAME = "庫里",
                        USER_ENAME = "KuLi"
                    }
                };
            }

            return memberData;
        }

        //public List<Models.BOOK_CLASS> GetBookByCondition(Models.BookSearchArg arg)
        //{

        //}

        public List<SelectListItem> GetMemberSelectList()
        {
            List<SelectListItem> result = new List<SelectListItem>();
            foreach (var row in MemberService.memberData)
            {
                result.Add(new SelectListItem()
                {
                    Text = row.USER_CNAME.ToString(),
                    Value = row.USER_ID.ToString()
                });
            }
            return result;
        }
    }
}