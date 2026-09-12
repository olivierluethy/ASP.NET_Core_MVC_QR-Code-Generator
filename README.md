# ASP.NET Core MVC QR-Code Generator

A small ASP.NET Core MVC web app that turns any text or URL into a QR code and displays it right in the browser.

## Features

- Enter any text or URL and generate a QR code on submit.
- The QR code is rendered server-side and shown inline as a base64 PNG (no file is written to disk).
- Clean MVC structure (`QRCodeModel`, `HomeController`, Razor views) built on the standard ASP.NET Core template.

## Tech

- **C# / .NET 6** (`net6.0-windows`), ASP.NET Core MVC
- [**QRCoder**](https://github.com/codebude/QRCoder) for QR generation (`QRCoderNetCore` package)
- `System.Drawing.Common` for producing the PNG bitmap
- Bootstrap + jQuery for the front-end (from the default template)

> Note: because it uses `System.Drawing.Common`, the project targets `net6.0-windows` and is intended to run on Windows.

## Run

Requires the [.NET 6 SDK](https://dotnet.microsoft.com/download) on Windows.

```bash
git clone https://github.com/olivierluethy/ASP.NET_Core_MVC_QR-Code-Generator.git
cd "ASP.NET_Core_MVC_QR-Code-Generator/ASP.NET-Core QR-Code Generator"
dotnet run
```

Then open the URL printed in the console (e.g. `https://localhost:5001`). You can also open the `.sln` file in Visual Studio and press F5.

## How it works

`HomeController.CreateQRCode` builds a `QRCodeData` object from the submitted text with the QRCoder library, renders it to a `Bitmap`, converts the bitmap to a byte array, and passes it to the view as a `data:image/png;base64,...` URI via `ViewBag`.

## Credits

Originally built following [this tutorial](https://www.compilemode.com/2021/04/how-to-generate-qr-code-using-asp-net-core.html).
