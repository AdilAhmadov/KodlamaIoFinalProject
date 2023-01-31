using EntityLayer.Models;
using Refit;

namespace BlazorApp_WebUI.DataAccess
{
    public interface IProductService
    {
        [Get("/Products")]
        Task<List<Product>> GetAllProduct();

        [Get("/Products/{id}")]
        Task<Product> GetProductById(int id);


    }
}
