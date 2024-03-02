using System;
using System.Collections.Generic;
using MatchedProfileImages;

interface IImageProcessing<T> where T : ImageClass 
{
   ImageClass[] MergeImages(GraphNode node);
   ImageClass[] MergeImages (Matrix mat); 
   ImageClass[] GenerateAnagramRepositoryOfSymbols(Matrix mat);
   ImageClass[] RotateImagesInGrid(Matrix mat);

   ImageClass UseGenerativeModelData(ImageClass imageClass );

   


    
}