﻿// ------------------------
//    WInterop Framework
// ------------------------

// Copyright (c) Jeremy W. Kuhne. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Runtime.InteropServices;
using WInterop.Gdi.Types;
using WInterop.Windows.Types;

namespace WInterop.Gdi
{
    public static partial class GdiMethods
    {
        /// <summary>
        /// Direct usage of Imports isn't recommended. Use the wrappers that do the heavy lifting for you.
        /// </summary>
        public static partial class Imports
        {
            // https://msdn.microsoft.com/en-us/library/dd144877.aspx
            [DllImport(Libraries.Gdi32, ExactSpelling = true)]
            public static extern int GetDeviceCaps(
                DeviceContext hdc,
                DeviceCapability nIndex);

            // https://msdn.microsoft.com/en-us/library/dd144947.aspx
            [DllImport(Libraries.User32, ExactSpelling = true)]
            public static extern IntPtr GetWindowDC(
                WindowHandle hWnd);

            // https://msdn.microsoft.com/en-us/library/dd144871.aspx
            [DllImport(Libraries.User32, ExactSpelling = true)]
            public static extern IntPtr GetDC(
                WindowHandle hWnd);

            // https://msdn.microsoft.com/en-us/library/dd183490.aspx
            [DllImport(Libraries.Gdi32, CharSet = CharSet.Unicode, ExactSpelling = true)]
            public unsafe static extern DeviceContext CreateDC(
                string lpszDriver,
                string lpszDevice,
                string lpszOutput,
                DEVMODE* lpInitData);

            // https://msdn.microsoft.com/en-us/library/dd183533.aspx
            [DllImport(Libraries.Gdi32, ExactSpelling = true)]
            public static extern bool DeleteDC(
                IntPtr hdc);

            // https://msdn.microsoft.com/en-us/library/windows/desktop/dd162920.aspx
            [DllImport(Libraries.User32, ExactSpelling = true)]
            public static extern bool ReleaseDC(
                WindowHandle hWnd,
                IntPtr hdc);

            // https://msdn.microsoft.com/en-us/library/dd183533.aspx
            [DllImport(Libraries.Gdi32, ExactSpelling = true)]
            public static extern GdiObjectHandle GetStockObject(
                StockObject stockObject);

            // https://msdn.microsoft.com/en-us/library/dd183518.aspx
            [DllImport(Libraries.Gdi32, ExactSpelling = true)]
            public static extern BrushHandle CreateSolidBrush(
                COLORREF crColor);

            // https://msdn.microsoft.com/en-us/library/dd162957.aspx
            [DllImport(Libraries.Gdi32, ExactSpelling = true)]
            public static extern IntPtr SelectObject(
                DeviceContext hdc,
                GdiObjectHandle hgdiobj);

            // https://msdn.microsoft.com/en-us/library/dd183539.aspx
            [DllImport(Libraries.Gdi32, ExactSpelling = true)]
            public static extern bool DeleteObject(
                IntPtr hObject);

            // https://msdn.microsoft.com/en-us/library/windows/desktop/dd162609.aspx
            [DllImport(Libraries.User32, ExactSpelling = true, CharSet = CharSet.Unicode)]
            public static extern bool EnumDisplayDevicesW(
                string lpDevice,
                uint iDevNum,
                ref DISPLAY_DEVICE lpDisplayDevice,
                uint dwFlags);

            // https://msdn.microsoft.com/en-us/library/dd162611.aspx
            [DllImport(Libraries.User32, ExactSpelling = true, CharSet = CharSet.Unicode)]
            public static extern bool EnumDisplaySettingsW(
                string lpszDeviceName,
                uint iModeNum,
                ref DEVMODE lpDevMode);

            // https://msdn.microsoft.com/en-us/library/dd183485.aspx
            [DllImport(Libraries.Gdi32, ExactSpelling = true)]
            public static extern BitmapHandle CreateBitmap(
                int nWidth,
                int nHeight,
                uint cPlanes,
                uint cBitsPerPel,
                IntPtr lpvBits);

            // https://msdn.microsoft.com/en-us/library/dd144905.aspx
            [DllImport(Libraries.Gdi32, ExactSpelling = true)]
            public static extern ObjectType GetObjectType(
                IntPtr h);

            // https://msdn.microsoft.com/en-us/library/dd144925.aspx
            [DllImport(Libraries.Gdi32, ExactSpelling = true)]
            public static extern IntPtr GetStockObject(
                int fnObject);

