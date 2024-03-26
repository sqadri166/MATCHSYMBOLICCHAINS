using System;
using System.Collections.Generic;


public class SentenceAnalysis 
{
    public Guid? SentenceLogicID {get;set;}

    public string Sentence {get;set;}

    public bool IsValidToAnalyse {get;set;}


    public APIUsage UseAPIToAnalyze {get;set;}

    public DateTime SentenceTimeStampSubmitted {get;set;}




}