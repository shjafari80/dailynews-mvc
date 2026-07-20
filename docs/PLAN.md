# DailyNews — Project Plan

## What this is

DailyNews is a news website built with ASP.NET Core MVC. It started as a
learning project and is being rebuilt here step by step, with the full
commit history kept intact, so the repo itself tells the story of how it
was built — from an empty folder structure to a working site with a real
news API behind it.

## Goals

- Build a clean, modern news website (home feed, article pages, categories,
  authors).
- Ship a working admin panel to manage articles without touching the
  database directly.
- Start with static/seeded sample data, then swap in a real news API once
  the UI and structure are solid.
- Keep the whole build visible and readable through commit history —
  someone should be able to open this repo and follow along phase by phase.

## Roadmap

### Phase 1 — Scaffold
- Write the planning docs (this file, `REQUIREMENTS.md`, `ARCHITECTURE.md`).
- Create the full folder structure with empty/stub files (`// TODO` markers,
  no real logic yet).
- Set up the ASP.NET Core project, EF Core, and SQLite so `dotnet run`
  boots successfully even with nothing built yet.

**Definition of done:** project builds and runs, shows a blank/placeholder
page, folder structure matches `ARCHITECTURE.md`.

### Phase 2 — Static site (sample data)
- Implement models (`News`, `Author`, `Category`).
- Implement `NewsDbContext` with seed data: 1 author, 3 news articles,
  4 categories.
- Build the Home page (news feed), Article Details page, About page.
- First real run: a working, browsable static news site.

**Definition of done:** site runs locally, shows the 3 seeded articles
across 4 categories, article pages open correctly.

### Phase 3 — UI/UX pass
- Featured/hero article on the homepage.
- Category badges + filter tabs.
- Related articles + share buttons on article pages.
- Search bar in the navbar.
- Responsive polish, loading states, image fallbacks.
- Basic SEO/social meta tags (Open Graph, meta description).

**Definition of done:** the static site from Phase 2 looks and feels like
an actual news site, not a course project demo.

### Phase 4 — Ideas for later (not planned in detail yet)
Once Phases 1–3 are actually done, some directions worth exploring:

- Admin CRUD polish (add author, add news, add category without touching
  seed data by hand)
- An external links / references field on articles
- Maybe pulling in real articles from a free-tier news API
- Maybe deploying it somewhere free so it's a real, reachable site

None of this is scoped or scheduled yet — it's just the rough direction
things could go once there's an actual working site to build on. See
`REQUIREMENTS.md` for a couple of loose notes on API/hosting options, kept
intentionally light since nothing here is decided.

## Working conventions

- Commit messages use light prefixes: `feat:`, `fix:`, `docs:`, `style:`,
  `refactor:`.
- Each phase above becomes a GitHub Milestone; meaningful chunks of work
  within a phase become Issues, referenced in commits (e.g.
  `feat: add News model (#3)`).
- No phase is "done" until its Definition of Done is met — small, real,
  working increments over big jumps.

## Non-goals (for now)

- User accounts / comments / likes — out of scope unless added as a later
  phase.
- Multi-language support — the site is English-only for this build.
- Payment/subscription features — not part of this project.
