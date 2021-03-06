﻿namespace org.telegram.api.input.chat.photo
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLInputChatPhotoEmpty : TLAbsInputChatPhoto
    {
        public const int CLASS_ID = 0x1ca48f57;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9e, 0x68 })]
        public TLInputChatPhotoEmpty()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLInputChatPhotoEmpty(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            0x1ca48f57;

        public override string toString() => 
            "inputChatPhotoEmpty#1ca48f57";
    }
}

