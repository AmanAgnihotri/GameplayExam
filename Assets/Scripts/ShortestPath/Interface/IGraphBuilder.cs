namespace Exam.ShortestPath
{
  public interface IGraphBuilder
  {
    IGraphBuilder AddVertex (IVertex vertex);

    IGraphBuilder AddEdge (IVertex from, IVertex to);

    IGraph Build ();
  }
}
