namespace BCM.Commands
{
  public class ListProgression : BCCommandAbstract
  {
    public override void Process()
    {
      string output = "";
      //foreach (string name in Archetypes.Instance.GetArchetypeNames())
      //{
      //  output += name + _sep;
      //}
      SendOutput(output);
    }
  }
}