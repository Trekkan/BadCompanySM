using BCM.Models;

namespace BCM.Commands
{
  public class ListPlayersClientInfo : ListPlayers
  {
    public override void displayPlayer(PlayerInfo _pInfo)
    {
      string output = "";
      output += new ClientInfoList(_pInfo, _options).Display(_sep);

      SendOutput(output);
    }
  }
}
