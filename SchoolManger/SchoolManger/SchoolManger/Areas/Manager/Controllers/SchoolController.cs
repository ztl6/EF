using ISchoolBLL;
using Model;
using SchoolBLL;
using SchoolManger.Models.School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolManger.Areas.Manager.Controllers
{
    public class SchoolController : Controller
    {
        // GET: Manager/School
        private ISchoolBll bll = new SchoolBll();

        [HttpGet]
        public ActionResult Index(string search = "")
        {
            var list = bll.GetDataByTitle(search);
            ViewBag.Search = search;
            return View(list);
        }
        [HttpGet]
        public ActionResult Add()
        {
            return View(new SchoolAddModel());
        }

        [HttpPost]
        public ActionResult Add(SchoolAddModel model)
        {
            if (ModelState.IsValid) //这个判断是判断我们表单元素存值是否满足了约束
            {
                var res = bll.Add(new roles
                {
                    posts = model.posts
                });
                if (res > 0)
                    return Content("<script>alert('新增成功');location.href='../../../Manager/School/index'</script>");
            }
            //不满足约束的
            return View(model);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var data = bll.GetDataById(id);

            return View(new SchoolEditModel
            {
                Id = data.id,
                Posts = data.posts
            });
        }

        [HttpPost]
        public ActionResult Edit(SchoolEditModel model)
        {
            if (ModelState.IsValid)
            {
                var res = bll.Edit(new roles
                {
                    id = model.Id,
                    posts = model.Posts
                });
                if (res > 0)
                    return Content("<script>alert('编辑成功');location.href='../../../Manager/School/index'</script>");
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            var data = bll.GetDataById(id);
            var res = bll.Delete(data);
            return Json(res > 0);
        }

        [HttpGet]
        public ActionResult IsExits(string posts)
        {
            var result = bll.IsExist(posts);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

    }
}