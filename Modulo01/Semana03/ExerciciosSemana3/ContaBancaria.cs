SELECT * FROM "Occurrence" 
INNER JOIN "OccurrenceLog" ON "OccurrenceLog"."OccurrenceId" = "Occurrence"."Id" 
INNER JOIN "Account" ON "Account"."Id" = "Occurrence"."AccountId" 
INNER JOIN "Event" ON "Event"."Id" = "Occurrence"."EventId" 
WHERE "Occurrence"."Id" = 1125