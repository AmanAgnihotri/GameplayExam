using UnityEngine;

namespace Exam.ShortestPath
{
  public class Vertex : IVertex
  {
    public string Name { get; private set; }

    public Vector2 Position { get; private set; }

    public Vertex (string name, Vector2 position)
    {
      Name = name;
      Position = position;
    }

    public override string ToString ()
    {
      return string.Format ("[{0}, ({1}, {2})]", Name, Position.x, Position.y);
    }

    public static IVertex Create (string name, float x, float y)
    {
      return new Vertex (name, new Vector2 (x, y));
    }
  }
}
