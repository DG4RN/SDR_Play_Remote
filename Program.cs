using System.Windows.Forms;


namespace SDR_Play_Remote
{
    class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
       // [STAThread]
        static void Main(string[] args)
        {
            // Zieladress und Port
            string server = "192.168.178.111";
            int port = 27299;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
    }
}
