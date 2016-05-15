# NUnit ASP.NET Embedded Test Runner #

An NUnit test runner which runs inside your ASP.NET application.

The test runner executes tests from the assembly in which it is compiled, thus requiring no configuration.

## Installation ##

The easiest way to add the test runner to your project is through [NuGet](https://www.nuget.org/packages/codeflood.nunit.aspnet.testrunner/).

Alternatively, add the files of this project into your test project, compile, deploy to your ASP.NET application, then access the `Test.aspx` page to use the runner.

## Usage ##

The test runner can be used manually by accessing the `Test.aspx` page using a web browser.

The test runner can also be orchestrated through query string parameters to facilitate build servers. The following query string parameters can be used:

| Parameter | Purpose | Example |
| fc | Pre-select category filters by value. Multiple values can be separated using pipes (`|`) | `fc=cat1|cat2` |
| fm | Pre-select method filters by value. Multiple values can be separated using pipes (`|`) | `fm=MyNamespace.MyTestFixture.MyTest` |
| run | Run the tests immediately | `run=true` |
