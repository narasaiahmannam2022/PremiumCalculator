# Premium Calculator Solution

## Overview
This repository contains ASP.NET Core MVC solution that implements the Premium Calculator coding task.

### Tech stack
- .NET 8.0  framework
- C# ASP.NET Core MVC
- Razor views for UI
- xUnit for unit tests
- No database required; occupation factors are in-memory.

## How to run
1. Install .NET 8 SDK from https://dotnet.microsoft.com/.
2. Extract the zip and open a terminal in `src/Premium.Web`.
3. Run:
   ```bash
   dotnet restore
   dotnet run
   ```
4.Open https://localhost:5001 or the URL displayed..

## What is included
- `Program.cs` - app bootstrap
- `Controllers/HomeController.cs` - UI and calculate endpoint
- `Controllers/PremiumController.cs` - API endpoint (POST /api/premium/calculate)
- `Services/` - contains PremiumCalculatorService and occupation factor provider
- `Views/` - Razor UI
- `wwwroot/css/site.css` - styling
- `tests/` - xUnit test project 
- `Scripts/Git_Sequential_Commits.sh` - Git Sequential Commits

## Formula used
Premium = (DeathSumInsured * RatingFactor * AgeNextBirthday) / 1000 * 12

## Occupations and rating factors
Occupations mapping:
- Cleaner -> Light Manual (11.50)
- Doctor -> Professional (1.50)
- Author -> White Collar (2.25)
- Farmer -> Heavy Manual (31.75)
- Mechanic -> Heavy Manual (31.75)
- Florist -> Light Manual (11.50)
- Other -> Heavy Manual (31.75)

Factors:
- Professional: 1.5
- White Collar: 2.25
- Light Manual: 11.50
- Heavy Manual: 31.75

## Database design (diagram)
Tables suggested:
- Member (MemberId PK, Name, AgeNextBirthday, DateOfBirth, OccupationId FK, DeathSumInsured)
- Occupation (OccupationId PK, OccupationName, RatingId FK)
- OccupationRating (RatingId PK, RatingName, Factor)

## Assumptions & Notes
- All input fields are mandatory. Client-side and server-side validation included.
- Changing occupation triggers premium calculation (handled on `change` event).
- DOB is captured as MM/YYYY with an HTML month input; no date math is performe.
- For production you'd persist members & occupations to a database; this keeps things in-memory for clarity.
- Unit tests: edge cases

## Git guidance
-'Scripts/Git_Sequential_Commits.sh` - Git Sequential Commits is listed.

