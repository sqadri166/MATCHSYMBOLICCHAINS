interface IGenerativeCustomLayer<T>  where T: DataInputs 
{

   public CustomLayer  GenerateCustomLayerForData(DataInputs inputs , ConditionalClause clauses);


}

public class CustomLayer
{
}

public class ConditionalClause
{
}

public class DataInputs
{
}