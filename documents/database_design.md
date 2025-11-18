# Database Design (ER)

## Tables

### Member
- MemberId (PK)
- Name
- AgeNextBirthday
- DateOfBirth
- OccupationId (FK -> Occupation.OccupationId)
- DeathSumInsured

### Occupation
- OccupationId (PK)
- OccupationName
- RatingId (FK -> OccupationRating.RatingId)

### OccupationRating
- RatingId (PK)
- RatingName
- Factor

Relationships:
- Member -> Occupation (many-to-one)
- Occupation -> OccupationRating (many-to-one)

# database design(Diagram Representation)

+------------------+
|   Occupation     |
+------------------+
| OccupationId PK  |
| OccupationName   |
| RatingId FK      |
+------------------+

+------------------+
| OccupationRating |
+------------------+
| RatingId PK      |
| RatingName       |
| Factor           |
+------------------+

+------------------+
|     Member       |
+------------------+
| MemberId PK      |
| Name             |
| AgeNextBirthday  |
| DateOfBirth      |
| OccupationId FK  |
| DeathSumInsured  |
+------------------+

