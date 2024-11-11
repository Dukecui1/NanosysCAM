using System; //基本C#类库
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;   //用于创建图形化用户界面（GUI）应用程序
using System.IO;
using MathNet.Numerics;   //用于数值计算的数学库，这个库在程序中用来进行拟合计算（例如多项式拟合）
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms.DataVisualization.Charting;

namespace Nanosys1000Software   //定义了项目的命名空间，所有代码都在这个命名空间中
{
    public partial class MainForm : Form  //MainForm 类继承自 Form，是 Windows 窗体应用程序的主要窗口。

    {
        double c, k, a40, a38, a36, a34, a32, a30, a28, a26, a24, a22, a20, a18, a16, a14, a12, a10, a8, a6, a4, a2;
        double tool_r, feedrate, spindleSpeed, step, startx, endx;
        //这部分定义了一些 double 类型的字段：c, k 等是光学计算的常量。
        //a30, a28, ... a0 是用于多项式拟合的系数，这些变量命名中包含的数字表示多项式项的次数。
        //tool_r、feedrate、spindleSpeed 分别表示刀具半径、进给率和主轴转速。
        //step, startx, endx 表示加工步距、起始位置和结束位置。
        //grindingSpeed 是磨头的转速。

        /// <summary>
        /// 磨头转速
        /// </summary>
        double grindingSpeed;
        double[] x_absolute = new double[200000];   //x_absolute 和 z_absolute 用于存储加工的绝对坐标
        double[] z_absolute = new double[200000];
        double[] x_number;   //x_number 和 z_error 存储误差拟合相关的数据
        double[] z_error;
        double[] x_pv = new double[200000];   //x_pv 和 z_pv 存储PV（面型误差）拟合数据
        double[] z_pv = new double[200000];
        double[] y2 = new double[200000];   //y2 用于存储样条插值的二阶导数数据
        double x, z = 0; //x, z 用于计算中的临时变量
        /// <summary>
        /// 误差拟合参数
        /// </summary>
        double a = 0.0, b = 0.0;   //a, b 是拟合的线性参数
        double diff_z = 0;   //diff_z 用于计算差值

        double[] error_nihe = new double[200000];   //error_nihe 用于存储拟合误差

        int pointNum;   //pointNum 是一个整数变量，用于记录点的数量
        ProgramForm programListF = new ProgramForm();       //ProgramForm programListF 和 AboutBox1 aboutBox 是窗体类的实例，programListF 用于显示程序列表
        AboutBox1 aboutBox = new AboutBox1();   //aboutBox 是程序的“关于”对话框

        /// <summary>
        /// 最大数组
        /// </summary>
        const int UV3P_MaxNum = 200000;   //UV3P_MaxNum 是一个常量，用于限制拟合数据数组的最大大小
        /// <summary>
        /// 拟合数据的X坐标
        /// </summary>
        double[] UV3P_x = new double[UV3P_MaxNum];
        /// <summary>
        /// 拟合数据的误差,zd坐标
        /// </summary>
        double[] UV3P_zd = new double[UV3P_MaxNum];   //UV3P_x 和 UV3P_zd 分别存储拟合数据的 x 坐标和 zd 坐标
        /// <summary>
        /// 多项式拟合的结果，分别对应多次补偿拟合
        /// </summary>
        double[] UV3P_result01 = new double[10];
        double[] UV3P_result02 = new double[10];
        double[] UV3P_result03 = new double[10];
        double[] UV3P_result04 = new double[10];
        double[] UV3P_result05 = new double[10];
        /// <summary>
        /// 分隔符
        /// </summary>
        char[] sepa = { ',', ' ', '\t' };
        /// <summary>
        /// 记录多少条数据
        /// </summary>
        int UV3P_index = 0;
        /// <summary>
        /// 没有载入补偿数据
        /// </summary>
        bool UV3P_NULL = true;

        /// <summary>
        /// 最大数组
        /// </summary>
        const int ExtMaxNum = 200;   //是延伸加工点的最大数量
        /// <summary>
        /// X坐标
        /// </summary>
        double[] ExtPtx = new double[ExtMaxNum];   //ExtPtx 和 ExtPtz 分别存储延伸加工点的 X 和 Z 坐标
        /// <summary>
        /// z坐标
        /// </summary>
        double[] ExtPtz = new double[ExtMaxNum];
        /// <summary>
        /// 1直线2圆
        /// </summary>
        double[] ExtType = new double[ExtMaxNum];   //用于记录延伸加工点的类型，1 表示直线，2 表示圆
        /// <summary>
        /// 圆的半径
        /// </summary>
        double[] ExtR = new double[ExtMaxNum];
        /// <summary>
        /// 圆心X坐标
        /// </summary>
        double[] ExtCx = new double[ExtMaxNum];
        /// <summary>
        /// 圆心Z坐标
        /// </summary>
        double[] ExtCz = new double[ExtMaxNum];
        /// <summary>
        /// 记录多少条延伸点数据
        /// </summary>
        int ExtIndex = 0;
        /// <summary>
        /// 没有载入延伸加工数据
        /// </summary>
        bool Ext_NULL = true;

        const int CParaMaxNum = 20;   //参数的最大数量
        int CParaIndex = 0;   //CParaIndex 用于记录当前参数的索引
        bool CFile_NULL = true;   //CFile_NULL 用于表示是否没有载入参数数据
        double cc, ck;   //cc, ck 是两个参数，可能与光学或机械加工计算有关
        double[] CPara = new double[CParaMaxNum];   //CPara 数组存储了20个参数，可能用于拟合或其他计算


        public MainForm()
        {
            InitializeComponent();
        }

        ///自由曲面
        private double fDxs(double cr, double ca)   //cr：半径，ca：角度（单位为度）
        {
            double x, y, z;
            x = cr * Math.Sin(ca * Math.PI / 180);   //表示沿 x 方向的投影，使用半径 cr 乘以角度的正弦值。
            y = cr * Math.Cos(ca * Math.PI / 180);   //半径 cr 乘以角度的余弦值，表示沿 y 方向的投影

            z = cc * cr * cr / (1 + Math.Sqrt(1 - (ck + 1) * cc * cc * cr * cr))
                + CPara[2] * Math.Pow(x, 1) * Math.Pow(y, 0)
                + CPara[3] * Math.Pow(x, 0) * Math.Pow(y, 1)
                + CPara[4] * Math.Pow(x, 2) * Math.Pow(y, 0)
                + CPara[5] * Math.Pow(x, 1) * Math.Pow(y, 1)
                + CPara[6] * Math.Pow(x, 0) * Math.Pow(y, 2)
                + CPara[7] * Math.Pow(x, 3) * Math.Pow(y, 0)
                + CPara[8] * Math.Pow(x, 2) * Math.Pow(y, 1)
                + CPara[9] * Math.Pow(x, 1) * Math.Pow(y, 2)
                + CPara[10] * Math.Pow(x, 0) * Math.Pow(y, 3)
                + CPara[11] * Math.Pow(x, 4) * Math.Pow(y, 0)
                + CPara[12] * Math.Pow(x, 3) * Math.Pow(y, 1)
                + CPara[13] * Math.Pow(x, 2) * Math.Pow(y, 2)
                + CPara[14] * Math.Pow(x, 1) * Math.Pow(y, 3)
                + CPara[15] * Math.Pow(x, 0) * Math.Pow(y, 4)
                + CPara[16] * Math.Pow(x, 5) * Math.Pow(y, 0)
                + CPara[17] * Math.Pow(x, 4) * Math.Pow(y, 1)
                + CPara[18] * Math.Pow(x, 3) * Math.Pow(y, 2)
                + CPara[19] * Math.Pow(x, 2) * Math.Pow(y, 3)
                ;

            //z = cc * cr * cr / (1 + Math.Sqrt(1 - (ck + 1) * cc * cc * cr * cr)) + a15 * Math.Pow(cr, 15) + a14 * Math.Pow(cr, 14) +
            //    a13 * Math.Pow(cr, 13) + a12 * Math.Pow(cr, 12) + a11 * Math.Pow(cr, 11) + a10 * Math.Pow(cr, 10) + a9 * Math.Pow(cr, 9) +
            //    a8 * Math.Pow(cr, 8) + a7 * Math.Pow(cr, 7) + a6 * Math.Pow(cr, 6) + a5 * Math.Pow(cr, 5) + a4 * Math.Pow(cr, 4) +
            //    a3 * Math.Pow(cr, 3) + a2 * Math.Pow(cr, 2) + a1 * cr + a0
            //    + a16 * Math.Pow(cr, 16)
            //    + a18 * Math.Pow(cr, 18)
            //    + a20 * Math.Pow(cr, 20)
            //    + a22 * Math.Pow(cr, 22)
            //    + a24 * Math.Pow(cr, 24)
            //    + a26 * Math.Pow(cr, 26)
            //    + a28 * Math.Pow(cr, 28)
            //    + a30 * Math.Pow(cr, 30)
            //    ;
            return (z);
        }

        //拟合，通过最小二乘法对输入的自变量数组 x 和因变量数组 y 进行线性拟合，得到一个线性函数的斜率 b 和截距 a
        private void fit(double[] x, double[] y, int ndata)   //ndata：整数，表示数据点的数量
        {
            int i;   //循环变量
            double t, sxoss, wt, ss, sx = 0.0;   //sx、sy用于累加 x 和 y 数据的加权和，初始值为 0。ss：加权和的权值累加，用于计算权重的总和
            double sy = 0.0;   //wt：权重因子，这里默认是 1。
            double st2 = 0.0;   //st2：用于累积平方差
            b = 0.0;   //b：拟合结果的斜率，初始值为 0

            ss = 0.0;
            for (i = 0; i < ndata; i++)
            {
                wt = 1.0;   //权重被固定为 1，即不加权
                ss = ss + wt;   //累加所有数据点的权重之和
                sx = sx + x[i] * wt;   //自变量x的加权和
                sy = sy + y[i] * wt;   //自变量y的加权和
            }

            sxoss = sx / ss;   //x的加权平均值

            for (i = 0; i < ndata; i++)
            {
                t = x[i] - sxoss;   //计算当前 x[i] 与均值 sxoss 的偏差
                st2 = st2 + t * t;   //累加偏差的平方，st2 用于计算方差
                b = b + t * y[i];    //累加偏差与 y[i] 的乘积，最终用于计算斜率

            }

            b = b / st2;   //计算斜率 b，即用 t 与 y 乘积的累积除以 t 的平方和
            a = (sy - sx * b) / ss;      //计算截距 a。这里用到 sy（y 值的加权和），减去 sx * b（x 值和斜率的乘积），再除以 ss（权重之和），得到截距

        }

        /// <summary>
        /// 光学方程计算
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        private double fx(double x)
        {
            double z;

            z = c * x * x / (1 + Math.Sqrt(1 - (k + 1) * c * c * x * x)) + a14 * Math.Pow(x, 14) +
                a12 * Math.Pow(x, 12) + a10 * Math.Pow(x, 10) +
                a8 * Math.Pow(x, 8) + a6 * Math.Pow(x, 6) + +a4 * Math.Pow(x, 4) +
                 +a2 * Math.Pow(x, 2)
                + a16 * Math.Pow(x, 16)
                + a18 * Math.Pow(x, 18)
                + a20 * Math.Pow(x, 20)
                + a22 * Math.Pow(x, 22)
                + a24 * Math.Pow(x, 24)
                + a26 * Math.Pow(x, 26)
                + a28 * Math.Pow(x, 28)
                + a30 * Math.Pow(x, 30)
                + a32 * Math.Pow(x, 32)
                + a34 * Math.Pow(x, 34)
                + a36 * Math.Pow(x, 36)
                + a38 * Math.Pow(x, 38)
                + a40 * Math.Pow(x, 40)

                ;
            return (z);
        }

