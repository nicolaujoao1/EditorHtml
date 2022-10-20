using System.Text;
namespace EditorHTML
{
    public static class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor=ConsoleColor.White;
            Console.ForegroundColor=ConsoleColor.Black;
            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("-----------");
            Start();
        }
        public static void Start()
        {
            var file=new StringBuilder();
            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            } while (Console.ReadKey().Key!=ConsoleKey.Escape);
            Console.WriteLine("-------------");
            Console.WriteLine(" Desejas gravar o seu arquivo?");
            Viewer.Show(file.ToString());
        }
    }
}