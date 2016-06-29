namespace MadLib.Objects
{
  public class FillInVariables
  {
    private string _name;
    public string GetName()
    {
      return _name;
    }
    public void SetName(string newName)
    {
      _name = newName;
    }

    private string _adjective;
    public string GetAdjective()
    {
      return _adjective;
    }
    public void SetAdjective(string newAdjective)
    {
      _adjective = newAdjective;
    }

  }
}
