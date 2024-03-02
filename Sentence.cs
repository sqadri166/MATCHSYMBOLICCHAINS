using MatchedProfileImages;

public class Sentence
{
  
    public Sentence(string currentContextSentence) 
    {
       this.SentenceLine = currentContextSentence;  

    }

    public string? SentenceLine {get;set;}
    public GraphNode? CurrentImageGraphForSentence {get;set;}
    public string? ReverseRead {get;set;}




}