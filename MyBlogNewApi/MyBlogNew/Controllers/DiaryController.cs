using MyBlogNew.Common;
using MyBlogNew.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace MyBlogNew.Controllers
{
    public class DiaryController : ApiController
    {
        //
        // GET: /Diary/
        /// <summary>
        /// 获取日记列表
        /// </summary>
        /// <returns></returns>
        public List<diary> GetDiaries(int pageIndex = 0,int pageSize = 0)
        {
            try
            {
                using (var entity = new MyBlogNewEntities())
                {
                    List<diary> ls_diary = entity.diaries.OrderBy(x => x.Id).Skip(pageIndex * pageSize).Take(pageSize).ToList();
                    if (ls_diary.Count == 0)
                    {
                        return ls_diary;
                    }
                    return ls_diary;
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

    }
}
