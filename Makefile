
APP = bin/Debug/netcoreapp3.0/sharp-md

default: ${APP}

${APP}: *.cs
	@dotnet build

run: ${APP}
	@./${APP}

clean:
	@rm -rf bin


