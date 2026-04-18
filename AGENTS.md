# AGENTS.md

## Repo Snapshot
- Single-project ASP.NET Core MVC app targeting `net10.0` (`DATN.csproj`).
- Solution file `DATN.slnx` contains only `DATN.csproj`.
- Real app startup is `Program.cs`; default route is `{controller=Home}/{action=Index}/{id?}`.

## High-Value Paths
- `Program.cs`: service registration and middleware pipeline.
- `Controllers/HomeController.cs`: current user-facing routes (`Index`, `Privacy`, `Error`).
- `Views/`: Razor UI templates.
- `Views/Shared/_Layout.cshtml`: global HTML shell, Bootstrap includes, nav/footer.
- `wwwroot/`: static assets (Bootstrap/jQuery are vendored under `wwwroot/lib`, not npm-managed).

## Commands (Verified)
- Build: `dotnet build DATN.csproj`
- Run app: `dotnet run --project DATN.csproj`
- Run with launch profile URLs from `launchSettings.json`:
  - HTTP: `dotnet run --launch-profile http` (http://localhost:5058)
  - HTTPS: `dotnet run --launch-profile https` (https://localhost:7225 + http://localhost:5058)
- Tests: `dotnet test DATN.csproj` currently finds no test project/tests.

## Workflow Notes
- No CI workflows, lint/format config, or repo-local instruction files were found.
- `README.md` currently has only the project title; do not assume extra documented setup.
- For UI changes, validate by running the app and checking rendered Razor pages in browser.

## Editing Guardrails
- Prefer editing source under `Controllers/`, `Views/`, `wwwroot/`, `Program.cs`.
- Do not edit build outputs in `bin/`, `obj/`, or IDE state in `.vs/`.
