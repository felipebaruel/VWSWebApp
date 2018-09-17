$BodyStart = @'
{
    "Host":"www.google.com",
    "Port":80,
    "Connections":30,
}
'@

Invoke-RestMethod -Uri http://localhost:54985/api/SocketStart -Method Post -Body $BodyStart -ContentType "application/json"

Invoke-RestMethod -Uri http://localhost:54985/api/Socket -Method Get -ContentType "application/json"

Invoke-RestMethod -Uri http://localhost:54985/api/SocketStop -Method Get -ContentType "application/json"