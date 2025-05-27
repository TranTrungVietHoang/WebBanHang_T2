using WebBanHang_T2.Models;
using System.Collections.Generic;

namespace WebBanHang_T2.Repositories
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories();
    }
}
