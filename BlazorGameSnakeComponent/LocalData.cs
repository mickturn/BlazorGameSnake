﻿using BlazorGameSnakeComponent.Classes;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorGameSnakeComponent
{
    public static class LocalData
    {
        public static CompBlazorGameSnake_Logic Curr_comp = null;
        public static CompChildBoard Curr_Comp_Board = null;
        
        [JSInvokable]
        public static void KeyUpFromjs(int e)
        {
            Curr_comp.KeyUpFromJS1(e);

        }

        public static double CompWidth = 1000.0;
        public static double CompHeight = 600.0;


        public static string canvas_Board;
        public static string context_Board;

        public static string canvas_AppName;
        public static string context_AppName;

        public static string canvas_Score;
        public static string context_Score;



        public static string global_Border_Color = "#999999";
        public static string global_BG_Color = "lightyellow";

        public static DirectionType Curr_Direction = DirectionType.empty;

        public static string timerVariable_Game_Time;
        public static int global_speed = 1;

        public static int global_margin = 10;

        public static string global_font = "30px Sylfaen";
    }
}