            // https://msdn.microsoft.com/en-us/library/dd145167.aspx
            [DllImport(Libraries.User32, ExactSpelling = true)]
            public static extern bool UpdateWindow(
                WindowHandle hWnd);

            // https://msdn.microsoft.com/en-us/library/dd183362.aspx
            [DllImport(Libraries.User32, ExactSpelling = true)]
            public static extern IntPtr BeginPaint(
                WindowHandle hwnd,
                out PAINTSTRUCT lpPaint);

            // https://msdn.microsoft.com/en-us/library/dd145002.aspx
            [DllImport(Libraries.User32, ExactSpelling = true)]
            public unsafe static extern bool InvalidateRect(
                WindowHandle hWnd,
                RECT* lpRect,
                bool bErase);

            // https://msdn.microsoft.com/en-us/library/dd162598.aspx
            [DllImport(Libraries.User32, ExactSpelling = true)]
            public static extern bool EndPaint(
                WindowHandle hwnd,
                [In] ref PAINTSTRUCT lpPaint);

            // https://msdn.microsoft.com/en-us/library/dd162498.aspx
            [DllImport(Libraries.User32, CharSet = CharSet.Unicode, ExactSpelling = true)]
            public static unsafe extern int DrawTextW(
                DeviceContext hDC,
                char* lpchText,
                int nCount,
                ref RECT lpRect,
                TextFormat uFormat);

            // https://msdn.microsoft.com/en-us/library/dd145133.aspx
            [DllImport(Libraries.Gdi32, CharSet = CharSet.Unicode, ExactSpelling = true)]
            public static extern bool TextOutW(
                DeviceContext hdc,
                int nXStart,
                int nYStart,
                string lpString,
                int cchString);

            // https://msdn.microsoft.com/en-us/library/dd144941.aspx
            [DllImport(Libraries.Gdi32, CharSet = CharSet.Unicode, ExactSpelling = true)]
            public static extern bool GetTextMetricsW(
                DeviceContext hdc,
                out TEXTMETRIC lptm);

            // https://msdn.microsoft.com/en-us/library/dd145091.aspx
            [DllImport(Libraries.Gdi32, ExactSpelling = true)]
            public static extern TextAlignment SetTextAlign(
                DeviceContext hdc,
                TextAlignment fMode);

            // https://msdn.microsoft.com/en-us/library/dd144932.aspx
            [DllImport(Libraries.Gdi32, ExactSpelling = true)]
            public static extern TextAlignment GetTextAlign(
                DeviceContext hdc);

            // https://msdn.microsoft.com/en-us/library/dd183354.aspx
            [DllImport(Libraries.Gdi32, ExactSpelling = true)]
            public static extern bool AngleArc(
                DeviceContext hdc,
                int X,
                int Y,
                uint dwRadius,
                float eStartAngle,
                float eSweepAngle);

            // https://msdn.microsoft.com/en-us/library/dd183357.aspx
            [DllImport(Libraries.Gdi32, ExactSpelling = true)]
            public static extern bool Arc(
                DeviceContext hdc,
                int nLeftRect,
                int nTopRect,
                int nRightRect,
                int nBottomRect,
                int nXStartArc,
                int nYStartArc,
                int nXEndArc,
                int nYEndArc);

            // https://msdn.microsoft.com/en-us/library/dd183358.aspx
            [DllImport(Libraries.Gdi32, ExactSpelling = true)]
            public static extern bool ArcTo(
                DeviceContext hdc,
                int nLeftRect,
                int nTopRect,
                int nRightRect,
                int nBottomRect,
                int nXRadial1,
                int nYRadial1,
                int nXRadial2,
                int nYRadial2);

            // https://msdn.microsoft.com/en-us/library/dd144848.aspx
            [DllImport(Libraries.Gdi32, ExactSpelling = true)]
            public static extern ArcDirection GetArcDirection(
                DeviceContext hdc);

            // https://msdn.microsoft.com/en-us/library/dd145029.aspx
            [DllImport(Libraries.Gdi32, ExactSpelling = true)]
            public static extern bool LineTo(
                DeviceContext hdc,
                int nXEnd,
                int nYEnd);

            // https://msdn.microsoft.com/en-us/library/dd145069.aspx
            [DllImport(Libraries.Gdi32, ExactSpelling = true)]
            public unsafe static extern bool MoveToEx(
                DeviceContext hdc,
                int X,
                int Y,
                POINT* lpPoint);

