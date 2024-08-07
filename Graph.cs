using System;
using System.Collections.Generic;
using System.Data;
using MatchedProfileImages;
namespace MatchedProfileImages 
{

// Generate thousands of actions of Deaf Symbols 
/// <summary>

/// </summary>

// This Grpah will help adding edges of Data and Visting Them
public class GraphNode {

	// No. of vertices
	private int _V;

	// Adjacency Lists
	LinkedList<int>[] _adj;
	LinkedList<ImageClass>[] _adjMatched ;

	public GraphNode(int V)
	{
		_adj = new LinkedList<int>[ V ];
		_adjMatched = new LinkedList<ImageClass>[V];
		for (int i = 0; i < _adj.Length; i++) {
			_adj[i] = new LinkedList<int>();
		}

		for (int i = 0; i < _adjMatched.Length; i++) {
			_adjMatched[i] = new LinkedList<ImageClass>();
		}

		_V = V;
	}

  



	// Function to add an edge into the graph
	public void AddEdge(int v, int w)
	{
		_adj[v].AddLast(w);
	}

	public void AddEdge(int v ,ImageClass imageClass)
	{

		_adjMatched[v].AddLast(imageClass);


	}


   // Add imgage Profile to Serach millions of images
   // Adding Profile Images
    


    public List<ImageClass> FindAddSpecificImagesAtVertex(int vertex , ImageClass imageClass)
	{
		List<ImageClass> imageClasses = new List<ImageClass>();
		// visited(By default set as false)
		bool[] visited = new bool[_V];
		for (int i = 0; i < _V; i++)
			visited[i] = false;

		// Create a queue for BFS
		LinkedList<ImageClass> queue = new LinkedList<ImageClass>();

		// Mark the current node as
		// visited and enqueue it
		visited[vertex] = true;
		queue.AddLast(imageClass);
	
		while (queue.Any()) {

			// Dequeue a vertex from queue
			// and print it
			imageClass = queue.First();
			queue.RemoveFirst();
            
			// Get all adjacent vertices of the
			// dequeued vertex s.
			// If an adjacent has not been visited,
			// then mark it visited and enqueue it
			LinkedList<ImageClass> list = _adjMatched[vertex];

			foreach(var val in list)
			{
				if (!visited[val.ImageID]) {
					visited[val.ImageID] = true;
					queue.AddLast(val);
					imageClasses.Add(val);
				}
			}
		}
        return imageClasses;



	}
	// Prints BFS traversal from a given source s
	public void BFS(int s)
	{

		// Mark all the vertices as not
		// visited(By default set as false)
		bool[] visited = new bool[_V];
		for (int i = 0; i < _V; i++)
			visited[i] = false;

		// Create a queue for BFS
		LinkedList<int> queue = new LinkedList<int>();

		// Mark the current node as
		// visited and enqueue it
		visited[s] = true;
		queue.AddLast(s);
	
		while (queue.Any()) {

			// Dequeue a vertex from queue
			// and print it
			s = queue.First();
			Console.Write(s + " ");
			queue.RemoveFirst();

			// Get all adjacent vertices of the
			// dequeued vertex s.
			// If an adjacent has not been visited,
			// then mark it visited and enqueue it
			LinkedList<int> list = _adj[s];

			foreach(var val in list)
			{
				if (!visited[val]) {
					visited[val] = true;
					queue.AddLast(val);
				}
			}
		}
	}

}
}