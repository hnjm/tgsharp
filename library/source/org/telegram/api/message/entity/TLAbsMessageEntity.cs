﻿namespace org.telegram.api.message.entity
{
    using IKVM.Attributes;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public abstract class TLAbsMessageEntity : TLObject
    {
        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(11)]
        public TLAbsMessageEntity()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLAbsMessageEntity(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }
    }
}

