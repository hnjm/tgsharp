﻿namespace org.telegram.api.page.block
{
    using IKVM.Attributes;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public abstract class TLAbsPageBlock : TLObject
    {
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x99, 0x68 })]
        public TLAbsPageBlock()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLAbsPageBlock(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }
    }
}

