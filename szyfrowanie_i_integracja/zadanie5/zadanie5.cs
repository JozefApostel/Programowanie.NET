using System;
using System.Windows.Forms;
using System.Drawing;

namespace SinusoidPlotterApp
{
    // Klasa reprezentująca główne okno aplikacji
    public partial class MainForm : Form
    {
        private Label amplitudeLabel;
        private TextBox amplitudeTextBox;
        private Label frequencyLabel;
        private TextBox frequencyTextBox;
        private Label phaseLabel;
        private TextBox phaseTextBox;
        private Button plotButton;
        private PictureBox plotPictureBox;

        // Konstruktor głównego okna
        public MainForm()
        {
            InitializeComponent();
        }

        // Metoda inicjalizująca komponenty interfejsu użytkownika
        private void InitializeComponent()
        {
            this.Size = new Size(400, 300);
            this.Text = "Sinusoid Plotter App";

            // Tworzenie etykiet i pól tekstowych dla amplitudy, częstotliwości i fazy
            amplitudeLabel = new Label();
            amplitudeLabel.Text = "Amplituda:";
            amplitudeLabel.Location = new Point(10, 10);
            this.Controls.Add(amplitudeLabel);

            amplitudeTextBox = new TextBox();
            amplitudeTextBox.Location = new Point(100, 10);
            this.Controls.Add(amplitudeTextBox);

            frequencyLabel = new Label();
            frequencyLabel.Text = "Częstotliwość:";
            frequencyLabel.Location = new Point(10, 40);
            this.Controls.Add(frequencyLabel);

            frequencyTextBox = new TextBox();
            frequencyTextBox.Location = new Point(100, 40);
            this.Controls.Add(frequencyTextBox);

            phaseLabel = new Label();
            phaseLabel.Text = "Faza:";
            phaseLabel.Location = new Point(10, 70);
            this.Controls.Add(phaseLabel);

            phaseTextBox = new TextBox();
            phaseTextBox.Location = new Point(100, 70);
            this.Controls.Add(phaseTextBox);

            // Tworzenie przycisku do rysowania sinusoidy
            plotButton = new Button();
            plotButton.Text = "Narysuj Sinusoidę";
            plotButton.Location = new Point(10, 100);
            plotButton.Click += PlotButton_Click;
            this.Controls.Add(plotButton);

            // Tworzenie obszaru do wyświetlania wykresu
            plotPictureBox = new PictureBox();
            plotPictureBox.Location = new Point(10, 130);
            plotPictureBox.Size = new Size(360, 160);
            this.Controls.Add(plotPictureBox);
        }

        // Metoda obsługująca kliknięcie przycisku do rysowania sinusoidy
        private void PlotButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Pobranie danych z pól tekstowych
                double amplitude = double.Parse(amplitudeTextBox.Text);
                double frequency = double.Parse(frequencyTextBox.Text);
                double phase = double.Parse(phaseTextBox.Text);

                // Utworzenie obrazu na którym będzie rysowana sinusoida
                Bitmap bitmap = new Bitmap(plotPictureBox.Width, plotPictureBox.Height);
                Graphics g = Graphics.FromImage(bitmap);

                Pen pen = new Pen(Color.Blue);
                // Rysowanie sinusoidy
                for (int x = 0; x < plotPictureBox.Width; x++)
                {
                    double t = x / 10.0; // Zakres czasu
                    double y = amplitude * Math.Sin(2 * Math.PI * frequency * t + phase);
                    int drawY = plotPictureBox.Height / 2 - (int)y;
                    bitmap.SetPixel(x, drawY, Color.Blue);
                }

                // Rysowanie osi czasu
                g.DrawLine(pen, new Point(0, plotPictureBox.Height / 2), new Point(plotPictureBox.Width, plotPictureBox.Height / 2));

                // Wyświetlenie wykresu na PictureBox
                plotPictureBox.Image = bitmap;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd: " + ex.Message);
            }
        }
    }

    // Klasa zawierająca metodę Main do uruchomienia aplikacji
    public class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
