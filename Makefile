.DEFAULT_GOAL := help
.PHONY: configure build run test help
.PHONY: install install-deps install-deps-test

configure: ## Setup build environment

install: install-deps build ## Install project artifacts from sources
	nuget restore Lykke.Service.Skycoin.Sign.sln

install-deps: ## Install run-time dependencies
	nuget install LibSkycoinNet

install-deps-test: ## Install dependencies for testing
	nuget install NUnit.Runners -Version 2.6.4 -OutputDirectory testrunner

build: ## Build project artifacts
	# TODO: Implement

run-test-services: ## Run Docker containers (mongo, redis, skycoin/skycoin) for testing
	# TODO: Implement

run: build ## Run Lykke.Skycoin.Sign service
	# TODO: Implement

stop-test-services: ## Stop Docker containers (mongo, redis, skycoin/skycoin) for testing
	# TODO: Implement

test: install-deps
	msbuild /p:Configuration=Release Lykke.Service.Skycoin.Sign.sln
	msbuild /p:Configuration=Debug Lykke.Service.Skycoin.Sign.sln

help:
	@grep -E '^[a-zA-Z_-]+:.*?## .*$$' $(MAKEFILE_LIST) | awk 'BEGIN {FS = ":.*?## "}; {printf "\033[36m%-30s\033[0m %s\n", $$1, $$2}'
