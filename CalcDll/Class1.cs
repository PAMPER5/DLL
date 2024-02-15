using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace CalcDll
{
    public class CalculatorStarter
    {
        [DllExport("StartCalculator", CallingConvention = CallingConvention.StdCall)]
        public static int StartCalculator(IntPtr hwnd, IntPtr hinst, IntPtr lpszCmdLine, int nCmdShow)
        {
            try
            {
                Process.Start("calc.exe");
                return 0; // Успешный запуск калькулятора  
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при запуске калькулятора: " + ex.Message);
                return 1; // Ошибка при запуске калькулятора  
            }
        }
    }
}