        /// <summary>
        /// 光学方程一阶导数计算
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        /// ？？？？？？？？？？？？一阶导结果是否有问题
        private double diff_fx(double x)
        {
            double z;
            // 计算根号中的部分
            double sqrtPart = Math.Sqrt(1 - (k + 1) * Math.Pow(c, 2) * Math.Pow(x, 2));

            // 计算第一项
            double firstTerm = (2 * c * x) / (1 + sqrtPart);

            // 计算第二项的分子
            double numeratorSecondTerm = (k + 1) * Math.Pow(c, 3) * Math.Pow(x, 3);

            // 计算第二项的分母
            double denominatorSecondTerm = Math.Pow(1 + sqrtPart, 2) * sqrtPart;

            // 计算第二项
            double secondTerm = numeratorSecondTerm / denominatorSecondTerm;

            // 求导数 dZ/dX
            double dZ_dX = firstTerm + secondTerm;

            //z = c * x / Math.Sqrt(1 - (k + 1) * c * c * x * x) 
            z = dZ_dX
                + 14 * a14 * Math.Pow(x, 13) + 12 * a12 * Math.Pow(x, 11)
                + 10 * a10 * Math.Pow(x, 9) + 8 * a8 * Math.Pow(x, 7)
                + 6 * a6 * Math.Pow(x, 5) + 4 * a4 * Math.Pow(x, 3) + 2 * a2 * x
                + 16 * a16 * Math.Pow(x, 15)
                + 18 * a18 * Math.Pow(x, 17)
                + 20 * a20 * Math.Pow(x, 19)
                + 22 * a22 * Math.Pow(x, 21)
                + 24 * a24 * Math.Pow(x, 23)
                + 26 * a26 * Math.Pow(x, 25)
                + 28 * a28 * Math.Pow(x, 27)
                + 30 * a30 * Math.Pow(x, 29)
                + 32 * a32 * Math.Pow(x, 31)
                + 34 * a34 * Math.Pow(x, 33)
                + 36 * a36 * Math.Pow(x, 35)
                + 38 * a38 * Math.Pow(x, 37)
                + 40 * a40 * Math.Pow(x, 39)
                ;
            return (z);
        }
        ///？？？？？？？？？？？？？？？？？？？？？？？？？光学方程二阶导计算
        private double diff2_fx(double x)
        {
            double z;

            z = c / Math.Pow((1 - (k + 1) * c * c * x * x), 1.5) + 13 * 14 * a14 * Math.Pow(x, 12) +
                11 * 12 * a12 * Math.Pow(x, 10) + 9 * 10 * a10 * Math.Pow(x, 8) +
                7 * 8 * a8 * Math.Pow(x, 6) + 5 * 6 * a6 * Math.Pow(x, 4) +
                       3 * 4 * a4 * Math.Pow(x, 2) + 2 * a2
                       + 16 * 15 * a16 * Math.Pow(x, 14)
                        + 18 * 17 * a18 * Math.Pow(x, 16)
                        + 20 * 19 * a20 * Math.Pow(x, 18)
                        + 22 * 21 * a22 * Math.Pow(x, 20)
                        + 24 * 23 * a24 * Math.Pow(x, 22)
                        + 26 * 25 * a26 * Math.Pow(x, 24)
                        + 28 * 27 * a28 * Math.Pow(x, 26)
                        + 30 * 29 * a30 * Math.Pow(x, 28)
                        + 32 * 31 * a32 * Math.Pow(x, 30)
                        + 34 * 33 * a34 * Math.Pow(x, 32)
                        + 36 * 35 * a36 * Math.Pow(x, 34)
                        + 38 * 37 * a38 * Math.Pow(x, 36)
                        + 40 * 41 * a40 * Math.Pow(x, 38)
                        ;
            return (z);
        }
        ////*参数及其含义
        ///x(double[])：数组，表示已知的自变量节点，即插值点的横坐标。它是一个递增的数组，存储各个插值节点的横坐标值。

        ///y(double[])：数组，表示对应的因变量节点，即插值点的纵坐标。每个 y[i] 对应于 x[i]，表示插值点的纵坐标值。

        ///n(int)：整数，表示节点的数量，数组 x 和 y 的长度为 n+1，即有 n 个区间。

        ///yp1(double)：表示第一节点的边界条件，即插值曲线在 x[1] 处的一阶导数值。如果 yp1 非常大（如 9.9e+29），表示自然边界条件（第一节点二阶导数为零）。

        ///ypn(double)：表示最后一个节点的边界条件，即插值曲线在 x[n] 处的一阶导数值。如果 ypn 非常大，表示自然边界条件（最后一个节点二阶导数为零）。

        ///y2(double[])：数组，输出参数，表示每个节点的二阶导数值。该数组会被更新以存储插值函数在各个节点的二阶导数，用于后续的插值计算。

        ///内部变量及其含义
        ///u(double[])：临时数组，辅助变量，用于存储计算过程中中间的值。它用来帮助计算三次样条插值函数的二阶导数。

        ///aaa(double)：用于计算曲线在当前节点的斜率值，用于在递推过程中计算二阶导数时的中间量。

        ///sig(double)：表示相邻节点之间的距离比率，计算公式为： sig= (x[i]−x[i−1]) / (x[i + 1]−x[i−1]), sig 用于控制权重，衡量当前节点相对于两侧节点的位置关系。

        ///p(double)：辅助变量，用于解三对角矩阵时的递推计算，表示当前节点二阶导数的权重调整值。

        ///bbb(double)：表示相邻两个节点之间的斜率，用于计算当前节点的变化率。通过计算差值来获得斜率：bbb = (y[i]−y[i−1]) / (x[i]−x[i−1])

        ///ccc(double)：表示当前节点前后两个节点的横坐标差，用于计算二阶导数之间的关系。

        ///qn(double)：表示最后一个节点处的边界条件系数，主要用于处理边界的导数条件。

        ///un(double)：表示最后一个节点的右侧自由项，用于处理边界条件，计算导数时的中间量。

        ///循环变量及其含义
        ///i(int)：循环变量，用于遍历 x 和 y 的内部节点，即从第 1 节点到第 n-1 节点。它用于递推计算每个节点的二阶导数的初步值。

        ///k(int)：用于在回代过程中，从最后一个节点开始依次更新每个节点的二阶导数值。

        ///代码中各变量的作用解释
        ///x 和 y 数组存储了插值的节点信息，是输入数据。
        ///yp1 和 ypn 是给定的边界条件，分别用于控制曲线在首末节点处的一阶导数值。通过这些边界条件可以确定是自然边界还是非自然边界条件。
        /// y2 数组最终将存储每个节点处的二阶导数值，用于三次样条插值的计算。
        ///u 数组是一个辅助数组，保存中间计算值，用于加快三对角矩阵的求解过程。
        ///aaa、bbb、ccc 用于保存节点斜率和节点差，用于计算三次样条的插值系数。
        ///sig 和 p 共同决定了当前节点在整个区间上的权重。
        ///qn 和 un 用于处理最后一个节点的边界条件。
        ///i 用于遍历中间节点，逐个计算它们的二阶导数。
        ///k 用于在回代过程中，从后往前更新每个节点的二阶导数值。
        private void spline(double[] x, double[] y, int n, double yp1, double ypn, double[] y2)
        {
            double[] u = new double[200000];

            double aaa, sig, p, bbb, ccc, qn, un;
            int i, k;

            // 处理第一个边界条件，判断是否是自然边界条件
            if (yp1 > 9.9e+29)
            {
                y2[1] = 0;
                u[1] = 0;
            }
            else
            {
                y2[1] = -0.5;
                aaa = (y[2] - y[1]) / (x[2] - x[1]);
                u[1] = (3.0 / (x[2] - x[1])) * (aaa - yp1);
            }

            // 计算内部节点的 y2 值
            for (i = 1; i < n - 1; i++)
            {
                sig = (x[i] - x[i - 1]) / (x[i + 1] - x[i - 1]);
                p = sig * y2[i - 1] + 2.0;
                y2[i] = (sig - 1.0) / p;
                aaa = (y[i + 1] - y[i]) / (x[i + 1] - x[i]);
                bbb = (y[i] - y[i - 1]) / (x[i] - x[i - 1]);
                ccc = x[i + 1] - x[i - 1];
                u[i] = (6.0 * (aaa - bbb) / ccc - sig * u[i - 1]) / p;
            }

            // 处理最后一个边界条件，判断是否是自然边界条件
            if (ypn > 9.9e+29)
            {
                qn = 0.0;
                un = 0.0;
            }
            else
            {
                qn = 0.5;
                aaa = ypn - (y[n] - y[n - 1]) / (x[n] - x[n - 1]);
                un = (3.0 / (x[n] - x[n - 1])) * aaa;
            }

            // 计算最后一个节点的 y2 值
            y2[n] = (un - qn * u[n - 1]) / (qn * y2[n - 1] + 1.0);
            // 使用回代法计算所有节点的 y2 值
            for (k = n - 1; k >= 1; k--)
                y2[k] = y2[k] * y2[k + 1] + u[k];
        }

        ///代码中的每个部分详解
        ///1.变量的初始化
        ///xa 和 ya：分别表示样条插值的节点自变量和因变量数组。
        ///y2：数组，存储在各个节点处的二阶导数值（通过 spline 函数计算得到）。
        ///n：节点的总数。
        ///x：要进行插值的点的横坐标。
        ///y：通过插值得到的结果。

        ///查找插值区间klo 和 khi：表示区间的下限和上限。初始时分别为 1 和 n,使用二分查找法找到给定 x 所在的区间[xa[klo], xa[khi]]。二分查找的目的是加快查找速度，时间复杂度为 O(logn)。

        ///计算区间宽度h = xa[khi] - xa[klo]：计算插值点所在区间的宽度。如果 h 为零，表示数据有问题（例如有重复的节点），因此函数会报错并返回。

        ///计算插值系数 a 和 b
        ///a = (xa[khi] - x) / h：表示插值点 x 距离右端点的比例。
        ///b = (x - xa[klo]) / h：表示插值点 x 距离左端点的比例。
        ///a 和 b 的和始终为 1，用于线性插值计算。

