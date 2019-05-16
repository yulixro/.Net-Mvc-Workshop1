using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Net_Mvc_Workshop_1.Controllers
{
    public class BookController : Controller
    {
        Models.BookService bookService = new Models.BookService();
        Models.BookClassService bookClassService = new Models.BookClassService();
        Models.MemberService memberService = new Models.MemberService();
        Models.BookStatusService bookStatusService = new Models.BookStatusService();

        // GET: Default
        public ActionResult Index()
        {
            Init();
            var books = Models.BookService.bookData;
            var bookClasses = Models.BookClassService.bookClassData;

            //var result = books.Join(bookClasses, a => a.BOOK_CLASS_ID, b => b.BOOK_CLASS_ID, (a, b) => new {     
            //});
 

            ViewBag.Books = books;
            ViewBag.BookClassSelectList = bookClassService.GetBookClassSelectList();
            ViewBag.MemberSelectList = memberService.GetMemberSelectList();
            ViewBag.BookStatusSelectList = bookStatusService.GetBookStatusSelectList();
            return View();
        }

        [HttpPost()]
        public ActionResult Index(FormCollection form)
        {
            return View("Index");
        }

        [HttpGet()]
        public ActionResult InsertBook()
        {
            Init();
            ViewBag.BookClassSelectList = bookClassService.GetBookClassSelectList();
            ViewBag.MemberSelectList = memberService.GetMemberSelectList();
            ViewBag.BookStatusSelectList = bookStatusService.GetBookStatusSelectList();
            return View();
        }

        [HttpPost()]
        public ActionResult InsertBook(Models.BOOK_DATA book)
        {
            return View();
        }

        /// <summary>
        /// 初始化資料
        /// </summary>
        public void Init()
        {
            bookService.GetBook();
            bookClassService.GetBookClass();
            memberService.GetMember();
            bookStatusService.GetStatus();
        }
    }
}