// Copyright (C) 2015-2024 The Neo Project.
// 
// The Neo.SmartContract.Framework is free software distributed under the MIT 
// software license, see the accompanying file LICENSE in the main directory 
// of the project or http://www.opensource.org/licenses/mit-license.php 
// for more details.
// 
// Redistribution and use in source and binary forms with or without
// modifications are permitted.

using System.Runtime.CompilerServices;

namespace Neo.SmartContract.Framework
{
    public abstract class SmartContract
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
#pragma warning disable IDE1006
        public extern static void _initialize();
#pragma warning restore IDE1006
    }
}
