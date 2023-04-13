﻿//HintName: BaseMapper.g.cs
#nullable enable
internal sealed abstract partial class BaseMapper
{
    public partial global::B AToB(global::A source)
    {
        var target = new global::B();
        target.Value = IntToString(source.Value);
        target.Value2 = IntToShort(source.Value2);
        return target;
    }

    protected partial short IntToShort(int value)
    {
        return (short)value;
    }
}
