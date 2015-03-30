using UnityEngine;

namespace Exam.ShortestPath
{
  public class ShortestPathTest : MonoBehaviour
  {
    public void Start ()
    {
      var vertexA = Vertex.Create ("A", 0, 0);
      var vertexB = Vertex.Create ("B", 1, 2);
      var vertexC = Vertex.Create ("C", 3, 4);
      var vertexD = Vertex.Create ("D", 2, 1);
      var vertexE = Vertex.Create ("E", 4, 1);
      var vertexF = Vertex.Create ("F", 5, 3);

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
