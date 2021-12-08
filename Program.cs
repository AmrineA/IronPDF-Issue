using IronPdf;

IronPdf.License.LicenseKey = "";
var document = new PdfDocument("does_work.pdf");
document.SaveAs("does_work_output.pdf");

var document2 = new PdfDocument("does_not_work.pdf");
document2.SaveAs("does_not_work_output.pdf");
