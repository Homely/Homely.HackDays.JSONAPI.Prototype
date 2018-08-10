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

Pros:
- Easy enough to get working

Cons:
- No deep nested support. Coming soon.

Questions:
- Where we would we use this? API Gateway, Microservices, or boh?
- How can we build specialized query endpoints? (e.g /listings/location/1). Would we just do `/listings?filter[locationId]=gt:1` ?

Next steps:
- Persistence (updating resources, JSON PATCH, etc)
- Caching
- Paging