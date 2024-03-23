using System;
using MatchedProfileImages;

using System;
using System.Collections.Generic;

public class Box
{
    public int BoxID {get;set;}
    public ImageClass ImageClassification {get;set;}

    public LexicalToken lexicalToken {get;set;}


    public string ImagePath {get;set;}
    public  String WordOrLetterCorresposnding {get;set;}

    public bool ApplyEncrytionCodeOnBox {get;set;}
    public int RowIndex {get;set;}

    public int ColIndex {get;set;}

    public string BoxTagID {get;set;}

    public Word Alphabet {get;set;} 




}
