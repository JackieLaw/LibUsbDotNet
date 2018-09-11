//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// Copyright © 2006-2010 Travis Robinson. All rights reserved.
// Copyright © 2011-2018 LibUsbDotNet contributors. All rights reserved.
// 
// website: http://github.com/libusbdotnet/libusbdotnet
// 
// This program is free software; you can redistribute it and/or modify it
// under the terms of the GNU General Public License as published by the
// Free Software Foundation; either version 2 of the License, or 
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful, but 
// WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY
// or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License
// for more details.
// 
// You should have received a copy of the GNU General Public License along
// with this program; if not, write to the Free Software Foundation, Inc.,
// 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA. or 
// visit www.gnu.org.
// 
//
using System;

namespace LibUsbDotNet
{
    /// <summary>
    ///  Standard requests, as defined in table 9-5 of the USB 3.0 specifications 
    /// </summary>
    [Flags]
    public enum StandardRequest : byte
    {
        /// <summary>
        ///  Request status of the specific recipient 
        /// </summary>
        GetStatus = 0,
        /// <summary>
        ///  Clear or disable a specific feature 
        /// </summary>
        ClearFeature = 0x1,
        /// <summary>
        ///  Set or enable a specific feature 
        /// </summary>
        SetFeature = 0x3,
        /// <summary>
        ///  Set device address for all future accesses 
        /// </summary>
        SetAddress = 0x5,
        /// <summary>
        ///  Get the specified descriptor 
        /// </summary>
        GetDescriptor = 0x6,
        /// <summary>
        ///  Used to update existing descriptors or add new descriptors 
        /// </summary>
        SetDescriptor = 0x7,
        /// <summary>
        ///  Get the current device configuration value 
        /// </summary>
        GetConfiguration = 0x8,
        /// <summary>
        ///  Set device configuration 
        /// </summary>
        SetConfiguration = 0x9,
        /// <summary>
        ///  Return the selected alternate setting for the specified interface 
        /// </summary>
        GetInterface = 0xA,
        /// <summary>
        ///  Select an alternate interface for the specified interface 
        /// </summary>
        SetInterface = 0xB,
        /// <summary>
        ///  Set then report an endpoint's synchronization frame 
        /// </summary>
        SynchFrame = 0xC,
        /// <summary>
        ///  Sets both the U1 and U2 Exit Latency 
        /// </summary>
        SetSel = 0x30,
        SetIsochDelay = 0x31,
    }
}