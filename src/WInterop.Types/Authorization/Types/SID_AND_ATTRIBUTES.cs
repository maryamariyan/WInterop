﻿// ------------------------
//    WInterop Framework
// ------------------------

// Copyright (c) Jeremy W. Kuhne. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace WInterop.Authorization.Types
{
    /// <summary>
    /// <see cref="https://msdn.microsoft.com/en-us/library/windows/desktop/aa379595.aspx"/>
    /// </summary>
    public struct SID_AND_ATTRIBUTES
    {
        public IntPtr Sid;
        public uint Attributes;
    }
}
