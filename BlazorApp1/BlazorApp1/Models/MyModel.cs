namespace BlazorApp1.Models
{
    public class MyModel
    {
        public MyModel()
        {
                
        }

        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string Name { get; set; }

        public string DisplayName { get => Name; }
    }
}
