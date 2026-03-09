namespace _2._2_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            word.Text = Properties.Settings.Default.word.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputWord;
            try
            {
                inputWord = word.Text;
                if (string.IsNullOrWhiteSpace(inputWord))
                {
                    throw new FormatException();
                }
            }
            catch (FormatException)
            {
                return;
            }

            Properties.Settings.Default.word = inputWord;
            Properties.Settings.Default.Save();

            MessageBox.Show(Logic.SwapPairs(inputWord));
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
