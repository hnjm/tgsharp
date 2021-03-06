﻿namespace org.telegram.api.functions.upload
{
    using IKVM.Attributes;
    using java.io;
    using java.lang;
    using org.telegram.tl;
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/tl/TLBool;>;")]
    public class TLRequestUploadSaveFilePart : TLMethod
    {
        private TLBytes bytes;
        public const int CLASS_ID = -1291540959;
        private long fileId;
        private int filePart;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xad, 0x68 })]
        public TLRequestUploadSaveFilePart()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestUploadSaveFilePart(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(0x11)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x3d, 0x6c, 0x6c, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.fileId = StreamingUtils.readLong(stream);
            this.filePart = StreamingUtils.readInt(stream);
            this.bytes = StreamingUtils.readTLBytes(stream, context);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb6, 0x68, 0x63, 0x70, 0x68, 0x67 })]
        public virtual TLBool deserializeResponse(InputStream stream, TLContext context)
        {
            TLObject obj2 = StreamingUtils.readTLObject(stream, context);
            if (obj2 == null)
            {
                Throwable.__<suppressFillInStackTrace>();
                throw new IOException("Unable to parse response");
            }
            if (obj2 is TLBool)
            {
                return (TLBool) obj2;
            }
            Throwable.__<suppressFillInStackTrace>();
            throw new IOException(new StringBuilder().append("Incorrect response type. Expected org.telegram.tl.TLBool, got: ").append(Object.instancehelper_getClass(obj2).getCanonicalName()).toString());
        }

        public virtual TLBytes getBytes() => 
            this.bytes;

        public override int getClassId() => 
            -1291540959;

        public virtual long getFileId() => 
            this.fileId;

        public virtual int getFilePart() => 
            this.filePart;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x36, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeLong(this.fileId, stream);
            StreamingUtils.writeInt(this.filePart, stream);
            StreamingUtils.writeTLBytes(this.bytes, stream);
        }

        public virtual void setBytes(TLBytes value)
        {
            this.bytes = value;
        }

        public virtual void setFileId(long value)
        {
            this.fileId = value;
        }

        public virtual void setFilePart(int value)
        {
            this.filePart = value;
        }

        public override string toString() => 
            "upload.saveFilePart#b304a621";
    }
}

