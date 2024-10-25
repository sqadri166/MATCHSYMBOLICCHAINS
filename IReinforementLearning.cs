using OpenCV.Net;

interface IReinforcementLearning 
{

       ReinforceDataAnalytics GenerateAnalyticsFromData(ModelData[] modelData);
       ReinforceDataAnalytics GenerateFilteredAnalytics(ModelData[] modelData);

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

