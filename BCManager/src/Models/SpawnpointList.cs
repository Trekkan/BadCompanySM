﻿using System;
using System.Collections.Generic;

namespace BCM.Models
{
  [Serializable]
  public class SpawnpointList : AbstractList
  {
    private List<Vector3i> spawnpoints = new List<Vector3i>();

    public SpawnpointList(PlayerInfo _pInfo, Dictionary<string, string> _options) : base(_pInfo, _options)
    {
    }

    public override void Load(PlayerInfo _pInfo)
    {
      foreach (Vector3i sp in _pInfo.PDF.spawnPoints)
      {
        spawnpoints.Add(sp);
      }
    }

    public override string Display(string sep = " ")
    {
      string postype = GetPosType();
      bool first = true;
      string output = "Spawnpoints:{";
      foreach (Vector3i sp in spawnpoints)
      {
        if (!first) { output += sep; } else { first = false; }
        output += " Bed:" + Convert.PosToStr(sp, postype);
      }
      output += "}";

      return output;
    }
  }
}
