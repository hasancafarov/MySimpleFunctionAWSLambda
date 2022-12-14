using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace MySimpleFunction;

public class DisplayNewUser
{
    
    /// <summary>
    /// A simple function that takes a string and does a ToUpper
    /// </summary>
    /// <param name="input"></param>
    /// <param name="context"></param>
    /// <returns></returns>
    public string FunctionHandler(NewUser input, ILambdaContext context)
    {
        LambdaLogger.Log($"Calling function name: {context.FunctionName}\n"); 
        return $"Welcome: {input.FirstName} {input.LastName}";
    }
}
