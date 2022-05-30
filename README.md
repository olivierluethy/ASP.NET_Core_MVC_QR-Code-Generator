# QR-Code Generator mit ASP.NET Core MVC
Ein ASP.NET Core MVC Projekt mit dem man QR-Codes generieren kann.

## Links
Dieses Projekt wurde mit Hilfe von dieser Webseite erschaffen: <br>
https://www.compilemode.com/2021/04/how-to-generate-qr-code-using-asp-net-core.html

## Errors - Solved
Im ```HomeController.cs``` File wo ein neues ```QRCode``` Objekt erzeugt wird, gibt es ein Fehler, da scheinbar diese Methode in der Library ```QRCoder``` nicht vorhanden ist. Die Library wurde aber erfolgreich unter dem NuGet Packet Manager erfolgreich installiert.

Lösung: In der Projektmappe unter ```Eigenschaften```-> ```Allgemein``` -> Unter Zielbetriebssystem auf ```Windows``` umstellen und dann funktioniert es.