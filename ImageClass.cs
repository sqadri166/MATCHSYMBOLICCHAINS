
using System;

public enum CultureClassificationCode
{
    AsianSignLanguageSymbols ,
    EuropeanSignSymbols ,
    AmericanSignSymbols 

}

public enum ImageDimensions 
{
   TopLeftCurveReadings,
   TopRightBottomReadings,

   BottomLeftReadings,

   BottomRightReadings,


}


public enum  ImageClassificationCode
{
   HandSymbolsDeaf ,
   HandSymbolsNormalActions ,
   LiftingSymbols ,
   DrawSymbols ,
   FacialSymbols,
   
   UtensilSymbols,
   FurnitureSymbols,




    
}

public class ImageClass 
{
    public ImageClassificationCode LookForClassificationCode {get;set;}
    public CultureClassificationCode CurrentCultureClassificationCode {get;set;}
    public int ImageID {get;set;}
    
    public byte[]? ImageSavedinRepo {get;set;}

    public byte[]? ImageFoundinRepo {get;set;}

    public byte[]? dullImages {get;set;}
     
    public bool RegenrateUsingGenerativeAI {get;set;} 

    public string? CorrespondingWord {get;set;} 



}