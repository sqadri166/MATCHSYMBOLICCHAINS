using Tensorflow;
using Tensorflow.Queues;



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
