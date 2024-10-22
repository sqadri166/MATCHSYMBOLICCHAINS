using System.Collections.Generic;
using System.Linq;


interface IClassificationData 
{
      ModelData[] ClassifyAndFeedDataModel(RawData data);  
      ModelData[] CreateTestDataForClassification(RawData data);




}