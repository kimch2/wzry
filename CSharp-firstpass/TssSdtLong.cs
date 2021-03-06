﻿using System;

public class TssSdtLong
{
    private TssSdtLongSlot m_slot;

    public override bool Equals(object obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return this.GetValue().GetHashCode();
    }

    private long GetValue()
    {
        if (this.m_slot == null)
        {
            this.m_slot = TssSdtLongSlot.NewSlot(null);
        }
        return this.m_slot.GetValue();
    }

    public static TssSdtLong NewTssSdtLong()
    {
        return new TssSdtLong { m_slot = TssSdtLongSlot.NewSlot(null) };
    }

    public static TssSdtLong operator --(TssSdtLong v)
    {
        TssSdtLong @long = new TssSdtLong();
        if (v == null)
        {
            @long.SetValue(-1L);
            return @long;
        }
        long num = v.GetValue() - 1L;
        @long.SetValue(num);
        return @long;
    }

    public static bool operator ==(TssSdtLong a, TssSdtLong b)
    {
        return ((object.Equals(a, null) && object.Equals(b, null)) || ((!object.Equals(a, null) && !object.Equals(b, null)) && (a.GetValue() == b.GetValue())));
    }

    public static implicit operator TssSdtLong(long v)
    {
        TssSdtLong @long = new TssSdtLong();
        @long.SetValue(v);
        return @long;
    }

    public static implicit operator long(TssSdtLong v)
    {
        if (v == null)
        {
            return 0L;
        }
        return v.GetValue();
    }

    public static TssSdtLong operator ++(TssSdtLong v)
    {
        TssSdtLong @long = new TssSdtLong();
        if (v == null)
        {
            @long.SetValue(1L);
            return @long;
        }
        long num = v.GetValue() + 1L;
        @long.SetValue(num);
        return @long;
    }

    public static bool operator !=(TssSdtLong a, TssSdtLong b)
    {
        if (object.Equals(a, null) && object.Equals(b, null))
        {
            return false;
        }
        if (!object.Equals(a, null) && !object.Equals(b, null))
        {
            return (a.GetValue() != b.GetValue());
        }
        return true;
    }

    private void SetValue(long v)
    {
        if (this.m_slot == null)
        {
            this.m_slot = TssSdtLongSlot.NewSlot(null);
        }
        this.m_slot.SetValue(v);
    }

    public override string ToString()
    {
        return string.Format("{0}", this.GetValue());
    }
}

