﻿namespace org.telegram.api.functions.messages
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using java.lang;
    using org.telegram.api.input.bot;
    using org.telegram.api.input.user;
    using org.telegram.api.messages;
    using org.telegram.tl;
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/api/messages/TLMessagesHighScores;>;")]
    public class TLRequestMessagesGetInlineGameHighScores : TLMethod
    {
        public const int CLASS_ID = 0xf635e1b;
        private TLInputBotInlineMessageId id;
        private TLAbsInputUser userId;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xad, 0x68 })]
        public TLRequestMessagesGetInlineGameHighScores()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestMessagesGetInlineGameHighScores(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(0x12)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x16, 0x77, 0x77 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.id = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLInputBotInlineMessageId>.Value);
            this.userId = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLAbsInputUser>.Value);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb6, 0x68, 0x63, 0x70, 0x68, 0x67 })]
        public virtual TLMessagesHighScores deserializeResponse(InputStream stream, TLContext context)
        {
            TLObject obj2 = StreamingUtils.readTLObject(stream, context);
            if (obj2 == null)
            {
                Throwable.__<suppressFillInStackTrace>();
                throw new IOException("Unable to parse response");
            }
            if (obj2 is TLMessagesHighScores)
            {
                return (TLMessagesHighScores) obj2;
            }
            Throwable.__<suppressFillInStackTrace>();
            throw new IOException(new StringBuilder().append("Incorrect response type. Expected ").append(ClassLiteral<TLMessagesHighScores>.Value.getCanonicalName()).append(", got: ").append(Object.instancehelper_getClass(obj2).getCanonicalName()).toString());
        }

        public override int getClassId() => 
            0xf635e1b;

        public virtual TLInputBotInlineMessageId getId() => 
            this.id;

        public virtual TLAbsInputUser getUserId() => 
            this.userId;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x10, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLObject(this.id, stream);
            StreamingUtils.writeTLObject(this.userId, stream);
        }

        public virtual void setId(TLInputBotInlineMessageId id)
        {
            this.id = id;
        }

        public virtual void setUserId(TLAbsInputUser userId)
        {
            this.userId = userId;
        }

        public override string toString() => 
            "messages.getInlineGameHighScores#f635e1b";
    }
}

