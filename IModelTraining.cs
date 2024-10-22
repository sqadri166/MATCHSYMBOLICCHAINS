
using System.Globalization;
using System.IO;
using System.Collections.Generic;

/// <summary>
/// Raw Data Search to IDentofy as Clusters
/// </summary>

public class RawData
{
    public byte[] Data {get;set;}
    public string RawDataPath {get;set;}  
    
    public int startIndex {get;set;}
    public int endIndex {get;set;}
}

public class ModelData
{
    public string ModelDataKey { get; set; } 
    public string ModelName { get; set;}
    public string ModelType { get; set;}
    public Dictionary<string,string> DataNodes {get;set;}   
    

}

interface IModelTrianing<T> 
{
   public ModelData[] SearchAndFetchClusterData(RawData data);
   public ModelData[] AnomallyDetection(RawData data);
    



}

public class TraingModel<T> : IModelTrianing<T> where T : RawData
{
    public ModelData[] AnomallyDetection(RawData data)
    {
        throw new NotImplementedException();
    }

    public ModelData[] SearchAndFetchClusterData(RawData data)
    {
        throw new NotImplementedException();
    }
} 