# DocumentFactory вЂ” C#

## Description

- `Document` вЂ” abstract class with abstract `Print()` and `PrepareForPrinting()` methods
- `PDFDocument`, `WordDocument`, `ExcelDocument` вЂ” inherit `Document` and implement `Print()`
- `DocumentFactory` вЂ” factory method that creates document objects by type

## Run

```bash
dotnet run
```
