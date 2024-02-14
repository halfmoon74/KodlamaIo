using KodlamaIo.Business.Abstracts;
using KodlamaIo.DataAcess.Abstracts;
using KodlamaIo.Entities;

namespace KodlamaIo.Business.Concrates
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            //İş kodları yazılır
            var result = _categoryDal.GetAll();
            return result;
        }

        public List<Category> GetCategoryId(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
