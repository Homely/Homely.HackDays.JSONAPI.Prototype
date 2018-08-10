# Homely.HackDays.JSONAPI.Prototype
https://homely-jsonapi-prototype.azurewebsites.net

## Goals
1. Get all listings
https://homely-jsonapi-prototype.azurewebsites.net/api/v1/listings

2. Get single listing
https://homely-jsonapi-prototype.azurewebsites.net/api/v1/listings/1

3. Get single listing (limit fields)
https://homely-jsonapi-prototype.azurewebsites.net/api/v1/listings?fields[listings]=title

4. Get single listing and include agents
https://homely-jsonapi-prototype.azurewebsites.net/api/v1/listings/1?include=agents

5. Get single listing and include agents, and the agents office
FAIL: not supported by this library (yet). https://github.com/json-api-dotnet/JsonApiDotNetCore/issues/39

Cons:
- No deep nested support. Coming soon.