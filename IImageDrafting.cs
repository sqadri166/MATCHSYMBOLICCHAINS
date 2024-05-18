using System;
using System.Collections.Generic;
/// <summary>
/// All Design implementation must be C++ AI no C# so the Open Proxy Gateway to communicate to Chips 
/// https://www.tensorflow.org/api_docs/cc
/// </summary>
/// <typeparam name="T"></typeparam>
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





