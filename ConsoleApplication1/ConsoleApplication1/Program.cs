﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            
            //字体颜色
            Console.WriteLine("请输入身高（米）");

            //文字显示
            float height = float.Parse(Console.ReadLine());

            //输入身高
            Console.WriteLine("请输入体重(公斤)");

            //文字显示
            float weight = float.Parse(Console.ReadLine());

            //输入体重

            float bmi = weight /( height * height);

            //bmi计算公式

            if(bmi <18.5)
             Console.WriteLine("体重过轻");

            //判断
            else if(bmi>=18.5&bmi <24)
                Console.WriteLine("正常");

            //判断
            else
                Console.WriteLine("异常");

            //判断
            Console.ReadLine();





        }
    }
}
