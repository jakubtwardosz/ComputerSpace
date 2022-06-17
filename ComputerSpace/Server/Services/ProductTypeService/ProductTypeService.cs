namespace ComputerSpace.Server.Services.ProductTypeService
{
    public class ProductTypeService : IProductTypeService
    {
        private readonly DataContext _context;

        public ProductTypeService(DataContext dataContext)
        {
            _context = dataContext;
        }

        public async Task<ServiceResponse<List<ProductType>>> GetProductTypes()
        {
            var productTypes = await _context.ProductTypes.ToListAsync();
            return new ServiceResponse<List<ProductType>> { Data = productTypes };

        }
    }
}
