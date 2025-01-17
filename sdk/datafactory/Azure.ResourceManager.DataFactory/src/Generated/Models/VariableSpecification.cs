// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Definition of a single variable for a Pipeline. </summary>
    public partial class VariableSpecification
    {
        /// <summary> Initializes a new instance of VariableSpecification. </summary>
        /// <param name="variableType"> Variable type. </param>
        public VariableSpecification(VariableType variableType)
        {
            VariableType = variableType;
        }

        /// <summary> Initializes a new instance of VariableSpecification. </summary>
        /// <param name="variableType"> Variable type. </param>
        /// <param name="defaultValue"> Default value of variable. </param>
        internal VariableSpecification(VariableType variableType, BinaryData defaultValue)
        {
            VariableType = variableType;
            DefaultValue = defaultValue;
        }

        /// <summary> Variable type. </summary>
        public VariableType VariableType { get; set; }
        /// <summary> Default value of variable. </summary>
        public BinaryData DefaultValue { get; set; }
    }
}
