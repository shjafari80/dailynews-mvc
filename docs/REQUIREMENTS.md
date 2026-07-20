# Requirements

Everything you need installed and the key decisions behind each choice.

## Local development tools

| Tool | Version | Why |
|---|---|---|
| .NET SDK | 10.0+ | Runtime + build tools for the whole project |
| EF Core CLI tools | `dotnet-ef` (latest matching EF Core version) | Create/apply migrations from the command line |
| Git | any recent version | Version control |
| A code editor | VS Code, Visual Studio, or Rider | Any works; VS Code + C# Dev Kit is the lightest free option |
| SQLite browser (optional) | e.g. "DB Browser for SQLite" | Inspect the local `.db` file visually, optional but handy |

Install the EF Core tools once, globally:
```bash
dotnet tool install --global dotnet-ef
```

## NuGet packages (already used / needed across phases)

| Package | Used for |
|---|---|
| `Microsoft.EntityFrameworkCore.Sqlite` | SQLite provider for EF Core |
| `Microsoft.EntityFrameworkCore.Design` | Needed for migrations tooling |
| `Microsoft.EntityFrameworkCore.Tools` | `dotnet ef` commands |

Later, once Phase 4 (real API) starts, we'll likely add:

| Package | Used for |
|---|---|
| `Microsoft.Extensions.Http` | Typed `HttpClient` for calling the news API cleanly |

## Database

- **Local dev:** SQLite (`DailyNews.db`), file-based, zero setup.
- **Production:** SQLite works fine for a small project, but most free
  hosts wipe the filesystem on redeploy/restart. If we deploy somewhere
  with an ephemeral filesystem, we'll need to either:
  - switch to a free hosted Postgres (e.g. via Render, Supabase, Neon), or
  - deploy somewhere with a persistent volume (e.g. Fly.io) and keep SQLite.
  This decision gets made in Phase 4, not before.

## Maybe later: real news API (not decided, just noted)

If a real news API gets added down the line, a few free-tier options exist
(GNews.io, NewsData.io, Mediastack, NewsAPI.org — the last one blocks
live-site use on its free tier, worth knowing). No pick has been made and
none of this is scheduled — just leaving a pointer here so it's not
forgotten.

## Maybe later: free hosting (not decided, just noted)

Similarly, if this ever gets deployed, Azure App Service, Render.com, and
Fly.io all have some form of free tier worth looking at when the time
comes. Nothing chosen, nothing scoped — just a breadcrumb for later.

## Things intentionally NOT required

- No SQL Server — SQLite is enough for this project's scale.
- No frontend build tooling (no Node/npm/webpack) — Bootstrap is pulled via
  CDN, keeping the project dependency-light.
- No authentication/authorization framework — the admin panel is not
  publicly locked down in this build (add this as a future improvement if
  the site becomes public-facing with sensitive operations).
