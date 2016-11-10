﻿using MovieResources.Filters;
using MovieResources.Helpers;
using System.Web.Mvc;

namespace MovieResources.Controllers
{
    public class CommentController : Controller
    {
        #region 创建评论
        //
        // GET: /Comment/Create/
        [Signedin]
        public ActionResult Create(string content, string movie, string returnurl)
        {
            if (!string.IsNullOrEmpty(content) && MovieManager.Exist(movie) && User.Identity.IsAuthenticated)
            {
                CommentManager.Create(content, movie, AccountManager.GetId(CookieHepler.GetCookie("user")));
            }
            return RedirectToLocal(returnurl);
        }
        #endregion

        #region 删除评论
        //
        // GET: /Comment/Delete/
        [Signedin]
        public ActionResult Delete(string id, string returnurl)
        {
            //MR_DataClassesDataContext _db = new MR_DataClassesDataContext();
            MRDataEntities _db = new MRDataEntities();
            if (CommentManager.Exist(id))
            {
                return RedirectToAction("NotFound", "Error");
            }
            else
            {
                CommentManager.Delete(id);
            }
            return RedirectToLocal(returnurl);
        }
        #endregion

        #region 帮助程序
        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (!Url.IsLocalUrl(returnUrl) && !string.IsNullOrEmpty(returnUrl) && !string.IsNullOrWhiteSpace(returnUrl))
            {
                return Redirect(returnUrl);
            }
            return RedirectToAction("Index", "Home");
        }
        #endregion
    }
}