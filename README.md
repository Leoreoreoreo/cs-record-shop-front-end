# Leo's Record Shop

A record shop website built with Blazor and .NET 8.

## How to Run

```bash
cd RecordShop/RecordShop
dotnet watch
```

## Project Structure

```
Pages/
├── Home.razor                   ← /
├── AllRecordsPage.razor         ← /records
│   └── RecordsLoader            ← fetches all albums from API
│       └── RecordsSummaryList
│           └── RecordSummary × N
└── RecordPage.razor             ← /records/{id}
    └── RecordLoader             ← fetches single album from API
        └── RecordDetails        ← edit form + save to API

Layout/
├── MainLayout.razor             ← header / main / footer
└── NavMenu.razor

Model/
└── Album.cs                     ← Id, Name, Artist, Genre, ReleaseYear, Stock, Price
```

## API

Backend: `http://localhost:5113`

| Method | Endpoint | Description |
|--------|----------|-------------|
| GET | `/api/albums` | Get all albums |
| GET | `/api/albums/{id}` | Get single album |
| PUT | `/api/albums/{id}` | Update album |

## Planned

- Navigation between list and detail pages
- Browse by genre
- Search
