# Leo's Record Shop

A record shop website built with Blazor and .NET 8. It talks to the Northcoders Record Shop API.

This is a mini project from the Northcoders C# Full-Stack bootcamp.

## How to Run

Start the API first, then:

```bash
cd RecordShop/RecordShop
dotnet run
```

The site expects the API at `http://localhost:5113`.

## Pages

- `/` - home page with a welcome and a randomly featured record
- `/records` - all records
- `/records/{id}` - a single record, with editing and deleting
- `/records/add` - add a new record
- `/search` - search by id, title, artist, genre or year
- `/login` - log in (required to add, edit or delete records)
- `/about` - about the shop

## How it works

- **RecordsProvider** loads all records once and shares them with the home and
  all-records pages using a cascading parameter.
- **RecordLoader** fetches a single record by id.
- **RecordSummary** / **RecordsSummaryList** show records in a list.
- **RecordDetails** edits, saves and deletes a single record.
- **AddRecordForm** validates and posts a new record.

## API

Backend: `http://localhost:5113`

| Method | Endpoint | Description |
|--------|----------|-------------|
| GET | `/api/albums` | Get all albums |
| GET | `/api/albums/{id}` | Get single album |
| POST | `/api/albums` | Add an album |
| PUT | `/api/albums/{id}` | Update an album |
| DELETE | `/api/albums/{id}` | Delete an album |
