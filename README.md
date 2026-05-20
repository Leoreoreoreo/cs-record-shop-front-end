# Leo's Record Shop

A Blazor Web App built with .NET 8 and Auto interactivity mode.

## How to Run

```bash
cd RecordShop/RecordShop
dotnet watch
```

Then open https://localhost:5001 in your browser.

## Tech Stack

- **Blazor Web App** — .NET 8
- **Auto interactivity mode** — uses Server-side rendering initially, switches to WebAssembly once downloaded
- **Two projects** — `RecordShop` (server) + `RecordShop.Client` (WebAssembly)

## Component Structure

```
App.razor
└── Routes.razor
    └── MainLayout.razor          ← Layout wrapper
        ├── <header>
        │   ├── .header-brand     ← Shop title & tagline
        │   └── NavMenu.razor     ← Navigation links
        ├── <main>
        │   └── @Body             ← Page content renders here
        └── <footer>              ← Name & year

Pages/
└── Home.razor                    ← "/" route
    └── RecordsSummaryList.razor  ← Takes List<Record>
        └── RecordSummary.razor   ← Takes single Record
            ├── Title
            ├── Artist
            ├── Genre
            └── Price

Models/
└── Record.cs
    ├── string Title
    ├── string Artist
    ├── string Genre
    └── decimal Price
```

## Projects

| Project | Purpose |
|---------|---------|
| `RecordShop` | Server-side rendering & InteractiveServer components |
| `RecordShop.Client` | WebAssembly client-side components |

## Planned Features

- Connect to Record Shop API for real data
- Individual record detail page
- Browse by genre
- Search functionality
