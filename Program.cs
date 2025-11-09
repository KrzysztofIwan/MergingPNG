using System.Drawing.Imaging;

namespace MergingPNG
{
    public class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            List<string> inputFiles = new List<string>();
            string outputFile = "";

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Wybierz dokumenty PNG (możesz wybrać wiele)";
                openFileDialog.Filter = "Pliki PNG (*.png)|*.png";
                openFileDialog.Multiselect = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    inputFiles = openFileDialog.FileNames.ToList();
                }
            }

            if (inputFiles.Count == 1)
            {
                Console.WriteLine("[Błąd] - wybrano jeden plik do scalenia");
                return;
            }

            if (!inputFiles.All(File.Exists))
            {
                Console.WriteLine("[Błąd] - nie udało się pobrać wskzanych dokumentów");
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Title = "Wskaż miejsce i nazwę pliku do zapisania";
                saveFileDialog.Filter = "Pliki obrazów PNG (*.png)|*.png|Wszystkie pliki (*.*)|*.*";
                saveFileDialog.RestoreDirectory = true;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    outputFile = saveFileDialog.FileName;
                }
                else
                {
                    Console.WriteLine("[Błąd] - nie wskazano miejsca zapisu pliku");
                    return;
                }
            }

            try
            {
                Image[] images = inputFiles.Select(Image.FromFile).ToArray();
                int totalHeight = images.Sum(img => img.Height);
                int maxWidth = images.Max(img => img.Width);

                using (var combinedBitmap = new Bitmap(maxWidth, totalHeight))
                {
                    using (var g = Graphics.FromImage(combinedBitmap))
                    {
                        g.Clear(Color.White);

                        int currentY = 0;

                        foreach (var image in images)
                        {
                            g.DrawImage(image, 0, currentY, image.Width, image.Height);
                            currentY += image.Height;
                        }
                    }

                    combinedBitmap.Save(outputFile, ImageFormat.Png);
                }

                foreach (var image in images)
                {
                    image.Dispose();
                }

                Console.WriteLine($"Sukces: Połączony obraz zapisano jako '{outputFile}'.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Wystąpił błąd podczas przetwarzania obrazów: {ex.Message}");
            }
        }
    }
}