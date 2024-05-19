using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        private Stopwatch stopwatch;
        private double firstNumber = 0;
        private string operation = string.Empty;

        public Form1()
        {
            InitializeComponent();

            stopwatch = new Stopwatch();
            stopwatch.Start();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stopwatch.Stop();
            long initializationTime = stopwatch.ElapsedMilliseconds;

            const long threshold = 500; // Próg czasu inicjalizacji w milisekundach
            if (initializationTime > threshold)
            {
                LogInitializationTime(initializationTime);
            }
        }

        private void LogInitializationTime(long time)
        {
            if (!EventLog.SourceExists("SimpleCalculator"))
            {
                EventLog.CreateEventSource("SimpleCalculator", "Application");
            }

            EventLog.WriteEntry("SimpleCalculator", $"Aplikacja inicjalizowała się przez {time} ms, co przekracza dopuszczalny próg.", EventLogEntryType.Warning);
        }

        private void number_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                if (txtDisplay.Text == "0")
                    txtDisplay.Text = button.Text;
                else
                    txtDisplay.Text += button.Text;
            }
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                firstNumber = double.Parse(txtDisplay.Text);
                operation = button.Text;
                txtDisplay.Text = "0";
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            double secondNumber = double.Parse(txtDisplay.Text);
            double result = 0;

            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    if (secondNumber != 0)
                        result = firstNumber / secondNumber;
                    else
                        MessageBox.Show("Nie można dzielić przez zero!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            txtDisplay.Text = result.ToString();
            firstNumber = result;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            firstNumber = 0;
            operation = string.Empty;
        }
    }
}
