# SPDX-FileCopyrightText: 2025 Shun Sakai
#
# SPDX-License-Identifier: Apache-2.0 OR MIT

# Run default recipe
_default:
    just -l

# Build a project
build:
    dotnet build

# Remove generated artifacts
clean:
    dotnet clean

# Run tests
test:
    dotnet test

# Run the formatter
fmt:
    dotnet format

# Build the project documentation
doc:
    docfx docs/docfx.json

# Run the linter for GitHub Actions workflow files
lint-github-actions:
    actionlint -verbose

# Run the formatter for the README
fmt-readme:
    npx prettier -w README.md

# Increment the version
bump part:
    bump-my-version bump {{ part }}
