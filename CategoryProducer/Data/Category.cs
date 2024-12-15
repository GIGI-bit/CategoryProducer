namespace CategoryProducer.Data
{
    public class Category : ICategory
    {
        public int Id { get; set; }
        public string? Content { get; set; }
        public List<ICategory>? SubCategories { get; set; }
    }

}
