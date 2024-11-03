using OpenCV.Net;

interface IReinforcementLearning 
{

       ReinforceDataAnalytics GenerateAnalyticsFromData(ModelData[] modelData , LearningAgent learningAgent );
       ReinforceDataAnalytics GenerateFilteredAnalytics(ModelData[] modelData , LearningAgent learningAgent);

}

public class LearningAgent
{
     public required ActionPerformed[] Rewards {get;set;}
     


}

public class ActionPerformed
{
    public required ModelData Action {get;set;}
    public decimal RewardPercentage {get;set;}

}

public class ReinforceDataAnalytics
{

    private readonly Graph _reinforceGraph;

     public ReinforceDataAnalytics(Graph graph) 
     {
              this._reinforceGraph = graph;

     }


     public Graph AnalyzeGraph(SearchRuleCriteria criteria)
     {
            // Provide impelemntaion fo REinforcement Criteria and retrun Graph 

           return _reinforceGraph;
     }


}

