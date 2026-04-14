namespace MansoursBlazor46.Pages
{
    public partial class FirstComponent
    {
        public string Message { get; set; } = "Hello";
        public void ShowMe(string ch)
        {
            Message += ch;
            Console.WriteLine("hello from c# to console");
        }
    }
}
