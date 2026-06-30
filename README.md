# ReportManager
abstract class ReportManager:
contains:
    input:
        SourceType
        Timestamp
        Latitude
        Longitude
        Description
    automaticly:
        ReportId
        Status
        Priority
        Classification
        ReliabilityScore
        RejectionReason

inhareting objects:
    Drone:
        Altitude
        ImageQuality
    Soldier:
        SoldierName
        SoldierID
        Unit
        ConfidenceLevel
    Radar:
        Speed
        Direction
        Distance
    Signal:
        Frequency
        Content
        LanguageSignalStrength

Status must be (New, Validating, Validated, Rejected, InProgress, Completed)
Priority must be (Low, Medium, High, Critical)
Classification must be (Unclassified, Restricted, Secret, TopSecret)


# General Validation Rules

1. All fields marked as "Required" must exist and must not be empty.
2. `Timestamp` cannot be in the future.
3. `Timestamp` cannot be earlier than `2020-01-01`.
4. `Latitude` must be within the range `29.5000`–`33.5000`.
5. `Longitude` must be within the range `34.0000`–`36.0000`.
6. `Description` must contain between `10` and `500` characters.
7. `SourceType` must be one of:
   - `Drone`
   - `Soldier`
   - `Radar`
   - `Signal`

# Drone-Specific Rules

8. `Altitude` must be within the range `100`–`10000`.
9. `ImageQuality` must be within the range `1`–`100`.

# Soldier-Specific Rules

10. `SoldierName` must contain between `2` and `50` characters.
11. `SoldierID` must consist of exactly `7` digits.
12. `Unit` must contain between `2` and `50` characters.
13. `ConfidenceLevel` must be within the range `1`–`5`.

# Radar-Specific Rules

14. `Speed` must be within the range `0`–`2000`.
15. `Direction` must be within the range `0`–`360`.
16. `Distance` must be within the range `100`–`100000`.

# Signal-Specific Rules

17. `Frequency` must be within the range `1.0`–`3000.0`.
18. `Content` must contain between `5` and `1000` characters.
19. `Language` must be one of:
   - `Hebrew`
   - `Arabic`
   - `English`
   - `Russian`
   - `Other`
20. `SignalStrength` must be within the range `-120`–`0`.


functions on the main app: 
1. Add Report – Create a new report based on the source type.
2. Display Valid Reports – Show a list of reports with Status = Validated.
3. Search – Perform a free-text search in the Description field.
4. Filter – Filter reports by Status, Classification, Priority, SourceType, and Timestamp date range.
4. Sort – Sort reports by Timestamp, Priority, or ReliabilityScore.
5. Update Status – Change the Status to InProgress or Completed.
6. View Report Details – Display all fields of a single report.
7. Display Rejected Reports – Show a list of reports with Status = Rejected, including the RejectionReason.
8. Statistics – Display the number of reports by Status, Priority, and SourceType, as well as the percentage of valid reports.

