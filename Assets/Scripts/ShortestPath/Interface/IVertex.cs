using UnityEngine;
using System.Collections.Generic;

namespace Exam.ShortestPath
{
  public interface IVertex
  {
    string Name { get; }

    Vector2 Position { get; }
  }
}
