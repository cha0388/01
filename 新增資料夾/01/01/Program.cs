using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            //設陣列 姓名、血型、性別、星座、身高
            string[] names = { "葉俊廷", "張澤瑜", "王程捷 的咩？", "江儀婷", "張秉華", "陳柏霖", "黃紀瑜", "黃昱維", "蔡逸群", "登琳", "世新魏鈞孝吧", "劉定南", "陳信如", "童信傑", "李岳倫", "鄒和恆", "簡毓玟", "劉子瑄", "蕭紹洋", "李亞宸la", "張以潔", "邱仕紳", "呂家瑩", "世新林鑫佑", "徐均得", "陳佳欣", "張恩瑋", "周詮", "王湘婷", "蕭宇成", "Max Cheung(BANG)", "馬嘉誠Σヽ(ﾟД ﾟ; )ﾉ魔貫光殺砲(ﾟДﾟ)σ━0000", "陳昱嘉", "康珈熏", "盧奕宏", "陳郁佳的大哥黃博涵", "遲正雯", "世新林星彤", "許晏誠ｘ勒是奇多＿８＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝Ｄ　", "許子安", "高子晴", "陳思婷", "矝鵘鮿", "余彥廷", "吳耀輝", "鄭丞智", "林冠廷", "世新何曜宇", "邵喬雨", "張豐愷", "林子晴", "邱雁回", "陳家欣是韓妞", "鄧雅馨", "謝汶珊", "李曼寧", "世新徐偉哲", "张钰慈", "鍾宜珊", "raer_tsai", "世新李姳諼", "鄭曼君", "陳柏霖", "世新許子安", "世新方若帆", "李曼寧", "世新遲正雯", "世新周詮"  };
            string[] blood = { "O", "其他", "O", "O", "A", "O", "A", "A", "O", "O", "A", "O", "A", "B", "O", "O", "A", "其他", "O", "O", "A", "", "B", "O", "", "O", "B", "O", "B", "B", "B", "O", "O", "AB", "O", "B", "A", "O", "O", "", "O", "A", "", "O", "O", "A", "O", "O", "其他", "B", "O", "O", "O", "A", "AB", "A", "O", "B", "AB", "", "O", "O", "O", "", "O", "A", "A", "O" };
            string[] gender = { "男", "男", "男", "女", "男", "男", "女", "男", "男", "男", "男", "男", "女", "男", "男", "男", "女", "女", "男", "男", "女", "男", "女", "男", "男", "女", "男", "男", "女", "男", "男", "男", "男", "女", "男", "男", "女", "女", "男", "男", "女", "女", "男", "男", "男", "男", "男", "男", "女", "男", "女", "女", "女", "女", "女", "女", "男", "女", "女", "女", "女", "女", "男", "男", "女", "女", "女", "男" };
            string[] star = { "金牛", "", "巨蟹", "白羊", "雙魚", "雙子", "天蠍", "巨蟹", "獅子", "雙魚", "雙子", "雙子", "獅子", "雙魚", "天蠍", "天蠍", "處女", "處女", "金牛", "雙魚", "處女", "摩羯", "雙魚", "白羊", "天蠍", "處女", "雙子", "金牛", "雙子", "白羊", "白羊", "摩羯", "射手", "巨蟹", "雙魚", "獅子", "射手", "摩羯", "天蠍", "", "雙魚", "雙子", "", "雙魚", "處女", "金牛", "天秤", "水瓶", "巨蟹", "處女", "白羊", "摩羯", "水瓶", "天秤", "金牛", "天蠍", "天蠍", "處女", "雙子", "", "摩羯", "天蠍", "雙子", "", "獅子", "天蠍", "射手", "金牛" };
            int[] height = { 173, 0, 179, 155, 183, 170, 163, 174, 165, 189, 177, 180, 154, 167, 170, 173, 165, 158, 180, 165, 153, 175, 162, 165, 0, 160, 165, 173, 164, 177, 177, 180, 170, 151, 176, 180, 168, 152, 666, 2147483647, 165, 155, 777, 173, 169, 170, 169, 171, 0, 170, 150, 160, 155, 164, 163, 165, 184, 165, 155, 0, 168, 160, 169, 0, 150, 163, 168, 173 };

            //設變數 男生人數、女生人數
            int countF = 0;
            int countM = 0;

            //設變數 女生身高總和、男生身高總和、全班身高總和
            int sumF = 0;
            int sumM = 0;
            int sum = 0;

            //設變數 女生身高平均、男生身高平均、全班身高平均
            int aveF = 0;
            int aveM = 0;
            int ave = 0;

            //設變數 A型人數、B型人數、AB型人數、O型人數、其他人數
            int countA = 0;
            int countB = 0;
            int countAB = 0;
            int countO = 0;
            int count = 0;

            //設變數 最高、最矮
            int min = 200;
            int max = 0;



            //計算男女人數
            for ( int i = 0; i < names.Length; i++ )
            {
                if ( gender[i] == "女" )
                {
                    countF += 1;
                }

                else if ( gender[i] == "男" )
                {
                    countM += 1;
                }
            }

            //計算女生身高平均
            for ( int i = 0; i < height.Length; i++ )
            {
                //去除不合理值
                if ( height[i] > 100 && height[i] < 200 )
                {
                    if ( gender[i] == "女" )
                    {
                        sumF = sumF + height[i];
                        aveF = sumF / countF;
                    }
                }
            }

            //計算男生身高平均
            for ( int i = 0; i < height.Length; i++ )
            {
                //去除不合理值
                if ( height[i] > 100 && height[i] < 200 )
                {
                    if ( gender[i] == "男" )
                    {
                        sumM = sumM + height[i];
                        aveM = sumM / countM;
                    }
                }
            }

            //計算全班身高平均
            for ( int i = 0; i < height.Length; i++ )
            {
                //去除不合理值
                if ( height[i] > 100 && height[i] < 200 )
                {
                    
                        sum = sum + height[i];
                        ave = sum / names.Length;
                }
            }

            //計算各血型人數
            for ( int i = 0; i< names.Length; i++ )
            {
                if ( blood[i] == "A" )
                {
                    countA += 1;
                }

                else if ( blood[i] == "B" )
                {
                    countB += 1;
                }

                else if ( blood[i] == "AB" )
                {
                    countAB += 1;
                }

                else if ( blood[i] == "O" )
                {
                    countO += 1;
                }

                else
                {
                    count += 1;
                }
            }



            //加分
            //找最高
            for ( int i = 0; i < height.Length; i++ )
            {
                //去除不合理值
                if ( height[i] > 100 && height[i] < 200 )
                {
                    if ( height[i] > max )
                    {
                        max = height[i];
                    }
                }
            }

            //找最矮
            for ( int i = 0; i < height.Length; i++ )
            {
                //去除不合理值
                if ( height[i] > 100 && height[i] < 200 )
                {
                    if ( height[i] < min )
                    {
                        min = height[i];
                    }
                }
            }



            //計算男女百分比
            double F = (double)countF / (double)names.Length * 100;
            double M = (double)countM / (double)names.Length * 100;

            //計算各血型百分比
            double A = (double) countA / (double) names.Length *100;
            double B = (double) countB / (double) names.Length * 100;
            double AB = (double) countAB / (double) names.Length * 100;
            double O = (double) countO / (double) names.Length * 100;
            double other = (double) count / (double) names.Length * 100;



            //顯示結果
            Console.WriteLine ( "女生人數" + countF + "\n占總數比例" + F + "%" );
            Console.WriteLine ( "\n男生人數" + countM + "\n占總數比例" + M + "%\n");

            Console.WriteLine ( "\nA型人數" + countA + "\n占總數比例" + A + "%" );
            Console.WriteLine ( "\nB型人數" + countB + "\n占總數比例" + B + "%" );
            Console.WriteLine ( "\nAB型人數" + countAB + "\n占總數比例" + AB + "%" );
            Console.WriteLine ( "\nO型人數" + countO + "\n占總數比例" + O + "%" );
            Console.WriteLine ( "\n其他人數" + count + "\n占總數比例" + other + "%\n" );

            Console.WriteLine ( "\n女生身高平均" + aveF );
            Console.WriteLine ( "男生身高平均" + aveM );
            Console.WriteLine ( "全班身高平均" + ave );

            //天蠍座O型
            Console.WriteLine ( "\n\n天蠍座O型的人：" );
            for ( int i = 0; i < star.Length; i++ )
            {
                //抓出天蠍座
                if ( star[i] == "天蠍" )
                {
                    //裡面的O型
                    if ( blood[i] == "O" )
                    {
                        //寫名單
                        Console.WriteLine( names[i] );
                    }
                }
            }



            //加分
            //列出結果
            Console.WriteLine ( "\n\n班上最高身高" + max );
            Console.WriteLine ( "班上最矮身高" + min );



            Console.ReadLine();
        }
    }
}
