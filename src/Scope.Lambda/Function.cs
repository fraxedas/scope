using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace Scope.Lambda
{
    public class Function
    {
        
        public object FunctionHandler()
        {
            var result = Library.Hello.World();
            LambdaLogger.Log(result);

            return new
            {
                isBase64Encoded = true,
                statusCode = 200,
                body = result
            };
        }
    }
}