            // https://msdn.microsoft.com/en-us/library/dd144910.aspx
            [DllImport(Libraries.Gdi32, ExactSpelling = true)]
            public static extern PolyFillMode GetPolyFillMode(
                DeviceContext hdc);

            // https://msdn.microsoft.com/en-us/library/dd145080.aspx
            [DllImport(Libraries.Gdi32, ExactSpelling = true)]
            public static extern PolyFillMode SetPolyFillMode(
                DeviceContext hdc,
                PolyFillMode iPolyFillMode);

            // https://msdn.microsoft.com/en-us/library/dd162811.aspx
            [DllImport(Libraries.Gdi32, ExactSpelling = true)]
            public unsafe static extern bool PolyBezier(
                DeviceContext hdc,
                POINT* lppt,
                uint cPoints);

            // https://msdn.microsoft.com/en-us/library/dd162812.aspx
            [DllImport(Libraries.Gdi32, ExactSpelling = true)]
            public unsafe static extern bool PolyBezierTo(
                DeviceContext hdc,
                POINT* lppt,
                uint cCount);

            // https://msdn.microsoft.com/en-us/library/dd162813.aspx
            [DllImport(Libraries.Gdi32, ExactSpelling = true)]
            public unsafe static extern bool PolyDraw(
                DeviceContext hdc,
                POINT* lppt,
                PointType* lpbTypes,
                int cCount);

            // https://msdn.microsoft.com/en-us/library/dd162815.aspx
            [DllImport(Libraries.Gdi32, ExactSpelling = true)]
            public unsafe static extern bool Polyline(
                DeviceContext hdc,
                POINT[] lppt,
                int cPoints);

            // https://msdn.microsoft.com/en-us/library/dd162816.aspx
            [DllImport(Libraries.Gdi32, ExactSpelling = true)]
            public unsafe static extern bool PolylineTo(
                DeviceContext hdc,
                POINT* lppt,
                uint cCount);

            // https://msdn.microsoft.com/en-us/library/dd162819.aspx
            [DllImport(Libraries.Gdi32, ExactSpelling = true)]
            public unsafe static extern bool PolyPolyline(
                DeviceContext hdc,
                POINT* lppt,
                uint[] lpdwPolyPoints,
                uint cCount);

            // https://msdn.microsoft.com/en-us/library/dd162961.aspx
            [DllImport(Libraries.Gdi32, ExactSpelling = true)]
            public static extern ArcDirection SetArcDirection(
                DeviceContext hdc,
                ArcDirection ArcDirection);

            // https://msdn.microsoft.com/en-us/library/dd183428.aspx
            [DllImport(Libraries.Gdi32, ExactSpelling = true)]
            public static extern bool Chord(
                DeviceContext hdc,
                int nLeftRect,
                int nTopRect,
                int nRightRect,
                int nBottomRect,
                int nXRadial1,
                int nYRadial1,
                int nXRadial2,
                int nYRadial2);

            // https://msdn.microsoft.com/en-us/library/dd162510(v=vs.85).aspx
            [DllImport(Libraries.Gdi32, ExactSpelling = true)]
            public static extern bool Ellipse(
                DeviceContext hdc,
                int nLeftRect,
                int nTopRect,
                int nRightRect,
                int nBottomRect);

            // https://msdn.microsoft.com/en-us/library/dd162719.aspx
            [DllImport(Libraries.Gdi32, ExactSpelling = true)]
            public static extern bool FillRect(
                DeviceContext hDC,
                [In] ref RECT lprc,
                BrushHandle hbr);

            // https://msdn.microsoft.com/en-us/library/dd144838.aspx
            [DllImport(Libraries.Gdi32, ExactSpelling = true)]
            public static extern bool FrameRect(
                DeviceContext hDC,
                [In] ref RECT lprc,
                BrushHandle hbr);

            // https://msdn.microsoft.com/en-us/library/dd145007.aspx
            [DllImport(Libraries.Gdi32, ExactSpelling = true)]
            public static extern bool InvertRect(
                DeviceContext hDC,
                [In] ref RECT lprc);

            // https://msdn.microsoft.com/en-us/library/dd162799.aspx
            [DllImport(Libraries.Gdi32, ExactSpelling = true)]
            public static extern bool Pie(
                DeviceContext hdc,
                int nLeftRect,
                int nTopRect,
                int nRightRect,
                int nBottomRect,
                int nXRadial1,
                int nYRadial1,
                int nXRadial2,
                int nYRadial2);

