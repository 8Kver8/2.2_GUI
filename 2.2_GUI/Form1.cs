namespace _2._2_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Logic.SwapPairs(word.Text));
        }
    }

    public class Logic
    {
        public static string SwapPairs(string word)
        {
            char[] letters = word.ToCharArray();

            for (int i = 0; i < letters.Length - 1; i += 2)
            {
                char temp = letters[i];
                letters[i] = letters[i + 1];
                letters[i + 1] = temp;
            }

            return new string(letters);
        }
    }
}
