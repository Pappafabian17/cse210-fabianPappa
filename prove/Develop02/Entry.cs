public class Entry
{ 
public string  _date ;
public string  _promptText = "";
public string _entryText = "";

public string _feeling = "";

public Entry(){

}
public void Display()
{
  Console.WriteLine($"{_date} - Prompt: {_promptText} {_entryText} and i felt {_feeling} today" );
}
}