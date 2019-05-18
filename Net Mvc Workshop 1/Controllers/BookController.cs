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
        /// 編輯書籍資料頁面
        /// </summary>
        /// <returns></returns>
        public ActionResult UpdateBook(int id)
        {
            var books = Models.BookService.bookData;
            var book = books.Find(x => x.BOOK_ID == id);
            ViewBag.BookClassSelectList = bookClassService.GetBookClassSelectList(book.BOOK_CLASS_ID);
            ViewBag.MemberSelectList = memberService.GetMemberSelectList();
            ViewBag.BookStatusSelectList = bookStatusService.GetBookStatusSelectList();
            ViewBag.book = book;
            return View();
        }

        /// <summary>
        /// 刪除書籍資料事件
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult DeleteBook(int id)
        {
            var books = Models.BookService.bookData;
            var removeList = books.Find(x => x.BOOK_ID == id);
            books.Remove(removeList);
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