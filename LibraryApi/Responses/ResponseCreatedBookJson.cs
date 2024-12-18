namespace LibraryApi.Responses
{
    public class ResponseCreatedBookJson
    {
        public string Id { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty.ToString();
        public string Genre { get; set; } = string.Empty.ToString();
        public float Price { get; set; }
        public int StockQuantity { get; set; }
    }
}
