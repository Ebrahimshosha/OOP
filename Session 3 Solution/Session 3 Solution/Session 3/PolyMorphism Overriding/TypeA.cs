using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_3.PolyMorphism_Overriding
{
    public class TypeA
    {
        public int A { get; set; }

        public TypeA()
        {

        }

        public TypeA(int _A)
        {
            A = _A;
        }

        public void MyFun1()
        {
            Console.WriteLine("I am Base [Parent]");
        }

        public virtual void MyFun2()
        {
            Console.WriteLine($"TypeA : A = {A}");
        }
    }

    public class TypeB : TypeA
    {
        public int B { get; set; }

        public TypeB(int _A,int _B):base(_A)
        {
            B = _B;
        }

        // 1. Applying Function Overriding using "new" keyword
        // static Binding Method
        public new void MyFun1()  // → new version from MyFun1 Method
        {
            Console.WriteLine("I am Derived [Child]");
        }

        // 2. Applying Function Overriding using "override" keyword
        // But before Anything, The function That Will be Overrided using "override", must be "public virtual"
        // // dynamic Binding Method

        public override void MyFun2()
        {
            Console.WriteLine($"TypeB : A = {A}, B = {B}");
        }
    }

    public class TypeC : TypeB
    {
        public int C { get; set; }

        public TypeC(int _A,int _B,int _C):base(_A,_B)
        {
            C = _C;
        }

        public new void MyFun1()
        {
            Console.WriteLine("I am Grand Child");
        }

        public override void MyFun2()
        {
            Console.WriteLine($"TypeC : A = {A},B = {B},C = {C}");
        }
    }

    public class TypeD : TypeC
    {
        public int D { get; set; }

        public TypeD(int _A, int _B, int _C, int _D) : base(_A, _B,_C)
        {
            D = _D;         
        }

        public new virtual void MyFun2()
        {
            Console.WriteLine($"TypeD : A = {A},B = {B},C = {C},D = {D}");
        }
    }

    public class TypeE : TypeD
    {
        public int E { get; set; }

        public TypeE(int _A, int _B, int _C, int _D,int _E) : base(_A, _B, _C,_D)
        {
            E = _E;
        }

        public override void MyFun2()
        {
            Console.WriteLine($"TypeD : A = {A},B = {B},C = {C},D = {D}, E = {E}");
        }
    }
    
}
