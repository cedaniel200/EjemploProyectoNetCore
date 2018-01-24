FROM microsoft/dotnet:2.0-runtime
ARG source
WORKDIR /app
RUN mkdir data
COPY /bin/Release/netcoreapp2.0 .
ENTRYPOINT ["dotnet", "ConsoleApp1.dll"]
