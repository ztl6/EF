using ISchoolBLL;
using Model;
using SchoolDAl;
using SchoolIDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBLL
{
    public class SchoolBll : ISchoolBll
    {
        private ISchoolDal dal = new SchoolDal();


        public int Add(roles model, bool isSaved = true)
        {
            return dal.Add(model, isSaved);
        }

        public int Delete(roles model, bool isSaved = true)
        {
            return dal.Delete(model, isSaved);
        }

        public int Edit(roles model, bool isSaved = true)
        {
            return dal.Edit(model, isSaved);
        }

        public IList<roles> GetAll()
        {
            return dal.Query();
        }

        public roles GetDataById(int id)
        {
            return dal.Query(id);
        }

        public IList<roles> GetDataByTitle(string title)
        {
            return dal.Query(r => r.posts.Contains(title));
        }


        public bool IsExist(string posts)
        {
            return !dal.Query(r => r.posts.Equals(title)).Any();
        }
    }
}
