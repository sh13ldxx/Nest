namespace WebApplication1.ViewModel
{
    public class ProductVm
    {
        public int Id { get; internal set; }
        public string Name { get; internal set; }
        public string Category { get; internal set; }
        public string Image { get; internal set; }
        public double Price { get; internal set; }
        public bool IsDeleted { get; internal set; }

    }
}
