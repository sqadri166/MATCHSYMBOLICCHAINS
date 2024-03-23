using System;
using System.Collections.Generic;
using MatchedProfileImages;
using OpenCV.Net;
using Xla;


/*
Remember 
Certainly! Reinforcement Learning (RL) is a fascinating field within Machine Learning that focuses on learning optimal actions based on rewards in a given environment. If you’re interested in implementing RL algorithms in C++, here are a couple of resources you might find helpful:
AI-Toolbox: This C++ library provides reinforcement learning and planning algorithms. It supports both single and multi-agent problems, as well as partial observability. The library is designed for simplicity and clarity, and it even has Python bindings for those who prefer Python. You can find the AI-Toolbox on GitHub here1.
rllib: Another interesting C++ template-based library oriented toward value function estimation. It promotes generic programming to align the mathematics of reinforcement learning with their implementation. You can explore rllib and find a short example in the paper here2.
Remember that RL involves concepts like reward functions, value functions, and policy optimization, so diving into the details will be both challenging and rewarding! 🚀🤖

*/

public enum ApplySerachAlgorithm
{
   BFSRule ,
   FullScan ,
   VisitAllLeftChildCriteria ,
   VisitAllRightCriteria ,
   DFS , 



}


public enum ApplyLayers 
{
   NativeCPlusPlus ,
   NativePython,


}

public enum APIUsage 
{
    Copilot ,
    Vertex ,
    Generic , 

}




public enum MachineLearningApplied
{
    ReinforcementLearning ,
    DecisionTree ,


         
  

}


public class SearchRuleCriteria 
{
    public string? SearchID {get;set;}
    public string? serachExpression {get;set;}
    public GraphNode? LookForGraphInside {get;set;}

    public ApplySerachAlgorithm? SearchTechnique {get;set;}
    
   
}
