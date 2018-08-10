# Homely.HackDays.JSONAPI.Prototype

## Goals
1. Get all listings
https://localhost:44380/api/v1/listings

2. Get single listing
https://localhost:44380/api/v1/listings/1

3. Get single listing (limit fields)
https://localhost:44380/api/v1/listings?fields[listings]=title

4. Get single listing and include agents
https://localhost:44380/api/v1/listings/1?include=agents

5. Get single listing and include agents, and the agents office
FAIL: not supported by this library (yet). https://github.com/json-api-dotnet/JsonApiDotNetCore/issues/39

Cons:
- No deep nested support. Coming soon.