using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SchoolIDAL
{
    public interface IBasaDal<T> where T : class, new()
    {
        int Add(T model, bool isSaved = true);

        int Edit(T model, bool isSaved = true);

        int Delete(T model, bool isSaved = true);

        IList<T> Query();
        IList<T> Query(Expression<Func<T, bool>> whereLambda);
        T Query(int id);

        int SaveData(); //用于保存数据的方法,返回的内容就是受影响行数
    }
}
