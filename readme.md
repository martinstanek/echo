## The Echo

*... a simple echo server. While home-labbing - sometimes this can get handy, either for testing of the setup or as a placeholder for the future website/service*

[![Build status](https://awitec.visualstudio.com/Awitec/_apis/build/status/awitec.echo)](https://awitec.visualstudio.com/Awitec/_build/latest?definitionId=55)
![Docker Image Version](https://img.shields.io/docker/v/awitec/echo)

![logo](https://github.com/martinstanek/echo/blob/main/misc/page.png?raw=true)

### Server

```
http://localhost -> returns the page
http://localhost/echo -> returns the server time
http://localhost/echo/your-message -> returns "your-message"
```
### Docker

Available Docker Tags: https://hub.docker.com/repository/docker/awitec/echo/tags

### Compose

```yml
services:

  echo:
    hostname: echo
    container_name: echo
    image: "awitec/echo:latest-arm64"
    ports:
      - "80:80"
    environment:
      - ECHO_TITLE=My Server
      - ECHO_MESSAGE=The site is under the construction.
    volumes:
      - /etc/localtime:/etc/localtime:ro
    restart: unless-stopped
```

Happy Echoing\
Martin