public class Video
{
  public string _title = "";
  public string _author = "";
  public int _length ;
  public List<Comment> Comments = new List<Comment>();

  public Video(string title, string author, int length)
  {
    _title = title;
    _author = author;
    _length = length;

  }

  public void AddComment(Comment comment)
  {
    Comments.Add(comment);
  }
  public int GetComments()
  {
    return Comments.Count;
  }
}