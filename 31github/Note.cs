public class Note
{
    public string Title { get; set; }
    public string Content { get; set; }

    public Note(string title, string content)
    {
        Title = title;
        Content = content;
    }
}
