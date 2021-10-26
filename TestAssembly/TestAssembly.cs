﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region NamespaceTest
namespace TestAssembly
{
    namespace N1 { namespace T1 { } namespace T2 { namespace X { struct D { } } } }
    namespace N2 { namespace F1 { } namespace F2 { class A { } class B { } class C { } } namespace F3 { } }
    namespace N3 { namespace P1 { } }
    namespace N4 { class T { } }

    class A { }
    class B { }
    class C { }
}

class A { }
struct B { }
#endregion

#region ClassesStructTest
namespace ClassesStructTest
{
    class A
    {
        class C
        {
            class T { class P { class Z { struct H { } } } }
        }

        struct F
        {

        }
    }

    namespace InnerNamespace
    {
        class B
        {

        }

        struct D
        {

        }
    }
}
#endregion

#region FieldsTest
class M
{
    private double[] myArray;
    public P strP;
    protected float f;
    private protected long zzz;
    protected internal string sss;
}

struct P
{
    private int a;
    double d;
    public float f;
    string str;
    char c;
    public M field;
    DateTime dt;
    private Random rand;
}
#endregion

#region PropertiesTest
class Q
{
    private Double[] MyArray { get; set; }
    public P StrP { get; private set; }
    protected float F { get; set; }
    private protected long Zzz { get; set; }
    protected internal string Sss { private get; set; }
}

struct R
{
    private int A { get; set; }
    double D { get; set; }
    public float F { get; set; }
    string Str { get; set; }
    char C { get; set; }
    public M Field { private get; set; }
    DateTime Dt { get; set; }
    private Random Rand { get; set; }
}
#endregion