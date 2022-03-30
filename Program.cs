using IronPdf;
using System.Drawing.Imaging;

IronPdf.License.LicenseKey = "";

var document = new PdfDocument("does_work.pdf");
var bmp = document.ToBitmap();
using (var stream = new FileStream("AdamTest.72.bmp", FileMode.OpenOrCreate))
{
    bmp[0].Save(stream, ImageFormat.Bmp);
}

bmp = document.ToBitmap(300);
using (var stream = new FileStream("AdamTest.300.bmp", FileMode.OpenOrCreate))
{
    bmp[0].Save(stream, ImageFormat.Bmp);
}

bmp = document.ToBitmap(600);
using (var stream = new FileStream("AdamTest.600.bmp", FileMode.OpenOrCreate))
{
    bmp[0].Save(stream, ImageFormat.Bmp);
}

