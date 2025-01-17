// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> The name of a managed cluster SKU. </summary>
    public readonly partial struct ManagedClusterSKUName : IEquatable<ManagedClusterSKUName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ManagedClusterSKUName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ManagedClusterSKUName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string BasicValue = "Basic";

        /// <summary> Basic. </summary>
        public static ManagedClusterSKUName Basic { get; } = new ManagedClusterSKUName(BasicValue);
        /// <summary> Determines if two <see cref="ManagedClusterSKUName"/> values are the same. </summary>
        public static bool operator ==(ManagedClusterSKUName left, ManagedClusterSKUName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ManagedClusterSKUName"/> values are not the same. </summary>
        public static bool operator !=(ManagedClusterSKUName left, ManagedClusterSKUName right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ManagedClusterSKUName"/>. </summary>
        public static implicit operator ManagedClusterSKUName(string value) => new ManagedClusterSKUName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ManagedClusterSKUName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ManagedClusterSKUName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
