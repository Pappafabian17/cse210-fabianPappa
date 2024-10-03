public class Person
{
  private string _title;
  private string _firstName;
  private string _lastName;


public Person()
{
  _title  = "";
  _firstName = "Anonymous";
  _lastName = "Unknown";

}

public Person(string firstName, string lastName)
{
  _title = "";
  _firstName = firstName;
  _lastName = lastName;

}

public Person(string title, string firstName, string lastName)
{
  _title = title;
  _firstName = firstName;
  _lastName = lastName;
  
}
//Getters and setters:

public string GetFirstName()
{
  return _firstName;
}
public void SetFirstName(string firstName)
{
  _firstName = firstName;
}
  private string GetFullName()
  {
    return _title + " " + _firstName + " " + _lastName;
  }


  // Get Signatures:
  public string GetInformalSignature()
  {
    return "Thanks " + _firstName;
  }

  public string GetFormalSignature()
  {
    return "Sincerely" + GetFullName();
  }

}