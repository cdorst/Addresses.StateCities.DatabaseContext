# Addresses.StateCities.DatabaseContext

[![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/addresses-statecities-databasecontext.svg?label=AppVeyor&style=for-the-badge)](https://ci.appveyor.com/project/cdorst/addresses-statecities-databasecontext)
[![NuGet package status](https://img.shields.io/nuget/v/CDorst.Addresses.StateCities.DatabaseContext.svg?label=NuGet&style=for-the-badge)](https://www.nuget.org/packages/CDorst.Addresses.StateCities.DatabaseContext)

## Description

EntityFrameworkCore database context for StateCity entities

## Environment Variables

This project depends on this environment variable:

Name | Description
---- | -----------
`LOCAL_NUGET_SOURCE_PATH` | *Required* to build the project, but not required during code execution. This is set to `c:\projects\nuget\cache` on the build server. On your development machine, set this to an empty, existing path. `dotnet restore` will inspect this folder prior to checking NuGet.

## Dependencies

Name | Status
---- | ------
[CDorst.Addresses.StateCities](https://github.com/CDorst/Addresses.StateCities) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/addresses-statecities.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst/addresses-statecities) [![NuGet package status](https://img.shields.io/nuget/v/CDorst.Addresses.StateCities.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst.Addresses.StateCities)
[CDorst.Addresses.Cities.DatabaseContext](https://github.com/CDorst/Addresses.Cities.DatabaseContext) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/addresses-cities-databasecontext.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst/addresses-cities-databasecontext) [![NuGet package status](https://img.shields.io/nuget/v/CDorst.Addresses.Cities.DatabaseContext.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst.Addresses.Cities.DatabaseContext)

## Dependents

The projects below use this repository as a direct dependency.

Name | Status
---- | ------
[Addresses.StateCities.ApiController](https://github.com/CDorst/Addresses.StateCities.ApiController) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/addresses-statecities-apicontroller.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst/addresses-statecities-apicontroller) [![NuGet package status](https://img.shields.io/nuget/v/CDorst.Addresses.StateCities.ApiController.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst.Addresses.StateCities.ApiController)
[Addresses.StateCityZips.DatabaseContext](https://github.com/CDorst/Addresses.StateCityZips.DatabaseContext) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/addresses-statecityzips-databasecontext.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst/addresses-statecityzips-databasecontext) [![NuGet package status](https://img.shields.io/nuget/v/CDorst.Addresses.StateCityZips.DatabaseContext.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst.Addresses.StateCityZips.DatabaseContext)

## NuGet


This project is published as a NuGet package at [https://www.nuget.org/packages/CDorst.Addresses.StateCities.DatabaseContext](https://www.nuget.org/packages/CDorst.Addresses.StateCities.DatabaseContext)

## Version

1.0.1

## Metaproject

Addresses.StateCities.DatabaseContext is maintained by robots and exists because of a declarative template metaproject. View the metaproject's component directory at [https://github.com/CDorst/Project.Index](https://github.com/CDorst/Project.Index)

