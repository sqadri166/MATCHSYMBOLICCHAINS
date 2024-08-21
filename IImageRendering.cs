using Tensorflow;
using Tensorflow.Queues;


/// <summary>
/// Use Tensor Flow C++ to generate and identify image and send to BOT Signal Rudino API C++
/// </summary> <summary>
/// 
/// </summary>
public class ImageCutDimensions 
{

    public string? ImageUrlPathFileName {get;set;}
    public decimal InputHeight {get;set;}
    public decimal InputWidth {get;set;}

    public decimal InputMean {get;set;}

    public decimal InputStandardDeviation{get;set;}


}
interface ImageLoading 
{
   public ImageClass[] ApplyTensorFlowToImageFile(ImageCutDimensions imageCutDimensions); 


}
