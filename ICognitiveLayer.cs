using MatchedProfileImages;

/// <summary>
/// ALL C++ Players and Layers 
/// A Player is AI ACTION PLAYER 
/// 
/// </summary>
/// <typeparam name="T"></typeparam>
interface ICognitiveLayer<T> where T : CognitiveAnalytics {

/// <summary>
/// Perfrom Cognitive Anlystics on Model Data Apply Cognitive behavior dependency and return Matrix data 
/// </summary>
/// <param name="cognitiveBehavior"></param>
/// <param name="cognitiveAnalytics"></param>
/// <param name="modelData"></param>
/// <returns></returns> <summary>
/// 
/// </summary>
/// <param name="cognitiveBehavior"></param>
/// <param name="cognitiveAnalytics"></param>
/// <param name="modelData"></param>
/// <returns></returns>
     Matrix PerformLeftNeuralCognitiveFunctions(ICognitiveBehavior cognitiveBehavior , CognitiveAnalytics cognitiveAnalytics ,ModelData[] modelData);



}

interface ICognitiveAnalytics<T> where T : CognitiveBrainAreaClassification 
{
   
      Matrix PerformCognitiveAnalysis(ICognitiveBehavior cognitiveBehavior , CognitiveAnalytics cognitiveAnalytics, ModelData[] modelData);


}



interface CognitiveBrainAreaClassification {
      // IDentify Cognitive Area and perfrom classification and generate neural Graph
            INeuralGraph<GraphNode> IdentifyNeuralNetwork(CognitiveAreaClassification classification, ModelData[] modelData ) ;
            INeuralGraph<GraphNode> IdentifyMoreClusters(CognitiveAreaClassification classification,ModelData[] modelData ) ;


}

public class CognitiveAreaClassification
{
      public Guid? AreaClassificationID   { get; set; }
      List<Matrix> AreaClassificatonMatrix { get; set; }
}

public class CognitiveAnalytics
{
      public List<GraphNode> GNNWorkFlow {get;set;}

      public bool Processed {get;set;}

}



