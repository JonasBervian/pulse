using System.Text.Json.Serialization;

namespace Pulse.Api;

// Every type returned or received by an endpoint must be registered here (Native AOT).
// T2.1.4 adds CreateLinkRequest and LinkResponse.
[JsonSerializable(typeof(string))]
internal sealed partial class AppJsonSerializerContext : JsonSerializerContext;