using UnityEngine;
using System.Collections.Generic;

namespace Exam.ShortestPath
{
  public static class ShortestPath
  {
    public static Stack<IVertex> FindPath (IGraph graph, IVertex start, IVertex end)
    {
      var previous = new Dictionary<IVertex, IVertex> ();
      var queue = new Queue<IVertex> ();

      queue.Enqueue (start);

      while (queue.Count > 0)
      {
        var current = queue.Dequeue ();
        var vertices = graph [current];

        if (vertices != null)
        {
          foreach (var vertex in vertices)
          {
            if (!previous.ContainsKey (vertex))
            {
              previous [vertex] = current;
              queue.Enqueue (vertex);
            }
          }
        }
      }

      previous [start] = null;

      return GetPathFrom (previous, start, end);
    }

    private static Stack<IVertex> GetPathFrom (IDictionary<IVertex, IVertex> previous, IVertex start, IVertex end)
    {
      Stack<IVertex> result = null;

      if (previous.ContainsKey (end))
      {
        result = new Stack<IVertex> ();

        for (IVertex vertex = end; vertex != null; vertex = previous [vertex])
        {
          result.Push (vertex);
        }
      }

      return result;
    }
  }
}
