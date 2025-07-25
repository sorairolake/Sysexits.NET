<!--
SPDX-FileCopyrightText: 2025 Shun Sakai

SPDX-License-Identifier: CC-BY-4.0
-->

# Sysexits.NET

[![CI][ci-badge]][ci-url]
[![Version][version-badge]][version-url]

**Sysexits.NET** ([`Sysexits`][version-url]) is a library that provides the
system exit code constants as defined by [`<sysexits.h>`].

This library is a port of [sysexits-rs].

## Usage

Run the following command in your project directory:

```sh
dotnet package add Sysexits
```

### Documentation

See the [documentation][docs-url] for more details.

## Source code

The upstream repository is available at
<https://github.com/sorairolake/Sysexits.NET.git>.

## Changelog

Please see [CHANGELOG.adoc].

## Contributing

Please see [CONTRIBUTING.adoc].

## License

Copyright (C) 2025 Shun Sakai (see [AUTHORS.adoc])

This library is distributed under the terms of either the _Apache License 2.0_
or the _MIT License_.

This project is compliant with version 3.3 of the [_REUSE Specification_]. See
copyright notices of individual files for more details on copyright and
licensing information.

[ci-badge]: https://img.shields.io/github/actions/workflow/status/sorairolake/Sysexits.NET/CI.yaml?branch=develop&style=for-the-badge&logo=github&label=CI
[ci-url]: https://github.com/sorairolake/Sysexits.NET/actions?query=branch%3Adevelop+workflow%3ACI++
[version-badge]: https://img.shields.io/nuget/v/Sysexits?style=for-the-badge&logo=nuget
[version-url]: https://www.nuget.org/packages/Sysexits
[`<sysexits.h>`]: https://man.openbsd.org/sysexits
[sysexits-rs]: https://crates.io/crates/sysexits
[docs-url]: https://sorairolake.github.io/Sysexits.NET/
[CHANGELOG.adoc]: CHANGELOG.adoc
[CONTRIBUTING.adoc]: CONTRIBUTING.adoc
[AUTHORS.adoc]: AUTHORS.adoc
[_REUSE Specification_]: https://reuse.software/spec-3.3/
