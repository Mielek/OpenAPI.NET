// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. 

using Microsoft.OpenApi.Models;

namespace Microsoft.OpenApi.Validations.Rules
{
    /// <summary>
    /// The validation rules for <see cref="OpenApiMediaType"/>.
    /// </summary>
    /// <remarks>
    /// Removed this in v1.3 as a default rule as the OpenAPI specification does not require that example
    /// values validate against the schema.  Validating examples against the schema is particularly difficult
    /// as it requires parsing of the example using the schema as a guide.  This is not possible when the schema
    /// is ref'd.  Even if we fix this issue, this rule should be treated as a warning, not an error
    /// Future versions of the validator should make that distinction.
    /// Future versions of the example parsers should not try an infer types.
    /// Example validation should be done as a separate post reading step so all schemas can be fully available.
    /// </remarks>
    [OpenApiRule]
    public static class OpenApiMediaTypeRules
    {
       
        // add more rule.
    }
}
