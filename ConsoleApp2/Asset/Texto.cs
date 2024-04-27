using System.Reflection.Metadata;

namespace Asset
{
    
    public class Texto

    {
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern IntPtr GetConsoleWindow();

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        private const int SW_HIDE = 0;

        private const int SW_MAXIMIZE = 3;

        static void Main(string[] args)
        {
            IntPtr handle = GetConsoleWindow();
            ShowWindow(handle, SW_MAXIMIZE);

            int consoleWidth = Console.WindowWidth;
            string texto = "       Bem-vindo a Arkania";
            string texto1 = "      Press Enter for Start";
            string texto2 = "         Sair";

            int posicaoInicial = (consoleWidth - texto.Length) / 2;
            int posicaoInicial1 = (consoleWidth - texto1.Length) / 2;
            int posicaoInicial2 = (consoleWidth - texto2.Length) / 2;

            Console.WriteLine(new string(' ', posicaoInicial) + texto);
            Console.WriteLine(new string(' ', posicaoInicial) + texto1);
            Console.WriteLine(new string(' ', posicaoInicial) + texto2);

            Console.ReadKey();

        }
    }
}