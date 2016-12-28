﻿using System;

namespace AntShares.SmartContract.Framework
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
    public class SyscallAttribute : Attribute
    {
        public string Method { get; }

        public SyscallAttribute(string method)
        {
            this.Method = method;
        }
    }
}
