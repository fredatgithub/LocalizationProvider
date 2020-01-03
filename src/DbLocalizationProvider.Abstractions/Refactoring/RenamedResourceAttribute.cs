// Copyright (c) Valdis Iljuconoks. All rights reserved.
// Licensed under Apache-2.0. See the LICENSE file in the project root for more information

using System;

namespace DbLocalizationProvider.Abstractions.Refactoring
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field)]
    public class RenamedResourceAttribute : Attribute
    {
        public RenamedResourceAttribute() { }

        public RenamedResourceAttribute(string oldName, string oldNamespace)
        {
            if(string.IsNullOrWhiteSpace(oldName)) throw new ArgumentException("Value cannot be null or whitespace.", nameof(oldName));

            OldName = oldName;
            OldNamespace = oldNamespace;
        }

        public RenamedResourceAttribute(string oldName) : this(oldName, null) { }

        public string OldName { get; set; }

        public string OldNamespace { get; set; }
    }
}