            // https://msdn.microsoft.com/en-us/library/dd162814.aspx
            [DllImport(Libraries.Gdi32, ExactSpelling = true)]
            public unsafe static extern bool Polygon(
                DeviceContext hdc,
                POINT* lpPoints,
                int nCount);

            // https://msdn.microsoft.com/en-us/library/dd162818.aspx
            [DllImport(Libraries.Gdi32, ExactSpelling = true)]
            public unsafe static extern bool PolyPolygon(
                DeviceContext hdc,
                POINT* lpPoints,
                int[] lpPolyCounts,
                int nCount);

            // https://msdn.microsoft.com/en-us/library/dd162898.aspx
            [DllImport(Libraries.Gdi32, ExactSpelling = true)]
            public static extern bool Rectangle(
                DeviceContext hdc,
                int nLeftRect,
                int nTopRect,
                int nRightRect,
                int nBottomRect);

            // https://msdn.microsoft.com/en-us/library/dd162944.aspx
            [DllImport(Libraries.Gdi32, ExactSpelling = true)]
            public static extern bool RoundRect(
                DeviceContext hdc,
                int nLeftRect,
                int nTopRect,
                int nRightRect,
                int nBottomRect,
                int nWidth,
                int nHeight);

            // https://msdn.microsoft.com/en-us/library/dd183434.aspx
            [DllImport(Libraries.User32, ExactSpelling = true)]
            public static extern bool ClientToScreen(
                WindowHandle hWnd,
                ref POINT lpPoint);

            // https://msdn.microsoft.com/en-us/library/dd183466.aspx
            [DllImport(Libraries.Gdi32, ExactSpelling = true)]
            public static extern bool CombineTransform(
                out XFORM lpxformResult,
                [In] ref XFORM lpxform1,
                [In] ref XFORM lpxform2);

            // https://msdn.microsoft.com/en-us/library/dd162474.aspx
            [DllImport(Libraries.Gdi32, ExactSpelling = true)]
            public unsafe static extern bool DPtoLP(
                DeviceContext hdc,
                POINT* lpPoints,
                int nCount);

            // https://msdn.microsoft.com/en-us/library/dd144870.aspx
            [DllImport(Libraries.Gdi32, ExactSpelling = true)]
            public static extern bool GetCurrentPositionEx(
                DeviceContext hdc,
                out POINT lpPoint);

            // https://msdn.microsoft.com/en-us/library/dn376360.aspx
            [DllImport(Libraries.User32, ExactSpelling = true)]
            public static extern bool GetDisplayAutoRotationPreferences(
                out ORIENTATION_PREFERENCE pOrientation);

            // https://msdn.microsoft.com/en-us/library/dd144892.aspx
            [DllImport(Libraries.Gdi32, ExactSpelling = true)]
            public static extern GraphicsMode GetGraphicsMode(
                DeviceContext hdc);

            // https://msdn.microsoft.com/en-us/library/dd144897.aspx
            [DllImport(Libraries.Gdi32, ExactSpelling = true)]
            public static extern MapMode GetMapMode(
                DeviceContext hdc);

            // https://msdn.microsoft.com/en-us/library/dd144945.aspx
            [DllImport(Libraries.Gdi32, ExactSpelling = true)]
            public static extern bool GetViewportExtEx(
                DeviceContext hdc,
                out SIZE lpSize);

            // https://msdn.microsoft.com/en-us/library/dd144946.aspx
            [DllImport(Libraries.Gdi32, ExactSpelling = true)]
            public static extern bool GetViewportOrgEx(
                DeviceContext hdc,
                out POINT lpPoint);

            // https://msdn.microsoft.com/en-us/library/dd144948.aspx
            [DllImport(Libraries.Gdi32, ExactSpelling = true)]
            public static extern bool GetWindowExtEx(
                DeviceContext hdc,
                out SIZE lpSize);

            // https://msdn.microsoft.com/en-us/library/dd144949.aspx
            [DllImport(Libraries.Gdi32, ExactSpelling = true)]
            public static extern bool GetWindowOrgEx(
                DeviceContext hdc,
                out POINT lpPoint);

            // https://msdn.microsoft.com/en-us/library/dd144953.aspx
            [DllImport(Libraries.Gdi32, ExactSpelling = true)]
            public static extern bool GetWorldTransform(
                DeviceContext hdc,
                out XFORM lpXform);

            // https://msdn.microsoft.com/en-us/library/dd145042.aspx
            [DllImport(Libraries.Gdi32, ExactSpelling = true)]
            public unsafe static extern bool LPtoDP(
                DeviceContext hdc,
                POINT* lpPoints,
                int nCount);

