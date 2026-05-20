# Leo's Record Shop

A Blazor Web App built with .NET 8 and Auto interactivity mode.

## How to Run

```bash
cd RecordShop/RecordShop
dotnet watch
```

Then open https://localhost:PORT in your browser (check terminal for port number).

## Tech Stack

- **Blazor Web App** — .NET 8
- **Auto interactivity mode** — uses Server-side rendering initially, switches to WebAssembly once downloaded
- **Two projects** — `RecordShop` (server) + `RecordShop.Client` (WebAssembly)

## Routes

| Route | Page | Description |
|-------|------|-------------|
| `/` | Home.razor | Hardcoded single record (temporary) |
| `/records` | AllRecordsPage.razor | All records from API |
| `/records/{id}` | RecordPage.razor | Single record detail & edit |

## Component Structure

```
Pages/
├── Home.razor                  ← "/" hardcoded album (temporary)
├── AllRecordsPage.razor        ← "/records"
│   └── RecordsLoader           ← GET /api/albums
│       └── RecordsSummaryList
│           └── RecordSummary × N
└── RecordPage.razor            ← "/records/{id}"
    └── RecordLoader            ← GET /api/albums/{id}
        └── RecordDetails       ← EditForm + Save (PUT /api/albums/{id})

Layout/
├── MainLayout.razor            ← header / main / footer
└── NavMenu.razor               ← navigation links

Models/
└── Album.cs
    ├── int Id
    ├── string Name
    ├── string Artist
    ├── string Genre
    ├── int ReleaseYear
    ├── int Stock
    └── decimal Price
```

## Projects

| Project | Purpose |
|---------|---------|
| `RecordShop` | Server-side rendering & InteractiveServer components |
| `RecordShop.Client` | WebAssembly client-side components |

## Planned Features

- Navigation links from record list to detail page
- Browse by genre
- Search functionality
