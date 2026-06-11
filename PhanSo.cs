using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PhanSo
{
    public int TuSo { get; set; }
    public int MauSo { get; set; }   
    public PhanSo(int tuSo, int mauSo)
    {
        if (mauSo == 0)
            throw new ArgumentException("Mẫu số không được bằng 0.");
        if (mauSo < 0)
        {
            TuSo = -tuSo;
            MauSo = -mauSo;
        }
        int ucln = UCLN(tuSo, mauSo);
        TuSo = tuSo / ucln;
        MauSo = mauSo / ucln;

    }
    public PhanSo RutGon()
    {
       return new PhanSo(TuSo, MauSo);
    }
    private int UCLN(int a, int b)
    {       
        while (b != 0)
         {
             int temp = b;
             b = a % b;
             a = temp;
         }
         return Math.Abs(a);        
    }
    public static PhanSo operator +(PhanSo a, PhanSo b)
    {
        int TuSo = a.TuSo * b.MauSo + b.TuSo * a.MauSo;
        int MauSo = a.MauSo * b.MauSo;
        PhanSo result = new PhanSo(TuSo, MauSo);
        //result.RutGon();
        return result;
    }
    public static PhanSo operator +(PhanSo a, int b)
    {
        int TuSo = a.TuSo + b * a.MauSo;
        int MauSo = a.MauSo;
        PhanSo result = new PhanSo(TuSo, MauSo);
        //result.RutGon();
        return result;
    }
    public static PhanSo operator -(PhanSo a, PhanSo b)
    {
        int TuSo = a.TuSo * b.MauSo - b.TuSo * a.MauSo;
        int MauSo = a.MauSo * b.MauSo;
        PhanSo result = new PhanSo(TuSo, MauSo);
        //result.RutGon();
        return result;
    }
    public static PhanSo operator *(PhanSo a, PhanSo b)
    {
        int TuSo = a.TuSo * b.TuSo;
        int MauSo = a.MauSo * b.MauSo;
        PhanSo result = new PhanSo(TuSo, MauSo);
        //result.RutGon();
        return result;
    }
    public static PhanSo operator /(PhanSo a, PhanSo b)
    {
        int TuSo = a.TuSo * b.MauSo;
        int MauSo = a.MauSo * b.TuSo;
        PhanSo result = new PhanSo(TuSo, MauSo);
        //result.RutGon();
        return result;
    }
    public static bool operator ==(PhanSo a, PhanSo b)
    {
        return a.TuSo * b.MauSo == b.TuSo * a.MauSo;
    }
    public static bool operator !=(PhanSo a, PhanSo b)
    {
        return !(a == b);
    }
    public static bool operator >(PhanSo a, PhanSo b)
    {
        return a.TuSo * b.MauSo > b.TuSo * a.MauSo;
    }
    public static bool operator <(PhanSo a, PhanSo b)
    {
        return a.TuSo * b.MauSo < b.TuSo * a.MauSo;
    }
    public static bool operator >=(PhanSo a, PhanSo b)
    {
        return a > b || a == b;
    }
    public static bool operator <=(PhanSo a, PhanSo b)
    {
        return a < b || a == b;
    }   
    public override bool Equals(object obj)
    {
        if (obj is PhanSo other)
        {
            return this == other;
        }
        return false;
    }
    public override int GetHashCode()
    {
        return HashCode.Combine(TuSo, MauSo);
    }
    public override string ToString()
    {
        return $"{TuSo}/{MauSo}";
    }
}
