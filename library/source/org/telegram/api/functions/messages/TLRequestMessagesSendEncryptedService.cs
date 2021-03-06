﻿namespace org.telegram.api.functions.messages
{
    using IKVM.Attributes;
    using java.io;
    using java.lang;
    using org.telegram.api.input.encrypted;
    using org.telegram.api.messages.sentencrypted;
    using org.telegram.tl;
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/api/messages/sentencrypted/TLAbsSentEncryptedMessage;>;")]
    public class TLRequestMessagesSendEncryptedService : TLMethod
    {
        public const int CLASS_ID = 0x32d439a4;
        private TLBytes data;
        private TLInputEncryptedChat peer;
        private long randomId;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xae, 0x68 })]
        public TLRequestMessagesSendEncryptedService()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestMessagesSendEncryptedService(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(0x12)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x3e, 0x72, 0x6c, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.peer = StreamingUtils.readTLObject(stream, context);
            this.randomId = StreamingUtils.readLong(stream);
            this.data = StreamingUtils.readTLBytes(stream, context);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb7, 0x68, 0x63, 0x70, 0x68, 0x67 })]
        public virtual TLAbsSentEncryptedMessage deserializeResponse(InputStream stream, TLContext context)
        {
            TLObject obj2 = StreamingUtils.readTLObject(stream, context);
            if (obj2 == null)
            {
                Throwable.__<suppressFillInStackTrace>();
                throw new IOException("Unable to parse response");
            }
            if (obj2 is TLAbsSentEncryptedMessage)
            {
                return (TLAbsSentEncryptedMessage) obj2;
            }
            Throwable.__<suppressFillInStackTrace>();
            throw new IOException(new StringBuilder().append("Incorrect response type. Expected org.telegram.api.messages.sentencrypted.TLAbsSentEncryptedMessage, got: ").append(Object.instancehelper_getClass(obj2).getCanonicalName()).toString());
        }

        public override int getClassId() => 
            0x32d439a4;

        public virtual TLBytes getData() => 
            this.data;

        public virtual TLInputEncryptedChat getPeer() => 
            this.peer;

        public virtual long getRandomId() => 
            this.randomId;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x37, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLObject(this.peer, stream);
            StreamingUtils.writeLong(this.randomId, stream);
            StreamingUtils.writeTLBytes(this.data, stream);
        }

        public virtual void setData(TLBytes value)
        {
            this.data = value;
        }

        public virtual void setPeer(TLInputEncryptedChat value)
        {
            this.peer = value;
        }

        public virtual void setRandomId(long value)
        {
            this.randomId = value;
        }

        public override string toString() => 
            "messages.sendEncryptedService#32d439a4";
    }
}

