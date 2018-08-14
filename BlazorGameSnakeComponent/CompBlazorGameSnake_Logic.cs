using BlazorGameSnakeComponent.Classes;
using Microsoft.AspNetCore.Blazor;
using Microsoft.AspNetCore.Blazor.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorGameSnakeComponent
{
    public class CompBlazorGameSnake_Logic : BlazorComponent
    {
        public bool input_Is_Bot_Mode;

        public bool input_Is_Enable_Audio;

        public int select_Game_mode;

        public int input_speed = 150;

        public int input_X_Count = 44;
        public int input_Y_Count = 22;


        public string CurrPoint = "Point 0";

        protected override void OnInit()
        {
            Game.x_Length = input_X_Count;
            Game.y_Length = input_Y_Count;

            reset_Settings();
            Game.reset();

            paint_AppName();

        }


        protected override void OnAfterRender()
        {

            LocalData.Curr_comp = this;


            base.OnAfterRender();
        }


        public void Refresh()
        {
            StateHasChanged();
        }

        public void button_1_onclick()
        {
            reset_Settings();
            Game.reset();
        }

        public void input_Is_Enable_Audio_onchange()
        {

            //let tmp_element = document.getElementById("input_Is_Enable_Audio") as HTMLInputElement;
            //Game.Is_Enabled_Audio = tmp_element.checked;

            //if (!Game.Is_Enabled_Audio)
            //{
            //    SoundEffect.bg_sound.pause();
            //}
        }


        public void input_Is_Bot_Mode_onchange()
        {

            //let tmp_element = document.getElementById("input_Is_Bot_Mode") as HTMLInputElement;
            //Game.Is_Bot_Mode = tmp_element.checked;
        }

        public void input_speed_onchange()
        {

            //let tmp_element = document.getElementById("input_speed") as HTMLInputElement;
            //global_speed = parseInt(tmp_element.value);
        }

        public void input_X_Count_onchange()
        {

            //let tmp_element = document.getElementById("input_X_Count") as HTMLInputElement;
            //Game.x_Length = parseInt(tmp_element.value);
        }

        public void input_Y_Count_onchange()
        {

            //let tmp_element = document.getElementById("input_Y_Count") as HTMLInputElement;
            //Game.y_Length = parseInt(tmp_element.value);

        }


        public void KeyUpFromJS1(int e)
        {
           
            if (Game.Is_Enabled)
            {
                if (!Game.Is_Bot_Mode)
                {

                    ConsoleKey consoleKey = (ConsoleKey)Enum.Parse(typeof(ConsoleKey), e.ToString());


                    switch (consoleKey)
                    {

                        case ConsoleKey.DownArrow:
                            if (LocalData.Curr_Direction != DirectionType.Up)
                            {
                                LocalData.Curr_Direction = DirectionType.Down;
                            }
                            if (!Game.Is_Started)
                            {
                                Game.start();
                            }
                            break;
                        case ConsoleKey.RightArrow:
                            if (LocalData.Curr_Direction != DirectionType.Left)
                            {
                                LocalData.Curr_Direction = DirectionType.Right;
                            }
                            if (!Game.Is_Started)
                            {
                                Game.start();
                            }
                            break;
                        case ConsoleKey.UpArrow:
                            if (LocalData.Curr_Direction != DirectionType.Down)
                            {
                                LocalData.Curr_Direction = DirectionType.Up;
                            }
                            if (!Game.Is_Started)
                            {
                                Game.start();
                            }
                            break;
                        case ConsoleKey.LeftArrow:
                            if (LocalData.Curr_Direction != DirectionType.Right)
                            {
                                LocalData.Curr_Direction = DirectionType.Left;
                            }
                            if (!Game.Is_Started)
                            {
                                Game.start();
                            }
                            break;
                        default:
                            break;
                    }

                    

                }
            }


           
        }

  



        public void paint_AppName() {

            //context_AppName.font = "40px Sylfaen";
            //context_AppName.fillStyle = "green";
            //let Tmp_Active_Width: number = Math.ceil(context_AppName.measureText("Snake").width);


            //context_AppName.fillText("Snake", (canvas_AppName.width - Tmp_Active_Width) / 2, 32);


        }

        

      

        public void reset_Settings()
        {



            Game_mode_onchange();
            input_Is_Enable_Audio_onchange();
            input_Is_Bot_Mode_onchange();
            input_speed_onchange();
            input_X_Count_onchange();
            input_Y_Count_onchange();

            Game.points_Count = Game.x_Length * Game.y_Length;
            Game.point_Width =Math.Round(LocalData.CompWidth * 1.0 / Game.x_Length,2);
            Game.point_Height = Math.Round(LocalData.CompHeight * 1.0 / Game.y_Length,2);

           

        }







        


        public void Game_mode_onchange()
        {

            //let my_select = document.getElementById("select_Game_mode") as HTMLSelectElement;
            //let curr_value: string = my_select.value.toString().trim();

            //switch (curr_value)
            //{
            //    case "1":
            //        Game.Are_Borders_Open = true;
            //        break;
            //    case "2":
            //        Game.Are_Borders_Open = false;
            //        break;
            //}

        }





        public void Dispose()
        {

        }

    }
}
