using MatchedProfileImages;

/// <summary>
/// ALL C++ Players and Layers 
/// A Player is AI ACTION PLAYER 
/// 
/// </summary>
/// <typeparam name="T"></typeparam>
interface ICognitiveLayer<T> where T : CognitiveAnalytics {

   void PerformLeftNeuralCognitiveFunctions(ICognitiveBehavior cognitiveBehavior , CognitiveAnalytics cognitiveAnalytics);



}

interface ICognitiveAnalytics<T> where T : CognitiveBrainAreaClassification 
{
   
      void PerformCognitiveAnalysis(ICognitiveBehavior cognitiveBehavior , CognitiveAnalytics cognitiveAnalytics);


}



interface CognitiveBrainAreaClassification
{
      INeuralGraph<GraphNode> IdentifyNeuralNetwork(CognitiveAreaClassification classification ) ;



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



