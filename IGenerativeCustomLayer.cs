interface IGenerativeCustomLayer<T>  where T: DataInputs 
{

   public CustomLayer  GenerateCustomLayerForData(DataInputs inputs , ConditionalClause clauses);


}

public class CustomLayer
{
  public List<BotAction>? Actions{ get; set; }
  public Dictionary<string,string>? ActionKeyItemDescription { get; set; }
 
 
}

public class ConditionalClause
{

    public List<string>? ConditionalExpressions {get; set;} 
    public bool OperaionPerformed {get; set;}
    public bool OperationSatisfied {get; set;}
    public string? ErrorMessage {get; set;}

}

public class DataInputs
{
   public List<List<int>>? DataInputsInterval { get; set; }  
   public Dictionary<int,string>? keyValueMappers {get;set;}

}