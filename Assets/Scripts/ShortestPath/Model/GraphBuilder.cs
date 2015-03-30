namespace Exam.ShortestPath
{
  public class GraphBuilder : IGraphBuilder
  {
    private IGraph Graph;

    public GraphBuilder ()
    {
      Graph = new Graph ();
    }

    public IGraphBuilder AddVertex (IVertex vertex)
    {
      Graph.AddVertex (vertex);

      return this;
    }

    public IGraphBuilder AddEdge (IVertex from, IVertex to)
    {
      Graph.AddEdge (from, to);

      return this;
    }

    public IGraph Build ()
    {
      return Graph;
    }
  }
}
