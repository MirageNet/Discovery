<p align="center"><img src="https://i.imgur.com/KbXfvaN.png"></p>

[![Discord](https://img.shields.io/discord/809535064551456888.svg)](https://discord.gg/DTBPBYvexy)
[![release](https://img.shields.io/github/release/MirageNet/Discovery.svg)](https://github.com/MirageNet/Discovery/releases/latest)
[![Build](https://github.com/MirageNet/Discovery/workflows/CI/badge.svg)](https://github.com/MirageNet/Discovery/actions?query=workflow%3ACI)

<!--[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=MirrorNG_Discovery&metric=alert_status)](https://sonarcloud.io/dashboard?id=MirrorNG_Discovery)
[![SonarCloud Coverage](https://sonarcloud.io/api/project_badges/measure?project=MirrorNG_Discovery&metric=coverage)](https://sonarcloud.io/component_measures?id=MirrorNG_Discovery&metric=coverage)
[![Lines of Code](https://sonarcloud.io/api/project_badges/measure?project=MirrorNG_Discovery&metric=ncloc)](https://sonarcloud.io/dashboard?id=MirrorNG_Discovery)
[![Technical Debt](https://sonarcloud.io/api/project_badges/measure?project=MirrorNG_Discovery&metric=sqale_index)](https://sonarcloud.io/dashboard?id=MirrorNG_Discovery)
[![Code Smells](https://sonarcloud.io/api/project_badges/measure?project=MirrorNG_Discovery&metric=code_smells)](https://sonarcloud.io/dashboard?id=MirrorNG_Discovery)-->


Mirage Discovery is a plugin for Mirage to for games to automatically find each other within the same network

## Installation
The preferred installation method is Unity Package manager.

If you are using unity 2020.2 or later: 

1) Open your project in unity
2) Install [Mirage](https://github.com/MirageNet/Mirage)
3) Click on Windows -> Package Manager
4) Click on the plus sign on the left and click on "Add package from git URL..."
5) enter https://github.com/MirageNet/Discovery.git?path=/Assets/Discovery
6) Unity will download and install Mirage Discovery

Alternatively you can download it from [Releases](https://github.com/MirageNet/Discovery/releases).  You will need to install some dependencies yourself such as cecil.

## Usage

1) In Unity create a NetworkManager gameobject from the GameObject -> Networking -> NetworkManager.
2) Then remove the NetworkManagerHud (the default transport), and add a NetworkDiscoveryHud.

## Contributing

There are several ways to contribute to this project:

* Pull requests for bug fixes and features are always appreciated.
* Pull requests to improve the documentation is also welcome
* Make tutorials on how to use this
* Test it and open issues
* Review existing pull requests
* Donations

When contributing code, please keep these things in mind:

* [KISS](https://en.wikipedia.org/wiki/KISS_principle) principle. Everything needs to be **as simple as possible**. 
* An API is like a joke,  if you have to explain it is not a good one.  Do not require people to read the documentation if you can avoid it.
* Follow [C# code conventions](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/coding-conventions).
* Follow [SOLID principles](https://en.wikipedia.org/wiki/SOLID) as much as possible. 
* Keep your pull requests small and obvious,  if a PR can be split into several small ones, do so.

