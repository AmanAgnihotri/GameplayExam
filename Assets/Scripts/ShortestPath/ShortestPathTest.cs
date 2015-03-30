using UnityEngine;

namespace Exam.ShortestPath
{
  public class ShortestPathTest : MonoBehaviour
  {
    public void Start ()
    {
      IVertex vertexA = new Vertex ("A", new Vector2 (0, 0));
      IVertex vertexB = new Vertex ("B", new Vector2 (1, 2));
      IVertex vertexC = new Vertex ("C", new Vector2 (3, 4));
      IVertex vertexD = new Vertex ("D", new Vector2 (2, 1));
      IVertex vertexE = new Vertex ("E", new Vector2 (4, 1));
      IVertex vertexF = new Vertex ("F", new Vector2 (5, 3));

      IGraphBuilder graphBuilder = new GraphBuilder ();

      IGraph graph = graphBuilder
        .AddVertex (vertexA).AddVertex (vertexB)
        .AddVertex (vertexC).AddVertex (vertexD)
        .AddVertex (vertexE).AddVertex (vertexF)
        .AddEdge (vertexA, vertexB)
        .AddEdge (vertexB, vertexC)
        .AddEdge (vertexB, vertexD)
        .AddEdge (vertexC, vertexE)
        .AddEdge (vertexD, vertexE)
        .AddEdge (vertexD, vertexF)
        .Build ();

      var path = ShortestPath.FindPath (graph, vertexA, vertexF);

      if (path != null)
      {
        foreach (var vertex in path)
        {
          Debug.Log (vertex);
        }
      }
      else
      {
        Debug.Log ("No Path Found");
      }
    }
  }
}
