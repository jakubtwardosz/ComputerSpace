namespace ComputerSpace.Server.Services.ProductTypeService
{
    public interface IProductTypeService
    {
        Task<ServiceResponse<List<ProductType>>> GetProductTypes();
        Task<ServiceResponse<List<ProductType>>> AddProductTypes(ProductType productType);
        Task<ServiceResponse<List<ProductType>>> UpdateProductTypes(ProductType productType);

    }
}
