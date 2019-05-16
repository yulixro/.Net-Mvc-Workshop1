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

        /// <summary>
        /// 主頁面(書籍資料清單)
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// 查詢書籍資料事件
        /// </summary>
        /// <param name="form"></param>
        /// <returns></returns>

        [HttpPost()]
        public ActionResult Index(Models.BookSearchArg bookSearchArg)
        {
            var books = Models.BookService.bookData;
            if (bookSearchArg.BOOK_NAME != null)
            {
                books = books.FindAll(x => x.BOOK_NAME.Contains(bookSearchArg.BOOK_NAME));
            }
            if (bookSearchArg.BOOK_CLASS_ID != null)
            {
                books = books.FindAll(x => x.BOOK_CLASS_ID == bookSearchArg.BOOK_CLASS_ID);
            }
            if (bookSearchArg.USER_ID != null)
            {
                books = books.FindAll(x => x.BOOK_KEEPER == bookSearchArg.USER_ID);
            }
            if (bookSearchArg.CODE_ID != null)
            {
                books = books.FindAll(x => x.BOOK_STATUS == bookSearchArg.CODE_ID);
            }
            ViewBag.Books = books;
            ViewBag.BookClassSelectList = bookClassService.GetBookClassSelectList();
            ViewBag.MemberSelectList = memberService.GetMemberSelectList();
            ViewBag.BookStatusSelectList = bookStatusService.GetBookStatusSelectList();
            return View("Index");
        }

        /// <summary>
        /// 新增書籍資料頁面
        /// </summary>
        /// <returns></returns>
        [HttpGet()]
        public ActionResult InsertBook()
        {
            Init();
            ViewBag.BookClassSelectList = bookClassService.GetBookClassSelectList();
            ViewBag.MemberSelectList = memberService.GetMemberSelectList();
            ViewBag.BookStatusSelectList = bookStatusService.GetBookStatusSelectList();
            return View();
        }

        /// <summary>
        /// 新增書籍資料事件
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        [HttpPost()]
        public ActionResult InsertBook(Models.BOOK_DATA book)
        {
            ///後端驗證
            if (ModelState.IsValid)
            {
                Models.BookService.bookData.Add(book);
                
            }
            return RedirectToAction("Index", "Book", null);
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