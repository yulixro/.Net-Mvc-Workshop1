using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Net_Mvc_Workshop_1.Controllers
{
    public class BookController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            Init();
            var books = Models.BookService.bookData;
            ViewBag.Books = books;
            Models.BookClassService bookClassService = new Models.BookClassService();
            ViewBag.BookClassSelectList = bookClassService.GetBookClassSelectList();
            Models.MemberService memberService = new Models.MemberService();
            ViewBag.MemberSelectList = memberService.GetMemberSelectList();
            Models.BookStatusService bookStatusService = new Models.BookStatusService();
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
            Models.BOOK_DATA result = new Models.BOOK_DATA();
            return View(result);
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
            Models.BookService bookService = new Models.BookService();
            Models.BookClassService bookClassService = new Models.BookClassService();
            Models.MemberService memberService = new Models.MemberService();
            Models.BookStatusService bookStatusService = new Models.BookStatusService();
            bookService.GetBook();
            bookClassService.GetBookClass();
            memberService.GetMember();
            bookStatusService.GetStatus();
        }
    }
}