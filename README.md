# DailyNews

A news website built with ASP.NET Core MVC — home feed, article pages,
categories, authors, and an admin panel to manage it all.

Built step by step, with the full process documented in [`/docs`](docs),
including the plan, requirements, and architecture behind it.

## Tech stack

ASP.NET Core MVC · Entity Framework Core · SQLite · Bootstrap 5

## Status

🚧 In progress — see [`docs/PLAN.md`](docs/PLAN.md) for the roadmap and
current phase.

## Running locally

```bash
git clone https://github.com/YOUR_USERNAME/dailynews-mvc.git
cd dailynews-mvc
dotnet restore
dotnet ef database update
dotnet run
```

Then open:
- Site: http://localhost:5295/
- Admin panel: http://localhost:5295/Admin/News

## Docs

- [`docs/PLAN.md`](docs/PLAN.md) — phases, roadmap, working conventions
- [`docs/REQUIREMENTS.md`](docs/REQUIREMENTS.md) — tools, packages, setup
- [`docs/ARCHITECTURE.md`](docs/ARCHITECTURE.md) — folder structure, data model
