using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISchoolBLL
{
    public interface ISchoolBll
    {
        int Add(roles model, bool isSaved = true);

        int Edit(roles model, bool isSaved = true);

        int Delete(roles model, bool isSaved = true);

        IList<roles> GetAll();

        IList<roles> GetDataByTitle(string title);

        //Func是委托,它带有的2个内容T,bool 分别为 T: 我们声明的这个变量是什么类型的
        //a => xxxxx   这个a就是参数,用于我们给后面实现代码传递的
        //bool 代表的是整个这个表达式的返回值是什么类型的

        roles GetDataById(int id);

        bool IsExist(string posts);
    }
}
