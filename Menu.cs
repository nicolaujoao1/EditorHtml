namespace EditorHTML
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor=ConsoleColor.Blue;
            Console.ForegroundColor=ConsoleColor.Black;
            DrawScreen();
            WriteOptions();
            var option=(short)Convert.ToInt32(Console.ReadLine());
            HandleMenuOption(option);
        }
        public static void HandleMenuOption(short option){
            switch (option)
            {
                case (short)EOPtions.NewFile:
                                Editor.Show();
                                break;
                case (short)EOPtions.Open:
                                Console.WriteLine("VIEW");
                                break;
                case (short)EOPtions.LogOut:{
                                Console.Clear();
                                Environment.Exit(0);
                                break;
                }
                default:
                                Show();
                                break;
            }
        }
        public static void SetPosition(int y){
            Console.SetCursorPosition(3,y);
        }
        public static void DrawLines(){
            Console.Write("+");
            for (int i = 0; i < 30; i++)
                Console.Write("-");
            Console.Write("+");
        }
        public static void BreakLine()
        {
            Console.Write("\n");
        }
        public static void DrawColumnXLines(){
            BreakLine();
            for (int i = 0; i < 10; i++)
            {
                Console.Write("|");  
                for (int j = 0; j < 30; j++)
                    Console.Write(" ");
                Console.Write("|");  
                BreakLine();
            }
            DrawLines();
        }
        public static void DrawScreen(){
            DrawLines();
            DrawColumnXLines();
        }
        public static void WriteOptions()
        {
            SetPosition(2);
            Console.WriteLine("EDITOR HTML");
            SetPosition(3);
            Console.WriteLine("===============");
            SetPosition(4);
            Console.WriteLine("SELECIONE UMA OPÇÃO:");
            SetPosition(6);
            Console.WriteLine("1 - NOVO ARQUIVO");
            SetPosition(7);
            Console.WriteLine("2 - ABRIR");
            SetPosition(8);
            Console.WriteLine("0 - SAIR");
            SetPosition(10);
            Console.Write("Opção:");

        }
        enum EOPtions
        {
            NewFile=1,Open=2, LogOut=0
        }
    }
}