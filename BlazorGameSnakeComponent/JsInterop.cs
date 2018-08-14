using Microsoft.JSInterop;
using System;


namespace BlazorGameSnakeComponent
{
    public class JsInterop
    {
        public static bool Alert(string a)
        {
            return (JSRuntime.Current as IJSInProcessRuntime).Invoke<bool>(
                "JsInteropSnake.Alert", a);
        }


        public static bool InitializeSound(int id, string path, bool loop)
        {

            return (JSRuntime.Current as IJSInProcessRuntime).Invoke<bool>(
                "JsInteropSnake.InitializeSound", new {id, path, loop });
        }


        public static bool ManageSound(int id, string command)
        {
            id = id - 1;
            return (JSRuntime.Current as IJSInProcessRuntime).Invoke<bool>(
                "JsInteropSnake.ManageSound", new { id, command});
        }


        
    }
}
