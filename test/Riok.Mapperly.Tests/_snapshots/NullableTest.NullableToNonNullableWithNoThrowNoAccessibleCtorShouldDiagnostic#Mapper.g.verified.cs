﻿//HintName: Mapper.g.cs
#nullable enable
public partial class Mapper
{
    private partial global::B Map(string? source)
    {
        return source == null ? throw new System.ArgumentNullException(nameof(source)) : global::B.Parse(source);
    }
}
