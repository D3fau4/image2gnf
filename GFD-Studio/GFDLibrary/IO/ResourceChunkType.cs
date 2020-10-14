﻿namespace GFDLibrary.IO
{
    public enum ResourceChunkType : uint
    {
        Invalid            = 0,
        Model              = 0x00010003,
        ChunkType000100F8  = 0x000100F8,
        ChunkType000100F9  = 0x000100F9,
        MaterialDictionary = 0x000100FB,
        TextureDictionary  = 0x000100FC,
        AnimationPack      = 0x000100FD,
    }
}