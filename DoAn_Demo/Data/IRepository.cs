using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_Demo.Data
{
    interface IRepository<T> where T : class
    {
        /// <summary>
        /// thực hiện lấy danh sách
        /// </summary>
        /// <returns>return List</returns>
        IEnumerable<T> GetAll();

        /// <summary>
        /// Get đối tượng theo expression
        /// </summary>
        /// <param name="expression">expression</param>
        /// <returns> if exists return object else return null </returns>
        T GetBy(Expression<Func<T, bool>> expression);

        /// <summary>
        /// delete đối tượng
        /// </summary>
        /// <param name="expression">expression</param>
        void Delete(Expression<Func<T, bool>> expression);

        /// <summary>
        /// delete đối tượng
        /// </summary>
        /// <param name="t">đối tượng cần xóa</param>
        void Delete(T t);

        /// <summary>
        /// update thông tin của đối tượng
        /// </summary>
        /// <param name="t">đối tượng với thông tin mới</param>
        void Edit(T t);

        /// <summary>
        /// tìm kiếm đối tượng theo biểu thức truyền vào
        /// </summary>
        /// <param name="expression">expression</param>
        /// <returns>true if exists else false</returns>
        bool FindBy(Expression<Func<T, bool>> expression);
    }
}
