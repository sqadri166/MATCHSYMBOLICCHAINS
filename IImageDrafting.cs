using System;
using System.Collections.Generic;

interface IImageDrafting<T> where T : ImageClass
{
     ImageClass[]  ExtractImagesFromImageHint(RightArmMovements rightArmMovements );
   
     ImageClass[]  ExtractImagesFromImageHint(LeftArmMovements rightArmMovements );


}

public class RightArmMovements
{

    public ImageClass[] OriginalCapturedFromCameraRightArms {get;set;}

}

public class LeftArmMovements 
{

   public ImageClass[] OriginalCaptureFromdLeftArmCamera {get;set;}

}





