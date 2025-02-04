// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Support
{

    /// <summary>Gets or sets the blockchain member provision state.</summary>
    public partial struct NodeProvisioningState :
        System.IEquatable<NodeProvisioningState>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Support.NodeProvisioningState Deleting = @"Deleting";

        public static Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Support.NodeProvisioningState Failed = @"Failed";

        public static Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Support.NodeProvisioningState NotSpecified = @"NotSpecified";

        public static Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Support.NodeProvisioningState Succeeded = @"Succeeded";

        public static Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Support.NodeProvisioningState Updating = @"Updating";

        /// <summary>the value for an instance of the <see cref="NodeProvisioningState" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to NodeProvisioningState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="NodeProvisioningState" />.</param>
        internal static object CreateFrom(object value)
        {
            return new NodeProvisioningState(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type NodeProvisioningState</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Support.NodeProvisioningState e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type NodeProvisioningState (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is NodeProvisioningState && Equals((NodeProvisioningState)obj);
        }

        /// <summary>Returns hashCode for enum NodeProvisioningState</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="NodeProvisioningState" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private NodeProvisioningState(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for NodeProvisioningState</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to NodeProvisioningState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="NodeProvisioningState" />.</param>

        public static implicit operator NodeProvisioningState(string value)
        {
            return new NodeProvisioningState(value);
        }

        /// <summary>Implicit operator to convert NodeProvisioningState to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="NodeProvisioningState" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Support.NodeProvisioningState e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum NodeProvisioningState</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Support.NodeProvisioningState e1, Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Support.NodeProvisioningState e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum NodeProvisioningState</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Support.NodeProvisioningState e1, Microsoft.Azure.PowerShell.Cmdlets.Blockchain.Support.NodeProvisioningState e2)
        {
            return e2.Equals(e1);
        }
    }
}