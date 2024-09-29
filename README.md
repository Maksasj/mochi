# 🍡 mochi

**mochi** is a minimalistic logging microservice built with **ASP.NET Core**. Designed to handle logging needs across distributed services, **mochi** provides a lightweight and efficient solution for tracking and managing log data in a microservices environment.

Cool looking widgets 
![GitHub Actions Workflow Status](https://img.shields.io/github/actions/workflow/status/Maksasj/mochi/test.yml?logo=github&label=build)
![GitHub License](https://img.shields.io/github/license/Maksasj/mochi)
![Unit Test Coverage](https://img.shields.io/endpoint?url=https://gist.githubusercontent.com/Maksasj/58977bdd8994a6eaaa2345e9a70c33d6/raw/mochi-code-coverage.json)
![GitHub Repo stars](https://img.shields.io/github/stars/Maksasj/mochi?style=flat)

### Links

1. Source code available at [github.com/Maksasj/mochi](https://github.com/Maksasj/mochi)

## Features
- **Minimalist Design**: Lightweight and easy to integrate with your existing services.
- **Scalable**: Designed for scalability in distributed systems and microservices architectures.
- **RESTful API**: Clean, easy-to-use API for interfacing with file services.
- **Cross-service Logging**: Seamlessly logs information from different services to a centralized endpoint.

## Developing

Please make sure you have the following prerequisites:
  - A desktop platform with the [.NET 8.0 SDK](https://dotnet.microsoft.com/download) installed
  - Version control tool [Git](https://git-scm.com/)

### Running with docker
```bash
docker build -t mochi .
docker run -p 7417:8080 mochi
```

## Contribution

When it comes to contributing to the project, the two main things you can do to help out are reporting issues and submitting pull requests.

If you have any questions, feel free to to submit [issue](https://github.com/Maksasj/mochi/issues) or message [author](https://github.com/Maksasj) on social medias.

## License

**mochi** is free and open source software. All code in this repository is licensed under
-  Apache-2.0 license ([LICENSE.md](https://github.com/Maksasj/mochi/blob/master/LICENSE.md) or http://www.apache.org/licenses/LICENSE-2.0)

*Copyright 2024 © Maksim Jaroslavcevas*

