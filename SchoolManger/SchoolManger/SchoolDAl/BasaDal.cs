using Model;
using SchoolIDAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDAl
{
    public class BasaDal<T> : IBasaDal<T> where T : class, new()
    {
        private SchoolManagementDBEntities db = new SchoolManagementDBEntities();

        public int Add(T model, bool isSaved = true)
        {
            db.Entry(model).State = EntityState.Added;
            if (isSaved)
                return SaveData();
            return 0; //当我们把isSaved的值传false,代表我们的数据暂时存储到缓冲区中
            //并不会更新到数据库当中
        }

        public int Delete(T model, bool isSaved = true)
        {
            db.Entry(model).State = EntityState.Deleted;
            if (isSaved)
                return SaveData();
            return 0; //当我们把isSaved的值传false,代表我们的数据暂时存储到缓冲区中
            //并不会更新到数据库当中
        }

        public int Edit(T model, bool isSaved = true)
        {
            db.Entry(model).State = EntityState.Modified;
            if (isSaved)
                return SaveData();
            return 0; //当我们把isSaved的值传false,代表我们的数据暂时存储到缓冲区中
            //并不会更新到数据库当中
        }

        public IList<T> Query()
        {
            return db.Set<T>().ToList();
        }

        public IList<T> Query(Expression<Func<T, bool>> whereLambda)
        {
            return db.Set<T>().Where(whereLambda).ToList();
        }

        public T Query(int id)
        {
            return db.Set<T>().Find(id);
        }

        public int SaveData()
        {
            return db.SaveChanges();
        }
    }
}
