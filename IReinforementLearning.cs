using Tensorflow;



public enum ReinforcmentType
{
    Autonomous,
    Drive ,
    Pick,
    Cut,
    Clean,
    Bite,
    MeasureForME,

    TypeForme ,
    ReplyEmailForMe,
    SenseObjectsForMe,

    CameraDetectionCapacity



}

interface IReinforcementLearning 
{

       
 
       ReinforceDataAnalytics GenerateAnalyticsFromData(ModelData[] modelData , LearningAgent learningAgent );
       ReinforceDataAnalytics GenerateFilteredAnalytics(ModelData[] modelData , LearningAgent learningAgent);
       
}

public class LearningAgent
{
     public required ActionPerformed[] Rewards {get;set;}
     public Step SetNextStep {get;set;}


}

public class Step
{
   public int StepID {get;set;}
   public string StepDescription {get;set;}
   public ModelData StepInputs {get;set;}
   public ModelData StepOutputs {get;set;}  

}

public class ActionPerformed
{
    public required ModelData Action {get;set;}
    public decimal RewardPercentage {get;set;}

    public decimal RegressionCalulation {get;set;}

     public ActionPerformed(ModelData modelData)
     {
           this.Action= modelData;

     }  

    public decimal PerformCalculationForAction (ModelData modelData, ReinforcmentType type) {

      /// <summary>
      /// implementatiuon required 
      /// </summary>
        return  this.RegressionCalulation;

    }


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

