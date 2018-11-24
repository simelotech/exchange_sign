install:
	nuget restore Lykke.Service.Skycoin.Sign.sln
	nuget install NUnit.Runners -Version 2.6.4 -OutputDirectory testrunner

  test: install
	msbuild /p:Configuration=Release Lykke.Service.Skycoin.Sign.sln
	msbuild /p:Configuration=Debug Lykke.Service.Skycoin.Sign.sln
	# mono ./testrunner/NUnit.Runners.2.6.4/tools/nunit-console.exe ./tests/Lykke.Service.Skycoin.API.Tests/obj/Release/netcoreapp2.1/Lykke.Service.Skycoin.API.Tests.dll -labels