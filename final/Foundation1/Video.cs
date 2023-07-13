class Video
{
    public string _title { get; }
    public string _author { get; }
    public int _length { get; }
    public List<Comment> Comments { get; }

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        Comments = new List<Comment>();
    }

    public void AddComment(string name, string text)
    {
        Comment comment = new Comment(name, text);
        Comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return Comments.Count;
    }
}