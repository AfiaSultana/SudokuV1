namespace SudokuV1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load_Game();
        }

        private void Load_Game()
        {
            int[,] sudokuGrid = new int[,]
       {
            {5, 3, 0, 0, 7, 0, 0, 0, 0},
            {6, 0, 0, 1, 9, 5, 0, 0, 0},
            {0, 9, 8, 0, 0, 0, 0, 6, 0},
            {8, 0, 0, 0, 6, 0, 0, 0, 3},
            {4, 0, 0, 8, 0, 3, 0, 0, 1},
            {7, 0, 0, 0, 2, 0, 0, 0, 6},
            {0, 6, 0, 0, 0, 0, 2, 8, 0},
            {0, 0, 0, 4, 1, 9, 0, 0, 5},
            {0, 0, 0, 0, 8, 0, 0, 7, 9}
       };
            foreach (Control control in SudokuPanel.Controls)
            {
               
                if (control is Label)
                {
                    
                    Label label = (Label)control;
                    Console.WriteLine(label.Name);

                   
                    int[] location = GetDigitsFromString(label.Name);
                    Console.WriteLine(location[0]+" "+ location[1]);


                    if (location.Length == 2)
                    {
                        int row = location[0]-1;
                        int column = location[1]-1;
                        if(sudokuGrid[row, column]==0)
                        {
                            label.Text = "  ";
                        }
                    else
                        {
                            label.Text = sudokuGrid[row, column].ToString();
                        }
                        
                    }


                    
                }
            }

        }
        static int[] GetDigitsFromString(string input)
        {
            // Extracting the digits from the input string
            string digitsStr = input.Substring(1); // Remove the "L" prefix
            int[] digits = new int[2];

            // Parsing the digits to integers
            digits[0] = int.Parse(digitsStr[0].ToString());
            digits[1] = int.Parse(digitsStr[1].ToString());

            return digits;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void L33_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {

        }







       
        private void L11_MouseClick(object sender, MouseEventArgs e)
        {
            if (L11.Text == "  ")
            {
                L11.Text = textBox1.Text;
            }
        }
        private void L12_MouseClick(object sender, MouseEventArgs e)
        {
            L12.Text = textBox1.Text;
        }
        private void L13_MouseClick(object sender, MouseEventArgs e)
        {
            L13.Text = textBox1.Text;
        }
        private void L14_MouseClick(object sender, MouseEventArgs e)
        {
            L14.Text = textBox1.Text;
        }
        private void L15_MouseClick(object sender, MouseEventArgs e)
        {
            L15.Text = textBox1.Text;
        }
        private void L16_MouseClick(object sender, MouseEventArgs e)
        {
            L16.Text = textBox1.Text;
        }
        private void L17_MouseClick(object sender, MouseEventArgs e)
        {
            L17.Text = textBox1.Text;
        }
        private void L18_MouseClick(object sender, MouseEventArgs e)
        {
            L18.Text = textBox1.Text;
        }
        private void L19_MouseClick(object sender, MouseEventArgs e)
        {
            L19.Text = textBox1.Text;
        }
        private void L21_MouseClick(object sender, MouseEventArgs e)
        {
            L21.Text = textBox1.Text;
        }
        private void L22_MouseClick(object sender, MouseEventArgs e)
        {
            L22.Text = textBox1.Text;
        }
        private void L23_MouseClick(object sender, MouseEventArgs e)
        {
            L23.Text = textBox1.Text;
        }
        private void L24_MouseClick(object sender, MouseEventArgs e)
        {
            L24.Text = textBox1.Text;
        }
        private void L25_MouseClick(object sender, MouseEventArgs e)
        {
            L25.Text = textBox1.Text;
        }
        private void L26_MouseClick(object sender, MouseEventArgs e)
        {
            L26.Text = textBox1.Text;
        }
        private void L27_MouseClick(object sender, MouseEventArgs e)
        {
            L27.Text = textBox1.Text;
        }
        private void L28_MouseClick(object sender, MouseEventArgs e)
        {
            L28.Text = textBox1.Text;
        }
        private void L29_MouseClick(object sender, MouseEventArgs e)
        {
            L29.Text = textBox1.Text;
        }
        private void L31_MouseClick(object sender, MouseEventArgs e)
        {
            L31.Text = textBox1.Text;
        }
        private void L32_MouseClick(object sender, MouseEventArgs e)
        {
            L32.Text = textBox1.Text;
        }
        private void L33_MouseClick(object sender, MouseEventArgs e)
        {
            L33.Text = textBox1.Text;
        }
        private void L34_MouseClick(object sender, MouseEventArgs e)
        {
            L34.Text = textBox1.Text;
        }
        private void L35_MouseClick(object sender, MouseEventArgs e)
        {
            L35.Text = textBox1.Text;
        }
        private void L36_MouseClick(object sender, MouseEventArgs e)
        {
            L36.Text = textBox1.Text;
        }
        private void L37_MouseClick(object sender, MouseEventArgs e)
        {
            L37.Text = textBox1.Text;
        }
        private void L38_MouseClick(object sender, MouseEventArgs e)
        {
            L38.Text = textBox1.Text;
        }
        private void L39_MouseClick(object sender, MouseEventArgs e)
        {
            L39.Text = textBox1.Text;
        }
        private void L41_MouseClick(object sender, MouseEventArgs e)
        {
            L41.Text = textBox1.Text;
        }
        private void L42_MouseClick(object sender, MouseEventArgs e)
        {
            L42.Text = textBox1.Text;
        }
        private void L43_MouseClick(object sender, MouseEventArgs e)
        {
            L43.Text = textBox1.Text;
        }
        private void L44_MouseClick(object sender, MouseEventArgs e)
        {
            L44.Text = textBox1.Text;
        }
        private void L45_MouseClick(object sender, MouseEventArgs e)
        {
            L45.Text = textBox1.Text;
        }
        private void L46_MouseClick(object sender, MouseEventArgs e)
        {
            L46.Text = textBox1.Text;
        }
        private void L47_MouseClick(object sender, MouseEventArgs e)
        {
            L47.Text = textBox1.Text;
        }
        private void L48_MouseClick(object sender, MouseEventArgs e)
        {
            L48.Text = textBox1.Text;
        }
        private void L49_MouseClick(object sender, MouseEventArgs e)
        {
            L49.Text = textBox1.Text;
        }
        private void L51_MouseClick(object sender, MouseEventArgs e)
        {
            L51.Text = textBox1.Text;
        }
        private void L52_MouseClick(object sender, MouseEventArgs e)
        {
            L52.Text = textBox1.Text;
        }
        private void L53_MouseClick(object sender, MouseEventArgs e)
        {
            L53.Text = textBox1.Text;
        }
        private void L54_MouseClick(object sender, MouseEventArgs e)
        {
            L54.Text = textBox1.Text;
        }
        private void L55_MouseClick(object sender, MouseEventArgs e)
        {
            L55.Text = textBox1.Text;
        }
        private void L56_MouseClick(object sender, MouseEventArgs e)
        {
            L56.Text = textBox1.Text;
        }
        private void L57_MouseClick(object sender, MouseEventArgs e)
        {
            L57.Text = textBox1.Text;
        }
        private void L58_MouseClick(object sender, MouseEventArgs e)
        {
            L58.Text = textBox1.Text;
        }
        private void L59_MouseClick(object sender, MouseEventArgs e)
        {
            L59.Text = textBox1.Text;
        }
        private void L61_MouseClick(object sender, MouseEventArgs e)
        {
            L61.Text = textBox1.Text;
        }
        private void L62_MouseClick(object sender, MouseEventArgs e)
        {
            L62.Text = textBox1.Text;
        }
        private void L63_MouseClick(object sender, MouseEventArgs e)
        {
            L63.Text = textBox1.Text;
        }
        private void L64_MouseClick(object sender, MouseEventArgs e)
        {
            L64.Text = textBox1.Text;
        }
        private void L65_MouseClick(object sender, MouseEventArgs e)
        {
            L65.Text = textBox1.Text;
        }
        private void L66_MouseClick(object sender, MouseEventArgs e)
        {
            L66.Text = textBox1.Text;
        }
        private void L67_MouseClick(object sender, MouseEventArgs e)
        {
            L67.Text = textBox1.Text;
        }
        private void L68_MouseClick(object sender, MouseEventArgs e)
        {
            L68.Text = textBox1.Text;
        }
        private void L69_MouseClick(object sender, MouseEventArgs e)
        {
            L69.Text = textBox1.Text;
        }
        private void L71_MouseClick(object sender, MouseEventArgs e)
        {
            L71.Text = textBox1.Text;
        }
        private void L72_MouseClick(object sender, MouseEventArgs e)
        {
            L72.Text = textBox1.Text;
        }
        private void L73_MouseClick(object sender, MouseEventArgs e)
        {
            L73.Text = textBox1.Text;
        }
        private void L74_MouseClick(object sender, MouseEventArgs e)
        {
            L74.Text = textBox1.Text;
        }
        private void L75_MouseClick(object sender, MouseEventArgs e)
        {
            L75.Text = textBox1.Text;
        }
        private void L76_MouseClick(object sender, MouseEventArgs e)
        {
            L76.Text = textBox1.Text;
        }
        private void L77_MouseClick(object sender, MouseEventArgs e)
        {
            L77.Text = textBox1.Text;
        }
        private void L78_MouseClick(object sender, MouseEventArgs e)
        {
            L78.Text = textBox1.Text;
        }
        private void L79_MouseClick(object sender, MouseEventArgs e)
        {
            L79.Text = textBox1.Text;
        }
        private void L81_MouseClick(object sender, MouseEventArgs e)
        {
            L81.Text = textBox1.Text;
        }
        private void L82_MouseClick(object sender, MouseEventArgs e)
        {
            L82.Text = textBox1.Text;
        }
        private void L83_MouseClick(object sender, MouseEventArgs e)
        {
            L83.Text = textBox1.Text;
        }
        private void L84_MouseClick(object sender, MouseEventArgs e)
        {
            L84.Text = textBox1.Text;
        }
        private void L85_MouseClick(object sender, MouseEventArgs e)
        {
            L85.Text = textBox1.Text;
        }
        private void L86_MouseClick(object sender, MouseEventArgs e)
        {
            L86.Text = textBox1.Text;
        }
        private void L87_MouseClick(object sender, MouseEventArgs e)
        {
            L87.Text = textBox1.Text;
        }
        private void L88_MouseClick(object sender, MouseEventArgs e)
        {
            L88.Text = textBox1.Text;
        }
        private void L89_MouseClick(object sender, MouseEventArgs e)
        {
            L89.Text = textBox1.Text;
        }
        private void L91_MouseClick(object sender, MouseEventArgs e)
        {
            L91.Text = textBox1.Text;
        }
        private void L92_MouseClick(object sender, MouseEventArgs e)
        {
            L92.Text = textBox1.Text;
        }
        private void L93_MouseClick(object sender, MouseEventArgs e)
        {
            L93.Text = textBox1.Text;
        }
        private void L94_MouseClick(object sender, MouseEventArgs e)
        {
            L94.Text = textBox1.Text;
        }
        private void L95_MouseClick(object sender, MouseEventArgs e)
        {
            L95.Text = textBox1.Text;
        }
        private void L96_MouseClick(object sender, MouseEventArgs e)
        {
            L96.Text = textBox1.Text;
        }
        private void L97_MouseClick(object sender, MouseEventArgs e)
        {
            L97.Text = textBox1.Text;
        }
        private void L98_MouseClick(object sender, MouseEventArgs e)
        {
            L98.Text = textBox1.Text;
        }
        private void L99_MouseClick(object sender, MouseEventArgs e)
        {
            L99.Text = textBox1.Text;
        }

        
    }
}
