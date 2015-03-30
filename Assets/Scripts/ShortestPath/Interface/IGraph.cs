using System.Collections.Generic;

namespace Exam.ShortestPath
{
  public interface IGraph
  {
    IList<IVertex> this [IVertex vertex] { get; }

    void AddVertex (IVertex vertex);

    void AddEdge (IVertex from, IVertex to);
  }
}
