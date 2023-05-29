namespace KP_10
{
    public partial class Form1 : Form
    {
        string path;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            File.Create(path);
        }

        private void buttonWrite_Click(object sender, EventArgs e)
        {
            File.WriteAllText(path, textBoxWriteText.Text);

        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            textBoxReadText.Text = File.ReadAllText(path);

        }

        private void textBoxPath_TextChanged(object sender, EventArgs e)
        {
            path = textBoxPath.Text;
        }

        private void buttonNumLines_Click(object sender, EventArgs e)
        {
            textBoxNumLines.Text = File.ReadAllLines(path).Length.ToString();
        }

        private void buttonNumOfContain_Click(object sender, EventArgs e)
        {
            string str = textBoxFindW.Text;
            string stringa = File.ReadAllText(path);
            string[] strings = File.ReadAllLines(path);
            int count = 0;
            for (int i = 0; i < File.ReadAllLines(path).Length; i++)
            {
                if (strings[i].Contains(str)) count++;
            }
            textBoxNumNeedLines.Text = count.ToString();
            count = 0;
            for (int i = 0; i < stringa.Length - str.Length; i++)
            {
                string temp_str = stringa.Substring(i, str.Length);
                if (temp_str == str) count++;
            }
            textBoxNumW.Text = count.ToString();
        }

        private void buttonChangeW_Click(object sender, EventArgs e)
        {
            string str = textBoxFindW.Text;
            string new_str = textBoxNewW.Text;
            string stringa = File.ReadAllText(path);
            stringa = stringa.Replace(str, new_str);
            File.WriteAllText(path, stringa);
        }

        private void buttonToUp_Click(object sender, EventArgs e)
        {
            string stringa = File.ReadAllText(path);
            stringa = stringa.ToUpper();
            File.WriteAllText(path, stringa);
        }

        private void buttonToLow_Click(object sender, EventArgs e)
        {
            string stringa = File.ReadAllText(path);
            stringa = stringa.ToLower();
            File.WriteAllText(path, stringa);
        }
    }
}