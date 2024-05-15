using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using MethodBoundaryAspect.Fody.Attributes;
using System.Collections.Generic;
public interface ICognitiveBehavior
{
    
    public CognitiveAnalytics FindActionBehavior(CognitiveAnalytics cognitiveAnalytics);
    public CognitiveAnalytics FindBodyAttributes(CognitiveAnalytics cognitiveAnalytics) ; 
    public CognitiveAnalytics FindNeuralActionForBot(CognitiveAnalytics cognitiveAnalytics , Bot bot) ;



}

public class Bot
{
  public string Name { get; set; }
  public string Description { get; set; }
  public Guid? ID {get; set;}

  public List<BotAction> BotActions {get;set;} 


}

public class BotAction
{

        public string ActionName { get; set;}
        public Matrix ActionMatrixAssigned{get;set;}

        public Guid CurrentBotActionID {get;set;}
        public List<string> ActionSteps {get;set;}

}