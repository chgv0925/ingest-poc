# Org.OpenAPITools - ASP.NET Core 2.0 Server

A sample API that uses a eventstore as an example to demonstrate features in the OpenAPI 3.0 specification

## Run

Linux/OS X:

```
sh build.sh
```

Windows:

```
build.bat
```
## Run in Docker

```
cd src/Org.OpenAPITools
docker build -t org.openapitools .
docker run -p 5000:8080 org.openapitools
```
