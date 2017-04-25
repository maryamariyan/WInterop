﻿// ------------------------
//    WInterop Framework
// ------------------------

// Copyright (c) Jeremy W. Kuhne. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Runtime.InteropServices;

namespace WInterop.Gdi.Types
{
    // https://msdn.microsoft.com/en-us/library/dd183449.aspx
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct COLORREF
    {
        public COLORREF(byte red, byte green, byte blue)
        {
            Value = 0;
            R = red;
            G = green;
            B = blue;
        }

        public COLORREF(uint value)
        {
            R = 0;
            G = 0;
            B = 0;
            Value = value & 0x00FFFFFF;
        }

        [FieldOffset(0)]
        public byte R;
        [FieldOffset(1)]
        public byte G;
        [FieldOffset(2)]
        public byte B;

        [FieldOffset(0)]
        public uint Value;
    }
}
