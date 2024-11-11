using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nanosys1000Software
{
    /// <summary>
    /// 计算延伸加工时，线线、线圆、圆圆交点等功能。延伸点X  延伸点Z    类型1直线2圆     半径	圆心X	圆心Y	序号
    /// </summary>
    static class CalcEx
    {
        public static void LinePan(Pt A, Pt B, double L,out Pt A2,out Pt B2)
        {
            // 计算方向向量
            Pt AB = new Pt(B.X - A.X, B.Y - A.Y);

            // 计算垂直向量
            Pt ABPerp = new Pt(AB.Y, -AB.X);

            // 单位化垂直向量并计算平移向量
            double ABPerpMag = Math.Sqrt(ABPerp.X * ABPerp.X + ABPerp.Y * ABPerp.Y);
            Pt ABShift = new Pt((ABPerp.X / ABPerpMag) * L, (ABPerp.Y / ABPerpMag) * L);

            // 计算新线段的点
            A2 = new Pt(A.X + ABShift.X, A.Y + ABShift.Y);
            B2 = new Pt(B.X + ABShift.X, B.Y + ABShift.Y);
        }

        public static void CirclePan(Pt A, Pt B, double r, Pt C,double L,out Pt A2, out Pt B2)
        {
            if(C.Y<A.Y || C.Y<B.Y)
            {
                A2 = new Pt((A.X-C.X)*L/r+A.X,(A.Y-C.Y)*L/r+A.Y);
                B2 = new Pt((B.X-C.X)*L/r+B.X,(B.Y-C.Y)*L/r+B.Y);
            }
            else
            {
                A2 = new Pt(-(A.X - C.X) * L / r + A.X, -(A.Y - C.Y) * L / r + A.Y);
                B2 = new Pt(-(B.X - C.X) * L / r + B.X, -(B.Y - C.Y) * L / r + B.Y);
            }
        }

        public static void CirclePanB(Pt B, double r, Pt C,double L,out Pt B2,out bool beCW)
        {
            if(C.X<B.X || C.Y<B.Y)
            {
                B2 = new Pt((B.X-C.X)*L/r+B.X,(B.Y-C.Y)*L/r+B.Y);
                beCW = true;
            }
            else
            {
                B2 = new Pt(-(B.X - C.X) * L / r + B.X, -(B.Y - C.Y) * L / r + B.Y);
                beCW = false;
            }
        }

        public static void CalcCenter(Pt A,Pt B,double r,out Pt C)
        {
            C = new Pt();
        }

    }

    class Pt
    {
        public Pt(double xx = 0, double yy = 0)
        {
            X = xx;
            Y = yy;
        }
        ~Pt() { }
        public double X;
        public double Y;
    }
}
