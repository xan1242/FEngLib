﻿using System.IO;

namespace FEngLib
{
    public abstract class FrontendTag
    {
        public FrontendObject FrontendObject { get; }

        protected FrontendTag(FrontendObject frontendObject)
        {
            FrontendObject = frontendObject;
        }

        public abstract void Read(BinaryReader br, ushort length);
    }
}