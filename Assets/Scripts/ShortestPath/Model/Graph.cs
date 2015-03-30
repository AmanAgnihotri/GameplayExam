using System.Collections.Generic;

namespace Exam.ShortestPath
{
  public class Graph : IGraph
  {
    public IList<IVertex> this [IVertex vertex] { get { return Values [vertex]; } }

    private IDictionary<IVertex, IList<IVertex>> Values { get; set; }

    public Graph ()
    {
      Values = new Dictionary<IVertex, IList<IVertex>> ();
    }

    public void AddVertex (IVertex vertex)
    {
      if (!Values.ContainsKey (vertex))
      {
        Values [vertex] = new List<IVertex> ();
      }
    }

    public void AddEdge (IVertex from, IVertex to)
    {
      if (!Values.ContainsKey (from))
      {
        AddVertex (from);
      }

      var edges = Values [from];

      if (!edges.Contains (to))
      {
        edges.Add (to);
      }
    }
  }
}
