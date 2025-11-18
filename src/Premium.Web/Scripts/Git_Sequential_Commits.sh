#!/bin/bash

echo "Initializing Git repository..."
git init

echo "Commit 1 — Initial solution scaffold"
git add .
git commit -m "Initial commit: Create .NET solution and empty MVC project structure"

echo "Commit 2 — Add core models"
git add src/Premium.Web/Models/
git commit -m "Add MemberViewModel, OccupationModel, and PremiumRequest models"

echo "Commit 3 — Add occupation factor provider"
git add src/Premium.Web/Services/OccupationFactorProvider.cs
git commit -m "Add OccupationFactorProvider with rating-factor mapping"

echo "Commit 4 — Add premium calculator service"
git add src/Premium.Web/Services/PremiumCalculatorService.cs
git commit -m "Add PremiumCalculatorService implementing formula logic"

echo "Commit 5 — Add service interfaces"
git add src/Premium.Web/Interfaces/
git commit -m "Add interfaces for premium calculator and occupation provider"

echo "Commit 6 — Register DI services"
git add src/Premium.Web/Program.cs
git commit -m "Register calculator and factor provider in dependency injection container"

echo "Commit 7 — Add HomeController"
git add src/Premium.Web/Controllers/HomeController.cs
git commit -m "Add HomeController for premium form UI"

echo "Commit 8 — Add API Controller"
git add src/Premium.Web/Controllers/PremiumApiController.cs
git commit -m "Add PremiumApiController with POST premium calculation"

echo "Commit 9 — Add Razor views"
git add src/Premium.Web/Views/
git commit -m "Add Razor UI for Premium Calculator (HTML/CSS/JS)"

echo "Commit 10 — Add JS for live premium calculation"
git add src/Premium.Web/wwwroot/js/premium.js
git commit -m "Add JS to auto-calc premium on occupation change"

echo "Commit 11 — Add validation"
git add src/Premium.Web/Models/ src/Premium.Web/Controllers/
git commit -m "Add client/server validation for mandatory fields"

echo "Commit 12 — Add unit tests"
git add tests/Premium.Tests/
git commit -m "Add xUnit tests for premium calculation and edge cases"

echo "Commit 13 — Add DB design doc"
git add docs/database_design.md
git commit -m "Add database design documentation"

echo "Commit 14 — Add project README"
git add README.md
git commit -m "Add README with project explanation, API, assumptions"

echo "Commit 15 — Cleanup"
git add .
git commit -m "Code cleanup: formatting, naming fixes, comments"

echo "Commit 16 — Final commit"
git commit --allow-empty -m "Final review updates"
