using OpenCV.Net;

interface IImageCutter<T> where T : IplImage
{
     void SetImage(T image);
     decimal CalculateBase64Load(T image);
     List<IplImage> SeggregateImages(T image); 
     IplImage MergeAllImages(List<T> values);
     
     // Cut image from sub Image
     IplImage CutImageAnVerify(T image);

     // Remove part of bae 64 PAttern
     IplImage RemovePartOfImage(T image , string base64pattern);
      

     IplImage FindRespectiveMatchPatterns(Graph graph, string base64pattern);

     IplImage ReplacePartImage(string base64pattern, string pattern);



   
    
}