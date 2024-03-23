using System;
using System.Collections.Generic;
using MatchedProfileImages;

interface INeuralGraph<T> where T : GraphNode
{
     public GraphNode FindGrapNodeById(int nodeTagID);
     public GraphNode FindGraphNodeBy(SearchRuleCriteria searchQueryRule);

     public GraphNode AddGraphNode(GraphNode node);

     public int DeleteGraphNode(GraphNode node);
   
     public GraphNode DeleteAllChildBelow(GraphNode node);

     public GraphNode InsertNodeLeftChild(GraphNode node);

     public GraphNode InsertNodeRightChild(GraphNode node);


     
     


}