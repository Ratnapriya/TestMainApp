using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Abbott.Services.Platform.Common.Json
{
    [ExcludeFromCodeCoverage]
    public static class Serialization
    {
        public static JsonSerializerSettings TolerantJsonSerializerSettings = new JsonSerializerSettings()
        {
            //Adding Comment for test
            NullValueHandling = NullValueHandling.Ignore,
            MissingMemberHandling = MissingMemberHandling.Ignore,
            Error = (object sender, Newtonsoft.Json.Serialization.ErrorEventArgs errorEventArgs) =>
            {
                Console.WriteLine($"Serialization Error: {errorEventArgs.CurrentObject}");
                errorEventArgs.ErrorContext.Handled = true;
            }
        };

        public static JsonSerializer TolerantJsonSerializer = new JsonSerializer()
        {
            NullValueHandling = NullValueHandling.Ignore,
            MissingMemberHandling = MissingMemberHandling.Ignore
        };
    }
}
