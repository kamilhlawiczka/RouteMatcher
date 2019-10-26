# RouteMatcher


## Installing

Sign in to https://developer.here.com/ and get secrets for `REST & XYZ HUB API/CLI`

Open command line then type:

```bash
git clone https://github.com/kamilhlawiczka/RouteMatcher.git
cd RouteMatcher/RouteMatcher

dotnet user-secrets set "ApiHereCom:AppCode" "<your_app_code>" 
dotnet user-secrets set "ApiHereCom:AppId" "<your_app_ip>"

dotnet run
```
---

## Example of usage
Get available routes
```
https://localhost:5001/api/routes
```

Get details routes
```
https://localhost:5001/api/routes/2_Points

```

Get details routes with route matching
```
https://localhost:5001/api/routes/2_Points/routematch

```

