using OpenCV.Net;

interface IImageCutter<T> where T : IplImage
{
     void SetImage(T image);
     decimal CalculateBase64Load(T image);
     List<IplImage> SeggregateImages(T image); 
     IplImage MergeAllImages(List<T> values);
     
     IplImage CutImageAnVerify(T image);

     IplImage RemovePartOfImage(T image , string base64pattern);
      

     IplImage FindRespectiveMatchPatterns(Graph graph, string base64pattern);

     IplImage ReplacePartImage(string base64pattern, string pattern);



   
    
}