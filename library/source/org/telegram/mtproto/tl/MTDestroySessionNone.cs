﻿namespace org.telegram.mtproto.tl
{
    using IKVM.Attributes;
    using java.io;
    using java.lang;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class MTDestroySessionNone : TLObject
    {
        public const int CLASS_ID = 0x62d350c9;
        private Long session_id;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa6, 0x68 })]
        public MTDestroySessionNone()
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa9, 0x68, 0x67 })]
        public MTDestroySessionNone(Long session_id)
        {
            this.session_id = session_id;
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected MTDestroySessionNone(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 180, 0x71 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.session_id = Long.valueOf(StreamingUtils.readLong(stream));
        }

        public override int getClassId() => 
            0x62d350c9;

        public virtual Long getSession_id() => 
            this.session_id;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xaf, 0x73 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeLong(this.session_id.longValue(), stream);
        }

        public virtual void setSession_id(Long session_id)
        {
            this.session_id = session_id;
        }

        public override string toString() => 
            "MTDestroySessionNone#62d350c9";
    }
}

