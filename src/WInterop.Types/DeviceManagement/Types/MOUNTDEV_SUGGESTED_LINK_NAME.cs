﻿// ------------------------
//    WInterop Framework
// ------------------------

// Copyright (c) Jeremy W. Kuhne. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Runtime.InteropServices;

namespace WInterop.DeviceManagement.Types
{
    // https://msdn.microsoft.com/en-us/library/windows/hardware/ff562258.aspx
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct MOUNTDEV_SUGGESTED_LINK_NAME
    {
        public BOOLEAN UseOnlyIfThereAreNoOtherLinks;
        public ushort NameLength;
        private TrailingString _Name;
        public ReadOnlySpan<char> Name => _Name.GetBuffer(NameLength);
    }
}
