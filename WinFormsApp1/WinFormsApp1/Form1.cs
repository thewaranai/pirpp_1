namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] arr = new int[10];
            string[] input = textBoxInput.Text.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);

            if (input.Length != 10)
            {
                MessageBox.Show("Введите ровно 10 чисел!");
                return;
            }

            int sum = 0;

            for (int i = 0; i < 10; i++)
            {
                arr[i] = int.Parse(input[i]);
                sum += arr[i];
            }

            labelResult.Text = "Сумма = " + sum;
        }

        private void buttonMinMax_Click(object sender, EventArgs e)
        {
            int N = int.Parse(textBoxN.Text);
            int[] arr = new int[N];
            Random rnd = new Random();

            for (int i = 0; i < N; i++)
                arr[i] = rnd.Next(1, 101);

            int min = arr[0];
            int max = arr[0];
            int minIndex = 0;
            int maxIndex = 0;

            for (int i = 1; i < N; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                    minIndex = i;
                }

                if (arr[i] > max)
                {
                    max = arr[i];
                    maxIndex = i;
                }
            }

            labelMinMax.Text =
                $"Min = {min} (индекс {minIndex})\n" +
                $"Max = {max} (индекс {maxIndex})";
        }

        private void buttonEvenOdd_Click(object sender, EventArgs e)
        {
            int[] arr = new int[15];
            Random rnd = new Random();

            for (int i = 0; i < arr.Length; i++)
                arr[i] = rnd.Next(10, 51);

            int even = 0;
            int odd = 0;

            foreach (int number in arr)
            {
                if (number % 2 == 0)
                    even++;
                else
                    odd++;
            }

            labelEvenOdd.Text =
                "Четных: " + even + "\n" +
                "Нечетных: " + odd;
        }

        private void buttonReverse_Click(object sender, EventArgs e)
        {
            string[] input = textBoxReverse.Text.Split(' ');
            if (input.Length != 5)
            {
                MessageBox.Show("Введите 5 чисел через пробел!");
                return;
            }

            int[] arr = new int[5];
            int[] reversed = new int[5];

            for (int i = 0; i < 5; i++)
                arr[i] = int.Parse(input[i]);

            for (int i = 0; i < 5; i++)
                reversed[i] = arr[4 - i];

            labelReverse.Text =
                "Исходный: " + string.Join(" ", arr) +
                "\nРеверс: " + string.Join(" ", reversed);
        }

        private void buttonShift_Click(object sender, EventArgs e)
        {
            string[] input = textBoxShift.Text.Split(' ');
            int[] arr = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
                arr[i] = int.Parse(input[i]);

            int last = arr[arr.Length - 1];

            for (int i = arr.Length - 1; i > 0; i--)
                arr[i] = arr[i - 1];

            arr[0] = last;

            labelShift.Text = "Результат: " + string.Join(" ", arr);
        }

        private void buttonDuplicates_Click(object sender, EventArgs e)
        {
            string[] input = textBoxDuplicates.Text.Split(' ');

            if (input.Length != 10)
            {
                MessageBox.Show("Введите 10 чисел!");
                return;
            }

            int[] arr = new int[10];

            for (int i = 0; i < 10; i++)
                arr[i] = int.Parse(input[i]);

            string result = "";

            for (int i = 0; i < arr.Length; i++)
            {
                int count = 0;
                bool alreadyCounted = false;

                for (int k = 0; k < i; k++)
                {
                    if (arr[i] == arr[k])
                    {
                        alreadyCounted = true;
                        break;
                    }
                }

                if (alreadyCounted)
                    continue;

                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                        count++;
                }

                result += $"Число {arr[i]} встречается {count} раз(а)\n";
            }

            labelDuplicates.Text = result;
        }
    }
}
