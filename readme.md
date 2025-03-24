## The Echo

* ... a simple echo server, while home-labbing - sometimes can get handy, either for testing the setup or as a placeholder *

[![Build status](https://awitec.visualstudio.com/Awitec/_apis/build/status/awitec.edgemq)](https://awitec.visualstudio.com/Awitec/_build/latest?definitionId=52)
![Docker Image Version](https://img.shields.io/docker/v/awitec/edgemq)

![logo](https://github.com/martinstanek/edgemq/blob/main/misc/ui.png?raw=true)


### Server

```
http://localhost:5027 -> returns page
http://localhost:5027/echo -> returns server time
http://localhost:5027/echo/your-message -> returns "your-message"
```
### Docker

Available Docker Tags: https://hub.docker.com/repository/docker/awitec/edgemq/tags

### Compose

```yml
services:

  echo:
    hostname: echo
    container_name: echo
    image: "awitec/echo:latest-arm64"
    ports:
      - "5027:5027"
    environment:
      - ECHO_TITLE=My Server
      - ECHO_MESSAGE=The site is under the construction.
    volumes:
      - /etc/localtime:/etc/localtime:ro
    restart: unless-stopped
```

Happy Echoing\
Martin