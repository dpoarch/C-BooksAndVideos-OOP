namespace BooksAndVideos.App.Entities
{
    public interface Entity
    {
        long Id { get; set; }
        string ItemName { get; set; }
        long CustomerId { get; set; }
        int ProductType { get; }
    }
}