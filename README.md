# IronPDF-Issue

## Problem Description
What we're seeing is that some PDFs are not properly loaded and output from the IronPDF software. We've found that simply opening the PDF inside of Adobe and resaving the PDF will then allow IronPDF to properly interact with it. However, there is no indicator as to when this will or will not happen and the IronPDF software seems to think it's perfectly fine when really it's not.

In the `bin` folder you'll see a `does_not_work.pdf` file. This PDF was saved using Microsoft Print to PDF from Microsoft Word.
Also in the `bin` folder, you'll see a `does_work.pdf` file. This PDF is the `does_not_work.pdf` file, but has been opened in Adobe Acrobat DC and resaved.

When you run this application, it simply opens the PDF files and creates files with `_output` in the name so you can see how it handles it and how it doesn't work.