        ///计算插值值
        ///aaa = a * ya[klo] + b * ya[khi]：这是基于线性插值的部分，表示使用节点 ya[klo] 和 ya[khi] 的线性组合来估计 y。
        ///bbb = (a* a * a - a) * y2[klo] + (b* b * b - b) * y2[khi]：这是基于二阶导数的修正项，使用节点处的二阶导数来修正插值的值，使得曲线更加平滑。这部分的计算基于样条插值的特性，即通过二阶导数来调整曲线的形状，使得曲线在每个节点处具有二阶连续性。
        ///y = aaa + bbb* h * h / 6.0：最终插值结果。这里的修正项 bbb * h* h / 6.0 来自于样条插值的公式，通过引入节点的二阶导数来保证曲线的平滑性。
        private void splint(double[] xa, double[] ya, double[] y2, int n, double x, double y)
        {
            int klo, khi, k;
            double h, a, b, aaa, bbb;
            // 初始化查找区间的下限和上限
            klo = 1;
            khi = n;

        // 使用二分查找法确定 x 所在的区间
        loop: if (khi - klo > 1)
            {
                k = (khi + klo) / 2;  // 找到中间位置
                if (xa[k] > x)
                    khi = k;  // 如果 x 小于中间值，更新上限
                else
                {
                    klo = k;  // 否则，更新下限
                }
                goto loop;  // 继续循环，直到找到区间
            }

            // 计算区间宽度
            h = xa[khi] - xa[klo];
            if (h == 0)
            {
                // 如果区间宽度为零，表示输入的数据有问题
                MessageBox.Show("Error! Bad  xa  input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // 计算 a 和 b，分别为距离的比例
            a = (xa[khi] - x) / h;
            b = (x - xa[klo]) / h;
            // 计算插值的值 aaa
            aaa = a * ya[klo] + b * ya[khi];
            // 计算对二阶导数部分的修正 bbb
            bbb = (a * a * a - a) * y2[klo] + (b * b * b - b) * y2[khi];
            // 得到插值结果
            y = aaa + bbb * h * h / 6.0;
            z = y;
        }

        private void spline_diff(double[] xa, double[] ya, double[] y2, int n, double x, double y)
        {
            int klo, khi, k;
            double h, a, b, c;

            // 初始化查找区间的下限和上限
            klo = 1;
            khi = n;

        // 使用二分查找法确定 x 所在的区间
        loop: if (khi - klo > 1)
            {
                k = (khi + klo) / 2;  // 找到中间位置
                if (xa[k] > x)
                    khi = k;  // 如果 x 小于中间值，更新上限
                else
                {
                    klo = k;  // 否则，更新下限
                }
                goto loop;  // 继续循环，直到找到区间
            }

            // 计算区间宽度
            h = xa[khi] - xa[klo];
            if (h == 0)
            {
                // 如果区间宽度为零，表示输入的数据有问题
                MessageBox.Show("Error! Bad  xa  input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            /*
            a = (xa[khi] - x) / h;
            b = (x - xa[klo]) / h;
            aaa = a * ya[klo] + b * ya[khi];
            bbb = (a * a * a - a) * y2[klo] + (b * b * b - b) * y2[khi];
            y = aaa + bbb * h * h / 6.0;
            */

            // 计算导数
            a = (xa[khi] - x);
            b = (x - xa[klo]);
            c = ya[khi] - ya[klo];

            // 使用样条函数的导数公式计算 y 值
            y = (-0.5 * a * a / h + h / 6.0) * y2[klo] + (0.5 * b * b / h - h / 6.0) * y2[khi] + c / h;
            diff_z = y;

        }


        //MainForm_Load 方法，负责在窗体加载时进行初始化操作。代码的主要功能是读取配置文件 parameter.ini 中的参数值，并将这些值加载到用户界面的各个控件中，进行初始化
        //MainForm_Load 是一个事件处理函数，它在窗体（MainForm）加载时被触发,object sender, EventArgs e 是事件处理的标准参数，其中 sender 是触发事件的对象，e 包含事件的相关信息
        private void MainForm_Load(object sender, EventArgs e)
        {
            //用于显示程序启动的时间，通常用于提示用户当前系统时间或作为时间戳
            timeLabel3.Text = DateTime.Now.ToString();
            //计时器可以让界面动态更新或进行一些重复的后台操作
            timer1.Enabled = true;

            //读取配置文件 (parameter.ini)
            if (File.Exists("parameter.ini"))
            {
                StreamReader sr = new StreamReader("parameter.ini");
                try
                {
                    //逐行读取配置文件的内容，并将其赋值给窗体中的控件
                    //这里 numericUpDown1 到 numericUpDown_speed 等控件是数值输入控件，使用 decimal.Parse() 将读取的字符串转换为 decimal 类型，再赋值给控件。
                    //textBox0 到 textBox30 表示多个文本框，它们的内容直接从文件中读取字符串并赋值。
                    numericUpDown1.Value = decimal.Parse(sr.ReadLine());
                    numericUpDown2.Value = decimal.Parse(sr.ReadLine());

                    textBox2.Text = sr.ReadLine();
                    textBox4.Text = sr.ReadLine();
                    textBox6.Text = sr.ReadLine();
                    textBox8.Text = sr.ReadLine();
                    textBox10.Text = sr.ReadLine();
                    textBox12.Text = sr.ReadLine();
                    textBox14.Text = sr.ReadLine();
                    textBox16.Text = sr.ReadLine();
                    textBox18.Text = sr.ReadLine();
                    textBox20.Text = sr.ReadLine();
                    textBox22.Text = sr.ReadLine();
                    textBox24.Text = sr.ReadLine();
                    textBox26.Text = sr.ReadLine();
                    textBox28.Text = sr.ReadLine();
                    textBox30.Text = sr.ReadLine();
                    textBox32.Text = sr.ReadLine();
                    textBox34.Text = sr.ReadLine();
                    textBox36.Text = sr.ReadLine();
                    textBox38.Text = sr.ReadLine();
                    textBox40.Text = sr.ReadLine();

                    numericUpDown_r.Value = decimal.Parse(sr.ReadLine());
                    numericUpDown_step.Value = decimal.Parse(sr.ReadLine());
                    numericUpDown_speed.Value = decimal.Parse(sr.ReadLine());
                    numericUpDown_feedrate.Value = decimal.Parse(sr.ReadLine());
                    numericUpDown_startx.Value = decimal.Parse(sr.ReadLine());
                    numericUpDown_endx.Value = decimal.Parse(sr.ReadLine());

                    XcenterNumericUpDown1.Value = decimal.Parse(sr.ReadLine());
                    partXcenterNumericUpDown2.Value = decimal.Parse(sr.ReadLine());

                    //从配置文件中读取一个整型值，判断该值是否为 0，来确定哪个单选按钮被选中
                    //这种逻辑用于恢复用户之前在界面上的设置，以保证下次使用时保持一致性
                    //这里的逻辑处理了两组单选按钮，分别是 aoRadioButton3/tuRadioButton1 和 linearRadioButton1/circleRadioButton2
                    if (int.Parse(sr.ReadLine()) == 0)
                    {
                        aoRadioButton3.Checked = true;
                        tuRadioButton1.Checked = false;
                    }
                    else
                    {
                        aoRadioButton3.Checked = false;
                        tuRadioButton1.Checked = true;
                    }
                    if (int.Parse(sr.ReadLine()) == 0)
                    {
                        linearRadioButton1.Checked = true;
                        circleRadioButton2.Checked = false;
                    }
                    else
                    {
                        linearRadioButton1.Checked = false;
                        circleRadioButton2.Checked = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                finally
                {
                    sr.Close();
                }
            }

        }

        private void button_Create_Click(object sender, EventArgs e)
        {
            #region 初始化变量
            double zmiddle;

            ///加工步进段数
            int stepNumber = 0;
            double[] G010203 = new double[200000];  //加工指令代码,直线01，顺时针圆弧02，逆时针圆弧03
            double[] r = new double[200000];  //半径
            double[] xnode = new double[200000];  //节点x坐标
            double[] znode = new double[200000];  //节点z坐标
            double[] angle = new double[200000];  //角度
            double[] znode_error = new double[200000];  //误差值

            double[] angle2 = new double[200000];
            double[] angle_nihe = new double[200000];

            /* 参数数值
              a1 = double.Parse(textBox1.Text);
              a1 = 9.612148E-29;
              a2 = -1.234598E-25;
              a3 = 7.202522E-23;
              a4 = -2.52627E-20;

              a5 = 5.942889E-18; 
              a6 = -9.902994E-16;
              a7 = 1.203394E-13;
              a8 = -1.081441E-11;
              a9 = 7.210597E-10;
              a10 = -3.546260E-8;

              a11 = 1.267527E-6;
              a12 = -3.214115E-5;
              a13 = 5.609625E-4;
              a14 = -3.399005E-3;
              a15 = 5.700426E-2;
              a16 = -13.5993; 
             */

            c = (double)numericUpDown1.Value;
            k = (double)numericUpDown2.Value;
            //double aa = 359.05;
            //double bb = 169.58;

            //c = aa / Math.Pow(bb, 2);
            //k = Math.Pow(bb, 2) / Math.Pow(aa, 2) - 1;
            try
            {
                //文本框中读取一系列参数值（例如 a0 到 a30），这些参数用于定义加工轨迹的函数，可能是高次多项式的系数。
                a2 = double.Parse(textBox2.Text);
                a4 = double.Parse(textBox4.Text);
                a6 = double.Parse(textBox6.Text);
                a8 = double.Parse(textBox8.Text);
                a10 = double.Parse(textBox10.Text);
                a12 = double.Parse(textBox12.Text);
                a14 = double.Parse(textBox14.Text);
                a16 = double.Parse(textBox16.Text);
                a18 = double.Parse(textBox18.Text);
                a20 = double.Parse(textBox20.Text);
                a22 = double.Parse(textBox22.Text);
                a24 = double.Parse(textBox24.Text);
                a26 = double.Parse(textBox26.Text);
                a28 = double.Parse(textBox28.Text);
                a30 = double.Parse(textBox30.Text);
                a32 = double.Parse(textBox32.Text);
                a34 = double.Parse(textBox34.Text);
                a36 = double.Parse(textBox36.Text);
                a38 = double.Parse(textBox38.Text);
                a40 = double.Parse(textBox40.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            //这些变量从数值输入控件中读取
            tool_r = (double)numericUpDown_r.Value;  //工具半径
            feedrate = (double)numericUpDown_feedrate.Value;  //进给速度
            spindleSpeed = (double)numericUpDown_speed.Value;  //主轴速度
            step = (double)numericUpDown_step.Value;  //步长
            startx = (double)numericUpDown_startx.Value;  //加工起始位置
            endx = (double)numericUpDown_endx.Value;  //加工结束位置
            grindingSpeed = (double)nUDGrindingSpeed.Value;

            //验证了一些关键参数的合理性
            if ((1 - (k + 1) * Math.Pow(c, 2) * Math.Pow(startx, 2)) < 0)
            {
                MessageBox.Show("The StartX point is not on the shape!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if ((1 - (k + 1) * Math.Pow(c, 2) * Math.Pow(endx, 2)) < 0)
            {
                MessageBox.Show("The EndX point is not on the shape!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (step <= 0)
            {
                MessageBox.Show("The step must be large than 0 !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (spindleSpeed <= 0)
            {
                MessageBox.Show("The spindleSpeed must be large than 0 !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (feedrate <= 0)
            {
                MessageBox.Show("The feedrate must be large than 0 !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (startx == endx)
            {
                MessageBox.Show("The StartX point can't be same to the EndX point!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //清空之前的数据，以准备插入新的加工路径数据
            dataGridView1.Rows.Clear();
            #endregion

            if (光学普适方程ToolStripMenuItem.Checked)
            {
                //根据起始和结束位置、步进距离计算出路径点数
                pointNum = (int)Math.Floor((Math.Abs(endx - startx) / step)) + 1;

                //如果所有多项式系数均为零，则设置为简单的水平直线段
                if (c == 0 & a14 == 0 & a12 == 0 & a10 == 0 & a8 == 0 & a6 == 0 & a4 == 0
                              & a2 == 0)
                {
                    xnode[0] = startx;
                    znode[0] = 0;
                    xnode[1] = endx;
                    znode[1] = 0;
                    angle[0] = 0;
                    G010203[0] = 1;
                    angle[1] = 0;
                    G010203[1] = 1;
                    stepNumber = 1;
                }
                //如果选中了 linearRadioButton1，则执行线性插补。
                else if (linearRadioButton1.Checked) // 线性插补
                {

                    for (int i = 0; i < pointNum; i++)
                    {
                        if (startx < endx)
                        {
                            //通过步进计算每个点的横坐标 xnode[i]
                            xnode[i] = startx + i * step;
                        }
                        else
                        {
                            xnode[i] = startx - i * step;
                        }
                        //使用函数 fx(x) 计算纵坐标 znode[i]，这个函数可能是用户定义的曲线函数
                        znode[i] = fx(xnode[i]);
                        //使用 diff_fx(x) 计算斜率并通过 Math.Atan() 得到每个点的角度 angle[i]
                        angle[i] = Math.Atan(diff_fx(xnode[i]));
                        //设置加工指令代码 G010203[i] = 1，表示直线插补
                        G010203[i] = 1;

                        //dataGridView1.Rows.Add((i + 1).ToString(), xnode[i].ToString(), znode[i].ToString("0.000000"), "0");
                    }
                    stepNumber = pointNum - 1;

                }
                // 双圆弧拟合插补是一种更复杂的路径生成方式，用于生成更加平滑的路径，其核心思想是利用圆弧的几何性质，尽量拟合原始轨迹。
                else
                {
                    //x1 和 x2 分别表示当前段的起点和终点，初始为 startx。
                    //xA 和 xB 在二分法迭代中被用于调整当前拟合的区间范围。
                    //z1 和 z2 是起点和终点的纵坐标，由函数 fx(x) 计算得到。
                    //zp 是计算得到的两个圆弧拟合点的 z 坐标，用于确定圆弧的中心点
                    double xA, xB, x1, x2, z1, z2, xp = 0, zp = 0;
                    //theta1：起点 x1 处的斜率角度，通过 Math.Atan(k1) 计算得到，其中 k1 = diff_fx(x1) 表示曲线在 x1 点处的导数。
                    //theta2：终点 x2 处的斜率角度，计算方法同上。
                    //thetaP：拟合圆弧在中间点处的角度
                    double theta1 = 0, theta2, thetaP = 0, theta;
                    //k1 和 k2：分别是起点 x1 和终点 x2 处曲线的导数。
                    //k3：表示曲线在两个点之间的平均斜率，计算为(z2 - z1) / (x2 - x1)。
                    //kp：拟合圆弧在中心点的斜率，用于确定圆心位置
                    //xcenter1 和 zcenter1 是拟合的第一个圆弧的圆心坐标。
                    //xcenter2 和 zcenter2 是第二个圆弧的圆心坐标。
                    //R1 是拟合的第一个圆弧的半径。
                    //R2 是拟合的第二个圆弧的半径。
                    double k1, k2, kp, k3, xcenter1 = 0, zcenter1 = 0, xcenter2, zcenter2, R1 = 0, R2 = 0;
                    int n = 0, number = 0;

                    //初始化了用于拟合的变量，开始位置设为 startx。
                    x1 = startx;
                    dataGridView1.Rows.Clear();

                    while (Math.Abs(x1 - endx) > 0.5 * step)
                    {
                        double error = 1;   //控制误差收敛
                        ///临时定义的记录G01G02G03选择
                        ///G01 表示直线插补。
                        ///G02 表示顺时针圆弧插补。
                        ///G03 表示逆时针圆弧插补。
                        int G123 = 1;
                        //判断加工方向，如果 startx < endx，表示正向加工，x2 = x1 + step；否则反向加工
                        if (startx < endx)
                        {
                            x2 = x1 + step;
                        }
                        else x2 = x1 - step;

                        while (error > Math.Pow(10, -5))
                        {
                            z1 = fx(x1);
                            z2 = fx(x2);
                            k1 = diff_fx(x1);
                            k2 = diff_fx(x2);
                            k3 = (z2 - z1) / (x2 - x1);    //？？
                            theta1 = Math.Atan(k1);
                            theta2 = Math.Atan(k2);
                            theta = Math.Atan(k3);

                            //使用公式计算拟合圆弧的中间点 (xp, zp)
                            xp = ((z1 - z2) + x2 * Math.Tan((theta2 + theta) / 2) - x1 * Math.Tan((theta1 + theta) / 2)) / (Math.Tan((theta2 + theta) / 2) - Math.Tan((theta1 + theta) / 2));
                            zp = z1 + (xp - x1) * Math.Tan((theta1 + theta) / 2);
                            if (k1 != 0 & k2 != 0)
                            {
                                xcenter1 = ((zp - z1) + ((x2 - x1) / (z2 - z1)) * xp - x1 / k1) / ((x2 - x1) / (z2 - z1) - 1 / k1);       //？？？？？？？？？？？
                                xcenter2 = ((zp - z2) + ((x2 - x1) / (z2 - z1)) * xp - x2 / k2) / ((x2 - x1) / (z2 - z1) - 1 / k2);
                                zcenter1 = z1 - (xcenter1 - x1) / k1;
                                zcenter2 = z2 - (xcenter2 - x2) / k2;
                                R1 = Math.Sqrt(Math.Pow((xcenter1 - x1), 2) + Math.Pow((zcenter1 - z1), 2));
                                R2 = Math.Sqrt(Math.Pow((xcenter2 - x2), 2) + Math.Pow((zcenter2 - z2), 2));

                            }

                            double x, z, z0, zA, zB;  //x、z：用于中间点的横纵坐标，z0：用于存储拟合圆弧上的某个 z 坐标值，zA、zB：用于辅助计算的 z 坐标
                            xA = x1;
                            xB = x2;
                            x = (xA + xB) / 2;
                            z = fx(x);
                            //z0 和 zA 分别表示拟合圆弧上 x 和 x1 对应的 z 坐标，利用直线方程的形式计算得出。
                            z0 = -(x - xp) / k3 + zp;
                            zA = -(x1 - xp) / k3 + zp;

                            while ((z - z0) > Math.Pow(10, -5))
                            {
                                x = (xA + xB) / 2;
                                z = fx(x);
                                z0 = -(x - xp) / k3 + zp;

                                if ((zA - zp) * (z0 - zp) > 0)
                                {
                                    xA = x;
                                }
                                else xB = x;

                            }
                            error = Math.Sqrt(Math.Pow(xp - x, 2) + Math.Pow(zp - z, 2));

                            if (error > Math.Pow(10, -5))
                            {
                                x2 = (x1 + x2) / 2;
                            }
                        }
                        if (aoRadioButton3.Checked)
                        //根据工具半径 tool_r 来调整拟合圆弧的半径 R1 和 R2，考虑刀具半径补偿。
                        {
                            if (x1 < x2)
                            {
                                G123 = 2;
                                R1 = R1 - tool_r;
                                R2 = R2 - tool_r;
                            }
                            else
                            {
                                G123 = 3;
                                R1 = R1 - tool_r;
                                R2 = R2 - tool_r;
                            }
                        }
                        else
                        {
                            if (x1 < x2)
                            {
                                G123 = 3;
                                R1 = R1 + tool_r;
                                R2 = R2 + tool_r;
                            }
                            else
                            {
                                G123 = 2;
                                R1 = R1 + tool_r;
                                R2 = R2 + tool_r;
                            }
                        }
                        //计算中间点的斜率 kp，并由此求得圆弧在中间点的切线角度 thetaP
                        kp = (zp - zcenter1) / (xp - xcenter1);
                        thetaP = Math.Atan(-1 / kp);

                        //将起点的信息存入相应数组
                        xnode[n] = x1; znode[n] = fx(x1); r[n] = R1; G010203[n] = G123; angle[n] = theta1;
                        n++;
                        //dataGridView1.Rows.Add(n.ToString(),xnode[n].ToString(),znode[n].ToString());

                        //将拟合得到的中间点信息存入相应数组，并更新当前起点为原来的终点，进行下一段圆弧插补。
                        xnode[n] = xp; znode[n] = zp; r[n] = R2; G010203[n] = G123; angle[n] = thetaP;
                        n++;
                        x1 = x2;
                        //dataGridView1.Rows.Add(n.ToString(), xnode[n].ToString(), znode[n].ToString(),error.ToString());

                        error_nihe[number] = error;
                        number++;
                    }
                    //最后将终点的信息存入相应数组，并计算其切线角度
                    xnode[n] = endx; znode[n] = fx(endx); G010203[n] = 1;
                    angle[n] = Math.Atan(diff_fx(xnode[n]));
                    stepNumber = n;
                }

            }
            //离散点云线性插补
            else
            {
                pointNum = inputPointNum;  //设置 pointNum 为输入的离散点数量
                for (int i = 0; i < pointNum; i++)
                {
                    xnode[i] = x_point[i];
                    znode[i] = z_point[i];
                    angle_nihe[i] = Math.Atan(diff_fx(xnode[i]));
                    G010203[i] = 1;

                    angle2[i] = (phi[i] - sata[i]) / 2;//给定的理论斜率角度，副面反射镜

                    //angle2[i] = phi[i] / 2;//给定的理论斜率角度，主面反射镜

                }
                stepNumber = pointNum - 1;
            }

            chart1.Series[0].Points.Clear();
            //chart1.ChartAreas[0].AxisX.Minimum = 0;

            for (int i = 0; i <= stepNumber; i++)
            {
                //liu[02]
                if (aoRadioButton3.Checked)
                {
                    znode[i] = znode[i];
                    angle[i] = angle[i];
                }
                else
                {
                    znode[i] = -znode[i];
                    angle[i] = -angle[i];
                }

                chart1.Series[0].Points.AddXY(xnode[i], znode[i]);   //工件曲线
            }

            ///补偿数据中，中点位置。用于把程序xnode[i]位置，转换到补偿数据的X位置。
            double partXcenter;   //存储补偿的中心位置
            partXcenter = (double)partXcenterNumericUpDown2.Value;
            // x_number = new double[] { 0, 20, 40, 60, 80, 100, 120, 140, 160, 180, 200, 220, 240, 260, 280, 300, 320, 340, 360, 380 };
            // z_error = new double[] {-0.006,0.506,0.87,1.158,1.432,1.658,1.86,2.054,2.294,2.48,2.728,2.946,
            //                               3.186,3.368,3.68,3.93,4.198,4.548,4.888,5.272};
            //垂直度补偿数据
            x_number = new double[] { 0, 20, 40, 60, 80, 100, 120, 140, 160, 180, 200, 220, 240, 260, 280, 300, 320, 340, 360, 380 };
            z_error = new double[] {0, 0.13, 0.26,0.39,0.52,0.65,0.78,0.91,1.04,1.17,1.3,1.43,
                                              1.56,1.69,1.82,1.95,2.08,2.21,2.34,2.47};
            //单位从um变化成mm
            for (int j = 0; j < z_error.Length; j++)
            {
                z_error[j] = 0.001 * z_error[j];
            }
            //垂直度误差补偿
            if (streightErrorCheckBox1.Checked)
            {
                //根据垂直度补偿数据，拟合直线，计算垂直度参数a,b。其实a没用。
                fit(x_number, z_error, z_error.Length);

                for (int i = 0; i <= stepNumber; i++)
                {
                    znode_error[i] = a + b * (partXcenter - xnode[i]);
                    znode[i] = znode[i] - znode_error[i];
                }
            }

            //面型误差补偿
            if (pvErrorCheckBox1.Checked)
            {
                for (int i = 0; i <= stepNumber; i++)
                {
                    x = xnode[i];
                    spline(x_pv, z_pv, x_pv.Length - 1, 0, Math.Pow(10, 30), y2);
                    splint(x_pv, z_pv, y2, x_pv.Length - 1, x, z);

                    znode[i] = znode[i] - z;
                }
            }

            //double D = Math.Max(startx, endx);
            //chart1.ChartAreas[0].Axes[0].Minimum = Math.Min(startx, endx);
            //chart1.ChartAreas[0].Axes[0].Maximum = D;
            //chart1.ChartAreas[0].Axes[0].Interval = 0.1 * Math.Abs(startx - endx);
            //chart1.Series[0].Color = Color.Red;


            chart1.Series[1].Points.Clear();

            //刀具半径补偿
            for (int i = 0; i <= stepNumber; i++)
            {
                if (离散点ToolStripMenuItem.Checked) angle[i] = angle2[i] * Math.PI / 180;

                if (angle[i] > 1.57)
                {
                    angle[i] = Math.PI / 2;
                }
                /*//liu[02]
                if (aoRadioButton3.Checked)
                {
                    xnode[i] = xnode[i] - tool_r * Math.Sin(angle[i]);
                    znode[i] = znode[i] + tool_r * Math.Cos(angle[i]);
                }
                else
                {
                    xnode[i] = xnode[i] + tool_r * Math.Sin(angle[i]);
                    znode[i] = znode[i] - tool_r * Math.Cos(angle[i]);
                }
                */
                //liu[02]
                xnode[i] = xnode[i] - tool_r * Math.Sin(angle[i]);
                znode[i] = znode[i] + tool_r * Math.Cos(angle[i]);
                /*
                if (aoRadioButton3.Checked)
                {
                    xnode[i] = xnode[i] - tool_r * Math.Sin(angle[i]);
                    znode[i] = znode[i] + tool_r * Math.Cos(angle[i]);
                }
                else
                {
                    xnode[i] = xnode[i] + tool_r * Math.Sin(angle[i]);
                    znode[i] = -znode[i] + tool_r * Math.Cos(angle[i]);
                }
                */


                //起始点为加工时对零点
                //  x_absolute[i] = Math.Abs(x00 - xnode[i]);  //liu[02]
                //  z_absolute[i] = Math.Abs(z00 - znode[i]);
            }

            if (checkBoxCMP1.Checked && !UV3P_NULL)
            {
                for (int i = 0; i <= stepNumber; i++)
                {
                    znode[i] -= UV3P_result01[0]
                                + UV3P_result01[1] * xnode[i]
                                + UV3P_result01[2] * xnode[i] * xnode[i]
                                + UV3P_result01[3] * xnode[i] * xnode[i] * xnode[i]
                                + UV3P_result01[4] * xnode[i] * xnode[i] * xnode[i] * xnode[i];
                }
            }
            if (checkBoxCMP2.Checked && !UV3P_NULL)
            {
                for (int i = 0; i <= stepNumber; i++)
                {
                    znode[i] -= UV3P_result02[0]
                                + UV3P_result02[1] * xnode[i]
                                + UV3P_result02[2] * xnode[i] * xnode[i]
                                + UV3P_result02[3] * xnode[i] * xnode[i] * xnode[i]
                                + UV3P_result02[4] * xnode[i] * xnode[i] * xnode[i] * xnode[i];
                }
            }
            if (checkBoxCMP3.Checked && !UV3P_NULL)
            {
                for (int i = 0; i <= stepNumber; i++)
                {
                    znode[i] -= UV3P_result03[0]
                                + UV3P_result03[1] * xnode[i]
                                + UV3P_result03[2] * xnode[i] * xnode[i]
                                + UV3P_result03[3] * xnode[i] * xnode[i] * xnode[i]
                                + UV3P_result03[4] * xnode[i] * xnode[i] * xnode[i] * xnode[i];
                }
            }
            if (checkBoxCMP4.Checked && !UV3P_NULL)
            {
                for (int i = 0; i <= stepNumber; i++)
                {
                    znode[i] -= UV3P_result04[0]
                                + UV3P_result04[1] * xnode[i]
                                + UV3P_result04[2] * xnode[i] * xnode[i]
                                + UV3P_result04[3] * xnode[i] * xnode[i] * xnode[i]
                                + UV3P_result04[4] * xnode[i] * xnode[i] * xnode[i] * xnode[i];
                }
            }
            if (checkBoxCMP5.Checked && !UV3P_NULL)
            {
                for (int i = 0; i <= stepNumber; i++)
                {
                    znode[i] -= UV3P_result05[0]
                                + UV3P_result05[1] * xnode[i]
                                + UV3P_result05[2] * xnode[i] * xnode[i]
                                + UV3P_result05[3] * xnode[i] * xnode[i] * xnode[i]
                                + UV3P_result05[4] * xnode[i] * xnode[i] * xnode[i] * xnode[i];
                }
            }

            double x00 = xnode[stepNumber];
            double z00 = znode[stepNumber];

            for (int i = 0; i <= stepNumber; i++)//liu[01]
            {
                //liu[01]
                x_absolute[i] = xnode[i] - x00;
                z_absolute[i] = znode[i] - z00;

                //   dataGridView1.Rows.Add((i + 1).ToString(), xnode[i].ToString("0.000000"), znode[i].ToString("0.000000"), sata[i].ToString("0.00000"), phi[i].ToString("0.00000"), (angle[i] * 180 / Math.PI).ToString("0.0000"), (angle_nihe[i] * 180 / Math.PI).ToString("0.0000"));

                dataGridView1.Rows.Add((i + 1).ToString(), xnode[i].ToString("0.000000"), (znode[i] - tool_r).ToString("0.000000"));
                //绘图还是绘制的刀圆心轨迹
                chart1.Series[1].Points.AddXY(xnode[i], znode[i] - tool_r);  //编程曲线
            }


            daojuStartX_numericUpDown4.Value = (decimal)xnode[0];
            daojuEndX_numericUpDown3.Value = (decimal)xnode[stepNumber];

            if (c == 0 & a14 == 0 & a12 == 0 & a10 == 0 & a8 == 0 & a6 == 0 & a4 == 0
                        & a2 == 0)
            {
                chart1.ChartAreas[0].Axes[1].Minimum = -0.01;
                chart1.ChartAreas[0].Axes[1].Maximum = 0.01;
                chart1.ChartAreas[0].Axes[1].Interval = 0.005;
            }
            else
            {
                //chart1.ChartAreas[0].Axes[1].Minimum =Math.Floor(Math.Min(znode[0], fx(endx)));
                //chart1.ChartAreas[0].Axes[1].Maximum =Math.Ceiling(Math.Max(znode[0], fx(endx)));
                //chart1.ChartAreas[0].Axes[1].Interval = (chart1.ChartAreas[0].Axes[1].Maximum - chart1.ChartAreas[0].Axes[1].Minimum) / 5;
            }

            #region 输出NC文件
            StreamWriter sw = new StreamWriter("NC program.txt");
            //sw.WriteLine(DateTime.Now.ToString());
            //sw.WriteLine(" ");
            //Write the beginning of the NC program 
            sw.WriteLine("%");
            //sw.WriteLine("N0001 G54 T01 G90 G21 G18 ");
            sw.WriteLine(comboBoxG54.Text + " T01 G90 G21 G18 ");
            //sw.WriteLine("N0001 G54 G90.1 G21 G18 ");
            /*
            if (startx < endx)
            {
                //sw.WriteLine("N0001 G01 X2*(-2) F100 ");
                // sw.WriteLine("N0002 G01 Z-2*(-1) F100");
                sw.WriteLine("N0001 G01 X-4 F100 ");
                sw.WriteLine("N0002 G01 Z2 F100");
            }
            else
            {
                //sw.WriteLine("N0001 G01 X-2*(-2) F100");
                //sw.WriteLine("N0002 G01 Z-2*(-1) F100");
                sw.WriteLine("N0001 G01 X4 F100");
                sw.WriteLine("N0002 G01 Z2 F100");
            }
            */
            //sw.WriteLine("N0002 G00 Z" + (z_absolute[0] + 100).ToString("0.000000"));
            if (startx > 0 || endx > 0)
            {
                sw.WriteLine("M04 S" + spindleSpeed.ToString());
            }
            else if (startx < 0 || endx < 0)
            {
                sw.WriteLine("M03 S" + spindleSpeed.ToString());
            }

            #region 延伸加工
            Pt PtNewA = new Pt();
            Pt PtNewB = new Pt();
            Pt PtNewC = new Pt();
            Pt PtNewD = new Pt();
            Pt PtNewZ = new Pt();
            int ExCnt = 10;
            if (checkBoxExt.Checked && (Ext_NULL == false) && (ExtIndex >= 2))
            {
                //第1点
                CalcEx.LinePan(new Pt(ExtPtx[0], ExtPtz[0]), new Pt(ExtPtx[1], ExtPtz[1]), tool_r, out PtNewA, out PtNewB);
                sw.WriteLine("G00 X" + (PtNewA.X + 1).ToString("0.000000"));
                sw.WriteLine("G00 Z" + (PtNewA.Y + 1).ToString("0.000000"));
                sw.WriteLine("G01 X" + " F" + feedrate.ToString(""));
                //后续点
                for (int j = 1; j < ExtIndex; j++)
                {
                    if (ExtType[j] == 2)
                    {
                        //半径为0的判断
                        if (ExtR[j] == 0)
                        {
                            if (ExtType[j + 1] == 1)
                            {
                                CalcEx.LinePan(new Pt(ExtPtx[j], ExtPtz[j]), new Pt(ExtPtx[j + 1], ExtPtz[j + 1]), tool_r, out PtNewA, out PtNewB);
                                ExCnt++;
                                sw.WriteLine(" G02 X" + PtNewA.X.ToString("0.000000") +
                                    " Z" + PtNewA.Y.ToString("0.000000") + " R" + (ExtR[0] + tool_r).ToString("0.00000"));
                            }
                            else//不可能后接圆
                            {

                            }
                        }
                        else
                        {
                            bool beG02 = true;
                            CalcEx.CirclePanB(new Pt(ExtPtx[j], ExtPtz[j]), ExtR[j], new Pt(ExtCx[j], ExtCz[j]), tool_r, out PtNewB, out beG02);
                            ExCnt++;
                            sw.WriteLine((beG02 ? " G02 X" : " G03 X") + PtNewB.X.ToString("0.000000") +
                                " Z" + PtNewB.Y.ToString("0.000000") + " R" + (beG02 ? (ExtR[j] + tool_r) : (ExtR[j] - tool_r)).ToString("0.00000"));
                        }
                    }
                    //直线
                    else  //(ExtType[j] == 1
                    {
                        CalcEx.LinePan(new Pt(ExtPtx[j - 1], ExtPtz[j - 1]), new Pt(ExtPtx[j], ExtPtz[j]), tool_r, out PtNewA, out PtNewB);
                        ExCnt++;
                        sw.WriteLine(" G01 X" + PtNewB.X.ToString("0.000000")
                                     + " Z" + PtNewB.Y.ToString("0.000000"));
                    }
                }
            }
            else
            {
                sw.WriteLine("G00 X" + x_absolute[0].ToString("0.000000"));
                sw.WriteLine("G00 Z" + z_absolute[0].ToString("0.000000"));
                sw.WriteLine("G01 F" + feedrate.ToString(""));
                sw.WriteLine("X" + x_absolute[0].ToString("0.000000") + " Z" + z_absolute[0].ToString("0.000000"));
            }
            #endregion

            //Write the middle of the NC program   
            int line_count = 0;
            for (int i = 0; i < stepNumber; i++)
            {
                //Liu[02]注释
                /*
                //凹面时根据走刀方向，修改坐标正负号
                if (aoRadioButton3.Checked)
                {
                    if (startx < endx)
                    {
                        z_absolute[i + 1] = -z_absolute[i + 1];
                        x_absolute[i + 1] = -x_absolute[i + 1];
                    }
                }
                //凸面时根据走刀方向，修改坐标正负号
                else
                {
                    if (startx < endx)
                    {
                        x_absolute[i + 1] = -x_absolute[i + 1];
                    }
                    else
                    {
                        z_absolute[i + 1] = -z_absolute[i + 1];
                    }
                }
                */

                if (G010203[i + 1] == 1)
                {
                    //不用每行都加G01
                    //sw.WriteLine("N" + (i + 10).ToString().PadLeft(4, '0') + " G01 X" + x_absolute[i + 1].ToString("0.000000") +
                    //        " Z" + (z_absolute[i + 1]).ToString("0.000000"));
                    sw.WriteLine(" X" + x_absolute[i + 1].ToString("0.000000") +
                            " Z" + (z_absolute[i + 1]).ToString("0.000000"));

                }
                else if (G010203[i + 1] == 2)
                {
                    sw.WriteLine(" G02 X" + (x_absolute[i + 1]).ToString("0.000000") +
                        " Z" + (z_absolute[i + 1]).ToString("0.000000") + " R" + r[i].ToString("0.00000"));
                }
                else
                {
                    sw.WriteLine(" G03 X" + (x_absolute[i + 1]).ToString("0.000000") +
                        " Z" + (z_absolute[i + 1]).ToString("0.000000") + " R" + r[i].ToString("0.00000"));
                }
                line_count = i;
            }

            //Write the end of the NC program 
            /*
            //凹面时，添加退刀代码
            if (aoRadioButton3.Checked)
            {
                if (startx > endx)
                {
                    sw.WriteLine("N" + (line_count + 20).ToString().PadLeft(4, '0') + " G01 Z-2 F100");
                    sw.WriteLine("N" + (line_count + 21).ToString().PadLeft(4, '0') + " M05");
                    sw.WriteLine("N" + (line_count + 22).ToString().PadLeft(4, '0') + " G01 X-2 F100");
                }
                else
                {
                    sw.WriteLine("N" + (line_count + 20).ToString().PadLeft(4, '0') + " G01 Z" + (z_absolute[stepNumber] - 2).ToString("0.00000") + " F100");
                    sw.WriteLine("N" + (line_count + 21).ToString().PadLeft(4, '0') + " M05");
                    sw.WriteLine("N" + (line_count + 22).ToString().PadLeft(4, '0') + " G01 X2 F100");
                }
            }
            //凸面时，添加退刀代码
            else
            {
                if (startx > endx)
                {
                    sw.WriteLine("N" + (line_count + 20).ToString().PadLeft(4, '0') + " G01 Z" + (z_absolute[stepNumber] - 2).ToString("0.00000") + " F100");
                    sw.WriteLine("N" + (line_count + 21).ToString().PadLeft(4, '0') + " M05");
                    sw.WriteLine("N" + (line_count + 22).ToString().PadLeft(4, '0') + " G01 X-2 F100");
                }                                    
                else                                 
                {                                    
                    sw.WriteLine("N" + (line_count + 20).ToString().PadLeft(4, '0') + " G01 Z-2 F100");
                    sw.WriteLine("N" + (line_count + 21).ToString().PadLeft(4, '0') + " M05");
                    sw.WriteLine("N" + (line_count + 22).ToString().PadLeft(4, '0') + " G01 X2 F100");
                }
            }
            */
            /*
            if (c == 0 & a15 == 0 & a2 == 0 & a13 == 0 & a12 == 0 & a11 == 0 & a10 == 0 & a9 == 0 & a8 == 0 & a7 == 0 & a6 == 0 & a5 == 0 & a4 == 0
                         & a3 == 0 & a2 == 0 & a1 == 0)
            {
                sw.WriteLine("N" + (line_count + 23).ToString().PadLeft(4, '0') + " M30");
            }
            else sw.WriteLine("N" + (line_count + 23).ToString().PadLeft(4, '0') + " M99");
            */
            sw.WriteLine(" G01 Z" + (z_absolute[stepNumber] + 2).ToString("0.00000"));
            sw.WriteLine(" M05");
            sw.WriteLine(" G00 Z" + (z_absolute[stepNumber] + 50).ToString("0.00000"));
            sw.WriteLine(" M30");
            sw.WriteLine("%");

            MessageBox.Show("NC程序已生成!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            sw.Close();

            #endregion
            programListToolStripMenuItem.Enabled = programListButton1.Enabled = true;
            //saveToolStripButton.Enabled = saveToolStripMenuItem.Enabled = button_saveFigure.Enabled = true;

        }

        private void toolStripButton_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        //读取包含加工路径的文件，其中包括坐标和加工路径类型
        private void btnOpenExt_Click(object sender, EventArgs e)
        {
            string strline = "";
            OpenFileDialog fd = new OpenFileDialog();   // 创建打开文件对话框
            if (fd.ShowDialog() == DialogResult.OK)     // 如果用户选择了文件并点击了"确定"
            {
                ExtIndex = 0;    // 初始化索引
                //chart1.Series[0].Points.Clear();
                StreamReader sr = new StreamReader(fd.FileName);    // 打开所选文件
                strline = sr.ReadLine();     // 读取文件第一行（通常可能是表头）
                //   for (int i = 0; i < FFT_N; i++)，逐行读取文件内容，直到文件末尾
                while ((strline = sr.ReadLine()) != null)
                {
                    string[] line = strline.Split(sepa);   // 根据分隔符 `sepa` 将字符串拆分为数组
                    ExtPtx[ExtIndex] = Convert.ToDouble(line[0]);   // 读取 x 坐标并转换为 double
                    ExtPtz[ExtIndex] = double.Parse(line[1]);   // 读取 z 坐标并转换为 double
                    ExtType[ExtIndex] = Convert.ToDouble(line[2]);    // 读取路径类型（例如直线或圆弧）
                    if (ExtType[ExtIndex] == 2) //路径类型是圆弧
                    {
                        ExtR[ExtIndex] = Convert.ToDouble(line[3]);   // 圆弧半径
                        ExtCx[ExtIndex] = Convert.ToDouble(line[4]);   // 圆心的 x 坐标
                        ExtCz[ExtIndex] = Convert.ToDouble(line[5]);   // 圆心的 z 坐标
                    }
                    ExtIndex++;   // 增加路径数据的索引
                    if (ExtIndex >= ExtMaxNum)    // 如果路径数据超过最大值，跳出循环
                        break;
                    //string[] line = System.Text.RegularExpressions.Regex.Replace(strline.Trim(), @"[\s]+", " ").Split(" ".ToCharArray());
                }
                sr.Close();
                tbExtFilePath.Text = fd.FileName;   //将文件路径显示在文本框中
                Ext_NULL = false;   // 表示扩展路径数据已经被加载
            }
        }

        //根据加工路径数据生成数控（NC）代码
        private void buttonCreatNCC_Click(object sender, EventArgs e)
        {
            ///加工步进段数
            double[] r = new double[200000];   // 半径数组，用于存储每个路径段的圆弧半径
            double[] xnode = new double[200000];   // 节点 x 坐标
            double[] znode = new double[200000];   // 节点 z 坐标
            double[] angle = new double[200000];   // 节点角度，用于表示刀具路径的斜率
            int numPerRound;
            numPerRound = (int)numericUpDownNumPerRnd.Value;   // 每一圈的分段数，从用户输入控件中读取
            double stepC = 360.0 / numPerRound;    // 每段的角度步进，360度均分

            tool_r = (double)numericUpDown_r.Value;   // 工具半径
            feedrate = (double)numericUpDown_feedrate.Value;   // 进给速度
            step = (double)numericUpDown_step.Value;   // 步进距离
            startx = (double)numericUpDown_startx.Value;   // 加工起始位置
            endx = (double)numericUpDown_endx.Value;   // 加工结束位置

            // 计算加工段数
            int numRound = (int)Math.Floor(Math.Abs(endx - startx) / step) + 1;
            pointNum = numRound * numPerRound;
            double[] cnode = new double[200000];   // 用于存储每个节点的角度
            double[] rnode = new double[200000];   // 用于存储每个节点的径向位置

            //for (int i = 0; i < numRound; i++)
            //{
            //    for (int j = 0; j < numPerRound; j++)
            //    {
            //        cnode[i * numPerRound + j] = (i * numPerRound + j) * stepC;
            //        rnode[i * numPerRound + j] = (i * numPerRound + j) * step / numPerRound;
            //    }
            //}
            double zDiv;   //Z方向上的导数
            bool beAoMian = aoRadioButton3.Checked;   // 判断是凹面还是凸面
            for (int i = 0; i <= pointNum; i++)
            {
                cnode[i] = stepC * i;   // 当前点的角度值
                rnode[i] = (startx < endx) ? (startx + step * i / numPerRound) : (startx - step * i / numPerRound);   // 径向坐标

                znode[i] = fDxs(rnode[i], cnode[i]);   // 通过函数 fDxs(r, c) 计算 z 坐标
                zDiv = (fDxs(rnode[i] + 0.001, cnode[i]) - znode[i]) * 1000;   // 计算 z 方向的差分，以估算斜率，通过计算一个微小变化后的差分值，估算曲面在该点的斜率
                angle[i] = Math.Atan(zDiv);   // 计算当前点的斜率角度
                // 根据是否是凹面，调整 z 坐标和角度的符号
                znode[i] = beAoMian ? znode[i] : -znode[i];
                angle[i] = beAoMian ? angle[i] : -angle[i];

                //刀具半径补偿，调整 rnode 和 znode
                rnode[i] = rnode[i] - tool_r * Math.Sin(angle[i]);
                znode[i] = znode[i] + tool_r * Math.Cos(angle[i]);

                //dataGridView1.Rows.Add((i + 1).ToString(), xnode[i].ToString(), znode[i].ToString("0.000000"), "0");
                //chart1.Series[0].Points.AddXY(xnode[i], znode[i]);
            }



            #region 输出NC文件
            StreamWriter sw = new StreamWriter("NC program.txt");

            // 输出 NC 程序头部
            sw.WriteLine("%");
            sw.WriteLine(comboBoxG54.Text + " T01 G90 G21 G18 ");
            sw.WriteLine("M04 S" + spindleSpeed.ToString());
            //sw.WriteLine("N0006 G04 P2000 ");  //2秒
            sw.WriteLine(" G01");

            // 循环输出每个路径点的 NC 指令
            for (int i = 0; i < pointNum; i++)
            {
                sw.WriteLine(" X " + rnode[i].ToString("0.000000")
                    + " Z " + (znode[i]).ToString("0.000000")
                    + " C " + (cnode[i]).ToString("0.000000")
                    );
            }

            // 输出 NC 程序结尾部分
            sw.WriteLine(" G01 Z" + (znode[pointNum] + 2).ToString("0.00000"));
            sw.WriteLine(" M05");
            sw.WriteLine(" G00 Z" + (znode[pointNum] + 50).ToString("0.00000"));
            sw.WriteLine(" M30");
            sw.WriteLine("%");

            MessageBox.Show("NC程序已生成!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            sw.Close();
            programListToolStripMenuItem.Enabled = programListButton1.Enabled = true;
            #endregion
        }

        //打开一个文件并读取其中的参数数据，主要用于处理与曲线拟合相关的数据。它使用 OpenFileDialog 来选择文件，并将读取到的数据存储在一个参数数组中
        private void btnOpenCFile_Click(object sender, EventArgs e)
        {
            string strline = "";   // 初始化一个字符串变量，用于存储读取到的每行文本
            OpenFileDialog fd = new OpenFileDialog();   // 创建一个打开文件对话框对象
            if (fd.ShowDialog() == DialogResult.OK)   // 如果用户选择了文件并点击了"确定"
            {
                // 初始化数组 CPara，用于存储文件中的参数数据，CParaMaxNum 表示数组的最大长度
                for (int i = 0; i < CParaMaxNum; i++)
                {
                    CPara[i] = 0;  //将数组的每个元素初始化为 0
                }
                CParaIndex = 0;  // 初始化参数索引为 0
                //chart1.Series[0].Points.Clear();
                StreamReader sr = new StreamReader(fd.FileName);  // 打开用户选择的文件进行读取
                strline = sr.ReadLine();  // 读取第一行文本
                strline = sr.ReadLine();  // 读取第二行文本

                // 将第二行文本按指定的分隔符进行拆分，这里是读取 `cc` 的值
                string[] linecc = strline.Split(sepa);
                cc = Convert.ToDouble(linecc[1]);  // 将拆分后的第二个元素转换为 double 并赋值给变量 `cc`
                strline = sr.ReadLine();  // 读取第三行文本
                string[] lineck = strline.Split(sepa);  // 将第三行文本按指定的分隔符进行拆分，这里是读取 `ck` 的值
                ck = Convert.ToDouble(lineck[1]);  // 将拆分后的第二个元素转换为 double 并赋值给变量 `ck`

                //   for (int i = 0; i < FFT_N; i++)
                // 开始读取文件中的参数数据
                while ((strline = sr.ReadLine()) != null)   // 循环读取文件中的每一行，直到文件结束
                {
                    string[] line = strline.Split(sepa);
                    //ExtPtx[ExtIndex] = Convert.ToDouble(line[0]);
                    CPara[CParaIndex] = double.Parse(line[1]);   // 读取第 2 列数据（下标为 1）并转换为 double，存储到 CPara 数组中
                    CParaIndex++;
                    if (CParaIndex >= CParaMaxNum)
                        break;
                    //string[] line = System.Text.RegularExpressions.Regex.Replace(strline.Trim(), @"[\s]+", " ").Split(" ".ToCharArray());
                }
                sr.Close();
                tbCFilePath.Text = fd.FileName;   // 将文件路径显示在文本框中
                CFile_NULL = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLabel3.Text = DateTime.Now.ToString(); //将 DateTime.Now.ToString()（即当前的日期和时间）显示在 timeLabel3 标签中
        }

        //当用户点击保存图像按钮时，弹出一个保存文件对话框。文件对话框标题设置为 "Save the Figure"，默认文件名为 "Figure1"，并且过滤器允许保存.jpg 文件和所有类型文件。
        //如果用户选择了保存路径并点击了“确定”，那么将当前显示的图表(chart1) 保存为指定路径下的.jpg 文件。
        private void button_saveFigure_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfdlg = new SaveFileDialog();
            sfdlg.Title = "Save the Figure";
            sfdlg.Filter = "图像文件(*.jpg)|*.jpg|All files(*.*)|*.*";
            sfdlg.RestoreDirectory = true;
            sfdlg.FileName = "Figure1";
            if (sfdlg.ShowDialog() == DialogResult.OK)
            {
                chart1.SaveImage(sfdlg.FileName, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Jpeg);//？？？？？？？？？？？路径
            }
        }

        //点击按钮 programListButton1 时，打开一个对话框 programListF
        private void programListButton1_Click(object sender, EventArgs e)
        {
            programListF.ShowDialog();
        }

        //当用户点击菜单项 "关于" 时，显示一个信息窗口 aboutBox，通常用于显示程序的信息，如版本号、开发者信息等
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutBox.ShowDialog();
        }

        //将当前界面中的数值参数保存到一个名为 parameter.ini 的文件中
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // 从文本框读取参数，保存到变量中
            try
            {
                a2 = double.Parse(textBox2.Text);
                a4 = double.Parse(textBox4.Text);
                a6 = double.Parse(textBox6.Text);
                a8 = double.Parse(textBox8.Text);
                a10 = double.Parse(textBox10.Text);
                a12 = double.Parse(textBox12.Text);
                a14 = double.Parse(textBox14.Text);
                a16 = double.Parse(textBox16.Text);
                a18 = double.Parse(textBox18.Text);
                a20 = double.Parse(textBox20.Text);
                a22 = double.Parse(textBox22.Text);
                a24 = double.Parse(textBox24.Text);
                a26 = double.Parse(textBox26.Text);
                a28 = double.Parse(textBox28.Text);
                a30 = double.Parse(textBox30.Text);
                a32 = double.Parse(textBox32.Text);
                a34 = double.Parse(textBox34.Text);
                a36 = double.Parse(textBox36.Text);
                a38 = double.Parse(textBox38.Text);
                a40 = double.Parse(textBox40.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            //从数值输入框读取其他参数
            c = (double)numericUpDown1.Value;
            k = (double)numericUpDown2.Value;
            tool_r = (double)numericUpDown_r.Value;
            feedrate = (double)numericUpDown_feedrate.Value;
            spindleSpeed = (double)numericUpDown_speed.Value;
            step = (double)numericUpDown_step.Value;
            startx = (double)numericUpDown_startx.Value;
            endx = (double)numericUpDown_endx.Value;

            //// 将所有参数写入到 "parameter.ini" 文件中保存
            StreamWriter sw = new StreamWriter("parameter.ini");

            try
            {
                sw.WriteLine(c.ToString());
                sw.WriteLine(k.ToString());
                sw.WriteLine(a2.ToString());
                sw.WriteLine(a4.ToString());
                sw.WriteLine(a6.ToString());
                sw.WriteLine(a8.ToString());
                sw.WriteLine(a10.ToString());
                sw.WriteLine(a12.ToString());
                sw.WriteLine(a14.ToString());
                sw.WriteLine(a16.ToString());
                sw.WriteLine(a18.ToString());
                sw.WriteLine(a20.ToString());
                sw.WriteLine(a22.ToString());
                sw.WriteLine(a24.ToString());
                sw.WriteLine(a26.ToString());
                sw.WriteLine(a28.ToString());
                sw.WriteLine(a30.ToString());
                sw.WriteLine(a32.ToString());
                sw.WriteLine(a34.ToString());
                sw.WriteLine(a36.ToString());
                sw.WriteLine(a38.ToString());
                sw.WriteLine(a40.ToString());

                sw.WriteLine(tool_r.ToString());
                sw.WriteLine(step.ToString());
                sw.WriteLine(spindleSpeed.ToString());
                sw.WriteLine(feedrate.ToString());
                sw.WriteLine(startx.ToString());
                sw.WriteLine(endx.ToString());

                //保存中心位置数据
                sw.WriteLine(XcenterNumericUpDown1.Value.ToString());
                sw.WriteLine(partXcenterNumericUpDown2.Value.ToString());

                // 保存加工方式的选择（通过单选按钮的状态）
                if (aoRadioButton3.Checked) sw.WriteLine("0");
                else sw.WriteLine("1");
                if (linearRadioButton1.Checked) sw.WriteLine("0");
                else sw.WriteLine("1");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                sw.Close();
            }
        }

        //根据是否选中某些补偿文件的复选框（checkBoxCMP1 到 checkBoxCMP5），决定相应的按钮（buttonOpenCMPFile1 到 buttonOpenCMPFile5）是否启用
        private void checkBoxUV3P_CheckedChanged(object sender, EventArgs e)
        {
            buttonOpenCMPFile1.Enabled = checkBoxCMP1.Checked;
            buttonOpenCMPFile2.Enabled = checkBoxCMP2.Checked;
            buttonOpenCMPFile3.Enabled = checkBoxCMP3.Checked;
            buttonOpenCMPFile4.Enabled = checkBoxCMP4.Checked;
            buttonOpenCMPFile5.Enabled = checkBoxCMP5.Checked;
        }

        /// <summary>
        /// 第一次补偿文件打开
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOpenFileUV3P_Click(object sender, EventArgs e)
        {
            string strline = "";  //strline 用于存储读取文件中的一行文本
            OpenFileDialog fd = new OpenFileDialog();  //用于打开文件选择对话框，让用户选择需要加载的数据文件。
            startx = (double)numericUpDown_startx.Value;  //加工起始位置
            endx = (double)numericUpDown_endx.Value;  //加工结束位置
            if (fd.ShowDialog() == DialogResult.OK)   //显示文件选择对话框，用户选择文件后返回 DialogResult.OK 表示成功选择了文件。
            {
                //清空 chart3 图表中的数据点，确保开始处理新数据时没有旧的图表数据残留。这是对图表的三个系列（Series[0], Series[1], Series[2]）进行清空操作。
                chart3.Series[0].Points.Clear();
                chart3.Series[1].Points.Clear();
                //chart3.Series[2].Points.Clear();
                Array.Clear(UV3P_x, 0, UV3P_x.Length);
                Array.Clear(UV3P_zd, 0, UV3P_zd.Length);

                StreamReader sr = new StreamReader(fd.FileName);  //打开用户选择的文件并准备读取其中的内容

                //UV3P误差补偿
                if (radioButtonBeUV3P.Checked)
                {
                    //两次读取文件前两行
                    strline = sr.ReadLine();
                    strline = sr.ReadLine();
                    // 判定要读取的 UV3P_x 的范围
                    bool readPositive = startx > 0 || endx > 0;
                    bool readNegative = startx < 0 || endx < 0;
                    //   for (int i = 0; i < FFT_N; i++)，循环读取文件剩余行，直到读取完毕
                    while ((strline = sr.ReadLine()) != null)
                    {
                        string[] line = strline.Split(sepa);
                        /*UV3P_x[UV3P_index] = Convert.ToDouble(line[0]); //读取 x 坐标数据
                        UV3P_zd[UV3P_index] = double.Parse(line[3]); //读取 z 坐标数据
                        chart3.Series[1].Points.AddXY(UV3P_x[UV3P_index], UV3P_zd[UV3P_index]);
                        //加上是负拟合，注释是全拟合。
                        if (UV3P_x[UV3P_index] <= 0)
                            continue;
                        //如果 UV3P_x 为非负数则跳过该行
                        UV3P_index++;

                        if (UV3P_index >= UV3P_MaxNum)
                            break;
                        //string[] line = System.Text.RegularExpressions.Regex.Replace(strline.Trim(), @"[\s]+", " ").Split(" ".ToCharArray());
                        */
                        double currentX = Convert.ToDouble(line[0]);
                        double currentZd = double.Parse(line[3]);

                        // 根据起始位置和终止位置判断是否读取当前数据
                        if ((readPositive && currentX > 0) || (readNegative && currentX < 0))
                        {
                            UV3P_x[UV3P_index] = currentX; // 读取 x 坐标数据
                            UV3P_zd[UV3P_index] = currentZd; // 读取 z 坐标数据
                            chart3.Series[1].Points.AddXY(UV3P_x[UV3P_index], UV3P_zd[UV3P_index]);
                            UV3P_index++;

                            // 判断是否达到最大数量限制
                            if (UV3P_index >= UV3P_MaxNum)
                                break;
                        }
                    }
                }
                //Taylor误差补偿
                else if (radioButtonBeTyler.Checked)
                {
                    //chart3.Series[0].Points.Clear();
                    //chart3.Series[1].Points.Clear();
                    for (int i = 1; i <= 32; i++)
                    {
                        strline = sr.ReadLine();
                        if (i == 9)
                        {
                            string[] line = strline.Split(sepa);  //在第9行按字符串分隔
                            //UV3P_index = Convert.ToInt32(line[1]);
                            if (line[1].Contains("E") || line[1].Contains("e"))  //如果第2个字段包含 E 或 e，则将其解析为浮点数
                            {
                                //UV3P_index = (int)Convert.ToDecimal(Decimal.Parse(line[1].ToString(), System.Globalization.NumberStyles.Float));
                                UV3P_index = int.Parse(line[1].ToString(), System.Globalization.NumberStyles.Float);  //接受科学计数法
                            }
                        }
                    }
                    if (UV3P_index >= UV3P_MaxNum)
                        MessageBox.Show("Too Many Data!");
                    // 读取 x 数据和 zd 数据并存储到 UV3P_x 和 UV3P_zd 数组中
                    List<double> filtered_x = new List<double>();
                    List<double> filtered_zd = new List<double>();

                    //读取 x 数据和 zd 数据并存储到 UV3P_x 和 UV3P_zd 数组中
                    for (int i = 0; i < UV3P_index; i++)
                    {
                        strline = sr.ReadLine();  //读取一行内容
                        UV3P_x[i] = double.Parse(strline, System.Globalization.NumberStyles.Float);  //将读取的字符串转换为浮点数并存储在 UV3P_x[i] 中，这些数据代表某些位置的 x 坐标
                    }
                    for (int i = 0; i < UV3P_index; i++)
                    {
                        strline = sr.ReadLine();
                        UV3P_zd[i] = Convert.ToDouble(strline);
                    }
                    // 筛选数据
                    if (startx > 0 || endx > 0)  // 如果起始位置有一个大于 0，则取 x 坐标大于 0 的部分
                    {
                        for (int i = 0; i < UV3P_index; i++)
                        {
                            if (UV3P_x[i] > 0)
                            {
                                filtered_x.Add(UV3P_x[i]);
                                filtered_zd.Add(UV3P_zd[i]);
                            }
                        }
                    }
                    else if (startx < 0 || endx < 0)  // 如果起始位置有一个小于 0，则取 x 坐标小于 0 的部分
                    {
                        for (int i = 0; i < UV3P_index; i++)
                        {
                            if (UV3P_x[i] < 0)
                            {
                                filtered_x.Add(UV3P_x[i]);
                                filtered_zd.Add(UV3P_zd[i]);
                            }
                        }
                    }

                    // 将筛选后的数据保存回原数组（如果需要）
                    UV3P_index = filtered_x.Count;
                    for (int i = 0; i < UV3P_index; i++)
                    {
                        UV3P_x[i] = filtered_x[i];
                        UV3P_zd[i] = filtered_zd[i];
                        chart3.Series[1].Points.AddXY(UV3P_x[i], UV3P_zd[i]);
                    }
                }

                sr.Close();


                //??????????????????????????
                switch (((System.Windows.Forms.Button)sender).Name)
                {
                    case "buttonOpenCMPFile1":
                        UV3P_result01 = Fit.Polynomial(UV3P_x, UV3P_zd, 4);  //执行四次多项式拟合（使用 Fit.Polynomial 函数），并将拟合结果存储在对应的 UV3P_resultXX 中
                        textBoxCMPFilePath1.Text = fd.FileName;              //找到最能描述已知数据点的多项式函数，以便对数据进行插值或预测
                        break;
                    case "buttonOpenCMPFile2":
                        UV3P_result02 = Fit.Polynomial(UV3P_x, UV3P_zd, 4);
                        textBoxCMPFilePath2.Text = fd.FileName;              //将所选文件路径显示在文本框中，方便用户查看。
                        break;
                    case "buttonOpenCMPFile3":
                        UV3P_result03 = Fit.Polynomial(UV3P_x, UV3P_zd, 4);
                        textBoxCMPFilePath3.Text = fd.FileName;
                        break;
                    case "buttonOpenCMPFile4":
                        UV3P_result04 = Fit.Polynomial(UV3P_x, UV3P_zd, 4);
                        textBoxCMPFilePath4.Text = fd.FileName;
                        break;
                    case "buttonOpenCMPFile5":
                        UV3P_result05 = Fit.Polynomial(UV3P_x, UV3P_zd, 4);
                        textBoxCMPFilePath5.Text = fd.FileName;
                        break;
                    default:
                        break;
                }
                //遍历区间
                for (double i = Math.Max(UV3P_x[0], UV3P_x[UV3P_index - 1]); i >= Math.Min(UV3P_x[0], UV3P_x[UV3P_index - 1]); i = i - 0.1)
                {
                    double sumZd = 0;
                    if (checkBoxCMP1.Checked)
                    {
                        sumZd += UV3P_result01[0]
                        + UV3P_result01[1] * i
                        + UV3P_result01[2] * i * i
                        + UV3P_result01[3] * i * i * i
                        + UV3P_result01[4] * i * i * i * i;
                    }
                    if (checkBoxCMP2.Checked)
                    {
                        sumZd += UV3P_result02[0]
                        + UV3P_result02[1] * i
                        + UV3P_result02[2] * i * i
                        + UV3P_result02[3] * i * i * i
                        + UV3P_result02[4] * i * i * i * i;
                    }
                    if (checkBoxCMP3.Checked)
                    {
                        sumZd += UV3P_result03[0]
                        + UV3P_result03[1] * i
                        + UV3P_result03[2] * i * i
                        + UV3P_result03[3] * i * i * i
                        + UV3P_result03[4] * i * i * i * i;
                    }
                    if (checkBoxCMP4.Checked)
                    {
                        sumZd += UV3P_result04[0]
                        + UV3P_result04[1] * i
                        + UV3P_result04[2] * i * i
                        + UV3P_result04[3] * i * i * i
                        + UV3P_result04[4] * i * i * i * i;
                    }
                    if (checkBoxCMP5.Checked)
                    {
                        sumZd += UV3P_result05[0]
                        + UV3P_result05[1] * i
                        + UV3P_result05[2] * i * i
                        + UV3P_result05[3] * i * i * i
                        + UV3P_result05[4] * i * i * i * i;
                    }

                    chart3.Series[0].Points.AddXY(i, sumZd);  //将每个计算得到的 (i, sumZd) 点添加到图表的第三个系列（Series[2]）中，最终绘制出累加后的拟合曲线
                }
                UV3P_NULL = false;
            }
        }

        //将所有的补偿文件按钮 (buttonOpenCMPFile1 到 buttonOpenCMPFile5) 以及复选框 (checkBoxCMP1 到 checkBoxCMP5) 都设置为不可用状态
        private void radioButtonBeUV3P_CheckedChanged(object sender, EventArgs e)
        {
            buttonOpenCMPFile1.Enabled = checkBoxCMP1.Checked = false;
            buttonOpenCMPFile2.Enabled = checkBoxCMP2.Checked = false;
            buttonOpenCMPFile3.Enabled = checkBoxCMP3.Checked = false;
            buttonOpenCMPFile4.Enabled = checkBoxCMP4.Checked = false;
            buttonOpenCMPFile5.Enabled = checkBoxCMP5.Checked = false;
        }

        private void pvErrorCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            // bool error = streightErrorCheckBox1.Checked | pvErrorCheckBox1.Checked;
            partXcenterNumericUpDown2.Enabled = streightErrorCheckBox1.Checked;
            XcenterNumericUpDown1.Enabled = openToolStripMenuItem.Enabled = openErrorButton1.Enabled = pvErrorCheckBox1.Checked;
        }

        private void openErrorButton1_Click(object sender, EventArgs e)
        {
            int i = 1, j;
            string linestr, x_str, z_str;
            double centerX;

            centerX = (double)XcenterNumericUpDown1.Value;

            OpenFileDialog filedlg = new OpenFileDialog();
            filedlg.Title = "打开误差数据文件";
            filedlg.Filter = "Text file(*.txt)|*.txt|All files(*.*)|*.*";
            filedlg.RestoreDirectory = true;
            if (filedlg.ShowDialog() == DialogResult.OK)
            {
                errorFiletextBox1.Text = filedlg.FileName;
                StreamReader sr = new StreamReader(filedlg.FileName);
                try
                {
                    linestr = sr.ReadLine();
                    linestr = sr.ReadLine();
                    while (linestr != null)
                    {
                        linestr = linestr.Trim();   //移除 linestr 两端的空白字符
                        x_str = linestr[0].ToString();   //x_str 用于存储读取到的 x 值
                        for (j = 1; j < linestr.Length; j++)
                        {
                            if (linestr[j] == ' ') break;
                            x_str += linestr[j].ToString();
                            //通过 for 循环读取 linestr，直到找到空格，将这些字符合并到 x_str 中。
                            //使用 Substring() 方法提取 z 值的部分(z_str) 并去除空格(Trim()).

                        }
                        z_str = linestr.Substring(j, linestr.Length - x_str.Length).Trim();
                        x_pv[i] = double.Parse(x_str) - centerX;   //将 x_str 转换为浮点数并减去中心位置 (centerX)，表示对 x 坐标进行归一化处理，使得数据相对于一个中心点对称。
                        z_pv[i] = 0.001 * double.Parse(z_str);   //使用 Substring() 方法提取 z 值的部分 (z_str) 并去除空格 (Trim()，将 z 值从微米单位转换为毫米单位。

                        i++;
                        linestr = sr.ReadLine();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sr.Close();
                }
            }
        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("对不起！ 目前还没有帮助文件。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //当 streightErrorCheckBox1 的选中状态改变时，如果被选中 (Checked 为 true)，则启用控件 partXcenterNumericUpDown2，否则禁用它
        private void streightErrorCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            //bool error;
            //error = streightErrorCheckBox1.Checked | pvErrorCheckBox1.Checked;
            //XcenterNumericUpDown1.Enabled = partXcenterNumericUpDown2.Enabled = error;
            partXcenterNumericUpDown2.Enabled = streightErrorCheckBox1.Checked;
        }

        private void 光学普适方程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (光学普适方程ToolStripMenuItem.Checked == false)
            {
                光学普适方程ToolStripMenuItem.Checked = groupBox1.Visible = true;
                离散点ToolStripMenuItem.Checked = groupBox8.Visible = false;
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
                dataGridView1.Rows.Clear();
            }
        }

        private void 离散点ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (离散点ToolStripMenuItem.Checked == false)
            {
                光学普适方程ToolStripMenuItem.Checked = groupBox1.Visible = false;
                离散点ToolStripMenuItem.Checked = groupBox8.Visible = true;
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
                dataGridView1.Rows.Clear();
                richTextBox1.Clear();
            }
        }

        /// <summary>
        /// 定义float类型的点坐标，x y 均为float类型的点
        /// </summary>
        public struct DPoint
        {
            private double x;
            private double y;

            public DPoint(double inX, double inY)
            {
                x = inX;
                y = inY;
            }

            public double X
            {
                get { return x; }
                set { x = value; }
            }

            public double Y
            {
                get { return y; }
                set { y = value; }
            }
        }

        int inputPointNum = 0;
        private DPoint[] Points;   //用来存储导入的离散点云
        double[] x_point;
        double[] z_point;

        private void ReadTXTFile(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fs, Encoding.Default);
            //string s = reader.ReadLine();
            //int ptsNum = int.Parse(reader.ReadLine());
            inputPointNum = int.Parse(reader.ReadLine());
            Points = new DPoint[inputPointNum];
            x_point = new double[inputPointNum];
            z_point = new double[inputPointNum];

            for (int i = 0; i < inputPointNum; i++)
            {
                string temp = reader.ReadLine();
                Points[i].X = double.Parse(temp.Substring(0, temp.IndexOf("\t")));
                Points[i].Y = double.Parse(temp.Substring(temp.IndexOf("\t") + 1).Replace(" ", ""));

                x_point[i] = Points[i].X;
                z_point[i] = Points[i].Y;
                chart1.Series[0].Points.AddXY(Math.Round(Points[i].X, 1), Math.Round(Points[i].Y, 1));
            }
            //CoordinatesTransformation();

            richTextBox1.AppendText("数据点数：" + inputPointNum.ToString() + "\n");
            richTextBox1.AppendText("数据路径：" + path + "\n");

        }

        private void inputData_button_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "文本文档(*.txt)|*.txt";
            openFileDialog1.Title = "导入数据点云";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
                richTextBox1.ResetText();
                string TxtFileName = openFileDialog1.FileName;
                ReadTXTFile(TxtFileName);
                groupBox10.Enabled = groupBox9.Enabled = true;

            }
        }
        double[] x4 = new double[4];
        double[] z4 = new double[4];

        private void spline_button_Click(object sender, EventArgs e)
        {
            spline_button.Enabled = false;
            /*
             for (int j = 0; j < 6499; j++)
             {
                 for (int i = 0; i < 4; i++)
                 {
                     x4[i] = x_point[ i+j*2];
                     z4[i] = z_point[ i+j*2];
                 }
                 spline(x4, z4, 3, Math.Pow(10, 30), Math.Pow(10, 30), y2);

                 double y = 0;
                 //x = 15.0011;

                 splint(x4, z4, y2, 3, x_point[1+ j * 2], y);
                 spline_diff(x4, z4, y2, 3, x_point[1 + j * 2],diff_z);
                 diff_z = Math.Atan(diff_z)*180/Math.PI;

                 dataGridView1.Rows.Add((2*j+1).ToString(), x_point[1 + j * 2].ToString(), z.ToString(), diff_z.ToString());
                 splint(x4, z4, y2, 3, x_point[2 + j * 2], y);
                 spline_diff(x4, z4, y2, 3, x_point[2 + j * 2], diff_z);
                 diff_z = Math.Atan(diff_z) * 180 / Math.PI;
                 dataGridView1.Rows.Add((2 * j + 2).ToString(), x_point[2 + j * 2].ToString(), z.ToString(), diff_z.ToString());

             }

             */
            spline(x_point, z_point, inputPointNum - 1, Math.Pow(10, 30), Math.Pow(10, 30), y2);
            int n = 0;
            for (int x = 15; x <= 150; x++)
            {
                splint(x_point, z_point, y2, inputPointNum - 1, x, z);
                n++;
                dataGridView1.Rows.Add(n.ToString(), x.ToString(), z.ToString());
            }

            spline_button.Enabled = true;
            MessageBox.Show("三次样条拟合成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// 最小二乘法，得到圆心坐标和半径三个数据
        /// </summary>
        private void LeastSquareFitting()
        {
            if (inputPointNum < 3)
                return;

            double x1 = 0.0f;  //x一次方的初值
            double y1 = 0.0f;
            double x2 = 0.0f;  //x平方的初始值
            double y2 = 0.0f;
            double x3 = 0.0f;  //x立方的初始值
            double y3 = 0.0f;
            double x1y1 = 0.0f;
            double x1y2 = 0.0f;
            double x2y1 = 0.0f;

            for (int i = 0; i < inputPointNum; i++)
            {
                x1 = x1 + Points[i].X;
                y1 = y1 + Points[i].Y;
                x2 = x2 + Points[i].X * Points[i].X;
                y2 = y2 + Points[i].Y * Points[i].Y;
                x3 = x3 + Points[i].X * Points[i].X * Points[i].X;
                y3 = y3 + Points[i].Y * Points[i].Y * Points[i].Y;
                x1y1 = x1y1 + Points[i].X * Points[i].Y;
                x1y2 = x1y2 + Points[i].X * Points[i].Y * Points[i].Y;
                x2y1 = x2y1 + Points[i].X * Points[i].X * Points[i].Y;
            }

            double C, D, E, G, H, N;
            double a, b, c;
            N = inputPointNum;
            C = N * x2 - x1 * x1;
            D = N * x1y1 - x1 * y1;
            E = N * x3 + N * x1y2 - (x2 + y2) * x1;
            G = N * y2 - y1 * y1;
            H = N * x2y1 + N * y3 - (x2 + y2) * y1;
            a = (H * D - E * G) / (C * G - D * D);
            b = (H * C - E * D) / (D * D - G * C);
            c = -(a * x1 + b * y1 + x2 + y2) / N;

            double A, B, R;
            A = a / (-2);
            B = b / (-2);
            R = (double)Math.Sqrt(a * a + b * b - 4 * c) / 2;

            centerX = A;
            centerZ = B;
            nihe_R = R;
        }

        double centerX, centerZ, nihe_R;

        private void circle_button2_Click(object sender, EventArgs e)
        {
            LeastSquareFitting();
            centerX_numericUpDown5.Value = (decimal)centerX;
            centerZ_numericUpDown6.Value = (decimal)centerZ;
            R_numericUpDown7.Value = (decimal)nihe_R;

            double zz;
            for (int i = 0; i < inputPointNum; i++)
            {
                x = x_point[i];
                z = z_point[i];
                zz = Zx(x);
                dataGridView1.Rows.Add((i + 1).ToString(), x.ToString(), z.ToString(), zz.ToString());

            }
        }
        private double Zx(double x)
        {
            double z;
            z = -Math.Sqrt(nihe_R * nihe_R - (x - centerX) * (x - centerX)) + centerZ;
            return z;
        }

        double[] sata;
        double[] phi;

        private void inputPhi_button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "文本文档(*.txt)|*.txt";
            openFileDialog1.Title = "导入斜率点云";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //chart1.Series[0].Points.Clear();
                //chart1.Series[1].Points.Clear();
                //richTextBox1.ResetText();
                string TxtFileName = openFileDialog1.FileName;

                FileStream fs = new FileStream(TxtFileName, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(fs, Encoding.Default);
                //string s = reader.ReadLine();
                //int ptsNum = int.Parse(reader.ReadLine());
                inputPointNum = int.Parse(reader.ReadLine());

                sata = new double[inputPointNum];
                phi = new double[inputPointNum];

                for (int i = 0; i < inputPointNum; i++)
                {
                    string temp = reader.ReadLine();
                    sata[i] = double.Parse(temp.Substring(0, temp.IndexOf("\t")));
                    phi[i] = double.Parse(temp.Substring(temp.IndexOf("\t") + 1).Replace(" ", ""));

                }
                //CoordinatesTransformation();

                richTextBox1.AppendText("斜率点云路径：" + TxtFileName + "\n");

            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }


    }
}