            // https://msdn.microsoft.com/en-us/library/dd145046.aspx
            [DllImport(Libraries.User32, ExactSpelling = true)]
            public unsafe static extern int MapWindowPoints(
                WindowHandle hWndFrom,
                WindowHandle hWndTo,
                POINT* lpPoints,
                uint cPoints);

            // https://msdn.microsoft.com/en-us/library/dd145060.aspx
            [DllImport(Libraries.Gdi32, ExactSpelling = true)]
            public static extern bool ModifyWorldTransform(
                DeviceContext hdc,
                [In] ref XFORM lpXform,
                WorldTransformMode iMode);

            // https://msdn.microsoft.com/en-us/library/dd162748.aspx
            [DllImport(Libraries.Gdi32, ExactSpelling = true)]
            public static extern bool OffsetViewportOrgEx(
                DeviceContext hdc,
                int nXOffset,
                int nYOffset,
                out POINT lpPoint);

            // https://msdn.microsoft.com/en-us/library/dd162749.aspx
            [DllImport(Libraries.Gdi32, ExactSpelling = true)]
            public static extern bool OffsetWindowOrgEx(
                DeviceContext hdc,
                int nXOffset,
                int nYOffset,
                out POINT lpPoint);

            // https://msdn.microsoft.com/en-us/library/dd162947.aspx
            [DllImport(Libraries.Gdi32, ExactSpelling = true)]
            public static extern bool ScaleViewportExtEx(
                DeviceContext hdc,
                int Xnum,
                int Xdenom,
                int Ynum,
                int Ydenom,
                out SIZE lpSize);

            // https://msdn.microsoft.com/en-us/library/dd162948.aspx
            [DllImport(Libraries.Gdi32, ExactSpelling = true)]
            public static extern bool ScaleWindowExtEx(
                DeviceContext hdc,
                int Xnum,
                int Xdenom,
                int Ynum,
                int Ydenom,
                out SIZE lpSize);

            // https://msdn.microsoft.com/en-us/library/dd162952.aspx
            [DllImport(Libraries.User32, ExactSpelling = true)]
            public static extern bool ScreenToClient(
                WindowHandle hWnd,
                ref POINT lpPoint);

            // https://msdn.microsoft.com/en-us/library/dn376361.aspx
            [DllImport(Libraries.User32, ExactSpelling = true)]
            public static extern bool SetDisplayAutoRotationPreferences(
                ORIENTATION_PREFERENCE orientation);

            // https://msdn.microsoft.com/en-us/library/dd162977.aspx
            [DllImport(Libraries.Gdi32, ExactSpelling = true)]
            public static extern bool SetGraphicsMode(
                DeviceContext hdc,
                GraphicsMode iMode);

            // https://msdn.microsoft.com/en-us/library/dd162980.aspx
            [DllImport(Libraries.Gdi32, ExactSpelling = true)]
            public static extern MapMode SetMapMode(
                DeviceContext hdc,
                MapMode fnMapMode);

            // https://msdn.microsoft.com/en-us/library/dd145098.aspx
            [DllImport(Libraries.Gdi32, ExactSpelling = true)]
            public static extern bool SetViewportExtEx(
                DeviceContext hdc,
                int nXExtent,
                int nYExtent,
                out SIZE lpSize);

            // https://msdn.microsoft.com/en-us/library/dd145099.aspx
            [DllImport(Libraries.Gdi32, ExactSpelling = true)]
            public static extern bool SetViewportOrgEx(
                DeviceContext hdc,
                int nXExtent,
                int nYExtent,
                out POINT lpPoint);

            // https://msdn.microsoft.com/en-us/library/dd145100.aspx
            [DllImport(Libraries.Gdi32, ExactSpelling = true)]
            public static extern bool SetWindowExtEx(
                DeviceContext hdc,
                int nXExtent,
                int nYExtent,
                out SIZE lpSize);

            // https://msdn.microsoft.com/en-us/library/dd145101.aspx
            [DllImport(Libraries.Gdi32, ExactSpelling = true)]
            public static extern bool SetWindowOrgEx(
                DeviceContext hdc,
                int nXExtent,
                int nYExtent,
                out POINT lpPoint);

            // https://msdn.microsoft.com/en-us/library/dd145104.aspx
            [DllImport(Libraries.Gdi32, ExactSpelling = true)]
            public static extern bool SetWorldTransform(
                DeviceContext hdc,
                [In] ref XFORM lpXform);
        }
    }
}
